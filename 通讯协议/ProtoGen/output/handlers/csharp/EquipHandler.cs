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
	public class EquipHandler
	{
		private PomeloClient _socket;

		public UnEquipResponse lastUnEquipResponse { get { return _socket.GetLastResponse<UnEquipResponse>(); } }
		public EquipResponse lastEquipResponse { get { return _socket.GetLastResponse<EquipResponse>(); } }
		public EquipPreStrengthenResponse lastEquipPreStrengthenResponse { get { return _socket.GetLastResponse<EquipPreStrengthenResponse>(); } }
		public EquipStrengthenResponse lastEquipStrengthenResponse { get { return _socket.GetLastResponse<EquipStrengthenResponse>(); } }
		public EnchantEquipResponse lastEnchantEquipResponse { get { return _socket.GetLastResponse<EnchantEquipResponse>(); } }
		public ConfirmEnchantEquipResponse lastConfirmEnchantEquipResponse { get { return _socket.GetLastResponse<ConfirmEnchantEquipResponse>(); } }
		public IdentifyEquipResponse lastIdentifyEquipResponse { get { return _socket.GetLastResponse<IdentifyEquipResponse>(); } }
		public RefineEquipResponse lastRefineEquipResponse { get { return _socket.GetLastResponse<RefineEquipResponse>(); } }
		public RefineOneKeyResponse lastRefineOneKeyResponse { get { return _socket.GetLastResponse<RefineOneKeyResponse>(); } }
		public RefineResetResponse lastRefineResetResponse { get { return _socket.GetLastResponse<RefineResetResponse>(); } }
		public EquipMakeResponse lastEquipMakeResponse { get { return _socket.GetLastResponse<EquipMakeResponse>(); } }
		public EquipLevelUpResponse lastEquipLevelUpResponse { get { return _socket.GetLastResponse<EquipLevelUpResponse>(); } }
		public EquipColorUpResponse lastEquipColorUpResponse { get { return _socket.GetLastResponse<EquipColorUpResponse>(); } }
		public FillGemResponse lastFillGemResponse { get { return _socket.GetLastResponse<FillGemResponse>(); } }
		public FillAllGemResponse lastFillAllGemResponse { get { return _socket.GetLastResponse<FillAllGemResponse>(); } }
		public UnFillGemResponse lastUnFillGemResponse { get { return _socket.GetLastResponse<UnFillGemResponse>(); } }
		public UnFillAllGemResponse lastUnFillAllGemResponse { get { return _socket.GetLastResponse<UnFillAllGemResponse>(); } }
		public GetSuitAttrResponse lastGetSuitAttrResponse { get { return _socket.GetLastResponse<GetSuitAttrResponse>(); } }
		public GetSuitDetailResponse lastGetSuitDetailResponse { get { return _socket.GetLastResponse<GetSuitDetailResponse>(); } }
		public GetInheritInfoResponse lastGetInheritInfoResponse { get { return _socket.GetLastResponse<GetInheritInfoResponse>(); } }
		public EquipInheritResponse lastEquipInheritResponse { get { return _socket.GetLastResponse<EquipInheritResponse>(); } }
		public EquipMeltResponse lastEquipMeltResponse { get { return _socket.GetLastResponse<EquipMeltResponse>(); } }
		public ChatEquipDetailResponse lastChatEquipDetailResponse { get { return _socket.GetLastResponse<ChatEquipDetailResponse>(); } }
		public EquipRebornResponse lastEquipRebornResponse { get { return _socket.GetLastResponse<EquipRebornResponse>(); } }
		public EquipRebuildResponse lastEquipRebuildResponse { get { return _socket.GetLastResponse<EquipRebuildResponse>(); } }
		public EquipSeniorRebuildResponse lastEquipSeniorRebuildResponse { get { return _socket.GetLastResponse<EquipSeniorRebuildResponse>(); } }
		public EquipRefineResponse lastEquipRefineResponse { get { return _socket.GetLastResponse<EquipRefineResponse>(); } }
		public EquipRefineLegendResponse lastEquipRefineLegendResponse { get { return _socket.GetLastResponse<EquipRefineLegendResponse>(); } }
		public SaveRebornResponse lastSaveRebornResponse { get { return _socket.GetLastResponse<SaveRebornResponse>(); } }
		public SaveRebuildResponse lastSaveRebuildResponse { get { return _socket.GetLastResponse<SaveRebuildResponse>(); } }
		public SmritiResponse lastSmritiResponse { get { return _socket.GetLastResponse<SmritiResponse>(); } }
		public SaveSeniorRebuildResponse lastSaveSeniorRebuildResponse { get { return _socket.GetLastResponse<SaveSeniorRebuildResponse>(); } }
		public SaveRefineResponse lastSaveRefineResponse { get { return _socket.GetLastResponse<SaveRefineResponse>(); } }
		public SaveRefineLegendResponse lastSaveRefineLegendResponse { get { return _socket.GetLastResponse<SaveRefineLegendResponse>(); } }
		public GetRefineExtPropResponse lastGetRefineExtPropResponse { get { return _socket.GetLastResponse<GetRefineExtPropResponse>(); } }
		static EquipHandler()
		{
			EventTypes.RegistPushType("area.equipPush.equipmentSimplePush", typeof(EquipmentSimplePush));
			EventTypes.RegistPushType("area.equipPush.equipInheritPush", typeof(EquipInheritPush));
			EventTypes.RegistPushType("area.equipPush.equipStrengthPosPush", typeof(StrengthPosPush));
			EventTypes.RegistRequestType("area.equipHandler.unEquipRequest", typeof(UnEquipRequest), typeof(UnEquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipRequest", typeof(EquipRequest), typeof(EquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipPreStrengthenRequest", typeof(EquipPreStrengthenRequest), typeof(EquipPreStrengthenResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipStrengthenRequest", typeof(EquipStrengthenRequest), typeof(EquipStrengthenResponse));
			EventTypes.RegistRequestType("area.equipHandler.enchantEquipRequest", typeof(EnchantEquipRequest), typeof(EnchantEquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.confirmEnchantEquipRequest", typeof(ConfirmEnchantEquipRequest), typeof(ConfirmEnchantEquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.identifyEquipRequest", typeof(IdentifyEquipRequest), typeof(IdentifyEquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.refineEquipRequest", typeof(RefineEquipRequest), typeof(RefineEquipResponse));
			EventTypes.RegistRequestType("area.equipHandler.refineOneKeyRequest", typeof(RefineOneKeyRequest), typeof(RefineOneKeyResponse));
			EventTypes.RegistRequestType("area.equipHandler.refineResetRequest", typeof(RefineResetRequest), typeof(RefineResetResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipMakeRequest", typeof(EquipMakeRequest), typeof(EquipMakeResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipLevelUpRequest", typeof(EquipLevelUpRequest), typeof(EquipLevelUpResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipColorUpRequest", typeof(EquipColorUpRequest), typeof(EquipColorUpResponse));
			EventTypes.RegistRequestType("area.equipHandler.fillGemRequest", typeof(FillGemRequest), typeof(FillGemResponse));
			EventTypes.RegistRequestType("area.equipHandler.fillAllGemRequest", typeof(FillAllGemRequest), typeof(FillAllGemResponse));
			EventTypes.RegistRequestType("area.equipHandler.unFillGemRequest", typeof(UnFillGemRequest), typeof(UnFillGemResponse));
			EventTypes.RegistRequestType("area.equipHandler.unFillAllGemRequest", typeof(UnFillAllGemRequest), typeof(UnFillAllGemResponse));
			EventTypes.RegistRequestType("area.equipHandler.getSuitAttrRequest", typeof(GetSuitAttrRequest), typeof(GetSuitAttrResponse));
			EventTypes.RegistRequestType("area.equipHandler.getSuitDetailRequest", typeof(GetSuitDetailRequest), typeof(GetSuitDetailResponse));
			EventTypes.RegistRequestType("area.equipHandler.getInheritInfoRequest", typeof(GetInheritInfoRequest), typeof(GetInheritInfoResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipInheritRequest", typeof(EquipInheritRequest), typeof(EquipInheritResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipMeltRequest", typeof(EquipMeltRequest), typeof(EquipMeltResponse));
			EventTypes.RegistRequestType("area.equipHandler.chatEquipDetailRequest", typeof(ChatEquipDetailRequest), typeof(ChatEquipDetailResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipRebornRequest", typeof(EquipRebornRequest), typeof(EquipRebornResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipRebuildRequest", typeof(EquipRebuildRequest), typeof(EquipRebuildResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipSeniorRebuildRequest", typeof(EquipSeniorRebuildRequest), typeof(EquipSeniorRebuildResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipRefineRequest", typeof(EquipRefineRequest), typeof(EquipRefineResponse));
			EventTypes.RegistRequestType("area.equipHandler.equipRefineLegendRequest", typeof(EquipRefineLegendRequest), typeof(EquipRefineLegendResponse));
			EventTypes.RegistRequestType("area.equipHandler.saveRebornRequest", typeof(SaveRebornRequest), typeof(SaveRebornResponse));
			EventTypes.RegistRequestType("area.equipHandler.saveRebuildRequest", typeof(SaveRebuildRequest), typeof(SaveRebuildResponse));
			EventTypes.RegistRequestType("area.equipHandler.smritiRequest", typeof(SmritiRequest), typeof(SmritiResponse));
			EventTypes.RegistRequestType("area.equipHandler.saveSeniorRebuildRequest", typeof(SaveSeniorRebuildRequest), typeof(SaveSeniorRebuildResponse));
			EventTypes.RegistRequestType("area.equipHandler.saveRefineRequest", typeof(SaveRefineRequest), typeof(SaveRefineResponse));
			EventTypes.RegistRequestType("area.equipHandler.saveRefineLegendRequest", typeof(SaveRefineLegendRequest), typeof(SaveRefineLegendResponse));
			EventTypes.RegistRequestType("area.equipHandler.getRefineExtPropRequest", typeof(GetRefineExtPropRequest), typeof(GetRefineExtPropResponse));
		}
		public EquipHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void unEquipRequest(int c2s_gridIndex,Action<PomeloException,UnEquipResponse> cb,object option = null)
		{
			var request = new UnEquipRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<UnEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipRequest(int c2s_gridIndex,Action<PomeloException,EquipResponse> cb,object option = null)
		{
			var request = new EquipRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<EquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipPreStrengthenRequest(int c2s_pos,Action<PomeloException,EquipPreStrengthenResponse> cb,object option = null)
		{
			var request = new EquipPreStrengthenRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<EquipPreStrengthenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipPreStrengthenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipStrengthenRequest(int c2s_pos,int c2s_useZuan,Action<PomeloException,EquipStrengthenResponse> cb,object option = null)
		{
			var request = new EquipStrengthenRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_useZuan= c2s_useZuan;
			_socket.request<EquipStrengthenResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipStrengthenResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enchantEquipRequest(int c2s_pos,int c2s_gridIndex,int c2s_diamond,Action<PomeloException,EnchantEquipResponse> cb,object option = null)
		{
			var request = new EnchantEquipRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_gridIndex= c2s_gridIndex;
			request.c2s_diamond= c2s_diamond;
			_socket.request<EnchantEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnchantEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void confirmEnchantEquipRequest(int c2s_pos,Action<PomeloException,ConfirmEnchantEquipResponse> cb,object option = null)
		{
			var request = new ConfirmEnchantEquipRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<ConfirmEnchantEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ConfirmEnchantEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void identifyEquipRequest(int c2s_gridIndex,Action<PomeloException,IdentifyEquipResponse> cb,object option = null)
		{
			var request = new IdentifyEquipRequest();
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<IdentifyEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as IdentifyEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void refineEquipRequest(int c2s_pos,string c2s_itemCode,Action<PomeloException,RefineEquipResponse> cb,object option = null)
		{
			var request = new RefineEquipRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_itemCode= c2s_itemCode;
			_socket.request<RefineEquipResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RefineEquipResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void refineOneKeyRequest(int c2s_pos,string c2s_itemCode,Action<PomeloException,RefineOneKeyResponse> cb,object option = null)
		{
			var request = new RefineOneKeyRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_itemCode= c2s_itemCode;
			_socket.request<RefineOneKeyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RefineOneKeyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void refineResetRequest(int c2s_pos,int c2s_propIndex,Action<PomeloException,RefineResetResponse> cb,object option = null)
		{
			var request = new RefineResetRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_propIndex= c2s_propIndex;
			_socket.request<RefineResetResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RefineResetResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipMakeRequest(string c2s_targetCode,Action<PomeloException,EquipMakeResponse> cb,object option = null)
		{
			var request = new EquipMakeRequest();
			request.c2s_targetCode= c2s_targetCode;
			_socket.request<EquipMakeResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipMakeResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipLevelUpRequest(EquipPos c2s_equipPos,int c2s_mateType,Action<PomeloException,EquipLevelUpResponse> cb,object option = null)
		{
			var request = new EquipLevelUpRequest();
			request.c2s_equipPos= c2s_equipPos;
			request.c2s_mateType= c2s_mateType;
			_socket.request<EquipLevelUpResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipLevelUpResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipColorUpRequest(EquipPos c2s_equipPos,Action<PomeloException,EquipColorUpResponse> cb,object option = null)
		{
			var request = new EquipColorUpRequest();
			request.c2s_equipPos= c2s_equipPos;
			_socket.request<EquipColorUpResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipColorUpResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void fillGemRequest(int c2s_pos,int c2s_index,int c2s_gridIndex,Action<PomeloException,FillGemResponse> cb,object option = null)
		{
			var request = new FillGemRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_index= c2s_index;
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<FillGemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FillGemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void fillAllGemRequest(int c2s_pos,Action<PomeloException,FillAllGemResponse> cb,object option = null)
		{
			var request = new FillAllGemRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<FillAllGemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FillAllGemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void unFillGemRequest(int c2s_pos,int c2s_index,Action<PomeloException,UnFillGemResponse> cb,object option = null)
		{
			var request = new UnFillGemRequest();
			request.c2s_pos= c2s_pos;
			request.c2s_index= c2s_index;
			_socket.request<UnFillGemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnFillGemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void unFillAllGemRequest(int c2s_pos,Action<PomeloException,UnFillAllGemResponse> cb,object option = null)
		{
			var request = new UnFillAllGemRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<UnFillAllGemResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnFillAllGemResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSuitAttrRequest(Action<PomeloException,GetSuitAttrResponse> cb,object option = null)
		{
			var request = new GetSuitAttrRequest();
			_socket.request<GetSuitAttrResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSuitAttrResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getSuitDetailRequest(int c2s_suitType,Action<PomeloException,GetSuitDetailResponse> cb,object option = null)
		{
			var request = new GetSuitDetailRequest();
			request.c2s_suitType= c2s_suitType;
			_socket.request<GetSuitDetailResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetSuitDetailResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getInheritInfoRequest(EquipPos c2s_inheritEquip,EquipPos c2s_beiInheritEquip,Action<PomeloException,GetInheritInfoResponse> cb,object option = null)
		{
			var request = new GetInheritInfoRequest();
			request.c2s_inheritEquip= c2s_inheritEquip;
			request.c2s_beiInheritEquip= c2s_beiInheritEquip;
			_socket.request<GetInheritInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetInheritInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipInheritRequest(EquipPos c2s_inheritEquip,EquipPos c2s_beiInheritEquip,int c2s_magical,int c2s_jewel,int c2s_refine,int c2s_isAuto,Action<PomeloException,EquipInheritResponse> cb,object option = null)
		{
			var request = new EquipInheritRequest();
			request.c2s_inheritEquip= c2s_inheritEquip;
			request.c2s_beiInheritEquip= c2s_beiInheritEquip;
			request.c2s_magical= c2s_magical;
			request.c2s_jewel= c2s_jewel;
			request.c2s_refine= c2s_refine;
			request.c2s_isAuto= c2s_isAuto;
			_socket.request<EquipInheritResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipInheritResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipMeltRequest(List<int> c2s_indexs,Action<PomeloException,EquipMeltResponse> cb,object option = null)
		{
			var request = new EquipMeltRequest();
			request.c2s_indexs.AddRange(c2s_indexs);
			_socket.request<EquipMeltResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipMeltResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void chatEquipDetailRequest(string c2s_id,Action<PomeloException,ChatEquipDetailResponse> cb,object option = null)
		{
			var request = new ChatEquipDetailRequest();
			request.c2s_id= c2s_id;
			_socket.request<ChatEquipDetailResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChatEquipDetailResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipRebornRequest(string equipId,Action<PomeloException,EquipRebornResponse> cb,object option = null)
		{
			var request = new EquipRebornRequest();
			request.equipId= equipId;
			_socket.request<EquipRebornResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipRebornResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipRebuildRequest(string equipId,List<int> lockedAttId,Action<PomeloException,EquipRebuildResponse> cb,object option = null)
		{
			var request = new EquipRebuildRequest();
			request.equipId= equipId;
			request.lockedAttId.AddRange(lockedAttId);
			_socket.request<EquipRebuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipRebuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipSeniorRebuildRequest(string equipId,Action<PomeloException,EquipSeniorRebuildResponse> cb,object option = null)
		{
			var request = new EquipSeniorRebuildRequest();
			request.equipId= equipId;
			_socket.request<EquipSeniorRebuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipSeniorRebuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipRefineRequest(string equipId,string attrkey,Action<PomeloException,EquipRefineResponse> cb,object option = null)
		{
			var request = new EquipRefineRequest();
			request.equipId= equipId;
			request.attrkey= attrkey;
			_socket.request<EquipRefineResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipRefineResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipRefineLegendRequest(string equipId,string attrkey,Action<PomeloException,EquipRefineLegendResponse> cb,object option = null)
		{
			var request = new EquipRefineLegendRequest();
			request.equipId= equipId;
			request.attrkey= attrkey;
			_socket.request<EquipRefineLegendResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipRefineLegendResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveRebornRequest(string equipId,Action<PomeloException,SaveRebornResponse> cb,object option = null)
		{
			var request = new SaveRebornRequest();
			request.equipId= equipId;
			_socket.request<SaveRebornResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveRebornResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveRebuildRequest(string equipId,Action<PomeloException,SaveRebuildResponse> cb,object option = null)
		{
			var request = new SaveRebuildRequest();
			request.equipId= equipId;
			_socket.request<SaveRebuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveRebuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void smritiRequest(string letf_equipId,string right_equipId,Action<PomeloException,SmritiResponse> cb,object option = null)
		{
			var request = new SmritiRequest();
			request.letf_equipId= letf_equipId;
			request.right_equipId= right_equipId;
			_socket.request<SmritiResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SmritiResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveSeniorRebuildRequest(string equipId,Action<PomeloException,SaveSeniorRebuildResponse> cb,object option = null)
		{
			var request = new SaveSeniorRebuildRequest();
			request.equipId= equipId;
			_socket.request<SaveSeniorRebuildResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveSeniorRebuildResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveRefineRequest(string equipId,string attrkey,Action<PomeloException,SaveRefineResponse> cb,object option = null)
		{
			var request = new SaveRefineRequest();
			request.equipId= equipId;
			request.attrkey= attrkey;
			_socket.request<SaveRefineResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveRefineResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveRefineLegendRequest(string equipId,string attrkey,Action<PomeloException,SaveRefineLegendResponse> cb,object option = null)
		{
			var request = new SaveRefineLegendRequest();
			request.equipId= equipId;
			request.attrkey= attrkey;
			_socket.request<SaveRefineLegendResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveRefineLegendResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRefineExtPropRequest(string equipId,Action<PomeloException,GetRefineExtPropResponse> cb,object option = null)
		{
			var request = new GetRefineExtPropRequest();
			request.equipId= equipId;
			_socket.request<GetRefineExtPropResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRefineExtPropResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onEquipmentSimplePush(Action<EquipmentSimplePush> cb)
		{
			_socket.listen_once<EquipmentSimplePush>(cb);
		}
		public void onEquipInheritPush(Action<EquipInheritPush> cb)
		{
			_socket.listen_once<EquipInheritPush>(cb);
		}
		public void onEquipStrengthPosPush(Action<StrengthPosPush> cb)
		{
			_socket.listen_once<StrengthPosPush>(cb);
		}

	}


}