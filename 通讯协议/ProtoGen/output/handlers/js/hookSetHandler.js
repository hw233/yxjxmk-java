/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var HookSetHandler = function(socket){
	this.socket = socket;
}

HookSetHandler.prototype.changeHookSetRequest = async(function(c2s_hookSetData){
	return await(this.socket.requestAsync('area.hookSetHandler.changeHookSetRequest',{c2s_hookSetData:c2s_hookSetData}));
});


module.exports = HookSetHandler;
