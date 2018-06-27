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
	public class GuildBossHandler
	{
		private PomeloClient _socket;

		public EnterGuildBossAreaResponse lastEnterGuildBossAreaResponse { get { return _socket.GetLastResponse<EnterGuildBossAreaResponse>(); } }
		public GetGuildBossInfoResponse lastGetGuildBossInfoResponse { get { return _socket.GetLastResponse<GetGuildBossInfoResponse>(); } }
		public GuildBossInspireResponse lastGuildBossInspireResponse { get { return _socket.GetLastResponse<GuildBossInspireResponse>(); } }
		static GuildBossHandler()
		{
			EventTypes.RegistPushType("area.guildBossPush.onHurtRankChangePush", typeof(OnHurtRankChangePush));
			EventTypes.RegistPushType("area.guildBossPush.onInspireSingleChangePush", typeof(OnInspireSingleChangePush));
			EventTypes.RegistPushType("area.guildBossPush.onInspireGuildChangePush", typeof(OnInspireGuildChangePush));
			EventTypes.RegistPushType("area.guildBossPush.onGuildBossOverPush", typeof(OnGuildBossOverPush));
			EventTypes.RegistPushType("area.guildBossPush.onQuitGuildBossPush", typeof(OnQuitGuildBossPush));
			EventTypes.RegistRequestType("area.guildBossHandler.enterGuildBossAreaRequest", typeof(EnterGuildBossAreaRequest), typeof(EnterGuildBossAreaResponse));
			EventTypes.RegistRequestType("area.guildBossHandler.getGuildBossInfoRequest", typeof(GetGuildBossInfoRequest), typeof(GetGuildBossInfoResponse));
			EventTypes.RegistRequestType("area.guildBossHandler.guildBossInspireRequest", typeof(GuildBossInspireRequest), typeof(GuildBossInspireResponse));
		}
		public GuildBossHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void enterGuildBossAreaRequest(Action<PomeloException,EnterGuildBossAreaResponse> cb,object option = null)
		{
			var request = new EnterGuildBossAreaRequest();
			_socket.request<EnterGuildBossAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterGuildBossAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGuildBossInfoRequest(Action<PomeloException,GetGuildBossInfoResponse> cb,object option = null)
		{
			var request = new GetGuildBossInfoRequest();
			_socket.request<GetGuildBossInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildBossInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void guildBossInspireRequest(int c2s_index,Action<PomeloException,GuildBossInspireResponse> cb,object option = null)
		{
			var request = new GuildBossInspireRequest();
			request.c2s_index= c2s_index;
			_socket.request<GuildBossInspireResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GuildBossInspireResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onHurtRankChangePush(Action<OnHurtRankChangePush> cb)
		{
			_socket.listen_once<OnHurtRankChangePush>(cb);
		}
		public void onInspireSingleChangePush(Action<OnInspireSingleChangePush> cb)
		{
			_socket.listen_once<OnInspireSingleChangePush>(cb);
		}
		public void onInspireGuildChangePush(Action<OnInspireGuildChangePush> cb)
		{
			_socket.listen_once<OnInspireGuildChangePush>(cb);
		}
		public void onGuildBossOverPush(Action<OnGuildBossOverPush> cb)
		{
			_socket.listen_once<OnGuildBossOverPush>(cb);
		}
		public void onQuitGuildBossPush(Action<OnQuitGuildBossPush> cb)
		{
			_socket.listen_once<OnQuitGuildBossPush>(cb);
		}

	}


}