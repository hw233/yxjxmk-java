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
	public class ItemHandler
	{
		private PomeloClient _socket;

		public GetAllEquipDetailsResponse lastGetAllEquipDetailsResponse { get { return _socket.GetLastResponse<GetAllEquipDetailsResponse>(); } }
		public GetCombineFormulaResponse lastGetCombineFormulaResponse { get { return _socket.GetLastResponse<GetCombineFormulaResponse>(); } }
		public CombineResponse lastCombineResponse { get { return _socket.GetLastResponse<CombineResponse>(); } }
		static ItemHandler()
		{
			EventTypes.RegistPushType("area.itemPush.fishItemPush", typeof(FishItemPush));
			EventTypes.RegistPushType("area.itemPush.countItemChangePush", typeof(CountItemChangePush));
			EventTypes.RegistPushType("area.itemPush.itemDetailPush", typeof(ItemDetailPush));
			EventTypes.RegistPushType("area.itemPush.rewardItemPush", typeof(RewardItemPush));
			EventTypes.RegistRequestType("area.itemHandler.getAllEquipDetailsRequest", typeof(GetAllEquipDetailsRequest), typeof(GetAllEquipDetailsResponse));
			EventTypes.RegistRequestType("area.itemHandler.getCombineFormulaRequest", typeof(GetCombineFormulaRequest), typeof(GetCombineFormulaResponse));
			EventTypes.RegistRequestType("area.itemHandler.combineRequest", typeof(CombineRequest), typeof(CombineResponse));
			EventTypes.RegistNotifyType("area.itemHandler.queryItemStatusUpdateNotify", typeof(QueryItemStatusUpdateNotify));
		}
		public ItemHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getAllEquipDetailsRequest(Action<PomeloException,GetAllEquipDetailsResponse> cb,object option = null)
		{
			var request = new GetAllEquipDetailsRequest();
			_socket.request<GetAllEquipDetailsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllEquipDetailsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getCombineFormulaRequest(int c2s_destID,Action<PomeloException,GetCombineFormulaResponse> cb,object option = null)
		{
			var request = new GetCombineFormulaRequest();
			request.c2s_destID= c2s_destID;
			_socket.request<GetCombineFormulaResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetCombineFormulaResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void combineRequest(int c2s_destID,int c2s_num,int c2s_gridIndex,Action<PomeloException,CombineResponse> cb,object option = null)
		{
			var request = new CombineRequest();
			request.c2s_destID= c2s_destID;
			request.c2s_num= c2s_num;
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<CombineResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CombineResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryItemStatusUpdateNotify(int index)
		{
			var notify = new QueryItemStatusUpdateNotify();
			notify.index= index;

			_socket.notify(notify);

		}
		public void onFishItemPush(Action<FishItemPush> cb)
		{
			_socket.listen_once<FishItemPush>(cb);
		}
		public void onCountItemChangePush(Action<CountItemChangePush> cb)
		{
			_socket.listen_once<CountItemChangePush>(cb);
		}
		public void onItemDetailPush(Action<ItemDetailPush> cb)
		{
			_socket.listen_once<ItemDetailPush>(cb);
		}
		public void onRewardItemPush(Action<RewardItemPush> cb)
		{
			_socket.listen_once<RewardItemPush>(cb);
		}

	}


}