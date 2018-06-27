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
	public class MasteryHandler
	{
		private PomeloClient _socket;

		public GetMasteryInfoResponse lastGetMasteryInfoResponse { get { return _socket.GetLastResponse<GetMasteryInfoResponse>(); } }
		public ActiveMasteryResponse lastActiveMasteryResponse { get { return _socket.GetLastResponse<ActiveMasteryResponse>(); } }
		public GetRingResponse lastGetRingResponse { get { return _socket.GetLastResponse<GetRingResponse>(); } }
		public MasteryRingResponse lastMasteryRingResponse { get { return _socket.GetLastResponse<MasteryRingResponse>(); } }
		public MasteryDeliverResponse lastMasteryDeliverResponse { get { return _socket.GetLastResponse<MasteryDeliverResponse>(); } }
		static MasteryHandler()
		{
			EventTypes.RegistRequestType("area.masteryHandler.getMasteryInfoRequest", typeof(GetMasteryInfoRequest), typeof(GetMasteryInfoResponse));
			EventTypes.RegistRequestType("area.masteryHandler.activeMasteryRequest", typeof(ActiveMasteryRequest), typeof(ActiveMasteryResponse));
			EventTypes.RegistRequestType("area.masteryHandler.getRingRequest", typeof(GetRingRequest), typeof(GetRingResponse));
			EventTypes.RegistRequestType("area.masteryHandler.masteryRingRequest", typeof(MasteryRingRequest), typeof(MasteryRingResponse));
			EventTypes.RegistRequestType("area.masteryHandler.masteryDeliverRequest", typeof(MasteryDeliverRequest), typeof(MasteryDeliverResponse));
		}
		public MasteryHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getMasteryInfoRequest(Action<PomeloException,GetMasteryInfoResponse> cb,object option = null)
		{
			var request = new GetMasteryInfoRequest();
			_socket.request<GetMasteryInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetMasteryInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activeMasteryRequest(int c2s_pos,Action<PomeloException,ActiveMasteryResponse> cb,object option = null)
		{
			var request = new ActiveMasteryRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<ActiveMasteryResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActiveMasteryResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getRingRequest(string c2s_ringId,Action<PomeloException,GetRingResponse> cb,object option = null)
		{
			var request = new GetRingRequest();
			request.c2s_ringId= c2s_ringId;
			_socket.request<GetRingResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetRingResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void masteryRingRequest(Action<PomeloException,MasteryRingResponse> cb,object option = null)
		{
			var request = new MasteryRingRequest();
			_socket.request<MasteryRingResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MasteryRingResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void masteryDeliverRequest(int c2s_pos,Action<PomeloException,MasteryDeliverResponse> cb,object option = null)
		{
			var request = new MasteryDeliverRequest();
			request.c2s_pos= c2s_pos;
			_socket.request<MasteryDeliverResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as MasteryDeliverResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}