/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var AchievementHandler = function(socket){
	this.socket = socket;
}

AchievementHandler.prototype.achievementGetTypeElementRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.achievementHandler.achievementGetTypeElementRequest',{c2s_id:c2s_id}));
});

AchievementHandler.prototype.achievementGetAwardRequest = async(function(c2s_id,c2s_type){
	return await(this.socket.requestAsync('area.achievementHandler.achievementGetAwardRequest',{c2s_id:c2s_id,c2s_type:c2s_type}));
});

AchievementHandler.prototype.getHolyArmorsRequest = async(function(){
	return await(this.socket.requestAsync('area.achievementHandler.getHolyArmorsRequest',{}));
});

AchievementHandler.prototype.activateHolyArmorRequest = async(function(id){
	return await(this.socket.requestAsync('area.achievementHandler.activateHolyArmorRequest',{id:id}));
});


AchievementHandler.prototype.onOnAchievementPush = function(cb){
	this.socket.on('area.achievementPush.onAchievementPush',cb);
}

module.exports = AchievementHandler;
