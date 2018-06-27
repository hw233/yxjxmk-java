<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,java.text.SimpleDateFormat,com.wanniu.paycenter.bean.LostOrderPO"%>
<%@ page
	import="java.util.*,java.io.*,com.wanniu.paycenter.utils.*,com.wanniu.paycenter.bean.OrderPO"%>
<%@ page import="net.sf.json.JSONObject,com.wanniu.paycenter.queue.*"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%@ page import="com.wanniu.paycenter.bean.OrderDetailPO"%>
<%
	Logger logger = Logger.getLogger("AppStoreNotify");
	Logger logger_error = Logger.getLogger("appstoreAskError");
	logger.info("received one AppStoreNotify");
	DataInputStream is = new DataInputStream(request.getInputStream());
	byte[] data = new byte[4096];
	byte[] buf = new byte[2048];
	int sum = 0;
	int len = 0;
	while (true) {
		len = is.read(buf);
		if (len == 0)
			continue;
		if (len == -1) {
			break;
		}
		System.arraycopy(buf, 0, data, sum, len);
		sum += len;
	}
	String encryptdata = Encoder.decode(data, sum);
	String jsonStr = encryptdata.substring(encryptdata.indexOf("transaction={") + 12);
	encryptdata = encryptdata.substring(0, encryptdata.indexOf("&transaction={"));
	HashMap<String, String> parameters = new HashMap<String, String>();
	java.util.StringTokenizer st = new java.util.StringTokenizer(encryptdata, "&");
	while (st.hasMoreTokens()) {
		String temp[] = st.nextToken().split("=");
		if (temp.length > 1) {
			parameters.put(temp[0], temp[1]);
		}
	}
	String money = parameters.get("money");
	String username = parameters.get("username");
	String channel = parameters.get("channel");
	String appid = parameters.get("appid");
	String serverid = parameters.get("serverid");
	String roleid = parameters.get("roleid");
	String expand = parameters.get("expand");
	String mac = parameters.get("mac");
	String logData = "recvAppStore:appid=" + appid + "&money=" + money + "&username=" + username + "&roleid="
			+ roleid + "&channel=" + channel + "&serverid=" + serverid + "&expand=" + expand + "&mac=" + mac
			+ "&transaction=" + jsonStr;
	logger.info(logData);
	JSONObject jnb = JSONObject.fromObject(jsonStr);
	String purchase = jnb.getString("purchase-info");
	String pase_result = Base64Util.getString(purchase);
	jnb = JSONObject.fromObject(pase_result);
	String transaction_id = jnb.getString("transaction-id");
	String receipt_data = UmpBase64.encode(jsonStr.getBytes());
	String checkUrl = "https://buy.itunes.apple.com/verifyReceipt";
	String requestData = "{\"receipt-data\":";
	requestData += "\"" + receipt_data + "\"";
	requestData += "}";
	logger.info("验证单据：" + requestData);
	String res = HttpUtil.requetPost(checkUrl, requestData);
	logger.info("app_storeResponseInfo:" + res);
	out.clearBuffer();
	PayDao paydao = new PayDao();
	OrderDetailsDao detailsDao = new OrderDetailsDao();//用来记录订单操作明细的DAO
	OrderDetailPO details = new OrderDetailPO(transaction_id, money, "44", channel, appid, username, roleid,
			serverid, expand, "CNY", "", "", "");
	details.setF_ReceiveReqMsg(logData);
	detailsDao.recordCreateOrderInfo(details);//苹果没有下单流程，回调时先记录下基本信息
	if (res == null || "".equals(res)) {
		logger_error.info("appid=" + appid + "&roleid=" + roleid + "&expand=" + expand + "&money=" + money
				+ "&username=" + username + "&channel=" + channel + "&serverid=" + serverid + "&data="
				+ requestData + "&res=" + res);
		String errInfo = "app_store订单" + transaction_id + "支付失败,res:" + res + ",username:" + username;
		logger.info(errInfo);
		LostOrderPO lostOrder = new LostOrderPO(appid, roleid, expand, money, username, channel, serverid,
				requestData, transaction_id);
		paydao.saveIosLostOrder(lostOrder);
		//加入重复队列.
		IosLostOrderThread.put(lostOrder);
		out.write(transaction_id);
		details.setF_ReceiveErrMsg(errInfo);
		details.setF_ReceiveResponseMsg(transaction_id + "||苹果平台验证响应信息为空，该订单已经放入重复请求队列");
		details.setF_ReceiveState("-2");
		details.setF_Money(money);
		details.setF_PayChannelOrderID(transaction_id);
		detailsDao.updateOnReceive(details);
		return;
	}
	jnb = JSONObject.fromObject(res);
	String status = jnb.getString("status");
	if (status.equals("0")) {//支付成功
		String product_id = jnb.getJSONObject("receipt").get("product_id").toString();
		String copOrder = jnb.getJSONObject("receipt").get("transaction_id").toString();
		String bid = jnb.getJSONObject("receipt").get("bid").toString();
		String original_purchase_date = jnb.getJSONObject("receipt").get("original_purchase_date").toString();
		original_purchase_date = original_purchase_date.substring(0, 10);
		SimpleDateFormat sf = new SimpleDateFormat("yyyy-MM-dd");
		Date before_four_date = sf.parse(DateUtil.getBeforeToday(5));
		Date order_date = sf.parse(original_purchase_date);
		String[] paseResult = AppUtil.getAppStoreByGameId(appid, product_id);
		String amount = paseResult[1];
		if (channel.equals("1750")) {//X三国又打了个新包，就渠道号、包名、购买项生变化
			paseResult[0] = "com.morefun.fqxsg";
		} else if (channel.equals("1751")) {//X三国又打了个新包，就渠道号、包名、购买项生变化
			paseResult[0] = "com.blsg.fytx";
		}
		if (!bid.equals(paseResult[0])) {
			out.write(transaction_id);
			details.setF_ReceiveState("-2");
			details.setF_ReceiveErrMsg("包名不匹配，数据异常");
			details.setF_ReceiveResponseMsg(transaction_id);
			details.setF_Money(amount);
			details.setF_PayChannelOrderID(transaction_id);
			detailsDao.updateOnReceive(details);
			return;
		}
		if (!order_date.after(before_four_date)) {
			String err = "app订单" + copOrder + "已过期." + original_purchase_date + ",username=" + username;
			logger_error.info(err);
			out.write(transaction_id);
			details.setF_ReceiveErrMsg(err);
			details.setF_ReceiveResponseMsg(transaction_id);
			details.setF_ReceiveState("-2");
			details.setF_Money(amount);
			details.setF_PayChannelOrderID(transaction_id);
			detailsDao.updateOnReceive(details);
			return;
		}
		//生成美峰订单号
		String order_id = transaction_id;
		if (appid.equals("7") || appid.equals("50")) {
			expand = product_id;
		}
		OrderPO order = new OrderPO(username, roleid, Double.parseDouble(amount), order_id, 44, 44, appid,
				serverid, transaction_id, 5, 4, 0, expand);
		order.setCopChannel(Integer.parseInt(channel));
		paydao.CallBackOrderUnCheck(order);
		logger.info("username:" + username + ",appStore_order:" + copOrder + "支付成功.");
		details.setF_ReceiveState("2");
		details.setF_Money(amount);
		details.setF_ReceiveResponseMsg(transaction_id);
		details.setF_PayChannelOrderID(transaction_id);
	} else {//支付失败
		String err = "app_store订单" + transaction_id + "支付失败,status:" + status + ",username:" + username;
		logger.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveState("-2");
		details.setF_PayChannelOrderID(transaction_id);
		details.setF_ReceiveResponseMsg("fail");
	}
	out.write(transaction_id);
	detailsDao.updateOnReceive(details);
%>