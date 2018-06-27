/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FunctionOpenHandler = function(socket){
	this.socket = socket;
}

FunctionOpenHandler.prototype.getFunctionListRequest = async(function(){
	return await(this.socket.requestAsync('area.functionOpenHandler.getFunctionListRequest',{}));
});

FunctionOpenHandler.prototype.setFunctionPlayedRequest = async(function(functionName){
	return await(this.socket.requestAsync('area.functionOpenHandler.setFunctionPlayedRequest',{functionName:functionName}));
});

FunctionOpenHandler.prototype.receiveFunctionAwardRequest = async(function(guide_id){
	return await(this.socket.requestAsync('area.functionOpenHandler.receiveFunctionAwardRequest',{guide_id:guide_id}));
});


FunctionOpenHandler.prototype.onFunctionOpenListPush = function(cb){
	this.socket.on('area.functionOpenPush.functionOpenListPush',cb);
}

FunctionOpenHandler.prototype.onFunctionAwardListPush = function(cb){
	this.socket.on('area.functionOpenPush.functionAwardListPush',cb);
}

module.exports = FunctionOpenHandler;
