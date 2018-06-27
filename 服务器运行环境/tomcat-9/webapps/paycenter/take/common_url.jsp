<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.ApplicationCO"%>
<%@ page
	import="java.util.*,com.wanniu.paycenter.utils.*,com.wanniu.paycenter.bean.OrderPO,java.io.*,com.wanniu.paycenter.res.Constants"%>
<%@ page import="com.wanniu.paycenter.bean.OrderDetailPO"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	Logger logger = Logger.getLogger("common_url");
	String appid = request.getAttribute("appid").toString();
	String channel = request.getAttribute("channel").toString();
	String money = request.getAttribute("money").toString();
	String username = request.getAttribute("username").toString();
	String serverid = request.getAttribute("serverid").toString();
	String roleid = request.getAttribute("roleid").toString();
	String expand = (String) request.getAttribute("expand");
	String cop_expand = (String) request.getAttribute("cop_expand");
	String payment = request.getAttribute("payment").toString();
	String mac = (String) request.getAttribute("mac");
	String msg = "common_url:appid=" + appid + "&payment=" + payment + "&channel=" + channel + "&money=" + money
			+ "&username=" + username + "&serverid=" + serverid + "&roleid=" + roleid + "&expand=" + expand
			+ "&cop_expand=" + cop_expand + "&mac=" + mac;
	logger.info(msg);
	out.clearBuffer();
	PayDao payDao = new PayDao();
	String order_id = DateUtil.getOrderID(appid, null);

	//---modify by luoqi 2015-12-04
	OrderDetailPO details = new OrderDetailPO(order_id, money, payment, channel, appid, username, roleid,
			serverid, expand, "CNY", msg, "", "");
	OrderDetailsDao detailsDao = new OrderDetailsDao();
	if ("".equals(order_id) || order_id == null) {
		details.setF_OrderState("-1");
		details.setF_CreateOrderErrMsg("下单失败，获取到的订单号为空");
	} else {
		details.setF_OrderState("1");
	}
	OrderPO orderInfo = new OrderPO(username, Double.parseDouble(money), roleid, order_id,
			Integer.parseInt(payment), Integer.parseInt(payment), appid, Integer.parseInt(channel), serverid,
			null, expand);
	payDao.creatOrder(orderInfo);
	out.write(order_id + "," + PartnerManager.getInstance().getCallBackUrl(payment));
	details.setF_CreateOrderResponseMsg(order_id + "," + PartnerManager.getInstance().getCallBackUrl(payment));
	detailsDao.recordCreateOrderInfo(details);//记录订单操作明细
%>