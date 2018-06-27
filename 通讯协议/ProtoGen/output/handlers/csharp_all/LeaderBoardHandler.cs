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
	public class LeaderBoardHandler
	{
		private PomeloClient _socket;

		public LeaderBoardResponse lastLeaderBoardResponse { get { return _socket.GetLastResponse<LeaderBoardResponse>(); } }
		public GuildInfoResponse lastGuildInfoResponse { get { return _socket.GetLastResponse<GuildInfoResponse>(); } }
		public WorShipResponse lastWorShipResponse { get { return _socket.GetLastResponse<WorShipResponse>(); } }
		public WorldLevelInfoResponse lastWorldLevelInfoResponse { get { return _socket.GetLastResponse<WorldLevelInfoResponse>(); } }
		static LeaderBoardHandler()
		{
			EventTypes.RegistRequestType("area.leaderBoardHandler.leaderBoardRequest", typeof(LeaderBoardRequest), typeof(LeaderBoardResponse));
			EventTypes.RegistRequestType("area.leaderBoardHandler.guildInfoRequest", typeof(GuildInfoRequest), typeof(GuildInfoResponse));
			EventTypes.RegistRequestType("area.leaderBoardHandler.worShipRequest", typeof(WorShipRequest), typeof(WorShipResponse));
			EventTypes.RegistRequestType("area.leaderBoardHandler.worldLevelInfoRequest", typeof(WorldLevelInfoRequest), typeof(WorldLevelInfoResponse));
		}
		public LeaderBoardHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void leaderBoardRequest(int c2s_kind,int c2s_season,Action<PomeloException,LeaderBoardResponse> cb,object option = null)
		{
			var request = new LeaderBoardRequest();
			request.c2s_kind= c2s_kind;
			request.c2s_season= c2s_season;
			_socket.request<LeaderBoardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaderBoardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void guildInfoRequest(string c2s_guildId,Action<PomeloException,GuildInfoResponse> cb,object option = null)
		{
			var request = new GuildInfoRequest();
			request.c2s_guildId= c2s_guildId;
			_socket.request<GuildInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GuildInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void worShipRequest(int c2s_type,Action<PomeloException,WorShipResponse> cb,object option = null)
		{
			var request = new WorShipRequest();
			request.c2s_type= c2s_type;
			_socket.request<WorShipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as WorShipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void worldLevelInfoRequest(Action<PomeloException,WorldLevelInfoResponse> cb,object option = null)
		{
			var request = new WorldLevelInfoRequest();
			_socket.request<WorldLevelInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as WorldLevelInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}