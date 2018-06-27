/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MountHandler = function(socket){
	this.socket = socket;
}

MountHandler.prototype.activeMountSkinRequest = async(function(c2s_skinId){
	return await(this.socket.requestAsync('area.mountHandler.activeMountSkinRequest',{c2s_skinId:c2s_skinId}));
});

MountHandler.prototype.saveMountRequest = async(function(c2s_mountId,c2s_skinId){
	return await(this.socket.requestAsync('area.mountHandler.saveMountRequest',{c2s_mountId:c2s_mountId,c2s_skinId:c2s_skinId}));
});

MountHandler.prototype.upMountStageRequest = async(function(){
	return await(this.socket.requestAsync('area.mountHandler.upMountStageRequest',{}));
});

MountHandler.prototype.getMountInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.mountHandler.getMountInfoRequest',{}));
});

MountHandler.prototype.trainingMountRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.mountHandler.trainingMountRequest',{c2s_type:c2s_type}));
});

MountHandler.prototype.ridingMountRequest = async(function(c2s_isUp){
	return await(this.socket.requestAsync('area.mountHandler.ridingMountRequest',{c2s_isUp:c2s_isUp}));
});

MountHandler.prototype.oneKeyTrainingRequest = async(function(){
	return await(this.socket.requestAsync('area.mountHandler.oneKeyTrainingRequest',{}));
});

MountHandler.prototype.chooseFirstSkinRequest = async(function(c2s_skinId){
	return await(this.socket.requestAsync('area.mountHandler.chooseFirstSkinRequest',{c2s_skinId:c2s_skinId}));
});


MountHandler.prototype.onMountFlagPush = function(cb){
	this.socket.on('area.mountPush.mountFlagPush',cb);
}

MountHandler.prototype.onMountNewSkinPush = function(cb){
	this.socket.on('area.mountPush.mountNewSkinPush',cb);
}

module.exports = MountHandler;
