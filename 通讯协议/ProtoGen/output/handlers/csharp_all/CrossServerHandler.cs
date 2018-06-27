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
	public class CrossServerHandler
	{
		private PomeloClient _socket;

		static CrossServerHandler()
		{
			EventTypes.RegistPushType("area.crossServerPush.treasureOpenPush", typeof(TreasureOpenPush));
		}
		public CrossServerHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void onTreasureOpenPush(Action<TreasureOpenPush> cb)
		{
			_socket.listen_once<TreasureOpenPush>(cb);
		}

	}


}