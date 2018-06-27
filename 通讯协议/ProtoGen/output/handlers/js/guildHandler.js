/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildHandler = function(socket){
	this.socket = socket;
}

GuildHandler.prototype.createGuildRequest = async(function(c2s_icon,c2s_name,c2s_qqGroup){
	return await(this.socket.requestAsync('area.guildHandler.createGuildRequest',{c2s_icon:c2s_icon,c2s_name:c2s_name,c2s_qqGroup:c2s_qqGroup}));
});

GuildHandler.prototype.getGuildListRequest = async(function(c2s_name){
	return await(this.socket.requestAsync('area.guildHandler.getGuildListRequest',{c2s_name:c2s_name}));
});

GuildHandler.prototype.joinGuildRequest = async(function(c2s_guildId){
	return await(this.socket.requestAsync('area.guildHandler.joinGuildRequest',{c2s_guildId:c2s_guildId}));
});

GuildHandler.prototype.joinGuildOfPlayerRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.guildHandler.joinGuildOfPlayerRequest',{c2s_playerId:c2s_playerId}));
});

GuildHandler.prototype.invitePlayerJoinMyGuildRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.guildHandler.invitePlayerJoinMyGuildRequest',{c2s_playerId:c2s_playerId}));
});

GuildHandler.prototype.agreeOrRefuseInviteRequest = async(function(c2s_isAgree,c2s_inviteId,c2s_guildId){
	return await(this.socket.requestAsync('area.guildHandler.agreeOrRefuseInviteRequest',{c2s_isAgree:c2s_isAgree,c2s_inviteId:c2s_inviteId,c2s_guildId:c2s_guildId}));
});

GuildHandler.prototype.dealApplyRequest = async(function(c2s_applyId,c2s_operate){
	return await(this.socket.requestAsync('area.guildHandler.dealApplyRequest',{c2s_applyId:c2s_applyId,c2s_operate:c2s_operate}));
});

GuildHandler.prototype.getMyGuildInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.getMyGuildInfoRequest',{}));
});

GuildHandler.prototype.getMyGuildMembersRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.getMyGuildMembersRequest',{}));
});

GuildHandler.prototype.getApplyListRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.getApplyListRequest',{}));
});

GuildHandler.prototype.setGuildInfoRequest = async(function(entryLevel,guildMode,entryUpLevel){
	return await(this.socket.requestAsync('area.guildHandler.setGuildInfoRequest',{entryLevel:entryLevel,guildMode:guildMode,entryUpLevel:entryUpLevel}));
});

GuildHandler.prototype.setGuildQQGroupRequest = async(function(qqGroup){
	return await(this.socket.requestAsync('area.guildHandler.setGuildQQGroupRequest',{qqGroup:qqGroup}));
});

GuildHandler.prototype.exitGuildRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.exitGuildRequest',{}));
});

GuildHandler.prototype.kickMemberRequest = async(function(memberId){
	return await(this.socket.requestAsync('area.guildHandler.kickMemberRequest',{memberId:memberId}));
});

GuildHandler.prototype.upgradeGuildLevelRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.upgradeGuildLevelRequest',{}));
});

GuildHandler.prototype.changeGuildNoticeRequest = async(function(notice){
	return await(this.socket.requestAsync('area.guildHandler.changeGuildNoticeRequest',{notice:notice}));
});

GuildHandler.prototype.changeGuildNameRequest = async(function(name){
	return await(this.socket.requestAsync('area.guildHandler.changeGuildNameRequest',{name:name}));
});

GuildHandler.prototype.changeOfficeNameRequest = async(function(officeNames){
	return await(this.socket.requestAsync('area.guildHandler.changeOfficeNameRequest',{officeNames:officeNames}));
});

GuildHandler.prototype.contributeToGuildRequest = async(function(type,times){
	return await(this.socket.requestAsync('area.guildHandler.contributeToGuildRequest',{type:type,times:times}));
});

GuildHandler.prototype.setMemberJobRequest = async(function(memberId,job){
	return await(this.socket.requestAsync('area.guildHandler.setMemberJobRequest',{memberId:memberId,job:job}));
});

GuildHandler.prototype.transferPresidentRequest = async(function(memberId){
	return await(this.socket.requestAsync('area.guildHandler.transferPresidentRequest',{memberId:memberId}));
});

GuildHandler.prototype.getGuildRecordRequest = async(function(page){
	return await(this.socket.requestAsync('area.guildHandler.getGuildRecordRequest',{page:page}));
});

GuildHandler.prototype.impeachGuildPresidentRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.impeachGuildPresidentRequest',{}));
});

GuildHandler.prototype.getGuildMoneyRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.getGuildMoneyRequest',{}));
});

GuildHandler.prototype.joinGuildDungeonRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.guildHandler.joinGuildDungeonRequest',{c2s_type:c2s_type}));
});

GuildHandler.prototype.leaveGuildDungeonRequest = async(function(){
	return await(this.socket.requestAsync('area.guildHandler.leaveGuildDungeonRequest',{}));
});


GuildHandler.prototype.onGuildRefreshPush = function(cb){
	this.socket.on('area.guildPush.guildRefreshPush',cb);
}

GuildHandler.prototype.onGuildInvitePush = function(cb){
	this.socket.on('area.guildPush.guildInvitePush',cb);
}

GuildHandler.prototype.onOnDungeonEndPush = function(cb){
	this.socket.on('area.guildPush.onDungeonEndPush',cb);
}

GuildHandler.prototype.onGuildDungeonOpenPush = function(cb){
	this.socket.on('area.guildPush.guildDungeonOpenPush',cb);
}

GuildHandler.prototype.onGuildDungeonPassPush = function(cb){
	this.socket.on('area.guildPush.guildDungeonPassPush',cb);
}

GuildHandler.prototype.onGuildDungeonPlayerNumPush = function(cb){
	this.socket.on('area.guildPush.guildDungeonPlayerNumPush',cb);
}

module.exports = GuildHandler;
