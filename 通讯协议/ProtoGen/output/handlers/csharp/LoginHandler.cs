/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pomelo.DotNetClient;

namespace pomelo.login
{
	public class LoginHandler
	{
		private PomeloClient _socket;

		public LoginResponse lastLoginResponse { get { return _socket.GetLastResponse<LoginResponse>(); } }
		public RegisterResponse lastRegisterResponse { get { return _socket.GetLastResponse<RegisterResponse>(); } }
		static LoginHandler()
		{
			EventTypes.RegistPushType("login.loginPush.serverStatePush", typeof(ServerStatePush));
			EventTypes.RegistRequestType("login.loginHandler.loginRequest", typeof(LoginRequest), typeof(LoginResponse));
			EventTypes.RegistRequestType("login.loginHandler.registerRequest", typeof(RegisterRequest), typeof(RegisterResponse));
		}
		public LoginHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void loginRequest(string appId,string uid,string token,string channel,int os,string imei,string version,string channelUid,Action<PomeloException,LoginResponse> cb,object option = null)
		{
			var request = new LoginRequest();
			request.appId= appId;
			request.uid= uid;
			request.token= token;
			request.channel= channel;
			request.os= os;
			request.imei= imei;
			request.version= version;
			request.channelUid= channelUid;
			_socket.request<LoginResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LoginResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void registerRequest(int appId,string account,string password,int channel,int os,string model,string imei,string version,string tel,Action<PomeloException,RegisterResponse> cb,object option = null)
		{
			var request = new RegisterRequest();
			request.appId= appId;
			request.account= account;
			request.password= password;
			request.channel= channel;
			request.os= os;
			request.model= model;
			request.imei= imei;
			request.version= version;
			request.tel= tel;
			_socket.request<RegisterResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RegisterResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onServerStatePush(Action<ServerStatePush> cb)
		{
			_socket.listen_once<ServerStatePush>(cb);
		}

	}


}