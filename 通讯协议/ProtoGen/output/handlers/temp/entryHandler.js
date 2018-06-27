/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var EntryHandler = function(socket){
	this.socket = socket;
}

EntryHandler.prototype.entryRequest = async(function(c2s_uid,c2s_token,c2s_logicServerId,c2s_deviceMac,c2s_deviceType,c2s_clientRegion,c2s_clientChannel,c2s_clientVersion){
	return await(this.socket.requestAsync('connector.entryHandler.entryRequest',{c2s_uid:c2s_uid,c2s_token:c2s_token,c2s_logicServerId:c2s_logicServerId,c2s_deviceMac:c2s_deviceMac,c2s_deviceType:c2s_deviceType,c2s_clientRegion:c2s_clientRegion,c2s_clientChannel:c2s_clientChannel,c2s_clientVersion:c2s_clientVersion}));
});

EntryHandler.prototype.bindPlayerRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('connector.entryHandler.bindPlayerRequest',{c2s_playerId:c2s_playerId}));
});

EntryHandler.prototype.getSysTimeRequest = async(function(){
	return await(this.socket.requestAsync('connector.entryHandler.getSysTimeRequest',{}));
});


EntryHandler.prototype.onLoginQueuePush = function(cb){
	this.socket.on('connector.entryPush.loginQueuePush',cb);
}

module.exports = EntryHandler;
