/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var IntergalMallHandler = function(socket){
	this.socket = socket;
}

IntergalMallHandler.prototype.getMallScoreItemListRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.intergalMallHandler.getMallScoreItemListRequest',{c2s_type:c2s_type}));
});

IntergalMallHandler.prototype.buyIntergalItemRequest = async(function(c2s_type,c2s_itemId,c2s_num){
	return await(this.socket.requestAsync('area.intergalMallHandler.buyIntergalItemRequest',{c2s_type:c2s_type,c2s_itemId:c2s_itemId,c2s_num:c2s_num}));
});


module.exports = IntergalMallHandler;
