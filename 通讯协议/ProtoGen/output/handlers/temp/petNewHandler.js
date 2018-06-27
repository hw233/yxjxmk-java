/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var PetNewHandler = function(socket){
	this.socket = socket;
}

PetNewHandler.prototype.getAllPetsInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.petNewHandler.getAllPetsInfoRequest',{}));
});

PetNewHandler.prototype.summonPetRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.petNewHandler.summonPetRequest',{c2s_id:c2s_id}));
});

PetNewHandler.prototype.upGradeUpLevelRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.petNewHandler.upGradeUpLevelRequest',{c2s_id:c2s_id}));
});

PetNewHandler.prototype.addExpByItemRequest = async(function(c2s_id,c2s_itemCode){
	return await(this.socket.requestAsync('area.petNewHandler.addExpByItemRequest',{c2s_id:c2s_id,c2s_itemCode:c2s_itemCode}));
});

PetNewHandler.prototype.upgradeOneLevelRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.petNewHandler.upgradeOneLevelRequest',{c2s_id:c2s_id}));
});

PetNewHandler.prototype.upgradeToTopRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.petNewHandler.upgradeToTopRequest',{c2s_id:c2s_id}));
});

PetNewHandler.prototype.changePetNameNewRequest = async(function(c2s_id,c2s_name){
	return await(this.socket.requestAsync('area.petNewHandler.changePetNameNewRequest',{c2s_id:c2s_id,c2s_name:c2s_name}));
});

PetNewHandler.prototype.petFightRequest = async(function(c2s_id,c2s_type){
	return await(this.socket.requestAsync('area.petNewHandler.petFightRequest',{c2s_id:c2s_id,c2s_type:c2s_type}));
});

PetNewHandler.prototype.getPetInfoNewRequest = async(function(c2s_petId,c2s_ownId){
	return await(this.socket.requestAsync('area.petNewHandler.getPetInfoNewRequest',{c2s_petId:c2s_petId,c2s_ownId:c2s_ownId}));
});


PetNewHandler.prototype.onOnNewPetDetailPush = function(cb){
	this.socket.on('area.petNewPush.onNewPetDetailPush',cb);
}

PetNewHandler.prototype.onPetExpUpdatePush = function(cb){
	this.socket.on('area.petNewPush.petExpUpdatePush',cb);
}

PetNewHandler.prototype.onPetInfoUpdatePush = function(cb){
	this.socket.on('area.petNewPush.petInfoUpdatePush',cb);
}

module.exports = PetNewHandler;
