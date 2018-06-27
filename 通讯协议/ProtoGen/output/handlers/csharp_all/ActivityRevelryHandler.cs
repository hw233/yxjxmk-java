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

namespace pomelo.revelry
{
	public class ActivityRevelryHandler
	{
		private PomeloClient _socket;

		public RevelryGetColumnResponse lastRevelryGetColumnResponse { get { return _socket.GetLastResponse<RevelryGetColumnResponse>(); } }
		public RevelryGetRankInfoResponse lastRevelryGetRankInfoResponse { get { return _socket.GetLastResponse<RevelryGetRankInfoResponse>(); } }
		public RevelryExchangeResponse lastRevelryExchangeResponse { get { return _socket.GetLastResponse<RevelryExchangeResponse>(); } }
		static ActivityRevelryHandler()
		{
			EventTypes.RegistRequestType("revelry.activityRevelryHandler.revelryGetColumnRequest", typeof(RevelryGetColumnRequest), typeof(RevelryGetColumnResponse));
			EventTypes.RegistRequestType("revelry.activityRevelryHandler.revelryGetRankInfoRequest", typeof(RevelryGetRankInfoRequest), typeof(RevelryGetRankInfoResponse));
			EventTypes.RegistRequestType("revelry.activityRevelryHandler.revelryExchangeRequest", typeof(RevelryExchangeRequest), typeof(RevelryExchangeResponse));
		}
		public ActivityRevelryHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void revelryGetColumnRequest(Action<PomeloException,RevelryGetColumnResponse> cb,object option = null)
		{
			var request = new RevelryGetColumnRequest();
			_socket.request<RevelryGetColumnResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RevelryGetColumnResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void revelryGetRankInfoRequest(string id,Action<PomeloException,RevelryGetRankInfoResponse> cb,object option = null)
		{
			var request = new RevelryGetRankInfoRequest();
			request.id= id;
			_socket.request<RevelryGetRankInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RevelryGetRankInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void revelryExchangeRequest(int id,int num,Action<PomeloException,RevelryExchangeResponse> cb,object option = null)
		{
			var request = new RevelryExchangeRequest();
			request.id= id;
			request.num= num;
			_socket.request<RevelryExchangeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RevelryExchangeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}