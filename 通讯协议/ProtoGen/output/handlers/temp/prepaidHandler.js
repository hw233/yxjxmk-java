/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var PrepaidHandler = function(socket){
	this.socket = socket;
}

PrepaidHandler.prototype.prepaidSDKRequest = async(function(s2c_param){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidSDKRequest',{s2c_param:s2c_param}));
});

PrepaidHandler.prototype.prepaidListRequest = async(function(){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidListRequest',{}));
});

PrepaidHandler.prototype.prepaidAwardRequest = async(function(){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidAwardRequest',{}));
});

PrepaidHandler.prototype.prepaidAPPRequest = async(function(s2c_param){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidAPPRequest',{s2c_param:s2c_param}));
});

PrepaidHandler.prototype.prepaidOrderIdRequest = async(function(c2s_productId,c2s_type,c2s_channelId,c2s_imei,c2s_os){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidOrderIdRequest',{c2s_productId:c2s_productId,c2s_type:c2s_type,c2s_channelId:c2s_channelId,c2s_imei:c2s_imei,c2s_os:c2s_os}));
});

PrepaidHandler.prototype.prepaidFirstAwardRequest = async(function(){
	return await(this.socket.requestAsync('area.prepaidHandler.prepaidFirstAwardRequest',{}));
});


module.exports = PrepaidHandler;
