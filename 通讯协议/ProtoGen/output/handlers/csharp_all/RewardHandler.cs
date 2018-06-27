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
	public class RewardHandler
	{
		private PomeloClient _socket;

		public RewardDeskResponse lastRewardDeskResponse { get { return _socket.GetLastResponse<RewardDeskResponse>(); } }
		public RewardResponse lastRewardResponse { get { return _socket.GetLastResponse<RewardResponse>(); } }
		public CheckBountyResponse lastCheckBountyResponse { get { return _socket.GetLastResponse<CheckBountyResponse>(); } }
		public FinishRewardResponse lastFinishRewardResponse { get { return _socket.GetLastResponse<FinishRewardResponse>(); } }
		public GetAwardBountyResponse lastGetAwardBountyResponse { get { return _socket.GetLastResponse<GetAwardBountyResponse>(); } }
		static RewardHandler()
		{
			EventTypes.RegistRequestType("area.rewardHandler.rewardDeskRequest", typeof(RewardDeskRequest), typeof(RewardDeskResponse));
			EventTypes.RegistRequestType("area.rewardHandler.rewardRequest", typeof(RewardRequest), typeof(RewardResponse));
			EventTypes.RegistRequestType("area.rewardHandler.checkBountyRequest", typeof(CheckBountyRequest), typeof(CheckBountyResponse));
			EventTypes.RegistRequestType("area.rewardHandler.getHasFinishRequest", typeof(FinishRewardRequest), typeof(FinishRewardResponse));
			EventTypes.RegistRequestType("area.rewardHandler.getAwardBountyRequest", typeof(GetAwardBountyRequest), typeof(GetAwardBountyResponse));
		}
		public RewardHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void rewardDeskRequest(Action<PomeloException,RewardDeskResponse> cb,object option = null)
		{
			var request = new RewardDeskRequest();
			_socket.request<RewardDeskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RewardDeskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void rewardRequest(string c2s_playerName,Action<PomeloException,RewardResponse> cb,object option = null)
		{
			var request = new RewardRequest();
			request.c2s_playerName= c2s_playerName;
			_socket.request<RewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void checkBountyRequest(int c2s_index,Action<PomeloException,CheckBountyResponse> cb,object option = null)
		{
			var request = new CheckBountyRequest();
			request.c2s_index= c2s_index;
			_socket.request<CheckBountyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as CheckBountyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getHasFinishRequest(Action<PomeloException,FinishRewardResponse> cb,object option = null)
		{
			var request = new FinishRewardRequest();
			_socket.request<FinishRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as FinishRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getAwardBountyRequest(string c2s_preyId,string c2s_hunterId,int c2s_bounty,Action<PomeloException,GetAwardBountyResponse> cb,object option = null)
		{
			var request = new GetAwardBountyRequest();
			request.c2s_preyId= c2s_preyId;
			request.c2s_hunterId= c2s_hunterId;
			request.c2s_bounty= c2s_bounty;
			_socket.request<GetAwardBountyResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAwardBountyResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}