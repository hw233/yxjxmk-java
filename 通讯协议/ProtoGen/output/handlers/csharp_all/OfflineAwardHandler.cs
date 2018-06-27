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
	public class OfflineAwardHandler
	{
		private PomeloClient _socket;

		public QueryAllAreasResponse lastQueryAllAreasResponse { get { return _socket.GetLastResponse<QueryAllAreasResponse>(); } }
		public SetOfflineAreaIdResponse lastSetOfflineAreaIdResponse { get { return _socket.GetLastResponse<SetOfflineAreaIdResponse>(); } }
		public QueryOfflineAwardResponse lastQueryOfflineAwardResponse { get { return _socket.GetLastResponse<QueryOfflineAwardResponse>(); } }
		public GetOfflineAwardResponse lastGetOfflineAwardResponse { get { return _socket.GetLastResponse<GetOfflineAwardResponse>(); } }
		public GetCurrentOfflineAreaResponse lastGetCurrentOfflineAreaResponse { get { return _socket.GetLastResponse<GetCurrentOfflineAreaResponse>(); } }
		static OfflineAwardHandler()
		{
			EventTypes.RegistRequestType("area.offlineAwardHandler.queryAllAreasRequest", typeof(QueryAllAreasRequest), typeof(QueryAllAreasResponse));
			EventTypes.RegistRequestType("area.offlineAwardHandler.setOfflineAreaIdRequest", typeof(SetOfflineAreaIdRequest), typeof(SetOfflineAreaIdResponse));
			EventTypes.RegistRequestType("area.offlineAwardHandler.queryOfflineAwardRequest", typeof(QueryOfflineAwardRequest), typeof(QueryOfflineAwardResponse));
			EventTypes.RegistRequestType("area.offlineAwardHandler.getOfflineAwardRequest", typeof(GetOfflineAwardRequest), typeof(GetOfflineAwardResponse));
			EventTypes.RegistRequestType("area.offlineAwardHandler.getCurrentOfflineAreaRequest", typeof(GetCurrentOfflineAreaRequest), typeof(GetCurrentOfflineAreaResponse));
		}
		public OfflineAwardHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void queryAllAreasRequest(Action<PomeloException,QueryAllAreasResponse> cb,object option = null)
		{
			var request = new QueryAllAreasRequest();
			_socket.request<QueryAllAreasResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryAllAreasResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setOfflineAreaIdRequest(int c2s_areaId,Action<PomeloException,SetOfflineAreaIdResponse> cb,object option = null)
		{
			var request = new SetOfflineAreaIdRequest();
			request.c2s_areaId= c2s_areaId;
			_socket.request<SetOfflineAreaIdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetOfflineAreaIdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryOfflineAwardRequest(Action<PomeloException,QueryOfflineAwardResponse> cb,object option = null)
		{
			var request = new QueryOfflineAwardRequest();
			_socket.request<QueryOfflineAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryOfflineAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getOfflineAwardRequest(string c2s_type,Action<PomeloException,GetOfflineAwardResponse> cb,object option = null)
		{
			var request = new GetOfflineAwardRequest();
			request.c2s_type= c2s_type;
			_socket.request<GetOfflineAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetOfflineAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getCurrentOfflineAreaRequest(Action<PomeloException,GetCurrentOfflineAreaResponse> cb,object option = null)
		{
			var request = new GetCurrentOfflineAreaRequest();
			_socket.request<GetCurrentOfflineAreaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetCurrentOfflineAreaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}