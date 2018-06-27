/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var WingHandler = function(socket){
	this.socket = socket;
}

WingHandler.prototype.getWingInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.wingHandler.getWingInfoRequest',{}));
});

WingHandler.prototype.trainingWingRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.wingHandler.trainingWingRequest',{c2s_type:c2s_type}));
});

WingHandler.prototype.saveWingNotify = function(c2s_wingLevel){
	return this.socket.notify('area.wingHandler.saveWingNotify',{c2s_wingLevel:c2s_wingLevel});
};


module.exports = WingHandler;
