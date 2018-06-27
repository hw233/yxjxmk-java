/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var GuildShopHandler = function(socket){
	this.socket = socket;
}

GuildShopHandler.prototype.getGuildShopInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.guildShopHandler.getGuildShopInfoRequest',{}));
});

GuildShopHandler.prototype.exchangeShopItemRequest = async(function(id){
	return await(this.socket.requestAsync('area.guildShopHandler.exchangeShopItemRequest',{id:id}));
});


GuildShopHandler.prototype.onShopRefreshPush = function(cb){
	this.socket.on('area.guildShopPush.shopRefreshPush',cb);
}

module.exports = GuildShopHandler;
