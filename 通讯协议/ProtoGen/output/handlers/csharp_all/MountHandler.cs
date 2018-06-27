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
	public class MountHandler
	{
		private PomeloClient _socket;

		public ActiveMountSkinResponse lastActiveMountSkinResponse { get { return _socket.GetLastResponse<ActiveMountSkinResponse>(); } }
		public SaveMountResponse lastSaveMountResponse { get { return _socket.GetLastResponse<SaveMountResponse>(); } }
		public UpMountStageResponse lastUpMountStageResponse { get { return _socket.GetLastResponse<UpMountStageResponse>(); } }
		public GetMountInfoResponse lastGetMountInfoResponse { get { return _socket.GetLastResponse<GetMountInfoResponse>(); } }
		public TrainingMountResponse lastTrainingMountResponse { get { return _socket.GetLastResponse<TrainingMountResponse>(); } }
		public RidingMountResponse lastRidingMountResponse { get { return _socket.GetLastResponse<RidingMountResponse>(); } }
		public OneKeyTrainingResponse lastOneKeyTrainingResponse { get { return _socket.GetLastResponse<OneKeyTrainingResponse>(); } }
		public ChooseFirstSkinResponse lastChooseFirstSkinResponse { get { return _socket.GetLastResponse<ChooseFirstSkinResponse>(); } }
		static MountHandler()
		{
			EventTypes.RegistPushType("area.mountPush.mountFlagPush", typeof(MountFlagPush));
			EventTypes.RegistPushType("area.mountPush.mountNewSkinPush", typeof(MountNewSkinPush));
			EventTypes.RegistRequestType("area.mountHandler.activeMountSkinRequest", typeof(ActiveMountSkinRequest), typeof(ActiveMountSkinResponse));
			EventTypes.RegistRequestType("area.mountHandler.saveMountRequest", typeof(SaveMountRequest), typeof(SaveMountResponse));
			EventTypes.RegistRequestType("area.mountHandler.upMountStageRequest", typeof(UpMountStageRequest), typeof(UpMountStageResponse));
			EventTypes.RegistRequestType("area.mountHandler.getMountInfoRequest", typeof(GetMountInfoRequest), typeof(GetMountInfoResponse));
			EventTypes.RegistRequestType("area.mountHandler.trainingMountRequest", typeof(TrainingMountRequest), typeof(TrainingMountResponse));
			EventTypes.RegistRequestType("area.mountHandler.ridingMountRequest", typeof(RidingMountRequest), typeof(RidingMountResponse));
			EventTypes.RegistRequestType("area.mountHandler.oneKeyTrainingRequest", typeof(OneKeyTrainingRequest), typeof(OneKeyTrainingResponse));
			EventTypes.RegistRequestType("area.mountHandler.chooseFirstSkinRequest", typeof(ChooseFirstSkinRequest), typeof(ChooseFirstSkinResponse));
		}
		public MountHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void activeMountSkinRequest(int c2s_skinId,Action<PomeloException,ActiveMountSkinResponse> cb,object option = null)
		{
			var request = new ActiveMountSkinRequest();
			request.c2s_skinId= c2s_skinId;
			_socket.request<ActiveMountSkinResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActiveMountSkinResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveMountRequest(int c2s_mountId,int c2s_skinId,Action<PomeloException,SaveMountResponse> cb,object option = null)
		{
			var request = new SaveMountRequest();
			request.c2s_mountId= c2s_mountId;
			request.c2s_skinId= c2s_skinId;
			_socket.request<SaveMountResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SaveMountResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void upMountStageRequest(Action<PomeloException,UpMountStageResponse> cb,object option = null)
		{
			var request = new UpMountStageRequest();
			_socket.request<UpMountStageResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpMountStageResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getMountInfoRequest(Action<PomeloException,GetMountInfoResponse> cb,object option = null)
		{
			var request = new GetMountInfoRequest();
			_socket.request<GetMountInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMountInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void trainingMountRequest(int c2s_type,Action<PomeloException,TrainingMountResponse> cb,object option = null)
		{
			var request = new TrainingMountRequest();
			request.c2s_type= c2s_type;
			_socket.request<TrainingMountResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TrainingMountResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void ridingMountRequest(int c2s_isUp,Action<PomeloException,RidingMountResponse> cb,object option = null)
		{
			var request = new RidingMountRequest();
			request.c2s_isUp= c2s_isUp;
			_socket.request<RidingMountResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RidingMountResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void oneKeyTrainingRequest(Action<PomeloException,OneKeyTrainingResponse> cb,object option = null)
		{
			var request = new OneKeyTrainingRequest();
			_socket.request<OneKeyTrainingResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OneKeyTrainingResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void chooseFirstSkinRequest(int c2s_skinId,Action<PomeloException,ChooseFirstSkinResponse> cb,object option = null)
		{
			var request = new ChooseFirstSkinRequest();
			request.c2s_skinId= c2s_skinId;
			_socket.request<ChooseFirstSkinResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ChooseFirstSkinResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onMountFlagPush(Action<MountFlagPush> cb)
		{
			_socket.listen_once<MountFlagPush>(cb);
		}
		public void onMountNewSkinPush(Action<MountNewSkinPush> cb)
		{
			_socket.listen_once<MountNewSkinPush>(cb);
		}

	}


}