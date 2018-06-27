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
	public class TradeHandler
	{
		private PomeloClient _socket;

		public InviteResponse lastInviteResponse { get { return _socket.GetLastResponse<InviteResponse>(); } }
		public AddItemResponse lastAddItemResponse { get { return _socket.GetLastResponse<AddItemResponse>(); } }
		public RemoveItemResponse lastRemoveItemResponse { get { return _socket.GetLastResponse<RemoveItemResponse>(); } }
		public TradeOperateResponse lastTradeOperateResponse { get { return _socket.GetLastResponse<TradeOperateResponse>(); } }
		static TradeHandler()
		{
			EventTypes.RegistPushType("area.tradePush.tradeBeginPush", typeof(TradeBeginPush));
			EventTypes.RegistPushType("area.tradePush.tradeItemChangePush", typeof(TradeItemChangePush));
			EventTypes.RegistPushType("area.tradePush.tradeOperatePush", typeof(TradeOperatePush));
			EventTypes.RegistRequestType("area.tradeHandler.inviteRequest", typeof(InviteRequest), typeof(InviteResponse));
			EventTypes.RegistRequestType("area.tradeHandler.addItemRequest", typeof(AddItemRequest), typeof(AddItemResponse));
			EventTypes.RegistRequestType("area.tradeHandler.removeItemRequest", typeof(RemoveItemRequest), typeof(RemoveItemResponse));
			EventTypes.RegistRequestType("area.tradeHandler.tradeOperateRequest", typeof(TradeOperateRequest), typeof(TradeOperateResponse));
		}
		public TradeHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void inviteRequest(string c2s_playerId,Action<PomeloException,InviteResponse> cb,object option = null)
		{
			var request = new InviteRequest();
			request.c2s_playerId= c2s_playerId;
			_socket.request<InviteResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as InviteResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void addItemRequest(int c2s_diamond,List<TradeItem> c2s_items,Action<PomeloException,AddItemResponse> cb,object option = null)
		{
			var request = new AddItemRequest();
			request.c2s_diamond= c2s_diamond;
			request.c2s_items.AddRange(c2s_items);
			_socket.request<AddItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AddItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void removeItemRequest(List<int> c2s_indexs,Action<PomeloException,RemoveItemResponse> cb,object option = null)
		{
			var request = new RemoveItemRequest();
			request.c2s_indexs.AddRange(c2s_indexs);
			_socket.request<RemoveItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RemoveItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void tradeOperateRequest(int c2s_operate,int c2s_diamond,List<TradeItem> c2s_items,Action<PomeloException,TradeOperateResponse> cb,object option = null)
		{
			var request = new TradeOperateRequest();
			request.c2s_operate= c2s_operate;
			request.c2s_diamond= c2s_diamond;
			request.c2s_items.AddRange(c2s_items);
			_socket.request<TradeOperateResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TradeOperateResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onTradeBeginPush(Action<TradeBeginPush> cb)
		{
			_socket.listen_once<TradeBeginPush>(cb);
		}
		public void onTradeItemChangePush(Action<TradeItemChangePush> cb)
		{
			_socket.listen_once<TradeItemChangePush>(cb);
		}
		public void onTradeOperatePush(Action<TradeOperatePush> cb)
		{
			_socket.listen_once<TradeOperatePush>(cb);
		}

	}


}