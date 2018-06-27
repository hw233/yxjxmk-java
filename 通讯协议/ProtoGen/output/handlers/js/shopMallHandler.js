/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ShopMallHandler = function(socket){
	this.socket = socket;
}

ShopMallHandler.prototype.getMallTabsRequest = async(function(){
	return await(this.socket.requestAsync('area.shopMallHandler.getMallTabsRequest',{}));
});

ShopMallHandler.prototype.getMallScoreItemListRequest = async(function(){
	return await(this.socket.requestAsync('area.shopMallHandler.getMallScoreItemListRequest',{}));
});

ShopMallHandler.prototype.buyMallItemRequest = async(function(c2s_itemId,c2s_count,c2s_playerId,c2s_bDiamond){
	return await(this.socket.requestAsync('area.shopMallHandler.buyMallItemRequest',{c2s_itemId:c2s_itemId,c2s_count:c2s_count,c2s_playerId:c2s_playerId,c2s_bDiamond:c2s_bDiamond}));
});

ShopMallHandler.prototype.getMallItemListRequest = async(function(c2s_moneyType,c2s_itemType){
	return await(this.socket.requestAsync('area.shopMallHandler.getMallItemListRequest',{c2s_moneyType:c2s_moneyType,c2s_itemType:c2s_itemType}));
});

ShopMallHandler.prototype.buyMallScoreItemRequest = async(function(c2s_itemId){
	return await(this.socket.requestAsync('area.shopMallHandler.buyMallScoreItemRequest',{c2s_itemId:c2s_itemId}));
});


module.exports = ShopMallHandler;
