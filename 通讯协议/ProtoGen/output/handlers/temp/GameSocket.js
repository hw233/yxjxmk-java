/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var util = require('util');
var Socket = require('Xmds-csharp').Socket;

var BagHandler = require('./bagHandler');
var BattleHandler = require('./battleHandler');
var DailyActivityHandler = require('./dailyActivityHandler');
var EquipHandler = require('./equipHandler');
var ItemHandler = require('./itemHandler');
var MessageHandler = require('./messageHandler');
var NpcHandler = require('./npcHandler');
var PetHandler = require('./petHandler');
var PetNewHandler = require('./petNewHandler');
var PlayerHandler = require('./playerHandler');
var PrepaidHandler = require('./prepaidHandler');
var ResourceHandler = require('./resourceHandler');
var SkillHandler = require('./skillHandler');
var SkillKeysHandler = require('./skillKeysHandler');
var TaskHandler = require('./taskHandler');
var TeamHandler = require('./teamHandler');
var EntryHandler = require('./entryHandler');
var RoleHandler = require('./roleHandler');

var GameSocket = function(protoPath){
	Socket.call(this,protoPath);
	this.bagHandler = new BagHandler(this);
	this.battleHandler = new BattleHandler(this);
	this.dailyActivityHandler = new DailyActivityHandler(this);
	this.equipHandler = new EquipHandler(this);
	this.itemHandler = new ItemHandler(this);
	this.messageHandler = new MessageHandler(this);
	this.npcHandler = new NpcHandler(this);
	this.petHandler = new PetHandler(this);
	this.petNewHandler = new PetNewHandler(this);
	this.playerHandler = new PlayerHandler(this);
	this.prepaidHandler = new PrepaidHandler(this);
	this.resourceHandler = new ResourceHandler(this);
	this.skillHandler = new SkillHandler(this);
	this.skillKeysHandler = new SkillKeysHandler(this);
	this.taskHandler = new TaskHandler(this);
	this.teamHandler = new TeamHandler(this);
	this.entryHandler = new EntryHandler(this);
	this.roleHandler = new RoleHandler(this);
}


util.inherits(GameSocket, Socket);


GameSocket.prototype.onBagItemUpdatePush = function(cb){
	this.on('area.bagPush.bagItemUpdatePush',cb);
}

GameSocket.prototype.onBagNewItemPush = function(cb){
	this.on('area.bagPush.bagNewItemPush',cb);
}

GameSocket.prototype.onBagNewEquipPush = function(cb){
	this.on('area.bagPush.bagNewEquipPush',cb);
}

GameSocket.prototype.onBagGridFullPush = function(cb){
	this.on('area.bagPush.bagGridFullPush',cb);
}

GameSocket.prototype.onBagGridNumPush = function(cb){
	this.on('area.bagPush.bagGridNumPush',cb);
}

GameSocket.prototype.onThrowPointItemListPush = function(cb){
	this.on('area.battlePush.throwPointItemListPush',cb);
}

GameSocket.prototype.onThrowPointResultPush = function(cb){
	this.on('area.battlePush.throwPointResultPush',cb);
}

GameSocket.prototype.onFightLevelResultPush = function(cb){
	this.on('area.battlePush.fightLevelResultPush',cb);
}

GameSocket.prototype.onItemDropPush = function(cb){
	this.on('area.battlePush.itemDropPush',cb);
}

GameSocket.prototype.onSceneNamePush = function(cb){
	this.on('area.battlePush.sceneNamePush',cb);
}

GameSocket.prototype.onResourceDungeonResultPush = function(cb){
	this.on('area.battlePush.resourceDungeonResultPush',cb);
}

GameSocket.prototype.onUpdateActivityPush = function(cb){
	this.on('area.dailyActivityPush.updateActivityPush',cb);
}

GameSocket.prototype.onEquipmentSimplePush = function(cb){
	this.on('area.equipPush.equipmentSimplePush',cb);
}

GameSocket.prototype.onEquipInheritPush = function(cb){
	this.on('area.equipPush.equipInheritPush',cb);
}

GameSocket.prototype.onEquipStrengthPosPush = function(cb){
	this.on('area.equipPush.equipStrengthPosPush',cb);
}

GameSocket.prototype.onFishItemPush = function(cb){
	this.on('area.itemPush.fishItemPush',cb);
}

GameSocket.prototype.onCountItemChangePush = function(cb){
	this.on('area.itemPush.countItemChangePush',cb);
}

GameSocket.prototype.onItemDetailPush = function(cb){
	this.on('area.itemPush.itemDetailPush',cb);
}

GameSocket.prototype.onRewardItemPush = function(cb){
	this.on('area.itemPush.rewardItemPush',cb);
}

GameSocket.prototype.onOnMessageAddPush = function(cb){
	this.on('area.messagePush.onMessageAddPush',cb);
}

GameSocket.prototype.onOnPetDetailPush = function(cb){
	this.on('area.petPush.onPetDetailPush',cb);
}

GameSocket.prototype.onOnPetExpPush = function(cb){
	this.on('area.petPush.onPetExpPush',cb);
}

GameSocket.prototype.onOnNewPetDetailPush = function(cb){
	this.on('area.petNewPush.onNewPetDetailPush',cb);
}

GameSocket.prototype.onPetExpUpdatePush = function(cb){
	this.on('area.petNewPush.petExpUpdatePush',cb);
}

GameSocket.prototype.onPetInfoUpdatePush = function(cb){
	this.on('area.petNewPush.petInfoUpdatePush',cb);
}

GameSocket.prototype.onClientConfigPush = function(cb){
	this.on('area.playerPush.clientConfigPush',cb);
}

GameSocket.prototype.onBattleEventPush = function(cb){
	this.on('area.playerPush.battleEventPush',cb);
}

GameSocket.prototype.onBattleClearPush = function(cb){
	this.on('area.playerPush.battleClearPush',cb);
}

GameSocket.prototype.onOnSuperScriptPush = function(cb){
	this.on('area.playerPush.onSuperScriptPush',cb);
}

GameSocket.prototype.onChangeAreaPush = function(cb){
	this.on('area.playerPush.changeAreaPush',cb);
}

GameSocket.prototype.onPlayerDynamicPush = function(cb){
	this.on('area.playerPush.playerDynamicPush',cb);
}

GameSocket.prototype.onPlayerRelivePush = function(cb){
	this.on('area.playerPush.playerRelivePush',cb);
}

GameSocket.prototype.onPlayerSaverRebirthPush = function(cb){
	this.on('area.playerPush.playerSaverRebirthPush',cb);
}

GameSocket.prototype.onSimulateDropPush = function(cb){
	this.on('area.playerPush.simulateDropPush',cb);
}

GameSocket.prototype.onKickPlayerPush = function(cb){
	this.on('area.playerPush.kickPlayerPush',cb);
}

GameSocket.prototype.onSuitPropertyUpPush = function(cb){
	this.on('area.playerPush.suitPropertyUpPush',cb);
}

GameSocket.prototype.onCommonPropertyPush = function(cb){
	this.on('area.playerPush.commonPropertyPush',cb);
}

GameSocket.prototype.onBuffPropertyPush = function(cb){
	this.on('area.playerPush.buffPropertyPush',cb);
}

GameSocket.prototype.onPlayerBattleAttributePush = function(cb){
	this.on('area.playerPush.playerBattleAttributePush',cb);
}

GameSocket.prototype.onPayGiftStatePush = function(cb){
	this.on('area.playerPush.payGiftStatePush',cb);
}

GameSocket.prototype.onSkillUpdatePush = function(cb){
	this.on('area.skillPush.skillUpdatePush',cb);
}

GameSocket.prototype.onSkillKeyUpdatePush = function(cb){
	this.on('area.skillKeysPush.skillKeyUpdatePush',cb);
}

GameSocket.prototype.onTaskUpdatePush = function(cb){
	this.on('area.taskPush.taskUpdatePush',cb);
}

GameSocket.prototype.onTaskAutoPush = function(cb){
	this.on('area.taskPush.taskAutoPush',cb);
}

GameSocket.prototype.onTreasureScenePointPush = function(cb){
	this.on('area.taskPush.treasureScenePointPush',cb);
}

GameSocket.prototype.onLoopResultPush = function(cb){
	this.on('area.taskPush.loopResultPush',cb);
}

GameSocket.prototype.onOnSummonTeamPush = function(cb){
	this.on('area.teamPush.onSummonTeamPush',cb);
}

GameSocket.prototype.onOnTeamUpdatePush = function(cb){
	this.on('area.teamPush.onTeamUpdatePush',cb);
}

GameSocket.prototype.onOnTeamMemberUpdatePush = function(cb){
	this.on('area.teamPush.onTeamMemberUpdatePush',cb);
}

GameSocket.prototype.onOnTeamTargetPush = function(cb){
	this.on('area.teamPush.onTeamTargetPush',cb);
}

GameSocket.prototype.onOnAcrossTeamInfoPush = function(cb){
	this.on('area.teamPush.onAcrossTeamInfoPush',cb);
}

GameSocket.prototype.onLoginQueuePush = function(cb){
	this.on('connector.entryPush.loginQueuePush',cb);
}

module.exports = GameSocket;
