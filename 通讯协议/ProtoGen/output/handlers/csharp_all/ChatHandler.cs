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

namespace pomelo.chat
{
	public class ChatHandler
	{
		private PomeloClient _socket;

		public SendChatResponse lastSendChatResponse { get { return _socket.GetLastResponse<SendChatResponse>(); } }
		public GetSaveChatMsgResponse lastGetSaveChatMsgResponse { get { return _socket.GetLastResponse<GetSaveChatMsgResponse>(); } }
		static ChatHandler()
		{
			EventTypes.RegistPushType("chat.chatPush.onChatPush", typeof(OnChatPush));
			EventTypes.RegistPushType("chat.chatPush.onChatErrorPush", typeof(OnChatErrorPush));
			EventTypes.RegistPushType("chat.chatPush.tipPush", typeof(TipPush));
			EventTypes.RegistRequestType("chat.chatHandler.sendChatRequest", typeof(SendChatRequest), typeof(SendChatResponse));
			EventTypes.RegistRequestType("chat.chatHandler.getSaveChatMsgRequest", typeof(GetSaveChatMsgRequest), typeof(GetSaveChatMsgResponse));
		}
		public ChatHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void sendChatRequest(int c2s_scope,string c2s_content,string c2s_serverData,string c2s_acceptRoleId,Action<PomeloException,SendChatResponse> cb,object option = null)
		{
			var request = new SendChatRequest();
			request.c2s_scope= c2s_scope;
			request.c2s_content= c2s_content;
			request.c2s_serverData= c2s_serverData;
			request.c2s_acceptRoleId= c2s_acceptRoleId;
			_socket.request<SendChatResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SendChatResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSaveChatMsgRequest(int c2s_scope,int c2s_index,string c2s_uid,Action<PomeloException,GetSaveChatMsgResponse> cb,object option = null)
		{
			var request = new GetSaveChatMsgRequest();
			request.c2s_scope= c2s_scope;
			request.c2s_index= c2s_index;
			request.c2s_uid= c2s_uid;
			_socket.request<GetSaveChatMsgResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSaveChatMsgResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onChatPush(Action<OnChatPush> cb)
		{
			_socket.listen_once<OnChatPush>(cb);
		}
		public void onChatErrorPush(Action<OnChatErrorPush> cb)
		{
			_socket.listen_once<OnChatErrorPush>(cb);
		}
		public void onTipPush(Action<TipPush> cb)
		{
			_socket.listen_once<TipPush>(cb);
		}

	}


}