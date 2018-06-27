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
	public class NpcHandler
	{
		private PomeloClient _socket;

		public RecoverByNpcResponse lastRecoverByNpcResponse { get { return _socket.GetLastResponse<RecoverByNpcResponse>(); } }
		static NpcHandler()
		{
			EventTypes.RegistRequestType("area.npcHandler.recoverByNpcRequest", typeof(RecoverByNpcRequest), typeof(RecoverByNpcResponse));
		}
		public NpcHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void recoverByNpcRequest(string npcObjId,Action<PomeloException,RecoverByNpcResponse> cb,object option = null)
		{
			var request = new RecoverByNpcRequest();
			request.npcObjId= npcObjId;
			_socket.request<RecoverByNpcResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RecoverByNpcResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}