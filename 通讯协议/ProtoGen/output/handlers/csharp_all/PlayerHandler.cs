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
	public class PlayerHandler
	{
		private PomeloClient _socket;

		public GetPlayerPositionResponse lastGetPlayerPositionResponse { get { return _socket.GetLastResponse<GetPlayerPositionResponse>(); } }
		public TransportResponse lastTransportResponse { get { return _socket.GetLastResponse<TransportResponse>(); } }
		public EnterSceneResponse lastEnterSceneResponse { get { return _socket.GetLastResponse<EnterSceneResponse>(); } }
		public QueryLoadWayResponse lastQueryLoadWayResponse { get { return _socket.GetLastResponse<QueryLoadWayResponse>(); } }
		public PickItemResponse lastPickItemResponse { get { return _socket.GetLastResponse<PickItemResponse>(); } }
		public ChangeAreaResponse lastChangeAreaResponse { get { return _socket.GetLastResponse<ChangeAreaResponse>(); } }
		public TransByAreaIdResponse lastTransByAreaIdResponse { get { return _socket.GetLastResponse<TransByAreaIdResponse>(); } }
		public ChangeAreaXYResponse lastChangeAreaXYResponse { get { return _socket.GetLastResponse<ChangeAreaXYResponse>(); } }
		public ChangeAreaByTaskResponse lastChangeAreaByTaskResponse { get { return _socket.GetLastResponse<ChangeAreaByTaskResponse>(); } }
		public RecentContactsResponse lastRecentContactsResponse { get { return _socket.GetLastResponse<RecentContactsResponse>(); } }
		public ChangPkModelRespone lastChangPkModelRespone { get { return _socket.GetLastResponse<ChangPkModelRespone>(); } }
		public ReliveSendPosResponse lastReliveSendPosResponse { get { return _socket.GetLastResponse<ReliveSendPosResponse>(); } }
		public ReliveResponse lastReliveResponse { get { return _socket.GetLastResponse<ReliveResponse>(); } }
		public GetAreaLinesResponse lastGetAreaLinesResponse { get { return _socket.GetLastResponse<GetAreaLinesResponse>(); } }
		public TransByInstanceIdResponse lastTransByInstanceIdResponse { get { return _socket.GetLastResponse<TransByInstanceIdResponse>(); } }
		public LookUpOtherPlayerResponse lastLookUpOtherPlayerResponse { get { return _socket.GetLastResponse<LookUpOtherPlayerResponse>(); } }
		public AgreeRebirthResponse lastAgreeRebirthResponse { get { return _socket.GetLastResponse<AgreeRebirthResponse>(); } }
		public CDKResponse lastCDKResponse { get { return _socket.GetLastResponse<CDKResponse>(); } }
		public CustomConfigResponse lastCustomConfigResponse { get { return _socket.GetLastResponse<CustomConfigResponse>(); } }
		public LeaveAreaResponse lastLeaveAreaResponse { get { return _socket.GetLastResponse<LeaveAreaResponse>(); } }
		public SimulateDropByTcResponse lastSimulateDropByTcResponse { get { return _socket.GetLastResponse<SimulateDropByTcResponse>(); } }
		public UpgradeClassResponse lastUpgradeClassResponse { get { return _socket.GetLastResponse<UpgradeClassResponse>(); } }
		public GetClassEventConditionResponse lastGetClassEventConditionResponse { get { return _socket.GetLastResponse<GetClassEventConditionResponse>(); } }
		public ClientReadyResponse lastClientReadyResponse { get { return _socket.GetLastResponse<ClientReadyResponse>(); } }
		public SendGMCmdResponse lastSendGMCmdResponse { get { return _socket.GetLastResponse<SendGMCmdResponse>(); } }
		static PlayerHandler()
		{
			EventTypes.RegistPushType("area.playerPush.clientConfigPush", typeof(ClientConfigPush));
			EventTypes.RegistPushType("area.playerPush.battleEventPush", typeof(BattleEventPush));
			EventTypes.RegistPushType("area.playerPush.battleClearPush", typeof(BattleClearPush));
			EventTypes.RegistPushType("area.playerPush.onSuperScriptPush", typeof(SuperScriptPush));
			EventTypes.RegistPushType("area.playerPush.changeAreaPush", typeof(ChangeAreaPush));
			EventTypes.RegistPushType("area.playerPush.playerDynamicPush", typeof(PlayerDynamicPush));
			EventTypes.RegistPushType("area.playerPush.playerRelivePush", typeof(PlayerRelivePush));
			EventTypes.RegistPushType("area.playerPush.playerSaverRebirthPush", typeof(PlayerSaverRebirthPush));
			EventTypes.RegistPushType("area.playerPush.simulateDropPush", typeof(SimulateDataPush));
			EventTypes.RegistPushType("area.playerPush.kickPlayerPush", typeof(KickPlayerPush));
			EventTypes.RegistPushType("area.playerPush.suitPropertyUpPush", typeof(SuitPropertyUpPush));
			EventTypes.RegistPushType("area.playerPush.commonPropertyPush", typeof(CommonPropertyPush));
			EventTypes.RegistPushType("area.playerPush.buffPropertyPush", typeof(BuffPropertyPush));
			EventTypes.RegistPushType("area.playerPush.playerBattleAttributePush", typeof(PlayerBattleAttributePush));
			EventTypes.RegistPushType("area.playerPush.payGiftStatePush", typeof(PayGiftStatePush));
			EventTypes.RegistRequestType("area.playerHandler.getPlayerPositionRequest", typeof(GetPlayerPositionRequest), typeof(GetPlayerPositionResponse));
			EventTypes.RegistRequestType("area.playerHandler.transportRequest", typeof(TransportRequest), typeof(TransportResponse));
			EventTypes.RegistRequestType("area.playerHandler.enterSceneRequest", typeof(EnterSceneRequest), typeof(EnterSceneResponse));
			EventTypes.RegistRequestType("area.playerHandler.queryLoadWayRequest", typeof(QueryLoadWayRequest), typeof(QueryLoadWayResponse));
			EventTypes.RegistRequestType("area.playerHandler.pickItemRequest", typeof(PickItemRequest), typeof(PickItemResponse));
			EventTypes.RegistRequestType("area.playerHandler.changeAreaRequest", typeof(ChangeAreaRequest), typeof(ChangeAreaResponse));
			EventTypes.RegistRequestType("area.playerHandler.transByAreaIdRequest", typeof(TransByAreaIdRequest), typeof(TransByAreaIdResponse));
			EventTypes.RegistRequestType("area.playerHandler.changeAreaXYRequest", typeof(ChangeAreaXYRequest), typeof(ChangeAreaXYResponse));
			EventTypes.RegistRequestType("area.playerHandler.changeAreaByTaskRequest", typeof(ChangeAreaByTaskRequest), typeof(ChangeAreaByTaskResponse));
			EventTypes.RegistRequestType("area.playerHandler.recentContactsRequest", typeof(RecentContactsRequest), typeof(RecentContactsResponse));
			EventTypes.RegistRequestType("area.playerHandler.ChangePkModelRequest", typeof(ChangPkModelRequest), typeof(ChangPkModelRespone));
			EventTypes.RegistRequestType("area.playerHandler.reliveSendPosRequest", typeof(ReliveSendPosRequest), typeof(ReliveSendPosResponse));
			EventTypes.RegistRequestType("area.playerHandler.reliveRequest", typeof(ReliveRequest), typeof(ReliveResponse));
			EventTypes.RegistRequestType("area.playerHandler.getAreaLinesRequest", typeof(GetAreaLinesRequest), typeof(GetAreaLinesResponse));
			EventTypes.RegistRequestType("area.playerHandler.transByInstanceIdRequest", typeof(TransByInstanceIdRequest), typeof(TransByInstanceIdResponse));
			EventTypes.RegistRequestType("area.playerHandler.lookUpOtherPlayerRequest", typeof(LookUpOtherPlayerRequest), typeof(LookUpOtherPlayerResponse));
			EventTypes.RegistRequestType("area.playerHandler.agreeRebirthRequest", typeof(AgreeRebirthRequest), typeof(AgreeRebirthResponse));
			EventTypes.RegistRequestType("area.playerHandler.cdkRequest", typeof(CDKRequest), typeof(CDKResponse));
			EventTypes.RegistRequestType("area.playerHandler.setCustomConfigRequest", typeof(CustomConfigRequest), typeof(CustomConfigResponse));
			EventTypes.RegistRequestType("area.playerHandler.leaveAreaRequest", typeof(LeaveAreaRequest), typeof(LeaveAreaResponse));
			EventTypes.RegistRequestType("area.playerHandler.getSimulateDropByTcRequest", typeof(SimulateDropByTcRequest), typeof(SimulateDropByTcResponse));
			EventTypes.RegistRequestType("area.playerHandler.upgradeClassRequest", typeof(UpgradeClassRequest), typeof(UpgradeClassResponse));
			EventTypes.RegistRequestType("area.playerHandler.getClassEventConditionRequest", typeof(GetClassEventConditionRequest), typeof(GetClassEventConditionResponse));
			EventTypes.RegistRequestType("area.playerHandler.clientReadyRequest", typeof(ClientReadyRequest), typeof(ClientReadyResponse));
			EventTypes.RegistRequestType("area.playerHandler.sendGMCmdRequest", typeof(SendGMCmdRequest), typeof(SendGMCmdResponse));
			EventTypes.RegistNotifyType("area.playerHandler.battleEventNotify", typeof(BattleEventNotify));
		}
		public PlayerHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getPlayerPositionRequest(string s2c_playerId,Action<PomeloException,GetPlayerPositionResponse> cb,object option = null)
		{
			var request = new GetPlayerPositionRequest();
			request.s2c_playerId= s2c_playerId;
			_socket.request<GetPlayerPositionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetPlayerPositionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void transportRequest(int c2s_transportId,Action<PomeloException,TransportResponse> cb,object option = null)
		{
			var request = new TransportRequest();
			request.c2s_transportId= c2s_transportId;
			_socket.request<TransportResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TransportResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterSceneRequest(string c2s_instanceId,Action<PomeloException,EnterSceneResponse> cb,object option = null)
		{
			var request = new EnterSceneRequest();
			request.c2s_instanceId= c2s_instanceId;
			_socket.request<EnterSceneResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterSceneResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryLoadWayRequest(int c2s_areaId,string c2s_pointId,Action<PomeloException,QueryLoadWayResponse> cb,object option = null)
		{
			var request = new QueryLoadWayRequest();
			request.c2s_areaId= c2s_areaId;
			request.c2s_pointId= c2s_pointId;
			_socket.request<QueryLoadWayResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryLoadWayResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void pickItemRequest(string c2s_instanceId,string c2s_itemId,Action<PomeloException,PickItemResponse> cb,object option = null)
		{
			var request = new PickItemRequest();
			request.c2s_instanceId= c2s_instanceId;
			request.c2s_itemId= c2s_itemId;
			_socket.request<PickItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PickItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeAreaRequest(string c2s_pointId,int c2s_type,Action<PomeloException,ChangeAreaResponse> cb,object option = null)
		{
			var request = new ChangeAreaRequest();
			request.c2s_pointId= c2s_pointId;
			request.c2s_type= c2s_type;
			_socket.request<ChangeAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void transByAreaIdRequest(int c2s_areaId,Action<PomeloException,TransByAreaIdResponse> cb,object option = null)
		{
			var request = new TransByAreaIdRequest();
			request.c2s_areaId= c2s_areaId;
			_socket.request<TransByAreaIdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TransByAreaIdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeAreaXYRequest(int mapId,int posx,int posy,string instanceId,Action<PomeloException,ChangeAreaXYResponse> cb,object option = null)
		{
			var request = new ChangeAreaXYRequest();
			request.mapId= mapId;
			request.posx= posx;
			request.posy= posy;
			request.instanceId= instanceId;
			_socket.request<ChangeAreaXYResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeAreaXYResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeAreaByTaskRequest(int mapId,int taskId,int posx,int posy,int point,Action<PomeloException,ChangeAreaByTaskResponse> cb,object option = null)
		{
			var request = new ChangeAreaByTaskRequest();
			request.mapId= mapId;
			request.taskId= taskId;
			request.posx= posx;
			request.posy= posy;
			request.point= point;
			_socket.request<ChangeAreaByTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeAreaByTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void recentContactsRequest(List<string> c2s_ids,Action<PomeloException,RecentContactsResponse> cb,object option = null)
		{
			var request = new RecentContactsRequest();
			request.c2s_ids.AddRange(c2s_ids);
			_socket.request<RecentContactsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RecentContactsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void ChangePkModelRequest(int c2s_model,Action<PomeloException,ChangPkModelRespone> cb,object option = null)
		{
			var request = new ChangPkModelRequest();
			request.c2s_model= c2s_model;
			_socket.request<ChangPkModelRespone>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangPkModelRespone;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void reliveSendPosRequest(Action<PomeloException,ReliveSendPosResponse> cb,object option = null)
		{
			var request = new ReliveSendPosRequest();
			_socket.request<ReliveSendPosResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReliveSendPosResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void reliveRequest(int type,int autoPay,Action<PomeloException,ReliveResponse> cb,object option = null)
		{
			var request = new ReliveRequest();
			request.type= type;
			request.autoPay= autoPay;
			_socket.request<ReliveResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReliveResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAreaLinesRequest(Action<PomeloException,GetAreaLinesResponse> cb,object option = null)
		{
			var request = new GetAreaLinesRequest();
			_socket.request<GetAreaLinesResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAreaLinesResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void transByInstanceIdRequest(string c2s_instanceId,Action<PomeloException,TransByInstanceIdResponse> cb,object option = null)
		{
			var request = new TransByInstanceIdRequest();
			request.c2s_instanceId= c2s_instanceId;
			_socket.request<TransByInstanceIdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TransByInstanceIdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void lookUpOtherPlayerRequest(string c2s_playerId,int c2s_type,Action<PomeloException,LookUpOtherPlayerResponse> cb,object option = null)
		{
			var request = new LookUpOtherPlayerRequest();
			request.c2s_playerId= c2s_playerId;
			request.c2s_type= c2s_type;
			_socket.request<LookUpOtherPlayerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LookUpOtherPlayerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void agreeRebirthRequest(Action<PomeloException,AgreeRebirthResponse> cb,object option = null)
		{
			var request = new AgreeRebirthRequest();
			_socket.request<AgreeRebirthResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AgreeRebirthResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cdkRequest(string c2s_cdk,int c2s_channel,Action<PomeloException,CDKResponse> cb,object option = null)
		{
			var request = new CDKRequest();
			request.c2s_cdk= c2s_cdk;
			request.c2s_channel= c2s_channel;
			_socket.request<CDKResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CDKResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setCustomConfigRequest(string c2s_key,string c2s_value,Action<PomeloException,CustomConfigResponse> cb,object option = null)
		{
			var request = new CustomConfigRequest();
			request.c2s_key= c2s_key;
			request.c2s_value= c2s_value;
			_socket.request<CustomConfigResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CustomConfigResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveAreaRequest(Action<PomeloException,LeaveAreaResponse> cb,object option = null)
		{
			var request = new LeaveAreaRequest();
			_socket.request<LeaveAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSimulateDropByTcRequest(string c2s_tcCode,int c2s_tcCount,int c2s_tcLevel,Action<PomeloException,SimulateDropByTcResponse> cb,object option = null)
		{
			var request = new SimulateDropByTcRequest();
			request.c2s_tcCode= c2s_tcCode;
			request.c2s_tcCount= c2s_tcCount;
			request.c2s_tcLevel= c2s_tcLevel;
			_socket.request<SimulateDropByTcResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SimulateDropByTcResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeClassRequest(Action<PomeloException,UpgradeClassResponse> cb,object option = null)
		{
			var request = new UpgradeClassRequest();
			_socket.request<UpgradeClassResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeClassResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getClassEventConditionRequest(Action<PomeloException,GetClassEventConditionResponse> cb,object option = null)
		{
			var request = new GetClassEventConditionRequest();
			_socket.request<GetClassEventConditionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetClassEventConditionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void clientReadyRequest(Action<PomeloException,ClientReadyResponse> cb,object option = null)
		{
			var request = new ClientReadyRequest();
			_socket.request<ClientReadyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ClientReadyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sendGMCmdRequest(string c2s_msg,Action<PomeloException,SendGMCmdResponse> cb,object option = null)
		{
			var request = new SendGMCmdRequest();
			request.c2s_msg= c2s_msg;
			_socket.request<SendGMCmdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SendGMCmdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void battleEventNotify(byte[] c2s_data)
		{
			var notify = new BattleEventNotify();
			notify.c2s_data= c2s_data;

			_socket.notify(notify);

		}
		public void onClientConfigPush(Action<ClientConfigPush> cb)
		{
			_socket.listen_once<ClientConfigPush>(cb);
		}
		public void onBattleEventPush(Action<BattleEventPush> cb)
		{

		}
		public void onBattleClearPush(Action<BattleClearPush> cb)
		{
			_socket.listen_once<BattleClearPush>(cb);
		}
		public void onSuperScriptPush(Action<SuperScriptPush> cb)
		{
			_socket.listen_once<SuperScriptPush>(cb);
		}
		public void onChangeAreaPush(Action<ChangeAreaPush> cb)
		{
			_socket.listen_once<ChangeAreaPush>(cb);
		}
		public void onPlayerDynamicPush(Action<PlayerDynamicPush> cb)
		{
			_socket.listen_once<PlayerDynamicPush>(cb);
		}
		public void onPlayerRelivePush(Action<PlayerRelivePush> cb)
		{
			_socket.listen_once<PlayerRelivePush>(cb);
		}
		public void onPlayerSaverRebirthPush(Action<PlayerSaverRebirthPush> cb)
		{
			_socket.listen_once<PlayerSaverRebirthPush>(cb);
		}
		public void onSimulateDropPush(Action<SimulateDataPush> cb)
		{
			_socket.listen_once<SimulateDataPush>(cb);
		}
		public void onKickPlayerPush(Action<KickPlayerPush> cb)
		{
			_socket.listen_once<KickPlayerPush>(cb);
		}
		public void onSuitPropertyUpPush(Action<SuitPropertyUpPush> cb)
		{
			_socket.listen_once<SuitPropertyUpPush>(cb);
		}
		public void onCommonPropertyPush(Action<CommonPropertyPush> cb)
		{
			_socket.listen_once<CommonPropertyPush>(cb);
		}
		public void onBuffPropertyPush(Action<BuffPropertyPush> cb)
		{
			_socket.listen_once<BuffPropertyPush>(cb);
		}
		public void onPlayerBattleAttributePush(Action<PlayerBattleAttributePush> cb)
		{
			_socket.listen_once<PlayerBattleAttributePush>(cb);
		}
		public void onPayGiftStatePush(Action<PayGiftStatePush> cb)
		{
			_socket.listen_once<PayGiftStatePush>(cb);
		}

	}


}