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

namespace pomelo.xianyuan
{
	public class XianYuanHandler
	{
		private PomeloClient _socket;

		public XianYuanResponse lastXianYuanResponse { get { return _socket.GetLastResponse<XianYuanResponse>(); } }
		static XianYuanHandler()
		{
			EventTypes.RegistRequestType("xianyuan.xianYuanHandler.applyXianYuanRequest", typeof(XianYuanRequest), typeof(XianYuanResponse));
		}
		public XianYuanHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void applyXianYuanRequest(Action<PomeloException,XianYuanResponse> cb,object option = null)
		{
			var request = new XianYuanRequest();
			_socket.request<XianYuanResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as XianYuanResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}