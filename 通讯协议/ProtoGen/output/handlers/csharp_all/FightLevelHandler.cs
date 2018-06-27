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
	public class FightLevelHandler
	{
		private PomeloClient _socket;

		public FubenListResponse lastFubenListResponse { get { return _socket.GetLastResponse<FubenListResponse>(); } }
		public EnterDungeonResponse lastEnterDungeonResponse { get { return _socket.GetLastResponse<EnterDungeonResponse>(); } }
		public ReplyEnterDungeonResponse lastReplyEnterDungeonResponse { get { return _socket.GetLastResponse<ReplyEnterDungeonResponse>(); } }
		public LeaveDungeonResponse lastLeaveDungeonResponse { get { return _socket.GetLastResponse<LeaveDungeonResponse>(); } }
		public WorldBossListResponse lastWorldBossListResponse { get { return _socket.GetLastResponse<WorldBossListResponse>(); } }
		public EnterWorldBossResponse lastEnterWorldBossResponse { get { return _socket.GetLastResponse<EnterWorldBossResponse>(); } }
		public GetMonsterLeaderResponse lastGetMonsterLeaderResponse { get { return _socket.GetLastResponse<GetMonsterLeaderResponse>(); } }
		public PalaceListResponse lastPalaceListResponse { get { return _socket.GetLastResponse<PalaceListResponse>(); } }
		public GetBossInfoResponse lastGetBossInfoResponse { get { return _socket.GetLastResponse<GetBossInfoResponse>(); } }
		public GetBossDamageRankResponse lastGetBossDamageRankResponse { get { return _socket.GetLastResponse<GetBossDamageRankResponse>(); } }
		public GetLllsionInfoResponse lastGetLllsionInfoResponse { get { return _socket.GetLastResponse<GetLllsionInfoResponse>(); } }
		public EnterLllsionResponse lastEnterLllsionResponse { get { return _socket.GetLastResponse<EnterLllsionResponse>(); } }
		public GetLllsionBossInfoResponse lastGetLllsionBossInfoResponse { get { return _socket.GetLastResponse<GetLllsionBossInfoResponse>(); } }
		public EnterLllsionBossResponse lastEnterLllsionBossResponse { get { return _socket.GetLastResponse<EnterLllsionBossResponse>(); } }
		public GetBenifitableResponse lastGetBenifitableResponse { get { return _socket.GetLastResponse<GetBenifitableResponse>(); } }
		public GetLllsion2InfoResponse lastGetLllsion2InfoResponse { get { return _socket.GetLastResponse<GetLllsion2InfoResponse>(); } }
		public EnterLllsion2Response lastEnterLllsion2Response { get { return _socket.GetLastResponse<EnterLllsion2Response>(); } }
		static FightLevelHandler()
		{
			EventTypes.RegistPushType("area.fightLevelPush.onConfirmEnterFubenPush", typeof(OnConfirmEnterFubenPush));
			EventTypes.RegistPushType("area.fightLevelPush.onMemberEnterFubenStateChangePush", typeof(OnMemberEnterFubenStateChangePush));
			EventTypes.RegistPushType("area.fightLevelPush.onFubenClosePush", typeof(OnFubenClosePush));
			EventTypes.RegistPushType("area.fightLevelPush.closeHandUpPush", typeof(CloseHandUpPush));
			EventTypes.RegistPushType("area.fightLevelPush.illusionPush", typeof(IllusionPush));
			EventTypes.RegistPushType("area.fightLevelPush.illusion2Push", typeof(Illusion2Push));
			EventTypes.RegistRequestType("area.fightLevelHandler.fubenListRequest", typeof(FubenListRequest), typeof(FubenListResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.enterDungeonRequest", typeof(EnterDungeonRequest), typeof(EnterDungeonResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.replyEnterDungeonRequest", typeof(ReplyEnterDungeonRequest), typeof(ReplyEnterDungeonResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.leaveDungeonRequest", typeof(LeaveDungeonRequest), typeof(LeaveDungeonResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.worldBossListRequest", typeof(WorldBossListRequest), typeof(WorldBossListResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.enterWorldBossRequest", typeof(EnterWorldBossRequest), typeof(EnterWorldBossResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getMonsterLeaderRequest", typeof(GetMonsterLeaderRequest), typeof(GetMonsterLeaderResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.palaceListRequest", typeof(PalaceListRequest), typeof(PalaceListResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getBossInfoRequest", typeof(GetBossInfoRequest), typeof(GetBossInfoResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getBossDamageRankRequest", typeof(GetBossDamageRankRequest), typeof(GetBossDamageRankResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getLllsionInfoRequest", typeof(GetLllsionInfoRequest), typeof(GetLllsionInfoResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.enterLllsionRequest", typeof(EnterLllsionRequest), typeof(EnterLllsionResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getLllsionBossInfoRequest", typeof(GetLllsionBossInfoRequest), typeof(GetLllsionBossInfoResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.enterLllsionBossRequest", typeof(EnterLllsionBossRequest), typeof(EnterLllsionBossResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getBenifitableRequest", typeof(GetBenifitableRequest), typeof(GetBenifitableResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.getLllsion2InfoRequest", typeof(GetLllsion2InfoRequest), typeof(GetLllsion2InfoResponse));
			EventTypes.RegistRequestType("area.fightLevelHandler.enterLllsion2Request", typeof(EnterLllsion2Request), typeof(EnterLllsion2Response));
		}
		public FightLevelHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void fubenListRequest(int mapId,Action<PomeloException,FubenListResponse> cb,object option = null)
		{
			var request = new FubenListRequest();
			request.mapId= mapId;
			_socket.request<FubenListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FubenListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterDungeonRequest(int c2s_dungeonId,Action<PomeloException,EnterDungeonResponse> cb,object option = null)
		{
			var request = new EnterDungeonRequest();
			request.c2s_dungeonId= c2s_dungeonId;
			_socket.request<EnterDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void replyEnterDungeonRequest(int c2s_type,int c2s_dungeonId,Action<PomeloException,ReplyEnterDungeonResponse> cb,object option = null)
		{
			var request = new ReplyEnterDungeonRequest();
			request.c2s_type= c2s_type;
			request.c2s_dungeonId= c2s_dungeonId;
			_socket.request<ReplyEnterDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReplyEnterDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveDungeonRequest(Action<PomeloException,LeaveDungeonResponse> cb,object option = null)
		{
			var request = new LeaveDungeonRequest();
			_socket.request<LeaveDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void worldBossListRequest(Action<PomeloException,WorldBossListResponse> cb,object option = null)
		{
			var request = new WorldBossListRequest();
			_socket.request<WorldBossListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as WorldBossListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterWorldBossRequest(int s2c_areaId,Action<PomeloException,EnterWorldBossResponse> cb,object option = null)
		{
			var request = new EnterWorldBossRequest();
			request.s2c_areaId= s2c_areaId;
			_socket.request<EnterWorldBossResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterWorldBossResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMonsterLeaderRequest(int s2c_monsterId,int s2c_areaId,Action<PomeloException,GetMonsterLeaderResponse> cb,object option = null)
		{
			var request = new GetMonsterLeaderRequest();
			request.s2c_monsterId= s2c_monsterId;
			request.s2c_areaId= s2c_areaId;
			_socket.request<GetMonsterLeaderResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMonsterLeaderResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void palaceListRequest(int s2c_type,Action<PomeloException,PalaceListResponse> cb,object option = null)
		{
			var request = new PalaceListRequest();
			request.s2c_type= s2c_type;
			_socket.request<PalaceListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PalaceListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBossInfoRequest(Action<PomeloException,GetBossInfoResponse> cb,object option = null)
		{
			var request = new GetBossInfoRequest();
			_socket.request<GetBossInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBossInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBossDamageRankRequest(Action<PomeloException,GetBossDamageRankResponse> cb,object option = null)
		{
			var request = new GetBossDamageRankRequest();
			_socket.request<GetBossDamageRankResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBossDamageRankResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getLllsionInfoRequest(Action<PomeloException,GetLllsionInfoResponse> cb,object option = null)
		{
			var request = new GetLllsionInfoRequest();
			_socket.request<GetLllsionInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLllsionInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterLllsionRequest(int c2s_id,Action<PomeloException,EnterLllsionResponse> cb,object option = null)
		{
			var request = new EnterLllsionRequest();
			request.c2s_id= c2s_id;
			_socket.request<EnterLllsionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterLllsionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getLllsionBossInfoRequest(Action<PomeloException,GetLllsionBossInfoResponse> cb,object option = null)
		{
			var request = new GetLllsionBossInfoRequest();
			_socket.request<GetLllsionBossInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLllsionBossInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterLllsionBossRequest(int c2s_id,Action<PomeloException,EnterLllsionBossResponse> cb,object option = null)
		{
			var request = new EnterLllsionBossRequest();
			request.c2s_id= c2s_id;
			_socket.request<EnterLllsionBossResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterLllsionBossResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getBenifitableRequest(Action<PomeloException,GetBenifitableResponse> cb,object option = null)
		{
			var request = new GetBenifitableRequest();
			_socket.request<GetBenifitableResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetBenifitableResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getLllsion2InfoRequest(Action<PomeloException,GetLllsion2InfoResponse> cb,object option = null)
		{
			var request = new GetLllsion2InfoRequest();
			_socket.request<GetLllsion2InfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLllsion2InfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterLllsion2Request(Action<PomeloException,EnterLllsion2Response> cb,object option = null)
		{
			var request = new EnterLllsion2Request();
			_socket.request<EnterLllsion2Response>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterLllsion2Response;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onConfirmEnterFubenPush(Action<OnConfirmEnterFubenPush> cb)
		{
			_socket.listen_once<OnConfirmEnterFubenPush>(cb);
		}
		public void onMemberEnterFubenStateChangePush(Action<OnMemberEnterFubenStateChangePush> cb)
		{
			_socket.listen_once<OnMemberEnterFubenStateChangePush>(cb);
		}
		public void onFubenClosePush(Action<OnFubenClosePush> cb)
		{
			_socket.listen_once<OnFubenClosePush>(cb);
		}
		public void onCloseHandUpPush(Action<CloseHandUpPush> cb)
		{
			_socket.listen_once<CloseHandUpPush>(cb);
		}
		public void onIllusionPush(Action<IllusionPush> cb)
		{
			_socket.listen_once<IllusionPush>(cb);
		}
		public void onIllusion2Push(Action<Illusion2Push> cb)
		{
			_socket.listen_once<Illusion2Push>(cb);
		}

	}


}