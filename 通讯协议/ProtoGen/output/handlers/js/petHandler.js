/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var PetHandler = function(socket){
	this.socket = socket;
}

PetHandler.prototype.getAllPetsBaseInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.petHandler.getAllPetsBaseInfoRequest',{}));
});

PetHandler.prototype.getPetInfoRequest = async(function(s2c_petId,s2c_ownId){
	return await(this.socket.requestAsync('area.petHandler.getPetInfoRequest',{s2c_petId:s2c_petId,s2c_ownId:s2c_ownId}));
});

PetHandler.prototype.developPetRequest = async(function(s2c_type,s2c_itemCode,s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.developPetRequest',{s2c_type:s2c_type,s2c_itemCode:s2c_itemCode,s2c_petId:s2c_petId}));
});

PetHandler.prototype.changePetNameRequest = async(function(s2c_petId,s2c_petName){
	return await(this.socket.requestAsync('area.petHandler.changePetNameRequest',{s2c_petId:s2c_petId,s2c_petName:s2c_petName}));
});

PetHandler.prototype.freePetRequest = async(function(s2c_petId,s2c_type){
	return await(this.socket.requestAsync('area.petHandler.freePetRequest',{s2c_petId:s2c_petId,s2c_type:s2c_type}));
});

PetHandler.prototype.petOutFightRequest = async(function(s2c_petId,s2c_type){
	return await(this.socket.requestAsync('area.petHandler.petOutFightRequest',{s2c_petId:s2c_petId,s2c_type:s2c_type}));
});

PetHandler.prototype.petReliveRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petReliveRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.randPetNameRequest = async(function(){
	return await(this.socket.requestAsync('area.petHandler.randPetNameRequest',{}));
});

PetHandler.prototype.upGradeInfoRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.upGradeInfoRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.upGradeLevelRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.upGradeLevelRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.upGradeRandPropertyRequest = async(function(s2c_petId,s2c_pos,s2c_materialItems){
	return await(this.socket.requestAsync('area.petHandler.upGradeRandPropertyRequest',{s2c_petId:s2c_petId,s2c_pos:s2c_pos,s2c_materialItems:s2c_materialItems}));
});

PetHandler.prototype.reSetRandPropertyRequest = async(function(s2c_petId,s2c_pos){
	return await(this.socket.requestAsync('area.petHandler.reSetRandPropertyRequest',{s2c_petId:s2c_petId,s2c_pos:s2c_pos}));
});

PetHandler.prototype.randPropertyListRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.randPropertyListRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.petIllusionRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petIllusionRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.petIllusionInfoRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petIllusionInfoRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.petIllusionReviewRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petIllusionReviewRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.petComprehendSkillRequest = async(function(s2c_petId,s2c_skillBookCode,s2c_lockPos){
	return await(this.socket.requestAsync('area.petHandler.petComprehendSkillRequest',{s2c_petId:s2c_petId,s2c_skillBookCode:s2c_skillBookCode,s2c_lockPos:s2c_lockPos}));
});

PetHandler.prototype.petSkillListRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petSkillListRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.petOnHookSetRequest = async(function(s2c_petId,s2c_onHookData){
	return await(this.socket.requestAsync('area.petHandler.petOnHookSetRequest',{s2c_petId:s2c_petId,s2c_onHookData:s2c_onHookData}));
});

PetHandler.prototype.petOnHookGetRequest = async(function(s2c_petId){
	return await(this.socket.requestAsync('area.petHandler.petOnHookGetRequest',{s2c_petId:s2c_petId}));
});

PetHandler.prototype.changePetPkModelRequest = async(function(c2s_model){
	return await(this.socket.requestAsync('area.petHandler.changePetPkModelRequest',{c2s_model:c2s_model}));
});


PetHandler.prototype.onOnPetDetailPush = function(cb){
	this.socket.on('area.petPush.onPetDetailPush',cb);
}

PetHandler.prototype.onOnPetExpPush = function(cb){
	this.socket.on('area.petPush.onPetExpPush',cb);
}

module.exports = PetHandler;
