/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var SkillKeysHandler = function(socket){
	this.socket = socket;
}

SkillKeysHandler.prototype.saveSkillKeysRequest = async(function(s2c_skillKeys){
	return await(this.socket.requestAsync('area.skillKeysHandler.saveSkillKeysRequest',{s2c_skillKeys:s2c_skillKeys}));
});


SkillKeysHandler.prototype.onSkillKeyUpdatePush = function(cb){
	this.socket.on('area.skillKeysPush.skillKeyUpdatePush',cb);
}

module.exports = SkillKeysHandler;
