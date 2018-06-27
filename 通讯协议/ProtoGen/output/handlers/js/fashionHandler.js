/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FashionHandler = function(socket){
	this.socket = socket;
}

FashionHandler.prototype.equipFashionRequest = async(function(code,ison){
	return await(this.socket.requestAsync('area.fashionHandler.equipFashionRequest',{code:code,ison:ison}));
});

FashionHandler.prototype.getFashionsRequest = async(function(){
	return await(this.socket.requestAsync('area.fashionHandler.getFashionsRequest',{}));
});


FashionHandler.prototype.onOnFashionGetPush = function(cb){
	this.socket.on('area.fashionPush.onFashionGetPush',cb);
}

module.exports = FashionHandler;
