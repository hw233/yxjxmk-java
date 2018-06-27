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
	public class WingHandler
	{
		private PomeloClient _socket;

		public GetWingInfoResponse lastGetWingInfoResponse { get { return _socket.GetLastResponse<GetWingInfoResponse>(); } }
		public TrainingWingResponse lastTrainingWingResponse { get { return _socket.GetLastResponse<TrainingWingResponse>(); } }
		static WingHandler()
		{
			EventTypes.RegistRequestType("area.wingHandler.getWingInfoRequest", typeof(GetWingInfoRequest), typeof(GetWingInfoResponse));
			EventTypes.RegistRequestType("area.wingHandler.trainingWingRequest", typeof(TrainingWingRequest), typeof(TrainingWingResponse));
			EventTypes.RegistNotifyType("area.wingHandler.saveWingNotify", typeof(SaveWingNotify));
		}
		public WingHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getWingInfoRequest(Action<PomeloException,GetWingInfoResponse> cb,object option = null)
		{
			var request = new GetWingInfoRequest();
			_socket.request<GetWingInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetWingInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void trainingWingRequest(int c2s_type,Action<PomeloException,TrainingWingResponse> cb,object option = null)
		{
			var request = new TrainingWingRequest();
			request.c2s_type= c2s_type;
			_socket.request<TrainingWingResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TrainingWingResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void saveWingNotify(int c2s_wingLevel)
		{
			var notify = new SaveWingNotify();
			notify.c2s_wingLevel= c2s_wingLevel;

			_socket.notify(notify);

		}

	}


}