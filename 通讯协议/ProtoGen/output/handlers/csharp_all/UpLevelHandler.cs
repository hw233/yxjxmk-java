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
	public class UpLevelHandler
	{
		private PomeloClient _socket;

		public UpInfoResponse lastUpInfoResponse { get { return _socket.GetLastResponse<UpInfoResponse>(); } }
		public UpLevelResponse lastUpLevelResponse { get { return _socket.GetLastResponse<UpLevelResponse>(); } }
		static UpLevelHandler()
		{
			EventTypes.RegistRequestType("area.upLevelHandler.upInfoRequest", typeof(UpInfoRequest), typeof(UpInfoResponse));
			EventTypes.RegistRequestType("area.upLevelHandler.upLevelRequest", typeof(UpLevelRequest), typeof(UpLevelResponse));
		}
		public UpLevelHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void upInfoRequest(Action<PomeloException,UpInfoResponse> cb,object option = null)
		{
			var request = new UpInfoRequest();
			_socket.request<UpInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upLevelRequest(Action<PomeloException,UpLevelResponse> cb,object option = null)
		{
			var request = new UpLevelRequest();
			_socket.request<UpLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}