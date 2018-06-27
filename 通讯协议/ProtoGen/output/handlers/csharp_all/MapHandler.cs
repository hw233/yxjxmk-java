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
	public class MapHandler
	{
		private PomeloClient _socket;

		public GnterSceneByAreaIdResponse lastGnterSceneByAreaIdResponse { get { return _socket.GetLastResponse<GnterSceneByAreaIdResponse>(); } }
		public GetWorldMapListResponse lastGetWorldMapListResponse { get { return _socket.GetLastResponse<GetWorldMapListResponse>(); } }
		public GetPlayerListResponse lastGetPlayerListResponse { get { return _socket.GetLastResponse<GetPlayerListResponse>(); } }
		public GetMonsterListResponse lastGetMonsterListResponse { get { return _socket.GetLastResponse<GetMonsterListResponse>(); } }
		public GetNpcListResponse lastGetNpcListResponse { get { return _socket.GetLastResponse<GetNpcListResponse>(); } }
		public GetMapListResponse lastGetMapListResponse { get { return _socket.GetLastResponse<GetMapListResponse>(); } }
		public GetAliveMonsterLineInfoResponse lastGetAliveMonsterLineInfoResponse { get { return _socket.GetLastResponse<GetAliveMonsterLineInfoResponse>(); } }
		static MapHandler()
		{
			EventTypes.RegistRequestType("area.mapHandler.enterSceneByAreaIdRequest", typeof(GnterSceneByAreaIdRequest), typeof(GnterSceneByAreaIdResponse));
			EventTypes.RegistRequestType("area.mapHandler.getWorldMapListRequest", typeof(GetWorldMapListRequest), typeof(GetWorldMapListResponse));
			EventTypes.RegistRequestType("area.mapHandler.getPlayerListRequest", typeof(GetPlayerListRequest), typeof(GetPlayerListResponse));
			EventTypes.RegistRequestType("area.mapHandler.getMonsterListRequest", typeof(GetMonsterListRequest), typeof(GetMonsterListResponse));
			EventTypes.RegistRequestType("area.mapHandler.getNpcListRequest", typeof(GetNpcListRequest), typeof(GetNpcListResponse));
			EventTypes.RegistRequestType("area.mapHandler.getMapListRequest", typeof(GetMapListRequest), typeof(GetMapListResponse));
			EventTypes.RegistRequestType("area.mapHandler.getAliveMonsterLineInfoRequest", typeof(GetAliveMonsterLineInfoRequest), typeof(GetAliveMonsterLineInfoResponse));
		}
		public MapHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void enterSceneByAreaIdRequest(int c2s_areaId,Action<PomeloException,GnterSceneByAreaIdResponse> cb,object option = null)
		{
			var request = new GnterSceneByAreaIdRequest();
			request.c2s_areaId= c2s_areaId;
			_socket.request<GnterSceneByAreaIdResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GnterSceneByAreaIdResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getWorldMapListRequest(Action<PomeloException,GetWorldMapListResponse> cb,object option = null)
		{
			var request = new GetWorldMapListRequest();
			_socket.request<GetWorldMapListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetWorldMapListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getPlayerListRequest(Action<PomeloException,GetPlayerListResponse> cb,object option = null)
		{
			var request = new GetPlayerListRequest();
			_socket.request<GetPlayerListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetPlayerListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMonsterListRequest(Action<PomeloException,GetMonsterListResponse> cb,object option = null)
		{
			var request = new GetMonsterListRequest();
			_socket.request<GetMonsterListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMonsterListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getNpcListRequest(Action<PomeloException,GetNpcListResponse> cb,object option = null)
		{
			var request = new GetNpcListRequest();
			_socket.request<GetNpcListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetNpcListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMapListRequest(int c2s_mapId,Action<PomeloException,GetMapListResponse> cb,object option = null)
		{
			var request = new GetMapListRequest();
			request.c2s_mapId= c2s_mapId;
			_socket.request<GetMapListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMapListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAliveMonsterLineInfoRequest(Action<PomeloException,GetAliveMonsterLineInfoResponse> cb,object option = null)
		{
			var request = new GetAliveMonsterLineInfoRequest();
			_socket.request<GetAliveMonsterLineInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAliveMonsterLineInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}