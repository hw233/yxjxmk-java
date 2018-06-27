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
	public class HookSetHandler
	{
		private PomeloClient _socket;

		public ChangeHookSetResponse lastChangeHookSetResponse { get { return _socket.GetLastResponse<ChangeHookSetResponse>(); } }
		static HookSetHandler()
		{
			EventTypes.RegistRequestType("area.hookSetHandler.changeHookSetRequest", typeof(ChangeHookSetRequest), typeof(ChangeHookSetResponse));
		}
		public HookSetHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void changeHookSetRequest(HookSetData c2s_hookSetData,Action<PomeloException,ChangeHookSetResponse> cb,object option = null)
		{
			var request = new ChangeHookSetRequest();
			request.c2s_hookSetData= c2s_hookSetData;
			_socket.request<ChangeHookSetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeHookSetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}