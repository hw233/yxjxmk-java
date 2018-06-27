<%@ page contentType="text/html;charset=UTF-8" pageEncoding="UTF-8"
	import="com.wanniu.paycenter.res.*,java.io.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.*,com.wanniu.paycenter.utils.*,java.net.*"%>
<%@ page
	import="net.sf.json.JSONObject,com.wanniu.paycenter.utils.Md5"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	final  int MIYU_PAYMENT_ID = 60;
	Logger log = Logger.getLogger("miyuNotify");
	String ip = request.getRemoteHost();

/* 	DataInputStream is = new DataInputStream(request.getInputStream());
	byte[] data = new byte[4096];
	byte[] buf = new byte[1024];
	int sum = 0;
	int len=0;
	while(true){
		len = is.read(buf);
		if(len==0)continue;
		if(len==-1){
			break;
		}
		System.arraycopy(buf,0,data,sum,len);
		sum+= len;
	}
	log.info("data:" + new String(data));
	String encryptdata=Encoder.decode(data,sum);
	log.info("encryptdata"+encryptdata); */
	
	String order_id = request.getParameter("order_id");
	String user_id = request.getParameter("user_id");
	String role_id = request.getParameter("role_id");
	String amount = request.getParameter("amount");
	String coin = request.getParameter("game_coin");
	int game_coin = Integer.parseInt(coin);
	String cp_order_id = request.getParameter("cp_order_id");
	int success = Integer.parseInt(request.getParameter("success"));
	String ext = request.getParameter("ext");
	String sign = request.getParameter("sign");

	String msg = "order_id=" + order_id + "&user_id=" + user_id + "&role_id=" + role_id + "&amount=" + amount
			+ "&game_coin=" + game_coin + "&cp_order_id=" + cp_order_id + "&success=" + success + "&ext=" + ext
			+ "&sign=" + sign + "&ip=" + ip;
	log.info("miyuNotify:" + msg);
	out.clearBuffer();

	OrderDetailPO details = new OrderDetailPO(cp_order_id, amount, order_id, msg, "", "");
	OrderDetailsDao detailsDao = new OrderDetailsDao();

	//验证订单是否过期
	boolean is_Expired = DateUtil.checkOrderDate(cp_order_id, 5);
	if (is_Expired) {
		out.write("success");
		String err = "米娱订单" + cp_order_id + "已过期.";
		log.info(err);
		details.setF_ReceiveErrMsg(err);
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("-2");
		detailsDao.updateOnReceive(details);//记录订单操作明细
		return;
	}
	String osid = cp_order_id.substring(cp_order_id.length() - 5, cp_order_id.length() - 4);
	String mf_appid = (cp_order_id.substring(cp_order_id.length() - 13, cp_order_id.length() - 9));
// 	Parameter par = Constants.PARAMTER.get(mf_appid +""+ MIYU_PAYMENT_ID);//TODO
//  	String key = par.getKeyios();
// 	if ((osid.equals("1")) && (mf_appid == 45)) {//系统为安卓，并且游戏为X三国 wfy guess
// 		key = par.getKey();
// 	} 
// 	String key = par.getKey();
	
	String key = PartnerManager.getInstance().getSecretKey(String.valueOf(MIYU_PAYMENT_ID), mf_appid, osid);
	//有参数名按字母顺序进行排序
	String strMd5= "amount=" + amount + "&cp_order_id=" + cp_order_id +  "&game_coin=" + game_coin
			+"&order_id=" + order_id+ "&role_id=" + role_id  + "&success=" + success+ "&user_id=" + user_id  + ":" + key;
	log.info("strMd5:"+strMd5);
	String mfsign=Md5.getUCMD5Str(strMd5);

	if (mfsign.equalsIgnoreCase(sign)) {
		PayDao paydao = new PayDao();
		RecvResult recvResult = new RecvResult(success, cp_order_id, Double.parseDouble(amount), role_id, MIYU_PAYMENT_ID,
				ext);//payType=98???TODO
		paydao.callBack(recvResult);
		out.write("success");
		log.info("米娱订单" + cp_order_id + "处理成功");
		details.setF_ReceiveResponseMsg("success");
		details.setF_ReceiveState("2");
	} else {
		String err = "米娱订单" + cp_order_id + "验证不通过";
		log.info(err);
		out.write("fail");
		details.setF_ReceiveState("-2");
		details.setF_ReceiveResponseMsg("fail");
		details.setF_ReceiveErrMsg(err);
	}
	detailsDao.updateOnReceive(details);//记录订单操作明细
%>