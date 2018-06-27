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
	public class DailyActivityHandler
	{
		private PomeloClient _socket;

		public DailyActivityResponse lastDailyActivityResponse { get { return _socket.GetLastResponse<DailyActivityResponse>(); } }
		public GetDegreeRewardResponse lastGetDegreeRewardResponse { get { return _socket.GetLastResponse<GetDegreeRewardResponse>(); } }
		static DailyActivityHandler()
		{
			EventTypes.RegistPushType("area.dailyActivityPush.updateActivityPush", typeof(UpdateActivityPush));
			EventTypes.RegistRequestType("area.dailyActivityHandler.dailyActivityRequest", typeof(DailyActivityRequest), typeof(DailyActivityResponse));
			EventTypes.RegistRequestType("area.dailyActivityHandler.getDegreeRewardRequest", typeof(GetDegreeRewardRequest), typeof(GetDegreeRewardResponse));
		}
		public DailyActivityHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void dailyActivityRequest(Action<PomeloException,DailyActivityResponse> cb,object option = null)
		{
			var request = new DailyActivityRequest();
			_socket.request<DailyActivityResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyActivityResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDegreeRewardRequest(int id,Action<PomeloException,GetDegreeRewardResponse> cb,object option = null)
		{
			var request = new GetDegreeRewardRequest();
			request.id= id;
			_socket.request<GetDegreeRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDegreeRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onUpdateActivityPush(Action<UpdateActivityPush> cb)
		{
			_socket.listen_once<UpdateActivityPush>(cb);
		}

	}


}