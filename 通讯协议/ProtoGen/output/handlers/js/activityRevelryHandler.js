/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ActivityRevelryHandler = function(socket){
	this.socket = socket;
}

ActivityRevelryHandler.prototype.revelryGetColumnRequest = async(function(){
	return await(this.socket.requestAsync('revelry.activityRevelryHandler.revelryGetColumnRequest',{}));
});

ActivityRevelryHandler.prototype.revelryGetRankInfoRequest = async(function(id){
	return await(this.socket.requestAsync('revelry.activityRevelryHandler.revelryGetRankInfoRequest',{id:id}));
});

ActivityRevelryHandler.prototype.revelryExchangeRequest = async(function(id,num){
	return await(this.socket.requestAsync('revelry.activityRevelryHandler.revelryExchangeRequest',{id:id,num:num}));
});


module.exports = ActivityRevelryHandler;
