-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGameSocket"
require "base64"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------GameSocket-------------------------------
Pomelo.GameSocket = {}

local function bagItemUpdatePushDecoder(stream)
	local res = bagHandler_pb.BagItemUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.bagItemUpdatePush(cb)
	Socket.On("area.bagPush.bagItemUpdatePush", function(res) 
		Pomelo.GameSocket.lastBagItemUpdatePush = res
		cb(nil,res) 
	end, bagItemUpdatePushDecoder) 
end


local function bagNewItemPushDecoder(stream)
	local res = bagHandler_pb.BagNewItemPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.bagNewItemPush(cb)
	Socket.On("area.bagPush.bagNewItemPush", function(res) 
		Pomelo.GameSocket.lastBagNewItemPush = res
		cb(nil,res) 
	end, bagNewItemPushDecoder) 
end


local function bagNewEquipPushDecoder(stream)
	local res = bagHandler_pb.BagNewEquipPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.bagNewEquipPush(cb)
	Socket.On("area.bagPush.bagNewEquipPush", function(res) 
		Pomelo.GameSocket.lastBagNewEquipPush = res
		cb(nil,res) 
	end, bagNewEquipPushDecoder) 
end


local function bagGridFullPushDecoder(stream)
	local res = bagHandler_pb.BagGridFullPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.bagGridFullPush(cb)
	Socket.On("area.bagPush.bagGridFullPush", function(res) 
		Pomelo.GameSocket.lastBagGridFullPush = res
		cb(nil,res) 
	end, bagGridFullPushDecoder) 
end


local function bagGridNumPushDecoder(stream)
	local res = bagHandler_pb.BagGridNumPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.bagGridNumPush(cb)
	Socket.On("area.bagPush.bagGridNumPush", function(res) 
		Pomelo.GameSocket.lastBagGridNumPush = res
		cb(nil,res) 
	end, bagGridNumPushDecoder) 
end


local function throwPointItemListPushDecoder(stream)
	local res = battleHandler_pb.ThrowPointItemListPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.throwPointItemListPush(cb)
	Socket.On("area.battlePush.throwPointItemListPush", function(res) 
		Pomelo.GameSocket.lastThrowPointItemListPush = res
		cb(nil,res) 
	end, throwPointItemListPushDecoder) 
end


local function throwPointResultPushDecoder(stream)
	local res = battleHandler_pb.ThrowPointResultPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.throwPointResultPush(cb)
	Socket.On("area.battlePush.throwPointResultPush", function(res) 
		Pomelo.GameSocket.lastThrowPointResultPush = res
		cb(nil,res) 
	end, throwPointResultPushDecoder) 
end


local function fightLevelResultPushDecoder(stream)
	local res = battleHandler_pb.FightLevelResultPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.fightLevelResultPush(cb)
	Socket.On("area.battlePush.fightLevelResultPush", function(res) 
		Pomelo.GameSocket.lastFightLevelResultPush = res
		cb(nil,res) 
	end, fightLevelResultPushDecoder) 
end


local function itemDropPushDecoder(stream)
	local res = battleHandler_pb.ItemDropPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.itemDropPush(cb)
	Socket.On("area.battlePush.itemDropPush", function(res) 
		Pomelo.GameSocket.lastItemDropPush = res
		cb(nil,res) 
	end, itemDropPushDecoder) 
end


local function sceneNamePushDecoder(stream)
	local res = battleHandler_pb.SceneNamePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.sceneNamePush(cb)
	Socket.On("area.battlePush.sceneNamePush", function(res) 
		Pomelo.GameSocket.lastSceneNamePush = res
		cb(nil,res) 
	end, sceneNamePushDecoder) 
end


local function resourceDungeonResultPushDecoder(stream)
	local res = battleHandler_pb.ResourceDungeonResultPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.resourceDungeonResultPush(cb)
	Socket.On("area.battlePush.resourceDungeonResultPush", function(res) 
		Pomelo.GameSocket.lastResourceDungeonResultPush = res
		cb(nil,res) 
	end, resourceDungeonResultPushDecoder) 
end


local function updateActivityPushDecoder(stream)
	local res = dailyActivityHandler_pb.UpdateActivityPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.updateActivityPush(cb)
	Socket.On("area.dailyActivityPush.updateActivityPush", function(res) 
		Pomelo.GameSocket.lastUpdateActivityPush = res
		cb(nil,res) 
	end, updateActivityPushDecoder) 
end


local function equipmentSimplePushDecoder(stream)
	local res = equipHandler_pb.EquipmentSimplePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.equipmentSimplePush(cb)
	Socket.On("area.equipPush.equipmentSimplePush", function(res) 
		Pomelo.GameSocket.lastEquipmentSimplePush = res
		cb(nil,res) 
	end, equipmentSimplePushDecoder) 
end


local function equipInheritPushDecoder(stream)
	local res = equipHandler_pb.EquipInheritPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.equipInheritPush(cb)
	Socket.On("area.equipPush.equipInheritPush", function(res) 
		Pomelo.GameSocket.lastEquipInheritPush = res
		cb(nil,res) 
	end, equipInheritPushDecoder) 
end


local function equipStrengthPosPushDecoder(stream)
	local res = equipHandler_pb.StrengthPosPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.equipStrengthPosPush(cb)
	Socket.On("area.equipPush.equipStrengthPosPush", function(res) 
		Pomelo.GameSocket.lastStrengthPosPush = res
		cb(nil,res) 
	end, equipStrengthPosPushDecoder) 
end


local function fishItemPushDecoder(stream)
	local res = itemHandler_pb.FishItemPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.fishItemPush(cb)
	Socket.On("area.itemPush.fishItemPush", function(res) 
		Pomelo.GameSocket.lastFishItemPush = res
		cb(nil,res) 
	end, fishItemPushDecoder) 
end


local function countItemChangePushDecoder(stream)
	local res = itemHandler_pb.CountItemChangePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.countItemChangePush(cb)
	Socket.On("area.itemPush.countItemChangePush", function(res) 
		Pomelo.GameSocket.lastCountItemChangePush = res
		cb(nil,res) 
	end, countItemChangePushDecoder) 
end


local function itemDetailPushDecoder(stream)
	local res = itemHandler_pb.ItemDetailPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.itemDetailPush(cb)
	Socket.On("area.itemPush.itemDetailPush", function(res) 
		Pomelo.GameSocket.lastItemDetailPush = res
		cb(nil,res) 
	end, itemDetailPushDecoder) 
end


local function rewardItemPushDecoder(stream)
	local res = itemHandler_pb.RewardItemPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.rewardItemPush(cb)
	Socket.On("area.itemPush.rewardItemPush", function(res) 
		Pomelo.GameSocket.lastRewardItemPush = res
		cb(nil,res) 
	end, rewardItemPushDecoder) 
end


local function onMessageAddPushDecoder(stream)
	local res = messageHandler_pb.OnMessageAddPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onMessageAddPush(cb)
	Socket.On("area.messagePush.onMessageAddPush", function(res) 
		Pomelo.GameSocket.lastOnMessageAddPush = res
		cb(nil,res) 
	end, onMessageAddPushDecoder) 
end


local function onPetDetailPushDecoder(stream)
	local res = petHandler_pb.OnPetDetailPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onPetDetailPush(cb)
	Socket.On("area.petPush.onPetDetailPush", function(res) 
		Pomelo.GameSocket.lastOnPetDetailPush = res
		cb(nil,res) 
	end, onPetDetailPushDecoder) 
end


local function onPetExpPushDecoder(stream)
	local res = petHandler_pb.OnPetExpPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onPetExpPush(cb)
	Socket.On("area.petPush.onPetExpPush", function(res) 
		Pomelo.GameSocket.lastOnPetExpPush = res
		cb(nil,res) 
	end, onPetExpPushDecoder) 
end


local function onNewPetDetailPushDecoder(stream)
	local res = petNewHandler_pb.OnNewPetDetailPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onNewPetDetailPush(cb)
	Socket.On("area.petNewPush.onNewPetDetailPush", function(res) 
		Pomelo.GameSocket.lastOnNewPetDetailPush = res
		cb(nil,res) 
	end, onNewPetDetailPushDecoder) 
end


local function petExpUpdatePushDecoder(stream)
	local res = petNewHandler_pb.PetExpUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.petExpUpdatePush(cb)
	Socket.On("area.petNewPush.petExpUpdatePush", function(res) 
		Pomelo.GameSocket.lastPetExpUpdatePush = res
		cb(nil,res) 
	end, petExpUpdatePushDecoder) 
end


local function petInfoUpdatePushDecoder(stream)
	local res = petNewHandler_pb.PetInfoUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.petInfoUpdatePush(cb)
	Socket.On("area.petNewPush.petInfoUpdatePush", function(res) 
		Pomelo.GameSocket.lastPetInfoUpdatePush = res
		cb(nil,res) 
	end, petInfoUpdatePushDecoder) 
end


local function clientConfigPushDecoder(stream)
	local res = playerHandler_pb.ClientConfigPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.clientConfigPush(cb)
	Socket.On("area.playerPush.clientConfigPush", function(res) 
		Pomelo.GameSocket.lastClientConfigPush = res
		cb(nil,res) 
	end, clientConfigPushDecoder) 
end


local function battleEventPushDecoder(stream)
	local res = playerHandler_pb.BattleEventPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.battleEventPush(cb)
	Socket.On("area.playerPush.battleEventPush", function(res) 
		Pomelo.GameSocket.lastBattleEventPush = res
		cb(nil,res) 
	end, battleEventPushDecoder) 
end


local function battleClearPushDecoder(stream)
	local res = playerHandler_pb.BattleClearPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.battleClearPush(cb)
	Socket.On("area.playerPush.battleClearPush", function(res) 
		Pomelo.GameSocket.lastBattleClearPush = res
		cb(nil,res) 
	end, battleClearPushDecoder) 
end


local function onSuperScriptPushDecoder(stream)
	local res = playerHandler_pb.SuperScriptPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onSuperScriptPush(cb)
	Socket.On("area.playerPush.onSuperScriptPush", function(res) 
		Pomelo.GameSocket.lastSuperScriptPush = res
		cb(nil,res) 
	end, onSuperScriptPushDecoder) 
end


local function changeAreaPushDecoder(stream)
	local res = playerHandler_pb.ChangeAreaPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.changeAreaPush(cb)
	Socket.On("area.playerPush.changeAreaPush", function(res) 
		Pomelo.GameSocket.lastChangeAreaPush = res
		cb(nil,res) 
	end, changeAreaPushDecoder) 
end


local function playerDynamicPushDecoder(stream)
	local res = playerHandler_pb.PlayerDynamicPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.playerDynamicPush(cb)
	Socket.On("area.playerPush.playerDynamicPush", function(res) 
		Pomelo.GameSocket.lastPlayerDynamicPush = res
		cb(nil,res) 
	end, playerDynamicPushDecoder) 
end


local function playerRelivePushDecoder(stream)
	local res = playerHandler_pb.PlayerRelivePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.playerRelivePush(cb)
	Socket.On("area.playerPush.playerRelivePush", function(res) 
		Pomelo.GameSocket.lastPlayerRelivePush = res
		cb(nil,res) 
	end, playerRelivePushDecoder) 
end


local function playerSaverRebirthPushDecoder(stream)
	local res = playerHandler_pb.PlayerSaverRebirthPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.playerSaverRebirthPush(cb)
	Socket.On("area.playerPush.playerSaverRebirthPush", function(res) 
		Pomelo.GameSocket.lastPlayerSaverRebirthPush = res
		cb(nil,res) 
	end, playerSaverRebirthPushDecoder) 
end


local function simulateDropPushDecoder(stream)
	local res = playerHandler_pb.SimulateDataPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.simulateDropPush(cb)
	Socket.On("area.playerPush.simulateDropPush", function(res) 
		Pomelo.GameSocket.lastSimulateDataPush = res
		cb(nil,res) 
	end, simulateDropPushDecoder) 
end


local function kickPlayerPushDecoder(stream)
	local res = playerHandler_pb.KickPlayerPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.kickPlayerPush(cb)
	Socket.On("area.playerPush.kickPlayerPush", function(res) 
		Pomelo.GameSocket.lastKickPlayerPush = res
		cb(nil,res) 
	end, kickPlayerPushDecoder) 
end


local function suitPropertyUpPushDecoder(stream)
	local res = playerHandler_pb.SuitPropertyUpPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.suitPropertyUpPush(cb)
	Socket.On("area.playerPush.suitPropertyUpPush", function(res) 
		Pomelo.GameSocket.lastSuitPropertyUpPush = res
		cb(nil,res) 
	end, suitPropertyUpPushDecoder) 
end


local function commonPropertyPushDecoder(stream)
	local res = playerHandler_pb.CommonPropertyPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.commonPropertyPush(cb)
	Socket.On("area.playerPush.commonPropertyPush", function(res) 
		Pomelo.GameSocket.lastCommonPropertyPush = res
		cb(nil,res) 
	end, commonPropertyPushDecoder) 
end


local function buffPropertyPushDecoder(stream)
	local res = playerHandler_pb.BuffPropertyPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.buffPropertyPush(cb)
	Socket.On("area.playerPush.buffPropertyPush", function(res) 
		Pomelo.GameSocket.lastBuffPropertyPush = res
		cb(nil,res) 
	end, buffPropertyPushDecoder) 
end


local function playerBattleAttributePushDecoder(stream)
	local res = playerHandler_pb.PlayerBattleAttributePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.playerBattleAttributePush(cb)
	Socket.On("area.playerPush.playerBattleAttributePush", function(res) 
		Pomelo.GameSocket.lastPlayerBattleAttributePush = res
		cb(nil,res) 
	end, playerBattleAttributePushDecoder) 
end


local function payGiftStatePushDecoder(stream)
	local res = playerHandler_pb.PayGiftStatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.payGiftStatePush(cb)
	Socket.On("area.playerPush.payGiftStatePush", function(res) 
		Pomelo.GameSocket.lastPayGiftStatePush = res
		cb(nil,res) 
	end, payGiftStatePushDecoder) 
end


local function skillUpdatePushDecoder(stream)
	local res = skillHandler_pb.SkillUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.skillUpdatePush(cb)
	Socket.On("area.skillPush.skillUpdatePush", function(res) 
		Pomelo.GameSocket.lastSkillUpdatePush = res
		cb(nil,res) 
	end, skillUpdatePushDecoder) 
end


local function skillKeyUpdatePushDecoder(stream)
	local res = skillKeysHandler_pb.SkillKeyUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.skillKeyUpdatePush(cb)
	Socket.On("area.skillKeysPush.skillKeyUpdatePush", function(res) 
		Pomelo.GameSocket.lastSkillKeyUpdatePush = res
		cb(nil,res) 
	end, skillKeyUpdatePushDecoder) 
end


local function taskUpdatePushDecoder(stream)
	local res = taskHandler_pb.TaskUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.taskUpdatePush(cb)
	Socket.On("area.taskPush.taskUpdatePush", function(res) 
		Pomelo.GameSocket.lastTaskUpdatePush = res
		cb(nil,res) 
	end, taskUpdatePushDecoder) 
end


local function taskAutoPushDecoder(stream)
	local res = taskHandler_pb.TaskAutoPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.taskAutoPush(cb)
	Socket.On("area.taskPush.taskAutoPush", function(res) 
		Pomelo.GameSocket.lastTaskAutoPush = res
		cb(nil,res) 
	end, taskAutoPushDecoder) 
end


local function treasureScenePointPushDecoder(stream)
	local res = taskHandler_pb.TreasureScenePointPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.treasureScenePointPush(cb)
	Socket.On("area.taskPush.treasureScenePointPush", function(res) 
		Pomelo.GameSocket.lastTreasureScenePointPush = res
		cb(nil,res) 
	end, treasureScenePointPushDecoder) 
end


local function loopResultPushDecoder(stream)
	local res = taskHandler_pb.LoopResultPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.loopResultPush(cb)
	Socket.On("area.taskPush.loopResultPush", function(res) 
		Pomelo.GameSocket.lastLoopResultPush = res
		cb(nil,res) 
	end, loopResultPushDecoder) 
end


local function onSummonTeamPushDecoder(stream)
	local res = teamHandler_pb.OnSummonTeamPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onSummonTeamPush(cb)
	Socket.On("area.teamPush.onSummonTeamPush", function(res) 
		Pomelo.GameSocket.lastOnSummonTeamPush = res
		cb(nil,res) 
	end, onSummonTeamPushDecoder) 
end


local function onTeamUpdatePushDecoder(stream)
	local res = teamHandler_pb.OnTeamUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onTeamUpdatePush(cb)
	Socket.On("area.teamPush.onTeamUpdatePush", function(res) 
		Pomelo.GameSocket.lastOnTeamUpdatePush = res
		cb(nil,res) 
	end, onTeamUpdatePushDecoder) 
end


local function onTeamMemberUpdatePushDecoder(stream)
	local res = teamHandler_pb.OnTeamMemberUpdatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onTeamMemberUpdatePush(cb)
	Socket.On("area.teamPush.onTeamMemberUpdatePush", function(res) 
		Pomelo.GameSocket.lastOnTeamMemberUpdatePush = res
		cb(nil,res) 
	end, onTeamMemberUpdatePushDecoder) 
end


local function onTeamTargetPushDecoder(stream)
	local res = teamHandler_pb.OnTeamTargetPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onTeamTargetPush(cb)
	Socket.On("area.teamPush.onTeamTargetPush", function(res) 
		Pomelo.GameSocket.lastOnTeamTargetPush = res
		cb(nil,res) 
	end, onTeamTargetPushDecoder) 
end


local function onAcrossTeamInfoPushDecoder(stream)
	local res = teamHandler_pb.OnAcrossTeamInfoPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.onAcrossTeamInfoPush(cb)
	Socket.On("area.teamPush.onAcrossTeamInfoPush", function(res) 
		Pomelo.GameSocket.lastOnAcrossTeamInfoPush = res
		cb(nil,res) 
	end, onAcrossTeamInfoPushDecoder) 
end


local function loginQueuePushDecoder(stream)
	local res = entryHandler_pb.LoginQueuePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GameSocket.loginQueuePush(cb)
	Socket.On("connector.entryPush.loginQueuePush", function(res) 
		Pomelo.GameSocket.lastLoginQueuePush = res
		cb(nil,res) 
	end, loginQueuePushDecoder) 
end




--------------------------------Pomelo-------------------------------
return Pomelo
