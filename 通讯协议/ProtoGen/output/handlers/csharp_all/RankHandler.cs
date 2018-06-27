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
	public class RankHandler
	{
		private PomeloClient _socket;

		public GetRankInfoResponse lastGetRankInfoResponse { get { return _socket.GetLastResponse<GetRankInfoResponse>(); } }
		static RankHandler()
		{
			EventTypes.RegistPushType("area.rankPush.onAwardRankPush", typeof(OnAwardRankPush));
			EventTypes.RegistRequestType("area.rankHandler.getRankInfoRequest", typeof(GetRankInfoRequest), typeof(GetRankInfoResponse));
			EventTypes.RegistNotifyType("area.rankHandler.saveRankNotify", typeof(SaveRankNotify));
		}
		public RankHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getRankInfoRequest(Action<PomeloException,GetRankInfoResponse> cb,object option = null)
		{
			var request = new GetRankInfoRequest();
			_socket.request<GetRankInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRankInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveRankNotify(int c2s_selectedRankId)
		{
			var notify = new SaveRankNotify();
			notify.c2s_selectedRankId= c2s_selectedRankId;

			_socket.notify(notify);

		}
		public void onAwardRankPush(Action<OnAwardRankPush> cb)
		{
			_socket.listen_once<OnAwardRankPush>(cb);
		}

	}


}