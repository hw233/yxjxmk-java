/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var TreasureHandler = function(socket){
	this.socket = socket;
}

TreasureHandler.prototype.getTreasureInfoRequest = async(function(c2s_treasureMsg){
	return await(this.socket.requestAsync('area.treasureHandler.getTreasureInfoRequest',{c2s_treasureMsg:c2s_treasureMsg}));
});

TreasureHandler.prototype.getTreasureBagInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.treasureHandler.getTreasureBagInfoRequest',{}));
});

TreasureHandler.prototype.openTreasureRequest = async(function(c2s_openType,c2s_useDiamond){
	return await(this.socket.requestAsync('area.treasureHandler.openTreasureRequest',{c2s_openType:c2s_openType,c2s_useDiamond:c2s_useDiamond}));
});

TreasureHandler.prototype.receiveTreasureBagRequest = async(function(){
	return await(this.socket.requestAsync('area.treasureHandler.receiveTreasureBagRequest',{}));
});


module.exports = TreasureHandler;
