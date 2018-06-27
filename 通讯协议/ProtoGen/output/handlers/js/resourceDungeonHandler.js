/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ResourceDungeonHandler = function(socket){
	this.socket = socket;
}

ResourceDungeonHandler.prototype.queryResourceDugeonInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.queryResourceDugeonInfoRequest',{}));
});

ResourceDungeonHandler.prototype.buyTimesRequest = async(function(dungeonId){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.buyTimesRequest',{dungeonId:dungeonId}));
});

ResourceDungeonHandler.prototype.enterResourceDugeonInfoRequest = async(function(dungeonId){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.enterResourceDugeonInfoRequest',{dungeonId:dungeonId}));
});

ResourceDungeonHandler.prototype.receiveDoubleRewardRequest = async(function(dungeonId){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.receiveDoubleRewardRequest',{dungeonId:dungeonId}));
});

ResourceDungeonHandler.prototype.resourceCountDownRequest = async(function(dungeonId){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.resourceCountDownRequest',{dungeonId:dungeonId}));
});

ResourceDungeonHandler.prototype.resourceSweepRequest = async(function(dungeonId){
	return await(this.socket.requestAsync('area.resourceDungeonHandler.resourceSweepRequest',{dungeonId:dungeonId}));
});


module.exports = ResourceDungeonHandler;
