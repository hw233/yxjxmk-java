/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var EquipHandler = function(socket){
	this.socket = socket;
}

EquipHandler.prototype.unEquipRequest = async(function(c2s_gridIndex){
	return await(this.socket.requestAsync('area.equipHandler.unEquipRequest',{c2s_gridIndex:c2s_gridIndex}));
});

EquipHandler.prototype.equipRequest = async(function(c2s_gridIndex){
	return await(this.socket.requestAsync('area.equipHandler.equipRequest',{c2s_gridIndex:c2s_gridIndex}));
});

EquipHandler.prototype.equipPreStrengthenRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.equipHandler.equipPreStrengthenRequest',{c2s_pos:c2s_pos}));
});

EquipHandler.prototype.equipStrengthenRequest = async(function(c2s_pos,c2s_useZuan){
	return await(this.socket.requestAsync('area.equipHandler.equipStrengthenRequest',{c2s_pos:c2s_pos,c2s_useZuan:c2s_useZuan}));
});

EquipHandler.prototype.enchantEquipRequest = async(function(c2s_pos,c2s_gridIndex,c2s_diamond){
	return await(this.socket.requestAsync('area.equipHandler.enchantEquipRequest',{c2s_pos:c2s_pos,c2s_gridIndex:c2s_gridIndex,c2s_diamond:c2s_diamond}));
});

EquipHandler.prototype.confirmEnchantEquipRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.equipHandler.confirmEnchantEquipRequest',{c2s_pos:c2s_pos}));
});

EquipHandler.prototype.identifyEquipRequest = async(function(c2s_gridIndex){
	return await(this.socket.requestAsync('area.equipHandler.identifyEquipRequest',{c2s_gridIndex:c2s_gridIndex}));
});

EquipHandler.prototype.refineEquipRequest = async(function(c2s_pos,c2s_itemCode){
	return await(this.socket.requestAsync('area.equipHandler.refineEquipRequest',{c2s_pos:c2s_pos,c2s_itemCode:c2s_itemCode}));
});

EquipHandler.prototype.refineOneKeyRequest = async(function(c2s_pos,c2s_itemCode){
	return await(this.socket.requestAsync('area.equipHandler.refineOneKeyRequest',{c2s_pos:c2s_pos,c2s_itemCode:c2s_itemCode}));
});

EquipHandler.prototype.refineResetRequest = async(function(c2s_pos,c2s_propIndex){
	return await(this.socket.requestAsync('area.equipHandler.refineResetRequest',{c2s_pos:c2s_pos,c2s_propIndex:c2s_propIndex}));
});

EquipHandler.prototype.equipMakeRequest = async(function(c2s_targetCode){
	return await(this.socket.requestAsync('area.equipHandler.equipMakeRequest',{c2s_targetCode:c2s_targetCode}));
});

EquipHandler.prototype.equipLevelUpRequest = async(function(c2s_equipPos,c2s_mateType){
	return await(this.socket.requestAsync('area.equipHandler.equipLevelUpRequest',{c2s_equipPos:c2s_equipPos,c2s_mateType:c2s_mateType}));
});

EquipHandler.prototype.equipColorUpRequest = async(function(c2s_equipPos){
	return await(this.socket.requestAsync('area.equipHandler.equipColorUpRequest',{c2s_equipPos:c2s_equipPos}));
});

EquipHandler.prototype.fillGemRequest = async(function(c2s_pos,c2s_index,c2s_gridIndex){
	return await(this.socket.requestAsync('area.equipHandler.fillGemRequest',{c2s_pos:c2s_pos,c2s_index:c2s_index,c2s_gridIndex:c2s_gridIndex}));
});

EquipHandler.prototype.fillAllGemRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.equipHandler.fillAllGemRequest',{c2s_pos:c2s_pos}));
});

EquipHandler.prototype.unFillGemRequest = async(function(c2s_pos,c2s_index){
	return await(this.socket.requestAsync('area.equipHandler.unFillGemRequest',{c2s_pos:c2s_pos,c2s_index:c2s_index}));
});

EquipHandler.prototype.unFillAllGemRequest = async(function(c2s_pos){
	return await(this.socket.requestAsync('area.equipHandler.unFillAllGemRequest',{c2s_pos:c2s_pos}));
});

EquipHandler.prototype.getSuitAttrRequest = async(function(){
	return await(this.socket.requestAsync('area.equipHandler.getSuitAttrRequest',{}));
});

EquipHandler.prototype.getSuitDetailRequest = async(function(c2s_suitType){
	return await(this.socket.requestAsync('area.equipHandler.getSuitDetailRequest',{c2s_suitType:c2s_suitType}));
});

EquipHandler.prototype.getInheritInfoRequest = async(function(c2s_inheritEquip,c2s_beiInheritEquip){
	return await(this.socket.requestAsync('area.equipHandler.getInheritInfoRequest',{c2s_inheritEquip:c2s_inheritEquip,c2s_beiInheritEquip:c2s_beiInheritEquip}));
});

EquipHandler.prototype.equipInheritRequest = async(function(c2s_inheritEquip,c2s_beiInheritEquip,c2s_magical,c2s_jewel,c2s_refine,c2s_isAuto){
	return await(this.socket.requestAsync('area.equipHandler.equipInheritRequest',{c2s_inheritEquip:c2s_inheritEquip,c2s_beiInheritEquip:c2s_beiInheritEquip,c2s_magical:c2s_magical,c2s_jewel:c2s_jewel,c2s_refine:c2s_refine,c2s_isAuto:c2s_isAuto}));
});

EquipHandler.prototype.equipMeltRequest = async(function(c2s_indexs){
	return await(this.socket.requestAsync('area.equipHandler.equipMeltRequest',{c2s_indexs:c2s_indexs}));
});

EquipHandler.prototype.chatEquipDetailRequest = async(function(c2s_id){
	return await(this.socket.requestAsync('area.equipHandler.chatEquipDetailRequest',{c2s_id:c2s_id}));
});

EquipHandler.prototype.equipRebornRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.equipRebornRequest',{equipId:equipId}));
});

EquipHandler.prototype.equipRebuildRequest = async(function(equipId,lockedAttId){
	return await(this.socket.requestAsync('area.equipHandler.equipRebuildRequest',{equipId:equipId,lockedAttId:lockedAttId}));
});

EquipHandler.prototype.equipSeniorRebuildRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.equipSeniorRebuildRequest',{equipId:equipId}));
});

EquipHandler.prototype.equipRefineRequest = async(function(equipId,attrkey){
	return await(this.socket.requestAsync('area.equipHandler.equipRefineRequest',{equipId:equipId,attrkey:attrkey}));
});

EquipHandler.prototype.equipRefineLegendRequest = async(function(equipId,attrkey){
	return await(this.socket.requestAsync('area.equipHandler.equipRefineLegendRequest',{equipId:equipId,attrkey:attrkey}));
});

EquipHandler.prototype.saveRebornRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.saveRebornRequest',{equipId:equipId}));
});

EquipHandler.prototype.saveRebuildRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.saveRebuildRequest',{equipId:equipId}));
});

EquipHandler.prototype.smritiRequest = async(function(letf_equipId,right_equipId){
	return await(this.socket.requestAsync('area.equipHandler.smritiRequest',{letf_equipId:letf_equipId,right_equipId:right_equipId}));
});

EquipHandler.prototype.saveSeniorRebuildRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.saveSeniorRebuildRequest',{equipId:equipId}));
});

EquipHandler.prototype.saveRefineRequest = async(function(equipId,attrkey){
	return await(this.socket.requestAsync('area.equipHandler.saveRefineRequest',{equipId:equipId,attrkey:attrkey}));
});

EquipHandler.prototype.saveRefineLegendRequest = async(function(equipId,attrkey){
	return await(this.socket.requestAsync('area.equipHandler.saveRefineLegendRequest',{equipId:equipId,attrkey:attrkey}));
});

EquipHandler.prototype.getRefineExtPropRequest = async(function(equipId){
	return await(this.socket.requestAsync('area.equipHandler.getRefineExtPropRequest',{equipId:equipId}));
});


EquipHandler.prototype.onEquipmentSimplePush = function(cb){
	this.socket.on('area.equipPush.equipmentSimplePush',cb);
}

EquipHandler.prototype.onEquipInheritPush = function(cb){
	this.socket.on('area.equipPush.equipInheritPush',cb);
}

EquipHandler.prototype.onEquipStrengthPosPush = function(cb){
	this.socket.on('area.equipPush.equipStrengthPosPush',cb);
}

module.exports = EquipHandler;
