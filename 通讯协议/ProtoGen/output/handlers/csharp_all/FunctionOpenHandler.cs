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
	public class FunctionOpenHandler
	{
		private PomeloClient _socket;

		public GetFunctionListResponse lastGetFunctionListResponse { get { return _socket.GetLastResponse<GetFunctionListResponse>(); } }
		public SetFunctionPlayedResponse lastSetFunctionPlayedResponse { get { return _socket.GetLastResponse<SetFunctionPlayedResponse>(); } }
		public ReceiveFunctionAwardResponse lastReceiveFunctionAwardResponse { get { return _socket.GetLastResponse<ReceiveFunctionAwardResponse>(); } }
		static FunctionOpenHandler()
		{
			EventTypes.RegistPushType("area.functionOpenPush.functionOpenListPush", typeof(FunctionOpenListPush));
			EventTypes.RegistPushType("area.functionOpenPush.functionAwardListPush", typeof(FunctionAwardListPush));
			EventTypes.RegistRequestType("area.functionOpenHandler.getFunctionListRequest", typeof(GetFunctionListRequest), typeof(GetFunctionListResponse));
			EventTypes.RegistRequestType("area.functionOpenHandler.setFunctionPlayedRequest", typeof(SetFunctionPlayedRequest), typeof(SetFunctionPlayedResponse));
			EventTypes.RegistRequestType("area.functionOpenHandler.receiveFunctionAwardRequest", typeof(ReceiveFunctionAwardRequest), typeof(ReceiveFunctionAwardResponse));
		}
		public FunctionOpenHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getFunctionListRequest(Action<PomeloException,GetFunctionListResponse> cb,object option = null)
		{
			var request = new GetFunctionListRequest();
			_socket.request<GetFunctionListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetFunctionListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setFunctionPlayedRequest(string functionName,Action<PomeloException,SetFunctionPlayedResponse> cb,object option = null)
		{
			var request = new SetFunctionPlayedRequest();
			request.functionName= functionName;
			_socket.request<SetFunctionPlayedResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetFunctionPlayedResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void receiveFunctionAwardRequest(int guide_id,Action<PomeloException,ReceiveFunctionAwardResponse> cb,object option = null)
		{
			var request = new ReceiveFunctionAwardRequest();
			request.guide_id= guide_id;
			_socket.request<ReceiveFunctionAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReceiveFunctionAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onFunctionOpenListPush(Action<FunctionOpenListPush> cb)
		{
			_socket.listen_once<FunctionOpenListPush>(cb);
		}
		public void onFunctionAwardListPush(Action<FunctionAwardListPush> cb)
		{
			_socket.listen_once<FunctionAwardListPush>(cb);
		}

	}


}