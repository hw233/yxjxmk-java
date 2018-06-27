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
	public class GuildBlessHandler
	{
		private PomeloClient _socket;

		public GetMyBlessInfoResponse lastGetMyBlessInfoResponse { get { return _socket.GetLastResponse<GetMyBlessInfoResponse>(); } }
		public BlessActionResponse lastBlessActionResponse { get { return _socket.GetLastResponse<BlessActionResponse>(); } }
		public ReceiveBlessGiftResponse lastReceiveBlessGiftResponse { get { return _socket.GetLastResponse<ReceiveBlessGiftResponse>(); } }
		public UpgradeBlessResponse lastUpgradeBlessResponse { get { return _socket.GetLastResponse<UpgradeBlessResponse>(); } }
		static GuildBlessHandler()
		{
			EventTypes.RegistPushType("area.guildBlessPush.blessRefreshPush", typeof(BlessRefreshPush));
			EventTypes.RegistRequestType("area.guildBlessHandler.getMyBlessInfoRequest", typeof(GetMyBlessInfoRequest), typeof(GetMyBlessInfoResponse));
			EventTypes.RegistRequestType("area.guildBlessHandler.blessActionRequest", typeof(BlessActionRequest), typeof(BlessActionResponse));
			EventTypes.RegistRequestType("area.guildBlessHandler.receiveBlessGiftRequest", typeof(ReceiveBlessGiftRequest), typeof(ReceiveBlessGiftResponse));
			EventTypes.RegistRequestType("area.guildBlessHandler.upgradeBlessRequest", typeof(UpgradeBlessRequest), typeof(UpgradeBlessResponse));
		}
		public GuildBlessHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getMyBlessInfoRequest(Action<PomeloException,GetMyBlessInfoResponse> cb,object option = null)
		{
			var request = new GetMyBlessInfoRequest();
			_socket.request<GetMyBlessInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMyBlessInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void blessActionRequest(int id,Action<PomeloException,BlessActionResponse> cb,object option = null)
		{
			var request = new BlessActionRequest();
			request.id= id;
			_socket.request<BlessActionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BlessActionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void receiveBlessGiftRequest(int index,Action<PomeloException,ReceiveBlessGiftResponse> cb,object option = null)
		{
			var request = new ReceiveBlessGiftRequest();
			request.index= index;
			_socket.request<ReceiveBlessGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReceiveBlessGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeBlessRequest(Action<PomeloException,UpgradeBlessResponse> cb,object option = null)
		{
			var request = new UpgradeBlessRequest();
			_socket.request<UpgradeBlessResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeBlessResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onBlessRefreshPush(Action<BlessRefreshPush> cb)
		{
			_socket.listen_once<BlessRefreshPush>(cb);
		}

	}


}