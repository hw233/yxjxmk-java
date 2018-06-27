<%@ page contentType="text/html;charset=utf-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.ApplicationCO"%>
<%@ page import="java.util.*,com.wanniu.paycenter.utils.*"%>
<%@ page import="com.wanniu.paycenter.res.Constants"%>
<%@ page import="com.wanniu.paycenter.bean.OrderPO,java.io.*"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%@ page import="com.wanniu.paycenter.bean.OrderDetailPO"%>
<%
	Logger logger = Logger.getLogger("control");
	request.setCharacterEncoding("UTF-8");

	String appid = request.getParameter("appid");
	appid = "00000" + appid;
	appid = appid.substring(appid.length() - 4, appid.length());
	String channel = request.getParameter("channel");
	String money = request.getParameter("money");
	String username = request.getParameter("username");
	String serverid = request.getParameter("serverid");
	String roleid = request.getParameter("roleid");
	String expand = request.getParameter("expand");
	String cop_expand = request.getParameter("cop_expand");
	String mac = request.getParameter("mac");
	String ip = request.getRemoteHost();
	String logData = "control:appid=" + appid + "&channel=" + channel + "&money=" + money + "&username="
			+ username + "&serverid=" + serverid + "&roleid=" + roleid + "&expand=" + expand + "&cop_expand="
			+ cop_expand + "&mac=" + mac + "&ip=" + ip;
	logger.info(logData);
	out.clearBuffer();
	ApplicationCO appinfo = ApplicationManager.getInstance().getApplication(appid);
	if (appinfo == null) {
		//----------alter by luoqi 2015-11-25
		OrderDetailsDao orderDao = new OrderDetailsDao();
		OrderDetailPO orderDetails = new OrderDetailPO(null, money, null, channel, appid, username, roleid,
				serverid, expand, "CNY", logData, "-1", "appid:" + appid + "不存在.");
		//----------alter by luoqi 2015-11-25
		logger.info("appid:" + appid + "不存在.");
		out.write("-1");
		//----------alter by luoqi 2015-11-25
		orderDetails.setF_OrderState("-1");//-1下单失败
		orderDao.recordCreateOrderInfo(orderDetails);//记录下单信息
		//----------alter by luoqi 2015-11-25
		return;
	}
	//TODO 自有sdk
	//	if((username.indexOf(".")<0 || username.endsWith(".yk")) && appid.equals("7") && !channel.equals("875") && !channel.equals("1137") && !channel.equals("910") && !channel.equals("817") && !channel.equals("845")){//安智和机锋,电信，应用汇,快用的用官方帐号充值的。
	//		logger.info("mfsdk:appid=" + appid + "&channel=" + channel + "&money=" + money + "&username=" + username + "&serverid=" + serverid + "&roleid=" + roleid + "&expand=" + expand + "&cop_expand=" + cop_expand + "&mac=" + mac+"&ip="+ip);
	//		String url="http://127.0.0.1:8032/pay/get/order.jsp";
	//		String data="appid="+appid+"&channel="+channel+"&money="+money+"&username="+username+"&serverid="+serverid+"&roleid="+roleid+"&expand="+expand;
	//		String order_id=SmsSend.requetPostByCharset(url, data, "UTF-8");
	//		out.write(order_id);
	//		return;
	//	}
	// 	String payment=Constants.ChannelToPayment.get(channel);

	String payment = PartnerManager.getInstance().getPartnerId(channel, appid);
	int pt = 0;
	if (payment != null) {
		pt = Integer.parseInt(payment);
	} else {
		logger.info("渠道号" + channel + "没找到支付通道号.");
	}

	// 检查IP
// 	if (!ApplicationManager.getInstance().checkIp(ip, appid)) {
// 		logger.info("非法IP" + ip);
// 		out.write("-1");
// 		return;
// 	}

	if (money != null) {
		money = String.valueOf(Double.parseDouble(money) / 100);
	}

	request.setAttribute("appid", appid);
	request.setAttribute("channel", channel);
	request.setAttribute("money", money);
	request.setAttribute("username", username);
	request.setAttribute("serverid", serverid);
	request.setAttribute("roleid", roleid);
	request.setAttribute("expand", expand);
	request.setAttribute("cop_expand", cop_expand);
	request.setAttribute("mac", mac);
	request.setAttribute("payment", payment);
	switch (pt) {
	case 60://米娱sdk
		request.getRequestDispatcher("common_miyu.jsp").forward(request, response);
		break;
	case 61://互爱游戏sdk
		request.getRequestDispatcher("common_hoolai.jsp").forward(request, response);
		break;
	case 62://清源sdk
		request.getRequestDispatcher("common_qeng.jsp").forward(request, response);
		break;
	default:
		request.getRequestDispatcher("common.jsp").forward(request, response);
		break;
	}
%>