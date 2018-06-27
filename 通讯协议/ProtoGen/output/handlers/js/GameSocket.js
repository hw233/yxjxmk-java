/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var util = require('util');
var Socket = require('Xmds-csharp').Socket;

var AchievementHandler = require('./achievementHandler');
var ActivityHandler = require('./activityHandler');
var ActivityFavorHandler = require('./activityFavorHandler');
var AmuletHandler = require('./amuletHandler');
var ArenaHandler = require('./arenaHandler');
var AttendanceHandler = require('./attendanceHandler');
var BagHandler = require('./bagHandler');
var BattleHandler = require('./battleHandler');
var CardHandler = require('./cardHandler');
var ConsignmentLineHandler = require('./consignmentLineHandler');
var CrossServerHandler = require('./crossServerHandler');
var DailyActivityHandler = require('./dailyActivityHandler');
var DemonTowerHandler = require('./demonTowerHandler');
var EquipHandler = require('./equipHandler');
var ExchangeHandler = require('./exchangeHandler');
var FashionHandler = require('./fashionHandler');
var FightLevelHandler = require('./fightLevelHandler');
var FleeHandler = require('./fleeHandler');
var FriendHandler = require('./friendHandler');
var FunctionHandler = require('./functionHandler');
var FunctionOpenHandler = require('./functionOpenHandler');
var GiftOnlineHandler = require('./giftOnlineHandler');
var GoddessHandler = require('./goddessHandler');
var GuildBlessHandler = require('./guildBlessHandler');
var GuildBossHandler = require('./guildBossHandler');
var GuildDepotHandler = require('./guildDepotHandler');
var GuildHandler = require('./guildHandler');
var GuildShopHandler = require('./guildShopHandler');
var GuildTechHandler = require('./guildTechHandler');
var HookSetHandler = require('./hookSetHandler');
var InteractHandler = require('./interactHandler');
var IntergalMallHandler = require('./intergalMallHandler');
var ItemHandler = require('./itemHandler');
var LeaderBoardHandler = require('./leaderBoardHandler');
var LimitTimeActivityHandler = require('./limitTimeActivityHandler');
var MailHandler = require('./mailHandler');
var MapHandler = require('./mapHandler');
var MasteryHandler = require('./masteryHandler');
var MedalHandler = require('./medalHandler');
var MessageHandler = require('./messageHandler');
var MountHandler = require('./mountHandler');
var NpcHandler = require('./npcHandler');
var OfflineAwardHandler = require('./offlineAwardHandler');
var OnlineGiftHandler = require('./onlineGiftHandler');
var PayGiftHandler = require('./payGiftHandler');
var PetHandler = require('./petHandler');
var PetNewHandler = require('./petNewHandler');
var PlayerHandler = require('./playerHandler');
var PrepaidHandler = require('./prepaidHandler');
var RankHandler = require('./rankHandler');
var ResourceDungeonHandler = require('./resourceDungeonHandler');
var ResourceHandler = require('./resourceHandler');
var RewardHandler = require('./rewardHandler');
var SaleHandler = require('./saleHandler');
var ShopMallHandler = require('./shopMallHandler');
var SkillHandler = require('./skillHandler');
var SkillKeysHandler = require('./skillKeysHandler');
var SoloHandler = require('./soloHandler');
var StealHandler = require('./stealHandler');
var SysSetHandler = require('./sysSetHandler');
var TaskHandler = require('./taskHandler');
var TeamHandler = require('./teamHandler');
var TradeHandler = require('./tradeHandler');
var TreasureHandler = require('./treasureHandler');
var UpLevelHandler = require('./upLevelHandler');
var VipHandler = require('./vipHandler');
var VitalityHandler = require('./vitalityHandler');
var WingHandler = require('./wingHandler');
var ActivityRevelryHandler = require('./activityRevelryHandler');
var AuctionHandler = require('./auctionHandler');
var ChatHandler = require('./chatHandler');
var DaoYouHandler = require('./daoYouHandler');
var EntryHandler = require('./entryHandler');
var RoleHandler = require('./roleHandler');
var FarmHandler = require('./farmHandler');
var Five2FiveHandler = require('./five2FiveHandler');
var GuildManagerHandler = require('./guildManagerHandler');
var XianYuanHandler = require('./xianYuanHandler');

var GameSocket = function(protoPath){
	Socket.call(this,protoPath);
	this.achievementHandler = new AchievementHandler(this);
	this.activityHandler = new ActivityHandler(this);
	this.activityFavorHandler = new ActivityFavorHandler(this);
	this.amuletHandler = new AmuletHandler(this);
	this.arenaHandler = new ArenaHandler(this);
	this.attendanceHandler = new AttendanceHandler(this);
	this.bagHandler = new BagHandler(this);
	this.battleHandler = new BattleHandler(this);
	this.cardHandler = new CardHandler(this);
	this.consignmentLineHandler = new ConsignmentLineHandler(this);
	this.crossServerHandler = new CrossServerHandler(this);
	this.dailyActivityHandler = new DailyActivityHandler(this);
	this.demonTowerHandler = new DemonTowerHandler(this);
	this.equipHandler = new EquipHandler(this);
	this.exchangeHandler = new ExchangeHandler(this);
	this.fashionHandler = new FashionHandler(this);
	this.fightLevelHandler = new FightLevelHandler(this);
	this.fleeHandler = new FleeHandler(this);
	this.friendHandler = new FriendHandler(this);
	this.functionHandler = new FunctionHandler(this);
	this.functionOpenHandler = new FunctionOpenHandler(this);
	this.giftOnlineHandler = new GiftOnlineHandler(this);
	this.goddessHandler = new GoddessHandler(this);
	this.guildBlessHandler = new GuildBlessHandler(this);
	this.guildBossHandler = new GuildBossHandler(this);
	this.guildDepotHandler = new GuildDepotHandler(this);
	this.guildHandler = new GuildHandler(this);
	this.guildShopHandler = new GuildShopHandler(this);
	this.guildTechHandler = new GuildTechHandler(this);
	this.hookSetHandler = new HookSetHandler(this);
	this.interactHandler = new InteractHandler(this);
	this.intergalMallHandler = new IntergalMallHandler(this);
	this.itemHandler = new ItemHandler(this);
	this.leaderBoardHandler = new LeaderBoardHandler(this);
	this.limitTimeActivityHandler = new LimitTimeActivityHandler(this);
	this.mailHandler = new MailHandler(this);
	this.mapHandler = new MapHandler(this);
	this.masteryHandler = new MasteryHandler(this);
	this.medalHandler = new MedalHandler(this);
	this.messageHandler = new MessageHandler(this);
	this.mountHandler = new MountHandler(this);
	this.npcHandler = new NpcHandler(this);
	this.offlineAwardHandler = new OfflineAwardHandler(this);
	this.onlineGiftHandler = new OnlineGiftHandler(this);
	this.payGiftHandler = new PayGiftHandler(this);
	this.petHandler = new PetHandler(this);
	this.petNewHandler = new PetNewHandler(this);
	this.playerHandler = new PlayerHandler(this);
	this.prepaidHandler = new PrepaidHandler(this);
	this.rankHandler = new RankHandler(this);
	this.resourceDungeonHandler = new ResourceDungeonHandler(this);
	this.resourceHandler = new ResourceHandler(this);
	this.rewardHandler = new RewardHandler(this);
	this.saleHandler = new SaleHandler(this);
	this.shopMallHandler = new ShopMallHandler(this);
	this.skillHandler = new SkillHandler(this);
	this.skillKeysHandler = new SkillKeysHandler(this);
	this.soloHandler = new SoloHandler(this);
	this.stealHandler = new StealHandler(this);
	this.sysSetHandler = new SysSetHandler(this);
	this.taskHandler = new TaskHandler(this);
	this.teamHandler = new TeamHandler(this);
	this.tradeHandler = new TradeHandler(this);
	this.treasureHandler = new TreasureHandler(this);
	this.upLevelHandler = new UpLevelHandler(this);
	this.vipHandler = new VipHandler(this);
	this.vitalityHandler = new VitalityHandler(this);
	this.wingHandler = new WingHandler(this);
	this.activityRevelryHandler = new ActivityRevelryHandler(this);
	this.auctionHandler = new AuctionHandler(this);
	this.chatHandler = new ChatHandler(this);
	this.daoYouHandler = new DaoYouHandler(this);
	this.entryHandler = new EntryHandler(this);
	this.roleHandler = new RoleHandler(this);
	this.farmHandler = new FarmHandler(this);
	this.five2FiveHandler = new Five2FiveHandler(this);
	this.guildManagerHandler = new GuildManagerHandler(this);
	this.xianYuanHandler = new XianYuanHandler(this);
}


util.inherits(GameSocket, Socket);


GameSocket.prototype.onOnAchievementPush = function(cb){
	this.on('area.achievementPush.onAchievementPush',cb);
}

GameSocket.prototype.onSuperPackageBuyPush = function(cb){
	this.on('area.activityFavorPush.superPackageBuyPush',cb);
}

GameSocket.prototype.onAmuletEquipNewPush = function(cb){
	this.on('area.amuletPush.amuletEquipNewPush',cb);
}

GameSocket.prototype.onOnArenaBattleInfoPush = function(cb){
	this.on('area.arenaPush.onArenaBattleInfoPush',cb);
}

GameSocket.prototype.onOnArenaBattleEndPush = function(cb){
	this.on('area.arenaPush.onArenaBattleEndPush',cb);
}

GameSocket.prototype.onLuxuryRewardPush = function(cb){
	this.on('area.attendancePush.luxuryRewardPush',cb);
}

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

GameSocket.prototype.onConsignmentRemovePush = function(cb){
	this.on('area.consignmentLinePush.consignmentRemovePush',cb);
}

GameSocket.prototype.onTreasureOpenPush = function(cb){
	this.on('area.crossServerPush.treasureOpenPush',cb);
}

GameSocket.prototype.onUpdateActivityPush = function(cb){
	this.on('area.dailyActivityPush.updateActivityPush',cb);
}

GameSocket.prototype.onSweepDemonTowerEndPush = function(cb){
	this.on('area.demonTowerPush.sweepDemonTowerEndPush',cb);
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

GameSocket.prototype.onOnFashionGetPush = function(cb){
	this.on('area.fashionPush.onFashionGetPush',cb);
}

GameSocket.prototype.onOnConfirmEnterFubenPush = function(cb){
	this.on('area.fightLevelPush.onConfirmEnterFubenPush',cb);
}

GameSocket.prototype.onOnMemberEnterFubenStateChangePush = function(cb){
	this.on('area.fightLevelPush.onMemberEnterFubenStateChangePush',cb);
}

GameSocket.prototype.onOnFubenClosePush = function(cb){
	this.on('area.fightLevelPush.onFubenClosePush',cb);
}

GameSocket.prototype.onCloseHandUpPush = function(cb){
	this.on('area.fightLevelPush.closeHandUpPush',cb);
}

GameSocket.prototype.onIllusionPush = function(cb){
	this.on('area.fightLevelPush.illusionPush',cb);
}

GameSocket.prototype.onIllusion2Push = function(cb){
	this.on('area.fightLevelPush.illusion2Push',cb);
}

GameSocket.prototype.onOnFleeDeathPush = function(cb){
	this.on('area.fleePush.onFleeDeathPush',cb);
}

GameSocket.prototype.onOnFleeEndPush = function(cb){
	this.on('area.fleePush.onFleeEndPush',cb);
}

GameSocket.prototype.onFunctionGoToPush = function(cb){
	this.on('area.functionPush.functionGoToPush',cb);
}

GameSocket.prototype.onTaskGuideFuncPush = function(cb){
	this.on('area.functionPush.taskGuideFuncPush',cb);
}

GameSocket.prototype.onFunctionOpenListPush = function(cb){
	this.on('area.functionOpenPush.functionOpenListPush',cb);
}

GameSocket.prototype.onFunctionAwardListPush = function(cb){
	this.on('area.functionOpenPush.functionAwardListPush',cb);
}

GameSocket.prototype.onGoddessEquipDynamicPush = function(cb){
	this.on('area.goddessPush.goddessEquipDynamicPush',cb);
}

GameSocket.prototype.onGoddessGiftDynamicPush = function(cb){
	this.on('area.goddessPush.goddessGiftDynamicPush',cb);
}

GameSocket.prototype.onBlessRefreshPush = function(cb){
	this.on('area.guildBlessPush.blessRefreshPush',cb);
}

GameSocket.prototype.onOnHurtRankChangePush = function(cb){
	this.on('area.guildBossPush.onHurtRankChangePush',cb);
}

GameSocket.prototype.onOnInspireSingleChangePush = function(cb){
	this.on('area.guildBossPush.onInspireSingleChangePush',cb);
}

GameSocket.prototype.onOnInspireGuildChangePush = function(cb){
	this.on('area.guildBossPush.onInspireGuildChangePush',cb);
}

GameSocket.prototype.onOnGuildBossOverPush = function(cb){
	this.on('area.guildBossPush.onGuildBossOverPush',cb);
}

GameSocket.prototype.onOnQuitGuildBossPush = function(cb){
	this.on('area.guildBossPush.onQuitGuildBossPush',cb);
}

GameSocket.prototype.onDepotRefreshPush = function(cb){
	this.on('area.guildDepotPush.depotRefreshPush',cb);
}

GameSocket.prototype.onGuildRefreshPush = function(cb){
	this.on('area.guildPush.guildRefreshPush',cb);
}

GameSocket.prototype.onGuildInvitePush = function(cb){
	this.on('area.guildPush.guildInvitePush',cb);
}

GameSocket.prototype.onOnDungeonEndPush = function(cb){
	this.on('area.guildPush.onDungeonEndPush',cb);
}

GameSocket.prototype.onGuildDungeonOpenPush = function(cb){
	this.on('area.guildPush.guildDungeonOpenPush',cb);
}

GameSocket.prototype.onGuildDungeonPassPush = function(cb){
	this.on('area.guildPush.guildDungeonPassPush',cb);
}

GameSocket.prototype.onGuildDungeonPlayerNumPush = function(cb){
	this.on('area.guildPush.guildDungeonPlayerNumPush',cb);
}

GameSocket.prototype.onShopRefreshPush = function(cb){
	this.on('area.guildShopPush.shopRefreshPush',cb);
}

GameSocket.prototype.onGuildTechRefreshPush = function(cb){
	this.on('area.guildTechPush.guildTechRefreshPush',cb);
}

GameSocket.prototype.onReceiveInteractPush = function(cb){
	this.on('area.interactPush.receiveInteractPush',cb);
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

GameSocket.prototype.onLtActivityInfoPush = function(cb){
	this.on('area.limitTimeActivityPush.ltActivityInfoPush',cb);
}

GameSocket.prototype.onOnGetMailPush = function(cb){
	this.on('area.mailPush.onGetMailPush',cb);
}

GameSocket.prototype.onMedalTitleChangePush = function(cb){
	this.on('area.medalPush.medalTitleChangePush',cb);
}

GameSocket.prototype.onOnMessageAddPush = function(cb){
	this.on('area.messagePush.onMessageAddPush',cb);
}

GameSocket.prototype.onMountFlagPush = function(cb){
	this.on('area.mountPush.mountFlagPush',cb);
}

GameSocket.prototype.onMountNewSkinPush = function(cb){
	this.on('area.mountPush.mountNewSkinPush',cb);
}

GameSocket.prototype.onGiftInfoPush = function(cb){
	this.on('area.onlineGiftPush.giftInfoPush',cb);
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

GameSocket.prototype.onOnAwardRankPush = function(cb){
	this.on('area.rankPush.onAwardRankPush',cb);
}

GameSocket.prototype.onSkillUpdatePush = function(cb){
	this.on('area.skillPush.skillUpdatePush',cb);
}

GameSocket.prototype.onSkillKeyUpdatePush = function(cb){
	this.on('area.skillKeysPush.skillKeyUpdatePush',cb);
}

GameSocket.prototype.onOnSoloMatchedPush = function(cb){
	this.on('area.soloPush.onSoloMatchedPush',cb);
}

GameSocket.prototype.onOnNewRewardPush = function(cb){
	this.on('area.soloPush.onNewRewardPush',cb);
}

GameSocket.prototype.onOnFightPointPush = function(cb){
	this.on('area.soloPush.onFightPointPush',cb);
}

GameSocket.prototype.onOnRoundEndPush = function(cb){
	this.on('area.soloPush.onRoundEndPush',cb);
}

GameSocket.prototype.onOnGameEndPush = function(cb){
	this.on('area.soloPush.onGameEndPush',cb);
}

GameSocket.prototype.onLeftSoloTimePush = function(cb){
	this.on('area.soloPush.leftSoloTimePush',cb);
}

GameSocket.prototype.onCancelMatchPush = function(cb){
	this.on('area.soloPush.cancelMatchPush',cb);
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

GameSocket.prototype.onTradeBeginPush = function(cb){
	this.on('area.tradePush.tradeBeginPush',cb);
}

GameSocket.prototype.onTradeItemChangePush = function(cb){
	this.on('area.tradePush.tradeItemChangePush',cb);
}

GameSocket.prototype.onTradeOperatePush = function(cb){
	this.on('area.tradePush.tradeOperatePush',cb);
}

GameSocket.prototype.onAuctionItemPush = function(cb){
	this.on('auction.auctionPush.auctionItemPush',cb);
}

GameSocket.prototype.onAddAuctionItemPush = function(cb){
	this.on('auction.auctionPush.addAuctionItemPush',cb);
}

GameSocket.prototype.onRemoveAuctionItemPush = function(cb){
	this.on('auction.auctionPush.removeAuctionItemPush',cb);
}

GameSocket.prototype.onOnChatPush = function(cb){
	this.on('chat.chatPush.onChatPush',cb);
}

GameSocket.prototype.onOnChatErrorPush = function(cb){
	this.on('chat.chatPush.onChatErrorPush',cb);
}

GameSocket.prototype.onTipPush = function(cb){
	this.on('chat.chatPush.tipPush',cb);
}

GameSocket.prototype.onLoginQueuePush = function(cb){
	this.on('connector.entryPush.loginQueuePush',cb);
}

GameSocket.prototype.onFive2FiveApplyMatchPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveApplyMatchPush',cb);
}

GameSocket.prototype.onFive2FiveMatchMemberInfoPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveMatchMemberInfoPush',cb);
}

GameSocket.prototype.onFive2FiveMemberChoicePush = function(cb){
	this.on('five2five.five2FivePush.five2FiveMemberChoicePush',cb);
}

GameSocket.prototype.onFive2FiveOnGameEndPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveOnGameEndPush',cb);
}

GameSocket.prototype.onFive2FiveOnNewRewardPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveOnNewRewardPush',cb);
}

GameSocket.prototype.onFive2FiveOnNoRewardPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveOnNoRewardPush',cb);
}

GameSocket.prototype.onFive2FiveMatchFailedPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveMatchFailedPush',cb);
}

GameSocket.prototype.onFive2FiveLeaderCancelMatchPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveLeaderCancelMatchPush',cb);
}

GameSocket.prototype.onFive2FiveTeamChangePush = function(cb){
	this.on('five2five.five2FivePush.five2FiveTeamChangePush',cb);
}

GameSocket.prototype.onFive2FiveMatchPoolChangePush = function(cb){
	this.on('five2five.five2FivePush.five2FiveMatchPoolChangePush',cb);
}

GameSocket.prototype.onFive2FiveApplyMatchResultPush = function(cb){
	this.on('five2five.five2FivePush.five2FiveApplyMatchResultPush',cb);
}

module.exports = GameSocket;
