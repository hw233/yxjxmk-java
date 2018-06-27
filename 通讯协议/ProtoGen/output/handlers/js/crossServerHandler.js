/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var CrossServerHandler = function(socket){
	this.socket = socket;
}


CrossServerHandler.prototype.onTreasureOpenPush = function(cb){
	this.socket.on('area.crossServerPush.treasureOpenPush',cb);
}

module.exports = CrossServerHandler;
