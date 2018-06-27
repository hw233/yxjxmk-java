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
	public class CardHandler
	{
		private PomeloClient _socket;

		public CardRegisterResponse lastCardRegisterResponse { get { return _socket.GetLastResponse<CardRegisterResponse>(); } }
		public CardLevelUpResponse lastCardLevelUpResponse { get { return _socket.GetLastResponse<CardLevelUpResponse>(); } }
		public CardPreLevelUpResponse lastCardPreLevelUpResponse { get { return _socket.GetLastResponse<CardPreLevelUpResponse>(); } }
		public CardGetAwardResponse lastCardGetAwardResponse { get { return _socket.GetLastResponse<CardGetAwardResponse>(); } }
		public CardEquipResponse lastCardEquipResponse { get { return _socket.GetLastResponse<CardEquipResponse>(); } }
		public CardQueryAllDataResponse lastCardQueryAllDataResponse { get { return _socket.GetLastResponse<CardQueryAllDataResponse>(); } }
		static CardHandler()
		{
			EventTypes.RegistRequestType("area.cardHandler.cardRegisterRequest", typeof(CardRegisterRequest), typeof(CardRegisterResponse));
			EventTypes.RegistRequestType("area.cardHandler.cardLevelUpRequest", typeof(CardLevelUpRequest), typeof(CardLevelUpResponse));
			EventTypes.RegistRequestType("area.cardHandler.cardPreLevelUpRequest", typeof(CardPreLevelUpRequest), typeof(CardPreLevelUpResponse));
			EventTypes.RegistRequestType("area.cardHandler.cardGetAwardRequest", typeof(CardGetAwardRequest), typeof(CardGetAwardResponse));
			EventTypes.RegistRequestType("area.cardHandler.cardEquipRequest", typeof(CardEquipRequest), typeof(CardEquipResponse));
			EventTypes.RegistRequestType("area.cardHandler.cardQueryAllDataRequest", typeof(CardQueryAllDataRequest), typeof(CardQueryAllDataResponse));
		}
		public CardHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void cardRegisterRequest(int c2s_cardId,Action<PomeloException,CardRegisterResponse> cb,object option = null)
		{
			var request = new CardRegisterRequest();
			request.c2s_cardId= c2s_cardId;
			_socket.request<CardRegisterResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardRegisterResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cardLevelUpRequest(int c2s_cardTemplateId,Action<PomeloException,CardLevelUpResponse> cb,object option = null)
		{
			var request = new CardLevelUpRequest();
			request.c2s_cardTemplateId= c2s_cardTemplateId;
			_socket.request<CardLevelUpResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardLevelUpResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cardPreLevelUpRequest(int c2s_cardTemplateId,Action<PomeloException,CardPreLevelUpResponse> cb,object option = null)
		{
			var request = new CardPreLevelUpRequest();
			request.c2s_cardTemplateId= c2s_cardTemplateId;
			_socket.request<CardPreLevelUpResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardPreLevelUpResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cardGetAwardRequest(int c2s_awardId,Action<PomeloException,CardGetAwardResponse> cb,object option = null)
		{
			var request = new CardGetAwardRequest();
			request.c2s_awardId= c2s_awardId;
			_socket.request<CardGetAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardGetAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cardEquipRequest(int c2s_cardId,int c2s_holePos,Action<PomeloException,CardEquipResponse> cb,object option = null)
		{
			var request = new CardEquipRequest();
			request.c2s_cardId= c2s_cardId;
			request.c2s_holePos= c2s_holePos;
			_socket.request<CardEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cardQueryAllDataRequest(Action<PomeloException,CardQueryAllDataResponse> cb,object option = null)
		{
			var request = new CardQueryAllDataRequest();
			_socket.request<CardQueryAllDataResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CardQueryAllDataResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}