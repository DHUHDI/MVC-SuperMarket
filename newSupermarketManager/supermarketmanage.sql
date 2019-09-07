/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : supermarketmanage

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2019-09-07 20:01:14
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tb_commodityinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_commodityinfo`;
CREATE TABLE `tb_commodityinfo` (
  `commodityId` varchar(15) NOT NULL,
  `commodityName` varchar(15) DEFAULT NULL,
  `businessName` varchar(15) NOT NULL,
  `costPrice` int(8) DEFAULT NULL,
  `unitPrice` int(8) DEFAULT NULL,
  `commodityNumber` int(8) DEFAULT NULL,
  `remarks` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`commodityId`),
  KEY `foreign_key_gonghuoID` (`businessName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_commodityinfo
-- ----------------------------
INSERT INTO `tb_commodityinfo` VALUES ('S1001', '女士长袜', '深海越洋公司', '5', '10', '100', '备货');
INSERT INTO `tb_commodityinfo` VALUES ('S1002', '男士长袜', '深海越洋公司', '5', '10', '100', null);

-- ----------------------------
-- Table structure for tb_purchase
-- ----------------------------
DROP TABLE IF EXISTS `tb_purchase`;
CREATE TABLE `tb_purchase` (
  `purchaseId` varchar(10) NOT NULL,
  `commodityName` varchar(15) NOT NULL,
  `purchaseNumber` int(4) DEFAULT NULL,
  `costPrice` int(4) DEFAULT NULL,
  `total` int(4) DEFAULT NULL,
  `purchaseDate` varchar(20) DEFAULT NULL,
  `handler` varchar(10) DEFAULT NULL,
  `purchaseStatus` char(8) DEFAULT NULL,
  PRIMARY KEY (`purchaseId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_purchase
-- ----------------------------
INSERT INTO `tb_purchase` VALUES ('J1001', '女士长袜', '100', '5', '500', '2019年7月30日', '张诗文', '完成');
INSERT INTO `tb_purchase` VALUES ('J1002', '女士长袜', '100', '5', '500', '2019年7月30日', '张诗文', '完成');
INSERT INTO `tb_purchase` VALUES ('J1003', '男士长袜', '1000', '5', '500', '2019年7月30日', '张诗文', '完成');

-- ----------------------------
-- Table structure for tb_sale
-- ----------------------------
DROP TABLE IF EXISTS `tb_sale`;
CREATE TABLE `tb_sale` (
  `saleId` varchar(15) NOT NULL,
  `commodityName` varchar(15) NOT NULL,
  `saleDate` varchar(20) DEFAULT NULL,
  `saleNumber` int(4) DEFAULT NULL,
  `payMethod` varchar(25) DEFAULT NULL,
  `workerName` varchar(8) DEFAULT NULL,
  `Gonghao` varchar(10) NOT NULL,
  KEY `foreign_key_shangpinID` (`commodityName`),
  KEY `foreign_key_gonghao` (`workerName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_sale
-- ----------------------------
INSERT INTO `tb_sale` VALUES (' X1001', '女士长袜', '2016年10月20日', '50', '微信支付', '张诗文', 'S1001');
INSERT INTO `tb_sale` VALUES ('X1002', '女士长袜', '2016年10月22日', '50', '支付宝', '张诗文', 'S1001');
INSERT INTO `tb_sale` VALUES ('X1005', '男士长袜', '2019年9月3日', '100', '支付宝', 'zsusnv', '');

-- ----------------------------
-- Table structure for tb_supplier
-- ----------------------------
DROP TABLE IF EXISTS `tb_supplier`;
CREATE TABLE `tb_supplier` (
  `supplierId` varchar(15) NOT NULL,
  `businessName` varchar(15) DEFAULT NULL,
  `contacts` varchar(11) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  `address` varchar(15) DEFAULT NULL,
  `settlementMethod` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`supplierId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_supplier
-- ----------------------------
INSERT INTO `tb_supplier` VALUES ('G1001', '深海越洋公司', '秦悦', '15693955696', '中国青岛', '支付宝');

-- ----------------------------
-- Table structure for tb_zhigong
-- ----------------------------
DROP TABLE IF EXISTS `tb_zhigong`;
CREATE TABLE `tb_zhigong` (
  `Gonghao` varchar(8) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Name` varchar(10) DEFAULT NULL,
  `Shenfenzhenghao` varchar(25) DEFAULT NULL,
  `Sex` char(8) DEFAULT NULL,
  `Address` varchar(25) DEFAULT NULL,
  `Gongzuodanwei` varchar(10) NOT NULL,
  `Phone` varchar(11) DEFAULT NULL,
  `Ruyongriqi` varchar(20) DEFAULT NULL,
  `Birth` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Gonghao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_zhigong
-- ----------------------------
INSERT INTO `tb_zhigong` VALUES ('j1001', '123', '武宏霞', '230123199805011107', '女', '黑龙江哈尔滨市', '进货管理', '13210383253', '2018年12月5日', '1998年5月4日');
INSERT INTO `tb_zhigong` VALUES ('k1001', '123', '张诗文', '', '', '', '库存管理', '', '2018年12月24日', '2018年12月24日');
INSERT INTO `tb_zhigong` VALUES ('r1001', '123', '吴越', '', '男', '', '人事管理', '', '2018年12月24日', '2018年12月24日');
INSERT INTO `tb_zhigong` VALUES ('r1002', '123', 'zsw', '3123123', '女', '黑龙江', '人事管理', '231414', '2019年6月2日', '2019年6月2日');
INSERT INTO `tb_zhigong` VALUES ('S1000', '123', null, null, null, null, '销售员', null, null, null);
INSERT INTO `tb_zhigong` VALUES ('S185', '123', null, null, null, null, '销售员', null, null, null);
INSERT INTO `tb_zhigong` VALUES ('S560', '123', null, null, null, null, '销售员', null, null, null);
INSERT INTO `tb_zhigong` VALUES ('x1001', '123', '秦斌', '', '', '', '销售管理', '', '2018年12月24日', '2018年12月24日');
