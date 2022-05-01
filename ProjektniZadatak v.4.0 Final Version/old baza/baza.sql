/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projekat

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-04 21:45:30
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
`artikal_id`  int(11) NOT NULL AUTO_INCREMENT ,
`naziv_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`vrsta_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`cijena`  double NULL DEFAULT NULL ,
PRIMARY KEY (`artikal_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=1 */

;

-- ----------------------------
-- Records of artikal
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
`kupac_id`  int(11) NOT NULL AUTO_INCREMENT ,
`ime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`prezime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`grad`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`adresa`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`telefon`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`user`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`pass`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
PRIMARY KEY (`kupac_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=1 */

;

-- ----------------------------
-- Records of kupac
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
`narudzbenica_id`  int(11) NOT NULL AUTO_INCREMENT ,
`kupac_id`  int(11) NULL DEFAULT NULL ,
`datum_narudzbe`  date NULL DEFAULT NULL ,
PRIMARY KEY (`narudzbenica_id`),
FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`kupac_id`) REFER `projekat/kupac`(`kupac_id`)'
/*!50003 AUTO_INCREMENT=1 */

;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
`id`  int(11) NOT NULL AUTO_INCREMENT ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina_stanje`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal`(`artikal_id`)'
/*!50003 AUTO_INCREMENT=1 */

;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
`stavka_id`  int(11) NOT NULL AUTO_INCREMENT ,
`narudzbenica_id`  int(11) NULL DEFAULT NULL ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`stavka_id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal`(`artikal_id`); (`n'
/*!50003 AUTO_INCREMENT=1 */

;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Auto increment value for `artikal`
-- ----------------------------
ALTER TABLE `artikal` AUTO_INCREMENT=1;

-- ----------------------------
-- Auto increment value for `kupac`
-- ----------------------------
ALTER TABLE `kupac` AUTO_INCREMENT=1;

-- ----------------------------
-- Indexes structure for table `narudzbenica`
-- ----------------------------
CREATE INDEX `narudzbenica_kupac_id` USING BTREE ON `narudzbenica`(`kupac_id`);

-- ----------------------------
-- Auto increment value for `narudzbenica`
-- ----------------------------
ALTER TABLE `narudzbenica` AUTO_INCREMENT=1;

-- ----------------------------
-- Indexes structure for table `skladiste`
-- ----------------------------
CREATE INDEX `skladiste_artikal_id` USING BTREE ON `skladiste`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `skladiste`
-- ----------------------------
ALTER TABLE `skladiste` AUTO_INCREMENT=1;

-- ----------------------------
-- Indexes structure for table `stavka_narudzbenice`
-- ----------------------------
CREATE INDEX `stavka_narudzbenice_narudzbenica_id` USING BTREE ON `stavka_narudzbenice`(`narudzbenica_id`);
CREATE INDEX `stavka_narudzbenice_artikal_id` USING BTREE ON `stavka_narudzbenice`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `stavka_narudzbenice`
-- ----------------------------
ALTER TABLE `stavka_narudzbenice` AUTO_INCREMENT=1;
