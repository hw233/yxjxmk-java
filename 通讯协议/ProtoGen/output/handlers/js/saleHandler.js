/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var SaleHandler = function(socket){
	this.socket = socket;
}

SaleHandler.prototype.buyPageRequest = async(function(c2s_sellIndex){
	return await(this.socket.requestAsync('area.saleHandler.buyPageRequest',{c2s_sellIndex:c2s_sellIndex}));
});

SaleHandler.prototype.buyItemRequest = async(function(c2s_typeId,c2s_itemId,c2s_num){
	return await(this.socket.requestAsync('area.saleHandler.buyItemRequest',{c2s_typeId:c2s_typeId,c2s_itemId:c2s_itemId,c2s_num:c2s_num}));
});

SaleHandler.prototype.autoBuyItemByCodeRequest = async(function(c2s_typeId,c2s_itemCode,c2s_num){
	return await(this.socket.requestAsync('area.saleHandler.autoBuyItemByCodeRequest',{c2s_typeId:c2s_typeId,c2s_itemCode:c2s_itemCode,c2s_num:c2s_num}));
});

SaleHandler.prototype.sellItemsRequest = async(function(c2s_sellGrids){
	return await(this.socket.requestAsync('area.saleHandler.sellItemsRequest',{c2s_sellGrids:c2s_sellGrids}));
});

SaleHandler.prototype.rebuyItemRequest = async(function(c2s_gridIndex,c2s_num){
	return await(this.socket.requestAsync('area.saleHandler.rebuyItemRequest',{c2s_gridIndex:c2s_gridIndex,c2s_num:c2s_num}));
});


module.exports = SaleHandler;
