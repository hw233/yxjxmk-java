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
	public class ActivityFavorHandler
	{
		private PomeloClient _socket;

		public DailyRechargeGetInfoResponse lastDailyRechargeGetInfoResponse { get { return _socket.GetLastResponse<DailyRechargeGetInfoResponse>(); } }
		public DailyRechargeGetAwardResponse lastDailyRechargeGetAwardResponse { get { return _socket.GetLastResponse<DailyRechargeGetAwardResponse>(); } }
		public SuperPackageGetInfoResponse lastSuperPackageGetInfoResponse { get { return _socket.GetLastResponse<SuperPackageGetInfoResponse>(); } }
		public SuperPackageBuyResponse lastSuperPackageBuyResponse { get { return _socket.GetLastResponse<SuperPackageBuyResponse>(); } }
		public SevenDayPackageGetInfoResponse lastSevenDayPackageGetInfoResponse { get { return _socket.GetLastResponse<SevenDayPackageGetInfoResponse>(); } }
		public SevenDayPackageAwardResponse lastSevenDayPackageAwardResponse { get { return _socket.GetLastResponse<SevenDayPackageAwardResponse>(); } }
		public DailyDrawInfoResponse lastDailyDrawInfoResponse { get { return _socket.GetLastResponse<DailyDrawInfoResponse>(); } }
		public DailyDrawResponse lastDailyDrawResponse { get { return _socket.GetLastResponse<DailyDrawResponse>(); } }
		public RecoveredInfoResponse lastRecoveredInfoResponse { get { return _socket.GetLastResponse<RecoveredInfoResponse>(); } }
		public RecoveredResponse lastRecoveredResponse { get { return _socket.GetLastResponse<RecoveredResponse>(); } }
		static ActivityFavorHandler()
		{
			EventTypes.RegistPushType("area.activityFavorPush.superPackageBuyPush", typeof(SuperPackageBuyPush));
			EventTypes.RegistRequestType("area.activityFavorHandler.dailyRechargeGetInfoRequest", typeof(DailyRechargeGetInfoRequest), typeof(DailyRechargeGetInfoResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.dailyRechargeGetAwardRequest", typeof(DailyRechargeGetAwardRequest), typeof(DailyRechargeGetAwardResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.superPackageGetInfoRequest", typeof(SuperPackageGetInfoRequest), typeof(SuperPackageGetInfoResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.superPackageBuyRequest", typeof(SuperPackageBuyRequest), typeof(SuperPackageBuyResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.sevenDayPackageGetInfoRequest", typeof(SevenDayPackageGetInfoRequest), typeof(SevenDayPackageGetInfoResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.sevenDayPackageAwardRequest", typeof(SevenDayPackageAwardRequest), typeof(SevenDayPackageAwardResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.dailyDrawInfoRequest", typeof(DailyDrawInfoRequest), typeof(DailyDrawInfoResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.dailyDrawRequest", typeof(DailyDrawRequest), typeof(DailyDrawResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.recoveredInfoRequest", typeof(RecoveredInfoRequest), typeof(RecoveredInfoResponse));
			EventTypes.RegistRequestType("area.activityFavorHandler.recoveredRequest", typeof(RecoveredRequest), typeof(RecoveredResponse));
		}
		public ActivityFavorHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void dailyRechargeGetInfoRequest(Action<PomeloException,DailyRechargeGetInfoResponse> cb,object option = null)
		{
			var request = new DailyRechargeGetInfoRequest();
			_socket.request<DailyRechargeGetInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyRechargeGetInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dailyRechargeGetAwardRequest(int awardId,Action<PomeloException,DailyRechargeGetAwardResponse> cb,object option = null)
		{
			var request = new DailyRechargeGetAwardRequest();
			request.awardId= awardId;
			_socket.request<DailyRechargeGetAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyRechargeGetAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void superPackageGetInfoRequest(Action<PomeloException,SuperPackageGetInfoResponse> cb,object option = null)
		{
			var request = new SuperPackageGetInfoRequest();
			_socket.request<SuperPackageGetInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SuperPackageGetInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void superPackageBuyRequest(int packageId,int channelId,string c2s_imei,int c2s_os,Action<PomeloException,SuperPackageBuyResponse> cb,object option = null)
		{
			var request = new SuperPackageBuyRequest();
			request.packageId= packageId;
			request.channelId= channelId;
			request.c2s_imei= c2s_imei;
			request.c2s_os= c2s_os;
			_socket.request<SuperPackageBuyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SuperPackageBuyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sevenDayPackageGetInfoRequest(Action<PomeloException,SevenDayPackageGetInfoResponse> cb,object option = null)
		{
			var request = new SevenDayPackageGetInfoRequest();
			_socket.request<SevenDayPackageGetInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SevenDayPackageGetInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sevenDayPackageAwardRequest(int packageId,Action<PomeloException,SevenDayPackageAwardResponse> cb,object option = null)
		{
			var request = new SevenDayPackageAwardRequest();
			request.packageId= packageId;
			_socket.request<SevenDayPackageAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SevenDayPackageAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dailyDrawInfoRequest(Action<PomeloException,DailyDrawInfoResponse> cb,object option = null)
		{
			var request = new DailyDrawInfoRequest();
			_socket.request<DailyDrawInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyDrawInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dailyDrawRequest(int timeType,int costType,Action<PomeloException,DailyDrawResponse> cb,object option = null)
		{
			var request = new DailyDrawRequest();
			request.timeType= timeType;
			request.costType= costType;
			_socket.request<DailyDrawResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyDrawResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void recoveredInfoRequest(Action<PomeloException,RecoveredInfoResponse> cb,object option = null)
		{
			var request = new RecoveredInfoRequest();
			_socket.request<RecoveredInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RecoveredInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void recoveredRequest(int id,int type,Action<PomeloException,RecoveredResponse> cb,object option = null)
		{
			var request = new RecoveredRequest();
			request.id= id;
			request.type= type;
			_socket.request<RecoveredResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RecoveredResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSuperPackageBuyPush(Action<SuperPackageBuyPush> cb)
		{
			_socket.listen_once<SuperPackageBuyPush>(cb);
		}

	}


}