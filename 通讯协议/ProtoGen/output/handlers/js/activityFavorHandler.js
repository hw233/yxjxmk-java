/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ActivityFavorHandler = function(socket){
	this.socket = socket;
}

ActivityFavorHandler.prototype.dailyRechargeGetInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityFavorHandler.dailyRechargeGetInfoRequest',{}));
});

ActivityFavorHandler.prototype.dailyRechargeGetAwardRequest = async(function(awardId){
	return await(this.socket.requestAsync('area.activityFavorHandler.dailyRechargeGetAwardRequest',{awardId:awardId}));
});

ActivityFavorHandler.prototype.superPackageGetInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityFavorHandler.superPackageGetInfoRequest',{}));
});

ActivityFavorHandler.prototype.superPackageBuyRequest = async(function(packageId,channelId,c2s_imei,c2s_os){
	return await(this.socket.requestAsync('area.activityFavorHandler.superPackageBuyRequest',{packageId:packageId,channelId:channelId,c2s_imei:c2s_imei,c2s_os:c2s_os}));
});

ActivityFavorHandler.prototype.sevenDayPackageGetInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityFavorHandler.sevenDayPackageGetInfoRequest',{}));
});

ActivityFavorHandler.prototype.sevenDayPackageAwardRequest = async(function(packageId){
	return await(this.socket.requestAsync('area.activityFavorHandler.sevenDayPackageAwardRequest',{packageId:packageId}));
});

ActivityFavorHandler.prototype.dailyDrawInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityFavorHandler.dailyDrawInfoRequest',{}));
});

ActivityFavorHandler.prototype.dailyDrawRequest = async(function(timeType,costType){
	return await(this.socket.requestAsync('area.activityFavorHandler.dailyDrawRequest',{timeType:timeType,costType:costType}));
});

ActivityFavorHandler.prototype.recoveredInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityFavorHandler.recoveredInfoRequest',{}));
});

ActivityFavorHandler.prototype.recoveredRequest = async(function(id,type){
	return await(this.socket.requestAsync('area.activityFavorHandler.recoveredRequest',{id:id,type:type}));
});


ActivityFavorHandler.prototype.onSuperPackageBuyPush = function(cb){
	this.socket.on('area.activityFavorPush.superPackageBuyPush',cb);
}

module.exports = ActivityFavorHandler;
