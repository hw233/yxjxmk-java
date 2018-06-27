<%@ page contentType="text/html;charset=UTF-8" pageEncoding="UTF-8"
	import="com.wanniu.paycenter.res.*,java.io.*"%>
<%@ page
	import="com.wanniu.paycenter.dao.PayDao,com.wanniu.paycenter.bean.*,com.wanniu.paycenter.utils.*,java.net.*"%>
<%@ page
	import="com.wanniu.paycenter.sdk.miyu.*,net.sf.json.*,com.wanniu.paycenter.utils.*"%>
<%@ page import="com.wanniu.paycenter.dao.OrderDetailsDao"%>
<%
	final  int MIYU_PAYMENT_ID = 60;
	Logger log = Logger.getLogger("miyuRebateNotify");
	String ip = request.getRemoteHost();

	DataInputStream is = new DataInputStream(request.getInputStream());
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
	log.info("encryptdata"+encryptdata);
	
	String applyid = request.getParameter("applyid");
	int gameid = Integer.parseInt(request.getParameter("gameid"));
	String userid = request.getParameter("userid");
	String serverid = request.getParameter("serverid");
	String roleid = request.getParameter("roleid");
	int total_amount = Integer.parseInt(request.getParameter("total_amount"));
	int rebate_gamecoin = Integer.parseInt(request.getParameter("rebate_gamecoin"));
	String order_lists = request.getParameter("order_lists");
	int applytime = Integer.parseInt(request.getParameter("applytime"));
	int rebatedate = Integer.parseInt(request.getParameter("rebatedate"));
	String sign = request.getParameter("sign");
	String ext = request.getParameter("ext");

	String checkInput ="";/*  TextUtil
			.format("applyid={0}&gameid={1}&userid={2}&serverid={3}&roleid={4}&total_amount={5}&rebate_gamecoin={6}&order_lists={7}&applytime={8}&rebatedate={9}:{10}",
					applyid, gameid, userid, serverid, roleid, total_amount, rebate_gamecoin, order_lists,applytime,rebatedate, Key);
	log.info(checkInput); 
	
	String orderLists = URLDecoder.decode(order_lists);
	try {
		String checkOutput =new String(EncryptUtil.getMD5(checkInput.getBytes("UTF-8")));
		if (sign.equals(checkOutput)) {//验证签名
		}
		
	}catch(Exception e){
		log.error(e);
	}
	*/
	String res = JSONUtils.toJson(new MiyuRebateResult(1,"返利成功"));
	log.debug(res);
	out.write(res);
	//request.getRequestDispatcher("http://passport.wnplay.cn:82/rebateForMiyu").forward(request,response);
/* 	String user_id = request.getParameter("user_id");
	String role_id = request.getParameter("role_id");
	String amount = request.getParameter("amount");
	int game_coin = Integer.parseInt(request.getParameter("game_coin"));
	String cp_order_id = request.getParameter("cp_order_id");
	int success = Integer.parseInt(request.getParameter("success"));
	String ext = request.getParameter("ext");
	String sign = request.getParameter("sign");

	String msg = "order_id=" + order_id + "&user_id=" + user_id + "&role_id=" + role_id + "&amount=" + amount
			+ "&game_coin=" + game_coin + "&cp_order_id=" + cp_order_id + "&success=" + success + "&ext=" + ext
			+ "&sign=" + sign + "&ip=" + ip;
	log.info("miyuNewNotify:" + msg);
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
	int mf_appid = Integer.parseInt(cp_order_id.substring(cp_order_id.length() - 12, cp_order_id.length() - 9));
	Parameter par = Constants.PARAMTER.get(mf_appid + MIYU_PAYMENT_ID);//TODO

	String key = par.getKey();

	String strMd5= "order_id=" + order_id + "&user_id=" + user_id + "&role_id=" + role_id + "&amount=" + amount
			+ "&game_coin=" + game_coin + "&cp_order_id=" + cp_order_id + "&success=" + success + "：" + key;
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
	*/
%>