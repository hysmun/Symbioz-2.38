/*
Navicat MySQL Data Transfer

Source Server         : Local
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : symbioz_auth

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2017-11-21 20:16:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for accounts
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Nickname` varchar(255) DEFAULT NULL,
  `Role` int(11) DEFAULT '1',
  `Banned` varchar(255) DEFAULT NULL,
  `CharacterSlots` int(11) DEFAULT NULL,
  `LastSelectedServerId` int(11) DEFAULT NULL,
  `Votes` int(11) DEFAULT '0',
  `Points` int(11) DEFAULT '0',
  `LastVoteDate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1425 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------

-- ----------------------------
-- Table structure for banips
-- ----------------------------
DROP TABLE IF EXISTS `banips`;
CREATE TABLE `banips` (
  `Ip` varchar(250) NOT NULL DEFAULT '',
  PRIMARY KEY (`Ip`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of banips
-- ----------------------------

-- ----------------------------
-- Table structure for cms_news
-- ----------------------------
DROP TABLE IF EXISTS `cms_news`;
CREATE TABLE `cms_news` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) NOT NULL DEFAULT 'NO TITLE',
  `Content` text,
  `Author` varchar(255) NOT NULL DEFAULT 'UNKNOWN',
  `Avatar` varchar(255) NOT NULL DEFAULT 'none.png',
  `Image` varchar(255) DEFAULT NULL,
  `date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=63 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cms_news
-- ----------------------------

-- ----------------------------
-- Table structure for cms_shop
-- ----------------------------
DROP TABLE IF EXISTS `cms_shop`;
CREATE TABLE `cms_shop` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Quantity` varchar(255) DEFAULT NULL,
  `GId` int(11) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `ImageName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cms_shop
-- ----------------------------

-- ----------------------------
-- Table structure for cms_votes
-- ----------------------------
DROP TABLE IF EXISTS `cms_votes`;
CREATE TABLE `cms_votes` (
  `Ip` varchar(255) DEFAULT NULL,
  `LastVoteTime` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cms_votes
-- ----------------------------

-- ----------------------------
-- Table structure for serverscharacters
-- ----------------------------
DROP TABLE IF EXISTS `serverscharacters`;
CREATE TABLE `serverscharacters` (
  `Id` int(11) NOT NULL DEFAULT '0',
  `CharacterId` int(11) DEFAULT NULL,
  `AccountId` int(11) DEFAULT NULL,
  `ServerId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of serverscharacters
-- ----------------------------

-- ----------------------------
-- Table structure for worldservers
-- ----------------------------
DROP TABLE IF EXISTS `worldservers`;
CREATE TABLE `worldservers` (
  `Id` int(11) NOT NULL DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Host` varchar(255) DEFAULT NULL,
  `Port` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of worldservers
-- ----------------------------
INSERT INTO `worldservers` VALUES ('22', 'Oto mustam', '0', '127.0.0.1', '5555');
