<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,java.text.SimpleDateFormat,com.wanniu.paycenter.bean.LostOrderPO"%>
<%@ page
	import="java.util.*,java.io.*,com.wanniu.paycenter.utils.*,com.wanniu.paycenter.bean.OrderPO"%>
<%@ page
	import="net.sf.json.JSONObject,com.wanniu.paycenter.queue.IosLostOrderThread"%>
<%
	Logger logger = Logger.getLogger("AppStoreMannualNotify");
	Logger logger_error = Logger.getLogger("appstoreMannualAskError");

	String money = "198";
	String username = "wclovesty.mf";
	String channel = "1706";
	String appid = "65";
	String serverid = "200004";
	String roleid = "IOS-200004-2260556";
	String expand = "{\"item\":4,\"mac\":\"F5794311-5D86-4959-AE40-2AF8BF28F8F3\"}";
	String mac = "F5794311-5D86-4959-AE40-2AF8BF28F8F3";
	String jsonStr = "{";
	jsonStr += "\n"
			+ "\"signature\" = \"Aoe6u90n8yl6twvZpEcFQGtqpMLaEwPyuB3gWsGRM4nDkURkJKd0XidyUzInQtls12pHxMce5O1QWGe9uDCVrUUFUbTdLwaYsRdbq+OBjjXq/cBjagYPo7fsCSg6IgyPCckzy13kKfo3XfuNbvqRDyRHLGVaEyn5nF/LNfJgTZ+OAAADVzCCA1MwggI7oAMCAQICCBup4+PAhm/LMA0GCSqGSIb3DQEBBQUAMH8xCzAJBgNVBAYTAlVTMRMwEQYDVQQKDApBcHBsZSBJbmMuMSYwJAYDVQQLDB1BcHBsZSBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eTEzMDEGA1UEAwwqQXBwbGUgaVR1bmVzIFN0b3JlIENlcnRpZmljYXRpb24gQXV0aG9yaXR5MB4XDTE0MDYwNzAwMDIyMVoXDTE2MDUxODE4MzEzMFowZDEjMCEGA1UEAwwaUHVyY2hhc2VSZWNlaXB0Q2VydGlmaWNhdGUxGzAZBgNVBAsMEkFwcGxlIGlUdW5lcyBTdG9yZTETMBEGA1UECgwKQXBwbGUgSW5jLjELMAkGA1UEBhMCVVMwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBAMmTEuLgjimLwRJxy1oEf0esUNDVEIe6wDsnnal14hNBt1v195X6n93YO7gi3orPSux9D554SkMp+Sayg84lTc362UtmYLpWnb34nqyGx9KBVTy5OGV4ljE1OwC+oTnRM+QLRCmeNxMbPZhS47T+eZtDEhVB9usk3+JM2Cogfwo7AgMBAAGjcjBwMB0GA1UdDgQWBBSJaEeNuq9Df6ZfN68Fe+I2u22ssDAMBgNVHRMBAf8EAjAAMB8GA1UdIwQYMBaAFDYd6OKdgtIBGLUyaw7XQwuRWEM6MA4GA1UdDwEB/wQEAwIHgDAQBgoqhkiG92NkBgUBBAIFADANBgkqhkiG9w0BAQUFAAOCAQEAeaJV2U51rxfcqAAe5C2/fEW8KUl4iO4lMuta7N6XzP1pZIz1NkkCtIIweyNj5URYHK+HjRKSU9RLguNl0nkfxqObiMckwRudKSq69NInrZyCD66R4K77nb9lMTABSSYlsKt8oNtlhgR/1kjSSRQcHktsDcSiQGKMdkSlp4AyXf7vnHPBe4yCwYV2PpSN04kboiJ3pBlxsGwV/ZlL26M2ueYHKYCuXhdqFwxVgm52h3oeJOOt/vY4EcQq7eqHm6m03Z9b7PRzYM2KGXHDmOMk7vDpeMVlLDPSGYz1+U3sDxJzebSpbaJmT7imzUKfggEY7xxf4czfH0yj5wNzSGTOvQ==\";";
	jsonStr += "\n"
			+ "\"purchase-info\" = \"ewoJIm9yaWdpbmFsLXB1cmNoYXNlLWRhdGUtcHN0IiA9ICIyMDE1LTA2LTE2IDA2OjU2OjI0IEFtZXJpY2EvTG9zX0FuZ2VsZXMiOwoJInB1cmNoYXNlLWRhdGUtbXMiID0gIjE0MzQ0NjI5ODQzMjMiOwoJInVuaXF1ZS1pZGVudGlmaWVyIiA9ICI0M2Y2MDQ0YWU1NmJhNDNiZDUxZTZkYTY0N2JlYWUwMDQzN2NhZDk1IjsKCSJvcmlnaW5hbC10cmFuc2FjdGlvbi1pZCIgPSAiNDcwMDAwMDk2Njc2MTc1IjsKCSJidnJzIiA9ICIxLjMuNiI7CgkiYXBwLWl0ZW0taWQiID0gIjk1NzI2MjU4MyI7CgkidHJhbnNhY3Rpb24taWQiID0gIjQ3MDAwMDA5NjY3NjE3NSI7CgkicXVhbnRpdHkiID0gIjEiOwoJIm9yaWdpbmFsLXB1cmNoYXNlLWRhdGUtbXMiID0gIjE0MzQ0NjI5ODQzMjMiOwoJInVuaXF1ZS12ZW5kb3ItaWRlbnRpZmllciIgPSAiM0MyM0UyNTEtODYxOC00MkY3LThDQzEtMUYzNTNCMjA2RDc4IjsKCSJpdGVtLWlkIiA9ICI5NjY3NjQxNzYiOwoJInZlcnNpb24tZXh0ZXJuYWwtaWRlbnRpZmllciIgPSAiODEyNDA1MzkwIjsKCSJwcm9kdWN0LWlkIiA9ICJjb20uamltZWkueHNhbmd1b19JT1NfQ05fMTk4IjsKCSJwdXJjaGFzZS1kYXRlIiA9ICIyMDE1LTA2LTE2IDEzOjU2OjI0IEV0Yy9HTVQiOwoJIm9yaWdpbmFsLXB1cmNoYXNlLWRhdGUiID0gIjIwMTUtMDYtMTYgMTM6NTY6MjQgRXRjL0dNVCI7CgkiYmlkIiA9ICJjb20uamltZWkueHNhbmd1byI7CgkicHVyY2hhc2UtZGF0ZS1wc3QiID0gIjIwMTUtMDYtMTYgMDY6NTY6MjQgQW1lcmljYS9Mb3NfQW5nZWxlcyI7Cn0=\";";
	jsonStr += "\n" + "\"pod\" = \"47\";";
	jsonStr += "\n" + "\"signing-status\" = \"0\";";
	jsonStr += "\n" + "}";
	logger.info("recvAppStore:appid=" + appid + "&money=" + money + "&username=" + username + "&roleid="
			+ roleid + "&channel=" + channel + "&serverid=" + serverid + "&expand=" + expand + "&mac=" + mac
			+ "&transaction=" + jsonStr);
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
	String res = HttpUtil.requetPost(checkUrl, requestData);
	logger.info("app_storeResponseInfo:" + res);
	out.clearBuffer();
	PayDao paydao = new PayDao();
	if (res == null || "".equals(res)) {
		logger_error.info("appid=" + appid + "&roleid=" + roleid + "&expand=" + expand + "&money=" + money
				+ "&username=" + username + "&channel=" + channel + "&serverid=" + serverid + "&data="
				+ requestData + "&res=" + res);
		logger.info("app_store订单" + transaction_id + "支付失败,res:" + res + ",username:" + username);
		LostOrderPO lostOrder = new LostOrderPO(appid, roleid, expand, money, username, channel, serverid,
				requestData, transaction_id);
		paydao.saveIosLostOrder(lostOrder);
		//加入重复队列.
		IosLostOrderThread.put(lostOrder);
		out.write(transaction_id);
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
		if (!bid.equals(paseResult[0])) {
			out.write(transaction_id);
			return;
		}
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