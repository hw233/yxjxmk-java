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

namespace pomelo.area
{
	public class PrepaidHandler
	{
		private PomeloClient _socket;

		public PrepaidSDKResponse lastPrepaidSDKResponse { get { return _socket.GetLastResponse<PrepaidSDKResponse>(); } }
		public PrepaidListResponse lastPrepaidListResponse { get { return _socket.GetLastResponse<PrepaidListResponse>(); } }
		public PrepaidAwardResponse lastPrepaidAwardResponse { get { return _socket.GetLastResponse<PrepaidAwardResponse>(); } }
		public PrepaidAPPResponse lastPrepaidAPPResponse { get { return _socket.GetLastResponse<PrepaidAPPResponse>(); } }
		public PrepaidOrderIdResponse lastPrepaidOrderIdResponse { get { return _socket.GetLastResponse<PrepaidOrderIdResponse>(); } }
		public PrepaidFirstResponse lastPrepaidFirstResponse { get { return _socket.GetLastResponse<PrepaidFirstResponse>(); } }
		static PrepaidHandler()
		{
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidSDKRequest", typeof(PrepaidSDKRequest), typeof(PrepaidSDKResponse));
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidListRequest", typeof(PrepaidListRequest), typeof(PrepaidListResponse));
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidAwardRequest", typeof(PrepaidAwardRequest), typeof(PrepaidAwardResponse));
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidAPPRequest", typeof(PrepaidAPPRequest), typeof(PrepaidAPPResponse));
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidOrderIdRequest", typeof(PrepaidOrderIdRequest), typeof(PrepaidOrderIdResponse));
			EventTypes.RegistRequestType("area.prepaidHandler.prepaidFirstAwardRequest", typeof(PrepaidFirstRequest), typeof(PrepaidFirstResponse));
		}
		public PrepaidHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void prepaidSDKRequest(string s2c_param,Action<PomeloException,PrepaidSDKResponse> cb,object option = null)
		{
			var request = new PrepaidSDKRequest();
			request.s2c_param= s2c_param;
			_socket.request<PrepaidSDKResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidSDKResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void prepaidListRequest(Action<PomeloException,PrepaidListResponse> cb,object option = null)
		{
			var request = new PrepaidListRequest();
			_socket.request<PrepaidListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void prepaidAwardRequest(Action<PomeloException,PrepaidAwardResponse> cb,object option = null)
		{
			var request = new PrepaidAwardRequest();
			_socket.request<PrepaidAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void prepaidAPPRequest(string s2c_param,Action<PomeloException,PrepaidAPPResponse> cb,object option = null)
		{
			var request = new PrepaidAPPRequest();
			request.s2c_param= s2c_param;
			_socket.request<PrepaidAPPResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidAPPResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void prepaidOrderIdRequest(int c2s_productId,int c2s_type,int c2s_channelId,string c2s_imei,int c2s_os,Action<PomeloException,PrepaidOrderIdResponse> cb,object option = null)
		{
			var request = new PrepaidOrderIdRequest();
			request.c2s_productId= c2s_productId;
			request.c2s_type= c2s_type;
			request.c2s_channelId= c2s_channelId;
			request.c2s_imei= c2s_imei;
			request.c2s_os= c2s_os;
			_socket.request<PrepaidOrderIdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidOrderIdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void prepaidFirstAwardRequest(Action<PomeloException,PrepaidFirstResponse> cb,object option = null)
		{
			var request = new PrepaidFirstRequest();
			_socket.request<PrepaidFirstResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PrepaidFirstResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}