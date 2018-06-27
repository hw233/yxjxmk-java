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
	public class ConsignmentLineHandler
	{
		private PomeloClient _socket;

		public AddConsignmentResponse lastAddConsignmentResponse { get { return _socket.GetLastResponse<AddConsignmentResponse>(); } }
		public RemoveConsignmentResponse lastRemoveConsignmentResponse { get { return _socket.GetLastResponse<RemoveConsignmentResponse>(); } }
		public BuyConsignmentResponse lastBuyConsignmentResponse { get { return _socket.GetLastResponse<BuyConsignmentResponse>(); } }
		public ConsignmentListResponse lastConsignmentListResponse { get { return _socket.GetLastResponse<ConsignmentListResponse>(); } }
		public MyConsignmentResponse lastMyConsignmentResponse { get { return _socket.GetLastResponse<MyConsignmentResponse>(); } }
		public SearchConsignmentResponse lastSearchConsignmentResponse { get { return _socket.GetLastResponse<SearchConsignmentResponse>(); } }
		public PublicItemResponse lastPublicItemResponse { get { return _socket.GetLastResponse<PublicItemResponse>(); } }
		static ConsignmentLineHandler()
		{
			EventTypes.RegistPushType("area.consignmentLinePush.consignmentRemovePush", typeof(ConsignmentRemovePush));
			EventTypes.RegistRequestType("area.consignmentLineHandler.addConsignmentRequest", typeof(AddConsignmentRequest), typeof(AddConsignmentResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.removeConsignmentRequest", typeof(RemoveConsignmentRequest), typeof(RemoveConsignmentResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.buyConsignmentRequest", typeof(BuyConsignmentRequest), typeof(BuyConsignmentResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.consignmentListRequest", typeof(ConsignmentListRequest), typeof(ConsignmentListResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.myConsignmentRequest", typeof(MyConsignmentRequest), typeof(MyConsignmentResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.searchConsignmentRequest", typeof(SearchConsignmentRequest), typeof(SearchConsignmentResponse));
			EventTypes.RegistRequestType("area.consignmentLineHandler.publicItemRequest", typeof(PublicItemRequest), typeof(PublicItemResponse));
		}
		public ConsignmentLineHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void addConsignmentRequest(int c2s_index,int c2s_number,int c2s_price,int c2s_global,int c2s_isAnonymous,string c2s_id,Action<PomeloException,AddConsignmentResponse> cb,object option = null)
		{
			var request = new AddConsignmentRequest();
			request.c2s_index= c2s_index;
			request.c2s_number= c2s_number;
			request.c2s_price= c2s_price;
			request.c2s_global= c2s_global;
			request.c2s_isAnonymous= c2s_isAnonymous;
			request.c2s_id= c2s_id;
			_socket.request<AddConsignmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AddConsignmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void removeConsignmentRequest(string c2s_id,int c2s_global,Action<PomeloException,RemoveConsignmentResponse> cb,object option = null)
		{
			var request = new RemoveConsignmentRequest();
			request.c2s_id= c2s_id;
			request.c2s_global= c2s_global;
			_socket.request<RemoveConsignmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RemoveConsignmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyConsignmentRequest(string c2s_id,int c2s_global,Action<PomeloException,BuyConsignmentResponse> cb,object option = null)
		{
			var request = new BuyConsignmentRequest();
			request.c2s_id= c2s_id;
			request.c2s_global= c2s_global;
			_socket.request<BuyConsignmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyConsignmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void consignmentListRequest(int c2s_pro,int c2s_qcolor,int c2s_order,int c2s_itemSecondType,int c2s_page,int c2s_global,string c2s_itemType,int c2s_level,Action<PomeloException,ConsignmentListResponse> cb,object option = null)
		{
			var request = new ConsignmentListRequest();
			request.c2s_pro= c2s_pro;
			request.c2s_qcolor= c2s_qcolor;
			request.c2s_order= c2s_order;
			request.c2s_itemSecondType= c2s_itemSecondType;
			request.c2s_page= c2s_page;
			request.c2s_global= c2s_global;
			request.c2s_itemType= c2s_itemType;
			request.c2s_level= c2s_level;
			_socket.request<ConsignmentListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ConsignmentListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void myConsignmentRequest(int c2s_global,Action<PomeloException,MyConsignmentResponse> cb,object option = null)
		{
			var request = new MyConsignmentRequest();
			request.c2s_global= c2s_global;
			_socket.request<MyConsignmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MyConsignmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void searchConsignmentRequest(string c2s_condition,int c2s_global,Action<PomeloException,SearchConsignmentResponse> cb,object option = null)
		{
			var request = new SearchConsignmentRequest();
			request.c2s_condition= c2s_condition;
			request.c2s_global= c2s_global;
			_socket.request<SearchConsignmentResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SearchConsignmentResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void publicItemRequest(string id,Action<PomeloException,PublicItemResponse> cb,object option = null)
		{
			var request = new PublicItemRequest();
			request.id= id;
			_socket.request<PublicItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PublicItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onConsignmentRemovePush(Action<ConsignmentRemovePush> cb)
		{
			_socket.listen_once<ConsignmentRemovePush>(cb);
		}

	}


}