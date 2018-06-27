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
	public class FashionHandler
	{
		private PomeloClient _socket;

		public EquipFashionResponse lastEquipFashionResponse { get { return _socket.GetLastResponse<EquipFashionResponse>(); } }
		public GetFashionsResponse lastGetFashionsResponse { get { return _socket.GetLastResponse<GetFashionsResponse>(); } }
		static FashionHandler()
		{
			EventTypes.RegistPushType("area.fashionPush.onFashionGetPush", typeof(FashionGetPush));
			EventTypes.RegistRequestType("area.fashionHandler.equipFashionRequest", typeof(EquipFashionRequest), typeof(EquipFashionResponse));
			EventTypes.RegistRequestType("area.fashionHandler.getFashionsRequest", typeof(GetFashionsRequest), typeof(GetFashionsResponse));
		}
		public FashionHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void equipFashionRequest(string code,bool ison,Action<PomeloException,EquipFashionResponse> cb,object option = null)
		{
			var request = new EquipFashionRequest();
			request.code= code;
			request.ison= ison;
			_socket.request<EquipFashionResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipFashionResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getFashionsRequest(Action<PomeloException,GetFashionsResponse> cb,object option = null)
		{
			var request = new GetFashionsRequest();
			_socket.request<GetFashionsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetFashionsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onFashionGetPush(Action<FashionGetPush> cb)
		{
			_socket.listen_once<FashionGetPush>(cb);
		}

	}


}