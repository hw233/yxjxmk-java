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
	public class InteractHandler
	{
		private PomeloClient _socket;

		public InteractResponse lastInteractResponse { get { return _socket.GetLastResponse<InteractResponse>(); } }
		public InteractConfigResponse lastInteractConfigResponse { get { return _socket.GetLastResponse<InteractConfigResponse>(); } }
		public InteractTimesResponse lastInteractTimesResponse { get { return _socket.GetLastResponse<InteractTimesResponse>(); } }
		static InteractHandler()
		{
			EventTypes.RegistPushType("area.interactPush.receiveInteractPush", typeof(ReceiveInteractPush));
			EventTypes.RegistRequestType("area.interactHandler.interactRequest", typeof(InteractRequest), typeof(InteractResponse));
			EventTypes.RegistRequestType("area.interactHandler.interactConfigRequest", typeof(InteractConfigRequest), typeof(InteractConfigResponse));
			EventTypes.RegistRequestType("area.interactHandler.interactTimesRequest", typeof(InteractTimesRequest), typeof(InteractTimesResponse));
		}
		public InteractHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void interactRequest(int c2s_id,string c2s_playerId,string c2s_playerName,Action<PomeloException,InteractResponse> cb,object option = null)
		{
			var request = new InteractRequest();
			request.c2s_id= c2s_id;
			request.c2s_playerId= c2s_playerId;
			request.c2s_playerName= c2s_playerName;
			_socket.request<InteractResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InteractResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void interactConfigRequest(Action<PomeloException,InteractConfigResponse> cb,object option = null)
		{
			var request = new InteractConfigRequest();
			_socket.request<InteractConfigResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InteractConfigResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void interactTimesRequest(Action<PomeloException,InteractTimesResponse> cb,object option = null)
		{
			var request = new InteractTimesRequest();
			_socket.request<InteractTimesResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InteractTimesResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onReceiveInteractPush(Action<ReceiveInteractPush> cb)
		{
			_socket.listen_once<ReceiveInteractPush>(cb);
		}

	}


}