/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var TeamHandler = function(socket){
	this.socket = socket;
}

TeamHandler.prototype.gotoTeamTargetRequest = async(function(targetId,difficulty){
	return await(this.socket.requestAsync('area.teamHandler.gotoTeamTargetRequest',{targetId:targetId,difficulty:difficulty}));
});

TeamHandler.prototype.summonRequest = async(function(c2s_teamMemberId){
	return await(this.socket.requestAsync('area.teamHandler.summonRequest',{c2s_teamMemberId:c2s_teamMemberId}));
});

TeamHandler.prototype.summonConfirmRequest = async(function(c2s_id,s2c_operate){
	return await(this.socket.requestAsync('area.teamHandler.summonConfirmRequest',{c2s_id:c2s_id,s2c_operate:s2c_operate}));
});

TeamHandler.prototype.autoJoinTeamRequest = async(function(c2s_targetId,c2s_difficulty){
	return await(this.socket.requestAsync('area.teamHandler.autoJoinTeamRequest',{c2s_targetId:c2s_targetId,c2s_difficulty:c2s_difficulty}));
});

TeamHandler.prototype.joinTeamRequest = async(function(c2s_teamId){
	return await(this.socket.requestAsync('area.teamHandler.joinTeamRequest',{c2s_teamId:c2s_teamId}));
});

TeamHandler.prototype.getAppliedPlayersRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.getAppliedPlayersRequest',{}));
});

TeamHandler.prototype.getPlayersByTypeRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.teamHandler.getPlayersByTypeRequest',{c2s_type:c2s_type}));
});

TeamHandler.prototype.queryTeamByTargetRequest = async(function(c2s_targetId,c2s_difficulty){
	return await(this.socket.requestAsync('area.teamHandler.queryTeamByTargetRequest',{c2s_targetId:c2s_targetId,c2s_difficulty:c2s_difficulty}));
});

TeamHandler.prototype.setTeamTargetRequest = async(function(c2s_targetId,c2s_difficulty,c2s_minLevel,c2s_maxLevel,c2s_isAutoTeam,c2s_isAutoStart){
	return await(this.socket.requestAsync('area.teamHandler.setTeamTargetRequest',{c2s_targetId:c2s_targetId,c2s_difficulty:c2s_difficulty,c2s_minLevel:c2s_minLevel,c2s_maxLevel:c2s_maxLevel,c2s_isAutoTeam:c2s_isAutoTeam,c2s_isAutoStart:c2s_isAutoStart}));
});

TeamHandler.prototype.createTeamRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.createTeamRequest',{}));
});

TeamHandler.prototype.followLeaderRequest = async(function(follow){
	return await(this.socket.requestAsync('area.teamHandler.followLeaderRequest',{follow:follow}));
});

TeamHandler.prototype.formTeamRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.teamHandler.formTeamRequest',{c2s_playerId:c2s_playerId}));
});

TeamHandler.prototype.getTeamMembersRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.getTeamMembersRequest',{}));
});

TeamHandler.prototype.getNearbyPlayersRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.getNearbyPlayersRequest',{}));
});

TeamHandler.prototype.getNearTeamsRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.getNearTeamsRequest',{}));
});

TeamHandler.prototype.changeTeamLeaderRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.teamHandler.changeTeamLeaderRequest',{c2s_playerId:c2s_playerId}));
});

TeamHandler.prototype.kickOutTeamRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.teamHandler.kickOutTeamRequest',{c2s_playerId:c2s_playerId}));
});

TeamHandler.prototype.leaveTeamRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.leaveTeamRequest',{}));
});

TeamHandler.prototype.setAutoAcceptTeamRequest = async(function(c2s_isAccept){
	return await(this.socket.requestAsync('area.teamHandler.setAutoAcceptTeamRequest',{c2s_isAccept:c2s_isAccept}));
});

TeamHandler.prototype.cancelAutoRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.cancelAutoRequest',{}));
});

TeamHandler.prototype.acrossMatchRequest = async(function(targetId,difficulty){
	return await(this.socket.requestAsync('area.teamHandler.acrossMatchRequest',{targetId:targetId,difficulty:difficulty}));
});

TeamHandler.prototype.leaveAcrossMatchRequest = async(function(){
	return await(this.socket.requestAsync('area.teamHandler.leaveAcrossMatchRequest',{}));
});


TeamHandler.prototype.onOnSummonTeamPush = function(cb){
	this.socket.on('area.teamPush.onSummonTeamPush',cb);
}

TeamHandler.prototype.onOnTeamUpdatePush = function(cb){
	this.socket.on('area.teamPush.onTeamUpdatePush',cb);
}

TeamHandler.prototype.onOnTeamMemberUpdatePush = function(cb){
	this.socket.on('area.teamPush.onTeamMemberUpdatePush',cb);
}

TeamHandler.prototype.onOnTeamTargetPush = function(cb){
	this.socket.on('area.teamPush.onTeamTargetPush',cb);
}

TeamHandler.prototype.onOnAcrossTeamInfoPush = function(cb){
	this.socket.on('area.teamPush.onAcrossTeamInfoPush',cb);
}

module.exports = TeamHandler;
