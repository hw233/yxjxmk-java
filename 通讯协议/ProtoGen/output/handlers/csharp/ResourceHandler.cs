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
	public class ResourceHandler
	{
		private PomeloClient _socket;

		public QueryAreaDataResponse lastQueryAreaDataResponse { get { return _socket.GetLastResponse<QueryAreaDataResponse>(); } }
		static ResourceHandler()
		{
			EventTypes.RegistRequestType("area.resourceHandler.queryAreaDataRequest", typeof(QueryAreaDataRequest), typeof(QueryAreaDataResponse));
		}
		public ResourceHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void queryAreaDataRequest(Action<PomeloException,QueryAreaDataResponse> cb,object option = null)
		{
			var request = new QueryAreaDataRequest();
			_socket.request<QueryAreaDataResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryAreaDataResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}