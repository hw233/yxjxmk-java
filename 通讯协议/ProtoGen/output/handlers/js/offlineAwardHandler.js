/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var OfflineAwardHandler = function(socket){
	this.socket = socket;
}

OfflineAwardHandler.prototype.queryAllAreasRequest = async(function(){
	return await(this.socket.requestAsync('area.offlineAwardHandler.queryAllAreasRequest',{}));
});

OfflineAwardHandler.prototype.setOfflineAreaIdRequest = async(function(c2s_areaId){
	return await(this.socket.requestAsync('area.offlineAwardHandler.setOfflineAreaIdRequest',{c2s_areaId:c2s_areaId}));
});

OfflineAwardHandler.prototype.queryOfflineAwardRequest = async(function(){
	return await(this.socket.requestAsync('area.offlineAwardHandler.queryOfflineAwardRequest',{}));
});

OfflineAwardHandler.prototype.getOfflineAwardRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.offlineAwardHandler.getOfflineAwardRequest',{c2s_type:c2s_type}));
});

OfflineAwardHandler.prototype.getCurrentOfflineAreaRequest = async(function(){
	return await(this.socket.requestAsync('area.offlineAwardHandler.getCurrentOfflineAreaRequest',{}));
});


module.exports = OfflineAwardHandler;
