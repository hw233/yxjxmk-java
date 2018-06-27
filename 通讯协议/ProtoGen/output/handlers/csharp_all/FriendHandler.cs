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
	public class FriendHandler
	{
		private PomeloClient _socket;

		public FriendGetAllFriendsResponse lastFriendGetAllFriendsResponse { get { return _socket.GetLastResponse<FriendGetAllFriendsResponse>(); } }
		public FriendApplyResponse lastFriendApplyResponse { get { return _socket.GetLastResponse<FriendApplyResponse>(); } }
		public FriendAllApplyResponse lastFriendAllApplyResponse { get { return _socket.GetLastResponse<FriendAllApplyResponse>(); } }
		public FriendAgreeApplyResponse lastFriendAgreeApplyResponse { get { return _socket.GetLastResponse<FriendAgreeApplyResponse>(); } }
		public FriendAllAgreeApplyResponse lastFriendAllAgreeApplyResponse { get { return _socket.GetLastResponse<FriendAllAgreeApplyResponse>(); } }
		public FriendRefuceApplyResponse lastFriendRefuceApplyResponse { get { return _socket.GetLastResponse<FriendRefuceApplyResponse>(); } }
		public FriendAllRefuceApplyResponse lastFriendAllRefuceApplyResponse { get { return _socket.GetLastResponse<FriendAllRefuceApplyResponse>(); } }
		public FriendDeleteResponse lastFriendDeleteResponse { get { return _socket.GetLastResponse<FriendDeleteResponse>(); } }
		public FriendDeleteChouRenResponse lastFriendDeleteChouRenResponse { get { return _socket.GetLastResponse<FriendDeleteChouRenResponse>(); } }
		public FriendAllDeleteChouRenResponse lastFriendAllDeleteChouRenResponse { get { return _socket.GetLastResponse<FriendAllDeleteChouRenResponse>(); } }
		public FriendAddChouRenResponse lastFriendAddChouRenResponse { get { return _socket.GetLastResponse<FriendAddChouRenResponse>(); } }
		public AddFriendInfoResponse lastAddFriendInfoResponse { get { return _socket.GetLastResponse<AddFriendInfoResponse>(); } }
		public QueryPlayerNameResponse lastQueryPlayerNameResponse { get { return _socket.GetLastResponse<QueryPlayerNameResponse>(); } }
		public ConcernFriendResponse lastConcernFriendResponse { get { return _socket.GetLastResponse<ConcernFriendResponse>(); } }
		public ConcernAllFriendResponse lastConcernAllFriendResponse { get { return _socket.GetLastResponse<ConcernAllFriendResponse>(); } }
		public FriendMessageListResponse lastFriendMessageListResponse { get { return _socket.GetLastResponse<FriendMessageListResponse>(); } }
		public DeleteAllFriendMessageResponse lastDeleteAllFriendMessageResponse { get { return _socket.GetLastResponse<DeleteAllFriendMessageResponse>(); } }
		public DeleteBlackListResponse lastDeleteBlackListResponse { get { return _socket.GetLastResponse<DeleteBlackListResponse>(); } }
		public DeleteAllBlackListResponse lastDeleteAllBlackListResponse { get { return _socket.GetLastResponse<DeleteAllBlackListResponse>(); } }
		public AddBlackListResponse lastAddBlackListResponse { get { return _socket.GetLastResponse<AddBlackListResponse>(); } }
		public GetSocialInfoResponse lastGetSocialInfoResponse { get { return _socket.GetLastResponse<GetSocialInfoResponse>(); } }
		public GetShopItemListResponse lastGetShopItemListResponse { get { return _socket.GetLastResponse<GetShopItemListResponse>(); } }
		public ExchangeFriendShopItemResponse lastExchangeFriendShopItemResponse { get { return _socket.GetLastResponse<ExchangeFriendShopItemResponse>(); } }
		public GetRecentChatListResponse lastGetRecentChatListResponse { get { return _socket.GetLastResponse<GetRecentChatListResponse>(); } }
		public GetChatMsgResponse lastGetChatMsgResponse { get { return _socket.GetLastResponse<GetChatMsgResponse>(); } }
		public RmChatMsgResponse lastRmChatMsgResponse { get { return _socket.GetLastResponse<RmChatMsgResponse>(); } }
		static FriendHandler()
		{
			EventTypes.RegistRequestType("area.friendHandler.friendGetAllFriendsRequest", typeof(FriendGetAllFriendsRequest), typeof(FriendGetAllFriendsResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendApplyRequest", typeof(FriendApplyRequest), typeof(FriendApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAllApplyRequest", typeof(FriendAllApplyRequest), typeof(FriendAllApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAgreeApplyRequest", typeof(FriendAgreeApplyRequest), typeof(FriendAgreeApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAllAgreeApplyRequest", typeof(FriendAllAgreeApplyRequest), typeof(FriendAllAgreeApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendRefuceApplyRequest", typeof(FriendRefuceApplyRequest), typeof(FriendRefuceApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAllRefuceApplyRequest", typeof(FriendAllRefuceApplyRequest), typeof(FriendAllRefuceApplyResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendDeleteRequest", typeof(FriendDeleteRequest), typeof(FriendDeleteResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendDeleteChouRenRequest", typeof(FriendDeleteChouRenRequest), typeof(FriendDeleteChouRenResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAllDeleteChouRenRequest", typeof(FriendAllDeleteChouRenRequest), typeof(FriendAllDeleteChouRenResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendAddChouRenRequest", typeof(FriendAddChouRenRequest), typeof(FriendAddChouRenResponse));
			EventTypes.RegistRequestType("area.friendHandler.addFriendInfoRequest", typeof(AddFriendInfoRequest), typeof(AddFriendInfoResponse));
			EventTypes.RegistRequestType("area.friendHandler.queryPlayerNameRequest", typeof(QueryPlayerNameRequest), typeof(QueryPlayerNameResponse));
			EventTypes.RegistRequestType("area.friendHandler.concernFriendRequest", typeof(ConcernFriendRequest), typeof(ConcernFriendResponse));
			EventTypes.RegistRequestType("area.friendHandler.concernAllFriendRequest", typeof(ConcernAllFriendRequest), typeof(ConcernAllFriendResponse));
			EventTypes.RegistRequestType("area.friendHandler.friendMessageListRequest", typeof(FriendMessageListRequest), typeof(FriendMessageListResponse));
			EventTypes.RegistRequestType("area.friendHandler.deleteAllFriendMessageRequest", typeof(DeleteAllFriendMessageRequest), typeof(DeleteAllFriendMessageResponse));
			EventTypes.RegistRequestType("area.friendHandler.deleteBlackListRequest", typeof(DeleteBlackListRequest), typeof(DeleteBlackListResponse));
			EventTypes.RegistRequestType("area.friendHandler.deleteAllBlackListRequest", typeof(DeleteAllBlackListRequest), typeof(DeleteAllBlackListResponse));
			EventTypes.RegistRequestType("area.friendHandler.addBlackListRequest", typeof(AddBlackListRequest), typeof(AddBlackListResponse));
			EventTypes.RegistRequestType("area.friendHandler.getSocialInfoRequest", typeof(GetSocialInfoRequest), typeof(GetSocialInfoResponse));
			EventTypes.RegistRequestType("area.friendHandler.getShopItemListRequest", typeof(GetShopItemListRequest), typeof(GetShopItemListResponse));
			EventTypes.RegistRequestType("area.friendHandler.exchangeFriendShopItemRequest", typeof(ExchangeFriendShopItemRequest), typeof(ExchangeFriendShopItemResponse));
			EventTypes.RegistRequestType("area.friendHandler.getRecentChatListRequest", typeof(GetRecentChatListRequest), typeof(GetRecentChatListResponse));
			EventTypes.RegistRequestType("area.friendHandler.getChatMsgRequest", typeof(GetChatMsgRequest), typeof(GetChatMsgResponse));
			EventTypes.RegistRequestType("area.friendHandler.rmChatMsgRequest", typeof(RmChatMsgRequest), typeof(RmChatMsgResponse));
		}
		public FriendHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void friendGetAllFriendsRequest(Action<PomeloException,FriendGetAllFriendsResponse> cb,object option = null)
		{
			var request = new FriendGetAllFriendsRequest();
			_socket.request<FriendGetAllFriendsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendGetAllFriendsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendApplyRequest(string c2s_toPlayerId,Action<PomeloException,FriendApplyResponse> cb,object option = null)
		{
			var request = new FriendApplyRequest();
			request.c2s_toPlayerId= c2s_toPlayerId;
			_socket.request<FriendApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAllApplyRequest(List<string> c2s_toPlayerIds,Action<PomeloException,FriendAllApplyResponse> cb,object option = null)
		{
			var request = new FriendAllApplyRequest();
			request.c2s_toPlayerIds.AddRange(c2s_toPlayerIds);
			_socket.request<FriendAllApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAllApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAgreeApplyRequest(string c2s_requestId,Action<PomeloException,FriendAgreeApplyResponse> cb,object option = null)
		{
			var request = new FriendAgreeApplyRequest();
			request.c2s_requestId= c2s_requestId;
			_socket.request<FriendAgreeApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAgreeApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAllAgreeApplyRequest(List<string> c2s_requestIds,Action<PomeloException,FriendAllAgreeApplyResponse> cb,object option = null)
		{
			var request = new FriendAllAgreeApplyRequest();
			request.c2s_requestIds.AddRange(c2s_requestIds);
			_socket.request<FriendAllAgreeApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAllAgreeApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendRefuceApplyRequest(string c2s_requestId,Action<PomeloException,FriendRefuceApplyResponse> cb,object option = null)
		{
			var request = new FriendRefuceApplyRequest();
			request.c2s_requestId= c2s_requestId;
			_socket.request<FriendRefuceApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendRefuceApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAllRefuceApplyRequest(List<string> c2s_requestIds,Action<PomeloException,FriendAllRefuceApplyResponse> cb,object option = null)
		{
			var request = new FriendAllRefuceApplyRequest();
			request.c2s_requestIds.AddRange(c2s_requestIds);
			_socket.request<FriendAllRefuceApplyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAllRefuceApplyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendDeleteRequest(string c2s_friendId,Action<PomeloException,FriendDeleteResponse> cb,object option = null)
		{
			var request = new FriendDeleteRequest();
			request.c2s_friendId= c2s_friendId;
			_socket.request<FriendDeleteResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendDeleteResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendDeleteChouRenRequest(string c2s_chouRenId,Action<PomeloException,FriendDeleteChouRenResponse> cb,object option = null)
		{
			var request = new FriendDeleteChouRenRequest();
			request.c2s_chouRenId= c2s_chouRenId;
			_socket.request<FriendDeleteChouRenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendDeleteChouRenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAllDeleteChouRenRequest(List<string> c2s_chouRenIds,Action<PomeloException,FriendAllDeleteChouRenResponse> cb,object option = null)
		{
			var request = new FriendAllDeleteChouRenRequest();
			request.c2s_chouRenIds.AddRange(c2s_chouRenIds);
			_socket.request<FriendAllDeleteChouRenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAllDeleteChouRenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendAddChouRenRequest(string c2s_chouRenId,Action<PomeloException,FriendAddChouRenResponse> cb,object option = null)
		{
			var request = new FriendAddChouRenRequest();
			request.c2s_chouRenId= c2s_chouRenId;
			_socket.request<FriendAddChouRenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendAddChouRenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void addFriendInfoRequest(Action<PomeloException,AddFriendInfoResponse> cb,object option = null)
		{
			var request = new AddFriendInfoRequest();
			_socket.request<AddFriendInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AddFriendInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void queryPlayerNameRequest(string c2s_strName,Action<PomeloException,QueryPlayerNameResponse> cb,object option = null)
		{
			var request = new QueryPlayerNameRequest();
			request.c2s_strName= c2s_strName;
			_socket.request<QueryPlayerNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryPlayerNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void concernFriendRequest(string c2s_friendId,Action<PomeloException,ConcernFriendResponse> cb,object option = null)
		{
			var request = new ConcernFriendRequest();
			request.c2s_friendId= c2s_friendId;
			_socket.request<ConcernFriendResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ConcernFriendResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void concernAllFriendRequest(List<string> c2s_friendIds,Action<PomeloException,ConcernAllFriendResponse> cb,object option = null)
		{
			var request = new ConcernAllFriendRequest();
			request.c2s_friendIds.AddRange(c2s_friendIds);
			_socket.request<ConcernAllFriendResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ConcernAllFriendResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void friendMessageListRequest(Action<PomeloException,FriendMessageListResponse> cb,object option = null)
		{
			var request = new FriendMessageListRequest();
			_socket.request<FriendMessageListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FriendMessageListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void deleteAllFriendMessageRequest(Action<PomeloException,DeleteAllFriendMessageResponse> cb,object option = null)
		{
			var request = new DeleteAllFriendMessageRequest();
			_socket.request<DeleteAllFriendMessageResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DeleteAllFriendMessageResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void deleteBlackListRequest(string c2s_blackListId,Action<PomeloException,DeleteBlackListResponse> cb,object option = null)
		{
			var request = new DeleteBlackListRequest();
			request.c2s_blackListId= c2s_blackListId;
			_socket.request<DeleteBlackListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DeleteBlackListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void deleteAllBlackListRequest(Action<PomeloException,DeleteAllBlackListResponse> cb,object option = null)
		{
			var request = new DeleteAllBlackListRequest();
			_socket.request<DeleteAllBlackListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DeleteAllBlackListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void addBlackListRequest(string c2s_blackListId,Action<PomeloException,AddBlackListResponse> cb,object option = null)
		{
			var request = new AddBlackListRequest();
			request.c2s_blackListId= c2s_blackListId;
			_socket.request<AddBlackListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AddBlackListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSocialInfoRequest(Action<PomeloException,GetSocialInfoResponse> cb,object option = null)
		{
			var request = new GetSocialInfoRequest();
			_socket.request<GetSocialInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSocialInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getShopItemListRequest(Action<PomeloException,GetShopItemListResponse> cb,object option = null)
		{
			var request = new GetShopItemListRequest();
			_socket.request<GetShopItemListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetShopItemListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void exchangeFriendShopItemRequest(int c2s_itemId,int c2s_num,Action<PomeloException,ExchangeFriendShopItemResponse> cb,object option = null)
		{
			var request = new ExchangeFriendShopItemRequest();
			request.c2s_itemId= c2s_itemId;
			request.c2s_num= c2s_num;
			_socket.request<ExchangeFriendShopItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ExchangeFriendShopItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRecentChatListRequest(Action<PomeloException,GetRecentChatListResponse> cb,object option = null)
		{
			var request = new GetRecentChatListRequest();
			_socket.request<GetRecentChatListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRecentChatListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getChatMsgRequest(string c2s_friendId,Action<PomeloException,GetChatMsgResponse> cb,object option = null)
		{
			var request = new GetChatMsgRequest();
			request.c2s_friendId= c2s_friendId;
			_socket.request<GetChatMsgResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetChatMsgResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void rmChatMsgRequest(string c2s_friendId,Action<PomeloException,RmChatMsgResponse> cb,object option = null)
		{
			var request = new RmChatMsgRequest();
			request.c2s_friendId= c2s_friendId;
			_socket.request<RmChatMsgResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RmChatMsgResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}