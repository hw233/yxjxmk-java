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
	public class AttendanceHandler
	{
		private PomeloClient _socket;

		public GetAttendanceInfoResponse lastGetAttendanceInfoResponse { get { return _socket.GetLastResponse<GetAttendanceInfoResponse>(); } }
		public GetDailyRewardResponse lastGetDailyRewardResponse { get { return _socket.GetLastResponse<GetDailyRewardResponse>(); } }
		public GetCumulativeRewardResponse lastGetCumulativeRewardResponse { get { return _socket.GetLastResponse<GetCumulativeRewardResponse>(); } }
		public GetLuxuryRewardResponse lastGetLuxuryRewardResponse { get { return _socket.GetLastResponse<GetLuxuryRewardResponse>(); } }
		public GetLeftVipRewardResponse lastGetLeftVipRewardResponse { get { return _socket.GetLastResponse<GetLeftVipRewardResponse>(); } }
		static AttendanceHandler()
		{
			EventTypes.RegistPushType("area.attendancePush.luxuryRewardPush", typeof(LuxuryRewardPush));
			EventTypes.RegistRequestType("area.attendanceHandler.getAttendanceInfoRequest", typeof(GetAttendanceInfoRequest), typeof(GetAttendanceInfoResponse));
			EventTypes.RegistRequestType("area.attendanceHandler.getDailyRewardRequest", typeof(GetDailyRewardRequest), typeof(GetDailyRewardResponse));
			EventTypes.RegistRequestType("area.attendanceHandler.getCumulativeRewardRequest", typeof(GetCumulativeRewardRequest), typeof(GetCumulativeRewardResponse));
			EventTypes.RegistRequestType("area.attendanceHandler.getLuxuryRewardRequest", typeof(GetLuxuryRewardRequest), typeof(GetLuxuryRewardResponse));
			EventTypes.RegistRequestType("area.attendanceHandler.getLeftVipRewardRequest", typeof(GetLeftVipRewardRequest), typeof(GetLeftVipRewardResponse));
		}
		public AttendanceHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getAttendanceInfoRequest(Action<PomeloException,GetAttendanceInfoResponse> cb,object option = null)
		{
			var request = new GetAttendanceInfoRequest();
			_socket.request<GetAttendanceInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAttendanceInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDailyRewardRequest(Action<PomeloException,GetDailyRewardResponse> cb,object option = null)
		{
			var request = new GetDailyRewardRequest();
			_socket.request<GetDailyRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDailyRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getCumulativeRewardRequest(int id,Action<PomeloException,GetCumulativeRewardResponse> cb,object option = null)
		{
			var request = new GetCumulativeRewardRequest();
			request.id= id;
			_socket.request<GetCumulativeRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetCumulativeRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getLuxuryRewardRequest(Action<PomeloException,GetLuxuryRewardResponse> cb,object option = null)
		{
			var request = new GetLuxuryRewardRequest();
			_socket.request<GetLuxuryRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLuxuryRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getLeftVipRewardRequest(int id,Action<PomeloException,GetLeftVipRewardResponse> cb,object option = null)
		{
			var request = new GetLeftVipRewardRequest();
			request.id= id;
			_socket.request<GetLeftVipRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLeftVipRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onLuxuryRewardPush(Action<LuxuryRewardPush> cb)
		{
			_socket.listen_once<LuxuryRewardPush>(cb);
		}

	}


}