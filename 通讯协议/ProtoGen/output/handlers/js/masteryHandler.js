/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var MasteryHandler = function(socket){
	this.socket = socket;
}

MasteryHandler.prototype.getMasteryInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.masteryHandler.getMasteryInfoRequest',{}));
});

MasteryHandler.prototype.activeMasteryRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.masteryHandler.activeMasteryRequest',{c2s_pos:c2s_pos}));
});

MasteryHandler.prototype.getRingRequest = async(function(c2s_ringId){
	return await(this.socket.requestAsync('area.masteryHandler.getRingRequest',{c2s_ringId:c2s_ringId}));
});

MasteryHandler.prototype.masteryRingRequest = async(function(){
	return await(this.socket.requestAsync('area.masteryHandler.masteryRingRequest',{}));
});

MasteryHandler.prototype.masteryDeliverRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.masteryHandler.masteryDeliverRequest',{c2s_pos:c2s_pos}));
});


module.exports = MasteryHandler;
