/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var Five2FiveHandler = function(socket){
	this.socket = socket;
}

Five2FiveHandler.prototype.five2FiveRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveRequest',{}));
});

Five2FiveHandler.prototype.five2FiveLookBtlReportRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveLookBtlReportRequest',{}));
});

Five2FiveHandler.prototype.five2FiveMatchRequest = async(function(matchOrReMatch){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveMatchRequest',{matchOrReMatch:matchOrReMatch}));
});

Five2FiveHandler.prototype.five2FiveRefuseMatchRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveRefuseMatchRequest',{}));
});

Five2FiveHandler.prototype.five2FiveAgreeMatchRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveAgreeMatchRequest',{}));
});

Five2FiveHandler.prototype.five2FiveCancelMatchRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveCancelMatchRequest',{}));
});

Five2FiveHandler.prototype.five2FiveReadyRequest = async(function(tempTeamId){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveReadyRequest',{tempTeamId:tempTeamId}));
});

Five2FiveHandler.prototype.five2FiveLeaveAreaRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveLeaveAreaRequest',{}));
});

Five2FiveHandler.prototype.five2FiveReciveRewardRequest = async(function(){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveReciveRewardRequest',{}));
});

Five2FiveHandler.prototype.five2FiveLookMatchResultRequest = async(function(instanceId){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveLookMatchResultRequest',{instanceId:instanceId}));
});

Five2FiveHandler.prototype.five2FiveShardMatchResultRequest = async(function(instanceId){
	return await(this.socket.requestAsync('five2five.five2FiveHandler.five2FiveShardMatchResultRequest',{instanceId:instanceId}));
});


Five2FiveHandler.prototype.onFive2FiveApplyMatchPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveApplyMatchPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveMatchMemberInfoPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveMatchMemberInfoPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveMemberChoicePush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveMemberChoicePush',cb);
}

Five2FiveHandler.prototype.onFive2FiveOnGameEndPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveOnGameEndPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveOnNewRewardPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveOnNewRewardPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveOnNoRewardPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveOnNoRewardPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveMatchFailedPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveMatchFailedPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveLeaderCancelMatchPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveLeaderCancelMatchPush',cb);
}

Five2FiveHandler.prototype.onFive2FiveTeamChangePush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveTeamChangePush',cb);
}

Five2FiveHandler.prototype.onFive2FiveMatchPoolChangePush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveMatchPoolChangePush',cb);
}

Five2FiveHandler.prototype.onFive2FiveApplyMatchResultPush = function(cb){
	this.socket.on('five2five.five2FivePush.five2FiveApplyMatchResultPush',cb);
}

module.exports = Five2FiveHandler;
