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
	public class BagHandler
	{
		private PomeloClient _socket;

		public PackUpBagResponse lastPackUpBagResponse { get { return _socket.GetLastResponse<PackUpBagResponse>(); } }
		public OpenBagGridResponse lastOpenBagGridResponse { get { return _socket.GetLastResponse<OpenBagGridResponse>(); } }
		public TransferItemResponse lastTransferItemResponse { get { return _socket.GetLastResponse<TransferItemResponse>(); } }
		public SellItemResponse lastSellItemResponse { get { return _socket.GetLastResponse<SellItemResponse>(); } }
		public UseItemResponse lastUseItemResponse { get { return _socket.GetLastResponse<UseItemResponse>(); } }
		static BagHandler()
		{
			EventTypes.RegistPushType("area.bagPush.bagItemUpdatePush", typeof(BagItemUpdatePush));
			EventTypes.RegistPushType("area.bagPush.bagNewItemPush", typeof(BagNewItemPush));
			EventTypes.RegistPushType("area.bagPush.bagNewEquipPush", typeof(BagNewEquipPush));
			EventTypes.RegistPushType("area.bagPush.bagGridFullPush", typeof(BagGridFullPush));
			EventTypes.RegistPushType("area.bagPush.bagGridNumPush", typeof(BagGridNumPush));
			EventTypes.RegistRequestType("area.bagHandler.packUpBagRequest", typeof(PackUpBagRequest), typeof(PackUpBagResponse));
			EventTypes.RegistRequestType("area.bagHandler.openBagGridRequest", typeof(OpenBagGridRequest), typeof(OpenBagGridResponse));
			EventTypes.RegistRequestType("area.bagHandler.transferItemRequest", typeof(TransferItemRequest), typeof(TransferItemResponse));
			EventTypes.RegistRequestType("area.bagHandler.sellItemRequest", typeof(SellItemRequest), typeof(SellItemResponse));
			EventTypes.RegistRequestType("area.bagHandler.useItemRequest", typeof(UseItemRequest), typeof(UseItemResponse));
			EventTypes.RegistNotifyType("area.bagHandler.addBagItemTestNotify", typeof(AddBagItemTestNotify));
		}
		public BagHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void packUpBagRequest(int c2s_type,Action<PomeloException,PackUpBagResponse> cb,object option = null)
		{
			var request = new PackUpBagRequest();
			request.c2s_type= c2s_type;
			_socket.request<PackUpBagResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PackUpBagResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openBagGridRequest(int c2s_type,int c2s_number,Action<PomeloException,OpenBagGridResponse> cb,object option = null)
		{
			var request = new OpenBagGridRequest();
			request.c2s_type= c2s_type;
			request.c2s_number= c2s_number;
			_socket.request<OpenBagGridResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenBagGridResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void transferItemRequest(int c2s_fromType,int c2s_fromIndex,int c2s_toType,int c2s_num,Action<PomeloException,TransferItemResponse> cb,object option = null)
		{
			var request = new TransferItemRequest();
			request.c2s_fromType= c2s_fromType;
			request.c2s_fromIndex= c2s_fromIndex;
			request.c2s_toType= c2s_toType;
			request.c2s_num= c2s_num;
			_socket.request<TransferItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TransferItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sellItemRequest(int c2s_gridIndex,int c2s_num,Action<PomeloException,SellItemResponse> cb,object option = null)
		{
			var request = new SellItemRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			request.c2s_num= c2s_num;
			_socket.request<SellItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SellItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void useItemRequest(int c2s_gridIndex,int c2s_num,Action<PomeloException,UseItemResponse> cb,object option = null)
		{
			var request = new UseItemRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			request.c2s_num= c2s_num;
			_socket.request<UseItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UseItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void addBagItemTestNotify()
		{
			var notify = new AddBagItemTestNotify();

			_socket.notify(notify);

		}
		public void onBagItemUpdatePush(Action<BagItemUpdatePush> cb)
		{
			_socket.listen_once<BagItemUpdatePush>(cb);
		}
		public void onBagNewItemPush(Action<BagNewItemPush> cb)
		{
			_socket.listen_once<BagNewItemPush>(cb);
		}
		public void onBagNewEquipPush(Action<BagNewEquipPush> cb)
		{
			_socket.listen_once<BagNewEquipPush>(cb);
		}
		public void onBagGridFullPush(Action<BagGridFullPush> cb)
		{
			_socket.listen_once<BagGridFullPush>(cb);
		}
		public void onBagGridNumPush(Action<BagGridNumPush> cb)
		{
			_socket.listen_once<BagGridNumPush>(cb);
		}

	}


}