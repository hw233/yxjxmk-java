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

namespace pomelo.guild
{
	public class GuildManagerHandler
	{
		private PomeloClient _socket;

		public GetDepotAllGridsResponse lastGetDepotAllGridsResponse { get { return _socket.GetLastResponse<GetDepotAllGridsResponse>(); } }
		public GetDepotAllDetailsResponse lastGetDepotAllDetailsResponse { get { return _socket.GetLastResponse<GetDepotAllDetailsResponse>(); } }
		public GetDepotOneGridInfoResponse lastGetDepotOneGridInfoResponse { get { return _socket.GetLastResponse<GetDepotOneGridInfoResponse>(); } }
		public GetDepotInfoResponse lastGetDepotInfoResponse { get { return _socket.GetLastResponse<GetDepotInfoResponse>(); } }
		public GetDepotRecordResponse lastGetDepotRecordResponse { get { return _socket.GetLastResponse<GetDepotRecordResponse>(); } }
		public GetBlessInfoResponse lastGetBlessInfoResponse { get { return _socket.GetLastResponse<GetBlessInfoResponse>(); } }
		public GetBlessRecordResponse lastGetBlessRecordResponse { get { return _socket.GetLastResponse<GetBlessRecordResponse>(); } }
		public GetBuildingLevelResponse lastGetBuildingLevelResponse { get { return _socket.GetLastResponse<GetBuildingLevelResponse>(); } }
		public OpenGuildDungeonResponse lastOpenGuildDungeonResponse { get { return _socket.GetLastResponse<OpenGuildDungeonResponse>(); } }
		public GuildDungeonListResponse lastGuildDungeonListResponse { get { return _socket.GetLastResponse<GuildDungeonListResponse>(); } }
		public DungeonRankResponse lastDungeonRankResponse { get { return _socket.GetLastResponse<DungeonRankResponse>(); } }
		public DungeonAwardInfoResponse lastDungeonAwardInfoResponse { get { return _socket.GetLastResponse<DungeonAwardInfoResponse>(); } }
		public DiceAwardResponse lastDiceAwardResponse { get { return _socket.GetLastResponse<DiceAwardResponse>(); } }
		static GuildManagerHandler()
		{
			EventTypes.RegistRequestType("guild.guildManagerHandler.getDepotAllGridsRequest", typeof(GetDepotAllGridsRequest), typeof(GetDepotAllGridsResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getDepotAllDetailsRequest", typeof(GetDepotAllDetailsRequest), typeof(GetDepotAllDetailsResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getDepotOneGridInfoRequest", typeof(GetDepotOneGridInfoRequest), typeof(GetDepotOneGridInfoResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getDepotInfoRequest", typeof(GetDepotInfoRequest), typeof(GetDepotInfoResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getDepotRecordRequest", typeof(GetDepotRecordRequest), typeof(GetDepotRecordResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getBlessInfoRequest", typeof(GetBlessInfoRequest), typeof(GetBlessInfoResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getBlessRecordRequest", typeof(GetBlessRecordRequest), typeof(GetBlessRecordResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.getBuildingLevelRequest", typeof(GetBuildingLevelRequest), typeof(GetBuildingLevelResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.openGuildDungeonRequest", typeof(OpenGuildDungeonRequest), typeof(OpenGuildDungeonResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.guildDungeonListRequest", typeof(GuildDungeonListRequest), typeof(GuildDungeonListResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.dungeonRankRequest", typeof(DungeonRankRequest), typeof(DungeonRankResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.dungeonAwardInfoRequest", typeof(DungeonAwardInfoRequest), typeof(DungeonAwardInfoResponse));
			EventTypes.RegistRequestType("guild.guildManagerHandler.diceAwardRequest", typeof(DiceAwardRequest), typeof(DiceAwardResponse));
		}
		public GuildManagerHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getDepotAllGridsRequest(Action<PomeloException,GetDepotAllGridsResponse> cb,object option = null)
		{
			var request = new GetDepotAllGridsRequest();
			_socket.request<GetDepotAllGridsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDepotAllGridsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDepotAllDetailsRequest(Action<PomeloException,GetDepotAllDetailsResponse> cb,object option = null)
		{
			var request = new GetDepotAllDetailsRequest();
			_socket.request<GetDepotAllDetailsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDepotAllDetailsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDepotOneGridInfoRequest(int bagIndex,Action<PomeloException,GetDepotOneGridInfoResponse> cb,object option = null)
		{
			var request = new GetDepotOneGridInfoRequest();
			request.bagIndex= bagIndex;
			_socket.request<GetDepotOneGridInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDepotOneGridInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDepotInfoRequest(Action<PomeloException,GetDepotInfoResponse> cb,object option = null)
		{
			var request = new GetDepotInfoRequest();
			_socket.request<GetDepotInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDepotInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDepotRecordRequest(int page,Action<PomeloException,GetDepotRecordResponse> cb,object option = null)
		{
			var request = new GetDepotRecordRequest();
			request.page= page;
			_socket.request<GetDepotRecordResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDepotRecordResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBlessInfoRequest(Action<PomeloException,GetBlessInfoResponse> cb,object option = null)
		{
			var request = new GetBlessInfoRequest();
			_socket.request<GetBlessInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBlessInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBlessRecordRequest(int page,Action<PomeloException,GetBlessRecordResponse> cb,object option = null)
		{
			var request = new GetBlessRecordRequest();
			request.page= page;
			_socket.request<GetBlessRecordResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBlessRecordResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBuildingLevelRequest(Action<PomeloException,GetBuildingLevelResponse> cb,object option = null)
		{
			var request = new GetBuildingLevelRequest();
			_socket.request<GetBuildingLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBuildingLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openGuildDungeonRequest(Action<PomeloException,OpenGuildDungeonResponse> cb,object option = null)
		{
			var request = new OpenGuildDungeonRequest();
			_socket.request<OpenGuildDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenGuildDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void guildDungeonListRequest(Action<PomeloException,GuildDungeonListResponse> cb,object option = null)
		{
			var request = new GuildDungeonListRequest();
			_socket.request<GuildDungeonListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GuildDungeonListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dungeonRankRequest(int s2c_type,Action<PomeloException,DungeonRankResponse> cb,object option = null)
		{
			var request = new DungeonRankRequest();
			request.s2c_type= s2c_type;
			_socket.request<DungeonRankResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DungeonRankResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dungeonAwardInfoRequest(Action<PomeloException,DungeonAwardInfoResponse> cb,object option = null)
		{
			var request = new DungeonAwardInfoRequest();
			_socket.request<DungeonAwardInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DungeonAwardInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void diceAwardRequest(int s2c_pos,Action<PomeloException,DiceAwardResponse> cb,object option = null)
		{
			var request = new DiceAwardRequest();
			request.s2c_pos= s2c_pos;
			_socket.request<DiceAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DiceAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}