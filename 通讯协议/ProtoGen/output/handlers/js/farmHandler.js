/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FarmHandler = function(socket){
	this.socket = socket;
}

FarmHandler.prototype.myFarmInfoRequest = async(function(){
	return await(this.socket.requestAsync('farm.farmHandler.myFarmInfoRequest',{}));
});

FarmHandler.prototype.friendFarmInfoRequest = async(function(playerId){
	return await(this.socket.requestAsync('farm.farmHandler.friendFarmInfoRequest',{playerId:playerId}));
});

FarmHandler.prototype.friendLsRequest = async(function(){
	return await(this.socket.requestAsync('farm.farmHandler.friendLsRequest',{}));
});

FarmHandler.prototype.openRequest = async(function(blockId){
	return await(this.socket.requestAsync('farm.farmHandler.openRequest',{blockId:blockId}));
});

FarmHandler.prototype.sowRequest = async(function(blockId,seedCode){
	return await(this.socket.requestAsync('farm.farmHandler.sowRequest',{blockId:blockId,seedCode:seedCode}));
});

FarmHandler.prototype.cultivateFriendRequest = async(function(blockId,cultivateType,friendId){
	return await(this.socket.requestAsync('farm.farmHandler.cultivateFriendRequest',{blockId:blockId,cultivateType:cultivateType,friendId:friendId}));
});

FarmHandler.prototype.cultivateSelfRequest = async(function(blockId,cultivateType){
	return await(this.socket.requestAsync('farm.farmHandler.cultivateSelfRequest',{blockId:blockId,cultivateType:cultivateType}));
});

FarmHandler.prototype.stealRequest = async(function(blockId,friendId){
	return await(this.socket.requestAsync('farm.farmHandler.stealRequest',{blockId:blockId,friendId:friendId}));
});

FarmHandler.prototype.harvestRequest = async(function(blockId){
	return await(this.socket.requestAsync('farm.farmHandler.harvestRequest',{blockId:blockId}));
});

FarmHandler.prototype.getShopInfoRequest = async(function(){
	return await(this.socket.requestAsync('farm.farmHandler.getShopInfoRequest',{}));
});

FarmHandler.prototype.changeShopItemRequest = async(function(itemId){
	return await(this.socket.requestAsync('farm.farmHandler.changeShopItemRequest',{itemId:itemId}));
});


module.exports = FarmHandler;
