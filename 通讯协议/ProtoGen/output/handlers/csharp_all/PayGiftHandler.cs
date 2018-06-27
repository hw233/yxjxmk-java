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
	public class PayGiftHandler
	{
		private PomeloClient _socket;

		public FirstPayGiftInfoResponse lastFirstPayGiftInfoResponse { get { return _socket.GetLastResponse<FirstPayGiftInfoResponse>(); } }
		public GetFirstPayGiftResponse lastGetFirstPayGiftResponse { get { return _socket.GetLastResponse<GetFirstPayGiftResponse>(); } }
		public DailyPayGiftInfoResponse lastDailyPayGiftInfoResponse { get { return _socket.GetLastResponse<DailyPayGiftInfoResponse>(); } }
		public GetDailyPayGiftResponse lastGetDailyPayGiftResponse { get { return _socket.GetLastResponse<GetDailyPayGiftResponse>(); } }
		static PayGiftHandler()
		{
			EventTypes.RegistRequestType("area.payGiftHandler.firstPayGiftInfoRequest", typeof(FirstPayGiftInfoRequest), typeof(FirstPayGiftInfoResponse));
			EventTypes.RegistRequestType("area.payGiftHandler.getFirstPayGiftRequest", typeof(GetFirstPayGiftRequest), typeof(GetFirstPayGiftResponse));
			EventTypes.RegistRequestType("area.payGiftHandler.dailyPayGiftInfoRequest", typeof(DailyPayGiftInfoRequest), typeof(DailyPayGiftInfoResponse));
			EventTypes.RegistRequestType("area.payGiftHandler.getDailyPayGiftRequest", typeof(GetDailyPayGiftRequest), typeof(GetDailyPayGiftResponse));
		}
		public PayGiftHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void firstPayGiftInfoRequest(Action<PomeloException,FirstPayGiftInfoResponse> cb,object option = null)
		{
			var request = new FirstPayGiftInfoRequest();
			_socket.request<FirstPayGiftInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FirstPayGiftInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getFirstPayGiftRequest(Action<PomeloException,GetFirstPayGiftResponse> cb,object option = null)
		{
			var request = new GetFirstPayGiftRequest();
			_socket.request<GetFirstPayGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetFirstPayGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void dailyPayGiftInfoRequest(Action<PomeloException,DailyPayGiftInfoResponse> cb,object option = null)
		{
			var request = new DailyPayGiftInfoRequest();
			_socket.request<DailyPayGiftInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DailyPayGiftInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDailyPayGiftRequest(int c2s_giftId,Action<PomeloException,GetDailyPayGiftResponse> cb,object option = null)
		{
			var request = new GetDailyPayGiftRequest();
			request.c2s_giftId= c2s_giftId;
			_socket.request<GetDailyPayGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDailyPayGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}