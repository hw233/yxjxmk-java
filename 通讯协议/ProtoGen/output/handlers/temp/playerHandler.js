/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var PlayerHandler = function(socket){
	this.socket = socket;
}

PlayerHandler.prototype.getPlayerPositionRequest = async(function(s2c_playerId){
	return await(this.socket.requestAsync('area.playerHandler.getPlayerPositionRequest',{s2c_playerId:s2c_playerId}));
});

PlayerHandler.prototype.transportRequest = async(function(c2s_transportId){
	return await(this.socket.requestAsync('area.playerHandler.transportRequest',{c2s_transportId:c2s_transportId}));
});

PlayerHandler.prototype.enterSceneRequest = async(function(c2s_instanceId){
	return await(this.socket.requestAsync('area.playerHandler.enterSceneRequest',{c2s_instanceId:c2s_instanceId}));
});

PlayerHandler.prototype.queryLoadWayRequest = async(function(c2s_areaId,c2s_pointId){
	return await(this.socket.requestAsync('area.playerHandler.queryLoadWayRequest',{c2s_areaId:c2s_areaId,c2s_pointId:c2s_pointId}));
});

PlayerHandler.prototype.pickItemRequest = async(function(c2s_instanceId,c2s_itemId){
	return await(this.socket.requestAsync('area.playerHandler.pickItemRequest',{c2s_instanceId:c2s_instanceId,c2s_itemId:c2s_itemId}));
});

PlayerHandler.prototype.changeAreaRequest = async(function(c2s_pointId,c2s_type){
	return await(this.socket.requestAsync('area.playerHandler.changeAreaRequest',{c2s_pointId:c2s_pointId,c2s_type:c2s_type}));
});

PlayerHandler.prototype.transByAreaIdRequest = async(function(c2s_areaId){
	return await(this.socket.requestAsync('area.playerHandler.transByAreaIdRequest',{c2s_areaId:c2s_areaId}));
});

PlayerHandler.prototype.changeAreaXYRequest = async(function(mapId,posx,posy,instanceId){
	return await(this.socket.requestAsync('area.playerHandler.changeAreaXYRequest',{mapId:mapId,posx:posx,posy:posy,instanceId:instanceId}));
});

PlayerHandler.prototype.changeAreaByTaskRequest = async(function(mapId,taskId,posx,posy,point){
	return await(this.socket.requestAsync('area.playerHandler.changeAreaByTaskRequest',{mapId:mapId,taskId:taskId,posx:posx,posy:posy,point:point}));
});

PlayerHandler.prototype.recentContactsRequest = async(function(c2s_ids){
	return await(this.socket.requestAsync('area.playerHandler.recentContactsRequest',{c2s_ids:c2s_ids}));
});

PlayerHandler.prototype.ChangePkModelRequest = async(function(c2s_model){
	return await(this.socket.requestAsync('area.playerHandler.ChangePkModelRequest',{c2s_model:c2s_model}));
});

PlayerHandler.prototype.reliveSendPosRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.reliveSendPosRequest',{}));
});

PlayerHandler.prototype.reliveRequest = async(function(type,autoPay){
	return await(this.socket.requestAsync('area.playerHandler.reliveRequest',{type:type,autoPay:autoPay}));
});

PlayerHandler.prototype.getAreaLinesRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.getAreaLinesRequest',{}));
});

PlayerHandler.prototype.transByInstanceIdRequest = async(function(c2s_instanceId){
	return await(this.socket.requestAsync('area.playerHandler.transByInstanceIdRequest',{c2s_instanceId:c2s_instanceId}));
});

PlayerHandler.prototype.lookUpOtherPlayerRequest = async(function(c2s_playerId,c2s_type){
	return await(this.socket.requestAsync('area.playerHandler.lookUpOtherPlayerRequest',{c2s_playerId:c2s_playerId,c2s_type:c2s_type}));
});

PlayerHandler.prototype.agreeRebirthRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.agreeRebirthRequest',{}));
});

PlayerHandler.prototype.cdkRequest = async(function(c2s_cdk,c2s_channel){
	return await(this.socket.requestAsync('area.playerHandler.cdkRequest',{c2s_cdk:c2s_cdk,c2s_channel:c2s_channel}));
});

PlayerHandler.prototype.setCustomConfigRequest = async(function(c2s_key,c2s_value){
	return await(this.socket.requestAsync('area.playerHandler.setCustomConfigRequest',{c2s_key:c2s_key,c2s_value:c2s_value}));
});

PlayerHandler.prototype.leaveAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.leaveAreaRequest',{}));
});

PlayerHandler.prototype.getSimulateDropByTcRequest = async(function(c2s_tcCode,c2s_tcCount,c2s_tcLevel){
	return await(this.socket.requestAsync('area.playerHandler.getSimulateDropByTcRequest',{c2s_tcCode:c2s_tcCode,c2s_tcCount:c2s_tcCount,c2s_tcLevel:c2s_tcLevel}));
});

PlayerHandler.prototype.upgradeClassRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.upgradeClassRequest',{}));
});

PlayerHandler.prototype.getClassEventConditionRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.getClassEventConditionRequest',{}));
});

PlayerHandler.prototype.clientReadyRequest = async(function(){
	return await(this.socket.requestAsync('area.playerHandler.clientReadyRequest',{}));
});

PlayerHandler.prototype.sendGMCmdRequest = async(function(c2s_msg){
	return await(this.socket.requestAsync('area.playerHandler.sendGMCmdRequest',{c2s_msg:c2s_msg}));
});

PlayerHandler.prototype.battleEventNotify = function(c2s_data){
	return this.socket.notify('area.playerHandler.battleEventNotify',{c2s_data:c2s_data});
};


PlayerHandler.prototype.onClientConfigPush = function(cb){
	this.socket.on('area.playerPush.clientConfigPush',cb);
}

PlayerHandler.prototype.onBattleEventPush = function(cb){
	this.socket.on('area.playerPush.battleEventPush',cb);
}

PlayerHandler.prototype.onBattleClearPush = function(cb){
	this.socket.on('area.playerPush.battleClearPush',cb);
}

PlayerHandler.prototype.onOnSuperScriptPush = function(cb){
	this.socket.on('area.playerPush.onSuperScriptPush',cb);
}

PlayerHandler.prototype.onChangeAreaPush = function(cb){
	this.socket.on('area.playerPush.changeAreaPush',cb);
}

PlayerHandler.prototype.onPlayerDynamicPush = function(cb){
	this.socket.on('area.playerPush.playerDynamicPush',cb);
}

PlayerHandler.prototype.onPlayerRelivePush = function(cb){
	this.socket.on('area.playerPush.playerRelivePush',cb);
}

PlayerHandler.prototype.onPlayerSaverRebirthPush = function(cb){
	this.socket.on('area.playerPush.playerSaverRebirthPush',cb);
}

PlayerHandler.prototype.onSimulateDropPush = function(cb){
	this.socket.on('area.playerPush.simulateDropPush',cb);
}

PlayerHandler.prototype.onKickPlayerPush = function(cb){
	this.socket.on('area.playerPush.kickPlayerPush',cb);
}

PlayerHandler.prototype.onSuitPropertyUpPush = function(cb){
	this.socket.on('area.playerPush.suitPropertyUpPush',cb);
}

PlayerHandler.prototype.onCommonPropertyPush = function(cb){
	this.socket.on('area.playerPush.commonPropertyPush',cb);
}

PlayerHandler.prototype.onBuffPropertyPush = function(cb){
	this.socket.on('area.playerPush.buffPropertyPush',cb);
}

PlayerHandler.prototype.onPlayerBattleAttributePush = function(cb){
	this.socket.on('area.playerPush.playerBattleAttributePush',cb);
}

PlayerHandler.prototype.onPayGiftStatePush = function(cb){
	this.socket.on('area.playerPush.payGiftStatePush',cb);
}

module.exports = PlayerHandler;
