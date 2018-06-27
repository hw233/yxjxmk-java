<%@page import="java.util.Base64"%>
<%@ page contentType="text/html;charset=UTF-8" pageEncoding="UTF-8"
	import="com.wanniu.paycenter.res.*,java.io.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.*,com.wanniu.paycenter.utils.*,java.net.*"%>
<%@ page import="net.sf.json.JSONObject,com.wanniu.paycenter.utils.Md5"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	final int PAYMENT_ID = 61;
	Logger log = Logger.getLogger("hoolaiNotify");
	String ip = request.getRemoteHost();
	String order_id = request.getParameter("order_id");
	String parent_channel = request.getParameter("parent_channel");
	String channel = request.getParameter("channel");
	String product_id = request.getParameter("product_id");
	String channel_id = request.getParameter("channel_id");
	String channel_app_id = request.getParameter("channel_app_id");
	String uid = request.getParameter("uid");
	String channelUid = request.getParameter("channelUid");
	String pay_date = request.getParameter("pay_date");
	String amount = request.getParameter("amount");
	String currency_unit = request.getParameter("currency_unit");
	String currency = request.getParameter("currency");
	String appstore_product_id = request.getParameter("appstore_product_id");
	String cp_order_id = request.getParameter("callback_info");
	String sign = request.getParameter("sign");
	out.clearBuffer();

	String orgOrderId = cp_order_id.replace("-", "+").replace("_", "/").replace(".", "=");
	orgOrderId = new String(Base64.getDecoder().decode(orgOrderId));//base64转码
	String osid = orgOrderId.substring(orgOrderId.length() - 5, orgOrderId.length() - 4);
	String mf_appid = (orgOrderId.substring(orgOrderId.length() - 13, orgOrderId.length() - 9));
	String key = PartnerManager.getInstance().getSecretKey(String.valueOf(PAYMENT_ID), mf_appid, osid);
	//有参数名按字母顺序进行排序
	String params = SignUtil.sortParams(request.getParameterMap());
	String msg = params;
	params += "product_key=" + key;
	log.info("strMd5:" + params);
	String mfsign = Md5.getUCMD5Str(params);

	OrderDetailPO details = new OrderDetailPO(orgOrderId, amount, order_id, msg, "", "");
	OrderDetailsDao detailsDao = new OrderDetailsDao();
	if (!mfsign.equalsIgnoreCase(sign)) {
		String err = "hoolai订单" + orgOrderId + "验证不通过";
		log.info(err);
		out.write("fail");
		details.setF_ReceiveState("-2");
		details.setF_ReceiveResponseMsg("fail");
		details.setF_ReceiveErrMsg(err);
		return;
	}

	//验证订单是否过期
	boolean is_Expired = DateUtil.checkOrderDate(orgOrderId, 5);
	if (is_Expired) {
		out.write("timeout");
		String err = "hoolai:" + orgOrderId + "已过期.";
		log.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("-2");
		detailsDao.updateOnReceive(details);//记录订单操作明细
		return;
	}
	PayDao paydao = new PayDao();
	RecvResult recvResult = new RecvResult(1, orgOrderId, Double.parseDouble(amount), "", PAYMENT_ID, "");//payType=98???TODO
	paydao.callBack(recvResult);
	out.write("ok");
	log.info("hoolai订单" + orgOrderId + "处理成功");
	details.setF_ReceiveResponseMsg("success");
	details.setF_ReceiveState("2");
	detailsDao.updateOnReceive(details);//记录订单操作明细
%>