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
	public class AchievementHandler
	{
		private PomeloClient _socket;

		public AchievementGetTypeElementResponse lastAchievementGetTypeElementResponse { get { return _socket.GetLastResponse<AchievementGetTypeElementResponse>(); } }
		public AchievementGetAwardResponse lastAchievementGetAwardResponse { get { return _socket.GetLastResponse<AchievementGetAwardResponse>(); } }
		public GetHolyArmorsResponse lastGetHolyArmorsResponse { get { return _socket.GetLastResponse<GetHolyArmorsResponse>(); } }
		public ActivateHolyArmorResponse lastActivateHolyArmorResponse { get { return _socket.GetLastResponse<ActivateHolyArmorResponse>(); } }
		static AchievementHandler()
		{
			EventTypes.RegistPushType("area.achievementPush.onAchievementPush", typeof(OnAchievementPush));
			EventTypes.RegistRequestType("area.achievementHandler.achievementGetTypeElementRequest", typeof(AchievementGetTypeElementRequest), typeof(AchievementGetTypeElementResponse));
			EventTypes.RegistRequestType("area.achievementHandler.achievementGetAwardRequest", typeof(AchievementGetAwardRequest), typeof(AchievementGetAwardResponse));
			EventTypes.RegistRequestType("area.achievementHandler.getHolyArmorsRequest", typeof(GetHolyArmorsRequest), typeof(GetHolyArmorsResponse));
			EventTypes.RegistRequestType("area.achievementHandler.activateHolyArmorRequest", typeof(ActivateHolyArmorRequest), typeof(ActivateHolyArmorResponse));
		}
		public AchievementHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void achievementGetTypeElementRequest(int c2s_id,Action<PomeloException,AchievementGetTypeElementResponse> cb,object option = null)
		{
			var request = new AchievementGetTypeElementRequest();
			request.c2s_id= c2s_id;
			_socket.request<AchievementGetTypeElementResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AchievementGetTypeElementResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void achievementGetAwardRequest(int c2s_id,int c2s_type,Action<PomeloException,AchievementGetAwardResponse> cb,object option = null)
		{
			var request = new AchievementGetAwardRequest();
			request.c2s_id= c2s_id;
			request.c2s_type= c2s_type;
			_socket.request<AchievementGetAwardResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AchievementGetAwardResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getHolyArmorsRequest(Action<PomeloException,GetHolyArmorsResponse> cb,object option = null)
		{
			var request = new GetHolyArmorsRequest();
			_socket.request<GetHolyArmorsResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetHolyArmorsResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void activateHolyArmorRequest(int id,Action<PomeloException,ActivateHolyArmorResponse> cb,object option = null)
		{
			var request = new ActivateHolyArmorRequest();
			request.id= id;
			_socket.request<ActivateHolyArmorResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ActivateHolyArmorResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onAchievementPush(Action<OnAchievementPush> cb)
		{
			_socket.listen_once<OnAchievementPush>(cb);
		}

	}


}