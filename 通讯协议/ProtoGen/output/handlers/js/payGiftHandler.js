/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var PayGiftHandler = function(socket){
	this.socket = socket;
}

PayGiftHandler.prototype.firstPayGiftInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.payGiftHandler.firstPayGiftInfoRequest',{}));
});

PayGiftHandler.prototype.getFirstPayGiftRequest = async(function(){
	return await(this.socket.requestAsync('area.payGiftHandler.getFirstPayGiftRequest',{}));
});

PayGiftHandler.prototype.dailyPayGiftInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.payGiftHandler.dailyPayGiftInfoRequest',{}));
});

PayGiftHandler.prototype.getDailyPayGiftRequest = async(function(c2s_giftId){
	return await(this.socket.requestAsync('area.payGiftHandler.getDailyPayGiftRequest',{c2s_giftId:c2s_giftId}));
});


module.exports = PayGiftHandler;
