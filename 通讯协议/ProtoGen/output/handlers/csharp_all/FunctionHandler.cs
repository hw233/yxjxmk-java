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
	public class FunctionHandler
	{
		private PomeloClient _socket;

		static FunctionHandler()
		{
			EventTypes.RegistPushType("area.functionPush.functionGoToPush", typeof(FunctionGoToPush));
			EventTypes.RegistPushType("area.functionPush.taskGuideFuncPush", typeof(TaskGuideFuncPush));
		}
		public FunctionHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void onFunctionGoToPush(Action<FunctionGoToPush> cb)
		{
			_socket.listen_once<FunctionGoToPush>(cb);
		}
		public void onTaskGuideFuncPush(Action<TaskGuideFuncPush> cb)
		{
			_socket.listen_once<TaskGuideFuncPush>(cb);
		}

	}


}