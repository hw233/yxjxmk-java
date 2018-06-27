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
	public class SoloHandler
	{
		private PomeloClient _socket;

		public SoloInfoResponse lastSoloInfoResponse { get { return _socket.GetLastResponse<SoloInfoResponse>(); } }
		public RewardInfoResponse lastRewardInfoResponse { get { return _socket.GetLastResponse<RewardInfoResponse>(); } }
		public DrawRankRewardResponse lastDrawRankRewardResponse { get { return _socket.GetLastResponse<DrawRankRewardResponse>(); } }
		public DrawDailyRewardResponse lastDrawDailyRewardResponse { get { return _socket.GetLastResponse<DrawDailyRewardResponse>(); } }
		public JoinSoloResponse lastJoinSoloResponse { get { return _socket.GetLastResponse<JoinSoloResponse>(); } }
		public JoinSoloBattleResponse lastJoinSoloBattleResponse { get { return _socket.GetLastResponse<JoinSoloBattleResponse>(); } }
		public QuitSoloResponse lastQuitSoloResponse { get { return _socket.GetLastResponse<QuitSoloResponse>(); } }
		public QueryRewardResponse lastQueryRewardResponse { get { return _socket.GetLastResponse<QueryRewardResponse>(); } }
		public LeaveSoloAreaResponse lastLeaveSoloAreaResponse { get { return _socket.GetLastResponse<LeaveSoloAreaResponse>(); } }
		public NewsInfoResponse lastNewsInfoResponse { get { return _socket.GetLastResponse<NewsInfoResponse>(); } }
		public BattleRecordResponse lastBattleRecordResponse { get { return _socket.GetLastResponse<BattleRecordResponse>(); } }
		public GetRivalInfoResponse lastGetRivalInfoResponse { get { return _socket.GetLastResponse<GetRivalInfoResponse>(); } }
		static SoloHandler()
		{
			EventTypes.RegistPushType("area.soloPush.onSoloMatchedPush", typeof(OnSoloMatchedPush));
			EventTypes.RegistPushType("area.soloPush.onNewRewardPush", typeof(OnNewRewardPush));
			EventTypes.RegistPushType("area.soloPush.onFightPointPush", typeof(OnFightPointPush));
			EventTypes.RegistPushType("area.soloPush.onRoundEndPush", typeof(OnRoundEndPush));
			EventTypes.RegistPushType("area.soloPush.onGameEndPush", typeof(OnGameEndPush));
			EventTypes.RegistPushType("area.soloPush.leftSoloTimePush", typeof(LeftSoloTimePush));
			EventTypes.RegistPushType("area.soloPush.cancelMatchPush", typeof(CancelMatchPush));
			EventTypes.RegistRequestType("area.soloHandler.soloInfoRequest", typeof(SoloInfoRequest), typeof(SoloInfoResponse));
			EventTypes.RegistRequestType("area.soloHandler.rewardInfoRequest", typeof(RewardInfoRequest), typeof(RewardInfoResponse));
			EventTypes.RegistRequestType("area.soloHandler.drawRankRewardRequest", typeof(DrawRankRewardRequest), typeof(DrawRankRewardResponse));
			EventTypes.RegistRequestType("area.soloHandler.drawDailyRewardRequest", typeof(DrawDailyRewardRequest), typeof(DrawDailyRewardResponse));
			EventTypes.RegistRequestType("area.soloHandler.joinSoloRequest", typeof(JoinSoloRequest), typeof(JoinSoloResponse));
			EventTypes.RegistRequestType("area.soloHandler.joinSoloBattleRequest", typeof(JoinSoloBattleRequest), typeof(JoinSoloBattleResponse));
			EventTypes.RegistRequestType("area.soloHandler.quitSoloRequest", typeof(QuitSoloRequest), typeof(QuitSoloResponse));
			EventTypes.RegistRequestType("area.soloHandler.queryRewardRequest", typeof(QueryRewardRequest), typeof(QueryRewardResponse));
			EventTypes.RegistRequestType("area.soloHandler.leaveSoloAreaRequest", typeof(LeaveSoloAreaRequest), typeof(LeaveSoloAreaResponse));
			EventTypes.RegistRequestType("area.soloHandler.newsInfoRequest", typeof(NewsInfoRequest), typeof(NewsInfoResponse));
			EventTypes.RegistRequestType("area.soloHandler.battleRecordRequest", typeof(BattleRecordRequest), typeof(BattleRecordResponse));
			EventTypes.RegistRequestType("area.soloHandler.getRivalInfoRequest", typeof(Void), typeof(GetRivalInfoResponse));
		}
		public SoloHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void soloInfoRequest(Action<PomeloException,SoloInfoResponse> cb,object option = null)
		{
			var request = new SoloInfoRequest();
			_socket.request<SoloInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SoloInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void rewardInfoRequest(Action<PomeloException,RewardInfoResponse> cb,object option = null)
		{
			var request = new RewardInfoRequest();
			_socket.request<RewardInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RewardInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawRankRewardRequest(int c2s_rankId,Action<PomeloException,DrawRankRewardResponse> cb,object option = null)
		{
			var request = new DrawRankRewardRequest();
			request.c2s_rankId= c2s_rankId;
			_socket.request<DrawRankRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawRankRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void drawDailyRewardRequest(int c2s_index,Action<PomeloException,DrawDailyRewardResponse> cb,object option = null)
		{
			var request = new DrawDailyRewardRequest();
			request.c2s_index= c2s_index;
			_socket.request<DrawDailyRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DrawDailyRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinSoloRequest(Action<PomeloException,JoinSoloResponse> cb,object option = null)
		{
			var request = new JoinSoloRequest();
			_socket.request<JoinSoloResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinSoloResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void joinSoloBattleRequest(Action<PomeloException,JoinSoloBattleResponse> cb,object option = null)
		{
			var request = new JoinSoloBattleRequest();
			_socket.request<JoinSoloBattleResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as JoinSoloBattleResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void quitSoloRequest(Action<PomeloException,QuitSoloResponse> cb,object option = null)
		{
			var request = new QuitSoloRequest();
			_socket.request<QuitSoloResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QuitSoloResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryRewardRequest(Action<PomeloException,QueryRewardResponse> cb,object option = null)
		{
			var request = new QueryRewardRequest();
			_socket.request<QueryRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveSoloAreaRequest(Action<PomeloException,LeaveSoloAreaResponse> cb,object option = null)
		{
			var request = new LeaveSoloAreaRequest();
			_socket.request<LeaveSoloAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveSoloAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void newsInfoRequest(Action<PomeloException,NewsInfoResponse> cb,object option = null)
		{
			var request = new NewsInfoRequest();
			_socket.request<NewsInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as NewsInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void battleRecordRequest(Action<PomeloException,BattleRecordResponse> cb,object option = null)
		{
			var request = new BattleRecordRequest();
			_socket.request<BattleRecordResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BattleRecordResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRivalInfoRequest(Action<PomeloException,GetRivalInfoResponse> cb,object option = null)
		{
			var request = new Void();
			_socket.request<GetRivalInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRivalInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSoloMatchedPush(Action<OnSoloMatchedPush> cb)
		{
			_socket.listen_once<OnSoloMatchedPush>(cb);
		}
		public void onNewRewardPush(Action<OnNewRewardPush> cb)
		{
			_socket.listen_once<OnNewRewardPush>(cb);
		}
		public void onFightPointPush(Action<OnFightPointPush> cb)
		{
			_socket.listen_once<OnFightPointPush>(cb);
		}
		public void onRoundEndPush(Action<OnRoundEndPush> cb)
		{
			_socket.listen_once<OnRoundEndPush>(cb);
		}
		public void onGameEndPush(Action<OnGameEndPush> cb)
		{
			_socket.listen_once<OnGameEndPush>(cb);
		}
		public void onLeftSoloTimePush(Action<LeftSoloTimePush> cb)
		{
			_socket.listen_once<LeftSoloTimePush>(cb);
		}
		public void onCancelMatchPush(Action<CancelMatchPush> cb)
		{
			_socket.listen_once<CancelMatchPush>(cb);
		}

	}


}