/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var SkillHandler = function(socket){
	this.socket = socket;
}

SkillHandler.prototype.unlockSkillRequest = async(function(s2c_skillId){
	return await(this.socket.requestAsync('area.skillHandler.unlockSkillRequest',{s2c_skillId:s2c_skillId}));
});

SkillHandler.prototype.upgradeSkillRequest = async(function(s2c_skillId){
	return await(this.socket.requestAsync('area.skillHandler.upgradeSkillRequest',{s2c_skillId:s2c_skillId}));
});

SkillHandler.prototype.upgradeSkillOneKeyRequest = async(function(){
	return await(this.socket.requestAsync('area.skillHandler.upgradeSkillOneKeyRequest',{}));
});

SkillHandler.prototype.getSkillDetailRequest = async(function(s2c_skillId){
	return await(this.socket.requestAsync('area.skillHandler.getSkillDetailRequest',{s2c_skillId:s2c_skillId}));
});

SkillHandler.prototype.getAllSkillRequest = async(function(){
	return await(this.socket.requestAsync('area.skillHandler.getAllSkillRequest',{}));
});


SkillHandler.prototype.onSkillUpdatePush = function(cb){
	this.socket.on('area.skillPush.skillUpdatePush',cb);
}

module.exports = SkillHandler;
