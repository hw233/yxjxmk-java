/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/9.0.0.M15
 * Generated at: 2017-05-25 02:59:39 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp.take;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import com.wanniu.paycenter.res.*;
import com.wanniu.paycenter.dao.PayDao;
import com.wanniu.paycenter.bean.ApplicationCO;
import java.util.*;
import com.wanniu.paycenter.utils.*;
import com.wanniu.paycenter.res.Constants;
import com.wanniu.paycenter.bean.OrderPO;
import java.io.*;
import com.wanniu.paycenter.dao.OrderDetailsDao;
import com.wanniu.paycenter.bean.OrderDetailPO;

public final class control_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("javax.servlet");
    _jspx_imports_packages.add("com.wanniu.paycenter.utils");
    _jspx_imports_packages.add("java.util");
    _jspx_imports_packages.add("javax.servlet.http");
    _jspx_imports_packages.add("com.wanniu.paycenter.res");
    _jspx_imports_packages.add("java.io");
    _jspx_imports_packages.add("javax.servlet.jsp");
    _jspx_imports_classes = new java.util.HashSet<>();
    _jspx_imports_classes.add("com.wanniu.paycenter.bean.OrderPO");
    _jspx_imports_classes.add("com.wanniu.paycenter.res.Constants");
    _jspx_imports_classes.add("com.wanniu.paycenter.dao.OrderDetailsDao");
    _jspx_imports_classes.add("com.wanniu.paycenter.dao.PayDao");
    _jspx_imports_classes.add("com.wanniu.paycenter.bean.OrderDetailPO");
    _jspx_imports_classes.add("com.wanniu.paycenter.bean.ApplicationCO");
  }

  private volatile javax.el.ExpressionFactory _el_expressionfactory;
  private volatile org.apache.tomcat.InstanceManager _jsp_instancemanager;

  public java.util.Map<java.lang.String,java.lang.Long> getDependants() {
    return _jspx_dependants;
  }

  public java.util.Set<java.lang.String> getPackageImports() {
    return _jspx_imports_packages;
  }

  public java.util.Set<java.lang.String> getClassImports() {
    return _jspx_imports_classes;
  }

  public javax.el.ExpressionFactory _jsp_getExpressionFactory() {
    if (_el_expressionfactory == null) {
      synchronized (this) {
        if (_el_expressionfactory == null) {
          _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
        }
      }
    }
    return _el_expressionfactory;
  }

  public org.apache.tomcat.InstanceManager _jsp_getInstanceManager() {
    if (_jsp_instancemanager == null) {
      synchronized (this) {
        if (_jsp_instancemanager == null) {
          _jsp_instancemanager = org.apache.jasper.runtime.InstanceManagerFactory.getInstanceManager(getServletConfig());
        }
      }
    }
    return _jsp_instancemanager;
  }

  public void _jspInit() {
  }

  public void _jspDestroy() {
  }

  public void _jspService(final javax.servlet.http.HttpServletRequest request, final javax.servlet.http.HttpServletResponse response)
      throws java.io.IOException, javax.servlet.ServletException {

    final java.lang.String _jspx_method = request.getMethod();
    if (!"GET".equals(_jspx_method) && !"POST".equals(_jspx_method) && !"HEAD".equals(_jspx_method) && !javax.servlet.DispatcherType.ERROR.equals(request.getDispatcherType())) {
      response.sendError(HttpServletResponse.SC_METHOD_NOT_ALLOWED, "JSPs only permit GET POST or HEAD");
      return;
    }

    final javax.servlet.jsp.PageContext pageContext;
    javax.servlet.http.HttpSession session = null;
    final javax.servlet.ServletContext application;
    final javax.servlet.ServletConfig config;
    javax.servlet.jsp.JspWriter out = null;
    final java.lang.Object page = this;
    javax.servlet.jsp.JspWriter _jspx_out = null;
    javax.servlet.jsp.PageContext _jspx_page_context = null;


    try {
      response.setContentType("text/html;charset=utf-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");

	Logger logger = Logger.getLogger("control");
	BufferedReader bin = new BufferedReader(new InputStreamReader(request.getInputStream(), "UTF-8"));
	String result = "";
	while (true) {
		String line = bin.readLine();
		if (line == null) {
			break;
		} else {
			result += line;
		}
	}
	bin.close();
	HashMap<String, String> parameters = new HashMap<String, String>();
	java.util.StringTokenizer st = new java.util.StringTokenizer(result, "&");
	while (st.hasMoreTokens()) {
		String temp[] = st.nextToken().split("=");
		if (temp.length > 1) {
			parameters.put(temp[0], temp[1]);
		}
	}
	String appid = parameters.get("appid");
	appid = "00000" + appid;
	appid = appid.substring(appid.length() - 4, appid.length());
	
	String channel = parameters.get("channel");
	String money = parameters.get("money");
	String username = parameters.get("username");
	String serverid = parameters.get("serverid");
	String roleid = parameters.get("roleid");
	String expand = parameters.get("expand");
	String cop_expand = parameters.get("cop_expand");
	String mac = parameters.get("mac");
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
	case 61:
		request.getRequestDispatcher("common_hoolai.jsp").forward(request, response);
		break;
	default:
		request.getRequestDispatcher("common.jsp").forward(request, response);
		break;
	}

    } catch (java.lang.Throwable t) {
      if (!(t instanceof javax.servlet.jsp.SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try {
            if (response.isCommitted()) {
              out.flush();
            } else {
              out.clearBuffer();
            }
          } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
