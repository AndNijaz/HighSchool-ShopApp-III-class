/*
Navicat MySQL Data Transfer

Source Server         : Vjezbanje
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projekat

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-28 22:33:25
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_id` int(11) NOT NULL auto_increment,
  `naziv_artikla` varchar(255) collate utf8_unicode_ci default NULL,
  `vrsta_artikla` varchar(255) collate utf8_unicode_ci default NULL,
  `cijena` double default NULL,
  PRIMARY KEY  (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of artikal
-- ----------------------------

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_id` int(11) NOT NULL auto_increment,
  `ime` varchar(255) collate utf8_unicode_ci default NULL,
  `prezime` varchar(255) collate utf8_unicode_ci default NULL,
  `grad` varchar(255) collate utf8_unicode_ci default NULL,
  `adresa` varchar(255) collate utf8_unicode_ci default NULL,
  `telefon` varchar(255) collate utf8_unicode_ci default NULL,
  `user` varchar(255) collate utf8_unicode_ci default NULL,
  `pass` varchar(255) collate utf8_unicode_ci default NULL,
  PRIMARY KEY  (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of kupac
-- ----------------------------

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int(11) NOT NULL auto_increment,
  `kupac_id` int(11) default NULL,
  `datum_narudzbe` date default NULL,
  `state` int(11) NOT NULL,
  PRIMARY KEY  (`narudzbenica_id`),
  KEY `narudzbenica_kupac_id` USING BTREE (`kupac_id`),
  CONSTRAINT `narudzbenica_ibfk_1` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='InnoDB free: 3072 kB; (`kupac_id`) REFER `projekat/kupac`(`k';

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `id` int(11) NOT NULL auto_increment,
  `artikal_id` int(11) default NULL,
  `kolicina_stanje` int(11) default NULL,
  PRIMARY KEY  (`id`),
  KEY `skladiste_artikal_id` USING BTREE (`artikal_id`),
  CONSTRAINT `skladiste_ibfk_1` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal';

-- ----------------------------
-- Records of skladiste
-- ----------------------------

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int(11) NOT NULL auto_increment,
  `narudzbenica_id` int(11) default NULL,
  `artikal_id` int(11) default NULL,
  `kolicina` int(11) default NULL,
  PRIMARY KEY  (`stavka_id`),
  KEY `stavka_narudzbenice_narudzbenica_id` USING BTREE (`narudzbenica_id`),
  KEY `stavka_narudzbenice_artikal_id` USING BTREE (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_1` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_2` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal';

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
