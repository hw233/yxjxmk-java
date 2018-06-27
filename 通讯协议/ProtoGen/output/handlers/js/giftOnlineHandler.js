/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GiftOnlineHandler = function(socket){
	this.socket = socket;
}

GiftOnlineHandler.prototype.getOnLineGiftRequest = async(function(){
	return await(this.socket.requestAsync('area.giftOnlineHandler.getOnLineGiftRequest',{}));
});


module.exports = GiftOnlineHandler;
