/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var DaoYouHandler = function(socket){
	this.socket = socket;
}

DaoYouHandler.prototype.daoYouRequest = async(function(){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouRequest',{}));
});

DaoYouHandler.prototype.daoYouInviteDaoYouRequest = async(function(playerId){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouInviteDaoYouRequest',{playerId:playerId}));
});

DaoYouHandler.prototype.daoYouFastInviteDaoYouRequest = async(function(){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouFastInviteDaoYouRequest',{}));
});

DaoYouHandler.prototype.daoYouEditTeamNameRequest = async(function(teamName){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouEditTeamNameRequest',{teamName:teamName}));
});

DaoYouHandler.prototype.daoYouLeaveMessageRequest = async(function(message){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouLeaveMessageRequest',{message:message}));
});

DaoYouHandler.prototype.daoYouNoticeRequest = async(function(notice){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouNoticeRequest',{notice:notice}));
});

DaoYouHandler.prototype.daoYouKickTeamRequest = async(function(playerId){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouKickTeamRequest',{playerId:playerId}));
});

DaoYouHandler.prototype.daoYouTransferAdminRequest = async(function(playerId){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouTransferAdminRequest',{playerId:playerId}));
});

DaoYouHandler.prototype.daoYouQuitTeamRequest = async(function(){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouQuitTeamRequest',{}));
});

DaoYouHandler.prototype.daoYouRebateRequest = async(function(){
	return await(this.socket.requestAsync('daoyou.daoYouHandler.daoYouRebateRequest',{}));
});


module.exports = DaoYouHandler;
