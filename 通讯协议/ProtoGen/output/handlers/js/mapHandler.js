/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MapHandler = function(socket){
	this.socket = socket;
}

MapHandler.prototype.enterSceneByAreaIdRequest = async(function(c2s_areaId){
	return await(this.socket.requestAsync('area.mapHandler.enterSceneByAreaIdRequest',{c2s_areaId:c2s_areaId}));
});

MapHandler.prototype.getWorldMapListRequest = async(function(){
	return await(this.socket.requestAsync('area.mapHandler.getWorldMapListRequest',{}));
});

MapHandler.prototype.getPlayerListRequest = async(function(){
	return await(this.socket.requestAsync('area.mapHandler.getPlayerListRequest',{}));
});

MapHandler.prototype.getMonsterListRequest = async(function(){
	return await(this.socket.requestAsync('area.mapHandler.getMonsterListRequest',{}));
});

MapHandler.prototype.getNpcListRequest = async(function(){
	return await(this.socket.requestAsync('area.mapHandler.getNpcListRequest',{}));
});

MapHandler.prototype.getMapListRequest = async(function(c2s_mapId){
	return await(this.socket.requestAsync('area.mapHandler.getMapListRequest',{c2s_mapId:c2s_mapId}));
});

MapHandler.prototype.getAliveMonsterLineInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.mapHandler.getAliveMonsterLineInfoRequest',{}));
});


module.exports = MapHandler;
