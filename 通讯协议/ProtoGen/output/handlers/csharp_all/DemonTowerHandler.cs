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
	public class DemonTowerHandler
	{
		private PomeloClient _socket;

		public GetDemonTowerInfoResponse lastGetDemonTowerInfoResponse { get { return _socket.GetLastResponse<GetDemonTowerInfoResponse>(); } }
		public GetDemonTowerSweepInfoResponse lastGetDemonTowerSweepInfoResponse { get { return _socket.GetLastResponse<GetDemonTowerSweepInfoResponse>(); } }
		public StartToSweepDemonTowerResponse lastStartToSweepDemonTowerResponse { get { return _socket.GetLastResponse<StartToSweepDemonTowerResponse>(); } }
		public StartDemonTowerResponse lastStartDemonTowerResponse { get { return _socket.GetLastResponse<StartDemonTowerResponse>(); } }
		public FinishSweepDemonTowerResponse lastFinishSweepDemonTowerResponse { get { return _socket.GetLastResponse<FinishSweepDemonTowerResponse>(); } }
		static DemonTowerHandler()
		{
			EventTypes.RegistPushType("area.demonTowerPush.sweepDemonTowerEndPush", typeof(SweepDemonTowerEndPush));
			EventTypes.RegistRequestType("area.demonTowerHandler.getDemonTowerInfoRequest", typeof(GetDemonTowerInfoRequest), typeof(GetDemonTowerInfoResponse));
			EventTypes.RegistRequestType("area.demonTowerHandler.getDemonTowerSweepInfoRequest", typeof(GetDemonTowerSweepInfoRequest), typeof(GetDemonTowerSweepInfoResponse));
			EventTypes.RegistRequestType("area.demonTowerHandler.startToSweepDemonTowerRequest", typeof(StartToSweepDemonTowerRequest), typeof(StartToSweepDemonTowerResponse));
			EventTypes.RegistRequestType("area.demonTowerHandler.startDemonTowerRequest", typeof(StartDemonTowerRequest), typeof(StartDemonTowerResponse));
			EventTypes.RegistRequestType("area.demonTowerHandler.finishSweepDemonTowerRequest", typeof(FinishSweepDemonTowerRequest), typeof(FinishSweepDemonTowerResponse));
		}
		public DemonTowerHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getDemonTowerInfoRequest(Action<PomeloException,GetDemonTowerInfoResponse> cb,object option = null)
		{
			var request = new GetDemonTowerInfoRequest();
			_socket.request<GetDemonTowerInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDemonTowerInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDemonTowerSweepInfoRequest(Action<PomeloException,GetDemonTowerSweepInfoResponse> cb,object option = null)
		{
			var request = new GetDemonTowerSweepInfoRequest();
			_socket.request<GetDemonTowerSweepInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDemonTowerSweepInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void startToSweepDemonTowerRequest(Action<PomeloException,StartToSweepDemonTowerResponse> cb,object option = null)
		{
			var request = new StartToSweepDemonTowerRequest();
			_socket.request<StartToSweepDemonTowerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as StartToSweepDemonTowerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void startDemonTowerRequest(Action<PomeloException,StartDemonTowerResponse> cb,object option = null)
		{
			var request = new StartDemonTowerRequest();
			_socket.request<StartDemonTowerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as StartDemonTowerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void finishSweepDemonTowerRequest(Action<PomeloException,FinishSweepDemonTowerResponse> cb,object option = null)
		{
			var request = new FinishSweepDemonTowerRequest();
			_socket.request<FinishSweepDemonTowerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FinishSweepDemonTowerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSweepDemonTowerEndPush(Action<SweepDemonTowerEndPush> cb)
		{
			_socket.listen_once<SweepDemonTowerEndPush>(cb);
		}

	}


}