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

namespace pomelo.gate
{
	public class GateHandler
	{
		private PomeloClient _socket;

		public QueryEntryResponse lastQueryEntryResponse { get { return _socket.GetLastResponse<QueryEntryResponse>(); } }
		static GateHandler()
		{
			EventTypes.RegistRequestType("gate.gateHandler.queryEntryRequest", typeof(QueryEntryRequest), typeof(QueryEntryResponse));
		}
		public GateHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void queryEntryRequest(string c2s_uid,string c2s_sign,string c2s_time,int c2s_logicServerId,Action<PomeloException,QueryEntryResponse> cb,object option = null)
		{
			var request = new QueryEntryRequest();
			request.c2s_uid= c2s_uid;
			request.c2s_sign= c2s_sign;
			request.c2s_time= c2s_time;
			request.c2s_logicServerId= c2s_logicServerId;
			_socket.request<QueryEntryResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryEntryResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}