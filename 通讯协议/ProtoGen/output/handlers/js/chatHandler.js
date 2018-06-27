/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ChatHandler = function(socket){
	this.socket = socket;
}

ChatHandler.prototype.sendChatRequest = async(function(c2s_scope,c2s_content,c2s_serverData,c2s_acceptRoleId){
	return await(this.socket.requestAsync('chat.chatHandler.sendChatRequest',{c2s_scope:c2s_scope,c2s_content:c2s_content,c2s_serverData:c2s_serverData,c2s_acceptRoleId:c2s_acceptRoleId}));
});

ChatHandler.prototype.getSaveChatMsgRequest = async(function(c2s_scope,c2s_index,c2s_uid){
	return await(this.socket.requestAsync('chat.chatHandler.getSaveChatMsgRequest',{c2s_scope:c2s_scope,c2s_index:c2s_index,c2s_uid:c2s_uid}));
});


ChatHandler.prototype.onOnChatPush = function(cb){
	this.socket.on('chat.chatPush.onChatPush',cb);
}

ChatHandler.prototype.onOnChatErrorPush = function(cb){
	this.socket.on('chat.chatPush.onChatErrorPush',cb);
}

ChatHandler.prototype.onTipPush = function(cb){
	this.socket.on('chat.chatPush.tipPush',cb);
}

module.exports = ChatHandler;
