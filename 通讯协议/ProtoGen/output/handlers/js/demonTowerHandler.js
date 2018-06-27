/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var DemonTowerHandler = function(socket){
	this.socket = socket;
}

DemonTowerHandler.prototype.getDemonTowerInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.demonTowerHandler.getDemonTowerInfoRequest',{}));
});

DemonTowerHandler.prototype.getDemonTowerSweepInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.demonTowerHandler.getDemonTowerSweepInfoRequest',{}));
});

DemonTowerHandler.prototype.startToSweepDemonTowerRequest = async(function(){
	return await(this.socket.requestAsync('area.demonTowerHandler.startToSweepDemonTowerRequest',{}));
});

DemonTowerHandler.prototype.startDemonTowerRequest = async(function(){
	return await(this.socket.requestAsync('area.demonTowerHandler.startDemonTowerRequest',{}));
});

DemonTowerHandler.prototype.finishSweepDemonTowerRequest = async(function(){
	return await(this.socket.requestAsync('area.demonTowerHandler.finishSweepDemonTowerRequest',{}));
});


DemonTowerHandler.prototype.onSweepDemonTowerEndPush = function(cb){
	this.socket.on('area.demonTowerPush.sweepDemonTowerEndPush',cb);
}

module.exports = DemonTowerHandler;
