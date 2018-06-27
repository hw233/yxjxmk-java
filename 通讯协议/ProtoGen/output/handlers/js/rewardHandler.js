/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var RewardHandler = function(socket){
	this.socket = socket;
}

RewardHandler.prototype.rewardDeskRequest = async(function(){
	return await(this.socket.requestAsync('area.rewardHandler.rewardDeskRequest',{}));
});

RewardHandler.prototype.rewardRequest = async(function(c2s_playerName){
	return await(this.socket.requestAsync('area.rewardHandler.rewardRequest',{c2s_playerName:c2s_playerName}));
});

RewardHandler.prototype.checkBountyRequest = async(function(c2s_index){
	return await(this.socket.requestAsync('area.rewardHandler.checkBountyRequest',{c2s_index:c2s_index}));
});

RewardHandler.prototype.getHasFinishRequest = async(function(){
	return await(this.socket.requestAsync('area.rewardHandler.getHasFinishRequest',{}));
});

RewardHandler.prototype.getAwardBountyRequest = async(function(c2s_preyId,c2s_hunterId,c2s_bounty){
	return await(this.socket.requestAsync('area.rewardHandler.getAwardBountyRequest',{c2s_preyId:c2s_preyId,c2s_hunterId:c2s_hunterId,c2s_bounty:c2s_bounty}));
});


module.exports = RewardHandler;
