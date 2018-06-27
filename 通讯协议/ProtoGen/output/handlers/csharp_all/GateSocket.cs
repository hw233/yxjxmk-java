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
using pomelo.gate;
using pomelo.login;

namespace Pomelo.DotNetClient
{
	public class GateSocket : PomeloClient
	{
		private GateHandler _gateHandler;
		private LoginHandler _loginHandler;

		public GateHandler gateHandler
		{
			get { return _gateHandler;}
			set { _gateHandler = value; }
		}

		public LoginHandler loginHandler
		{
			get { return _loginHandler;}
			set { _loginHandler = value; }
		}

		public GateSocket(ISerializer serializer) : base(serializer)
		{
			_gateHandler = new GateHandler(this);
			_loginHandler = new LoginHandler(this);

		}
		public void onServerStatePush(Action<ServerStatePush> cb)
		{
			_loginHandler.onServerStatePush(cb);

		}

	}


}