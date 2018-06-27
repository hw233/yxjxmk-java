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
	public class IntergalMallHandler
	{
		private PomeloClient _socket;

		public GetIntergalMallListResponse lastGetIntergalMallListResponse { get { return _socket.GetLastResponse<GetIntergalMallListResponse>(); } }
		public BuyIntergalItemResponse lastBuyIntergalItemResponse { get { return _socket.GetLastResponse<BuyIntergalItemResponse>(); } }
		static IntergalMallHandler()
		{
			EventTypes.RegistRequestType("area.intergalMallHandler.getMallScoreItemListRequest", typeof(GetIntergalMallListRequest), typeof(GetIntergalMallListResponse));
			EventTypes.RegistRequestType("area.intergalMallHandler.buyIntergalItemRequest", typeof(BuyIntergalItemRequest), typeof(BuyIntergalItemResponse));
		}
		public IntergalMallHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getMallScoreItemListRequest(int c2s_type,Action<PomeloException,GetIntergalMallListResponse> cb,object option = null)
		{
			var request = new GetIntergalMallListRequest();
			request.c2s_type= c2s_type;
			_socket.request<GetIntergalMallListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetIntergalMallListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyIntergalItemRequest(int c2s_type,int c2s_itemId,int c2s_num,Action<PomeloException,BuyIntergalItemResponse> cb,object option = null)
		{
			var request = new BuyIntergalItemRequest();
			request.c2s_type= c2s_type;
			request.c2s_itemId= c2s_itemId;
			request.c2s_num= c2s_num;
			_socket.request<BuyIntergalItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyIntergalItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}