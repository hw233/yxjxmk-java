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
	public class SkillHandler
	{
		private PomeloClient _socket;

		public UnlockSkillResponse lastUnlockSkillResponse { get { return _socket.GetLastResponse<UnlockSkillResponse>(); } }
		public UpgradeSkillResponse lastUpgradeSkillResponse { get { return _socket.GetLastResponse<UpgradeSkillResponse>(); } }
		public UpgradeSkillOneKeyResponse lastUpgradeSkillOneKeyResponse { get { return _socket.GetLastResponse<UpgradeSkillOneKeyResponse>(); } }
		public GetSkillDetailResponse lastGetSkillDetailResponse { get { return _socket.GetLastResponse<GetSkillDetailResponse>(); } }
		public GetAllSkillResponse lastGetAllSkillResponse { get { return _socket.GetLastResponse<GetAllSkillResponse>(); } }
		static SkillHandler()
		{
			EventTypes.RegistPushType("area.skillPush.skillUpdatePush", typeof(SkillUpdatePush));
			EventTypes.RegistRequestType("area.skillHandler.unlockSkillRequest", typeof(UnlockSkillRequest), typeof(UnlockSkillResponse));
			EventTypes.RegistRequestType("area.skillHandler.upgradeSkillRequest", typeof(UpgradeSkillRequest), typeof(UpgradeSkillResponse));
			EventTypes.RegistRequestType("area.skillHandler.upgradeSkillOneKeyRequest", typeof(UpgradeSkillOneKeyRequest), typeof(UpgradeSkillOneKeyResponse));
			EventTypes.RegistRequestType("area.skillHandler.getSkillDetailRequest", typeof(GetSkillDetailRequest), typeof(GetSkillDetailResponse));
			EventTypes.RegistRequestType("area.skillHandler.getAllSkillRequest", typeof(GetAllSkillRequest), typeof(GetAllSkillResponse));
		}
		public SkillHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void unlockSkillRequest(int s2c_skillId,Action<PomeloException,UnlockSkillResponse> cb,object option = null)
		{
			var request = new UnlockSkillRequest();
			request.s2c_skillId= s2c_skillId;
			_socket.request<UnlockSkillResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnlockSkillResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeSkillRequest(int s2c_skillId,Action<PomeloException,UpgradeSkillResponse> cb,object option = null)
		{
			var request = new UpgradeSkillRequest();
			request.s2c_skillId= s2c_skillId;
			_socket.request<UpgradeSkillResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeSkillResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeSkillOneKeyRequest(Action<PomeloException,UpgradeSkillOneKeyResponse> cb,object option = null)
		{
			var request = new UpgradeSkillOneKeyRequest();
			_socket.request<UpgradeSkillOneKeyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeSkillOneKeyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSkillDetailRequest(int s2c_skillId,Action<PomeloException,GetSkillDetailResponse> cb,object option = null)
		{
			var request = new GetSkillDetailRequest();
			request.s2c_skillId= s2c_skillId;
			_socket.request<GetSkillDetailResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSkillDetailResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAllSkillRequest(Action<PomeloException,GetAllSkillResponse> cb,object option = null)
		{
			var request = new GetAllSkillRequest();
			_socket.request<GetAllSkillResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllSkillResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onSkillUpdatePush(Action<SkillUpdatePush> cb)
		{
			_socket.listen_once<SkillUpdatePush>(cb);
		}

	}


}