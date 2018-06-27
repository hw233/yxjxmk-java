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
	public class OnlineGiftHandler
	{
		private PomeloClient _socket;

		public GetGiftInfoResponse lastGetGiftInfoResponse { get { return _socket.GetLastResponse<GetGiftInfoResponse>(); } }
		public GetOnlineTimeResponse lastGetOnlineTimeResponse { get { return _socket.GetLastResponse<GetOnlineTimeResponse>(); } }
		public ReceiveGiftResponse lastReceiveGiftResponse { get { return _socket.GetLastResponse<ReceiveGiftResponse>(); } }
		static OnlineGiftHandler()
		{
			EventTypes.RegistPushType("area.onlineGiftPush.giftInfoPush", typeof(GiftInfoPush));
			EventTypes.RegistRequestType("area.onlineGiftHandler.getGiftInfoRequest", typeof(GetGiftInfoRequest), typeof(GetGiftInfoResponse));
			EventTypes.RegistRequestType("area.onlineGiftHandler.getOnlineTimeRequest", typeof(GetOnlineTimeRequest), typeof(GetOnlineTimeResponse));
			EventTypes.RegistRequestType("area.onlineGiftHandler.receiveGiftRequest", typeof(ReceiveGiftRequest), typeof(ReceiveGiftResponse));
		}
		public OnlineGiftHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getGiftInfoRequest(Action<PomeloException,GetGiftInfoResponse> cb,object option = null)
		{
			var request = new GetGiftInfoRequest();
			_socket.request<GetGiftInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGiftInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getOnlineTimeRequest(Action<PomeloException,GetOnlineTimeResponse> cb,object option = null)
		{
			var request = new GetOnlineTimeRequest();
			_socket.request<GetOnlineTimeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetOnlineTimeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void receiveGiftRequest(int c2s_id,Action<PomeloException,ReceiveGiftResponse> cb,object option = null)
		{
			var request = new ReceiveGiftRequest();
			request.c2s_id= c2s_id;
			_socket.request<ReceiveGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReceiveGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onGiftInfoPush(Action<GiftInfoPush> cb)
		{
			_socket.listen_once<GiftInfoPush>(cb);
		}

	}


}