/*
SQLyog Trial v9.30 
MySQL - 5.5.20 : Database - paycenter
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`paycenter` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `paycenter`;

/*Table structure for table `app_lost_order` */

DROP TABLE IF EXISTS `app_lost_order`;

CREATE TABLE `app_lost_order` (
  `appid` varchar(50) NOT NULL,
  `roleid` varchar(50) DEFAULT NULL,
  `expand` varchar(50) DEFAULT NULL,
  `money` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `channel` varchar(50) DEFAULT NULL,
  `serverid` varchar(50) DEFAULT NULL,
  `DATA` blob,
  `orderid` varchar(50) DEFAULT NULL,
  `creattime` varchar(50) DEFAULT NULL,
  `state` int(11) DEFAULT NULL,
  PRIMARY KEY (`appid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `order_details` */

DROP TABLE IF EXISTS `order_details`;

CREATE TABLE `order_details` (
  `F_OrderID` varchar(50) NOT NULL,
  `F_OrderState` varchar(50) DEFAULT NULL,
  `F_PaymentID` varchar(50) DEFAULT NULL,
  `F_CopChannel` varchar(50) DEFAULT NULL,
  `F_AppID` varchar(50) DEFAULT NULL,
  `F_UserName` varchar(50) DEFAULT NULL,
  `F_RoleID` varchar(50) DEFAULT NULL,
  `F_ServerID` varchar(50) DEFAULT NULL,
  `F_Expand` varchar(512) DEFAULT NULL,
  `F_Currency` varchar(50) DEFAULT NULL,
  `F_CreateOrderReqMsg` varchar(255) DEFAULT NULL,
  `F_CreateOrderResponseMsg` varchar(255) DEFAULT NULL,
  `F_CreateOrderErrMsg` varchar(255) DEFAULT NULL,
  `F_SendMoney` varchar(50) DEFAULT NULL,
  `F_ReceiveState` varchar(50) DEFAULT NULL,
  `F_Money` varchar(50) DEFAULT NULL,
  `F_PayChannelOrderID` varchar(50) DEFAULT NULL,
  `F_ReceiveTime` varchar(50) DEFAULT NULL,
  `F_ReceiveReqMsg` varchar(1000) DEFAULT NULL,
  `F_ReceiveResponseMsg` varchar(255) DEFAULT NULL,
  `F_ReceiveErrMsg` varchar(255) DEFAULT NULL,
  `F_NotifyState` varchar(50) DEFAULT NULL,
  `F_CompeletedTime` varchar(50) DEFAULT NULL,
  `F_NotifyReqMsg` varchar(512) DEFAULT NULL,
  `F_NotifyResponseMsg` varchar(255) DEFAULT NULL,
  `F_NotifyErrMsg` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`F_OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `order_info` */

DROP TABLE IF EXISTS `order_info`;

CREATE TABLE `order_info` (
  `F_OrderID` varchar(255) NOT NULL,
  `F_UserName` varchar(50) DEFAULT NULL,
  `F_Money` double DEFAULT NULL,
  `F_SendMoney` double DEFAULT NULL,
  `F_AppId` varchar(50) DEFAULT NULL,
  `F_PayType` int(11) DEFAULT NULL,
  `F_CopChannel` int(11) DEFAULT NULL,
  `F_PaymentChanelID` int(11) DEFAULT NULL,
  `F_PayChannelOrderID` varchar(50) DEFAULT NULL,
  `F_OrderMsg` varchar(50) DEFAULT NULL,
  `F_Serverid` varchar(50) DEFAULT NULL,
  `F_SysType` int(11) DEFAULT NULL,
  `F_CreatTime` varchar(50) DEFAULT NULL,
  `F_RoleId` varchar(50) DEFAULT NULL,
  `F_Expand` varchar(512) DEFAULT NULL,
  `F_OrderProccStep` int(11) DEFAULT NULL,
  `F_OrderState` int(11) DEFAULT NULL,
  `F_ReceiveTime` varchar(50) DEFAULT NULL,
  `F_CompeletedTime` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`F_OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
