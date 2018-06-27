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
	public class VipHandler
	{
		private PomeloClient _socket;

		public VipResponse lastVipResponse { get { return _socket.GetLastResponse<VipResponse>(); } }
		public GetEveryDayGiftResponse lastGetEveryDayGiftResponse { get { return _socket.GetLastResponse<GetEveryDayGiftResponse>(); } }
		public BuyEveryDayGiftResponse lastBuyEveryDayGiftResponse { get { return _socket.GetLastResponse<BuyEveryDayGiftResponse>(); } }
		public BuyVipCardResponse lastBuyVipCardResponse { get { return _socket.GetLastResponse<BuyVipCardResponse>(); } }
		static VipHandler()
		{
			EventTypes.RegistRequestType("area.vipHandler.vipInfoRequest", typeof(VipRequest), typeof(VipResponse));
			EventTypes.RegistRequestType("area.vipHandler.getEveryDayGiftRequest", typeof(GetEveryDayGiftRequest), typeof(GetEveryDayGiftResponse));
			EventTypes.RegistRequestType("area.vipHandler.buyEveryDayGiftRequest", typeof(BuyEveryDayGiftRequest), typeof(BuyEveryDayGiftResponse));
			EventTypes.RegistRequestType("area.vipHandler.buyVipCardRequest", typeof(BuyVipCardRequest), typeof(BuyVipCardResponse));
		}
		public VipHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void vipInfoRequest(Action<PomeloException,VipResponse> cb,object option = null)
		{
			var request = new VipRequest();
			_socket.request<VipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as VipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getEveryDayGiftRequest(int c2s_type,Action<PomeloException,GetEveryDayGiftResponse> cb,object option = null)
		{
			var request = new GetEveryDayGiftRequest();
			request.c2s_type= c2s_type;
			_socket.request<GetEveryDayGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetEveryDayGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyEveryDayGiftRequest(int c2s_vipLevel,Action<PomeloException,BuyEveryDayGiftResponse> cb,object option = null)
		{
			var request = new BuyEveryDayGiftRequest();
			request.c2s_vipLevel= c2s_vipLevel;
			_socket.request<BuyEveryDayGiftResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyEveryDayGiftResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyVipCardRequest(int c2s_typeId,int c2s_itemId,int c2s_type,Action<PomeloException,BuyVipCardResponse> cb,object option = null)
		{
			var request = new BuyVipCardRequest();
			request.c2s_typeId= c2s_typeId;
			request.c2s_itemId= c2s_itemId;
			request.c2s_type= c2s_type;
			_socket.request<BuyVipCardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyVipCardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}