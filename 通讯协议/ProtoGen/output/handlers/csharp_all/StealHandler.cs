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
	public class StealHandler
	{
		private PomeloClient _socket;

		public StealResponse lastStealResponse { get { return _socket.GetLastResponse<StealResponse>(); } }
		static StealHandler()
		{
			EventTypes.RegistRequestType("area.stealHandler.stealRequest", typeof(StealRequest), typeof(StealResponse));
		}
		public StealHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void stealRequest(int c2s_id,Action<PomeloException,StealResponse> cb,object option = null)
		{
			var request = new StealRequest();
			request.c2s_id= c2s_id;
			_socket.request<StealResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as StealResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}