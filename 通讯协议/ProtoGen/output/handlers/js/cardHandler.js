/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var CardHandler = function(socket){
	this.socket = socket;
}

CardHandler.prototype.cardRegisterRequest = async(function(c2s_cardId){
	return await(this.socket.requestAsync('area.cardHandler.cardRegisterRequest',{c2s_cardId:c2s_cardId}));
});

CardHandler.prototype.cardLevelUpRequest = async(function(c2s_cardTemplateId){
	return await(this.socket.requestAsync('area.cardHandler.cardLevelUpRequest',{c2s_cardTemplateId:c2s_cardTemplateId}));
});

CardHandler.prototype.cardPreLevelUpRequest = async(function(c2s_cardTemplateId){
	return await(this.socket.requestAsync('area.cardHandler.cardPreLevelUpRequest',{c2s_cardTemplateId:c2s_cardTemplateId}));
});

CardHandler.prototype.cardGetAwardRequest = async(function(c2s_awardId){
	return await(this.socket.requestAsync('area.cardHandler.cardGetAwardRequest',{c2s_awardId:c2s_awardId}));
});

CardHandler.prototype.cardEquipRequest = async(function(c2s_cardId,c2s_holePos){
	return await(this.socket.requestAsync('area.cardHandler.cardEquipRequest',{c2s_cardId:c2s_cardId,c2s_holePos:c2s_holePos}));
});

CardHandler.prototype.cardQueryAllDataRequest = async(function(){
	return await(this.socket.requestAsync('area.cardHandler.cardQueryAllDataRequest',{}));
});


module.exports = CardHandler;
