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
	public class AmuletHandler
	{
		private PomeloClient _socket;

		public GetAllAmuletDetailRes lastGetAllAmuletDetailRes { get { return _socket.GetLastResponse<GetAllAmuletDetailRes>(); } }
		public EquipAmuletRes lastEquipAmuletRes { get { return _socket.GetLastResponse<EquipAmuletRes>(); } }
		public UnEquipAmuletRes lastUnEquipAmuletRes { get { return _socket.GetLastResponse<UnEquipAmuletRes>(); } }
		public UnAllEquipAmuletRes lastUnAllEquipAmuletRes { get { return _socket.GetLastResponse<UnAllEquipAmuletRes>(); } }
		static AmuletHandler()
		{
			EventTypes.RegistPushType("area.amuletPush.amuletEquipNewPush", typeof(AmuletEquipNewPush));
			EventTypes.RegistRequestType("area.amuletHandler.getAllAmuletRequest", typeof(GetAllAmuletDetailReq), typeof(GetAllAmuletDetailRes));
			EventTypes.RegistRequestType("area.amuletHandler.equipAmuletRequest", typeof(EquipAmuletReq), typeof(EquipAmuletRes));
			EventTypes.RegistRequestType("area.amuletHandler.unEquipAmuletRequest", typeof(UnEquipAmuletReq), typeof(UnEquipAmuletRes));
			EventTypes.RegistRequestType("area.amuletHandler.unAllEquipAmuletRequest", typeof(UnAllEquipAmuletReq), typeof(UnAllEquipAmuletRes));
		}
		public AmuletHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void getAllAmuletRequest(Action<PomeloException,GetAllAmuletDetailRes> cb,object option = null)
		{
			var request = new GetAllAmuletDetailReq();
			_socket.request<GetAllAmuletDetailRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetAllAmuletDetailRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void equipAmuletRequest(int c2s_gridIndex,Action<PomeloException,EquipAmuletRes> cb,object option = null)
		{
			var request = new EquipAmuletReq();
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<EquipAmuletRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as EquipAmuletRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void unEquipAmuletRequest(string c2s_gridIndex,Action<PomeloException,UnEquipAmuletRes> cb,object option = null)
		{
			var request = new UnEquipAmuletReq();
			request.c2s_gridIndex= c2s_gridIndex;
			_socket.request<UnEquipAmuletRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnEquipAmuletRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void unAllEquipAmuletRequest(Action<PomeloException,UnAllEquipAmuletRes> cb,object option = null)
		{
			var request = new UnAllEquipAmuletReq();
			_socket.request<UnAllEquipAmuletRes>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UnAllEquipAmuletRes;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onAmuletEquipNewPush(Action<AmuletEquipNewPush> cb)
		{
			_socket.listen_once<AmuletEquipNewPush>(cb);
		}

	}


}