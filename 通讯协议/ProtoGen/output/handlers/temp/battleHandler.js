/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var BattleHandler = function(socket){
	this.socket = socket;
}

BattleHandler.prototype.throwPointRequest = async(function(id){
	return await(this.socket.requestAsync('area.battleHandler.throwPointRequest',{id:id}));
});


BattleHandler.prototype.onThrowPointItemListPush = function(cb){
	this.socket.on('area.battlePush.throwPointItemListPush',cb);
}

BattleHandler.prototype.onThrowPointResultPush = function(cb){
	this.socket.on('area.battlePush.throwPointResultPush',cb);
}

BattleHandler.prototype.onFightLevelResultPush = function(cb){
	this.socket.on('area.battlePush.fightLevelResultPush',cb);
}

BattleHandler.prototype.onItemDropPush = function(cb){
	this.socket.on('area.battlePush.itemDropPush',cb);
}

BattleHandler.prototype.onSceneNamePush = function(cb){
	this.socket.on('area.battlePush.sceneNamePush',cb);
}

BattleHandler.prototype.onResourceDungeonResultPush = function(cb){
	this.socket.on('area.battlePush.resourceDungeonResultPush',cb);
}

module.exports = BattleHandler;
