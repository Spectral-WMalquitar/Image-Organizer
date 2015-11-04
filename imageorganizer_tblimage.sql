CREATE DATABASE  IF NOT EXISTS `imageorganizer` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `imageorganizer`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: imageorganizer
-- ------------------------------------------------------
-- Server version	5.7.5-m15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblimage`
--

DROP TABLE IF EXISTS `tblimage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblimage` (
  `ImageID` int(11) NOT NULL AUTO_INCREMENT,
  `AlbumsID` int(11) NOT NULL,
  `ImageName` varchar(255) DEFAULT NULL,
  `ImagePath` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ImageID`,`AlbumsID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblimage`
--

LOCK TABLES `tblimage` WRITE;
/*!40000 ALTER TABLE `tblimage` DISABLE KEYS */;
INSERT INTO `tblimage` VALUES (1,0,'IMG01548.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01548.jpg'),(2,0,'IMG01549.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01549.jpg'),(3,0,'IMG01550.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01550.jpg'),(4,0,'IMG01551.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01551.jpg'),(5,1,'IMG01544.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01544.jpg'),(6,1,'asd.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\asd.jpg'),(7,2,'Photo0196.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\Photo0196.jpg'),(8,1,'Photo0221.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\Photo0221.jpg'),(9,2,'IMG_20150620_124655.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG_20150620_124655.jpg'),(10,2,'Photo0234.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\Photo0234.jpg'),(11,3,'IMG01549.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01549.jpg'),(12,2,'IMG01549.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01549.jpg'),(13,2,'IMG01550.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01550.jpg'),(14,2,'IMG01551.jpg','C:\\Users\\Mendoza\\Desktop\\virus\\IMG01551.jpg');
/*!40000 ALTER TABLE `tblimage` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-10-17 18:20:16
