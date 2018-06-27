/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var DailyActivityHandler = function(socket){
	this.socket = socket;
}

DailyActivityHandler.prototype.dailyActivityRequest = async(function(){
	return await(this.socket.requestAsync('area.dailyActivityHandler.dailyActivityRequest',{}));
});

DailyActivityHandler.prototype.getDegreeRewardRequest = async(function(id){
	return await(this.socket.requestAsync('area.dailyActivityHandler.getDegreeRewardRequest',{id:id}));
});


DailyActivityHandler.prototype.onUpdateActivityPush = function(cb){
	this.socket.on('area.dailyActivityPush.updateActivityPush',cb);
}

module.exports = DailyActivityHandler;
