/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var ConsignmentLineHandler = function(socket){
	this.socket = socket;
}

ConsignmentLineHandler.prototype.addConsignmentRequest = async(function(c2s_index,c2s_number,c2s_price,c2s_global,c2s_isAnonymous,c2s_id){
	return await(this.socket.requestAsync('area.consignmentLineHandler.addConsignmentRequest',{c2s_index:c2s_index,c2s_number:c2s_number,c2s_price:c2s_price,c2s_global:c2s_global,c2s_isAnonymous:c2s_isAnonymous,c2s_id:c2s_id}));
});

ConsignmentLineHandler.prototype.removeConsignmentRequest = async(function(c2s_id,c2s_global){
	return await(this.socket.requestAsync('area.consignmentLineHandler.removeConsignmentRequest',{c2s_id:c2s_id,c2s_global:c2s_global}));
});

ConsignmentLineHandler.prototype.buyConsignmentRequest = async(function(c2s_id,c2s_global){
	return await(this.socket.requestAsync('area.consignmentLineHandler.buyConsignmentRequest',{c2s_id:c2s_id,c2s_global:c2s_global}));
});

ConsignmentLineHandler.prototype.consignmentListRequest = async(function(c2s_pro,c2s_qcolor,c2s_order,c2s_itemSecondType,c2s_page,c2s_global,c2s_itemType,c2s_level){
	return await(this.socket.requestAsync('area.consignmentLineHandler.consignmentListRequest',{c2s_pro:c2s_pro,c2s_qcolor:c2s_qcolor,c2s_order:c2s_order,c2s_itemSecondType:c2s_itemSecondType,c2s_page:c2s_page,c2s_global:c2s_global,c2s_itemType:c2s_itemType,c2s_level:c2s_level}));
});

ConsignmentLineHandler.prototype.myConsignmentRequest = async(function(c2s_global){
	return await(this.socket.requestAsync('area.consignmentLineHandler.myConsignmentRequest',{c2s_global:c2s_global}));
});

ConsignmentLineHandler.prototype.searchConsignmentRequest = async(function(c2s_condition,c2s_global){
	return await(this.socket.requestAsync('area.consignmentLineHandler.searchConsignmentRequest',{c2s_condition:c2s_condition,c2s_global:c2s_global}));
});

ConsignmentLineHandler.prototype.publicItemRequest = async(function(id){
	return await(this.socket.requestAsync('area.consignmentLineHandler.publicItemRequest',{id:id}));
});


ConsignmentLineHandler.prototype.onConsignmentRemovePush = function(cb){
	this.socket.on('area.consignmentLinePush.consignmentRemovePush',cb);
}

module.exports = ConsignmentLineHandler;
