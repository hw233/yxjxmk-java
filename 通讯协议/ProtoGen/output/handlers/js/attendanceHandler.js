/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var AttendanceHandler = function(socket){
	this.socket = socket;
}

AttendanceHandler.prototype.getAttendanceInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.attendanceHandler.getAttendanceInfoRequest',{}));
});

AttendanceHandler.prototype.getDailyRewardRequest = async(function(){
	return await(this.socket.requestAsync('area.attendanceHandler.getDailyRewardRequest',{}));
});

AttendanceHandler.prototype.getCumulativeRewardRequest = async(function(id){
	return await(this.socket.requestAsync('area.attendanceHandler.getCumulativeRewardRequest',{id:id}));
});

AttendanceHandler.prototype.getLuxuryRewardRequest = async(function(){
	return await(this.socket.requestAsync('area.attendanceHandler.getLuxuryRewardRequest',{}));
});

AttendanceHandler.prototype.getLeftVipRewardRequest = async(function(id){
	return await(this.socket.requestAsync('area.attendanceHandler.getLeftVipRewardRequest',{id:id}));
});


AttendanceHandler.prototype.onLuxuryRewardPush = function(cb){
	this.socket.on('area.attendancePush.luxuryRewardPush',cb);
}

module.exports = AttendanceHandler;
