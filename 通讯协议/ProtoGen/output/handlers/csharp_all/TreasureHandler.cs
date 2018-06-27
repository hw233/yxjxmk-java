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
	public class TreasureHandler
	{
		private PomeloClient _socket;

		public GetTreasureInfoResponse lastGetTreasureInfoResponse { get { return _socket.GetLastResponse<GetTreasureInfoResponse>(); } }
		public GetTreasureBagInfoResponse lastGetTreasureBagInfoResponse { get { return _socket.GetLastResponse<GetTreasureBagInfoResponse>(); } }
		public OpenTreasureResponse lastOpenTreasureResponse { get { return _socket.GetLastResponse<OpenTreasureResponse>(); } }
		public ReceiveTreasureBagResponse lastReceiveTreasureBagResponse { get { return _socket.GetLastResponse<ReceiveTreasureBagResponse>(); } }
		static TreasureHandler()
		{
			EventTypes.RegistRequestType("area.treasureHandler.getTreasureInfoRequest", typeof(GetTreasureInfoRequest), typeof(GetTreasureInfoResponse));
			EventTypes.RegistRequestType("area.treasureHandler.getTreasureBagInfoRequest", typeof(GetTreasureBagInfoRequest), typeof(GetTreasureBagInfoResponse));
			EventTypes.RegistRequestType("area.treasureHandler.openTreasureRequest", typeof(OpenTreasureRequest), typeof(OpenTreasureResponse));
			EventTypes.RegistRequestType("area.treasureHandler.receiveTreasureBagRequest", typeof(ReceiveTreasureBagRequest), typeof(ReceiveTreasureBagResponse));
		}
		public TreasureHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getTreasureInfoRequest(int c2s_treasureMsg,Action<PomeloException,GetTreasureInfoResponse> cb,object option = null)
		{
			var request = new GetTreasureInfoRequest();
			request.c2s_treasureMsg= c2s_treasureMsg;
			_socket.request<GetTreasureInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetTreasureInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getTreasureBagInfoRequest(Action<PomeloException,GetTreasureBagInfoResponse> cb,object option = null)
		{
			var request = new GetTreasureBagInfoRequest();
			_socket.request<GetTreasureBagInfoResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetTreasureBagInfoResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void openTreasureRequest(OpenType c2s_openType,int c2s_useDiamond,Action<PomeloException,OpenTreasureResponse> cb,object option = null)
		{
			var request = new OpenTreasureRequest();
			request.c2s_openType= c2s_openType;
			request.c2s_useDiamond= c2s_useDiamond;
			_socket.request<OpenTreasureResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as OpenTreasureResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void receiveTreasureBagRequest(Action<PomeloException,ReceiveTreasureBagResponse> cb,object option = null)
		{
			var request = new ReceiveTreasureBagRequest();
			_socket.request<ReceiveTreasureBagResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReceiveTreasureBagResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}

	}


}