/*
SQLyog Trial v9.30 
MySQL - 5.5.20 : Database - xmds_game_banshen
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`xmds_game_banshen` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;

USE `xmds_game_banshen`;

/*Table structure for table `tb_achievement_data` */

DROP TABLE IF EXISTS `tb_achievement_data`;

CREATE TABLE `tb_achievement_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `awards` blob NOT NULL,
  `achievements` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_achievement_data` */

/*Table structure for table `tb_activity_data` */

DROP TABLE IF EXISTS `tb_activity_data`;

CREATE TABLE `tb_activity_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `luckyAwardContainer` blob NOT NULL,
  `refreshTime` datetime NOT NULL,
  `buffTimes` int(11) NOT NULL DEFAULT '0',
  `activityRewardRecorder` blob NOT NULL,
  `activityInfo` blob NOT NULL,
  `drawedContainer` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_activity_data` */

/*Table structure for table `tb_ally_data` */

DROP TABLE IF EXISTS `tb_ally_data`;

CREATE TABLE `tb_ally_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `itemCount` int(11) NOT NULL DEFAULT '0',
  `freeCount` int(11) NOT NULL DEFAULT '0',
  `totalRebate` int(11) NOT NULL DEFAULT '0',
  `exchangeList` blob NOT NULL,
  `refreshFlag` blob NOT NULL,
  `enterFlag` int(11) NOT NULL DEFAULT '0',
  `allyId` varchar(500) NOT NULL DEFAULT '',
  `allyName` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_ally_data` */

/*Table structure for table `tb_arena_data` */

DROP TABLE IF EXISTS `tb_arena_data`;

CREATE TABLE `tb_arena_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `usedDefTimes` int(11) NOT NULL DEFAULT '0',
  `singleReward` int(11) NOT NULL DEFAULT '0',
  `totalReward` int(11) NOT NULL DEFAULT '0',
  `score` int(11) NOT NULL DEFAULT '0',
  `killCount` int(11) NOT NULL DEFAULT '0',
  `killTotal` int(11) NOT NULL DEFAULT '0',
  `maxKillCount` int(11) NOT NULL DEFAULT '0',
  `singleWinTimes` int(11) NOT NULL DEFAULT '0',
  `areaRankIndex` int(11) NOT NULL DEFAULT '0',
  `activityTime` datetime NOT NULL,
  `deadCount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_arena_data` */

/*Table structure for table `tb_attendance` */

DROP TABLE IF EXISTS `tb_attendance`;

CREATE TABLE `tb_attendance` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `stage` int(11) NOT NULL DEFAULT '0',
  `lastSignTime` datetime NOT NULL,
  `lastLuxuryTime` datetime NOT NULL,
  `luxuryState` int(11) NOT NULL DEFAULT '0',
  `signMap` blob NOT NULL,
  `cumulativeMap` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_attendance` */

/*Table structure for table `tb_bags` */

DROP TABLE IF EXISTS `tb_bags`;

CREATE TABLE `tb_bags` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `bagData` blob NOT NULL,
  `wareHouseData` blob NOT NULL,
  `recycleData` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_bags` */

/*Table structure for table `tb_chat_showitem` */

DROP TABLE IF EXISTS `tb_chat_showitem`;

CREATE TABLE `tb_chat_showitem` (
  `itemId` varchar(50) NOT NULL DEFAULT '',
  `itemDb` blob NOT NULL,
  PRIMARY KEY (`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_chat_showitem` */

/*Table structure for table `tb_consignment_line` */

DROP TABLE IF EXISTS `tb_consignment_line`;

CREATE TABLE `tb_consignment_line` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `serverId` int(11) NOT NULL DEFAULT '0',
  `items` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_consignment_line` */

/*Table structure for table `tb_exchange` */

DROP TABLE IF EXISTS `tb_exchange`;

CREATE TABLE `tb_exchange` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `dailyBoughtRecord` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_exchange` */

/*Table structure for table `tb_fight_levels` */

DROP TABLE IF EXISTS `tb_fight_levels`;

CREATE TABLE `tb_fight_levels` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `inviteFriends` blob NOT NULL,
  `todays` blob NOT NULL,
  `finishes` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_fight_levels` */

/*Table structure for table `tb_function_open` */

DROP TABLE IF EXISTS `tb_function_open`;

CREATE TABLE `tb_function_open` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `openMap` blob NOT NULL,
  `playMap` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_function_open` */

/*Table structure for table `tb_guild` */

DROP TABLE IF EXISTS `tb_guild`;

CREATE TABLE `tb_guild` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `showServerId` int(11) NOT NULL DEFAULT '0',
  `icon` varchar(500) NOT NULL DEFAULT '',
  `name` varchar(500) NOT NULL DEFAULT '',
  `level` int(11) NOT NULL DEFAULT '0',
  `presidentId` varchar(500) NOT NULL DEFAULT '',
  `presidentPro` int(11) NOT NULL DEFAULT '0',
  `presidentName` varchar(500) NOT NULL DEFAULT '',
  `qqGroup` varchar(500) NOT NULL DEFAULT '',
  `fund` bigint(20) NOT NULL DEFAULT '0',
  `sumFund` bigint(20) NOT NULL DEFAULT '0',
  `exp` bigint(20) NOT NULL DEFAULT '0',
  `entryLevel` int(11) NOT NULL DEFAULT '0',
  `entryUpLevel` int(11) NOT NULL DEFAULT '0',
  `guildMode` int(11) NOT NULL DEFAULT '0',
  `notice` varchar(500) NOT NULL DEFAULT '',
  `kickCount` int(11) NOT NULL DEFAULT '0',
  `logicName` varchar(500) NOT NULL DEFAULT '',
  `jobName` varchar(500) NOT NULL DEFAULT '',
  `job` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime NOT NULL,
  `changeNameTime` datetime NOT NULL,
  `kickTime` datetime NOT NULL,
  `officeNames` blob NOT NULL,
  `allBlobData` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild` */

/*Table structure for table `tb_guild_apply` */

DROP TABLE IF EXISTS `tb_guild_apply`;

CREATE TABLE `tb_guild_apply` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `guildId` varchar(500) NOT NULL DEFAULT '',
  `playerId` varchar(500) NOT NULL DEFAULT '',
  `name` varchar(500) NOT NULL DEFAULT '',
  `pro` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_apply` */

/*Table structure for table `tb_guild_depot` */

DROP TABLE IF EXISTS `tb_guild_depot`;

CREATE TABLE `tb_guild_depot` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime NOT NULL,
  `condition` blob NOT NULL,
  `news` blob NOT NULL,
  `bag` blob NOT NULL,
  `deleteCount` int(11) NOT NULL DEFAULT '0',
  `deleteCountMax` int(11) NOT NULL DEFAULT '0',
  `refreshTime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_depot` */

/*Table structure for table `tb_guild_dungeon` */

DROP TABLE IF EXISTS `tb_guild_dungeon`;

CREATE TABLE `tb_guild_dungeon` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `openTimesToday` int(11) NOT NULL DEFAULT '0',
  `openState` int(11) NOT NULL DEFAULT '0',
  `bReward` int(11) NOT NULL DEFAULT '0',
  `currPassedCount` int(11) NOT NULL DEFAULT '0',
  `totalPassedCount` int(11) NOT NULL DEFAULT '0',
  `dungeonPassedTime` datetime NOT NULL,
  `openTime` datetime NOT NULL,
  `dungeonRecord` blob NOT NULL,
  `instanceId` varchar(500) NOT NULL DEFAULT '',
  `serverId` varchar(500) NOT NULL DEFAULT '',
  `throwInfo` blob NOT NULL,
  `damagePlayer` blob NOT NULL,
  `damageRankInfo` blob NOT NULL,
  `healRankInfo` blob NOT NULL,
  `enterState` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_dungeon` */

/*Table structure for table `tb_guild_id_by_name` */

DROP TABLE IF EXISTS `tb_guild_id_by_name`;

CREATE TABLE `tb_guild_id_by_name` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `showServerId` int(11) NOT NULL DEFAULT '0',
  `name` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_id_by_name` */

/*Table structure for table `tb_guild_member` */

DROP TABLE IF EXISTS `tb_guild_member`;

CREATE TABLE `tb_guild_member` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `guildId` varchar(500) NOT NULL DEFAULT '',
  `name` varchar(500) NOT NULL DEFAULT '',
  `job` int(11) NOT NULL DEFAULT '0',
  `pro` int(11) NOT NULL DEFAULT '0',
  `lastContributeValue` bigint(20) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `upLevel` int(11) NOT NULL DEFAULT '0',
  `showServerId` int(11) NOT NULL DEFAULT '0',
  `gold` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime NOT NULL,
  `lastContributeTime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_member` */

/*Table structure for table `tb_guild_tech` */

DROP TABLE IF EXISTS `tb_guild_tech`;

CREATE TABLE `tb_guild_tech` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `skills` blob NOT NULL,
  `boughtList` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_guild_tech` */

/*Table structure for table `tb_hook_set` */

DROP TABLE IF EXISTS `tb_hook_set`;

CREATE TABLE `tb_hook_set` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `hpPercent` int(11) NOT NULL DEFAULT '0',
  `mpPercent` int(11) NOT NULL DEFAULT '0',
  `hpItemCode` varchar(500) NOT NULL DEFAULT '',
  `mpItemCode` varchar(500) NOT NULL DEFAULT '',
  `pkSet` int(11) NOT NULL DEFAULT '0',
  `meltQcolor` blob NOT NULL,
  `autoBuyHpItem` int(11) NOT NULL DEFAULT '0',
  `autoBuyMpItem` int(11) NOT NULL DEFAULT '0',
  `fieldMaphook` int(11) NOT NULL DEFAULT '0',
  `areaMaphook` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_hook_set` */

/*Table structure for table `tb_illusion` */

DROP TABLE IF EXISTS `tb_illusion`;

CREATE TABLE `tb_illusion` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `todayExp` int(11) NOT NULL DEFAULT '0',
  `todayClassExp` int(11) NOT NULL DEFAULT '0',
  `todayGold` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_illusion` */

/*Table structure for table `tb_interact` */

DROP TABLE IF EXISTS `tb_interact`;

CREATE TABLE `tb_interact` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `offline` varchar(500) NOT NULL DEFAULT '',
  `friendNum` int(11) NOT NULL DEFAULT '0',
  `unfriendNum` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_interact` */

/*Table structure for table `tb_leader_board` */

DROP TABLE IF EXISTS `tb_leader_board`;

CREATE TABLE `tb_leader_board` (
  `logicServerId` varchar(50) NOT NULL DEFAULT '',
  `kind` int(11) NOT NULL DEFAULT '0',
  `leaderBoardInfo` blob NOT NULL,
  PRIMARY KEY (`logicServerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_leader_board` */

/*Table structure for table `tb_mastery_ring` */

DROP TABLE IF EXISTS `tb_mastery_ring`;

CREATE TABLE `tb_mastery_ring` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `masterys` blob NOT NULL,
  `curPoint` int(11) NOT NULL DEFAULT '0',
  `curRingId` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_mastery_ring` */

/*Table structure for table `tb_message` */

DROP TABLE IF EXISTS `tb_message`;

CREATE TABLE `tb_message` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `createTime` datetime NOT NULL,
  `createPlayerId` varchar(500) NOT NULL DEFAULT '',
  `messageType` int(11) NOT NULL DEFAULT '0',
  `strMsg` blob NOT NULL,
  `data` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_message` */

/*Table structure for table `tb_mount` */

DROP TABLE IF EXISTS `tb_mount`;

CREATE TABLE `tb_mount` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `starLv` int(11) NOT NULL DEFAULT '0',
  `rideLevel` int(11) NOT NULL DEFAULT '0',
  `usingSkinId` int(11) NOT NULL DEFAULT '0',
  `mountSkins` blob NOT NULL,
  `rideFlag` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_mount` */

/*Table structure for table `tb_online_data` */

DROP TABLE IF EXISTS `tb_online_data`;

CREATE TABLE `tb_online_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `receiveMap` blob NOT NULL,
  `sumTime` bigint(20) NOT NULL DEFAULT '0',
  `lastTime` datetime NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_online_data` */

/*Table structure for table `tb_pay_gift` */

DROP TABLE IF EXISTS `tb_pay_gift`;

CREATE TABLE `tb_pay_gift` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `firstPayGift` blob NOT NULL,
  `dailyRecharge` blob NOT NULL,
  `dailyPayGift` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_pay_gift` */

/*Table structure for table `tb_pet` */

DROP TABLE IF EXISTS `tb_pet`;

CREATE TABLE `tb_pet` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `templateId` int(11) NOT NULL DEFAULT '0',
  `name` varchar(500) NOT NULL DEFAULT '',
  `level` int(11) NOT NULL DEFAULT '0',
  `exp` int(11) NOT NULL DEFAULT '0',
  `hp` int(11) NOT NULL DEFAULT '0',
  `mp` int(11) NOT NULL DEFAULT '0',
  `transformLevel` int(11) NOT NULL DEFAULT '0',
  `upGradeLevel` int(11) NOT NULL DEFAULT '0',
  `upGradeExp` int(11) NOT NULL DEFAULT '0',
  `luckyValue` int(11) NOT NULL DEFAULT '0',
  `deadSlotNum` int(11) NOT NULL DEFAULT '0',
  `fightPower` int(11) NOT NULL DEFAULT '0',
  `randProperty` blob NOT NULL,
  `skills` blob NOT NULL,
  `onHookData` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_pet` */

/*Table structure for table `tb_player` */

DROP TABLE IF EXISTS `tb_player`;

CREATE TABLE `tb_player` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `uid` varchar(500) NOT NULL DEFAULT '',
  `showServerId` int(11) NOT NULL DEFAULT '0',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `name` varchar(500) NOT NULL DEFAULT '',
  `camp` int(11) NOT NULL DEFAULT '0',
  `isDelete` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `exp` bigint(20) NOT NULL DEFAULT '0',
  `lineIndex` int(11) NOT NULL DEFAULT '0',
  `prestige` int(11) NOT NULL DEFAULT '0',
  `pro` int(11) NOT NULL DEFAULT '0',
  `diamond` int(11) NOT NULL DEFAULT '0',
  `ticket` int(11) NOT NULL DEFAULT '0',
  `gold` int(11) NOT NULL DEFAULT '0',
  `friendly` int(11) NOT NULL DEFAULT '0',
  `solopoint` int(11) NOT NULL DEFAULT '0',
  `consumePoint` int(11) NOT NULL DEFAULT '0',
  `charm` int(11) NOT NULL DEFAULT '0',
  `pawnGold` int(11) NOT NULL DEFAULT '0',
  `guildpoint` int(11) NOT NULL DEFAULT '0',
  `treasurePoint` int(11) NOT NULL DEFAULT '0',
  `fightPower` int(11) NOT NULL DEFAULT '0',
  `upOrder` int(11) NOT NULL DEFAULT '0',
  `upLevel` int(11) NOT NULL DEFAULT '0',
  `classExp` int(11) NOT NULL DEFAULT '0',
  `vip` int(11) NOT NULL DEFAULT '0',
  `vipTime` datetime NOT NULL,
  `bornType` int(11) NOT NULL DEFAULT '0',
  `state` int(11) NOT NULL DEFAULT '0',
  `enterState` int(11) NOT NULL DEFAULT '0',
  `isAcceptAutoTeam` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime NOT NULL,
  `loginTime` datetime NOT NULL,
  `logoutTime` datetime NOT NULL,
  `modifyTime` datetime NOT NULL,
  `refreshTime` datetime NOT NULL,
  `forbidTalkTime` datetime NOT NULL,
  `freezeTime` datetime NOT NULL,
  `totalCostDiamond` int(11) NOT NULL DEFAULT '0',
  `rewardDropNum` int(11) NOT NULL DEFAULT '0',
  `worldLevelTime` datetime NOT NULL,
  `needExp` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player` */

/*Table structure for table `tb_player_area` */

DROP TABLE IF EXISTS `tb_player_area`;

CREATE TABLE `tb_player_area` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `name` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_area` */

/*Table structure for table `tb_player_attach` */

DROP TABLE IF EXISTS `tb_player_attach`;

CREATE TABLE `tb_player_attach` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `equipGrids` blob NOT NULL,
  `strengthPos` blob NOT NULL,
  `sysSet` int(11) NOT NULL DEFAULT '0',
  `countItem` varchar(500) NOT NULL DEFAULT '',
  `miscData` blob NOT NULL,
  `guildBlessToday` int(11) NOT NULL DEFAULT '0',
  `guildSkillUpToday` int(11) NOT NULL DEFAULT '0',
  `guildDonateToday` int(11) NOT NULL DEFAULT '0',
  `transportData` blob NOT NULL,
  `medal` blob NOT NULL,
  `wing` blob NOT NULL,
  `clientConfig` blob NOT NULL,
  `mapData` blob NOT NULL,
  `firstKillMonsterIds` blob NOT NULL,
  `buffs` blob NOT NULL,
  `sceneProgress` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_attach` */

/*Table structure for table `tb_player_chou_ren` */

DROP TABLE IF EXISTS `tb_player_chou_ren`;

CREATE TABLE `tb_player_chou_ren` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `chouRens` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_chou_ren` */

/*Table structure for table `tb_player_consignment_items` */

DROP TABLE IF EXISTS `tb_player_consignment_items`;

CREATE TABLE `tb_player_consignment_items` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `local` blob NOT NULL,
  `global` blob NOT NULL,
  `buyFirstConsignItem` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_consignment_items` */

/*Table structure for table `tb_player_fashion` */

DROP TABLE IF EXISTS `tb_player_fashion`;

CREATE TABLE `tb_player_fashion` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `fashions` varchar(500) NOT NULL DEFAULT '',
  `equip_fashion` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_fashion` */

/*Table structure for table `tb_player_friends` */

DROP TABLE IF EXISTS `tb_player_friends`;

CREATE TABLE `tb_player_friends` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `friends` blob NOT NULL,
  `addPointTime` datetime NOT NULL,
  `addPointToday` int(11) NOT NULL DEFAULT '0',
  `friendShipTime` datetime NOT NULL,
  `applyFriendIds` blob NOT NULL,
  `blackList` blob NOT NULL,
  `friendMessage` blob NOT NULL,
  `recordInfos` blob NOT NULL,
  `dailyBoughtRecord` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_friends` */

/*Table structure for table `tb_player_guild` */

DROP TABLE IF EXISTS `tb_player_guild`;

CREATE TABLE `tb_player_guild` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `contribution` int(11) NOT NULL DEFAULT '0',
  `totalContributionMap` blob NOT NULL,
  `contributeTimesMap` blob NOT NULL,
  `lastSelfExitTime` datetime NOT NULL,
  `refreshTime` datetime NOT NULL,
  `depositCount` int(11) NOT NULL DEFAULT '0',
  `blessCount` int(11) NOT NULL DEFAULT '0',
  `blessRecState` blob NOT NULL,
  `joinDungeonGuildId` varchar(500) NOT NULL DEFAULT '',
  `joinDungeonTime` datetime NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_guild` */

/*Table structure for table `tb_player_instance` */

DROP TABLE IF EXISTS `tb_player_instance`;

CREATE TABLE `tb_player_instance` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `uid` varchar(500) NOT NULL DEFAULT '',
  `name` varchar(500) NOT NULL DEFAULT '',
  `pro` int(11) NOT NULL DEFAULT '0',
  `instanceId` varchar(500) NOT NULL DEFAULT '',
  `areaId` int(11) NOT NULL DEFAULT '0',
  `upLevel` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `frontServerId` varchar(500) NOT NULL DEFAULT '',
  `serverId` varchar(500) NOT NULL DEFAULT '',
  `acrossServerId` int(11) NOT NULL DEFAULT '0',
  `loginTime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_instance` */

/*Table structure for table `tb_player_p_k_data` */

DROP TABLE IF EXISTS `tb_player_p_k_data`;

CREATE TABLE `tb_player_p_k_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `pkModel` int(11) NOT NULL DEFAULT '0',
  `historyPkModel` int(11) NOT NULL DEFAULT '0',
  `pkValue` int(11) NOT NULL DEFAULT '0',
  `pkLevel` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_p_k_data` */

/*Table structure for table `tb_player_pets` */

DROP TABLE IF EXISTS `tb_player_pets`;

CREATE TABLE `tb_player_pets` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `fightingPetId` varchar(500) NOT NULL DEFAULT '',
  `pets` varchar(500) NOT NULL DEFAULT '',
  `pkModel` int(11) NOT NULL DEFAULT '0',
  `haveGotPet` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_pets` */

/*Table structure for table `tb_player_temp` */

DROP TABLE IF EXISTS `tb_player_temp`;

CREATE TABLE `tb_player_temp` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `historyAreaId` int(11) NOT NULL DEFAULT '0',
  `historyX` int(11) NOT NULL DEFAULT '0',
  `historyY` int(11) NOT NULL DEFAULT '0',
  `areaId` int(11) NOT NULL DEFAULT '0',
  `sceneType` int(11) NOT NULL DEFAULT '0',
  `x` int(11) NOT NULL DEFAULT '0',
  `y` int(11) NOT NULL DEFAULT '0',
  `bornAreaId` int(11) NOT NULL DEFAULT '0',
  `bornX` int(11) NOT NULL DEFAULT '0',
  `bornY` int(11) NOT NULL DEFAULT '0',
  `hp` int(11) NOT NULL DEFAULT '0',
  `mp` int(11) NOT NULL DEFAULT '0',
  `instanceId` varchar(500) NOT NULL DEFAULT '',
  `failedInstanceId` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_player_temp` */

/*Table structure for table `tb_prepaid_data` */

DROP TABLE IF EXISTS `tb_prepaid_data`;

CREATE TABLE `tb_prepaid_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `prepaidRecorder` blob NOT NULL,
  `rewardRecorder` blob NOT NULL,
  `dailyCharge` int(11) NOT NULL DEFAULT '0',
  `dailyDate` datetime NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_prepaid_data` */

/*Table structure for table `tb_rank` */

DROP TABLE IF EXISTS `tb_rank`;

CREATE TABLE `tb_rank` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `selectedRankId` int(11) NOT NULL DEFAULT '0',
  `awardRanks` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_rank` */

/*Table structure for table `tb_recent_chat` */

DROP TABLE IF EXISTS `tb_recent_chat`;

CREATE TABLE `tb_recent_chat` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `msg` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_recent_chat` */

/*Table structure for table `tb_shop_mall` */

DROP TABLE IF EXISTS `tb_shop_mall`;

CREATE TABLE `tb_shop_mall` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `seenTab` blob NOT NULL,
  `mallScoreItem` blob NOT NULL,
  `selfMallItemNums` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_shop_mall` */

/*Table structure for table `tb_skills_db` */

DROP TABLE IF EXISTS `tb_skills_db`;

CREATE TABLE `tb_skills_db` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `skills` blob NOT NULL,
  `skillKeys` blob NOT NULL,
  `openCount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_skills_db` */

/*Table structure for table `tb_solo_data` */

DROP TABLE IF EXISTS `tb_solo_data`;

CREATE TABLE `tb_solo_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `havePlayed` blob NOT NULL,
  `rankId` int(11) NOT NULL DEFAULT '0',
  `starPoint` int(11) NOT NULL DEFAULT '0',
  `rankGotTime` datetime NOT NULL,
  `contWinTimes` int(11) NOT NULL DEFAULT '0',
  `extrWinTimes` int(11) NOT NULL DEFAULT '0',
  `usedDefTimes` int(11) NOT NULL DEFAULT '0',
  `usedBuyTimes` int(11) NOT NULL DEFAULT '0',
  `leftBuyTimes` int(11) NOT NULL DEFAULT '0',
  `coolDownTime` datetime NOT NULL,
  `rankRewards` blob NOT NULL,
  `dailyRewards` blob NOT NULL,
  `dailyReceived` int(11) NOT NULL DEFAULT '0',
  `yestodayLeft` int(11) NOT NULL DEFAULT '0',
  `weeklyReward` blob NOT NULL,
  `weeklyJoinedTimes` int(11) NOT NULL DEFAULT '0',
  `dailyRewardTimes` int(11) NOT NULL DEFAULT '0',
  `weeklyResetTime` datetime NOT NULL,
  `dailyResetTime` datetime NOT NULL,
  `lastJoinedTime` datetime NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_solo_data` */

/*Table structure for table `tb_task_list` */

DROP TABLE IF EXISTS `tb_task_list`;

CREATE TABLE `tb_task_list` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `getDailySoulTaskCount` int(11) NOT NULL DEFAULT '0',
  `normalTasks` blob NOT NULL,
  `finishedNormalTasks` blob NOT NULL,
  `dailyTasks` blob NOT NULL,
  `finishedDailyTasks` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_task_list` */

/*Table structure for table `tb_vip` */

DROP TABLE IF EXISTS `tb_vip`;

CREATE TABLE `tb_vip` (
  `everyGetGift` blob NOT NULL,
  `everyBuyGift` blob NOT NULL,
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `vip` int(11) NOT NULL DEFAULT '0',
  `vipTime` datetime NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_vip` */

/*Table structure for table `tb_vitality_data` */

DROP TABLE IF EXISTS `tb_vitality_data`;

CREATE TABLE `tb_vitality_data` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `processData` blob NOT NULL,
  `rewardData` blob NOT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_vitality_data` */

/*Table structure for table `tb_wing_data` */

DROP TABLE IF EXISTS `tb_wing_data`;

CREATE TABLE `tb_wing_data` (
  `currLevel` varchar(50) NOT NULL DEFAULT '',
  `currStar` int(11) NOT NULL DEFAULT '0',
  `currExp` int(11) NOT NULL DEFAULT '0',
  `currReiki` int(11) NOT NULL DEFAULT '0',
  `savedLevel` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`currLevel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_wing_data` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
