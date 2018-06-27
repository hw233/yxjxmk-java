/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ResourceHandler = function(socket){
	this.socket = socket;
}

ResourceHandler.prototype.queryAreaDataRequest = async(function(){
	return await(this.socket.requestAsync('area.resourceHandler.queryAreaDataRequest',{}));
});


module.exports = ResourceHandler;
