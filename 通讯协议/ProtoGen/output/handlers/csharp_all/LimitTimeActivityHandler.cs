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
	public class LimitTimeActivityHandler
	{
		private PomeloClient _socket;

		public GetLimitTimeActivityInfoResponse lastGetLimitTimeActivityInfoResponse { get { return _socket.GetLastResponse<GetLimitTimeActivityInfoResponse>(); } }
		static LimitTimeActivityHandler()
		{
			EventTypes.RegistPushType("area.limitTimeActivityPush.ltActivityInfoPush", typeof(LTActivityInfoPush));
			EventTypes.RegistRequestType("area.limitTimeActivityHandler.getLimitTimeActivityInfoRequest", typeof(GetLimitTimeActivityInfoRequest), typeof(GetLimitTimeActivityInfoResponse));
		}
		public LimitTimeActivityHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getLimitTimeActivityInfoRequest(Action<PomeloException,GetLimitTimeActivityInfoResponse> cb,object option = null)
		{
			var request = new GetLimitTimeActivityInfoRequest();
			_socket.request<GetLimitTimeActivityInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetLimitTimeActivityInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onLtActivityInfoPush(Action<LTActivityInfoPush> cb)
		{
			_socket.listen_once<LTActivityInfoPush>(cb);
		}

	}


}