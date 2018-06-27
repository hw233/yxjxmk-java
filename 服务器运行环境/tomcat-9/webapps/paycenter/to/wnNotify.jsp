<%@ page contentType="text/html;charset=UTF-8" pageEncoding="UTF-8"
	import="com.wanniu.paycenter.res.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.RecvResult,java.net.*,net.sf.json.JSONObject"%>
<%@ page
	import="com.wanniu.paycenter.bean.OrderPO,com.wanniu.paycenter.utils.Md5,com.wanniu.paycenter.utils.Base64"%>
<%@ page import="com.wanniu.paycenter.bean.OrderDetailPO" %>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao" %>
<%
	Logger log = Logger.getLogger("mfNotify");
	String account=request.getParameter("account");
	String money=request.getParameter("money");
	String orderid=request.getParameter("orderid");
	String cop_order_id=request.getParameter("cop_order_id");
	String sign=request.getParameter("sign");
	String md5String = "account="+account+"&cop_order_id="+cop_order_id+"&money="+money+"&orderid="+orderid;
	String logData = md5String+"&sign="+sign;
	log.info("received one mf callback:"+logData);
	if(cop_order_id.equals("") || cop_order_id==null){
		log.info("顽牛订单，cop_order_id空");
		return;
	}
	//------modify by luoqi 2015-12-14
	OrderDetailPO details = new OrderDetailPO(cop_order_id,"",orderid,logData,"","");
	OrderDetailsDao detailsDao = new OrderDetailsDao();
	details.setF_ReceiveState("-2");//设置初始化状态为-2
	//验证订单是否过期
	boolean is_Expired=DateUtil.checkOrderDate(cop_order_id,5);
	if(is_Expired){
		out.write("success");
		String err = "顽牛订单："+cop_order_id+"已过期.";
		log.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		detailsDao.updateOnReceive(details);//记录收到渠道通知时的详细信息
		return;
	}
	//签名验证
	String appid=(cop_order_id.substring(cop_order_id.length()-13,cop_order_id.length()-9));
	String osid=cop_order_id.substring(cop_order_id.length()-5,cop_order_id.length()-4);
	String secret = PartnerManager.getInstance().getSecretKey("", appid, osid);
	
// 	Parameter par=Constants.PARAMTER.get(appid+"0");
// 	String secret=par.getKey();
// 	if(osid.equals("2")){
// 		secret=par.getKeyios();
// 	}
	md5String += secret;
	log.info("顽牛订单,签名用字符串："+md5String);
	String res_sign=Md5.getUCMD5Str(md5String);
	out.clearBuffer();
	if(sign.equalsIgnoreCase(res_sign)){//验签通过	
		try {
			RecvResult recvResult=new RecvResult(1,cop_order_id,Double.parseDouble(money)/100,orderid,0,null);
			PayDao paydao = new PayDao();
			paydao.callBack(recvResult);
			out.write("Y");
			details.setF_ReceiveState("2");
			details.setF_ReceiveResponseMsg("Y");
			details.setF_Money(new Double(Double.parseDouble(money)/100).toString());
		} catch (Exception e) {
			out.write("N");
			log.error(e);
		}
	}else{
		out.write("N");
		String err = "顽牛订单,签名验证失败。";
		log.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("N");
	}
	detailsDao.updateOnReceive(details);//记录收到渠道通知时的详细信息
%>