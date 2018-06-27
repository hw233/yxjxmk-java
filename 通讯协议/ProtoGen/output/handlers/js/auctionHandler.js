/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var AuctionHandler = function(socket){
	this.socket = socket;
}

AuctionHandler.prototype.syncAuctionInfoRequest = async(function(){
	return await(this.socket.requestAsync('auction.auctionHandler.syncAuctionInfoRequest',{}));
});

AuctionHandler.prototype.cancelSyncAuctionInfoRequest = async(function(){
	return await(this.socket.requestAsync('auction.auctionHandler.cancelSyncAuctionInfoRequest',{}));
});

AuctionHandler.prototype.auctionListRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('auction.auctionHandler.auctionListRequest',{c2s_type:c2s_type}));
});

AuctionHandler.prototype.auctionRequest = async(function(itemId,price){
	return await(this.socket.requestAsync('auction.auctionHandler.auctionRequest',{itemId:itemId,price:price}));
});

AuctionHandler.prototype.auctionLogRequest = async(function(){
	return await(this.socket.requestAsync('auction.auctionHandler.auctionLogRequest',{}));
});


AuctionHandler.prototype.onAuctionItemPush = function(cb){
	this.socket.on('auction.auctionPush.auctionItemPush',cb);
}

AuctionHandler.prototype.onAddAuctionItemPush = function(cb){
	this.socket.on('auction.auctionPush.addAuctionItemPush',cb);
}

AuctionHandler.prototype.onRemoveAuctionItemPush = function(cb){
	this.socket.on('auction.auctionPush.removeAuctionItemPush',cb);
}

module.exports = AuctionHandler;
