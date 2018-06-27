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
	public class MailHandler
	{
		private PomeloClient _socket;

		public MailGetAllResponse lastMailGetAllResponse { get { return _socket.GetLastResponse<MailGetAllResponse>(); } }
		public MailSendMailResponse lastMailSendMailResponse { get { return _socket.GetLastResponse<MailSendMailResponse>(); } }
		public MailDeleteResponse lastMailDeleteResponse { get { return _socket.GetLastResponse<MailDeleteResponse>(); } }
		public MailDeleteOneKeyResponse lastMailDeleteOneKeyResponse { get { return _socket.GetLastResponse<MailDeleteOneKeyResponse>(); } }
		public MailGetAttachmentResponse lastMailGetAttachmentResponse { get { return _socket.GetLastResponse<MailGetAttachmentResponse>(); } }
		public MailGetAttachmentOneKeyResponse lastMailGetAttachmentOneKeyResponse { get { return _socket.GetLastResponse<MailGetAttachmentOneKeyResponse>(); } }
		static MailHandler()
		{
			EventTypes.RegistPushType("area.mailPush.onGetMailPush", typeof(OnGetMailPush));
			EventTypes.RegistRequestType("area.mailHandler.mailGetAllRequest", typeof(MailGetAllRequest), typeof(MailGetAllResponse));
			EventTypes.RegistRequestType("area.mailHandler.mailSendMailRequest", typeof(MailSendMailRequest), typeof(MailSendMailResponse));
			EventTypes.RegistRequestType("area.mailHandler.mailDeleteRequest", typeof(MailDeleteRequest), typeof(MailDeleteResponse));
			EventTypes.RegistRequestType("area.mailHandler.mailDeleteOneKeyRequest", typeof(MailDeleteOneKeyRequest), typeof(MailDeleteOneKeyResponse));
			EventTypes.RegistRequestType("area.mailHandler.mailGetAttachmentRequest", typeof(MailGetAttachmentRequest), typeof(MailGetAttachmentResponse));
			EventTypes.RegistRequestType("area.mailHandler.mailGetAttachmentOneKeyRequest", typeof(MailGetAttachmentOneKeyRequest), typeof(MailGetAttachmentOneKeyResponse));
			EventTypes.RegistNotifyType("area.mailHandler.mailReadNotify", typeof(MailReadNotify));
			EventTypes.RegistNotifyType("area.mailHandler.mailSendTestNotify", typeof(MailSendTestNotify));
		}
		public MailHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void mailGetAllRequest(Action<PomeloException,MailGetAllResponse> cb,object option = null)
		{
			var request = new MailGetAllRequest();
			_socket.request<MailGetAllResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailGetAllResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailSendMailRequest(string toPlayerId,string mailTitle,string mailText,int mailRead,string toPlayerName,Action<PomeloException,MailSendMailResponse> cb,object option = null)
		{
			var request = new MailSendMailRequest();
			request.toPlayerId= toPlayerId;
			request.mailTitle= mailTitle;
			request.mailText= mailText;
			request.mailRead= mailRead;
			request.toPlayerName= toPlayerName;
			_socket.request<MailSendMailResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailSendMailResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailDeleteRequest(string c2s_id,Action<PomeloException,MailDeleteResponse> cb,object option = null)
		{
			var request = new MailDeleteRequest();
			request.c2s_id= c2s_id;
			_socket.request<MailDeleteResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailDeleteResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailDeleteOneKeyRequest(Action<PomeloException,MailDeleteOneKeyResponse> cb,object option = null)
		{
			var request = new MailDeleteOneKeyRequest();
			_socket.request<MailDeleteOneKeyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailDeleteOneKeyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailGetAttachmentRequest(string c2s_id,Action<PomeloException,MailGetAttachmentResponse> cb,object option = null)
		{
			var request = new MailGetAttachmentRequest();
			request.c2s_id= c2s_id;
			_socket.request<MailGetAttachmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailGetAttachmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailGetAttachmentOneKeyRequest(Action<PomeloException,MailGetAttachmentOneKeyResponse> cb,object option = null)
		{
			var request = new MailGetAttachmentOneKeyRequest();
			_socket.request<MailGetAttachmentOneKeyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MailGetAttachmentOneKeyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void mailReadNotify(List<string> c2s_id)
		{
			var notify = new MailReadNotify();
			notify.c2s_id.AddRange(c2s_id);

			_socket.notify(notify);

		}
		public void mailSendTestNotify(int c2s_mailId,string c2s_tcCode)
		{
			var notify = new MailSendTestNotify();
			notify.c2s_mailId= c2s_mailId;
			notify.c2s_tcCode= c2s_tcCode;

			_socket.notify(notify);

		}
		public void onGetMailPush(Action<OnGetMailPush> cb)
		{
			_socket.listen_once<OnGetMailPush>(cb);
		}

	}


}