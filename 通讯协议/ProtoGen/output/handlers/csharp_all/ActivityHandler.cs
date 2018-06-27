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
	public class ActivityHandler
	{
		private PomeloClient _socket;

		public ActivityLsResponse lastActivityLsResponse { get { return _socket.GetLastResponse<ActivityLsResponse>(); } }
		public InterestActivityAdResponse lastInterestActivityAdResponse { get { return _socket.GetLastResponse<InterestActivityAdResponse>(); } }
		public PayFirstResponse lastPayFirstResponse { get { return _socket.GetLastResponse<PayFirstResponse>(); } }
		public PaySecondResponse lastPaySecondResponse { get { return _socket.GetLastResponse<PaySecondResponse>(); } }
		public PayTotalResponse lastPayTotalResponse { get { return _socket.GetLastResponse<PayTotalResponse>(); } }
		public ConsumeTotalResponse lastConsumeTotalResponse { get { return _socket.GetLastResponse<ConsumeTotalResponse>(); } }
		public ActivityAwardResponse lastActivityAwardResponse { get { return _socket.GetLastResponse<ActivityAwardResponse>(); } }
		public ActivityInviteCodeResponse lastActivityInviteCodeResponse { get { return _socket.GetLastResponse<ActivityInviteCodeResponse>(); } }
		public ActivityNoticeRes lastActivityNoticeRes { get { return _socket.GetLastResponse<ActivityNoticeRes>(); } }
		public ActivityLevelOrSwordResponse lastActivityLevelOrSwordResponse { get { return _socket.GetLastResponse<ActivityLevelOrSwordResponse>(); } }
		public ActivityBuyFundsRes lastActivityBuyFundsRes { get { return _socket.GetLastResponse<ActivityBuyFundsRes>(); } }
		public ActivityOpenFundsRes lastActivityOpenFundsRes { get { return _socket.GetLastResponse<ActivityOpenFundsRes>(); } }
		public ActivityLuckyAwardViewResponse lastActivityLuckyAwardViewResponse { get { return _socket.GetLastResponse<ActivityLuckyAwardViewResponse>(); } }
		public LuckyAwardViewResponse lastLuckyAwardViewResponse { get { return _socket.GetLastResponse<LuckyAwardViewResponse>(); } }
		public ReSetluckyAwardResponse lastReSetluckyAwardResponse { get { return _socket.GetLastResponse<ReSetluckyAwardResponse>(); } }
		public OpenSevenDayResponse lastOpenSevenDayResponse { get { return _socket.GetLastResponse<OpenSevenDayResponse>(); } }
		public OpenChangeResponse lastOpenChangeResponse { get { return _socket.GetLastResponse<OpenChangeResponse>(); } }
		public ActivityDrawInfoResponse lastActivityDrawInfoResponse { get { return _socket.GetLastResponse<ActivityDrawInfoResponse>(); } }
		public DrawInfoResponse lastDrawInfoResponse { get { return _socket.GetLastResponse<DrawInfoResponse>(); } }
		public DrawRankResponse lastDrawRankResponse { get { return _socket.GetLastResponse<DrawRankResponse>(); } }
		public DrawSetLowResponse lastDrawSetLowResponse { get { return _socket.GetLastResponse<DrawSetLowResponse>(); } }
		public DrawAwardResponse lastDrawAwardResponse { get { return _socket.GetLastResponse<DrawAwardResponse>(); } }
		static ActivityHandler()
		{
			EventTypes.RegistRequestType("area.activityHandler.activityLsRequest", typeof(ActivityLsRequest), typeof(ActivityLsResponse));
			EventTypes.RegistRequestType("area.activityHandler.interestActivityAdRequest", typeof(InterestActivityAdRequest), typeof(InterestActivityAdResponse));
			EventTypes.RegistRequestType("area.activityHandler.payFirstRequest", typeof(PayFirstRequest), typeof(PayFirstResponse));
			EventTypes.RegistRequestType("area.activityHandler.paySecondRequest", typeof(PaySecondRequest), typeof(PaySecondResponse));
			EventTypes.RegistRequestType("area.activityHandler.payTotalRequest", typeof(PayTotalRequest), typeof(PayTotalResponse));
			EventTypes.RegistRequestType("area.activityHandler.consumeTotalRequest", typeof(ConsumeTotalRequest), typeof(ConsumeTotalResponse));
			EventTypes.RegistRequestType("area.activityHandler.activityAwardRequest", typeof(ActivityAwardRequest), typeof(ActivityAwardResponse));
			EventTypes.RegistRequestType("area.activityHandler.activityInviteCodeRequest", typeof(ActivityInviteCodeRequest), typeof(ActivityInviteCodeResponse));
			EventTypes.RegistRequestType("area.activityHandler.activityNoticeRequest", typeof(ActivityNoticeReq), typeof(ActivityNoticeRes));
			EventTypes.RegistRequestType("area.activityHandler.activityLevelOrSwordRequest", typeof(ActivityLevelOrSwordRequest), typeof(ActivityLevelOrSwordResponse));
			EventTypes.RegistRequestType("area.activityHandler.activityBuyFundsRequest", typeof(ActivityBuyFundsReq), typeof(ActivityBuyFundsRes));
			EventTypes.RegistRequestType("area.activityHandler.activityOpenFundsRequest", typeof(ActivityOpenFundsReq), typeof(ActivityOpenFundsRes));
			EventTypes.RegistRequestType("area.activityHandler.activityLuckyAwardViewRequest", typeof(ActivityLuckyAwardViewRequest), typeof(ActivityLuckyAwardViewResponse));
			EventTypes.RegistRequestType("area.activityHandler.luckyAwardViewRequest", typeof(LuckyAwardViewRequest), typeof(LuckyAwardViewResponse));
			EventTypes.RegistRequestType("area.activityHandler.reSetluckyAwardRequest", typeof(ReSetluckyAwardRequest), typeof(ReSetluckyAwardResponse));
			EventTypes.RegistRequestType("area.activityHandler.openSevenDayRequest", typeof(OpenSevenDayRequest), typeof(OpenSevenDayResponse));
			EventTypes.RegistRequestType("area.activityHandler.openChangeRequest", typeof(OpenChangeRequest), typeof(OpenChangeResponse));
			EventTypes.RegistRequestType("area.activityHandler.activityDrawInfoRequest", typeof(ActivityDrawInfoRequest), typeof(ActivityDrawInfoResponse));
			EventTypes.RegistRequestType("area.activityHandler.drawInfoRequest", typeof(DrawInfoRequest), typeof(DrawInfoResponse));
			EventTypes.RegistRequestType("area.activityHandler.drawRankRequest", typeof(DrawRankRequest), typeof(DrawRankResponse));
			EventTypes.RegistRequestType("area.activityHandler.drawSetLowRequest", typeof(DrawSetLowRequest), typeof(DrawSetLowResponse));
			EventTypes.RegistRequestType("area.activityHandler.drawAwardRequest", typeof(DrawAwardRequest), typeof(DrawAwardResponse));
		}
		public ActivityHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void activityLsRequest(Action<PomeloException,ActivityLsResponse> cb,object option = null)
		{
			var request = new ActivityLsRequest();
			_socket.request<ActivityLsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityLsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void interestActivityAdRequest(Action<PomeloException,InterestActivityAdResponse> cb,object option = null)
		{
			var request = new InterestActivityAdRequest();
			_socket.request<InterestActivityAdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InterestActivityAdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void payFirstRequest(Action<PomeloException,PayFirstResponse> cb,object option = null)
		{
			var request = new PayFirstRequest();
			_socket.request<PayFirstResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PayFirstResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void paySecondRequest(Action<PomeloException,PaySecondResponse> cb,object option = null)
		{
			var request = new PaySecondRequest();
			_socket.request<PaySecondResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PaySecondResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void payTotalRequest(Action<PomeloException,PayTotalResponse> cb,object option = null)
		{
			var request = new PayTotalRequest();
			_socket.request<PayTotalResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PayTotalResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void consumeTotalRequest(Action<PomeloException,ConsumeTotalResponse> cb,object option = null)
		{
			var request = new ConsumeTotalRequest();
			_socket.request<ConsumeTotalResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ConsumeTotalResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityAwardRequest(int s2c_awardId,int s2c_activityId,Action<PomeloException,ActivityAwardResponse> cb,object option = null)
		{
			var request = new ActivityAwardRequest();
			request.s2c_awardId= s2c_awardId;
			request.s2c_activityId= s2c_activityId;
			_socket.request<ActivityAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityInviteCodeRequest(string c2s_inviteCode,Action<PomeloException,ActivityInviteCodeResponse> cb,object option = null)
		{
			var request = new ActivityInviteCodeRequest();
			request.c2s_inviteCode= c2s_inviteCode;
			_socket.request<ActivityInviteCodeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityInviteCodeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityNoticeRequest(Action<PomeloException,ActivityNoticeRes> cb,object option = null)
		{
			var request = new ActivityNoticeReq();
			_socket.request<ActivityNoticeRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityNoticeRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityLevelOrSwordRequest(int c2s_activityId,Action<PomeloException,ActivityLevelOrSwordResponse> cb,object option = null)
		{
			var request = new ActivityLevelOrSwordRequest();
			request.c2s_activityId= c2s_activityId;
			_socket.request<ActivityLevelOrSwordResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityLevelOrSwordResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityBuyFundsRequest(Action<PomeloException,ActivityBuyFundsRes> cb,object option = null)
		{
			var request = new ActivityBuyFundsReq();
			_socket.request<ActivityBuyFundsRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityBuyFundsRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityOpenFundsRequest(Action<PomeloException,ActivityOpenFundsRes> cb,object option = null)
		{
			var request = new ActivityOpenFundsReq();
			_socket.request<ActivityOpenFundsRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityOpenFundsRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityLuckyAwardViewRequest(Action<PomeloException,ActivityLuckyAwardViewResponse> cb,object option = null)
		{
			var request = new ActivityLuckyAwardViewRequest();
			_socket.request<ActivityLuckyAwardViewResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityLuckyAwardViewResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void luckyAwardViewRequest(Action<PomeloException,LuckyAwardViewResponse> cb,object option = null)
		{
			var request = new LuckyAwardViewRequest();
			_socket.request<LuckyAwardViewResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LuckyAwardViewResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void reSetluckyAwardRequest(Action<PomeloException,ReSetluckyAwardResponse> cb,object option = null)
		{
			var request = new ReSetluckyAwardRequest();
			_socket.request<ReSetluckyAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReSetluckyAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openSevenDayRequest(int c2s_day,Action<PomeloException,OpenSevenDayResponse> cb,object option = null)
		{
			var request = new OpenSevenDayRequest();
			request.c2s_day= c2s_day;
			_socket.request<OpenSevenDayResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenSevenDayResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openChangeRequest(Action<PomeloException,OpenChangeResponse> cb,object option = null)
		{
			var request = new OpenChangeRequest();
			_socket.request<OpenChangeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenChangeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activityDrawInfoRequest(Action<PomeloException,ActivityDrawInfoResponse> cb,object option = null)
		{
			var request = new ActivityDrawInfoRequest();
			_socket.request<ActivityDrawInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivityDrawInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawInfoRequest(Action<PomeloException,DrawInfoResponse> cb,object option = null)
		{
			var request = new DrawInfoRequest();
			_socket.request<DrawInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawRankRequest(Action<PomeloException,DrawRankResponse> cb,object option = null)
		{
			var request = new DrawRankRequest();
			_socket.request<DrawRankResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawRankResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawSetLowRequest(int isLow,Action<PomeloException,DrawSetLowResponse> cb,object option = null)
		{
			var request = new DrawSetLowRequest();
			request.isLow= isLow;
			_socket.request<DrawSetLowResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawSetLowResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawAwardRequest(int type,int useItem,Action<PomeloException,DrawAwardResponse> cb,object option = null)
		{
			var request = new DrawAwardRequest();
			request.type= type;
			request.useItem= useItem;
			_socket.request<DrawAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}