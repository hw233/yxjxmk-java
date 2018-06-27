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
	public class ArenaHandler
	{
		private PomeloClient _socket;

		public ArenaInfoResponse lastArenaInfoResponse { get { return _socket.GetLastResponse<ArenaInfoResponse>(); } }
		public EnterArenaAreaResponse lastEnterArenaAreaResponse { get { return _socket.GetLastResponse<EnterArenaAreaResponse>(); } }
		public LeaveArenaAreaResponse lastLeaveArenaAreaResponse { get { return _socket.GetLastResponse<LeaveArenaAreaResponse>(); } }
		public ArenaRewardResponse lastArenaRewardResponse { get { return _socket.GetLastResponse<ArenaRewardResponse>(); } }
		static ArenaHandler()
		{
			EventTypes.RegistPushType("area.arenaPush.onArenaBattleInfoPush", typeof(OnArenaBattleInfoPush));
			EventTypes.RegistPushType("area.arenaPush.onArenaBattleEndPush", typeof(OnArenaBattleEndPush));
			EventTypes.RegistRequestType("area.arenaHandler.arenaInfoRequest", typeof(ArenaInfoRequest), typeof(ArenaInfoResponse));
			EventTypes.RegistRequestType("area.arenaHandler.enterArenaAreaRequest", typeof(EnterArenaAreaRequest), typeof(EnterArenaAreaResponse));
			EventTypes.RegistRequestType("area.arenaHandler.leaveArenaAreaRequest", typeof(LeaveArenaAreaRequest), typeof(LeaveArenaAreaResponse));
			EventTypes.RegistRequestType("area.arenaHandler.arenaRewardRequest", typeof(ArenaRewardRequest), typeof(ArenaRewardResponse));
		}
		public ArenaHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void arenaInfoRequest(Action<PomeloException,ArenaInfoResponse> cb,object option = null)
		{
			var request = new ArenaInfoRequest();
			_socket.request<ArenaInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ArenaInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterArenaAreaRequest(Action<PomeloException,EnterArenaAreaResponse> cb,object option = null)
		{
			var request = new EnterArenaAreaRequest();
			_socket.request<EnterArenaAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterArenaAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void leaveArenaAreaRequest(Action<PomeloException,LeaveArenaAreaResponse> cb,object option = null)
		{
			var request = new LeaveArenaAreaRequest();
			_socket.request<LeaveArenaAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as LeaveArenaAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void arenaRewardRequest(int c2s_type,Action<PomeloException,ArenaRewardResponse> cb,object option = null)
		{
			var request = new ArenaRewardRequest();
			request.c2s_type= c2s_type;
			_socket.request<ArenaRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ArenaRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onArenaBattleInfoPush(Action<OnArenaBattleInfoPush> cb)
		{
			_socket.listen_once<OnArenaBattleInfoPush>(cb);
		}
		public void onArenaBattleEndPush(Action<OnArenaBattleEndPush> cb)
		{
			_socket.listen_once<OnArenaBattleEndPush>(cb);
		}

	}


}