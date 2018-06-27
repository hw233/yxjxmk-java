/*
SQLyog Trial v9.30 
MySQL - 5.5.20 : Database - xmds-gm
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`xmds-gm` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `xmds-gm`;

/*Table structure for table `t_global_mail` */

DROP TABLE IF EXISTS `t_global_mail`;

CREATE TABLE `t_global_mail` (
  `id` varchar(50) NOT NULL,
  `create_date` varchar(50) DEFAULT NULL,
  `servers` text,
  `content` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `t_global_mail` */

insert  into `t_global_mail`(`id`,`create_date`,`servers`,`content`) values ('1c80817d-48d9-4fee-a4f3-4a3be459c515','2017-07-28 19:07:23','213','[1,\"\",\"123123\",\"123123\",\"\",\"2017-07-29 19:06:32\",\"1\",\"phelm3-10:1\",\"1c80817d-48d9-4fee-a4f3-4a3be459c515\"]'),('41692a9f-dfdb-44c7-8dec-57217c8adaff','2017-07-27 13:50:09','119','[1,\"\",\"1111111111\",\"11111111111\",\"\",\"2017-07-28 13:48:17\",\"1\",\"dneck3-10:1\",\"41692a9f-dfdb-44c7-8dec-57217c8adaff\"]'),('828aa8a0-0c47-4249-9ff7-55d249e8dd69','2017-07-27 13:54:20','119','[1,\"\",\"2222222222\",\"2222222222\",\"\",\"2017-07-28 13:48:17\",\"1\",\"dneck3-10:1\",\"828aa8a0-0c47-4249-9ff7-55d249e8dd69\"]'),('e3989ee0-fd34-4dee-92b0-d650779e6669','2017-07-27 14:54:08','119','[1,\"\",\"333333333\",\"333333333\",\"\",\"2017-07-28 13:48:17\",\"1\",\"dneck3-10:1\",\"e3989ee0-fd34-4dee-92b0-d650779e6669\"]'),('f8c0a8d7-7e8b-4dd6-85e7-f3544748c830','2017-07-24 15:47:22','209','[1,\"\",\"测试\",\"123123123\",\"\",\"2017-07-24 15:43:39\",\"40\",\"gb7:1;lneck1-60:1;rpk10:1\",\"f8c0a8d7-7e8b-4dd6-85e7-f3544748c830\"]');

/*Table structure for table `t_gm` */

DROP TABLE IF EXISTS `t_gm`;

CREATE TABLE `t_gm` (
  `F_ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_UName` varchar(18) NOT NULL,
  `F_Pwd` char(32) NOT NULL,
  `F_RealName` varchar(20) DEFAULT NULL,
  `F_CreateTime` datetime NOT NULL,
  `F_Group` int(11) DEFAULT NULL,
  `F_Email` varchar(30) DEFAULT NULL,
  `F_Phone` char(12) DEFAULT NULL,
  `F_Status` tinyint(4) DEFAULT NULL,
  `F_Desc` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`F_ID`),
  UNIQUE KEY `F_UName` (`F_UName`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

/*Data for the table `t_gm` */

insert  into `t_gm`(`F_ID`,`F_UName`,`F_Pwd`,`F_RealName`,`F_CreateTime`,`F_Group`,`F_Email`,`F_Phone`,`F_Status`,`F_Desc`) values (1,'sa','e10adc3949ba59abbe56e057f20f883e','超级管理员','2014-05-20 16:16:16',1,NULL,NULL,1,'超级管理员：提供除删除超级管理员外的所有功能'),(2,'gm','e10adc3949ba59abbe56e057f20f883e','运营人员','2014-05-20 19:24:57',7,NULL,'13456789999',1,'系统管理员'),(3,'agui','e10adc3949ba59abbe56e057f20f883e','阿贵','2014-11-17 00:00:00',7,NULL,NULL,1,NULL),(4,'fengruixiang','3d8b97e1846950592f00037e747ca013','冯瑞祥','2017-05-08 00:00:00',7,NULL,NULL,1,NULL),(5,'test','96e79218965eb72c92a549dd5a330112','xx','2017-05-10 00:00:00',2,NULL,NULL,1,NULL),(6,'wanda','11ccac747fa0b21571d02905a702663f','万达运营','2017-06-03 00:00:00',8,NULL,NULL,1,NULL);

/*Table structure for table `t_gm_group` */

DROP TABLE IF EXISTS `t_gm_group`;

CREATE TABLE `t_gm_group` (
  `F_ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_Name` varchar(20) NOT NULL,
  `F_Permission` varchar(500) NOT NULL,
  `F_Desc` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`F_ID`),
  UNIQUE KEY `F_Name` (`F_Name`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

/*Data for the table `t_gm_group` */

insert  into `t_gm_group`(`F_ID`,`F_Name`,`F_Permission`,`F_Desc`) values (1,'超级管理员','*','超级管理员拥有GM工具中除了删除【超级管理员】组以外的所有权限'),(2,'市场','[20,23,26,98,302,250,3,9]','市场'),(6,'运营','[270,401,276,20,277,23,24,25,601,26,98,301,302,303,501,250,3,9,701]',NULL),(7,'管理','[10,14,270,401,276,20,277,23,24,25,601,26,98,301,302,303,501,250,3,9,701]',NULL),(8,'万达','[14,270,276,277,23,26,301,302,303,250,3,9,701]',NULL);

/*Table structure for table `t_gm_log` */

DROP TABLE IF EXISTS `t_gm_log`;

CREATE TABLE `t_gm_log` (
  `F_ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_Servers` varchar(200) DEFAULT NULL,
  `F_Type` int(11) NOT NULL,
  `F_OP` char(10) DEFAULT NULL,
  `F_GM` varchar(50) NOT NULL,
  `F_Content` varchar(5000) DEFAULT NULL,
  `F_Result` varchar(500) NOT NULL,
  `F_Time` datetime NOT NULL,
  `F_IP` char(15) NOT NULL,
  PRIMARY KEY (`F_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4822 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

/*Data for the table `t_gm_log` */

insert  into `t_gm_log`(`F_ID`,`F_Servers`,`F_Type`,`F_OP`,`F_GM`,`F_Content`,`F_Result`,`F_Time`,`F_IP`) values (4753,NULL,1,NULL,'sa',NULL,'1','2017-04-27 17:29:03','0:0:0:0:0:0:0:1'),(4754,NULL,1,NULL,'sa',NULL,'1','2017-04-27 17:44:51','127.0.0.1'),(4755,NULL,1,NULL,'sa',NULL,'1','2017-04-27 18:30:44','0:0:0:0:0:0:0:1'),(4756,NULL,1,NULL,'sa',NULL,'1','2017-04-27 19:29:25','0:0:0:0:0:0:0:1'),(4757,NULL,1,NULL,'sa',NULL,'1','2017-04-27 19:32:47','192.168.1.117'),(4758,NULL,1,'login','sa','sa','1','2017-04-27 19:45:33','192.168.1.117'),(4759,NULL,1,'login','sa','sa','1','2017-04-27 19:59:54','192.168.1.117'),(4760,NULL,1,'login','sa','sa','1','2017-04-27 20:04:49','192.168.1.117'),(4761,NULL,1,'login','sa','sa','1','2017-04-27 20:05:53','192.168.1.117'),(4762,NULL,1,NULL,'sa',NULL,'1','2017-04-27 20:48:58','0:0:0:0:0:0:0:1'),(4763,NULL,1,NULL,'sa',NULL,'1','2017-04-28 09:42:34','0:0:0:0:0:0:0:1'),(4764,NULL,1,NULL,'sa',NULL,'1','2017-04-28 11:31:10','0:0:0:0:0:0:0:1'),(4765,NULL,1,'login','sa','sa','1','2017-04-28 17:14:24','192.168.1.117'),(4766,'117',3,'11cc','sa','[\"123456\",false]','{\"117\":-1}','2017-04-28 17:14:33','192.168.1.117'),(4767,NULL,1,NULL,'sa',NULL,'1','2017-04-28 17:19:34','0:0:0:0:0:0:0:1'),(4768,NULL,1,'login','sa','sa','1','2017-05-10 16:38:02','0:0:0:0:0:0:0:1'),(4769,NULL,2,'logout','sa','sa','1','2017-05-10 16:46:42','0:0:0:0:0:0:0:1'),(4770,NULL,1,'login','test','test','1','2017-05-10 16:46:47','0:0:0:0:0:0:0:1'),(4771,NULL,1,'login','sa','sa','1','2017-05-10 17:04:36','0:0:0:0:0:0:0:1'),(4772,NULL,1,'login','sa','sa','1','2017-05-23 16:22:15','192.168.1.117'),(4773,NULL,8,'4','sa','/xmds-gm/action/dispatcher','1','2017-05-23 16:24:04','192.168.1.117'),(4774,NULL,8,'3','sa','/xmds-gm/action/dispatcher','1','2017-05-23 16:24:18','192.168.1.117'),(4775,NULL,1,'login','sa','sa','1','2017-05-23 16:30:30','192.168.1.117'),(4776,NULL,1,'login','sa','sa','1','2017-05-23 16:33:08','192.168.1.117'),(4777,NULL,8,'4','sa','module=4&','1','2017-05-23 16:33:25','192.168.1.117'),(4778,NULL,1,'login','sa','sa','1','2017-06-05 12:21:00','192.168.1.117'),(4779,NULL,1,'login','sa','sa','1','2017-06-05 13:19:00','192.168.1.117'),(4780,NULL,1,'login','sa','sa','1','2017-06-05 13:29:44','192.168.1.117'),(4781,NULL,1,'login','sa','sa','1','2017-06-05 13:35:00','192.168.1.117'),(4782,NULL,1,'login','sa','sa','1','2017-06-05 13:47:11','0:0:0:0:0:0:0:1'),(4783,NULL,8,'5','sa','id=53&serverId=53&areaId=1&name=钢子&olLimit=1000&show=2&isNew=0&isHot=0&isRecommend=0&module=5&op=1&','1','2017-06-05 13:55:19','0:0:0:0:0:0:0:1'),(4784,NULL,8,'5','sa','id=53&ip=192.168.1.53:3015&module=5&op=4&','1','2017-06-05 13:55:35','0:0:0:0:0:0:0:1'),(4785,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=1&isNew=0&serverId=53&areaId=1&name=钢子&host=192.168.1.53:3015&id=53&openDate=2017-06-05 13:55:19&isHot=0&module=5&op=3&','1','2017-06-05 13:56:35','0:0:0:0:0:0:0:1'),(4786,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=53&areaId=1&name=钢子&host=192.168.1.53:3015&id=53&openDate=2017-06-05 13:55:19&isHot=0&module=5&op=3&','1','2017-06-05 13:56:38','0:0:0:0:0:0:0:1'),(4787,NULL,1,'login','sa','sa','1','2017-06-05 14:11:43','192.168.1.143'),(4788,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=53&areaId=1&name=钢子&host=192.168.1.53:3015&id=53&openDate=2017-06-05 13:55:19&isHot=0&module=5&op=3&','1','2017-06-05 14:12:07','192.168.1.143'),(4789,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=53&areaId=2&name=钢子&host=192.168.1.53:3015&id=53&state=1&openDate=2017-06-05 13:55:19&isHot=0&module=5&op=3&','1','2017-06-05 14:19:04','192.168.1.143'),(4790,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=53&areaId=2&name=钢子&host=192.168.1.53:3015&id=53&state=1&openDate=2017-06-05 13:55:19&isHot=0&module=5&op=3&','1','2017-06-05 14:19:32','192.168.1.143'),(4791,NULL,8,'5','sa','olLimit=1000&show=2&isNew=1&serverId=143&areaId=1&name=lxm&host=192.168.1.143:3015&id=143&openDate=2017-04-27 17:46:06&module=5&op=2&','1','2017-06-05 14:31:49','192.168.1.143'),(4792,NULL,1,'login','sa','sa','1','2017-06-05 15:00:41','192.168.1.143'),(4793,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=1&name=143&host=192.168.1.143:3015&id=143&state=1&isHot=0&module=5&op=3&','1','2017-06-05 15:03:37','192.168.1.143'),(4794,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=2&name=143&host=192.168.1.143:3015&id=143&state=1&openDate=2017-06-05 15:03:37&isHot=0&module=5&op=3&','1','2017-06-05 15:04:16','192.168.1.143'),(4795,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=1&name=143&host=192.168.1.143:3015&id=143&state=1&openDate=2017-06-05 15:03:37&isHot=0&module=5&op=3&','1','2017-06-05 15:04:37','192.168.1.143'),(4796,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=1&name=143&host=192.168.1.143:3015&id=143&state=1&openDate=2017-06-05 15:03:37&isHot=0&module=5&op=3&','1','2017-06-05 15:04:39','192.168.1.143'),(4797,NULL,1,'login','sa','sa','1','2017-06-05 15:15:52','192.168.1.117'),(4798,NULL,1,'login','sa','sa','1','2017-06-05 15:22:42','192.168.1.117'),(4799,NULL,1,'login','sa','sa','1','2017-06-05 15:26:36','192.168.1.117'),(4800,NULL,1,'login','gm','gm','1','2017-06-05 15:26:43','192.168.1.143'),(4801,NULL,1,'login','sa','sa','1','2017-06-05 15:26:05','192.168.1.117'),(4802,NULL,1,'login','sa','sa','1','2017-06-05 15:29:44','192.168.1.117'),(4803,NULL,2,'logout','gm','gm','1','2017-06-05 15:30:36','192.168.1.143'),(4804,NULL,1,'login','sa','sa','1','2017-06-05 15:30:40','192.168.1.143'),(4805,NULL,1,'login','sa','sa','1','2017-06-05 15:31:46','192.168.1.117'),(4806,NULL,1,'login','gm','gm','1','2017-06-05 15:35:17','192.168.1.143'),(4807,NULL,2,'logout','gm','gm','1','2017-06-05 15:55:13','192.168.1.143'),(4808,NULL,1,'login','gm','gm','1','2017-06-05 15:55:16','192.168.1.143'),(4809,NULL,2,'logout','gm','gm','1','2017-06-05 15:55:54','192.168.1.143'),(4810,NULL,1,'login','sa','sa','1','2017-06-05 15:55:58','192.168.1.143'),(4811,NULL,8,'3','sa','createTime=2014-05-20 19:24:57&desc=系统管理员&group=7&id=2&phone=13456789999&pwd=e10adc3949ba59abbe56e057f20f883e&realName=运营人员&status=1&uname=gm&module=3&op=3&','1','2017-06-05 15:56:17','192.168.1.143'),(4812,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=1&name=Lxm&host=192.168.1.143:3015&id=143&state=1&openDate=2017-06-05 15:03:37&isHot=0&module=5&op=3&','1','2017-06-05 16:30:09','192.168.1.143'),(4813,NULL,8,'5','sa','isRecommend=0&olLimit=1000&show=2&isNew=0&serverId=0&areaId=1&name=lxm&host=192.168.1.143:3015&id=143&state=1&openDate=2017-06-05 15:03:37&isHot=0&module=5&op=3&','1','2017-06-05 16:30:35','192.168.1.143'),(4814,NULL,2,'logout','sa','sa','1','2017-06-05 16:31:30','192.168.1.143'),(4815,NULL,1,'login','gm','gm','1','2017-06-05 16:31:34','192.168.1.143'),(4816,NULL,1,'login','sa','sa','1','2017-06-05 19:45:18','192.168.1.101'),(4817,NULL,1,'login','sa','sa','1','2017-06-05 19:48:34','192.168.1.101'),(4818,'209',6,'1120','sa','111[0717].txt','111[0717].txt','2017-06-05 19:53:50','192.168.1.101'),(4819,'209',6,'1120','sa','222[0718].txt','222[0718].txt','2017-06-05 19:55:24','192.168.1.101'),(4820,NULL,1,'login','gm','gm','1','2017-06-05 19:59:01','192.168.1.143'),(4821,NULL,2,'logout','gm','gm','1','2017-06-05 20:15:21','192.168.1.143');

/*Table structure for table `t_gm_resource` */

DROP TABLE IF EXISTS `t_gm_resource`;

CREATE TABLE `t_gm_resource` (
  `F_ID` int(11) NOT NULL DEFAULT '0' COMMENT '菜单编号',
  `F_PID` int(11) NOT NULL COMMENT '父菜单的编号',
  `F_Name` varchar(50) NOT NULL COMMENT '资源名',
  `F_Code_W` varchar(100) DEFAULT NULL COMMENT '写操作权限码',
  `F_Code` varchar(100) DEFAULT NULL COMMENT '权限码',
  `F_Type` tinyint(4) NOT NULL DEFAULT '0' COMMENT '客户端打开方式',
  `F_IconCls` varchar(12) DEFAULT NULL COMMENT '树形菜单上的图标',
  `F_State` varchar(10) DEFAULT NULL COMMENT '树形菜单上的闭合状态',
  `F_Resource` varchar(50) DEFAULT NULL COMMENT '页面资源引用',
  PRIMARY KEY (`F_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

/*Data for the table `t_gm_resource` */

insert  into `t_gm_resource`(`F_ID`,`F_PID`,`F_Name`,`F_Code_W`,`F_Code`,`F_Type`,`F_IconCls`,`F_State`,`F_Resource`) values (24,2,'脚本执行',NULL,'11cc',5,'icon-ok',NULL,'game/script.html'),(277,2,'充值补单',NULL,'2030',5,'icon-edit',NULL,'game/pay.html'),(14,1,'服务器列表管理',NULL,NULL,4,'icon-edit',NULL,'gm/serverlist.html'),(270,2,'充值查询',NULL,'2010',5,'icon-search',NULL,'game/pay_query.html'),(279,1,'GM操作记录',NULL,'2005',5,'icon-search',NULL,'gm/gmlogs.html'),(1,0,'管理员功能',NULL,NULL,0,'icon-edit',NULL,NULL),(23,2,'CDKey',NULL,'1120;1121',5,'icon-edit',NULL,'game/activity/cdkey.html'),(2,0,'游戏管理',NULL,NULL,0,'icon-reload',NULL,NULL),(9,0,'退出当前账号',NULL,NULL,0,'icon-ok',NULL,NULL),(276,2,'登陆公告',NULL,'2020;2021;2022',4,'icon-edit',NULL,'game/announcement.html'),(26,2,'滚动公告',NULL,'1181;1182',5,'icon-search',NULL,'game/system/notice.html'),(13,1,'GM用户管理',NULL,NULL,4,'icon-edit',NULL,'gm/admin.html'),(10,1,'GM工具白名单',NULL,NULL,4,'icon-ok',NULL,'gm/config.html'),(12,1,'权限组管理',NULL,NULL,4,'icon-edit',NULL,'gm/group.html'),(301,2,'用户管理',NULL,'3001;3002;3003;3004',4,'icon-edit',NULL,'game/player/role_manager.html'),(20,2,'玩家反馈',NULL,'1131;1132',5,'icon-search',NULL,'game/system/comment.html'),(11,1,'资源管理',NULL,NULL,4,'icon-edit',NULL,'gm/resource.html'),(98,2,'刷新配置数据',NULL,'5000',5,'icon-reload',NULL,'game/refresh.html'),(250,2,'发送邮件',NULL,'11e1;3030',5,'icon-edit',NULL,'game/mail.html'),(25,2,'白名单',NULL,NULL,4,'icon-edit',NULL,'game/system/whitelist.html'),(302,2,'用户查询',NULL,'3020;3021;3022;3023;3024;3025;3026;3027',5,'icon-search',NULL,'game/player/role_query.html'),(303,2,'仙盟查询',NULL,'3031;3032',5,'icon-search',NULL,'game/guild.html'),(401,2,'道友查询',NULL,'4010',5,'icon-search',NULL,'game/daoyou.html'),(501,2,'排行榜',NULL,'5010',5,'icon-search',NULL,'game/rank.html'),(601,2,'热加载',NULL,'6010',5,'icon-ok',NULL,'game/reload.html'),(3,0,'修改密码',NULL,NULL,4,'icon-lock',NULL,'gm/pwd.html'),(701,2,'游戏内公告',NULL,'7010;7011;7012',5,'icon-edit',NULL,'game/game_notice.html');

/*Table structure for table `t_notice` */

DROP TABLE IF EXISTS `t_notice`;

CREATE TABLE `t_notice` (
  `id` varchar(50) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `content` varchar(1000) DEFAULT NULL,
  `begin_date` varchar(50) DEFAULT NULL,
  `end_date` varchar(50) DEFAULT NULL,
  `interval_minute` int(11) NOT NULL,
  `sended_num` int(11) NOT NULL,
  `servers` text,
  `create_date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `t_notice` */

insert  into `t_notice`(`id`,`name`,`content`,`begin_date`,`end_date`,`interval_minute`,`sended_num`,`servers`,`create_date`) values ('04b08d83-4752-48d0-a022-8a49a2e92b03','停服公告','服务器将于下午2点停服','2017-07-12 13:43:01','2017-07-12 13:45:03',1,3,'209','2017-07-12 13:43:18'),('0a208cd0-1ece-4aa5-801d-b98fbd9bc4c6','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:11:24','2017-07-12 14:13:09',1,0,'209','2017-07-12 14:13:14'),('0ae15a7b-f427-4345-a9f3-a59af064d1c7','停服更新公告','服务器将于5分钟后停服更新，修复40级任务无法完成问题','2017-06-09 13:38:05','2017-06-09 13:43:11',2,3,'213','2017-06-09 13:40:56'),('179bb2f9-de0c-4ce4-b832-ed382e0fc3da','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:00:24','2017-07-12 14:02:09',1,1,'209','2017-07-12 14:02:06'),('18ec282f-69c1-42bf-b7c3-40a570efc84b','停服公告','西永嘉你故意暗杀啊','2017-07-12 13:54:07','2017-07-12 13:56:09',1,3,'209','2017-07-12 13:54:19'),('1a4f3bdc-10dd-4440-b896-e3709dce3ad4','停服公告','系统将于2点停服','2017-07-12 13:50:06','2017-07-12 13:52:13',1,3,'209','2017-07-12 13:50:29'),('20dfc9dd-a86e-4cf4-9f64-99f2207276b0','停服公告','服务器将于本日下午5点停服','2017-07-08 16:16:06','2017-07-08 16:18:07',1,3,'209','2017-07-08 16:16:20'),('26fc538e-d235-4000-a68d-771c89898f22','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:13:24','2017-07-12 14:15:09',1,3,'209','2017-07-12 14:13:37'),('29c06b5b-0158-4d33-9814-229515894c45','测试公告','测试界面的样子','2017-07-10 10:55:32','2017-07-10 10:57:33',1,3,'209','2017-07-10 10:55:49'),('4d6dfb4b-d5d0-461c-8f06-ab35b2ca8ed5','测试公告','测试系统的稳定性','2017-07-10 11:00:39','2017-07-10 11:02:42',1,3,'209','2017-07-10 11:01:28'),('4eab6c82-5769-44f4-bc27-f721ddc54203','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:11:24','2017-07-12 14:13:09',1,3,'209','2017-07-12 14:11:18'),('504ff0e7-48fa-4376-8814-e5ed5dad8b9f','停服更新公告','服务器将于5分钟后停服','2017-07-08 13:58:07','2017-07-08 14:00:08',1,3,'209','2017-07-08 13:58:42'),('51dbd1b8-ab58-4d41-8d12-611ba8828f24','停服公告','服务器将于5分钟过后停服更新','2017-07-08 13:42:36','2017-07-08 13:44:40',1,0,'209','2017-07-08 13:55:58'),('67ed23fc-8314-4018-a83d-fcb2ea3724f3','停服公告','服务器将于5分中后停服','2017-07-08 13:38:47','2017-07-08 13:39:03',1,0,'209','2017-07-08 13:39:26'),('693562e5-b8d0-4677-9efa-3f7ea24d51a2','测试公告','测试测试测试123123','2017-07-08 20:28:40','2017-07-08 20:40:44',1,12,'209,208','2017-07-08 20:30:31'),('74fad9bf-34fc-4978-9d19-795373b70d70','停服公告','服务器将于5分钟过后停服更新','2017-07-08 13:42:36','2017-07-08 13:44:40',1,3,'209','2017-07-08 13:42:56'),('7504ef97-9c4d-4f8b-ba42-d6855ec7792c','测试公告','测试测试测试123123111111111111111111111111111111111111111111111111111111111','2017-07-08 21:29:08','2017-07-08 21:50:13',1,19,'209','2017-07-08 21:32:51'),('7567f278-8a2c-4af5-b3e2-9f4d98361654','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:08:24','2017-07-12 14:10:09',1,2,'209','2017-07-12 14:10:04'),('7e95e047-25d9-45c6-a62c-38e7443fb118','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:00:24','2017-07-12 14:02:09',1,3,'209','2017-07-12 14:00:54'),('8490ebd8-2b9e-4e5e-bf36-0edbcc831f6d','test','test','2017-08-08 11:25:37','2017-08-08 12:25:39',1,59,'143,209','2017-08-08 11:27:43'),('8ab983a3-fc93-404c-a04f-33f40a1309f5','停服公告','服务器将于下午2点停服','2017-07-12 13:43:01','2017-07-12 13:45:03',1,3,'209','2017-07-12 13:43:54'),('8f6c55c8-1cb7-4829-8e94-da556d744d59','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:08:24','2017-07-12 14:10:09',1,3,'209','2017-07-12 14:08:36'),('94808904-24bf-447b-bf36-7d3db66b7e9b','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:11:24','2017-07-12 14:13:09',1,2,'209','2017-07-12 14:12:49'),('9dfbd300-a3ed-4c4c-a3db-ef7cf03e56d9','停服公告','服务器将于5分钟后停服','2017-07-10 14:32:49','2017-07-10 14:34:50',5,2,'209','2017-07-10 14:33:02'),('d5773643-70cd-4d03-b304-486ae1735fe1','停服公告','服务器将于5分中后停服','2017-07-08 13:38:47','2017-07-08 13:39:03',1,0,'209','2017-07-08 13:40:23'),('f0f9fcd3-f566-4a93-a194-8ea4a190ccf0','停服公告','西永嘉你故意暗杀啊','2017-07-12 13:54:07','2017-07-12 13:56:09',1,0,'209','2017-07-12 13:56:21'),('f4ec3453-e9f7-4e9f-af88-6e8ff16ec291','停服公告','西永嘉你故意暗杀啊','2017-07-12 13:58:22','2017-07-12 14:00:09',1,2,'209','2017-07-12 13:59:08'),('f6cbea13-5534-416c-9fa9-1d56279e4405','测试公告','测试系统的稳定性','2017-07-10 11:00:39','2017-07-10 11:02:42',1,3,'209','2017-07-10 11:00:58'),('f80837f7-bab9-4087-91a0-0842b30b3efa','停服公告','西永嘉你故意暗杀啊','2017-07-12 14:13:24','2017-07-12 14:15:09',1,0,'209','2017-07-12 14:15:42'),('fa278422-17cb-41c9-873c-a3f258aba115','停服公告','服务器将于5分钟过后停服更新','2017-07-08 13:42:36','2017-07-08 13:44:40',1,3,'209','2017-07-08 13:43:35');

/*Table structure for table `t_server` */

DROP TABLE IF EXISTS `t_server`;

CREATE TABLE `t_server` (
  `F_ID` int(11) unsigned NOT NULL,
  `F_Server_ID` int(11) unsigned NOT NULL DEFAULT '0',
  `F_Name` varchar(50) NOT NULL,
  `F_IP` char(15) DEFAULT NULL,
  `F_Port` int(5) NOT NULL DEFAULT '10000',
  `F_Area_Id` int(11) unsigned NOT NULL DEFAULT '0',
  `F_Open_Date` datetime DEFAULT NULL COMMENT '开发时间',
  `F_New` tinyint(4) DEFAULT NULL,
  `F_Hot` tinyint(4) DEFAULT NULL,
  `F_Recommend` tinyint(4) DEFAULT NULL,
  `F_OlLimit` int(11) DEFAULT NULL,
  `F_Show` int(11) DEFAULT NULL,
  `F_Desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`F_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

/*Data for the table `t_server` */

insert  into `t_server`(`F_ID`,`F_Server_ID`,`F_Name`,`F_IP`,`F_Port`,`F_Area_Id`,`F_Open_Date`,`F_New`,`F_Hot`,`F_Recommend`,`F_OlLimit`,`F_Show`,`F_Desc`) values (1,0,'服务器',NULL,0,0,'2017-04-05 15:55:22',1,0,0,1000,2,'第一大区'),(2,0,'策划',NULL,0,0,'2017-04-05 00:00:00',0,0,0,1000,2,'第二大区'),(3,0,'测试区',NULL,0,0,'2017-06-19 11:51:27',0,0,0,1000,2,'第三大区'),(85,0,'策划服','192.168.102.85',3015,2,'2017-10-09 14:50:56',0,0,0,1000,2,NULL),(86,0,'陈勇钢','192.168.101.86',3015,2,NULL,0,0,0,1000,2,NULL),(87,0,'内网测试服','192.168.102.87',3015,3,'2017-10-09 14:13:27',0,0,0,1000,2,NULL),(91,0,'周兴','192.168.101.91',3015,2,NULL,0,0,0,1000,2,NULL),(128,0,'王方月','192.168.101.132',3015,1,'2017-10-09 14:50:47',0,0,0,1000,2,NULL),(212,0,'李玥','192.168.102.212',3015,1,'2017-10-09 14:50:32',0,0,0,1000,2,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
