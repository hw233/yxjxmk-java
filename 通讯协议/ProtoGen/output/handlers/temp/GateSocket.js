/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var util = require('util');
var Socket = require('Xmds-csharp').Socket;

var GateHandler = require('./gateHandler');
var LoginHandler = require('./loginHandler');

var GateSocket = function(protoPath){
	Socket.call(this,protoPath);
	this.gateHandler = new GateHandler(this);
	this.loginHandler = new LoginHandler(this);
}


util.inherits(GateSocket, Socket);


GateSocket.prototype.onServerStatePush = function(cb){
	this.on('login.loginPush.serverStatePush',cb);
}

module.exports = GateSocket;
