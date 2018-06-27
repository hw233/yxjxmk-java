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
	public class GoddessHandler
	{
		private PomeloClient _socket;

		public EnterGoddessSceneResponse lastEnterGoddessSceneResponse { get { return _socket.GetLastResponse<EnterGoddessSceneResponse>(); } }
		public OutGoddessSceneResponse lastOutGoddessSceneResponse { get { return _socket.GetLastResponse<OutGoddessSceneResponse>(); } }
		public ActiveGoddessResponse lastActiveGoddessResponse { get { return _socket.GetLastResponse<ActiveGoddessResponse>(); } }
		public OnBattleGoddessResponse lastOnBattleGoddessResponse { get { return _socket.GetLastResponse<OnBattleGoddessResponse>(); } }
		public OffBattleGoddessResponse lastOffBattleGoddessResponse { get { return _socket.GetLastResponse<OffBattleGoddessResponse>(); } }
		public GetGiftsResponse lastGetGiftsResponse { get { return _socket.GetLastResponse<GetGiftsResponse>(); } }
		public BuyGiftResponse lastBuyGiftResponse { get { return _socket.GetLastResponse<BuyGiftResponse>(); } }
		public UnEquipGiftResponse lastUnEquipGiftResponse { get { return _socket.GetLastResponse<UnEquipGiftResponse>(); } }
		public EquipGiftResponse lastEquipGiftResponse { get { return _socket.GetLastResponse<EquipGiftResponse>(); } }
		public UpIntimacyResponse lastUpIntimacyResponse { get { return _socket.GetLastResponse<UpIntimacyResponse>(); } }
		public UpStarResponse lastUpStarResponse { get { return _socket.GetLastResponse<UpStarResponse>(); } }
		public GetCommInfoResponse lastGetCommInfoResponse { get { return _socket.GetLastResponse<GetCommInfoResponse>(); } }
		public GetGoddessDetailResponse lastGetGoddessDetailResponse { get { return _socket.GetLastResponse<GetGoddessDetailResponse>(); } }
		public GetAllGoddessResponse lastGetAllGoddessResponse { get { return _socket.GetLastResponse<GetAllGoddessResponse>(); } }
		static GoddessHandler()
		{
			EventTypes.RegistPushType("area.goddessPush.goddessEquipDynamicPush", typeof(GoddessEquipDynamicPush));
			EventTypes.RegistPushType("area.goddessPush.goddessGiftDynamicPush", typeof(GoddessGiftDynamicPush));
			EventTypes.RegistRequestType("area.goddessHandler.enterGoddessSceneRequest", typeof(EnterGoddessSceneRequest), typeof(EnterGoddessSceneResponse));
			EventTypes.RegistRequestType("area.goddessHandler.outGoddessSceneRequest", typeof(OutGoddessSceneRequest), typeof(OutGoddessSceneResponse));
			EventTypes.RegistRequestType("area.goddessHandler.activeGoddessRequest", typeof(ActiveGoddessRequest), typeof(ActiveGoddessResponse));
			EventTypes.RegistRequestType("area.goddessHandler.onBattleGoddessRequest", typeof(OnBattleGoddessRequest), typeof(OnBattleGoddessResponse));
			EventTypes.RegistRequestType("area.goddessHandler.offBattleGoddessRequest", typeof(OffBattleGoddessRequest), typeof(OffBattleGoddessResponse));
			EventTypes.RegistRequestType("area.goddessHandler.getGiftsRequest", typeof(GetGiftsRequest), typeof(GetGiftsResponse));
			EventTypes.RegistRequestType("area.goddessHandler.buyGiftRequest", typeof(BuyGiftRequest), typeof(BuyGiftResponse));
			EventTypes.RegistRequestType("area.goddessHandler.unEquipGiftRequest", typeof(UnEquipGiftRequest), typeof(UnEquipGiftResponse));
			EventTypes.RegistRequestType("area.goddessHandler.equipGiftRequest", typeof(EquipGiftRequest), typeof(EquipGiftResponse));
			EventTypes.RegistRequestType("area.goddessHandler.upIntimacyRequest", typeof(UpIntimacyRequest), typeof(UpIntimacyResponse));
			EventTypes.RegistRequestType("area.goddessHandler.upStarRequest", typeof(UpStarRequest), typeof(UpStarResponse));
			EventTypes.RegistRequestType("area.goddessHandler.getCommInfoRequest", typeof(GetCommInfoRequest), typeof(GetCommInfoResponse));
			EventTypes.RegistRequestType("area.goddessHandler.getGoddessDetailRequest", typeof(GetGoddessDetailRequest), typeof(GetGoddessDetailResponse));
			EventTypes.RegistRequestType("area.goddessHandler.getAllGoddessRequest", typeof(GetAllGoddessRequest), typeof(GetAllGoddessResponse));
		}
		public GoddessHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void enterGoddessSceneRequest(Action<PomeloException,EnterGoddessSceneResponse> cb,object option = null)
		{
			var request = new EnterGoddessSceneRequest();
			_socket.request<EnterGoddessSceneResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterGoddessSceneResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void outGoddessSceneRequest(Action<PomeloException,OutGoddessSceneResponse> cb,object option = null)
		{
			var request = new OutGoddessSceneRequest();
			_socket.request<OutGoddessSceneResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OutGoddessSceneResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activeGoddessRequest(int c2s_goddessTemplateId,Action<PomeloException,ActiveGoddessResponse> cb,object option = null)
		{
			var request = new ActiveGoddessRequest();
			request.c2s_goddessTemplateId= c2s_goddessTemplateId;
			_socket.request<ActiveGoddessResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActiveGoddessResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onBattleGoddessRequest(int c2s_goddessId,Action<PomeloException,OnBattleGoddessResponse> cb,object option = null)
		{
			var request = new OnBattleGoddessRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<OnBattleGoddessResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OnBattleGoddessResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void offBattleGoddessRequest(int c2s_goddessId,Action<PomeloException,OffBattleGoddessResponse> cb,object option = null)
		{
			var request = new OffBattleGoddessRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<OffBattleGoddessResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OffBattleGoddessResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGiftsRequest(int c2s_goddessId,Action<PomeloException,GetGiftsResponse> cb,object option = null)
		{
			var request = new GetGiftsRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<GetGiftsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGiftsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyGiftRequest(int c2s_goddessId,int c2s_giftId,Action<PomeloException,BuyGiftResponse> cb,object option = null)
		{
			var request = new BuyGiftRequest();
			request.c2s_goddessId= c2s_goddessId;
			request.c2s_giftId= c2s_giftId;
			_socket.request<BuyGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void unEquipGiftRequest(int c2s_goddessId,int c2s_giftId,Action<PomeloException,UnEquipGiftResponse> cb,object option = null)
		{
			var request = new UnEquipGiftRequest();
			request.c2s_goddessId= c2s_goddessId;
			request.c2s_giftId= c2s_giftId;
			_socket.request<UnEquipGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnEquipGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipGiftRequest(int c2s_goddessId,int c2s_giftId,Action<PomeloException,EquipGiftResponse> cb,object option = null)
		{
			var request = new EquipGiftRequest();
			request.c2s_goddessId= c2s_goddessId;
			request.c2s_giftId= c2s_giftId;
			_socket.request<EquipGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upIntimacyRequest(int c2s_goddessId,int c2s_type,Action<PomeloException,UpIntimacyResponse> cb,object option = null)
		{
			var request = new UpIntimacyRequest();
			request.c2s_goddessId= c2s_goddessId;
			request.c2s_type= c2s_type;
			_socket.request<UpIntimacyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpIntimacyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upStarRequest(int c2s_goddessId,Action<PomeloException,UpStarResponse> cb,object option = null)
		{
			var request = new UpStarRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<UpStarResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpStarResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getCommInfoRequest(int c2s_goddessId,Action<PomeloException,GetCommInfoResponse> cb,object option = null)
		{
			var request = new GetCommInfoRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<GetCommInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetCommInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getGoddessDetailRequest(int c2s_goddessId,Action<PomeloException,GetGoddessDetailResponse> cb,object option = null)
		{
			var request = new GetGoddessDetailRequest();
			request.c2s_goddessId= c2s_goddessId;
			_socket.request<GetGoddessDetailResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGoddessDetailResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAllGoddessRequest(Action<PomeloException,GetAllGoddessResponse> cb,object option = null)
		{
			var request = new GetAllGoddessRequest();
			_socket.request<GetAllGoddessResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllGoddessResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onGoddessEquipDynamicPush(Action<GoddessEquipDynamicPush> cb)
		{
			_socket.listen_once<GoddessEquipDynamicPush>(cb);
		}
		public void onGoddessGiftDynamicPush(Action<GoddessGiftDynamicPush> cb)
		{
			_socket.listen_once<GoddessGiftDynamicPush>(cb);
		}

	}


}