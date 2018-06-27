/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var LoginHandler = function(socket){
	this.socket = socket;
}

LoginHandler.prototype.loginRequest = async(function(appId,uid,token,channel,os,imei,version,channelUid){
	return await(this.socket.requestAsync('login.loginHandler.loginRequest',{appId:appId,uid:uid,token:token,channel:channel,os:os,imei:imei,version:version,channelUid:channelUid}));
});

LoginHandler.prototype.registerRequest = async(function(appId,account,password,channel,os,model,imei,version,tel){
	return await(this.socket.requestAsync('login.loginHandler.registerRequest',{appId:appId,account:account,password:password,channel:channel,os:os,model:model,imei:imei,version:version,tel:tel}));
});


LoginHandler.prototype.onServerStatePush = function(cb){
	this.socket.on('login.loginPush.serverStatePush',cb);
}

module.exports = LoginHandler;
