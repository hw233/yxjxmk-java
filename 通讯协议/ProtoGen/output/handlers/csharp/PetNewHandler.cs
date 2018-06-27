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
	public class PetNewHandler
	{
		private PomeloClient _socket;

		public GetAllPetsInfoResponse lastGetAllPetsInfoResponse { get { return _socket.GetLastResponse<GetAllPetsInfoResponse>(); } }
		public SummonPetResponse lastSummonPetResponse { get { return _socket.GetLastResponse<SummonPetResponse>(); } }
		public UpGradeUpLevelResponse lastUpGradeUpLevelResponse { get { return _socket.GetLastResponse<UpGradeUpLevelResponse>(); } }
		public AddExpByItemResponse lastAddExpByItemResponse { get { return _socket.GetLastResponse<AddExpByItemResponse>(); } }
		public UpgradeOneLevelResponse lastUpgradeOneLevelResponse { get { return _socket.GetLastResponse<UpgradeOneLevelResponse>(); } }
		public UpgradeToTopResponse lastUpgradeToTopResponse { get { return _socket.GetLastResponse<UpgradeToTopResponse>(); } }
		public ChangePetNameNewResponse lastChangePetNameNewResponse { get { return _socket.GetLastResponse<ChangePetNameNewResponse>(); } }
		public PetFightResponse lastPetFightResponse { get { return _socket.GetLastResponse<PetFightResponse>(); } }
		public GetPetInfoNewResponse lastGetPetInfoNewResponse { get { return _socket.GetLastResponse<GetPetInfoNewResponse>(); } }
		static PetNewHandler()
		{
			EventTypes.RegistPushType("area.petNewPush.onNewPetDetailPush", typeof(OnNewPetDetailPush));
			EventTypes.RegistPushType("area.petNewPush.petExpUpdatePush", typeof(PetExpUpdatePush));
			EventTypes.RegistPushType("area.petNewPush.petInfoUpdatePush", typeof(PetInfoUpdatePush));
			EventTypes.RegistRequestType("area.petNewHandler.getAllPetsInfoRequest", typeof(GetAllPetsInfoRequest), typeof(GetAllPetsInfoResponse));
			EventTypes.RegistRequestType("area.petNewHandler.summonPetRequest", typeof(SummonPetRequest), typeof(SummonPetResponse));
			EventTypes.RegistRequestType("area.petNewHandler.upGradeUpLevelRequest", typeof(UpGradeUpLevelRequest), typeof(UpGradeUpLevelResponse));
			EventTypes.RegistRequestType("area.petNewHandler.addExpByItemRequest", typeof(AddExpByItemRequest), typeof(AddExpByItemResponse));
			EventTypes.RegistRequestType("area.petNewHandler.upgradeOneLevelRequest", typeof(UpgradeOneLevelRequest), typeof(UpgradeOneLevelResponse));
			EventTypes.RegistRequestType("area.petNewHandler.upgradeToTopRequest", typeof(UpgradeToTopRequest), typeof(UpgradeToTopResponse));
			EventTypes.RegistRequestType("area.petNewHandler.changePetNameNewRequest", typeof(ChangePetNameNewRequest), typeof(ChangePetNameNewResponse));
			EventTypes.RegistRequestType("area.petNewHandler.petFightRequest", typeof(PetFightRequest), typeof(PetFightResponse));
			EventTypes.RegistRequestType("area.petNewHandler.getPetInfoNewRequest", typeof(GetPetInfoNewRequest), typeof(GetPetInfoNewResponse));
		}
		public PetNewHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getAllPetsInfoRequest(Action<PomeloException,GetAllPetsInfoResponse> cb,object option = null)
		{
			var request = new GetAllPetsInfoRequest();
			_socket.request<GetAllPetsInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllPetsInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void summonPetRequest(int c2s_id,Action<PomeloException,SummonPetResponse> cb,object option = null)
		{
			var request = new SummonPetRequest();
			request.c2s_id= c2s_id;
			_socket.request<SummonPetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SummonPetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upGradeUpLevelRequest(int c2s_id,Action<PomeloException,UpGradeUpLevelResponse> cb,object option = null)
		{
			var request = new UpGradeUpLevelRequest();
			request.c2s_id= c2s_id;
			_socket.request<UpGradeUpLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpGradeUpLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void addExpByItemRequest(int c2s_id,string c2s_itemCode,Action<PomeloException,AddExpByItemResponse> cb,object option = null)
		{
			var request = new AddExpByItemRequest();
			request.c2s_id= c2s_id;
			request.c2s_itemCode= c2s_itemCode;
			_socket.request<AddExpByItemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AddExpByItemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeOneLevelRequest(int c2s_id,Action<PomeloException,UpgradeOneLevelResponse> cb,object option = null)
		{
			var request = new UpgradeOneLevelRequest();
			request.c2s_id= c2s_id;
			_socket.request<UpgradeOneLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeOneLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upgradeToTopRequest(int c2s_id,Action<PomeloException,UpgradeToTopResponse> cb,object option = null)
		{
			var request = new UpgradeToTopRequest();
			request.c2s_id= c2s_id;
			_socket.request<UpgradeToTopResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpgradeToTopResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changePetNameNewRequest(int c2s_id,string c2s_name,Action<PomeloException,ChangePetNameNewResponse> cb,object option = null)
		{
			var request = new ChangePetNameNewRequest();
			request.c2s_id= c2s_id;
			request.c2s_name= c2s_name;
			_socket.request<ChangePetNameNewResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangePetNameNewResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petFightRequest(int c2s_id,int c2s_type,Action<PomeloException,PetFightResponse> cb,object option = null)
		{
			var request = new PetFightRequest();
			request.c2s_id= c2s_id;
			request.c2s_type= c2s_type;
			_socket.request<PetFightResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetFightResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getPetInfoNewRequest(int c2s_petId,string c2s_ownId,Action<PomeloException,GetPetInfoNewResponse> cb,object option = null)
		{
			var request = new GetPetInfoNewRequest();
			request.c2s_petId= c2s_petId;
			request.c2s_ownId= c2s_ownId;
			_socket.request<GetPetInfoNewResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetPetInfoNewResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onNewPetDetailPush(Action<OnNewPetDetailPush> cb)
		{
			_socket.listen_once<OnNewPetDetailPush>(cb);
		}
		public void onPetExpUpdatePush(Action<PetExpUpdatePush> cb)
		{
			_socket.listen_once<PetExpUpdatePush>(cb);
		}
		public void onPetInfoUpdatePush(Action<PetInfoUpdatePush> cb)
		{
			_socket.listen_once<PetInfoUpdatePush>(cb);
		}

	}


}