/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var InteractHandler = function(socket){
	this.socket = socket;
}

InteractHandler.prototype.interactRequest = async(function(c2s_id,c2s_playerId,c2s_playerName){
	return await(this.socket.requestAsync('area.interactHandler.interactRequest',{c2s_id:c2s_id,c2s_playerId:c2s_playerId,c2s_playerName:c2s_playerName}));
});

InteractHandler.prototype.interactConfigRequest = async(function(){
	return await(this.socket.requestAsync('area.interactHandler.interactConfigRequest',{}));
});

InteractHandler.prototype.interactTimesRequest = async(function(){
	return await(this.socket.requestAsync('area.interactHandler.interactTimesRequest',{}));
});


InteractHandler.prototype.onReceiveInteractPush = function(cb){
	this.socket.on('area.interactPush.receiveInteractPush',cb);
}

module.exports = InteractHandler;
