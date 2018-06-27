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
	public class ExchangeHandler
	{
		private PomeloClient _socket;

		public GetExchangeLabelResponse lastGetExchangeLabelResponse { get { return _socket.GetLastResponse<GetExchangeLabelResponse>(); } }
		public GetExchangeListResponse lastGetExchangeListResponse { get { return _socket.GetLastResponse<GetExchangeListResponse>(); } }
		public ExchangeItemResponse lastExchangeItemResponse { get { return _socket.GetLastResponse<ExchangeItemResponse>(); } }
		public AllyFightExchangeResponse lastAllyFightExchangeResponse { get { return _socket.GetLastResponse<AllyFightExchangeResponse>(); } }
		static ExchangeHandler()
		{
			EventTypes.RegistRequestType("area.exchangeHandler.getExchangeLabelRequest", typeof(GetExchangeLabelRequest), typeof(GetExchangeLabelResponse));
			EventTypes.RegistRequestType("area.exchangeHandler.getExchangeListRequest", typeof(GetExchangeListRequest), typeof(GetExchangeListResponse));
			EventTypes.RegistRequestType("area.exchangeHandler.exchangeItemRequest", typeof(ExchangeItemRequest), typeof(ExchangeItemResponse));
			EventTypes.RegistRequestType("area.exchangeHandler.allyFightExchangeRequest", typeof(AllyFightExchangeRequest), typeof(AllyFightExchangeResponse));
		}
		public ExchangeHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getExchangeLabelRequest(string c2s_npcId,Action<PomeloException,GetExchangeLabelResponse> cb,object option = null)
		{
			var request = new GetExchangeLabelRequest();
			request.c2s_npcId= c2s_npcId;
			_socket.request<GetExchangeLabelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetExchangeLabelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getExchangeListRequest(string c2s_npcId,int c2s_typeId,Action<PomeloException,GetExchangeListResponse> cb,object option = null)
		{
			var request = new GetExchangeListRequest();
			request.c2s_npcId= c2s_npcId;
			request.c2s_typeId= c2s_typeId;
			_socket.request<GetExchangeListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetExchangeListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void exchangeItemRequest(int c2s_typeId,int c2s_itemId,int c2s_num,string c2s_npcId,Action<PomeloException,ExchangeItemResponse> cb,object option = null)
		{
			var request = new ExchangeItemRequest();
			request.c2s_typeId= c2s_typeId;
			request.c2s_itemId= c2s_itemId;
			request.c2s_num= c2s_num;
			request.c2s_npcId= c2s_npcId;
			_socket.request<ExchangeItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ExchangeItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void allyFightExchangeRequest(string c2s_npcId,int c2s_typeId,Action<PomeloException,AllyFightExchangeResponse> cb,object option = null)
		{
			var request = new AllyFightExchangeRequest();
			request.c2s_npcId= c2s_npcId;
			request.c2s_typeId= c2s_typeId;
			_socket.request<AllyFightExchangeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AllyFightExchangeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}