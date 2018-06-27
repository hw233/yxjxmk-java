/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FunctionHandler = function(socket){
	this.socket = socket;
}


FunctionHandler.prototype.onFunctionGoToPush = function(cb){
	this.socket.on('area.functionPush.functionGoToPush',cb);
}

FunctionHandler.prototype.onTaskGuideFuncPush = function(cb){
	this.socket.on('area.functionPush.taskGuideFuncPush',cb);
}

module.exports = FunctionHandler;
