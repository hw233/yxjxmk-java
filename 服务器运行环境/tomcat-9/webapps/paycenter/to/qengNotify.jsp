<%@page import="java.util.Base64"%>
<%@ page contentType="text/html;charset=UTF-8" pageEncoding="UTF-8"
	import="com.wanniu.paycenter.res.*,java.io.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.*,com.wanniu.paycenter.utils.*,java.net.*"%>
<%@ page import="net.sf.json.JSONObject,com.wanniu.paycenter.utils.Md5"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	request.setCharacterEncoding("UTF-8");
	final int PAYMENT_ID = 61;
	Logger log = Logger.getLogger("qengNotify");
	String ip = request.getRemoteHost();
	String orderid= request.getParameter("orderid");//商户系统生成的订单号
	String transid = request.getParameter("transid");//支付平台的交易流水号
	String channel = request.getParameter("channel");//1微信，2支付宝，3appstore内购
	String appid = request.getParameter("appid");//平台分配的应用编号
	String ordername = request.getParameter("ordername");//订单显示的商品名称
	String price = request.getParameter("price");//支付金额，单位为元	
	String userid = request.getParameter("userid");//商户系统的用户编号
	String username = request.getParameter("username");//商户系统中的用户名
	String attach = request.getParameter("attach");//创建订单时填写的私有信息
	String status = request.getParameter("status");//3系统异常，4交易失败，5交易成功
	String sandbox = request.getParameter("sandbox");//0正式环境，1沙盒环境
	String createat = request.getParameter("createat");//调用订单创建接口的时间
	String startat = request.getParameter("startat");//用户开始支付的时间
	String payat = request.getParameter("payat");//支付时间	
	String sign = request.getParameter("sign");//签名
	out.clearBuffer();
// 	String tmp = ip+"&"+orderid+"&"+transid+"&"+channel+"&"+ordername+"&"+price+"&"+userid+"&"+username+"&"+attach+"&"+status+"&"+sandbox+"&"+createat+"&"+startat+"&"+payat+"&"+sign;
// 	System.out.println(tmp);
// 	log.info(tmp);
	String orgOrderId = orderid;
// 	= attach.replace("-", "+").replace("_", "/").replace(".", "=");
// 	orgOrderId = new String(Base64.getDecoder().decode(orgOrderId));//base64转码
// 	String osid = orgOrderId.substring(orgOrderId.length() - 5, orgOrderId.length() - 4);
// 	String mf_appid = (orgOrderId.substring(orgOrderId.length() - 13, orgOrderId.length() - 9));
// 	String key = PartnerManager.getInstance().getSecretKey(String.valueOf(PAYMENT_ID), mf_appid, osid);
	//有参数名按字母顺序进行排序，并去除sign
 	String params = SignUtil.sortParams(request.getParameterMap());
 	String msg = params.substring(0,params.length()-1);//去除最后一个“&”符号
// 	params += "product_key=" + key;
	log.info("params:" + msg);
 	OrderDetailPO details = new OrderDetailPO(orgOrderId, price, orderid, msg, "", "");
 	OrderDetailsDao detailsDao = new OrderDetailsDao();
 	
 	if(!RsaUtil.doCheck(msg, sign, RsaUtil.RSAKey.QENG_PUB_KEY)){
 		String err = "qeng订单" + orgOrderId + "验证不通过";
		log.info(err);
		out.write("Sign Error");
		return;
 	}

	if(status.equals("4")){
 		String err = "qeng订单:" + orgOrderId + "下单失败";
		log.info(err);
		out.write("SUCCESS");
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("-1");
		detailsDao.updateOnReceive(details);//记录订单操作明细
		return;
	}
	
	if(!status.equals("5")){
 		String err = "qeng订单:" + orgOrderId + "发生异常，编号："+status;
		log.info(err);
		out.write("SUCCESS");
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("-1");
		detailsDao.updateOnReceive(details);//记录订单操作明细
		return;
	}
	
	//验证订单是否过期
	boolean is_Expired = DateUtil.checkOrderDate(orgOrderId, 5);
	if (is_Expired) {
		out.write("SUCCESS");//过期或是不成功的订单，就不要再重复发了
		String err = "qeng订单:" + orgOrderId + "已过期.";
		log.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("-2");
		detailsDao.updateOnReceive(details);//记录订单操作明细
		return;
	}
	
	
	PayDao paydao = new PayDao();
	RecvResult recvResult = new RecvResult(1, orgOrderId, Double.parseDouble(price), "", PAYMENT_ID, "");//payType=98???TODO
	paydao.callBack(recvResult);//通知游戏服
	out.write("SUCCESS");
	out.close();
	log.info("qeng订单" + orgOrderId + "处理成功");
	details.setF_ReceiveResponseMsg("success");
	details.setF_ReceiveState("2");
	detailsDao.updateOnReceive(details);//记录订单操作明细
%>