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
	public class GuildDepotHandler
	{
		private PomeloClient _socket;

		public DepositItemResponse lastDepositItemResponse { get { return _socket.GetLastResponse<DepositItemResponse>(); } }
		public TakeOutItemResponse lastTakeOutItemResponse { get { return _socket.GetLastResponse<TakeOutItemResponse>(); } }
		public SetConditionResponse lastSetConditionResponse { get { return _socket.GetLastResponse<SetConditionResponse>(); } }
		public DeleteItemResponse lastDeleteItemResponse { get { return _socket.GetLastResponse<DeleteItemResponse>(); } }
		public UpgradeDepotResponse lastUpgradeDepotResponse { get { return _socket.GetLastResponse<UpgradeDepotResponse>(); } }
		static GuildDepotHandler()
		{
			EventTypes.RegistPushType("area.guildDepotPush.depotRefreshPush", typeof(DepotRefreshPush));
			EventTypes.RegistRequestType("area.guildDepotHandler.depositItemRequest", typeof(DepositItemRequest), typeof(DepositItemResponse));
			EventTypes.RegistRequestType("area.guildDepotHandler.takeOutItemRequest", typeof(TakeOutItemRequest), typeof(TakeOutItemResponse));
			EventTypes.RegistRequestType("area.guildDepotHandler.setConditionRequest", typeof(SetConditionRequest), typeof(SetConditionResponse));
			EventTypes.RegistRequestType("area.guildDepotHandler.deleteItemRequest", typeof(DeleteItemRequest), typeof(DeleteItemResponse));
			EventTypes.RegistRequestType("area.guildDepotHandler.upgradeDepotRequest", typeof(UpgradeDepotRequest), typeof(UpgradeDepotResponse));
		}
		public GuildDepotHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void depositItemRequest(int c2s_fromIndex,Action<PomeloException,DepositItemResponse> cb,object option = null)
		{
			var request = new DepositItemRequest();
			request.c2s_fromIndex= c2s_fromIndex;
			_socket.request<DepositItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DepositItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void takeOutItemRequest(int c2s_fromIndex,Action<PomeloException,TakeOutItemResponse> cb,object option = null)
		{
			var request = new TakeOutItemRequest();
			request.c2s_fromIndex= c2s_fromIndex;
			_socket.request<TakeOutItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TakeOutItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void setConditionRequest(int useLevel,int useUpLevel,int useJob,int minLevel,int minUpLevel,int minqColor,int maxLevel,int maxUpLevel,int maxqColor,Action<PomeloException,SetConditionResponse> cb,object option = null)
		{
			var request = new SetConditionRequest();
			request.useLevel= useLevel;
			request.useUpLevel= useUpLevel;
			request.useJob= useJob;
			request.minLevel= minLevel;
			request.minUpLevel= minUpLevel;
			request.minqColor= minqColor;
			request.maxLevel= maxLevel;
			request.maxUpLevel= maxUpLevel;
			request.maxqColor= maxqColor;
			_socket.request<SetConditionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SetConditionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void deleteItemRequest(int c2s_fromIndex,Action<PomeloException,DeleteItemResponse> cb,object option = null)
		{
			var request = new DeleteItemRequest();
			request.c2s_fromIndex= c2s_fromIndex;
			_socket.request<DeleteItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DeleteItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeDepotRequest(Action<PomeloException,UpgradeDepotResponse> cb,object option = null)
		{
			var request = new UpgradeDepotRequest();
			_socket.request<UpgradeDepotResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeDepotResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onDepotRefreshPush(Action<DepotRefreshPush> cb)
		{
			_socket.listen_once<DepotRefreshPush>(cb);
		}

	}


}