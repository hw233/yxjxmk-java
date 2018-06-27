/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var AmuletHandler = function(socket){
	this.socket = socket;
}

AmuletHandler.prototype.getAllAmuletRequest = async(function(){
	return await(this.socket.requestAsync('area.amuletHandler.getAllAmuletRequest',{}));
});

AmuletHandler.prototype.equipAmuletRequest = async(function(c2s_gridIndex){
	return await(this.socket.requestAsync('area.amuletHandler.equipAmuletRequest',{c2s_gridIndex:c2s_gridIndex}));
});

AmuletHandler.prototype.unEquipAmuletRequest = async(function(c2s_gridIndex){
	return await(this.socket.requestAsync('area.amuletHandler.unEquipAmuletRequest',{c2s_gridIndex:c2s_gridIndex}));
});

AmuletHandler.prototype.unAllEquipAmuletRequest = async(function(){
	return await(this.socket.requestAsync('area.amuletHandler.unAllEquipAmuletRequest',{}));
});


AmuletHandler.prototype.onAmuletEquipNewPush = function(cb){
	this.socket.on('area.amuletPush.amuletEquipNewPush',cb);
}

module.exports = AmuletHandler;
