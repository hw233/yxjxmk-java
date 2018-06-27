/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FleeHandler = function(socket){
	this.socket = socket;
}

FleeHandler.prototype.fleeInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.fleeHandler.fleeInfoRequest',{}));
});

FleeHandler.prototype.getRewardRequest = async(function(gradeId){
	return await(this.socket.requestAsync('area.fleeHandler.getRewardRequest',{gradeId:gradeId}));
});

FleeHandler.prototype.fleeLookBtlReportRequest = async(function(){
	return await(this.socket.requestAsync('area.fleeHandler.fleeLookBtlReportRequest',{}));
});

FleeHandler.prototype.enterFleeRequest = async(function(){
	return await(this.socket.requestAsync('area.fleeHandler.enterFleeRequest',{}));
});

FleeHandler.prototype.cancelMatchRequest = async(function(){
	return await(this.socket.requestAsync('area.fleeHandler.cancelMatchRequest',{}));
});


FleeHandler.prototype.onOnFleeDeathPush = function(cb){
	this.socket.on('area.fleePush.onFleeDeathPush',cb);
}

FleeHandler.prototype.onOnFleeEndPush = function(cb){
	this.socket.on('area.fleePush.onFleeEndPush',cb);
}

module.exports = FleeHandler;
