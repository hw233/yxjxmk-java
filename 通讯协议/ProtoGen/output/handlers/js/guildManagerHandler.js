/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildManagerHandler = function(socket){
	this.socket = socket;
}

GuildManagerHandler.prototype.getDepotAllGridsRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getDepotAllGridsRequest',{}));
});

GuildManagerHandler.prototype.getDepotAllDetailsRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getDepotAllDetailsRequest',{}));
});

GuildManagerHandler.prototype.getDepotOneGridInfoRequest = async(function(bagIndex){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getDepotOneGridInfoRequest',{bagIndex:bagIndex}));
});

GuildManagerHandler.prototype.getDepotInfoRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getDepotInfoRequest',{}));
});

GuildManagerHandler.prototype.getDepotRecordRequest = async(function(page){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getDepotRecordRequest',{page:page}));
});

GuildManagerHandler.prototype.getBlessInfoRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getBlessInfoRequest',{}));
});

GuildManagerHandler.prototype.getBlessRecordRequest = async(function(page){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getBlessRecordRequest',{page:page}));
});

GuildManagerHandler.prototype.getBuildingLevelRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.getBuildingLevelRequest',{}));
});

GuildManagerHandler.prototype.openGuildDungeonRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.openGuildDungeonRequest',{}));
});

GuildManagerHandler.prototype.guildDungeonListRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.guildDungeonListRequest',{}));
});

GuildManagerHandler.prototype.dungeonRankRequest = async(function(s2c_type){
	return await(this.socket.requestAsync('guild.guildManagerHandler.dungeonRankRequest',{s2c_type:s2c_type}));
});

GuildManagerHandler.prototype.dungeonAwardInfoRequest = async(function(){
	return await(this.socket.requestAsync('guild.guildManagerHandler.dungeonAwardInfoRequest',{}));
});

GuildManagerHandler.prototype.diceAwardRequest = async(function(s2c_pos){
	return await(this.socket.requestAsync('guild.guildManagerHandler.diceAwardRequest',{s2c_pos:s2c_pos}));
});


module.exports = GuildManagerHandler;
