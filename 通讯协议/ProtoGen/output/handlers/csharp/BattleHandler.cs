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
	public class BattleHandler
	{
		private PomeloClient _socket;

		public ThrowPointResponse lastThrowPointResponse { get { return _socket.GetLastResponse<ThrowPointResponse>(); } }
		static BattleHandler()
		{
			EventTypes.RegistPushType("area.battlePush.throwPointItemListPush", typeof(ThrowPointItemListPush));
			EventTypes.RegistPushType("area.battlePush.throwPointResultPush", typeof(ThrowPointResultPush));
			EventTypes.RegistPushType("area.battlePush.fightLevelResultPush", typeof(FightLevelResultPush));
			EventTypes.RegistPushType("area.battlePush.itemDropPush", typeof(ItemDropPush));
			EventTypes.RegistPushType("area.battlePush.sceneNamePush", typeof(SceneNamePush));
			EventTypes.RegistPushType("area.battlePush.resourceDungeonResultPush", typeof(ResourceDungeonResultPush));
			EventTypes.RegistRequestType("area.battleHandler.throwPointRequest", typeof(ThrowPointRequest), typeof(ThrowPointResponse));
		}
		public BattleHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void throwPointRequest(string id,Action<PomeloException,ThrowPointResponse> cb,object option = null)
		{
			var request = new ThrowPointRequest();
			request.id= id;
			_socket.request<ThrowPointResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ThrowPointResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void onThrowPointItemListPush(Action<ThrowPointItemListPush> cb)
		{
			_socket.listen_once<ThrowPointItemListPush>(cb);
		}
		public void onThrowPointResultPush(Action<ThrowPointResultPush> cb)
		{
			_socket.listen_once<ThrowPointResultPush>(cb);
		}
		public void onFightLevelResultPush(Action<FightLevelResultPush> cb)
		{
			_socket.listen_once<FightLevelResultPush>(cb);
		}
		public void onItemDropPush(Action<ItemDropPush> cb)
		{
			_socket.listen_once<ItemDropPush>(cb);
		}
		public void onSceneNamePush(Action<SceneNamePush> cb)
		{
			_socket.listen_once<SceneNamePush>(cb);
		}
		public void onResourceDungeonResultPush(Action<ResourceDungeonResultPush> cb)
		{
			_socket.listen_once<ResourceDungeonResultPush>(cb);
		}

	}


}