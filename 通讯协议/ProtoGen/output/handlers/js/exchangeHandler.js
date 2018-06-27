/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ExchangeHandler = function(socket){
	this.socket = socket;
}

ExchangeHandler.prototype.getExchangeLabelRequest = async(function(c2s_npcId){
	return await(this.socket.requestAsync('area.exchangeHandler.getExchangeLabelRequest',{c2s_npcId:c2s_npcId}));
});

ExchangeHandler.prototype.getExchangeListRequest = async(function(c2s_npcId,c2s_typeId){
	return await(this.socket.requestAsync('area.exchangeHandler.getExchangeListRequest',{c2s_npcId:c2s_npcId,c2s_typeId:c2s_typeId}));
});

ExchangeHandler.prototype.exchangeItemRequest = async(function(c2s_typeId,c2s_itemId,c2s_num,c2s_npcId){
	return await(this.socket.requestAsync('area.exchangeHandler.exchangeItemRequest',{c2s_typeId:c2s_typeId,c2s_itemId:c2s_itemId,c2s_num:c2s_num,c2s_npcId:c2s_npcId}));
});

ExchangeHandler.prototype.allyFightExchangeRequest = async(function(c2s_npcId,c2s_typeId){
	return await(this.socket.requestAsync('area.exchangeHandler.allyFightExchangeRequest',{c2s_npcId:c2s_npcId,c2s_typeId:c2s_typeId}));
});


module.exports = ExchangeHandler;
