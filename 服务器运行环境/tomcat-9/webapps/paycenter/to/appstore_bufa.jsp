<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,java.text.SimpleDateFormat"%>
<%@ page
	import="java.util.*,java.io.*,com.wanniu.paycenter.utils.*,com.wanniu.paycenter.bean.OrderPO"%>
<%@ page import="net.sf.json.JSONObject"%>
<%
	Logger logger = Logger.getLogger("bufa");
	Logger logger_error = Logger.getLogger("bufaError");
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
	logger.info("recvAppStore:appid=" + appid + "&money=" + money + "&username=" + username + "&roleid="
			+ roleid + "&channel=" + channel + "&serverid=" + serverid + "&expand=" + expand + "&mac=" + mac
			+ "&transaction=" + jsonStr);
	String checkUrl = "https://buy.itunes.apple.com/verifyReceipt";
	String requestData = jsonStr;
	String res = HttpUtil.requetPost(checkUrl, requestData);
	logger.info("app_storeResponseInfo:" + res);
	out.clearBuffer();
	JSONObject jnb = JSONObject.fromObject(res);
	String status = jnb.getString("status");
	String transaction_id = "";
	if (status.equals("0")) {//支付成功
		String product_id = jnb.getJSONObject("receipt").get("product_id").toString();
		String copOrder = jnb.getJSONObject("receipt").get("transaction_id").toString();
		transaction_id = copOrder;
		String bid = jnb.getJSONObject("receipt").get("bid").toString();
		String original_purchase_date = jnb.getJSONObject("receipt").get("original_purchase_date").toString();
		original_purchase_date = original_purchase_date.substring(0, 10);
		SimpleDateFormat sf = new SimpleDateFormat("yyyy-MM-dd");
		Date before_four_date = sf.parse(DateUtil.getBeforeToday(20));
		Date order_date = sf.parse(original_purchase_date);
		String[] paseResult = AppUtil.getAppStoreByGameId(appid, product_id);
		String amount = paseResult[1];
		if (!bid.equals(paseResult[0])) {
			out.write(transaction_id);
			return;
		}
		if (!order_date.after(before_four_date)) {
			logger_error.info("app订单" + copOrder + "已过期." + original_purchase_date + ",username=" + username);
			out.write(transaction_id);
			return;
		}
		PayDao paydao = new PayDao();
		//生成美峰订单号
		String order_id = transaction_id;
		if (appid.equals("7") || appid.equals("51")) {
			expand = product_id;
		}
		OrderPO order = new OrderPO(username, roleid, Double.parseDouble(amount), order_id, 44, 44, appid,
				serverid, transaction_id, 5, 4, 0, expand);
		order.setCopChannel(Integer.parseInt(channel));
		paydao.CallBackOrderUnCheck(order);
		logger.info("username:" + username + ",appStore_order:" + copOrder + "支付成功.");
	} else {//支付失败
		logger.info("app_store订单" + transaction_id + "支付失败,status:" + status + ",username:" + username);
	}
	out.write(transaction_id);
%>