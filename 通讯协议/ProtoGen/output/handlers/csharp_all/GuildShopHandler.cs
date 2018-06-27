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
	public class GuildShopHandler
	{
		private PomeloClient _socket;

		public GetGuildShopInfoResponse lastGetGuildShopInfoResponse { get { return _socket.GetLastResponse<GetGuildShopInfoResponse>(); } }
		public ExchangeShopItemResponse lastExchangeShopItemResponse { get { return _socket.GetLastResponse<ExchangeShopItemResponse>(); } }
		static GuildShopHandler()
		{
			EventTypes.RegistPushType("area.guildShopPush.shopRefreshPush", typeof(ShopRefreshPush));
			EventTypes.RegistRequestType("area.guildShopHandler.getGuildShopInfoRequest", typeof(GetGuildShopInfoRequest), typeof(GetGuildShopInfoResponse));
			EventTypes.RegistRequestType("area.guildShopHandler.exchangeShopItemRequest", typeof(ExchangeShopItemRequest), typeof(ExchangeShopItemResponse));
		}
		public GuildShopHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getGuildShopInfoRequest(Action<PomeloException,GetGuildShopInfoResponse> cb,object option = null)
		{
			var request = new GetGuildShopInfoRequest();
			_socket.request<GetGuildShopInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetGuildShopInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void exchangeShopItemRequest(int id,Action<PomeloException,ExchangeShopItemResponse> cb,object option = null)
		{
			var request = new ExchangeShopItemRequest();
			request.id= id;
			_socket.request<ExchangeShopItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ExchangeShopItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onShopRefreshPush(Action<ShopRefreshPush> cb)
		{
			_socket.listen_once<ShopRefreshPush>(cb);
		}

	}


}