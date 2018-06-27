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
	public class VitalityHandler
	{
		private PomeloClient _socket;

		public GetVitalityListResponse lastGetVitalityListResponse { get { return _socket.GetLastResponse<GetVitalityListResponse>(); } }
		public GetVitalityRewardResponse lastGetVitalityRewardResponse { get { return _socket.GetLastResponse<GetVitalityRewardResponse>(); } }
		public GetRecommendPlayListResponse lastGetRecommendPlayListResponse { get { return _socket.GetLastResponse<GetRecommendPlayListResponse>(); } }
		static VitalityHandler()
		{
			EventTypes.RegistRequestType("area.vitalityHandler.getVitalityListRequest", typeof(GetVitalityListRequest), typeof(GetVitalityListResponse));
			EventTypes.RegistRequestType("area.vitalityHandler.getVitalityRewardRequest", typeof(GetVitalityRewardRequest), typeof(GetVitalityRewardResponse));
			EventTypes.RegistRequestType("area.vitalityHandler.getRecommendPlayListRequest", typeof(GetRecommendPlayListRequest), typeof(GetRecommendPlayListResponse));
		}
		public VitalityHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getVitalityListRequest(Action<PomeloException,GetVitalityListResponse> cb,object option = null)
		{
			var request = new GetVitalityListRequest();
			_socket.request<GetVitalityListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetVitalityListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getVitalityRewardRequest(int c2s_rewardId,Action<PomeloException,GetVitalityRewardResponse> cb,object option = null)
		{
			var request = new GetVitalityRewardRequest();
			request.c2s_rewardId= c2s_rewardId;
			_socket.request<GetVitalityRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetVitalityRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRecommendPlayListRequest(Action<PomeloException,GetRecommendPlayListResponse> cb,object option = null)
		{
			var request = new GetRecommendPlayListRequest();
			_socket.request<GetRecommendPlayListResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRecommendPlayListResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}