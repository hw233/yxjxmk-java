<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*,java.sql.Timestamp,java.text.SimpleDateFormat"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.ApplicationCO,java.math.BigDecimal,net.sf.json.JSONObject"%>
<%@ page
	import="java.util.*,com.wanniu.paycenter.utils.SmsSend,com.wanniu.paycenter.bean.OrderPO,java.io.*,com.wanniu.paycenter.res.Constants,java.net.*"%>
<%@ page import="com.wanniu.paycenter.bean.OrderDetailPO"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	Logger logger = Logger.getLogger("common_qeng");
	String appid = String.valueOf(request.getAttribute("appid"));
	String channel = String.valueOf(request.getAttribute("channel"));
	String money = String.valueOf(request.getAttribute("money"));
	String username = String.valueOf(request.getAttribute("username"));
	String serverid = String.valueOf(request.getAttribute("serverid"));
	String roleid = String.valueOf(request.getAttribute("roleid"));
	String expand = String.valueOf(request.getAttribute("expand"));
	String cop_expand = String.valueOf(request.getAttribute("cop_expand"));
	String payment = String.valueOf(request.getAttribute("payment"));
	String mac =String.valueOf(request.getAttribute("mac"));
	String msg = "common_qeng:appid=" + appid
			+ "&payment=" + payment 
			+ "&channel=" + channel + "&money="
			+ money + "&username=" + username + "&serverid=" + serverid + "&roleid=" + roleid + "&expand="
			+ expand 
			+ "&cop_expand=" + cop_expand + "&mac=" + mac;
	logger.info(msg);
	out.clearBuffer();
	// 	Parameter par=Constants.PARAMTER.get(appid+payment);
	// 	String appkey=par.getKeypad();
	// 	String cop_appid=par.getKeyios();
	// 	String osid=Constants.ChannelOS.get(payment + channel);
	

// 	String appkey = PartnerManager.getInstance().getPadKey(payment, appid);
// 	String cop_appid = PartnerManager.getInstance().getIosKey(payment, appid);
	String osid = PartnerManager.getInstance().getChannelOstype(payment, channel);
	String order_id = DateUtil.getOrderID(appid, osid);
	PayDao payDao = new PayDao();
	OrderDetailPO details = new OrderDetailPO(order_id, money, payment, channel, appid, username, roleid,
			serverid, expand, "CNY", msg, "", "");
	details.setF_OrderState("1");
	OrderDetailsDao detailsDao = new OrderDetailsDao();
	OrderPO orderInfo = new OrderPO(username, Double.parseDouble(money), roleid, order_id, 98, 98, appid,
			Integer.parseInt(channel), serverid, null, expand);
	payDao.creatOrder(orderInfo);
	out.write(order_id);
	details.setF_CreateOrderResponseMsg(order_id);
	detailsDao.recordCreateOrderInfo(details);//记录订单的下单详情
%>