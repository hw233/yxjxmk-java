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
	public class SaleHandler
	{
		private PomeloClient _socket;

		public BuyPageResponse lastBuyPageResponse { get { return _socket.GetLastResponse<BuyPageResponse>(); } }
		public BuyItemResponse lastBuyItemResponse { get { return _socket.GetLastResponse<BuyItemResponse>(); } }
		public AutoBuyItemByCodeResponse lastAutoBuyItemByCodeResponse { get { return _socket.GetLastResponse<AutoBuyItemByCodeResponse>(); } }
		public SellItemsResponse lastSellItemsResponse { get { return _socket.GetLastResponse<SellItemsResponse>(); } }
		public RebuyItemResponse lastRebuyItemResponse { get { return _socket.GetLastResponse<RebuyItemResponse>(); } }
		static SaleHandler()
		{
			EventTypes.RegistRequestType("area.saleHandler.buyPageRequest", typeof(BuyPageRequest), typeof(BuyPageResponse));
			EventTypes.RegistRequestType("area.saleHandler.buyItemRequest", typeof(BuyItemRequest), typeof(BuyItemResponse));
			EventTypes.RegistRequestType("area.saleHandler.autoBuyItemByCodeRequest", typeof(AutoBuyItemByCodeRequest), typeof(AutoBuyItemByCodeResponse));
			EventTypes.RegistRequestType("area.saleHandler.sellItemsRequest", typeof(SellItemsRequest), typeof(SellItemsResponse));
			EventTypes.RegistRequestType("area.saleHandler.rebuyItemRequest", typeof(RebuyItemRequest), typeof(RebuyItemResponse));
		}
		public SaleHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void buyPageRequest(List<int> c2s_sellIndex,Action<PomeloException,BuyPageResponse> cb,object option = null)
		{
			var request = new BuyPageRequest();
			request.c2s_sellIndex.AddRange(c2s_sellIndex);
			_socket.request<BuyPageResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyPageResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyItemRequest(int c2s_typeId,int c2s_itemId,int c2s_num,Action<PomeloException,BuyItemResponse> cb,object option = null)
		{
			var request = new BuyItemRequest();
			request.c2s_typeId= c2s_typeId;
			request.c2s_itemId= c2s_itemId;
			request.c2s_num= c2s_num;
			_socket.request<BuyItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void autoBuyItemByCodeRequest(List<int> c2s_typeId,string c2s_itemCode,int c2s_num,Action<PomeloException,AutoBuyItemByCodeResponse> cb,object option = null)
		{
			var request = new AutoBuyItemByCodeRequest();
			request.c2s_typeId.AddRange(c2s_typeId);
			request.c2s_itemCode= c2s_itemCode;
			request.c2s_num= c2s_num;
			_socket.request<AutoBuyItemByCodeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AutoBuyItemByCodeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sellItemsRequest(List<SellGrid> c2s_sellGrids,Action<PomeloException,SellItemsResponse> cb,object option = null)
		{
			var request = new SellItemsRequest();
			request.c2s_sellGrids.AddRange(c2s_sellGrids);
			_socket.request<SellItemsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SellItemsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void rebuyItemRequest(int c2s_gridIndex,int c2s_num,Action<PomeloException,RebuyItemResponse> cb,object option = null)
		{
			var request = new RebuyItemRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			request.c2s_num= c2s_num;
			_socket.request<RebuyItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RebuyItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}