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
	public class GuildHandler
	{
		private PomeloClient _socket;

		public CreateGuildResponse lastCreateGuildResponse { get { return _socket.GetLastResponse<CreateGuildResponse>(); } }
		public GetGuildListResponse lastGetGuildListResponse { get { return _socket.GetLastResponse<GetGuildListResponse>(); } }
		public JoinGuildResponse lastJoinGuildResponse { get { return _socket.GetLastResponse<JoinGuildResponse>(); } }
		public JoinGuildOfPlayerResponse lastJoinGuildOfPlayerResponse { get { return _socket.GetLastResponse<JoinGuildOfPlayerResponse>(); } }
		public InvitePlayerJoinMyGuildResponse lastInvitePlayerJoinMyGuildResponse { get { return _socket.GetLastResponse<InvitePlayerJoinMyGuildResponse>(); } }
		public AgreeOrRefuseInviteResponse lastAgreeOrRefuseInviteResponse { get { return _socket.GetLastResponse<AgreeOrRefuseInviteResponse>(); } }
		public DealApplyResponse lastDealApplyResponse { get { return _socket.GetLastResponse<DealApplyResponse>(); } }
		public GetMyGuildInfoResponse lastGetMyGuildInfoResponse { get { return _socket.GetLastResponse<GetMyGuildInfoResponse>(); } }
		public GetMyGuildMembersResponse lastGetMyGuildMembersResponse { get { return _socket.GetLastResponse<GetMyGuildMembersResponse>(); } }
		public GetApplyListResponse lastGetApplyListResponse { get { return _socket.GetLastResponse<GetApplyListResponse>(); } }
		public SetGuildInfoResponse lastSetGuildInfoResponse { get { return _socket.GetLastResponse<SetGuildInfoResponse>(); } }
		public SetGuildQQGroupResponse lastSetGuildQQGroupResponse { get { return _socket.GetLastResponse<SetGuildQQGroupResponse>(); } }
		public ExitGuildResponse lastExitGuildResponse { get { return _socket.GetLastResponse<ExitGuildResponse>(); } }
		public KickMemberResponse lastKickMemberResponse { get { return _socket.GetLastResponse<KickMemberResponse>(); } }
		public UpgradeGuildLevelResponse lastUpgradeGuildLevelResponse { get { return _socket.GetLastResponse<UpgradeGuildLevelResponse>(); } }
		public ChangeGuildNoticeResponse lastChangeGuildNoticeResponse { get { return _socket.GetLastResponse<ChangeGuildNoticeResponse>(); } }
		public ChangeGuildNameResponse lastChangeGuildNameResponse { get { return _socket.GetLastResponse<ChangeGuildNameResponse>(); } }
		public ChangeOfficeNameResponse lastChangeOfficeNameResponse { get { return _socket.GetLastResponse<ChangeOfficeNameResponse>(); } }
		public ContributeToGuildResponse lastContributeToGuildResponse { get { return _socket.GetLastResponse<ContributeToGuildResponse>(); } }
		public SetMemberJobResponse lastSetMemberJobResponse { get { return _socket.GetLastResponse<SetMemberJobResponse>(); } }
		public TransferPresidentResponse lastTransferPresidentResponse { get { return _socket.GetLastResponse<TransferPresidentResponse>(); } }
		public GetGuildRecordResponse lastGetGuildRecordResponse { get { return _socket.GetLastResponse<GetGuildRecordResponse>(); } }
		public ImpeachGuildPresidentResponse lastImpeachGuildPresidentResponse { get { return _socket.GetLastResponse<ImpeachGuildPresidentResponse>(); } }
		public GetGuildMoneyResponse lastGetGuildMoneyResponse { get { return _socket.GetLastResponse<GetGuildMoneyResponse>(); } }
		public JoinGuildDungeonResponse lastJoinGuildDungeonResponse { get { return _socket.GetLastResponse<JoinGuildDungeonResponse>(); } }
		public LeaveGuildDungeonResponse lastLeaveGuildDungeonResponse { get { return _socket.GetLastResponse<LeaveGuildDungeonResponse>(); } }
		static GuildHandler()
		{
			EventTypes.RegistPushType("area.guildPush.guildRefreshPush", typeof(GuildRefreshPush));
			EventTypes.RegistPushType("area.guildPush.guildInvitePush", typeof(GuildInvitePush));
			EventTypes.RegistPushType("area.guildPush.onDungeonEndPush", typeof(OnDungeonEndPush));
			EventTypes.RegistPushType("area.guildPush.guildDungeonOpenPush", typeof(GuildDungeonOpenPush));
			EventTypes.RegistPushType("area.guildPush.guildDungeonPassPush", typeof(GuildDungeonPassPush));
			EventTypes.RegistPushType("area.guildPush.guildDungeonPlayerNumPush", typeof(GuildDungeonPlayerNumPush));
			EventTypes.RegistRequestType("area.guildHandler.createGuildRequest", typeof(CreateGuildRequest), typeof(CreateGuildResponse));
			EventTypes.RegistRequestType("area.guildHandler.getGuildListRequest", typeof(GetGuildListRequest), typeof(GetGuildListResponse));
			EventTypes.RegistRequestType("area.guildHandler.joinGuildRequest", typeof(JoinGuildRequest), typeof(JoinGuildResponse));
			EventTypes.RegistRequestType("area.guildHandler.joinGuildOfPlayerRequest", typeof(JoinGuildOfPlayerRequest), typeof(JoinGuildOfPlayerResponse));
			EventTypes.RegistRequestType("area.guildHandler.invitePlayerJoinMyGuildRequest", typeof(InvitePlayerJoinMyGuildRequest), typeof(InvitePlayerJoinMyGuildResponse));
			EventTypes.RegistRequestType("area.guildHandler.agreeOrRefuseInviteRequest", typeof(AgreeOrRefuseInviteRequest), typeof(AgreeOrRefuseInviteResponse));
			EventTypes.RegistRequestType("area.guildHandler.dealApplyRequest", typeof(DealApplyRequest), typeof(DealApplyResponse));
			EventTypes.RegistRequestType("area.guildHandler.getMyGuildInfoRequest", typeof(GetMyGuildInfoRequest), typeof(GetMyGuildInfoResponse));
			EventTypes.RegistRequestType("area.guildHandler.getMyGuildMembersRequest", typeof(GetMyGuildMembersRequest), typeof(GetMyGuildMembersResponse));
			EventTypes.RegistRequestType("area.guildHandler.getApplyListRequest", typeof(GetApplyListRequest), typeof(GetApplyListResponse));
			EventTypes.RegistRequestType("area.guildHandler.setGuildInfoRequest", typeof(SetGuildInfoRequest), typeof(SetGuildInfoResponse));
			EventTypes.RegistRequestType("area.guildHandler.setGuildQQGroupRequest", typeof(SetGuildQQGroupRequest), typeof(SetGuildQQGroupResponse));
			EventTypes.RegistRequestType("area.guildHandler.exitGuildRequest", typeof(ExitGuildRequest), typeof(ExitGuildResponse));
			EventTypes.RegistRequestType("area.guildHandler.kickMemberRequest", typeof(KickMemberRequest), typeof(KickMemberResponse));
			EventTypes.RegistRequestType("area.guildHandler.upgradeGuildLevelRequest", typeof(UpgradeGuildLevelRequest), typeof(UpgradeGuildLevelResponse));
			EventTypes.RegistRequestType("area.guildHandler.changeGuildNoticeRequest", typeof(ChangeGuildNoticeRequest), typeof(ChangeGuildNoticeResponse));
			EventTypes.RegistRequestType("area.guildHandler.changeGuildNameRequest", typeof(ChangeGuildNameRequest), typeof(ChangeGuildNameResponse));
			EventTypes.RegistRequestType("area.guildHandler.changeOfficeNameRequest", typeof(ChangeOfficeNameRequest), typeof(ChangeOfficeNameResponse));
			EventTypes.RegistRequestType("area.guildHandler.contributeToGuildRequest", typeof(ContributeToGuildRequest), typeof(ContributeToGuildResponse));
			EventTypes.RegistRequestType("area.guildHandler.setMemberJobRequest", typeof(SetMemberJobRequest), typeof(SetMemberJobResponse));
			EventTypes.RegistRequestType("area.guildHandler.transferPresidentRequest", typeof(TransferPresidentRequest), typeof(TransferPresidentResponse));
			EventTypes.RegistRequestType("area.guildHandler.getGuildRecordRequest", typeof(GetGuildRecordRequest), typeof(GetGuildRecordResponse));
			EventTypes.RegistRequestType("area.guildHandler.impeachGuildPresidentRequest", typeof(ImpeachGuildPresidentRequest), typeof(ImpeachGuildPresidentResponse));
			EventTypes.RegistRequestType("area.guildHandler.getGuildMoneyRequest", typeof(GetGuildMoneyRequest), typeof(GetGuildMoneyResponse));
			EventTypes.RegistRequestType("area.guildHandler.joinGuildDungeonRequest", typeof(JoinGuildDungeonRequest), typeof(JoinGuildDungeonResponse));
			EventTypes.RegistRequestType("area.guildHandler.leaveGuildDungeonRequest", typeof(LeaveGuildDungeonRequest), typeof(LeaveGuildDungeonResponse));
		}
		public GuildHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void createGuildRequest(string c2s_icon,string c2s_name,string c2s_qqGroup,Action<PomeloException,CreateGuildResponse> cb,object option = null)
		{
			var request = new CreateGuildRequest();
			request.c2s_icon= c2s_icon;
			request.c2s_name= c2s_name;
			request.c2s_qqGroup= c2s_qqGroup;
			_socket.request<CreateGuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CreateGuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGuildListRequest(string c2s_name,Action<PomeloException,GetGuildListResponse> cb,object option = null)
		{
			var request = new GetGuildListRequest();
			request.c2s_name= c2s_name;
			_socket.request<GetGuildListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinGuildRequest(string c2s_guildId,Action<PomeloException,JoinGuildResponse> cb,object option = null)
		{
			var request = new JoinGuildRequest();
			request.c2s_guildId= c2s_guildId;
			_socket.request<JoinGuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinGuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinGuildOfPlayerRequest(string c2s_playerId,Action<PomeloException,JoinGuildOfPlayerResponse> cb,object option = null)
		{
			var request = new JoinGuildOfPlayerRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<JoinGuildOfPlayerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinGuildOfPlayerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void invitePlayerJoinMyGuildRequest(string c2s_playerId,Action<PomeloException,InvitePlayerJoinMyGuildResponse> cb,object option = null)
		{
			var request = new InvitePlayerJoinMyGuildRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<InvitePlayerJoinMyGuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InvitePlayerJoinMyGuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void agreeOrRefuseInviteRequest(int c2s_isAgree,string c2s_inviteId,string c2s_guildId,Action<PomeloException,AgreeOrRefuseInviteResponse> cb,object option = null)
		{
			var request = new AgreeOrRefuseInviteRequest();
			request.c2s_isAgree= c2s_isAgree;
			request.c2s_inviteId= c2s_inviteId;
			request.c2s_guildId= c2s_guildId;
			_socket.request<AgreeOrRefuseInviteResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AgreeOrRefuseInviteResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dealApplyRequest(string c2s_applyId,int c2s_operate,Action<PomeloException,DealApplyResponse> cb,object option = null)
		{
			var request = new DealApplyRequest();
			request.c2s_applyId= c2s_applyId;
			request.c2s_operate= c2s_operate;
			_socket.request<DealApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DealApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMyGuildInfoRequest(Action<PomeloException,GetMyGuildInfoResponse> cb,object option = null)
		{
			var request = new GetMyGuildInfoRequest();
			_socket.request<GetMyGuildInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMyGuildInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMyGuildMembersRequest(Action<PomeloException,GetMyGuildMembersResponse> cb,object option = null)
		{
			var request = new GetMyGuildMembersRequest();
			_socket.request<GetMyGuildMembersResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMyGuildMembersResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getApplyListRequest(Action<PomeloException,GetApplyListResponse> cb,object option = null)
		{
			var request = new GetApplyListRequest();
			_socket.request<GetApplyListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetApplyListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setGuildInfoRequest(int entryLevel,int guildMode,int entryUpLevel,Action<PomeloException,SetGuildInfoResponse> cb,object option = null)
		{
			var request = new SetGuildInfoRequest();
			request.entryLevel= entryLevel;
			request.guildMode= guildMode;
			request.entryUpLevel= entryUpLevel;
			_socket.request<SetGuildInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetGuildInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setGuildQQGroupRequest(string qqGroup,Action<PomeloException,SetGuildQQGroupResponse> cb,object option = null)
		{
			var request = new SetGuildQQGroupRequest();
			request.qqGroup= qqGroup;
			_socket.request<SetGuildQQGroupResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetGuildQQGroupResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void exitGuildRequest(Action<PomeloException,ExitGuildResponse> cb,object option = null)
		{
			var request = new ExitGuildRequest();
			_socket.request<ExitGuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ExitGuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void kickMemberRequest(string memberId,Action<PomeloException,KickMemberResponse> cb,object option = null)
		{
			var request = new KickMemberRequest();
			request.memberId= memberId;
			_socket.request<KickMemberResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as KickMemberResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeGuildLevelRequest(Action<PomeloException,UpgradeGuildLevelResponse> cb,object option = null)
		{
			var request = new UpgradeGuildLevelRequest();
			_socket.request<UpgradeGuildLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeGuildLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeGuildNoticeRequest(string notice,Action<PomeloException,ChangeGuildNoticeResponse> cb,object option = null)
		{
			var request = new ChangeGuildNoticeRequest();
			request.notice= notice;
			_socket.request<ChangeGuildNoticeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeGuildNoticeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeGuildNameRequest(string name,Action<PomeloException,ChangeGuildNameResponse> cb,object option = null)
		{
			var request = new ChangeGuildNameRequest();
			request.name= name;
			_socket.request<ChangeGuildNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeGuildNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeOfficeNameRequest(List<OfficeName> officeNames,Action<PomeloException,ChangeOfficeNameResponse> cb,object option = null)
		{
			var request = new ChangeOfficeNameRequest();
			request.officeNames.AddRange(officeNames);
			_socket.request<ChangeOfficeNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeOfficeNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void contributeToGuildRequest(int type,int times,Action<PomeloException,ContributeToGuildResponse> cb,object option = null)
		{
			var request = new ContributeToGuildRequest();
			request.type= type;
			request.times= times;
			_socket.request<ContributeToGuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ContributeToGuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setMemberJobRequest(string memberId,int job,Action<PomeloException,SetMemberJobResponse> cb,object option = null)
		{
			var request = new SetMemberJobRequest();
			request.memberId= memberId;
			request.job= job;
			_socket.request<SetMemberJobResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetMemberJobResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void transferPresidentRequest(string memberId,Action<PomeloException,TransferPresidentResponse> cb,object option = null)
		{
			var request = new TransferPresidentRequest();
			request.memberId= memberId;
			_socket.request<TransferPresidentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TransferPresidentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGuildRecordRequest(int page,Action<PomeloException,GetGuildRecordResponse> cb,object option = null)
		{
			var request = new GetGuildRecordRequest();
			request.page= page;
			_socket.request<GetGuildRecordResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildRecordResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void impeachGuildPresidentRequest(Action<PomeloException,ImpeachGuildPresidentResponse> cb,object option = null)
		{
			var request = new ImpeachGuildPresidentRequest();
			_socket.request<ImpeachGuildPresidentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ImpeachGuildPresidentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGuildMoneyRequest(Action<PomeloException,GetGuildMoneyResponse> cb,object option = null)
		{
			var request = new GetGuildMoneyRequest();
			_socket.request<GetGuildMoneyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildMoneyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinGuildDungeonRequest(int c2s_type,Action<PomeloException,JoinGuildDungeonResponse> cb,object option = null)
		{
			var request = new JoinGuildDungeonRequest();
			request.c2s_type= c2s_type;
			_socket.request<JoinGuildDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinGuildDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveGuildDungeonRequest(Action<PomeloException,LeaveGuildDungeonResponse> cb,object option = null)
		{
			var request = new LeaveGuildDungeonRequest();
			_socket.request<LeaveGuildDungeonResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveGuildDungeonResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onGuildRefreshPush(Action<GuildRefreshPush> cb)
		{
			_socket.listen_once<GuildRefreshPush>(cb);
		}
		public void onGuildInvitePush(Action<GuildInvitePush> cb)
		{
			_socket.listen_once<GuildInvitePush>(cb);
		}
		public void onDungeonEndPush(Action<OnDungeonEndPush> cb)
		{
			_socket.listen_once<OnDungeonEndPush>(cb);
		}
		public void onGuildDungeonOpenPush(Action<GuildDungeonOpenPush> cb)
		{
			_socket.listen_once<GuildDungeonOpenPush>(cb);
		}
		public void onGuildDungeonPassPush(Action<GuildDungeonPassPush> cb)
		{
			_socket.listen_once<GuildDungeonPassPush>(cb);
		}
		public void onGuildDungeonPlayerNumPush(Action<GuildDungeonPlayerNumPush> cb)
		{
			_socket.listen_once<GuildDungeonPlayerNumPush>(cb);
		}

	}


}