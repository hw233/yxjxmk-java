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
	public class MessageHandler
	{
		private PomeloClient _socket;

		public HandleMessageResponse lastHandleMessageResponse { get { return _socket.GetLastResponse<HandleMessageResponse>(); } }
		static MessageHandler()
		{
			EventTypes.RegistPushType("area.messagePush.onMessageAddPush", typeof(OnMessageAddPush));
			EventTypes.RegistRequestType("area.messageHandler.handleMessageRequest", typeof(HandleMessageRequest), typeof(HandleMessageResponse));
		}
		public MessageHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void handleMessageRequest(string c2s_id,int c2s_type,int c2s_operate,Action<PomeloException,HandleMessageResponse> cb,object option = null)
		{
			var request = new HandleMessageRequest();
			request.c2s_id= c2s_id;
			request.c2s_type= c2s_type;
			request.c2s_operate= c2s_operate;
			_socket.request<HandleMessageResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as HandleMessageResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onMessageAddPush(Action<OnMessageAddPush> cb)
		{
			_socket.listen_once<OnMessageAddPush>(cb);
		}

	}


}