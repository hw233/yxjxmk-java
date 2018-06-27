/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildBlessHandler = function(socket){
	this.socket = socket;
}

GuildBlessHandler.prototype.getMyBlessInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.guildBlessHandler.getMyBlessInfoRequest',{}));
});

GuildBlessHandler.prototype.blessActionRequest = async(function(id){
	return await(this.socket.requestAsync('area.guildBlessHandler.blessActionRequest',{id:id}));
});

GuildBlessHandler.prototype.receiveBlessGiftRequest = async(function(index){
	return await(this.socket.requestAsync('area.guildBlessHandler.receiveBlessGiftRequest',{index:index}));
});

GuildBlessHandler.prototype.upgradeBlessRequest = async(function(){
	return await(this.socket.requestAsync('area.guildBlessHandler.upgradeBlessRequest',{}));
});


GuildBlessHandler.prototype.onBlessRefreshPush = function(cb){
	this.socket.on('area.guildBlessPush.blessRefreshPush',cb);
}

module.exports = GuildBlessHandler;
