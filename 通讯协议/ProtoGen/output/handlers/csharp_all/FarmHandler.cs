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

namespace pomelo.farm
{
	public class FarmHandler
	{
		private PomeloClient _socket;

		public MyFarmInfoResponse lastMyFarmInfoResponse { get { return _socket.GetLastResponse<MyFarmInfoResponse>(); } }
		public FriendFarmInfoResponse lastFriendFarmInfoResponse { get { return _socket.GetLastResponse<FriendFarmInfoResponse>(); } }
		public FriendLsResponse lastFriendLsResponse { get { return _socket.GetLastResponse<FriendLsResponse>(); } }
		public OpenResponse lastOpenResponse { get { return _socket.GetLastResponse<OpenResponse>(); } }
		public SowResponse lastSowResponse { get { return _socket.GetLastResponse<SowResponse>(); } }
		public CultivateFriendResponse lastCultivateFriendResponse { get { return _socket.GetLastResponse<CultivateFriendResponse>(); } }
		public CultivateSelfResponse lastCultivateSelfResponse { get { return _socket.GetLastResponse<CultivateSelfResponse>(); } }
		public StealResponse lastStealResponse { get { return _socket.GetLastResponse<StealResponse>(); } }
		public HarvestResponse lastHarvestResponse { get { return _socket.GetLastResponse<HarvestResponse>(); } }
		public GetShopInfoResponse lastGetShopInfoResponse { get { return _socket.GetLastResponse<GetShopInfoResponse>(); } }
		public ChangeShopItemResponse lastChangeShopItemResponse { get { return _socket.GetLastResponse<ChangeShopItemResponse>(); } }
		static FarmHandler()
		{
			EventTypes.RegistRequestType("farm.farmHandler.myFarmInfoRequest", typeof(MyFarmInfoRequest), typeof(MyFarmInfoResponse));
			EventTypes.RegistRequestType("farm.farmHandler.friendFarmInfoRequest", typeof(FriendFarmInfoRequest), typeof(FriendFarmInfoResponse));
			EventTypes.RegistRequestType("farm.farmHandler.friendLsRequest", typeof(FriendLsRequest), typeof(FriendLsResponse));
			EventTypes.RegistRequestType("farm.farmHandler.openRequest", typeof(OpenRequest), typeof(OpenResponse));
			EventTypes.RegistRequestType("farm.farmHandler.sowRequest", typeof(SowRequest), typeof(SowResponse));
			EventTypes.RegistRequestType("farm.farmHandler.cultivateFriendRequest", typeof(CultivateFriendRequest), typeof(CultivateFriendResponse));
			EventTypes.RegistRequestType("farm.farmHandler.cultivateSelfRequest", typeof(CultivateSelfRequest), typeof(CultivateSelfResponse));
			EventTypes.RegistRequestType("farm.farmHandler.stealRequest", typeof(StealRequest), typeof(StealResponse));
			EventTypes.RegistRequestType("farm.farmHandler.harvestRequest", typeof(HarvestRequest), typeof(HarvestResponse));
			EventTypes.RegistRequestType("farm.farmHandler.getShopInfoRequest", typeof(GetShopInfoRequest), typeof(GetShopInfoResponse));
			EventTypes.RegistRequestType("farm.farmHandler.changeShopItemRequest", typeof(ChangeShopItemRequest), typeof(ChangeShopItemResponse));
		}
		public FarmHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void myFarmInfoRequest(Action<PomeloException,MyFarmInfoResponse> cb,object option = null)
		{
			var request = new MyFarmInfoRequest();
			_socket.request<MyFarmInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MyFarmInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendFarmInfoRequest(string playerId,Action<PomeloException,FriendFarmInfoResponse> cb,object option = null)
		{
			var request = new FriendFarmInfoRequest();
			request.playerId= playerId;
			_socket.request<FriendFarmInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendFarmInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendLsRequest(Action<PomeloException,FriendLsResponse> cb,object option = null)
		{
			var request = new FriendLsRequest();
			_socket.request<FriendLsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendLsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openRequest(int blockId,Action<PomeloException,OpenResponse> cb,object option = null)
		{
			var request = new OpenRequest();
			request.blockId= blockId;
			_socket.request<OpenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void sowRequest(int blockId,string seedCode,Action<PomeloException,SowResponse> cb,object option = null)
		{
			var request = new SowRequest();
			request.blockId= blockId;
			request.seedCode= seedCode;
			_socket.request<SowResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SowResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cultivateFriendRequest(int blockId,int cultivateType,string friendId,Action<PomeloException,CultivateFriendResponse> cb,object option = null)
		{
			var request = new CultivateFriendRequest();
			request.blockId= blockId;
			request.cultivateType= cultivateType;
			request.friendId= friendId;
			_socket.request<CultivateFriendResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CultivateFriendResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cultivateSelfRequest(int blockId,int cultivateType,Action<PomeloException,CultivateSelfResponse> cb,object option = null)
		{
			var request = new CultivateSelfRequest();
			request.blockId= blockId;
			request.cultivateType= cultivateType;
			_socket.request<CultivateSelfResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CultivateSelfResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void stealRequest(int blockId,string friendId,Action<PomeloException,StealResponse> cb,object option = null)
		{
			var request = new StealRequest();
			request.blockId= blockId;
			request.friendId= friendId;
			_socket.request<StealResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as StealResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void harvestRequest(int blockId,Action<PomeloException,HarvestResponse> cb,object option = null)
		{
			var request = new HarvestRequest();
			request.blockId= blockId;
			_socket.request<HarvestResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as HarvestResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getShopInfoRequest(Action<PomeloException,GetShopInfoResponse> cb,object option = null)
		{
			var request = new GetShopInfoRequest();
			_socket.request<GetShopInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetShopInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changeShopItemRequest(int itemId,Action<PomeloException,ChangeShopItemResponse> cb,object option = null)
		{
			var request = new ChangeShopItemRequest();
			request.itemId= itemId;
			_socket.request<ChangeShopItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangeShopItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}