/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ItemHandler = function(socket){
	this.socket = socket;
}

ItemHandler.prototype.getAllEquipDetailsRequest = async(function(){
	return await(this.socket.requestAsync('area.itemHandler.getAllEquipDetailsRequest',{}));
});

ItemHandler.prototype.getCombineFormulaRequest = async(function(c2s_destID){
	return await(this.socket.requestAsync('area.itemHandler.getCombineFormulaRequest',{c2s_destID:c2s_destID}));
});

ItemHandler.prototype.combineRequest = async(function(c2s_destID,c2s_num,c2s_gridIndex){
	return await(this.socket.requestAsync('area.itemHandler.combineRequest',{c2s_destID:c2s_destID,c2s_num:c2s_num,c2s_gridIndex:c2s_gridIndex}));
});

ItemHandler.prototype.queryItemStatusUpdateNotify = function(index){
	return this.socket.notify('area.itemHandler.queryItemStatusUpdateNotify',{index:index});
};


ItemHandler.prototype.onFishItemPush = function(cb){
	this.socket.on('area.itemPush.fishItemPush',cb);
}

ItemHandler.prototype.onCountItemChangePush = function(cb){
	this.socket.on('area.itemPush.countItemChangePush',cb);
}

ItemHandler.prototype.onItemDetailPush = function(cb){
	this.socket.on('area.itemPush.itemDetailPush',cb);
}

ItemHandler.prototype.onRewardItemPush = function(cb){
	this.socket.on('area.itemPush.rewardItemPush',cb);
}

module.exports = ItemHandler;
