/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var TaskHandler = function(socket){
	this.socket = socket;
}

TaskHandler.prototype.acceptTaskRequest = async(function(c2s_templateId,c2s_kind,c2s_npcId){
	return await(this.socket.requestAsync('area.taskHandler.acceptTaskRequest',{c2s_templateId:c2s_templateId,c2s_kind:c2s_kind,c2s_npcId:c2s_npcId}));
});

TaskHandler.prototype.quickFinishRequest = async(function(c2s_templateId,c2s_kind,c2s_npcId){
	return await(this.socket.requestAsync('area.taskHandler.quickFinishRequest',{c2s_templateId:c2s_templateId,c2s_kind:c2s_kind,c2s_npcId:c2s_npcId}));
});

TaskHandler.prototype.discardTaskRequest = async(function(c2s_templateId,c2s_kind){
	return await(this.socket.requestAsync('area.taskHandler.discardTaskRequest',{c2s_templateId:c2s_templateId,c2s_kind:c2s_kind}));
});

TaskHandler.prototype.submitTaskRequest = async(function(c2s_templateId,c2s_kind,c2s_double,c2s_npcId){
	return await(this.socket.requestAsync('area.taskHandler.submitTaskRequest',{c2s_templateId:c2s_templateId,c2s_kind:c2s_kind,c2s_double:c2s_double,c2s_npcId:c2s_npcId}));
});

TaskHandler.prototype.updateTaskStatusRequest = async(function(c2s_templateId,c2s_kind){
	return await(this.socket.requestAsync('area.taskHandler.updateTaskStatusRequest',{c2s_templateId:c2s_templateId,c2s_kind:c2s_kind}));
});

TaskHandler.prototype.refreshSoulTaskRequest = async(function(c2s_taskId){
	return await(this.socket.requestAsync('area.taskHandler.refreshSoulTaskRequest',{c2s_taskId:c2s_taskId}));
});

TaskHandler.prototype.getDailySoulFinNumRequest = async(function(){
	return await(this.socket.requestAsync('area.taskHandler.getDailySoulFinNumRequest',{}));
});

TaskHandler.prototype.taskFuncDeskRequest = async(function(c2s_ncpId){
	return await(this.socket.requestAsync('area.taskHandler.taskFuncDeskRequest',{c2s_ncpId:c2s_ncpId}));
});

TaskHandler.prototype.acceptLoopTaskRequest = async(function(c2s_npcId){
	return await(this.socket.requestAsync('area.taskHandler.acceptLoopTaskRequest',{c2s_npcId:c2s_npcId}));
});

TaskHandler.prototype.acceptDailyTaskRequest = async(function(c2s_npcId){
	return await(this.socket.requestAsync('area.taskHandler.acceptDailyTaskRequest',{c2s_npcId:c2s_npcId}));
});

TaskHandler.prototype.reachTreasurePointRequest = async(function(point){
	return await(this.socket.requestAsync('area.taskHandler.reachTreasurePointRequest',{point:point}));
});

TaskHandler.prototype.cjPlayEndNotify = function(s2c_msg){
	return this.socket.notify('area.taskHandler.cjPlayEndNotify',{s2c_msg:s2c_msg});
};


TaskHandler.prototype.onTaskUpdatePush = function(cb){
	this.socket.on('area.taskPush.taskUpdatePush',cb);
}

TaskHandler.prototype.onTaskAutoPush = function(cb){
	this.socket.on('area.taskPush.taskAutoPush',cb);
}

TaskHandler.prototype.onTreasureScenePointPush = function(cb){
	this.socket.on('area.taskPush.treasureScenePointPush',cb);
}

TaskHandler.prototype.onLoopResultPush = function(cb){
	this.socket.on('area.taskPush.loopResultPush',cb);
}

module.exports = TaskHandler;
