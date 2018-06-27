/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var VipHandler = function(socket){
	this.socket = socket;
}

VipHandler.prototype.vipInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.vipHandler.vipInfoRequest',{}));
});

VipHandler.prototype.getEveryDayGiftRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.vipHandler.getEveryDayGiftRequest',{c2s_type:c2s_type}));
});

VipHandler.prototype.buyEveryDayGiftRequest = async(function(c2s_vipLevel){
	return await(this.socket.requestAsync('area.vipHandler.buyEveryDayGiftRequest',{c2s_vipLevel:c2s_vipLevel}));
});

VipHandler.prototype.buyVipCardRequest = async(function(c2s_typeId,c2s_itemId,c2s_type){
	return await(this.socket.requestAsync('area.vipHandler.buyVipCardRequest',{c2s_typeId:c2s_typeId,c2s_itemId:c2s_itemId,c2s_type:c2s_type}));
});


module.exports = VipHandler;
