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

namespace pomelo.connector
{
	public class EntryHandler
	{
		private PomeloClient _socket;

		public EntryResponse lastEntryResponse { get { return _socket.GetLastResponse<EntryResponse>(); } }
		public BindPlayerResponse lastBindPlayerResponse { get { return _socket.GetLastResponse<BindPlayerResponse>(); } }
		public GetSysTimeResponse lastGetSysTimeResponse { get { return _socket.GetLastResponse<GetSysTimeResponse>(); } }
		static EntryHandler()
		{
			EventTypes.RegistPushType("connector.entryPush.loginQueuePush", typeof(LoginQueuePush));
			EventTypes.RegistRequestType("connector.entryHandler.entryRequest", typeof(EntryRequest), typeof(EntryResponse));
			EventTypes.RegistRequestType("connector.entryHandler.bindPlayerRequest", typeof(BindPlayerRequest), typeof(BindPlayerResponse));
			EventTypes.RegistRequestType("connector.entryHandler.getSysTimeRequest", typeof(GetSysTimeRequest), typeof(GetSysTimeResponse));
		}
		public EntryHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void entryRequest(string c2s_uid,string c2s_token,int c2s_logicServerId,string c2s_deviceMac,int c2s_deviceType,string c2s_clientRegion,string c2s_clientChannel,string c2s_clientVersion,Action<PomeloException,EntryResponse> cb,object option = null)
		{
			var request = new EntryRequest();
			request.c2s_uid= c2s_uid;
			request.c2s_token= c2s_token;
			request.c2s_logicServerId= c2s_logicServerId;
			request.c2s_deviceMac= c2s_deviceMac;
			request.c2s_deviceType= c2s_deviceType;
			request.c2s_clientRegion= c2s_clientRegion;
			request.c2s_clientChannel= c2s_clientChannel;
			request.c2s_clientVersion= c2s_clientVersion;
			_socket.request<EntryResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EntryResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void bindPlayerRequest(string c2s_playerId,Action<PomeloException,BindPlayerResponse> cb,object option = null)
		{
			var request = new BindPlayerRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<BindPlayerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BindPlayerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSysTimeRequest(Action<PomeloException,GetSysTimeResponse> cb,object option = null)
		{
			var request = new GetSysTimeRequest();
			_socket.request<GetSysTimeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSysTimeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onLoginQueuePush(Action<LoginQueuePush> cb)
		{
			_socket.listen_once<LoginQueuePush>(cb);
		}

	}


}