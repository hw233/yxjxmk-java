/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ArenaHandler = function(socket){
	this.socket = socket;
}

ArenaHandler.prototype.arenaInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.arenaHandler.arenaInfoRequest',{}));
});

ArenaHandler.prototype.enterArenaAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.arenaHandler.enterArenaAreaRequest',{}));
});

ArenaHandler.prototype.leaveArenaAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.arenaHandler.leaveArenaAreaRequest',{}));
});

ArenaHandler.prototype.arenaRewardRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.arenaHandler.arenaRewardRequest',{c2s_type:c2s_type}));
});


ArenaHandler.prototype.onOnArenaBattleInfoPush = function(cb){
	this.socket.on('area.arenaPush.onArenaBattleInfoPush',cb);
}

ArenaHandler.prototype.onOnArenaBattleEndPush = function(cb){
	this.socket.on('area.arenaPush.onArenaBattleEndPush',cb);
}

module.exports = ArenaHandler;
