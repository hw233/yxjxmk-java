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
	public class TeamHandler
	{
		private PomeloClient _socket;

		public GotoTeamTargetResponse lastGotoTeamTargetResponse { get { return _socket.GetLastResponse<GotoTeamTargetResponse>(); } }
		public SummonResponse lastSummonResponse { get { return _socket.GetLastResponse<SummonResponse>(); } }
		public SummonConfirmResponse lastSummonConfirmResponse { get { return _socket.GetLastResponse<SummonConfirmResponse>(); } }
		public AutoJoinTeamResponse lastAutoJoinTeamResponse { get { return _socket.GetLastResponse<AutoJoinTeamResponse>(); } }
		public JoinTeamResponse lastJoinTeamResponse { get { return _socket.GetLastResponse<JoinTeamResponse>(); } }
		public GetAppliedPlayersResponse lastGetAppliedPlayersResponse { get { return _socket.GetLastResponse<GetAppliedPlayersResponse>(); } }
		public GetPlayersByTypeResponse lastGetPlayersByTypeResponse { get { return _socket.GetLastResponse<GetPlayersByTypeResponse>(); } }
		public QueryTeamByTargetResponse lastQueryTeamByTargetResponse { get { return _socket.GetLastResponse<QueryTeamByTargetResponse>(); } }
		public SetTeamTargetResponse lastSetTeamTargetResponse { get { return _socket.GetLastResponse<SetTeamTargetResponse>(); } }
		public CreateTeamResponse lastCreateTeamResponse { get { return _socket.GetLastResponse<CreateTeamResponse>(); } }
		public FollowLeaderResponse lastFollowLeaderResponse { get { return _socket.GetLastResponse<FollowLeaderResponse>(); } }
		public FormTeamResponse lastFormTeamResponse { get { return _socket.GetLastResponse<FormTeamResponse>(); } }
		public GetTeamMembersResponse lastGetTeamMembersResponse { get { return _socket.GetLastResponse<GetTeamMembersResponse>(); } }
		public GetNearbyPlayersResponse lastGetNearbyPlayersResponse { get { return _socket.GetLastResponse<GetNearbyPlayersResponse>(); } }
		public GetNearTeamsResponse lastGetNearTeamsResponse { get { return _socket.GetLastResponse<GetNearTeamsResponse>(); } }
		public ChangeTeamLeaderResponse lastChangeTeamLeaderResponse { get { return _socket.GetLastResponse<ChangeTeamLeaderResponse>(); } }
		public KickOutTeamResponse lastKickOutTeamResponse { get { return _socket.GetLastResponse<KickOutTeamResponse>(); } }
		public LeaveTeamResponse lastLeaveTeamResponse { get { return _socket.GetLastResponse<LeaveTeamResponse>(); } }
		public SetAutoAcceptTeamResponse lastSetAutoAcceptTeamResponse { get { return _socket.GetLastResponse<SetAutoAcceptTeamResponse>(); } }
		public CancelAutoResponse lastCancelAutoResponse { get { return _socket.GetLastResponse<CancelAutoResponse>(); } }
		public AcrossMatchResponse lastAcrossMatchResponse { get { return _socket.GetLastResponse<AcrossMatchResponse>(); } }
		public LeaveAcrossMatchResponse lastLeaveAcrossMatchResponse { get { return _socket.GetLastResponse<LeaveAcrossMatchResponse>(); } }
		static TeamHandler()
		{
			EventTypes.RegistPushType("area.teamPush.onSummonTeamPush", typeof(OnSummonTeamPush));
			EventTypes.RegistPushType("area.teamPush.onTeamUpdatePush", typeof(OnTeamUpdatePush));
			EventTypes.RegistPushType("area.teamPush.onTeamMemberUpdatePush", typeof(OnTeamMemberUpdatePush));
			EventTypes.RegistPushType("area.teamPush.onTeamTargetPush", typeof(OnTeamTargetPush));
			EventTypes.RegistPushType("area.teamPush.onAcrossTeamInfoPush", typeof(OnAcrossTeamInfoPush));
			EventTypes.RegistRequestType("area.teamHandler.gotoTeamTargetRequest", typeof(GotoTeamTargetRequest), typeof(GotoTeamTargetResponse));
			EventTypes.RegistRequestType("area.teamHandler.summonRequest", typeof(SummonRequest), typeof(SummonResponse));
			EventTypes.RegistRequestType("area.teamHandler.summonConfirmRequest", typeof(SummonConfirmRequest), typeof(SummonConfirmResponse));
			EventTypes.RegistRequestType("area.teamHandler.autoJoinTeamRequest", typeof(AutoJoinTeamRequest), typeof(AutoJoinTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.joinTeamRequest", typeof(JoinTeamRequest), typeof(JoinTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.getAppliedPlayersRequest", typeof(GetAppliedPlayersRequest), typeof(GetAppliedPlayersResponse));
			EventTypes.RegistRequestType("area.teamHandler.getPlayersByTypeRequest", typeof(GetPlayersByTypeRequest), typeof(GetPlayersByTypeResponse));
			EventTypes.RegistRequestType("area.teamHandler.queryTeamByTargetRequest", typeof(QueryTeamByTargetRequest), typeof(QueryTeamByTargetResponse));
			EventTypes.RegistRequestType("area.teamHandler.setTeamTargetRequest", typeof(SetTeamTargetRequest), typeof(SetTeamTargetResponse));
			EventTypes.RegistRequestType("area.teamHandler.createTeamRequest", typeof(CreateTeamRequest), typeof(CreateTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.followLeaderRequest", typeof(FollowLeaderRequest), typeof(FollowLeaderResponse));
			EventTypes.RegistRequestType("area.teamHandler.formTeamRequest", typeof(FormTeamRequest), typeof(FormTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.getTeamMembersRequest", typeof(GetTeamMembersRequest), typeof(GetTeamMembersResponse));
			EventTypes.RegistRequestType("area.teamHandler.getNearbyPlayersRequest", typeof(GetNearbyPlayersRequest), typeof(GetNearbyPlayersResponse));
			EventTypes.RegistRequestType("area.teamHandler.getNearTeamsRequest", typeof(GetNearTeamsRequest), typeof(GetNearTeamsResponse));
			EventTypes.RegistRequestType("area.teamHandler.changeTeamLeaderRequest", typeof(ChangeTeamLeaderRequest), typeof(ChangeTeamLeaderResponse));
			EventTypes.RegistRequestType("area.teamHandler.kickOutTeamRequest", typeof(KickOutTeamRequest), typeof(KickOutTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.leaveTeamRequest", typeof(LeaveTeamRequest), typeof(LeaveTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.setAutoAcceptTeamRequest", typeof(SetAutoAcceptTeamRequest), typeof(SetAutoAcceptTeamResponse));
			EventTypes.RegistRequestType("area.teamHandler.cancelAutoRequest", typeof(CancelAutoRequest), typeof(CancelAutoResponse));
			EventTypes.RegistRequestType("area.teamHandler.acrossMatchRequest", typeof(AcrossMatchRequest), typeof(AcrossMatchResponse));
			EventTypes.RegistRequestType("area.teamHandler.leaveAcrossMatchRequest", typeof(LeaveAcrossMatchRequest), typeof(LeaveAcrossMatchResponse));
		}
		public TeamHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void gotoTeamTargetRequest(int targetId,int difficulty,Action<PomeloException,GotoTeamTargetResponse> cb,object option = null)
		{
			var request = new GotoTeamTargetRequest();
			request.targetId= targetId;
			request.difficulty= difficulty;
			_socket.request<GotoTeamTargetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GotoTeamTargetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void summonRequest(string c2s_teamMemberId,Action<PomeloException,SummonResponse> cb,object option = null)
		{
			var request = new SummonRequest();
			request.c2s_teamMemberId= c2s_teamMemberId;
			_socket.request<SummonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SummonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void summonConfirmRequest(string c2s_id,int s2c_operate,Action<PomeloException,SummonConfirmResponse> cb,object option = null)
		{
			var request = new SummonConfirmRequest();
			request.c2s_id= c2s_id;
			request.s2c_operate= s2c_operate;
			_socket.request<SummonConfirmResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SummonConfirmResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void autoJoinTeamRequest(int c2s_targetId,int c2s_difficulty,Action<PomeloException,AutoJoinTeamResponse> cb,object option = null)
		{
			var request = new AutoJoinTeamRequest();
			request.c2s_targetId= c2s_targetId;
			request.c2s_difficulty= c2s_difficulty;
			_socket.request<AutoJoinTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AutoJoinTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinTeamRequest(string c2s_teamId,Action<PomeloException,JoinTeamResponse> cb,object option = null)
		{
			var request = new JoinTeamRequest();
			request.c2s_teamId= c2s_teamId;
			_socket.request<JoinTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAppliedPlayersRequest(Action<PomeloException,GetAppliedPlayersResponse> cb,object option = null)
		{
			var request = new GetAppliedPlayersRequest();
			_socket.request<GetAppliedPlayersResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAppliedPlayersResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getPlayersByTypeRequest(int c2s_type,Action<PomeloException,GetPlayersByTypeResponse> cb,object option = null)
		{
			var request = new GetPlayersByTypeRequest();
			request.c2s_type= c2s_type;
			_socket.request<GetPlayersByTypeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetPlayersByTypeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryTeamByTargetRequest(int c2s_targetId,int c2s_difficulty,Action<PomeloException,QueryTeamByTargetResponse> cb,object option = null)
		{
			var request = new QueryTeamByTargetRequest();
			request.c2s_targetId= c2s_targetId;
			request.c2s_difficulty= c2s_difficulty;
			_socket.request<QueryTeamByTargetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryTeamByTargetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setTeamTargetRequest(int c2s_targetId,int c2s_difficulty,int c2s_minLevel,int c2s_maxLevel,int c2s_isAutoTeam,int c2s_isAutoStart,Action<PomeloException,SetTeamTargetResponse> cb,object option = null)
		{
			var request = new SetTeamTargetRequest();
			request.c2s_targetId= c2s_targetId;
			request.c2s_difficulty= c2s_difficulty;
			request.c2s_minLevel= c2s_minLevel;
			request.c2s_maxLevel= c2s_maxLevel;
			request.c2s_isAutoTeam= c2s_isAutoTeam;
			request.c2s_isAutoStart= c2s_isAutoStart;
			_socket.request<SetTeamTargetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetTeamTargetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void createTeamRequest(Action<PomeloException,CreateTeamResponse> cb,object option = null)
		{
			var request = new CreateTeamRequest();
			_socket.request<CreateTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CreateTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void followLeaderRequest(int follow,Action<PomeloException,FollowLeaderResponse> cb,object option = null)
		{
			var request = new FollowLeaderRequest();
			request.follow= follow;
			_socket.request<FollowLeaderResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FollowLeaderResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void formTeamRequest(string c2s_playerId,Action<PomeloException,FormTeamResponse> cb,object option = null)
		{
			var request = new FormTeamRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<FormTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FormTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getTeamMembersRequest(Action<PomeloException,GetTeamMembersResponse> cb,object option = null)
		{
			var request = new GetTeamMembersRequest();
			_socket.request<GetTeamMembersResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetTeamMembersResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getNearbyPlayersRequest(Action<PomeloException,GetNearbyPlayersResponse> cb,object option = null)
		{
			var request = new GetNearbyPlayersRequest();
			_socket.request<GetNearbyPlayersResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetNearbyPlayersResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getNearTeamsRequest(Action<PomeloException,GetNearTeamsResponse> cb,object option = null)
		{
			var request = new GetNearTeamsRequest();
			_socket.request<GetNearTeamsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetNearTeamsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeTeamLeaderRequest(string c2s_playerId,Action<PomeloException,ChangeTeamLeaderResponse> cb,object option = null)
		{
			var request = new ChangeTeamLeaderRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<ChangeTeamLeaderResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeTeamLeaderResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void kickOutTeamRequest(string c2s_playerId,Action<PomeloException,KickOutTeamResponse> cb,object option = null)
		{
			var request = new KickOutTeamRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<KickOutTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as KickOutTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveTeamRequest(Action<PomeloException,LeaveTeamResponse> cb,object option = null)
		{
			var request = new LeaveTeamRequest();
			_socket.request<LeaveTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setAutoAcceptTeamRequest(int c2s_isAccept,Action<PomeloException,SetAutoAcceptTeamResponse> cb,object option = null)
		{
			var request = new SetAutoAcceptTeamRequest();
			request.c2s_isAccept= c2s_isAccept;
			_socket.request<SetAutoAcceptTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetAutoAcceptTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cancelAutoRequest(Action<PomeloException,CancelAutoResponse> cb,object option = null)
		{
			var request = new CancelAutoRequest();
			_socket.request<CancelAutoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CancelAutoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void acrossMatchRequest(int targetId,int difficulty,Action<PomeloException,AcrossMatchResponse> cb,object option = null)
		{
			var request = new AcrossMatchRequest();
			request.targetId= targetId;
			request.difficulty= difficulty;
			_socket.request<AcrossMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AcrossMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveAcrossMatchRequest(Action<PomeloException,LeaveAcrossMatchResponse> cb,object option = null)
		{
			var request = new LeaveAcrossMatchRequest();
			_socket.request<LeaveAcrossMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveAcrossMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSummonTeamPush(Action<OnSummonTeamPush> cb)
		{
			_socket.listen_once<OnSummonTeamPush>(cb);
		}
		public void onTeamUpdatePush(Action<OnTeamUpdatePush> cb)
		{
			_socket.listen_once<OnTeamUpdatePush>(cb);
		}
		public void onTeamMemberUpdatePush(Action<OnTeamMemberUpdatePush> cb)
		{
			_socket.listen_once<OnTeamMemberUpdatePush>(cb);
		}
		public void onTeamTargetPush(Action<OnTeamTargetPush> cb)
		{
			_socket.listen_once<OnTeamTargetPush>(cb);
		}
		public void onAcrossTeamInfoPush(Action<OnAcrossTeamInfoPush> cb)
		{
			_socket.listen_once<OnAcrossTeamInfoPush>(cb);
		}

	}


}