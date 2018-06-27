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

namespace pomelo.daoyou
{
	public class DaoYouHandler
	{
		private PomeloClient _socket;

		public DaoYouResponse lastDaoYouResponse { get { return _socket.GetLastResponse<DaoYouResponse>(); } }
		public DaoYouInviteDaoYouResponse lastDaoYouInviteDaoYouResponse { get { return _socket.GetLastResponse<DaoYouInviteDaoYouResponse>(); } }
		public DaoYouFastInviteDaoYouResponse lastDaoYouFastInviteDaoYouResponse { get { return _socket.GetLastResponse<DaoYouFastInviteDaoYouResponse>(); } }
		public DaoYouEditTeamNameResponse lastDaoYouEditTeamNameResponse { get { return _socket.GetLastResponse<DaoYouEditTeamNameResponse>(); } }
		public DaoYouLeaveMessageResponse lastDaoYouLeaveMessageResponse { get { return _socket.GetLastResponse<DaoYouLeaveMessageResponse>(); } }
		public DaoYouNoticeResponse lastDaoYouNoticeResponse { get { return _socket.GetLastResponse<DaoYouNoticeResponse>(); } }
		public DaoYouKickTeamResponse lastDaoYouKickTeamResponse { get { return _socket.GetLastResponse<DaoYouKickTeamResponse>(); } }
		public DaoYouTransferAdminResponse lastDaoYouTransferAdminResponse { get { return _socket.GetLastResponse<DaoYouTransferAdminResponse>(); } }
		public DaoYouQuitTeamResponse lastDaoYouQuitTeamResponse { get { return _socket.GetLastResponse<DaoYouQuitTeamResponse>(); } }
		public DaoYouRebateResponse lastDaoYouRebateResponse { get { return _socket.GetLastResponse<DaoYouRebateResponse>(); } }
		static DaoYouHandler()
		{
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouRequest", typeof(DaoYouRequest), typeof(DaoYouResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouInviteDaoYouRequest", typeof(DaoYouInviteDaoYouRequest), typeof(DaoYouInviteDaoYouResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouFastInviteDaoYouRequest", typeof(DaoYouFastInviteDaoYouRequest), typeof(DaoYouFastInviteDaoYouResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouEditTeamNameRequest", typeof(DaoYouEditTeamNameRequest), typeof(DaoYouEditTeamNameResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouLeaveMessageRequest", typeof(DaoYouLeaveMessageRequest), typeof(DaoYouLeaveMessageResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouNoticeRequest", typeof(DaoYouNoticeRequest), typeof(DaoYouNoticeResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouKickTeamRequest", typeof(DaoYouKickTeamRequest), typeof(DaoYouKickTeamResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouTransferAdminRequest", typeof(DaoYouTransferAdminRequest), typeof(DaoYouTransferAdminResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouQuitTeamRequest", typeof(DaoYouQuitTeamRequest), typeof(DaoYouQuitTeamResponse));
			EventTypes.RegistRequestType("daoyou.daoYouHandler.daoYouRebateRequest", typeof(DaoYouRebateRequest), typeof(DaoYouRebateResponse));
		}
		public DaoYouHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void daoYouRequest(Action<PomeloException,DaoYouResponse> cb,object option = null)
		{
			var request = new DaoYouRequest();
			_socket.request<DaoYouResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouInviteDaoYouRequest(string playerId,Action<PomeloException,DaoYouInviteDaoYouResponse> cb,object option = null)
		{
			var request = new DaoYouInviteDaoYouRequest();
			request.playerId= playerId;
			_socket.request<DaoYouInviteDaoYouResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouInviteDaoYouResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouFastInviteDaoYouRequest(Action<PomeloException,DaoYouFastInviteDaoYouResponse> cb,object option = null)
		{
			var request = new DaoYouFastInviteDaoYouRequest();
			_socket.request<DaoYouFastInviteDaoYouResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouFastInviteDaoYouResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouEditTeamNameRequest(string teamName,Action<PomeloException,DaoYouEditTeamNameResponse> cb,object option = null)
		{
			var request = new DaoYouEditTeamNameRequest();
			request.teamName= teamName;
			_socket.request<DaoYouEditTeamNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouEditTeamNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouLeaveMessageRequest(string message,Action<PomeloException,DaoYouLeaveMessageResponse> cb,object option = null)
		{
			var request = new DaoYouLeaveMessageRequest();
			request.message= message;
			_socket.request<DaoYouLeaveMessageResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouLeaveMessageResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouNoticeRequest(string notice,Action<PomeloException,DaoYouNoticeResponse> cb,object option = null)
		{
			var request = new DaoYouNoticeRequest();
			request.notice= notice;
			_socket.request<DaoYouNoticeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouNoticeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouKickTeamRequest(string playerId,Action<PomeloException,DaoYouKickTeamResponse> cb,object option = null)
		{
			var request = new DaoYouKickTeamRequest();
			request.playerId= playerId;
			_socket.request<DaoYouKickTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouKickTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouTransferAdminRequest(string playerId,Action<PomeloException,DaoYouTransferAdminResponse> cb,object option = null)
		{
			var request = new DaoYouTransferAdminRequest();
			request.playerId= playerId;
			_socket.request<DaoYouTransferAdminResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouTransferAdminResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouQuitTeamRequest(Action<PomeloException,DaoYouQuitTeamResponse> cb,object option = null)
		{
			var request = new DaoYouQuitTeamRequest();
			_socket.request<DaoYouQuitTeamResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouQuitTeamResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void daoYouRebateRequest(Action<PomeloException,DaoYouRebateResponse> cb,object option = null)
		{
			var request = new DaoYouRebateRequest();
			_socket.request<DaoYouRebateResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DaoYouRebateResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}