/*
SQLyog Trial v9.30 
MySQL - 5.5.20 : Database - xmds_game
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`xmds_game` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `xmds_game`;

/*Table structure for table `tb_consignment_items` */

DROP TABLE IF EXISTS `tb_consignment_items`;

CREATE TABLE `tb_consignment_items` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `itemType` int(11) NOT NULL DEFAULT '0',
  `pro` int(11) NOT NULL DEFAULT '0',
  `itemSecondType` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `consignmentPrice` int(11) NOT NULL DEFAULT '0',
  `consignmentTime` datetime DEFAULT NULL,
  `isAnonymous` int(11) NOT NULL DEFAULT '0',
  `consignmentPlayerName` varchar(500) DEFAULT NULL,
  `consignmentPlayerPro` int(11) NOT NULL DEFAULT '0',
  `consignmentPlayerId` varchar(500) DEFAULT NULL,
  `groupCount` int(11) NOT NULL DEFAULT '0',
  `publishTimes` int(11) NOT NULL DEFAULT '0',
  `db` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_dao_you` */

DROP TABLE IF EXISTS `tb_dao_you`;

CREATE TABLE `tb_dao_you` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `adminPlayerId` varchar(500) DEFAULT NULL,
  `name` varchar(500) DEFAULT NULL,
  `fightPower` int(11) NOT NULL DEFAULT '0',
  `notice` varchar(500) DEFAULT NULL,
  `isEditedDyName` int(11) NOT NULL DEFAULT '0',
  `lastEditNameTime` datetime DEFAULT NULL,
  `messages` blob,
  `createTime` datetime DEFAULT NULL,
  `updateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_dao_you_member` */

DROP TABLE IF EXISTS `tb_dao_you_member`;

CREATE TABLE `tb_dao_you_member` (
  `playerId` varchar(50) NOT NULL DEFAULT '',
  `daoYouId` varchar(500) DEFAULT NULL,
  `totalSendRebate` int(11) NOT NULL DEFAULT '0',
  `todaySendRebate` blob,
  `totalReciveRebate` int(11) NOT NULL DEFAULT '0',
  `todayReciveRebate` int(11) NOT NULL DEFAULT '0',
  `joinTime` datetime DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `updateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_fee_order` */

DROP TABLE IF EXISTS `tb_fee_order`;

CREATE TABLE `tb_fee_order` (
  `orderId` varchar(64) NOT NULL DEFAULT '',
  `productId` int(11) NOT NULL DEFAULT '0',
  `playerId` varchar(500) DEFAULT NULL,
  `createtime` datetime DEFAULT NULL,
  `isCard` blob,
  PRIMARY KEY (`orderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_five2_five_player_btl_report` */

DROP TABLE IF EXISTS `tb_five2_five_player_btl_report`;

CREATE TABLE `tb_five2_five_player_btl_report` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `playerId` varchar(500) DEFAULT NULL,
  `status` int(11) NOT NULL DEFAULT '0',
  `scoreChange` int(11) NOT NULL DEFAULT '0',
  `resultInfoA` blob,
  `resultInfoB` blob,
  `createTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_five2_five_system` */

DROP TABLE IF EXISTS `tb_five2_five_system`;

CREATE TABLE `tb_five2_five_system` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `teamTotalMatchSuccessCostTime` bigint(20) NOT NULL DEFAULT '0',
  `singleTotalMatchSuccessCostTime` bigint(20) NOT NULL DEFAULT '0',
  `totalMatchSuccessSingle` int(11) NOT NULL DEFAULT '0',
  `totalMatchSuccessTeam` int(11) NOT NULL DEFAULT '0',
  `seasonRefreshTime` datetime DEFAULT NULL,
  `hasNoReciveRankRewardPlayer` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_guild` */

DROP TABLE IF EXISTS `tb_guild`;

CREATE TABLE `tb_guild` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `icon` varchar(500) DEFAULT NULL,
  `name` varchar(500) DEFAULT NULL,
  `level` int(11) NOT NULL DEFAULT '0',
  `presidentId` varchar(500) DEFAULT NULL,
  `presidentPro` int(11) NOT NULL DEFAULT '0',
  `presidentName` varchar(500) DEFAULT NULL,
  `qqGroup` varchar(500) DEFAULT NULL,
  `fund` bigint(20) NOT NULL DEFAULT '0',
  `sumFund` bigint(20) NOT NULL DEFAULT '0',
  `exp` bigint(20) NOT NULL DEFAULT '0',
  `entryLevel` int(11) NOT NULL DEFAULT '0',
  `entryUpLevel` int(11) NOT NULL DEFAULT '0',
  `guildMode` int(11) NOT NULL DEFAULT '0',
  `notice` varchar(500) DEFAULT NULL,
  `logicName` varchar(500) DEFAULT NULL,
  `jobName` varchar(500) DEFAULT NULL,
  `job` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  `changeNameTime` datetime DEFAULT NULL,
  `kickTime` datetime DEFAULT NULL,
  `kickCount` int(11) NOT NULL DEFAULT '0',
  `officeNames` blob,
  `allBlobData` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_guild_depot` */

DROP TABLE IF EXISTS `tb_guild_depot`;

CREATE TABLE `tb_guild_depot` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  `condition` blob,
  `news` blob,
  `bag` blob,
  `deleteCount` int(11) NOT NULL DEFAULT '0',
  `deleteCountMax` int(11) NOT NULL DEFAULT '0',
  `refreshTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_guild_dungeon` */

DROP TABLE IF EXISTS `tb_guild_dungeon`;

CREATE TABLE `tb_guild_dungeon` (
  `id` varchar(50) NOT NULL DEFAULT '',
  `openTimesToday` int(11) NOT NULL DEFAULT '0',
  `openState` int(11) NOT NULL DEFAULT '0',
  `bReward` int(11) NOT NULL DEFAULT '0',
  `currPassedCount` int(11) NOT NULL DEFAULT '0',
  `totalPassedCount` int(11) NOT NULL DEFAULT '0',
  `dungeonPassedTime` datetime DEFAULT NULL,
  `openTime` datetime DEFAULT NULL,
  `dungeonRecord` blob,
  `instanceId` varchar(500) DEFAULT NULL,
  `serverId` varchar(500) DEFAULT NULL,
  `throwInfo` blob,
  `damagePlayer` blob,
  `damageRankInfo` blob,
  `healRankInfo` blob,
  `enterState` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_guild_member` */

DROP TABLE IF EXISTS `tb_guild_member`;

CREATE TABLE `tb_guild_member` (
  `playerId` char(36) NOT NULL DEFAULT '',
  `guildId` varchar(500) DEFAULT NULL,
  `name` varchar(500) DEFAULT NULL,
  `pro` int(11) NOT NULL DEFAULT '0',
  `job` int(11) NOT NULL DEFAULT '0',
  `lastContributeValue` bigint(20) NOT NULL DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  `lastContributeTime` datetime DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player` */

DROP TABLE IF EXISTS `tb_player`;

CREATE TABLE `tb_player` (
  `id` char(36) NOT NULL DEFAULT '',
  `uid` varchar(256) DEFAULT NULL,
  `logicServerId` int(11) NOT NULL DEFAULT '0',
  `name` varchar(64) DEFAULT NULL,
  `isDelete` int(11) NOT NULL DEFAULT '0',
  `level` int(11) NOT NULL DEFAULT '0',
  `exp` bigint(20) NOT NULL DEFAULT '0',
  `prestige` int(11) NOT NULL DEFAULT '0',
  `pro` int(11) NOT NULL DEFAULT '0',
  `gold` int(11) NOT NULL DEFAULT '0',
  `diamond` int(11) NOT NULL DEFAULT '0',
  `ticket` int(11) NOT NULL DEFAULT '0',
  `friendly` int(11) NOT NULL DEFAULT '0',
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
  `vipEndTime` datetime DEFAULT NULL,
  `isAcceptAutoTeam` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  `loginTime` datetime DEFAULT NULL,
  `logoutTime` datetime DEFAULT NULL,
  `refreshTime` datetime DEFAULT NULL,
  `forbidTalkTime` datetime DEFAULT NULL,
  `freezeTime` datetime DEFAULT NULL,
  `forbidTalkReason` varchar(500) DEFAULT NULL,
  `freezeReason` varchar(500) DEFAULT NULL,
  `totalCostDiamond` int(11) NOT NULL DEFAULT '0',
  `fightingPetId` varchar(500) DEFAULT NULL,
  `lvChangeTime` datetime DEFAULT NULL,
  `fightChangeTime` datetime DEFAULT NULL,
  `openMount` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_achieves` */

DROP TABLE IF EXISTS `tb_player_achieves`;

CREATE TABLE `tb_player_achieves` (
  `playerId` char(36) NOT NULL,
  `achievements` blob,
  `receivedAwards` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_activity` */

DROP TABLE IF EXISTS `tb_player_activity`;

CREATE TABLE `tb_player_activity` (
  `playerId` char(36) NOT NULL,
  `luckyAwardContainer` blob,
  `refreshTime` datetime DEFAULT NULL,
  `buffTimes` int(11) NOT NULL DEFAULT '0',
  `activityRewardRecorder` blob,
  `activityInfo` blob,
  `drawedContainer` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_arena_data` */

DROP TABLE IF EXISTS `tb_player_arena_data`;

CREATE TABLE `tb_player_arena_data` (
  `playerId` char(36) NOT NULL,
  `usedDefTimes` int(11) NOT NULL DEFAULT '0',
  `singleReward` int(11) NOT NULL DEFAULT '0',
  `totalReward` int(11) NOT NULL DEFAULT '0',
  `score` int(11) NOT NULL DEFAULT '0',
  `combo` int(11) NOT NULL DEFAULT '0',
  `comboDaily` int(11) NOT NULL DEFAULT '0',
  `scoreMonth` int(11) NOT NULL DEFAULT '0',
  `killDaily` int(11) NOT NULL DEFAULT '0',
  `killMonth` int(11) NOT NULL DEFAULT '0',
  `deadMonth` int(11) NOT NULL DEFAULT '0',
  `singleWinTimes` int(11) NOT NULL DEFAULT '0',
  `firstSingleWinTime` bigint(20) NOT NULL DEFAULT '0',
  `activityTime` bigint(20) NOT NULL DEFAULT '0',
  `season` int(11) NOT NULL DEFAULT '0',
  `arenaInstanceId` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_attach` */

DROP TABLE IF EXISTS `tb_player_attach`;

CREATE TABLE `tb_player_attach` (
  `playerId` char(36) NOT NULL,
  `sysSet` int(11) NOT NULL DEFAULT '0',
  `miscData` blob,
  `guildBlessToday` int(11) NOT NULL DEFAULT '0',
  `guildSkillUpToday` int(11) NOT NULL DEFAULT '0',
  `guildDonateToday` int(11) NOT NULL DEFAULT '0',
  `medal` blob,
  `config` blob,
  `firstKillMonsterIds` blob,
  `buffs` blob,
  `sceneProgress` blob,
  `vipData` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_bags` */

DROP TABLE IF EXISTS `tb_player_bags`;

CREATE TABLE `tb_player_bags` (
  `playerId` char(36) NOT NULL,
  `bagData` mediumblob,
  `wareHouseData` mediumblob,
  `recycleData` mediumblob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_base` */

DROP TABLE IF EXISTS `tb_player_base`;

CREATE TABLE `tb_player_base` (
  `playerId` char(36) NOT NULL,
  `equipGrids` blob,
  `strengthPos` blob,
  `model` varchar(500) DEFAULT NULL,
  `speed` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_chouren` */

DROP TABLE IF EXISTS `tb_player_chouren`;

CREATE TABLE `tb_player_chouren` (
  `playerId` char(36) NOT NULL,
  `chouRens` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_consignment` */

DROP TABLE IF EXISTS `tb_player_consignment`;

CREATE TABLE `tb_player_consignment` (
  `playerId` char(36) NOT NULL,
  `buyFirstConsignItem` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_daily` */

DROP TABLE IF EXISTS `tb_player_daily`;

CREATE TABLE `tb_player_daily` (
  `playerId` char(36) NOT NULL,
  `activeMap` blob,
  `rewards` blob,
  `totalDegree` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_fightlevel` */

DROP TABLE IF EXISTS `tb_player_fightlevel`;

CREATE TABLE `tb_player_fightlevel` (
  `playerId` char(36) NOT NULL,
  `todays` blob,
  `finishes` blob,
  `resourceDungeon` blob,
  `doubleReward` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_five2five` */

DROP TABLE IF EXISTS `tb_player_five2five`;

CREATE TABLE `tb_player_five2five` (
  `playerId` char(36) NOT NULL,
  `score` int(11) NOT NULL DEFAULT '0',
  `winCount` int(11) NOT NULL DEFAULT '0',
  `tieCount` int(11) NOT NULL DEFAULT '0',
  `failCount` int(11) NOT NULL DEFAULT '0',
  `mvpCount` int(11) NOT NULL DEFAULT '0',
  `canReciveRewardCount` int(11) NOT NULL DEFAULT '0',
  `lastChallengeTime` datetime DEFAULT NULL,
  `hasReciveRewardCount` int(11) NOT NULL DEFAULT '0',
  `lastReciveRewardTime` datetime DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `updateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_friends` */

DROP TABLE IF EXISTS `tb_player_friends`;

CREATE TABLE `tb_player_friends` (
  `playerId` char(36) NOT NULL,
  `friends` blob,
  `addPointTime` datetime DEFAULT NULL,
  `addPointToday` int(11) NOT NULL DEFAULT '0',
  `friendShipTime` datetime DEFAULT NULL,
  `applyFriendIds` blob,
  `blackList` blob,
  `friendMessage` blob,
  `recordInfos` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_func_open` */

DROP TABLE IF EXISTS `tb_player_func_open`;

CREATE TABLE `tb_player_func_open` (
  `playerId` char(36) NOT NULL,
  `openMap` blob,
  `playMap` blob,
  `functionAwards` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_guild` */

DROP TABLE IF EXISTS `tb_player_guild`;

CREATE TABLE `tb_player_guild` (
  `playerId` char(36) NOT NULL,
  `contribution` int(11) NOT NULL DEFAULT '0',
  `totalContributionMap` blob,
  `contributeTimesMap` blob,
  `lastSelfExitTime` datetime DEFAULT NULL,
  `refreshTime` datetime DEFAULT NULL,
  `depositCount` int(11) NOT NULL DEFAULT '0',
  `blessCount` int(11) NOT NULL DEFAULT '0',
  `blessRecState` blob,
  `joinDungeonGuildId` varchar(500) DEFAULT NULL,
  `joinDungeonTime` datetime DEFAULT NULL,
  `buffTime` int(11) NOT NULL DEFAULT '0',
  `buffIds` blob,
  `skills` blob,
  `boughtList` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_hookset` */

DROP TABLE IF EXISTS `tb_player_hookset`;

CREATE TABLE `tb_player_hookset` (
  `playerId` char(36) NOT NULL,
  `hpPercent` int(11) NOT NULL DEFAULT '0',
  `mpPercent` int(11) NOT NULL DEFAULT '0',
  `hpItemCode` varchar(500) DEFAULT NULL,
  `mpItemCode` varchar(500) DEFAULT NULL,
  `pkSet` int(11) NOT NULL DEFAULT '0',
  `meltQcolor` blob,
  `autoBuyHpItem` int(11) NOT NULL DEFAULT '0',
  `autoBuyMpItem` int(11) NOT NULL DEFAULT '0',
  `fieldMaphook` int(11) NOT NULL DEFAULT '0',
  `areaMaphook` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_leaderboard` */

DROP TABLE IF EXISTS `tb_player_leaderboard`;

CREATE TABLE `tb_player_leaderboard` (
  `playerId` char(36) NOT NULL,
  `worShipTimes` int(11) NOT NULL DEFAULT '0',
  `worShipTime` datetime DEFAULT NULL,
  `worShipDiamondTimes` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_mails` */

DROP TABLE IF EXISTS `tb_player_mails`;

CREATE TABLE `tb_player_mails` (
  `playerId` char(36) NOT NULL,
  `mails` mediumblob,
  `serverMailRecord` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_mount` */

DROP TABLE IF EXISTS `tb_player_mount`;

CREATE TABLE `tb_player_mount` (
  `playerId` char(36) NOT NULL,
  `starLv` int(11) NOT NULL DEFAULT '0',
  `rideLevel` int(11) NOT NULL DEFAULT '0',
  `usingSkinId` int(11) NOT NULL DEFAULT '0',
  `mountSkins` blob,
  `fightPower` int(11) NOT NULL DEFAULT '0',
  `rideFlag` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_online_data` */

DROP TABLE IF EXISTS `tb_player_online_data`;

CREATE TABLE `tb_player_online_data` (
  `playerId` char(36) NOT NULL,
  `sumTime` bigint(20) NOT NULL DEFAULT '0',
  `rewardState` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_pets` */

DROP TABLE IF EXISTS `tb_player_pets`;

CREATE TABLE `tb_player_pets` (
  `playerId` char(36) NOT NULL,
  `pets` blob,
  `fightPetId` int(11) NOT NULL DEFAULT '0',
  `pkModel` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_pk_data` */

DROP TABLE IF EXISTS `tb_player_pk_data`;

CREATE TABLE `tb_player_pk_data` (
  `playerId` char(36) NOT NULL,
  `pkModel` int(11) NOT NULL DEFAULT '0',
  `historyPkModel` int(11) NOT NULL DEFAULT '0',
  `pkValue` int(11) NOT NULL DEFAULT '0',
  `pkLevel` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_recent_chat` */

DROP TABLE IF EXISTS `tb_player_recent_chat`;

CREATE TABLE `tb_player_recent_chat` (
  `playerId` char(36) NOT NULL,
  `msg` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_shop_mall` */

DROP TABLE IF EXISTS `tb_player_shop_mall`;

CREATE TABLE `tb_player_shop_mall` (
  `playerId` char(36) NOT NULL,
  `seenTab` blob,
  `dayMallItemNums` blob,
  `weekMallItemNums` blob,
  `resetTime` datetime DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_sign` */

DROP TABLE IF EXISTS `tb_player_sign`;

CREATE TABLE `tb_player_sign` (
  `playerId` char(36) NOT NULL,
  `stage` int(11) NOT NULL DEFAULT '0',
  `lastSignTime` datetime DEFAULT NULL,
  `lastLuxuryTime` datetime DEFAULT NULL,
  `luxuryState` int(11) NOT NULL DEFAULT '0',
  `signMap` blob,
  `cumulativeMap` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_skill` */

DROP TABLE IF EXISTS `tb_player_skill`;

CREATE TABLE `tb_player_skill` (
  `playerId` char(36) NOT NULL,
  `skills` blob,
  `skillKeys` blob,
  `openCount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_solo_data` */

DROP TABLE IF EXISTS `tb_player_solo_data`;

CREATE TABLE `tb_player_solo_data` (
  `playerId` char(36) NOT NULL,
  `havePlayed` blob,
  `score` int(11) NOT NULL DEFAULT '0',
  `curRank` int(11) NOT NULL DEFAULT '0',
  `soloPoint` int(11) NOT NULL DEFAULT '0',
  `soloPointToday` int(11) NOT NULL DEFAULT '0',
  `rankId` int(11) NOT NULL DEFAULT '0',
  `rankGotTime` datetime DEFAULT NULL,
  `rankRewards` blob,
  `dailyRewards` blob,
  `dailyReceived` int(11) NOT NULL DEFAULT '0',
  `dailyBattleTimes` int(11) NOT NULL DEFAULT '0',
  `dailyRewardRound` int(11) NOT NULL DEFAULT '0',
  `dailyResetTime` datetime DEFAULT NULL,
  `lastJoinedTime` datetime DEFAULT NULL,
  `contWinTimes` int(11) NOT NULL DEFAULT '0',
  `extrWinTimes` int(11) NOT NULL DEFAULT '0',
  `maxContWinTimes` int(11) NOT NULL DEFAULT '0',
  `contLoseTimes` int(11) NOT NULL DEFAULT '0',
  `maxContLoseTimes` int(11) NOT NULL DEFAULT '0',
  `term` int(11) NOT NULL DEFAULT '0',
  `battleTimes` int(11) NOT NULL DEFAULT '0',
  `winTotalTimes` int(11) NOT NULL DEFAULT '0',
  `loseTotalTimes` int(11) NOT NULL DEFAULT '0',
  `winTimes_canglang` int(11) NOT NULL DEFAULT '0',
  `winTimes_yujian` int(11) NOT NULL DEFAULT '0',
  `winTimes_yixian` int(11) NOT NULL DEFAULT '0',
  `winTimes_shenjian` int(11) NOT NULL DEFAULT '0',
  `winTimes_linghu` int(11) NOT NULL DEFAULT '0',
  `battleTimes_canglang` int(11) NOT NULL DEFAULT '0',
  `battleTimes_yujian` int(11) NOT NULL DEFAULT '0',
  `battleTimes_yixian` int(11) NOT NULL DEFAULT '0',
  `battleTimes_shenjian` int(11) NOT NULL DEFAULT '0',
  `battleTimes_linghu` int(11) NOT NULL DEFAULT '0',
  `battleRecords` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_tasks` */

DROP TABLE IF EXISTS `tb_player_tasks`;

CREATE TABLE `tb_player_tasks` (
  `playerId` char(36) NOT NULL,
  `normalTasks` blob,
  `finishedNormalTasks` blob,
  `dailyTasks` blob,
  `finishedDailyTasks` blob,
  `todayLoopTaskCount` int(11) NOT NULL DEFAULT '0',
  `todayDailyTaskCount` int(11) NOT NULL DEFAULT '0',
  `loopBreaked` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_temp_data` */

DROP TABLE IF EXISTS `tb_player_temp_data`;

CREATE TABLE `tb_player_temp_data` (
  `playerId` char(36) NOT NULL,
  `historyAreaId` int(11) NOT NULL DEFAULT '0',
  `historyX` int(11) NOT NULL DEFAULT '0',
  `historyY` int(11) NOT NULL DEFAULT '0',
  `bornAreaId` int(11) NOT NULL DEFAULT '0',
  `bornX` float NOT NULL DEFAULT '0',
  `bornY` float NOT NULL DEFAULT '0',
  `areaId` int(11) NOT NULL DEFAULT '0',
  `x` float NOT NULL DEFAULT '0',
  `y` float NOT NULL DEFAULT '0',
  `hp` int(11) NOT NULL DEFAULT '0',
  `mp` int(11) NOT NULL DEFAULT '0',
  `teamId` varchar(500) DEFAULT NULL,
  `sendMailItemNum` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_title` */

DROP TABLE IF EXISTS `tb_player_title`;

CREATE TABLE `tb_player_title` (
  `playerId` char(36) NOT NULL,
  `selectedRankId` int(11) NOT NULL DEFAULT '0',
  `awardRanks` blob,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `tb_player_xianyuan` */

DROP TABLE IF EXISTS `tb_player_xianyuan`;

CREATE TABLE `tb_player_xianyuan` (
  `playerId` char(36) NOT NULL,
  `funReviceInfo` blob,
  `xianYuanNum` int(11) NOT NULL DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  `updateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`playerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
