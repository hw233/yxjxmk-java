/*
SQLyog Trial v9.30 
MySQL - 5.5.20 : Database - querydb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`querydb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `querydb`;

/*Table structure for table `order_info` */

DROP TABLE IF EXISTS `order_info`;

CREATE TABLE `order_info` (
  `F_OrderID` varchar(50) NOT NULL,
  `F_AppId` int(11) DEFAULT NULL,
  `F_UserName` varchar(50) DEFAULT NULL,
  `F_CreatTime` varchar(50) DEFAULT NULL,
  `F_Money` varchar(50) DEFAULT NULL,
  `F_PaymentChanelID` int(11) DEFAULT NULL,
  `F_CopChannel` int(11) DEFAULT NULL,
  `F_Serverid` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`F_OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
