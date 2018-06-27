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
	public class GuildTechHandler
	{
		private PomeloClient _socket;

		public GetGuildTechInfoResponse lastGetGuildTechInfoResponse { get { return _socket.GetLastResponse<GetGuildTechInfoResponse>(); } }
		public UpgradeGuildTechResponse lastUpgradeGuildTechResponse { get { return _socket.GetLastResponse<UpgradeGuildTechResponse>(); } }
		public UpgradeGuildBuffResponse lastUpgradeGuildBuffResponse { get { return _socket.GetLastResponse<UpgradeGuildBuffResponse>(); } }
		public UpgradeGuildSkillResponse lastUpgradeGuildSkillResponse { get { return _socket.GetLastResponse<UpgradeGuildSkillResponse>(); } }
		public BuyGuildProductResponse lastBuyGuildProductResponse { get { return _socket.GetLastResponse<BuyGuildProductResponse>(); } }
		static GuildTechHandler()
		{
			EventTypes.RegistPushType("area.guildTechPush.guildTechRefreshPush", typeof(GuildTechRefreshPush));
			EventTypes.RegistRequestType("area.guildTechHandler.getGuildTechInfoRequest", typeof(GetGuildTechInfoRequest), typeof(GetGuildTechInfoResponse));
			EventTypes.RegistRequestType("area.guildTechHandler.upgradeGuildTechRequest", typeof(UpgradeGuildTechRequest), typeof(UpgradeGuildTechResponse));
			EventTypes.RegistRequestType("area.guildTechHandler.upgradeGuildBuffRequest", typeof(UpgradeGuildBuffRequest), typeof(UpgradeGuildBuffResponse));
			EventTypes.RegistRequestType("area.guildTechHandler.upgradeGuildSkillRequest", typeof(UpgradeGuildSkillRequest), typeof(UpgradeGuildSkillResponse));
			EventTypes.RegistRequestType("area.guildTechHandler.buyGuildProductRequest", typeof(BuyGuildProductRequest), typeof(BuyGuildProductResponse));
		}
		public GuildTechHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getGuildTechInfoRequest(Action<PomeloException,GetGuildTechInfoResponse> cb,object option = null)
		{
			var request = new GetGuildTechInfoRequest();
			_socket.request<GetGuildTechInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildTechInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeGuildTechRequest(Action<PomeloException,UpgradeGuildTechResponse> cb,object option = null)
		{
			var request = new UpgradeGuildTechRequest();
			_socket.request<UpgradeGuildTechResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeGuildTechResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeGuildBuffRequest(Action<PomeloException,UpgradeGuildBuffResponse> cb,object option = null)
		{
			var request = new UpgradeGuildBuffRequest();
			_socket.request<UpgradeGuildBuffResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeGuildBuffResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeGuildSkillRequest(int skillId,Action<PomeloException,UpgradeGuildSkillResponse> cb,object option = null)
		{
			var request = new UpgradeGuildSkillRequest();
			request.skillId= skillId;
			_socket.request<UpgradeGuildSkillResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeGuildSkillResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyGuildProductRequest(int productId,Action<PomeloException,BuyGuildProductResponse> cb,object option = null)
		{
			var request = new BuyGuildProductRequest();
			request.productId= productId;
			_socket.request<BuyGuildProductResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyGuildProductResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onGuildTechRefreshPush(Action<GuildTechRefreshPush> cb)
		{
			_socket.listen_once<GuildTechRefreshPush>(cb);
		}

	}


}