/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildBossHandler = function(socket){
	this.socket = socket;
}

GuildBossHandler.prototype.enterGuildBossAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.guildBossHandler.enterGuildBossAreaRequest',{}));
});

GuildBossHandler.prototype.getGuildBossInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.guildBossHandler.getGuildBossInfoRequest',{}));
});

GuildBossHandler.prototype.guildBossInspireRequest = async(function(c2s_index){
	return await(this.socket.requestAsync('area.guildBossHandler.guildBossInspireRequest',{c2s_index:c2s_index}));
});


GuildBossHandler.prototype.onOnHurtRankChangePush = function(cb){
	this.socket.on('area.guildBossPush.onHurtRankChangePush',cb);
}

GuildBossHandler.prototype.onOnInspireSingleChangePush = function(cb){
	this.socket.on('area.guildBossPush.onInspireSingleChangePush',cb);
}

GuildBossHandler.prototype.onOnInspireGuildChangePush = function(cb){
	this.socket.on('area.guildBossPush.onInspireGuildChangePush',cb);
}

GuildBossHandler.prototype.onOnGuildBossOverPush = function(cb){
	this.socket.on('area.guildBossPush.onGuildBossOverPush',cb);
}

GuildBossHandler.prototype.onOnQuitGuildBossPush = function(cb){
	this.socket.on('area.guildBossPush.onQuitGuildBossPush',cb);
}

module.exports = GuildBossHandler;
