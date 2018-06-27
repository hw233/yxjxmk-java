/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildDepotHandler = function(socket){
	this.socket = socket;
}

GuildDepotHandler.prototype.depositItemRequest = async(function(c2s_fromIndex){
	return await(this.socket.requestAsync('area.guildDepotHandler.depositItemRequest',{c2s_fromIndex:c2s_fromIndex}));
});

GuildDepotHandler.prototype.takeOutItemRequest = async(function(c2s_fromIndex){
	return await(this.socket.requestAsync('area.guildDepotHandler.takeOutItemRequest',{c2s_fromIndex:c2s_fromIndex}));
});

GuildDepotHandler.prototype.setConditionRequest = async(function(useLevel,useUpLevel,useJob,minLevel,minUpLevel,minqColor,maxLevel,maxUpLevel,maxqColor){
	return await(this.socket.requestAsync('area.guildDepotHandler.setConditionRequest',{useLevel:useLevel,useUpLevel:useUpLevel,useJob:useJob,minLevel:minLevel,minUpLevel:minUpLevel,minqColor:minqColor,maxLevel:maxLevel,maxUpLevel:maxUpLevel,maxqColor:maxqColor}));
});

GuildDepotHandler.prototype.deleteItemRequest = async(function(c2s_fromIndex){
	return await(this.socket.requestAsync('area.guildDepotHandler.deleteItemRequest',{c2s_fromIndex:c2s_fromIndex}));
});

GuildDepotHandler.prototype.upgradeDepotRequest = async(function(){
	return await(this.socket.requestAsync('area.guildDepotHandler.upgradeDepotRequest',{}));
});


GuildDepotHandler.prototype.onDepotRefreshPush = function(cb){
	this.socket.on('area.guildDepotPush.depotRefreshPush',cb);
}

module.exports = GuildDepotHandler;
