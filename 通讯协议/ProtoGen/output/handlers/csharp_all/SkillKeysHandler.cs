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
	public class SkillKeysHandler
	{
		private PomeloClient _socket;

		public SaveSkillKeysResponse lastSaveSkillKeysResponse { get { return _socket.GetLastResponse<SaveSkillKeysResponse>(); } }
		static SkillKeysHandler()
		{
			EventTypes.RegistPushType("area.skillKeysPush.skillKeyUpdatePush", typeof(SkillKeyUpdatePush));
			EventTypes.RegistRequestType("area.skillKeysHandler.saveSkillKeysRequest", typeof(SaveSkillKeysRequest), typeof(SaveSkillKeysResponse));
		}
		public SkillKeysHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void saveSkillKeysRequest(List<SkillKey> s2c_skillKeys,Action<PomeloException,SaveSkillKeysResponse> cb,object option = null)
		{
			var request = new SaveSkillKeysRequest();
			request.s2c_skillKeys.AddRange(s2c_skillKeys);
			_socket.request<SaveSkillKeysResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveSkillKeysResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSkillKeyUpdatePush(Action<SkillKeyUpdatePush> cb)
		{
			_socket.listen_once<SkillKeyUpdatePush>(cb);
		}

	}


}