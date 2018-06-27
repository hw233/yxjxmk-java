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
	public class SysSetHandler
	{
		private PomeloClient _socket;

		public ChangeSysSetResponse lastChangeSysSetResponse { get { return _socket.GetLastResponse<ChangeSysSetResponse>(); } }
		static SysSetHandler()
		{
			EventTypes.RegistRequestType("area.sysSetHandler.changeSysSetRequest", typeof(ChangeSysSetRequest), typeof(ChangeSysSetResponse));
		}
		public SysSetHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void changeSysSetRequest(SetData c2s_setData,Action<PomeloException,ChangeSysSetResponse> cb,object option = null)
		{
			var request = new ChangeSysSetRequest();
			request.c2s_setData= c2s_setData;
			_socket.request<ChangeSysSetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeSysSetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}