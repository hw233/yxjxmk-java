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

namespace pomelo.connector
{
	public class RoleHandler
	{
		private PomeloClient _socket;

		public CreatePlayerResponse lastCreatePlayerResponse { get { return _socket.GetLastResponse<CreatePlayerResponse>(); } }
		public ChangePlayerNameResponse lastChangePlayerNameResponse { get { return _socket.GetLastResponse<ChangePlayerNameResponse>(); } }
		public DeletePlayerResponse lastDeletePlayerResponse { get { return _socket.GetLastResponse<DeletePlayerResponse>(); } }
		public GetRandomNameResponse lastGetRandomNameResponse { get { return _socket.GetLastResponse<GetRandomNameResponse>(); } }
		static RoleHandler()
		{
			EventTypes.RegistRequestType("connector.roleHandler.createPlayerRequest", typeof(CreatePlayerRequest), typeof(CreatePlayerResponse));
			EventTypes.RegistRequestType("connector.roleHandler.changePlayerNameRequest", typeof(ChangePlayerNameRequest), typeof(ChangePlayerNameResponse));
			EventTypes.RegistRequestType("connector.roleHandler.deletePlayerRequest", typeof(DeletePlayerRequest), typeof(DeletePlayerResponse));
			EventTypes.RegistRequestType("connector.roleHandler.getRandomNameRequest", typeof(GetRandomNameRequest), typeof(GetRandomNameResponse));
		}
		public RoleHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void createPlayerRequest(int c2s_pro,string c2s_name,Action<PomeloException,CreatePlayerResponse> cb,object option = null)
		{
			var request = new CreatePlayerRequest();
			request.c2s_pro= c2s_pro;
			request.c2s_name= c2s_name;
			_socket.request<CreatePlayerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CreatePlayerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changePlayerNameRequest(string c2s_name,int pos,Action<PomeloException,ChangePlayerNameResponse> cb,object option = null)
		{
			var request = new ChangePlayerNameRequest();
			request.c2s_name= c2s_name;
			request.pos= pos;
			_socket.request<ChangePlayerNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangePlayerNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void deletePlayerRequest(string c2s_playerId,Action<PomeloException,DeletePlayerResponse> cb,object option = null)
		{
			var request = new DeletePlayerRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<DeletePlayerResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DeletePlayerResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRandomNameRequest(int c2s_pro,Action<PomeloException,GetRandomNameResponse> cb,object option = null)
		{
			var request = new GetRandomNameRequest();
			request.c2s_pro= c2s_pro;
			_socket.request<GetRandomNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRandomNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}