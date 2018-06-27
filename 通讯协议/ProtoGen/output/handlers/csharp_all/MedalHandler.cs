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
	public class MedalHandler
	{
		private PomeloClient _socket;

		public GetMedalInfoResponse lastGetMedalInfoResponse { get { return _socket.GetLastResponse<GetMedalInfoResponse>(); } }
		public GainMedalResponse lastGainMedalResponse { get { return _socket.GetLastResponse<GainMedalResponse>(); } }
		public MedalListResponse lastMedalListResponse { get { return _socket.GetLastResponse<MedalListResponse>(); } }
		public GetMedalInfoByCodeResponse lastGetMedalInfoByCodeResponse { get { return _socket.GetLastResponse<GetMedalInfoByCodeResponse>(); } }
		static MedalHandler()
		{
			EventTypes.RegistPushType("area.medalPush.medalTitleChangePush", typeof(MedalTitleChangePush));
			EventTypes.RegistRequestType("area.medalHandler.getMedalInfoRequest", typeof(GetMedalInfoRequest), typeof(GetMedalInfoResponse));
			EventTypes.RegistRequestType("area.medalHandler.gainMedalRequest", typeof(GainMedalRequest), typeof(GainMedalResponse));
			EventTypes.RegistRequestType("area.medalHandler.medalListRequest", typeof(MedalListRequest), typeof(MedalListResponse));
			EventTypes.RegistRequestType("area.medalHandler.getMedalInfoByCodeRequest", typeof(GetMedalInfoByCodeRequest), typeof(GetMedalInfoByCodeResponse));
		}
		public MedalHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getMedalInfoRequest(Action<PomeloException,GetMedalInfoResponse> cb,object option = null)
		{
			var request = new GetMedalInfoRequest();
			_socket.request<GetMedalInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMedalInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void gainMedalRequest(string c2s_id,Action<PomeloException,GainMedalResponse> cb,object option = null)
		{
			var request = new GainMedalRequest();
			request.c2s_id= c2s_id;
			_socket.request<GainMedalResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GainMedalResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void medalListRequest(Action<PomeloException,MedalListResponse> cb,object option = null)
		{
			var request = new MedalListRequest();
			_socket.request<MedalListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MedalListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMedalInfoByCodeRequest(string c2s_code,Action<PomeloException,GetMedalInfoByCodeResponse> cb,object option = null)
		{
			var request = new GetMedalInfoByCodeRequest();
			request.c2s_code= c2s_code;
			_socket.request<GetMedalInfoByCodeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMedalInfoByCodeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onMedalTitleChangePush(Action<MedalTitleChangePush> cb)
		{
			_socket.listen_once<MedalTitleChangePush>(cb);
		}

	}


}