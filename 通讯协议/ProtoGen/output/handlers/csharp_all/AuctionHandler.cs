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

namespace pomelo.auction
{
	public class AuctionHandler
	{
		private PomeloClient _socket;

		public SyncAuctionInfoResponse lastSyncAuctionInfoResponse { get { return _socket.GetLastResponse<SyncAuctionInfoResponse>(); } }
		public CancelSyncAuctionInfoResponse lastCancelSyncAuctionInfoResponse { get { return _socket.GetLastResponse<CancelSyncAuctionInfoResponse>(); } }
		public AuctionListResponse lastAuctionListResponse { get { return _socket.GetLastResponse<AuctionListResponse>(); } }
		public AuctionResponse lastAuctionResponse { get { return _socket.GetLastResponse<AuctionResponse>(); } }
		public AuctionLogResponse lastAuctionLogResponse { get { return _socket.GetLastResponse<AuctionLogResponse>(); } }
		static AuctionHandler()
		{
			EventTypes.RegistPushType("auction.auctionPush.auctionItemPush", typeof(AuctionItemPush));
			EventTypes.RegistPushType("auction.auctionPush.addAuctionItemPush", typeof(AddAuctionItemPush));
			EventTypes.RegistPushType("auction.auctionPush.removeAuctionItemPush", typeof(RemoveAuctionItemPush));
			EventTypes.RegistRequestType("auction.auctionHandler.syncAuctionInfoRequest", typeof(SyncAuctionInfoRequest), typeof(SyncAuctionInfoResponse));
			EventTypes.RegistRequestType("auction.auctionHandler.cancelSyncAuctionInfoRequest", typeof(CancelSyncAuctionInfoRequest), typeof(CancelSyncAuctionInfoResponse));
			EventTypes.RegistRequestType("auction.auctionHandler.auctionListRequest", typeof(AuctionListRequest), typeof(AuctionListResponse));
			EventTypes.RegistRequestType("auction.auctionHandler.auctionRequest", typeof(AuctionRequest), typeof(AuctionResponse));
			EventTypes.RegistRequestType("auction.auctionHandler.auctionLogRequest", typeof(AuctionLogRequest), typeof(AuctionLogResponse));
		}
		public AuctionHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void syncAuctionInfoRequest(Action<PomeloException,SyncAuctionInfoResponse> cb,object option = null)
		{
			var request = new SyncAuctionInfoRequest();
			_socket.request<SyncAuctionInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SyncAuctionInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cancelSyncAuctionInfoRequest(Action<PomeloException,CancelSyncAuctionInfoResponse> cb,object option = null)
		{
			var request = new CancelSyncAuctionInfoRequest();
			_socket.request<CancelSyncAuctionInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CancelSyncAuctionInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void auctionListRequest(int c2s_type,Action<PomeloException,AuctionListResponse> cb,object option = null)
		{
			var request = new AuctionListRequest();
			request.c2s_type= c2s_type;
			_socket.request<AuctionListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AuctionListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void auctionRequest(string itemId,int price,Action<PomeloException,AuctionResponse> cb,object option = null)
		{
			var request = new AuctionRequest();
			request.itemId= itemId;
			request.price= price;
			_socket.request<AuctionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AuctionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void auctionLogRequest(Action<PomeloException,AuctionLogResponse> cb,object option = null)
		{
			var request = new AuctionLogRequest();
			_socket.request<AuctionLogResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AuctionLogResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onAuctionItemPush(Action<AuctionItemPush> cb)
		{
			_socket.listen_once<AuctionItemPush>(cb);
		}
		public void onAddAuctionItemPush(Action<AddAuctionItemPush> cb)
		{
			_socket.listen_once<AddAuctionItemPush>(cb);
		}
		public void onRemoveAuctionItemPush(Action<RemoveAuctionItemPush> cb)
		{
			_socket.listen_once<RemoveAuctionItemPush>(cb);
		}

	}


}