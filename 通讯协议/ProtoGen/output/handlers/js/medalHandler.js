/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MedalHandler = function(socket){
	this.socket = socket;
}

MedalHandler.prototype.getMedalInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.medalHandler.getMedalInfoRequest',{}));
});

MedalHandler.prototype.gainMedalRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.medalHandler.gainMedalRequest',{c2s_id:c2s_id}));
});

MedalHandler.prototype.medalListRequest = async(function(){
	return await(this.socket.requestAsync('area.medalHandler.medalListRequest',{}));
});

MedalHandler.prototype.getMedalInfoByCodeRequest = async(function(c2s_code){
	return await(this.socket.requestAsync('area.medalHandler.getMedalInfoByCodeRequest',{c2s_code:c2s_code}));
});


MedalHandler.prototype.onMedalTitleChangePush = function(cb){
	this.socket.on('area.medalPush.medalTitleChangePush',cb);
}

module.exports = MedalHandler;
