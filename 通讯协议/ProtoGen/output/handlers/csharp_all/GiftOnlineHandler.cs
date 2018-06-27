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
	public class GiftOnlineHandler
	{
		private PomeloClient _socket;

		public GetOnLineGiftResponse lastGetOnLineGiftResponse { get { return _socket.GetLastResponse<GetOnLineGiftResponse>(); } }
		static GiftOnlineHandler()
		{
			EventTypes.RegistRequestType("area.giftOnlineHandler.getOnLineGiftRequest", typeof(GetOnLineGiftRequest), typeof(GetOnLineGiftResponse));
		}
		public GiftOnlineHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getOnLineGiftRequest(Action<PomeloException,GetOnLineGiftResponse> cb,object option = null)
		{
			var request = new GetOnLineGiftRequest();
			_socket.request<GetOnLineGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetOnLineGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}