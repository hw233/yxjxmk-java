/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GoddessHandler = function(socket){
	this.socket = socket;
}

GoddessHandler.prototype.enterGoddessSceneRequest = async(function(){
	return await(this.socket.requestAsync('area.goddessHandler.enterGoddessSceneRequest',{}));
});

GoddessHandler.prototype.outGoddessSceneRequest = async(function(){
	return await(this.socket.requestAsync('area.goddessHandler.outGoddessSceneRequest',{}));
});

GoddessHandler.prototype.activeGoddessRequest = async(function(c2s_goddessTemplateId){
	return await(this.socket.requestAsync('area.goddessHandler.activeGoddessRequest',{c2s_goddessTemplateId:c2s_goddessTemplateId}));
});

GoddessHandler.prototype.onBattleGoddessRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.onBattleGoddessRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.offBattleGoddessRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.offBattleGoddessRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.getGiftsRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.getGiftsRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.buyGiftRequest = async(function(c2s_goddessId,c2s_giftId){
	return await(this.socket.requestAsync('area.goddessHandler.buyGiftRequest',{c2s_goddessId:c2s_goddessId,c2s_giftId:c2s_giftId}));
});

GoddessHandler.prototype.unEquipGiftRequest = async(function(c2s_goddessId,c2s_giftId){
	return await(this.socket.requestAsync('area.goddessHandler.unEquipGiftRequest',{c2s_goddessId:c2s_goddessId,c2s_giftId:c2s_giftId}));
});

GoddessHandler.prototype.equipGiftRequest = async(function(c2s_goddessId,c2s_giftId){
	return await(this.socket.requestAsync('area.goddessHandler.equipGiftRequest',{c2s_goddessId:c2s_goddessId,c2s_giftId:c2s_giftId}));
});

GoddessHandler.prototype.upIntimacyRequest = async(function(c2s_goddessId,c2s_type){
	return await(this.socket.requestAsync('area.goddessHandler.upIntimacyRequest',{c2s_goddessId:c2s_goddessId,c2s_type:c2s_type}));
});

GoddessHandler.prototype.upStarRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.upStarRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.getCommInfoRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.getCommInfoRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.getGoddessDetailRequest = async(function(c2s_goddessId){
	return await(this.socket.requestAsync('area.goddessHandler.getGoddessDetailRequest',{c2s_goddessId:c2s_goddessId}));
});

GoddessHandler.prototype.getAllGoddessRequest = async(function(){
	return await(this.socket.requestAsync('area.goddessHandler.getAllGoddessRequest',{}));
});


GoddessHandler.prototype.onGoddessEquipDynamicPush = function(cb){
	this.socket.on('area.goddessPush.goddessEquipDynamicPush',cb);
}

GoddessHandler.prototype.onGoddessGiftDynamicPush = function(cb){
	this.socket.on('area.goddessPush.goddessGiftDynamicPush',cb);
}

module.exports = GoddessHandler;
