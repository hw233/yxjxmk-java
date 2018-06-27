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
	public class ResourceDungeonHandler
	{
		private PomeloClient _socket;

		public QueryResourceDugeonInfoResponse lastQueryResourceDugeonInfoResponse { get { return _socket.GetLastResponse<QueryResourceDugeonInfoResponse>(); } }
		public BuyTimesResponse lastBuyTimesResponse { get { return _socket.GetLastResponse<BuyTimesResponse>(); } }
		public EnterResourceDugeonInfoResponse lastEnterResourceDugeonInfoResponse { get { return _socket.GetLastResponse<EnterResourceDugeonInfoResponse>(); } }
		public ReceiveDoubleRewardResponse lastReceiveDoubleRewardResponse { get { return _socket.GetLastResponse<ReceiveDoubleRewardResponse>(); } }
		public ResourceCountDownResponse lastResourceCountDownResponse { get { return _socket.GetLastResponse<ResourceCountDownResponse>(); } }
		public ResourceSweepResponse lastResourceSweepResponse { get { return _socket.GetLastResponse<ResourceSweepResponse>(); } }
		static ResourceDungeonHandler()
		{
			EventTypes.RegistRequestType("area.resourceDungeonHandler.queryResourceDugeonInfoRequest", typeof(QueryResourceDugeonInfoRequest), typeof(QueryResourceDugeonInfoResponse));
			EventTypes.RegistRequestType("area.resourceDungeonHandler.buyTimesRequest", typeof(BuyTimesRequest), typeof(BuyTimesResponse));
			EventTypes.RegistRequestType("area.resourceDungeonHandler.enterResourceDugeonInfoRequest", typeof(EnterResourceDugeonInfoRequest), typeof(EnterResourceDugeonInfoResponse));
			EventTypes.RegistRequestType("area.resourceDungeonHandler.receiveDoubleRewardRequest", typeof(ReceiveDoubleRewardRequest), typeof(ReceiveDoubleRewardResponse));
			EventTypes.RegistRequestType("area.resourceDungeonHandler.resourceCountDownRequest", typeof(ResourceCountDownRequest), typeof(ResourceCountDownResponse));
			EventTypes.RegistRequestType("area.resourceDungeonHandler.resourceSweepRequest", typeof(ResourceSweepRequest), typeof(ResourceSweepResponse));
		}
		public ResourceDungeonHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void queryResourceDugeonInfoRequest(Action<PomeloException,QueryResourceDugeonInfoResponse> cb,object option = null)
		{
			var request = new QueryResourceDugeonInfoRequest();
			_socket.request<QueryResourceDugeonInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QueryResourceDugeonInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void buyTimesRequest(int dungeonId,Action<PomeloException,BuyTimesResponse> cb,object option = null)
		{
			var request = new BuyTimesRequest();
			request.dungeonId= dungeonId;
			_socket.request<BuyTimesResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as BuyTimesResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void enterResourceDugeonInfoRequest(int dungeonId,Action<PomeloException,EnterResourceDugeonInfoResponse> cb,object option = null)
		{
			var request = new EnterResourceDugeonInfoRequest();
			request.dungeonId= dungeonId;
			_socket.request<EnterResourceDugeonInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EnterResourceDugeonInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void receiveDoubleRewardRequest(int dungeonId,Action<PomeloException,ReceiveDoubleRewardResponse> cb,object option = null)
		{
			var request = new ReceiveDoubleRewardRequest();
			request.dungeonId= dungeonId;
			_socket.request<ReceiveDoubleRewardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReceiveDoubleRewardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void resourceCountDownRequest(int dungeonId,Action<PomeloException,ResourceCountDownResponse> cb,object option = null)
		{
			var request = new ResourceCountDownRequest();
			request.dungeonId= dungeonId;
			_socket.request<ResourceCountDownResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ResourceCountDownResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void resourceSweepRequest(int dungeonId,Action<PomeloException,ResourceSweepResponse> cb,object option = null)
		{
			var request = new ResourceSweepRequest();
			request.dungeonId= dungeonId;
			_socket.request<ResourceSweepResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ResourceSweepResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}