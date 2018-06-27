/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var TradeHandler = function(socket){
	this.socket = socket;
}

TradeHandler.prototype.inviteRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('area.tradeHandler.inviteRequest',{c2s_playerId:c2s_playerId}));
});

TradeHandler.prototype.addItemRequest = async(function(c2s_diamond,c2s_items){
	return await(this.socket.requestAsync('area.tradeHandler.addItemRequest',{c2s_diamond:c2s_diamond,c2s_items:c2s_items}));
});

TradeHandler.prototype.removeItemRequest = async(function(c2s_indexs){
	return await(this.socket.requestAsync('area.tradeHandler.removeItemRequest',{c2s_indexs:c2s_indexs}));
});

TradeHandler.prototype.tradeOperateRequest = async(function(c2s_operate,c2s_diamond,c2s_items){
	return await(this.socket.requestAsync('area.tradeHandler.tradeOperateRequest',{c2s_operate:c2s_operate,c2s_diamond:c2s_diamond,c2s_items:c2s_items}));
});


TradeHandler.prototype.onTradeBeginPush = function(cb){
	this.socket.on('area.tradePush.tradeBeginPush',cb);
}

TradeHandler.prototype.onTradeItemChangePush = function(cb){
	this.socket.on('area.tradePush.tradeItemChangePush',cb);
}

TradeHandler.prototype.onTradeOperatePush = function(cb){
	this.socket.on('area.tradePush.tradeOperatePush',cb);
}

module.exports = TradeHandler;
