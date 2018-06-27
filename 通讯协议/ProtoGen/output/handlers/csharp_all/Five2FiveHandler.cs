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

namespace pomelo.five2five
{
	public class Five2FiveHandler
	{
		private PomeloClient _socket;

		public Five2FiveResponse lastFive2FiveResponse { get { return _socket.GetLastResponse<Five2FiveResponse>(); } }
		public Five2FiveLookBtlReportResponse lastFive2FiveLookBtlReportResponse { get { return _socket.GetLastResponse<Five2FiveLookBtlReportResponse>(); } }
		public Five2FiveMatchResponse lastFive2FiveMatchResponse { get { return _socket.GetLastResponse<Five2FiveMatchResponse>(); } }
		public Five2FiveRefuseMatchResponse lastFive2FiveRefuseMatchResponse { get { return _socket.GetLastResponse<Five2FiveRefuseMatchResponse>(); } }
		public Five2FiveAgreeMatchResponse lastFive2FiveAgreeMatchResponse { get { return _socket.GetLastResponse<Five2FiveAgreeMatchResponse>(); } }
		public Five2FiveCancelMatchResponse lastFive2FiveCancelMatchResponse { get { return _socket.GetLastResponse<Five2FiveCancelMatchResponse>(); } }
		public Five2FiveReadyResponse lastFive2FiveReadyResponse { get { return _socket.GetLastResponse<Five2FiveReadyResponse>(); } }
		public Five2FiveLeaveAreaResponse lastFive2FiveLeaveAreaResponse { get { return _socket.GetLastResponse<Five2FiveLeaveAreaResponse>(); } }
		public Five2FiveReciveRewardResponse lastFive2FiveReciveRewardResponse { get { return _socket.GetLastResponse<Five2FiveReciveRewardResponse>(); } }
		public Five2FiveLookMatchResultResponse lastFive2FiveLookMatchResultResponse { get { return _socket.GetLastResponse<Five2FiveLookMatchResultResponse>(); } }
		public Five2FiveShardMatchResultResponse lastFive2FiveShardMatchResultResponse { get { return _socket.GetLastResponse<Five2FiveShardMatchResultResponse>(); } }
		static Five2FiveHandler()
		{
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveApplyMatchPush", typeof(Five2FiveApplyMatchPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveMatchMemberInfoPush", typeof(Five2FiveMatchMemberInfoPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveMemberChoicePush", typeof(Five2FiveMemberChoicePush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveOnGameEndPush", typeof(Five2FiveOnGameEndPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveOnNewRewardPush", typeof(Five2FiveOnNewRewardPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveOnNoRewardPush", typeof(Five2FiveOnNoRewardPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveMatchFailedPush", typeof(Five2FiveMatchFailedPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveLeaderCancelMatchPush", typeof(Five2FiveLeaderCancelMatchPush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveTeamChangePush", typeof(Five2FiveTeamChangePush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveMatchPoolChangePush", typeof(Five2FiveMatchPoolChangePush));
			EventTypes.RegistPushType("five2five.five2FivePush.five2FiveApplyMatchResultPush", typeof(Five2FiveApplyMatchResultPush));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveRequest", typeof(Five2FiveRequest), typeof(Five2FiveResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveLookBtlReportRequest", typeof(Five2FiveLookBtlReportRequest), typeof(Five2FiveLookBtlReportResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveMatchRequest", typeof(Five2FiveMatchRequest), typeof(Five2FiveMatchResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveRefuseMatchRequest", typeof(Five2FiveRefuseMatchRequest), typeof(Five2FiveRefuseMatchResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveAgreeMatchRequest", typeof(Five2FiveAgreeMatchRequest), typeof(Five2FiveAgreeMatchResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveCancelMatchRequest", typeof(Five2FiveCancelMatchRequest), typeof(Five2FiveCancelMatchResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveReadyRequest", typeof(Five2FiveReadyRequest), typeof(Five2FiveReadyResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveLeaveAreaRequest", typeof(Five2FiveLeaveAreaRequest), typeof(Five2FiveLeaveAreaResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveReciveRewardRequest", typeof(Five2FiveReciveRewardRequest), typeof(Five2FiveReciveRewardResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveLookMatchResultRequest", typeof(Five2FiveLookMatchResultRequest), typeof(Five2FiveLookMatchResultResponse));
			EventTypes.RegistRequestType("five2five.five2FiveHandler.five2FiveShardMatchResultRequest", typeof(Five2FiveShardMatchResultRequest), typeof(Five2FiveShardMatchResultResponse));
		}
		public Five2FiveHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void five2FiveRequest(Action<PomeloException,Five2FiveResponse> cb,object option = null)
		{
			var request = new Five2FiveRequest();
			_socket.request<Five2FiveResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveLookBtlReportRequest(Action<PomeloException,Five2FiveLookBtlReportResponse> cb,object option = null)
		{
			var request = new Five2FiveLookBtlReportRequest();
			_socket.request<Five2FiveLookBtlReportResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveLookBtlReportResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveMatchRequest(int matchOrReMatch,Action<PomeloException,Five2FiveMatchResponse> cb,object option = null)
		{
			var request = new Five2FiveMatchRequest();
			request.matchOrReMatch= matchOrReMatch;
			_socket.request<Five2FiveMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveRefuseMatchRequest(Action<PomeloException,Five2FiveRefuseMatchResponse> cb,object option = null)
		{
			var request = new Five2FiveRefuseMatchRequest();
			_socket.request<Five2FiveRefuseMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveRefuseMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveAgreeMatchRequest(Action<PomeloException,Five2FiveAgreeMatchResponse> cb,object option = null)
		{
			var request = new Five2FiveAgreeMatchRequest();
			_socket.request<Five2FiveAgreeMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveAgreeMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveCancelMatchRequest(Action<PomeloException,Five2FiveCancelMatchResponse> cb,object option = null)
		{
			var request = new Five2FiveCancelMatchRequest();
			_socket.request<Five2FiveCancelMatchResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveCancelMatchResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveReadyRequest(string tempTeamId,Action<PomeloException,Five2FiveReadyResponse> cb,object option = null)
		{
			var request = new Five2FiveReadyRequest();
			request.tempTeamId= tempTeamId;
			_socket.request<Five2FiveReadyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveReadyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveLeaveAreaRequest(Action<PomeloException,Five2FiveLeaveAreaResponse> cb,object option = null)
		{
			var request = new Five2FiveLeaveAreaRequest();
			_socket.request<Five2FiveLeaveAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveLeaveAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveReciveRewardRequest(Action<PomeloException,Five2FiveReciveRewardResponse> cb,object option = null)
		{
			var request = new Five2FiveReciveRewardRequest();
			_socket.request<Five2FiveReciveRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveReciveRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveLookMatchResultRequest(string instanceId,Action<PomeloException,Five2FiveLookMatchResultResponse> cb,object option = null)
		{
			var request = new Five2FiveLookMatchResultRequest();
			request.instanceId= instanceId;
			_socket.request<Five2FiveLookMatchResultResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveLookMatchResultResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void five2FiveShardMatchResultRequest(string instanceId,Action<PomeloException,Five2FiveShardMatchResultResponse> cb,object option = null)
		{
			var request = new Five2FiveShardMatchResultRequest();
			request.instanceId= instanceId;
			_socket.request<Five2FiveShardMatchResultResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as Five2FiveShardMatchResultResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onFive2FiveApplyMatchPush(Action<Five2FiveApplyMatchPush> cb)
		{
			_socket.listen_once<Five2FiveApplyMatchPush>(cb);
		}
		public void onFive2FiveMatchMemberInfoPush(Action<Five2FiveMatchMemberInfoPush> cb)
		{
			_socket.listen_once<Five2FiveMatchMemberInfoPush>(cb);
		}
		public void onFive2FiveMemberChoicePush(Action<Five2FiveMemberChoicePush> cb)
		{
			_socket.listen_once<Five2FiveMemberChoicePush>(cb);
		}
		public void onFive2FiveOnGameEndPush(Action<Five2FiveOnGameEndPush> cb)
		{
			_socket.listen_once<Five2FiveOnGameEndPush>(cb);
		}
		public void onFive2FiveOnNewRewardPush(Action<Five2FiveOnNewRewardPush> cb)
		{
			_socket.listen_once<Five2FiveOnNewRewardPush>(cb);
		}
		public void onFive2FiveOnNoRewardPush(Action<Five2FiveOnNoRewardPush> cb)
		{
			_socket.listen_once<Five2FiveOnNoRewardPush>(cb);
		}
		public void onFive2FiveMatchFailedPush(Action<Five2FiveMatchFailedPush> cb)
		{
			_socket.listen_once<Five2FiveMatchFailedPush>(cb);
		}
		public void onFive2FiveLeaderCancelMatchPush(Action<Five2FiveLeaderCancelMatchPush> cb)
		{
			_socket.listen_once<Five2FiveLeaderCancelMatchPush>(cb);
		}
		public void onFive2FiveTeamChangePush(Action<Five2FiveTeamChangePush> cb)
		{
			_socket.listen_once<Five2FiveTeamChangePush>(cb);
		}
		public void onFive2FiveMatchPoolChangePush(Action<Five2FiveMatchPoolChangePush> cb)
		{
			_socket.listen_once<Five2FiveMatchPoolChangePush>(cb);
		}
		public void onFive2FiveApplyMatchResultPush(Action<Five2FiveApplyMatchResultPush> cb)
		{
			_socket.listen_once<Five2FiveApplyMatchResultPush>(cb);
		}

	}


}