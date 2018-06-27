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
	public class FleeHandler
	{
		private PomeloClient _socket;

		public FleeInfoResponse lastFleeInfoResponse { get { return _socket.GetLastResponse<FleeInfoResponse>(); } }
		public GetRewardResponse lastGetRewardResponse { get { return _socket.GetLastResponse<GetRewardResponse>(); } }
		public FleeLookBtlReportResponse lastFleeLookBtlReportResponse { get { return _socket.GetLastResponse<FleeLookBtlReportResponse>(); } }
		public EnterFleeResponse lastEnterFleeResponse { get { return _socket.GetLastResponse<EnterFleeResponse>(); } }
		public CancelMatchResponse lastCancelMatchResponse { get { return _socket.GetLastResponse<CancelMatchResponse>(); } }
		static FleeHandler()
		{
			EventTypes.RegistPushType("area.fleePush.onFleeDeathPush", typeof(OnFleeDeathPush));
			EventTypes.RegistPushType("area.fleePush.onFleeEndPush", typeof(OnFleeEndPush));
			EventTypes.RegistRequestType("area.fleeHandler.fleeInfoRequest", typeof(FleeInfoRequest), typeof(FleeInfoResponse));
			EventTypes.RegistRequestType("area.fleeHandler.getRewardRequest", typeof(GetRewardRequest), typeof(GetRewardResponse));
			EventTypes.RegistRequestType("area.fleeHandler.fleeLookBtlReportRequest", typeof(FleeLookBtlReportRequest), typeof(FleeLookBtlReportResponse));
			EventTypes.RegistRequestType("area.fleeHandler.enterFleeRequest", typeof(EnterFleeRequest), typeof(EnterFleeResponse));
			EventTypes.RegistRequestType("area.fleeHandler.cancelMatchRequest", typeof(CancelMatchRequest), typeof(CancelMatchResponse));
		}
		public FleeHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void fleeInfoRequest(Action<PomeloException,FleeInfoResponse> cb,object option = null)
		{
			var request = new FleeInfoRequest();
			_socket.request<FleeInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FleeInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRewardRequest(int gradeId,Action<PomeloException,GetRewardResponse> cb,object option = null)
		{
			var request = new GetRewardRequest();
			request.gradeId= gradeId;
			_socket.request<GetRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void fleeLookBtlReportRequest(Action<PomeloException,FleeLookBtlReportResponse> cb,object option = null)
		{
			var request = new FleeLookBtlReportRequest();
			_socket.request<FleeLookBtlReportResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FleeLookBtlReportResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterFleeRequest(Action<PomeloException,EnterFleeResponse> cb,object option = null)
		{
			var request = new EnterFleeRequest();
			_socket.request<EnterFleeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterFleeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cancelMatchRequest(Action<PomeloException,CancelMatchResponse> cb,object option = null)
		{
			var request = new CancelMatchRequest();
			_socket.request<CancelMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CancelMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onFleeDeathPush(Action<OnFleeDeathPush> cb)
		{
			_socket.listen_once<OnFleeDeathPush>(cb);
		}
		public void onFleeEndPush(Action<OnFleeEndPush> cb)
		{
			_socket.listen_once<OnFleeEndPush>(cb);
		}

	}


}