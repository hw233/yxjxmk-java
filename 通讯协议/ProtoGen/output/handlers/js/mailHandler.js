/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MailHandler = function(socket){
	this.socket = socket;
}

MailHandler.prototype.mailGetAllRequest = async(function(){
	return await(this.socket.requestAsync('area.mailHandler.mailGetAllRequest',{}));
});

MailHandler.prototype.mailSendMailRequest = async(function(toPlayerId,mailTitle,mailText,mailRead,toPlayerName){
	return await(this.socket.requestAsync('area.mailHandler.mailSendMailRequest',{toPlayerId:toPlayerId,mailTitle:mailTitle,mailText:mailText,mailRead:mailRead,toPlayerName:toPlayerName}));
});

MailHandler.prototype.mailDeleteRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.mailHandler.mailDeleteRequest',{c2s_id:c2s_id}));
});

MailHandler.prototype.mailDeleteOneKeyRequest = async(function(){
	return await(this.socket.requestAsync('area.mailHandler.mailDeleteOneKeyRequest',{}));
});

MailHandler.prototype.mailGetAttachmentRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.mailHandler.mailGetAttachmentRequest',{c2s_id:c2s_id}));
});

MailHandler.prototype.mailGetAttachmentOneKeyRequest = async(function(){
	return await(this.socket.requestAsync('area.mailHandler.mailGetAttachmentOneKeyRequest',{}));
});

MailHandler.prototype.mailReadNotify = function(c2s_id){
	return this.socket.notify('area.mailHandler.mailReadNotify',{c2s_id:c2s_id});
};

MailHandler.prototype.mailSendTestNotify = function(c2s_mailId,c2s_tcCode){
	return this.socket.notify('area.mailHandler.mailSendTestNotify',{c2s_mailId:c2s_mailId,c2s_tcCode:c2s_tcCode});
};


MailHandler.prototype.onOnGetMailPush = function(cb){
	this.socket.on('area.mailPush.onGetMailPush',cb);
}

module.exports = MailHandler;
