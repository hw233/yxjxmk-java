/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FightLevelHandler = function(socket){
	this.socket = socket;
}

FightLevelHandler.prototype.fubenListRequest = async(function(mapId){
	return await(this.socket.requestAsync('area.fightLevelHandler.fubenListRequest',{mapId:mapId}));
});

FightLevelHandler.prototype.enterDungeonRequest = async(function(c2s_dungeonId){
	return await(this.socket.requestAsync('area.fightLevelHandler.enterDungeonRequest',{c2s_dungeonId:c2s_dungeonId}));
});

FightLevelHandler.prototype.replyEnterDungeonRequest = async(function(c2s_type,c2s_dungeonId){
	return await(this.socket.requestAsync('area.fightLevelHandler.replyEnterDungeonRequest',{c2s_type:c2s_type,c2s_dungeonId:c2s_dungeonId}));
});

FightLevelHandler.prototype.leaveDungeonRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.leaveDungeonRequest',{}));
});

FightLevelHandler.prototype.worldBossListRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.worldBossListRequest',{}));
});

FightLevelHandler.prototype.enterWorldBossRequest = async(function(s2c_areaId){
	return await(this.socket.requestAsync('area.fightLevelHandler.enterWorldBossRequest',{s2c_areaId:s2c_areaId}));
});

FightLevelHandler.prototype.getMonsterLeaderRequest = async(function(s2c_monsterId,s2c_areaId){
	return await(this.socket.requestAsync('area.fightLevelHandler.getMonsterLeaderRequest',{s2c_monsterId:s2c_monsterId,s2c_areaId:s2c_areaId}));
});

FightLevelHandler.prototype.palaceListRequest = async(function(s2c_type){
	return await(this.socket.requestAsync('area.fightLevelHandler.palaceListRequest',{s2c_type:s2c_type}));
});

FightLevelHandler.prototype.getBossInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getBossInfoRequest',{}));
});

FightLevelHandler.prototype.getBossDamageRankRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getBossDamageRankRequest',{}));
});

FightLevelHandler.prototype.getLllsionInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getLllsionInfoRequest',{}));
});

FightLevelHandler.prototype.enterLllsionRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.fightLevelHandler.enterLllsionRequest',{c2s_id:c2s_id}));
});

FightLevelHandler.prototype.getLllsionBossInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getLllsionBossInfoRequest',{}));
});

FightLevelHandler.prototype.enterLllsionBossRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.fightLevelHandler.enterLllsionBossRequest',{c2s_id:c2s_id}));
});

FightLevelHandler.prototype.getBenifitableRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getBenifitableRequest',{}));
});

FightLevelHandler.prototype.getLllsion2InfoRequest = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.getLllsion2InfoRequest',{}));
});

FightLevelHandler.prototype.enterLllsion2Request = async(function(){
	return await(this.socket.requestAsync('area.fightLevelHandler.enterLllsion2Request',{}));
});


FightLevelHandler.prototype.onOnConfirmEnterFubenPush = function(cb){
	this.socket.on('area.fightLevelPush.onConfirmEnterFubenPush',cb);
}

FightLevelHandler.prototype.onOnMemberEnterFubenStateChangePush = function(cb){
	this.socket.on('area.fightLevelPush.onMemberEnterFubenStateChangePush',cb);
}

FightLevelHandler.prototype.onOnFubenClosePush = function(cb){
	this.socket.on('area.fightLevelPush.onFubenClosePush',cb);
}

FightLevelHandler.prototype.onCloseHandUpPush = function(cb){
	this.socket.on('area.fightLevelPush.closeHandUpPush',cb);
}

FightLevelHandler.prototype.onIllusionPush = function(cb){
	this.socket.on('area.fightLevelPush.illusionPush',cb);
}

FightLevelHandler.prototype.onIllusion2Push = function(cb){
	this.socket.on('area.fightLevelPush.illusion2Push',cb);
}

module.exports = FightLevelHandler;
