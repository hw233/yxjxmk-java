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
	public class PetHandler
	{
		private PomeloClient _socket;

		public GetAllPetsBaseInfoResponse lastGetAllPetsBaseInfoResponse { get { return _socket.GetLastResponse<GetAllPetsBaseInfoResponse>(); } }
		public GetPetInfoResponse lastGetPetInfoResponse { get { return _socket.GetLastResponse<GetPetInfoResponse>(); } }
		public DevelopPetResponse lastDevelopPetResponse { get { return _socket.GetLastResponse<DevelopPetResponse>(); } }
		public ChangePetNameResponse lastChangePetNameResponse { get { return _socket.GetLastResponse<ChangePetNameResponse>(); } }
		public FreePetResponse lastFreePetResponse { get { return _socket.GetLastResponse<FreePetResponse>(); } }
		public PetOutFightResponse lastPetOutFightResponse { get { return _socket.GetLastResponse<PetOutFightResponse>(); } }
		public PetReliveResponse lastPetReliveResponse { get { return _socket.GetLastResponse<PetReliveResponse>(); } }
		public RandPetNameResponse lastRandPetNameResponse { get { return _socket.GetLastResponse<RandPetNameResponse>(); } }
		public UpGradeInfoResponse lastUpGradeInfoResponse { get { return _socket.GetLastResponse<UpGradeInfoResponse>(); } }
		public UpGradeLevelResponse lastUpGradeLevelResponse { get { return _socket.GetLastResponse<UpGradeLevelResponse>(); } }
		public UpGradeRandPropertyResponse lastUpGradeRandPropertyResponse { get { return _socket.GetLastResponse<UpGradeRandPropertyResponse>(); } }
		public ReSetRandPropertyResponse lastReSetRandPropertyResponse { get { return _socket.GetLastResponse<ReSetRandPropertyResponse>(); } }
		public RandPropertyListResponse lastRandPropertyListResponse { get { return _socket.GetLastResponse<RandPropertyListResponse>(); } }
		public PetIllusionResponse lastPetIllusionResponse { get { return _socket.GetLastResponse<PetIllusionResponse>(); } }
		public PetIllusionInfoResponse lastPetIllusionInfoResponse { get { return _socket.GetLastResponse<PetIllusionInfoResponse>(); } }
		public PetIllusionReviewResponse lastPetIllusionReviewResponse { get { return _socket.GetLastResponse<PetIllusionReviewResponse>(); } }
		public PetComprehendSkillResponse lastPetComprehendSkillResponse { get { return _socket.GetLastResponse<PetComprehendSkillResponse>(); } }
		public PetSkillListResponse lastPetSkillListResponse { get { return _socket.GetLastResponse<PetSkillListResponse>(); } }
		public PetOnHookSetResponse lastPetOnHookSetResponse { get { return _socket.GetLastResponse<PetOnHookSetResponse>(); } }
		public PetOnHookGetResponse lastPetOnHookGetResponse { get { return _socket.GetLastResponse<PetOnHookGetResponse>(); } }
		public ChangePetPkModelResponse lastChangePetPkModelResponse { get { return _socket.GetLastResponse<ChangePetPkModelResponse>(); } }
		static PetHandler()
		{
			EventTypes.RegistPushType("area.petPush.onPetDetailPush", typeof(OnPetDetailPush));
			EventTypes.RegistPushType("area.petPush.onPetExpPush", typeof(OnPetExpPush));
			EventTypes.RegistRequestType("area.petHandler.getAllPetsBaseInfoRequest", typeof(GetAllPetsBaseInfoRequest), typeof(GetAllPetsBaseInfoResponse));
			EventTypes.RegistRequestType("area.petHandler.getPetInfoRequest", typeof(GetPetInfoRequest), typeof(GetPetInfoResponse));
			EventTypes.RegistRequestType("area.petHandler.developPetRequest", typeof(DevelopPetRequest), typeof(DevelopPetResponse));
			EventTypes.RegistRequestType("area.petHandler.changePetNameRequest", typeof(ChangePetNameRequest), typeof(ChangePetNameResponse));
			EventTypes.RegistRequestType("area.petHandler.freePetRequest", typeof(FreePetRequest), typeof(FreePetResponse));
			EventTypes.RegistRequestType("area.petHandler.petOutFightRequest", typeof(PetOutFightRequest), typeof(PetOutFightResponse));
			EventTypes.RegistRequestType("area.petHandler.petReliveRequest", typeof(PetReliveRequest), typeof(PetReliveResponse));
			EventTypes.RegistRequestType("area.petHandler.randPetNameRequest", typeof(RandPetNameRequest), typeof(RandPetNameResponse));
			EventTypes.RegistRequestType("area.petHandler.upGradeInfoRequest", typeof(UpGradeInfoRequest), typeof(UpGradeInfoResponse));
			EventTypes.RegistRequestType("area.petHandler.upGradeLevelRequest", typeof(UpGradeLevelRequest), typeof(UpGradeLevelResponse));
			EventTypes.RegistRequestType("area.petHandler.upGradeRandPropertyRequest", typeof(UpGradeRandPropertyRequest), typeof(UpGradeRandPropertyResponse));
			EventTypes.RegistRequestType("area.petHandler.reSetRandPropertyRequest", typeof(ReSetRandPropertyRequest), typeof(ReSetRandPropertyResponse));
			EventTypes.RegistRequestType("area.petHandler.randPropertyListRequest", typeof(RandPropertyListRequest), typeof(RandPropertyListResponse));
			EventTypes.RegistRequestType("area.petHandler.petIllusionRequest", typeof(PetIllusionRequest), typeof(PetIllusionResponse));
			EventTypes.RegistRequestType("area.petHandler.petIllusionInfoRequest", typeof(PetIllusionInfoRequest), typeof(PetIllusionInfoResponse));
			EventTypes.RegistRequestType("area.petHandler.petIllusionReviewRequest", typeof(PetIllusionReviewRequest), typeof(PetIllusionReviewResponse));
			EventTypes.RegistRequestType("area.petHandler.petComprehendSkillRequest", typeof(PetComprehendSkillRequest), typeof(PetComprehendSkillResponse));
			EventTypes.RegistRequestType("area.petHandler.petSkillListRequest", typeof(PetSkillListRequest), typeof(PetSkillListResponse));
			EventTypes.RegistRequestType("area.petHandler.petOnHookSetRequest", typeof(PetOnHookSetRequest), typeof(PetOnHookSetResponse));
			EventTypes.RegistRequestType("area.petHandler.petOnHookGetRequest", typeof(PetOnHookGetRequest), typeof(PetOnHookGetResponse));
			EventTypes.RegistRequestType("area.petHandler.changePetPkModelRequest", typeof(ChangePetPkModelRequest), typeof(ChangePetPkModelResponse));
		}
		public PetHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getAllPetsBaseInfoRequest(Action<PomeloException,GetAllPetsBaseInfoResponse> cb,object option = null)
		{
			var request = new GetAllPetsBaseInfoRequest();
			_socket.request<GetAllPetsBaseInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllPetsBaseInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getPetInfoRequest(string s2c_petId,string s2c_ownId,Action<PomeloException,GetPetInfoResponse> cb,object option = null)
		{
			var request = new GetPetInfoRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_ownId= s2c_ownId;
			_socket.request<GetPetInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetPetInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void developPetRequest(int s2c_type,string s2c_itemCode,string s2c_petId,Action<PomeloException,DevelopPetResponse> cb,object option = null)
		{
			var request = new DevelopPetRequest();
			request.s2c_type= s2c_type;
			request.s2c_itemCode= s2c_itemCode;
			request.s2c_petId= s2c_petId;
			_socket.request<DevelopPetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DevelopPetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changePetNameRequest(string s2c_petId,string s2c_petName,Action<PomeloException,ChangePetNameResponse> cb,object option = null)
		{
			var request = new ChangePetNameRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_petName= s2c_petName;
			_socket.request<ChangePetNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangePetNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void freePetRequest(string s2c_petId,int s2c_type,Action<PomeloException,FreePetResponse> cb,object option = null)
		{
			var request = new FreePetRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_type= s2c_type;
			_socket.request<FreePetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FreePetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petOutFightRequest(string s2c_petId,int s2c_type,Action<PomeloException,PetOutFightResponse> cb,object option = null)
		{
			var request = new PetOutFightRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_type= s2c_type;
			_socket.request<PetOutFightResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetOutFightResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petReliveRequest(string s2c_petId,Action<PomeloException,PetReliveResponse> cb,object option = null)
		{
			var request = new PetReliveRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetReliveResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetReliveResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void randPetNameRequest(Action<PomeloException,RandPetNameResponse> cb,object option = null)
		{
			var request = new RandPetNameRequest();
			_socket.request<RandPetNameResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RandPetNameResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upGradeInfoRequest(string s2c_petId,Action<PomeloException,UpGradeInfoResponse> cb,object option = null)
		{
			var request = new UpGradeInfoRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<UpGradeInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpGradeInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upGradeLevelRequest(string s2c_petId,Action<PomeloException,UpGradeLevelResponse> cb,object option = null)
		{
			var request = new UpGradeLevelRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<UpGradeLevelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpGradeLevelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upGradeRandPropertyRequest(string s2c_petId,int s2c_pos,List<ItemInfo> s2c_materialItems,Action<PomeloException,UpGradeRandPropertyResponse> cb,object option = null)
		{
			var request = new UpGradeRandPropertyRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_pos= s2c_pos;
			request.s2c_materialItems.AddRange(s2c_materialItems);
			_socket.request<UpGradeRandPropertyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpGradeRandPropertyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void reSetRandPropertyRequest(string s2c_petId,int s2c_pos,Action<PomeloException,ReSetRandPropertyResponse> cb,object option = null)
		{
			var request = new ReSetRandPropertyRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_pos= s2c_pos;
			_socket.request<ReSetRandPropertyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReSetRandPropertyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void randPropertyListRequest(string s2c_petId,Action<PomeloException,RandPropertyListResponse> cb,object option = null)
		{
			var request = new RandPropertyListRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<RandPropertyListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RandPropertyListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petIllusionRequest(string s2c_petId,Action<PomeloException,PetIllusionResponse> cb,object option = null)
		{
			var request = new PetIllusionRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetIllusionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetIllusionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petIllusionInfoRequest(string s2c_petId,Action<PomeloException,PetIllusionInfoResponse> cb,object option = null)
		{
			var request = new PetIllusionInfoRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetIllusionInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetIllusionInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petIllusionReviewRequest(string s2c_petId,Action<PomeloException,PetIllusionReviewResponse> cb,object option = null)
		{
			var request = new PetIllusionReviewRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetIllusionReviewResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetIllusionReviewResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petComprehendSkillRequest(string s2c_petId,string s2c_skillBookCode,List<int> s2c_lockPos,Action<PomeloException,PetComprehendSkillResponse> cb,object option = null)
		{
			var request = new PetComprehendSkillRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_skillBookCode= s2c_skillBookCode;
			request.s2c_lockPos.AddRange(s2c_lockPos);
			_socket.request<PetComprehendSkillResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetComprehendSkillResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petSkillListRequest(string s2c_petId,Action<PomeloException,PetSkillListResponse> cb,object option = null)
		{
			var request = new PetSkillListRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetSkillListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetSkillListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petOnHookSetRequest(string s2c_petId,string s2c_onHookData,Action<PomeloException,PetOnHookSetResponse> cb,object option = null)
		{
			var request = new PetOnHookSetRequest();
			request.s2c_petId= s2c_petId;
			request.s2c_onHookData= s2c_onHookData;
			_socket.request<PetOnHookSetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetOnHookSetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void petOnHookGetRequest(string s2c_petId,Action<PomeloException,PetOnHookGetResponse> cb,object option = null)
		{
			var request = new PetOnHookGetRequest();
			request.s2c_petId= s2c_petId;
			_socket.request<PetOnHookGetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as PetOnHookGetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void changePetPkModelRequest(int c2s_model,Action<PomeloException,ChangePetPkModelResponse> cb,object option = null)
		{
			var request = new ChangePetPkModelRequest();
			request.c2s_model= c2s_model;
			_socket.request<ChangePetPkModelResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChangePetPkModelResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onPetDetailPush(Action<OnPetDetailPush> cb)
		{
			_socket.listen_once<OnPetDetailPush>(cb);
		}
		public void onPetExpPush(Action<OnPetExpPush> cb)
		{
			_socket.listen_once<OnPetExpPush>(cb);
		}

	}


}