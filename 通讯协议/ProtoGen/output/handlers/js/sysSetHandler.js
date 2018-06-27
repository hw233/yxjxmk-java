/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var SysSetHandler = function(socket){
	this.socket = socket;
}

SysSetHandler.prototype.changeSysSetRequest = async(function(c2s_setData){
	return await(this.socket.requestAsync('area.sysSetHandler.changeSysSetRequest',{c2s_setData:c2s_setData}));
});


module.exports = SysSetHandler;
