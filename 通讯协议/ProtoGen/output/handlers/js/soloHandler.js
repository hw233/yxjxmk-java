/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var SoloHandler = function(socket){
	this.socket = socket;
}

SoloHandler.prototype.soloInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.soloInfoRequest',{}));
});

SoloHandler.prototype.rewardInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.rewardInfoRequest',{}));
});

SoloHandler.prototype.drawRankRewardRequest = async(function(c2s_rankId){
	return await(this.socket.requestAsync('area.soloHandler.drawRankRewardRequest',{c2s_rankId:c2s_rankId}));
});

SoloHandler.prototype.drawDailyRewardRequest = async(function(c2s_index){
	return await(this.socket.requestAsync('area.soloHandler.drawDailyRewardRequest',{c2s_index:c2s_index}));
});

SoloHandler.prototype.joinSoloRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.joinSoloRequest',{}));
});

SoloHandler.prototype.joinSoloBattleRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.joinSoloBattleRequest',{}));
});

SoloHandler.prototype.quitSoloRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.quitSoloRequest',{}));
});

SoloHandler.prototype.queryRewardRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.queryRewardRequest',{}));
});

SoloHandler.prototype.leaveSoloAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.leaveSoloAreaRequest',{}));
});

SoloHandler.prototype.newsInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.newsInfoRequest',{}));
});

SoloHandler.prototype.battleRecordRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.battleRecordRequest',{}));
});

SoloHandler.prototype.getRivalInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.soloHandler.getRivalInfoRequest',{}));
});


SoloHandler.prototype.onOnSoloMatchedPush = function(cb){
	this.socket.on('area.soloPush.onSoloMatchedPush',cb);
}

SoloHandler.prototype.onOnNewRewardPush = function(cb){
	this.socket.on('area.soloPush.onNewRewardPush',cb);
}

SoloHandler.prototype.onOnFightPointPush = function(cb){
	this.socket.on('area.soloPush.onFightPointPush',cb);
}

SoloHandler.prototype.onOnRoundEndPush = function(cb){
	this.socket.on('area.soloPush.onRoundEndPush',cb);
}

SoloHandler.prototype.onOnGameEndPush = function(cb){
	this.socket.on('area.soloPush.onGameEndPush',cb);
}

SoloHandler.prototype.onLeftSoloTimePush = function(cb){
	this.socket.on('area.soloPush.leftSoloTimePush',cb);
}

SoloHandler.prototype.onCancelMatchPush = function(cb){
	this.socket.on('area.soloPush.cancelMatchPush',cb);
}

module.exports = SoloHandler;
