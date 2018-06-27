/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildTechHandler = function(socket){
	this.socket = socket;
}

GuildTechHandler.prototype.getGuildTechInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.guildTechHandler.getGuildTechInfoRequest',{}));
});

GuildTechHandler.prototype.upgradeGuildTechRequest = async(function(){
	return await(this.socket.requestAsync('area.guildTechHandler.upgradeGuildTechRequest',{}));
});

GuildTechHandler.prototype.upgradeGuildBuffRequest = async(function(){
	return await(this.socket.requestAsync('area.guildTechHandler.upgradeGuildBuffRequest',{}));
});

GuildTechHandler.prototype.upgradeGuildSkillRequest = async(function(skillId){
	return await(this.socket.requestAsync('area.guildTechHandler.upgradeGuildSkillRequest',{skillId:skillId}));
});

GuildTechHandler.prototype.buyGuildProductRequest = async(function(productId){
	return await(this.socket.requestAsync('area.guildTechHandler.buyGuildProductRequest',{productId:productId}));
});


GuildTechHandler.prototype.onGuildTechRefreshPush = function(cb){
	this.socket.on('area.guildTechPush.guildTechRefreshPush',cb);
}

module.exports = GuildTechHandler;
