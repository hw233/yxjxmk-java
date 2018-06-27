/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MessageHandler = function(socket){
	this.socket = socket;
}

MessageHandler.prototype.handleMessageRequest = async(function(c2s_id,c2s_type,c2s_operate){
	return await(this.socket.requestAsync('area.messageHandler.handleMessageRequest',{c2s_id:c2s_id,c2s_type:c2s_type,c2s_operate:c2s_operate}));
});


MessageHandler.prototype.onOnMessageAddPush = function(cb){
	this.socket.on('area.messagePush.onMessageAddPush',cb);
}

module.exports = MessageHandler;
