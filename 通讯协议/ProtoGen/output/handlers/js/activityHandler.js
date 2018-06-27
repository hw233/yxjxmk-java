/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ActivityHandler = function(socket){
	this.socket = socket;
}

ActivityHandler.prototype.activityLsRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityLsRequest',{}));
});

ActivityHandler.prototype.interestActivityAdRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.interestActivityAdRequest',{}));
});

ActivityHandler.prototype.payFirstRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.payFirstRequest',{}));
});

ActivityHandler.prototype.paySecondRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.paySecondRequest',{}));
});

ActivityHandler.prototype.payTotalRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.payTotalRequest',{}));
});

ActivityHandler.prototype.consumeTotalRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.consumeTotalRequest',{}));
});

ActivityHandler.prototype.activityAwardRequest = async(function(s2c_awardId,s2c_activityId){
	return await(this.socket.requestAsync('area.activityHandler.activityAwardRequest',{s2c_awardId:s2c_awardId,s2c_activityId:s2c_activityId}));
});

ActivityHandler.prototype.activityInviteCodeRequest = async(function(c2s_inviteCode){
	return await(this.socket.requestAsync('area.activityHandler.activityInviteCodeRequest',{c2s_inviteCode:c2s_inviteCode}));
});

ActivityHandler.prototype.activityNoticeRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityNoticeRequest',{}));
});

ActivityHandler.prototype.activityLevelOrSwordRequest = async(function(c2s_activityId){
	return await(this.socket.requestAsync('area.activityHandler.activityLevelOrSwordRequest',{c2s_activityId:c2s_activityId}));
});

ActivityHandler.prototype.activityBuyFundsRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityBuyFundsRequest',{}));
});

ActivityHandler.prototype.activityOpenFundsRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityOpenFundsRequest',{}));
});

ActivityHandler.prototype.activityLuckyAwardViewRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityLuckyAwardViewRequest',{}));
});

ActivityHandler.prototype.luckyAwardViewRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.luckyAwardViewRequest',{}));
});

ActivityHandler.prototype.reSetluckyAwardRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.reSetluckyAwardRequest',{}));
});

ActivityHandler.prototype.openSevenDayRequest = async(function(c2s_day){
	return await(this.socket.requestAsync('area.activityHandler.openSevenDayRequest',{c2s_day:c2s_day}));
});

ActivityHandler.prototype.openChangeRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.openChangeRequest',{}));
});

ActivityHandler.prototype.activityDrawInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.activityDrawInfoRequest',{}));
});

ActivityHandler.prototype.drawInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.drawInfoRequest',{}));
});

ActivityHandler.prototype.drawRankRequest = async(function(){
	return await(this.socket.requestAsync('area.activityHandler.drawRankRequest',{}));
});

ActivityHandler.prototype.drawSetLowRequest = async(function(isLow){
	return await(this.socket.requestAsync('area.activityHandler.drawSetLowRequest',{isLow:isLow}));
});

ActivityHandler.prototype.drawAwardRequest = async(function(type,useItem){
	return await(this.socket.requestAsync('area.activityHandler.drawAwardRequest',{type:type,useItem:useItem}));
});


module.exports = ActivityHandler;
