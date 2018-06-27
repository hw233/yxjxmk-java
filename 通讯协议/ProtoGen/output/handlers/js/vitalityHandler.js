/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var VitalityHandler = function(socket){
	this.socket = socket;
}

VitalityHandler.prototype.getVitalityListRequest = async(function(){
	return await(this.socket.requestAsync('area.vitalityHandler.getVitalityListRequest',{}));
});

VitalityHandler.prototype.getVitalityRewardRequest = async(function(c2s_rewardId){
	return await(this.socket.requestAsync('area.vitalityHandler.getVitalityRewardRequest',{c2s_rewardId:c2s_rewardId}));
});

VitalityHandler.prototype.getRecommendPlayListRequest = async(function(){
	return await(this.socket.requestAsync('area.vitalityHandler.getRecommendPlayListRequest',{}));
});


module.exports = VitalityHandler;
