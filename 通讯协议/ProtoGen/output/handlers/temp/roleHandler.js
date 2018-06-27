/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var RoleHandler = function(socket){
	this.socket = socket;
}

RoleHandler.prototype.createPlayerRequest = async(function(c2s_pro,c2s_name){
	return await(this.socket.requestAsync('connector.roleHandler.createPlayerRequest',{c2s_pro:c2s_pro,c2s_name:c2s_name}));
});

RoleHandler.prototype.changePlayerNameRequest = async(function(c2s_name,pos){
	return await(this.socket.requestAsync('connector.roleHandler.changePlayerNameRequest',{c2s_name:c2s_name,pos:pos}));
});

RoleHandler.prototype.deletePlayerRequest = async(function(c2s_playerId){
	return await(this.socket.requestAsync('connector.roleHandler.deletePlayerRequest',{c2s_playerId:c2s_playerId}));
});

RoleHandler.prototype.getRandomNameRequest = async(function(c2s_pro){
	return await(this.socket.requestAsync('connector.roleHandler.getRandomNameRequest',{c2s_pro:c2s_pro}));
});


module.exports = RoleHandler;
