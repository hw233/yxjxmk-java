/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var BagHandler = function(socket){
	this.socket = socket;
}

BagHandler.prototype.packUpBagRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.bagHandler.packUpBagRequest',{c2s_type:c2s_type}));
});

BagHandler.prototype.openBagGridRequest = async(function(c2s_type,c2s_number){
	return await(this.socket.requestAsync('area.bagHandler.openBagGridRequest',{c2s_type:c2s_type,c2s_number:c2s_number}));
});

BagHandler.prototype.transferItemRequest = async(function(c2s_fromType,c2s_fromIndex,c2s_toType,c2s_num){
	return await(this.socket.requestAsync('area.bagHandler.transferItemRequest',{c2s_fromType:c2s_fromType,c2s_fromIndex:c2s_fromIndex,c2s_toType:c2s_toType,c2s_num:c2s_num}));
});

BagHandler.prototype.sellItemRequest = async(function(c2s_gridIndex,c2s_num){
	return await(this.socket.requestAsync('area.bagHandler.sellItemRequest',{c2s_gridIndex:c2s_gridIndex,c2s_num:c2s_num}));
});

BagHandler.prototype.useItemRequest = async(function(c2s_gridIndex,c2s_num){
	return await(this.socket.requestAsync('area.bagHandler.useItemRequest',{c2s_gridIndex:c2s_gridIndex,c2s_num:c2s_num}));
});

BagHandler.prototype.addBagItemTestNotify = function(){
	return this.socket.notify('area.bagHandler.addBagItemTestNotify',{});
};


BagHandler.prototype.onBagItemUpdatePush = function(cb){
	this.socket.on('area.bagPush.bagItemUpdatePush',cb);
}

BagHandler.prototype.onBagNewItemPush = function(cb){
	this.socket.on('area.bagPush.bagNewItemPush',cb);
}

BagHandler.prototype.onBagNewEquipPush = function(cb){
	this.socket.on('area.bagPush.bagNewEquipPush',cb);
}

BagHandler.prototype.onBagGridFullPush = function(cb){
	this.socket.on('area.bagPush.bagGridFullPush',cb);
}

BagHandler.prototype.onBagGridNumPush = function(cb){
	this.socket.on('area.bagPush.bagGridNumPush',cb);
}

module.exports = BagHandler;
