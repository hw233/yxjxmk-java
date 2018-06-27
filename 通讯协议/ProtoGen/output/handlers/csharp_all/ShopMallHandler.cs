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
	public class ShopMallHandler
	{
		private PomeloClient _socket;

		public GetMallTabsResponse lastGetMallTabsResponse { get { return _socket.GetLastResponse<GetMallTabsResponse>(); } }
		public GetMallScoreItemListResponse lastGetMallScoreItemListResponse { get { return _socket.GetLastResponse<GetMallScoreItemListResponse>(); } }
		public BuyMallItemResponse lastBuyMallItemResponse { get { return _socket.GetLastResponse<BuyMallItemResponse>(); } }
		public GetMallItemListResponse lastGetMallItemListResponse { get { return _socket.GetLastResponse<GetMallItemListResponse>(); } }
		public BuyMallScoreItemResponse lastBuyMallScoreItemResponse { get { return _socket.GetLastResponse<BuyMallScoreItemResponse>(); } }
		static ShopMallHandler()
		{
			EventTypes.RegistRequestType("area.shopMallHandler.getMallTabsRequest", typeof(GetMallTabsRequest), typeof(GetMallTabsResponse));
			EventTypes.RegistRequestType("area.shopMallHandler.getMallScoreItemListRequest", typeof(GetMallScoreItemListRequest), typeof(GetMallScoreItemListResponse));
			EventTypes.RegistRequestType("area.shopMallHandler.buyMallItemRequest", typeof(BuyMallItemRequest), typeof(BuyMallItemResponse));
			EventTypes.RegistRequestType("area.shopMallHandler.getMallItemListRequest", typeof(GetMallItemListRequest), typeof(GetMallItemListResponse));
			EventTypes.RegistRequestType("area.shopMallHandler.buyMallScoreItemRequest", typeof(BuyMallScoreItemRequest), typeof(BuyMallScoreItemResponse));
		}
		public ShopMallHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getMallTabsRequest(Action<PomeloException,GetMallTabsResponse> cb,object option = null)
		{
			var request = new GetMallTabsRequest();
			_socket.request<GetMallTabsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMallTabsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMallScoreItemListRequest(Action<PomeloException,GetMallScoreItemListResponse> cb,object option = null)
		{
			var request = new GetMallScoreItemListRequest();
			_socket.request<GetMallScoreItemListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMallScoreItemListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyMallItemRequest(string c2s_itemId,int c2s_count,string c2s_playerId,int c2s_bDiamond,Action<PomeloException,BuyMallItemResponse> cb,object option = null)
		{
			var request = new BuyMallItemRequest();
			request.c2s_itemId= c2s_itemId;
			request.c2s_count= c2s_count;
			request.c2s_playerId= c2s_playerId;
			request.c2s_bDiamond= c2s_bDiamond;
			_socket.request<BuyMallItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyMallItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMallItemListRequest(int c2s_moneyType,int c2s_itemType,Action<PomeloException,GetMallItemListResponse> cb,object option = null)
		{
			var request = new GetMallItemListRequest();
			request.c2s_moneyType= c2s_moneyType;
			request.c2s_itemType= c2s_itemType;
			_socket.request<GetMallItemListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMallItemListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyMallScoreItemRequest(string c2s_itemId,Action<PomeloException,BuyMallScoreItemResponse> cb,object option = null)
		{
			var request = new BuyMallScoreItemRequest();
			request.c2s_itemId= c2s_itemId;
			_socket.request<BuyMallScoreItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyMallScoreItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}