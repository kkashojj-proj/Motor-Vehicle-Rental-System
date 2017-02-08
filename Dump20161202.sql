-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: mvrs_db
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
-- Table structure for table `carddetails`
--

DROP TABLE IF EXISTS `carddetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carddetails` (
  `card_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `card_no` varchar(25) NOT NULL,
  `name_on_card` varchar(45) NOT NULL,
  `expiry_date` date NOT NULL,
  `cvv` int(11) NOT NULL,
  `address_line_1` varchar(45) NOT NULL,
  `address_line_2` varchar(45) NOT NULL,
  `zipcode_cd` varchar(45) NOT NULL,
  PRIMARY KEY (`card_id`),
  KEY `user_id_card_idx` (`user_id`),
  KEY `zipcode_idx` (`zipcode_cd`),
  CONSTRAINT `user_id_card` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `zipcode_cd` FOREIGN KEY (`zipcode_cd`) REFERENCES `zipcodes` (`zipcode`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carddetails`
--

LOCK TABLES `carddetails` WRITE;
/*!40000 ALTER TABLE `carddetails` DISABLE KEYS */;
INSERT INTO `carddetails` VALUES (1,14,'5555666633332222','Ashwini','2018-11-20',123,'9555 Apt J','UT drive','28262'),(6,12,'2255664477889988','Ashwin','2018-01-04',444,'10001 J','Graduate Lane','28262');
/*!40000 ALTER TABLE `carddetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discountdetails`
--

DROP TABLE IF EXISTS `discountdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `discountdetails` (
  `promo_code` varchar(15) NOT NULL,
  `description` varchar(50) DEFAULT NULL,
  `discount_percentage` int(5) DEFAULT NULL,
  PRIMARY KEY (`promo_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discountdetails`
--

LOCK TABLES `discountdetails` WRITE;
/*!40000 ALTER TABLE `discountdetails` DISABLE KEYS */;
INSERT INTO `discountdetails` VALUES ('CHRISTMAS10','Christmas 10% offer',10),('July25','July $25.00 discount',5),('LaborDay5','Labor Day $5.00 offer',5),('NewYear10','New Year 10% offer',10),('NOPROMO','No promotion code',0);
/*!40000 ALTER TABLE `discountdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insurance`
--

DROP TABLE IF EXISTS `insurance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `insurance` (
  `insurance_type` varchar(15) NOT NULL,
  `bodily_coverage` float(8,2) NOT NULL,
  `medical_coverage` float(8,2) NOT NULL,
  `collision_coverage` float(8,2) NOT NULL,
  `insurance_price` float(8,2) NOT NULL,
  PRIMARY KEY (`insurance_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insurance`
--

LOCK TABLES `insurance` WRITE;
/*!40000 ALTER TABLE `insurance` DISABLE KEYS */;
INSERT INTO `insurance` VALUES ('Comprehensive',50000.00,50000.00,50000.00,19.99),('Liability',25000.00,50000.00,0.00,9.99);
/*!40000 ALTER TABLE `insurance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pickuplocation`
--

DROP TABLE IF EXISTS `pickuplocation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pickuplocation` (
  `location_id` varchar(45) NOT NULL,
  `address_line_1` varchar(45) NOT NULL,
  `address_line_2` varchar(45) DEFAULT NULL,
  `zipcode` varchar(45) NOT NULL,
  `phone_number` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  PRIMARY KEY (`location_id`),
  KEY `zipcode_idx` (`zipcode`),
  CONSTRAINT `zipcode_pl` FOREIGN KEY (`zipcode`) REFERENCES `zipcodes` (`zipcode`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pickuplocation`
--

LOCK TABLES `pickuplocation` WRITE;
/*!40000 ALTER TABLE `pickuplocation` DISABLE KEYS */;
INSERT INTO `pickuplocation` VALUES ('ashford','10001 J','Lane 3, Ashford','28262','4443332222','def@email.com'),('graduatelane','300G','Graduate lane road','28262','8976567890','abc@email.com'),('utd','9555','University terrace drive','28262','6478398888','xyz@email.com'),('utn','9666','University terrace north','28262','6667778888','ghi@email.com');
/*!40000 ALTER TABLE `pickuplocation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservation` (
  `reservation_id` int(11) NOT NULL AUTO_INCREMENT,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `rental_amount` int(11) NOT NULL,
  `deposit_amount` int(11) NOT NULL,
  `total_amount_paid` float(8,2) DEFAULT NULL,
  `vehicle_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `insurance_amount` float(8,2) NOT NULL DEFAULT '0.00',
  `promo_code` varchar(15) DEFAULT NULL,
  `insurance_type` varchar(15) NOT NULL,
  PRIMARY KEY (`start_date`,`end_date`,`vehicle_id`),
  UNIQUE KEY `reservation_id_UNIQUE` (`reservation_id`),
  KEY `user_id_idx` (`user_id`),
  KEY `vehicle_id_idx` (`vehicle_id`),
  KEY `discount_price_idx_idx` (`promo_code`),
  KEY `insurance_type_idx` (`insurance_type`),
  CONSTRAINT `insurance_type` FOREIGN KEY (`insurance_type`) REFERENCES `insurance` (`insurance_type`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `promo_code` FOREIGN KEY (`promo_code`) REFERENCES `discountdetails` (`promo_code`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user_id_reser` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `vehicle_id` FOREIGN KEY (`vehicle_id`) REFERENCES `vehicledetails` (`vehicle_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` VALUES (19,'2016-11-20','2016-11-20',15,500,2000.00,21,12,0.00,'NOPROMO','Liability'),(13,'2016-11-20','2016-11-24',22,500,2739.96,12,12,39.96,'NOPROMO','Liability'),(17,'2016-11-20','2016-11-24',150,500,15539.96,21,14,39.96,'NOPROMO','Liability'),(16,'2016-11-20','2016-11-30',222,500,22799.90,12,14,99.90,'NOPROMO','Liability'),(20,'2016-11-21','2016-11-21',15,500,1850.00,21,12,0.00,'CHRISTMAS10','Liability'),(14,'2016-11-21','2016-11-23',222,500,22739.98,16,14,39.98,'NOPROMO','Comprehensive'),(15,'2016-11-24','2016-11-26',222,500,20519.98,18,14,39.98,'CHRISTMAS10','Comprehensive'),(21,'2016-11-25','2016-11-26',22,500,2719.99,12,14,19.99,'NOPROMO','Comprehensive'),(22,'2016-11-27','2016-11-28',22,500,2499.99,12,14,19.99,'CHRISTMAS10','Comprehensive'),(23,'2016-12-20','2016-12-21',22,500,2709.99,15,14,9.99,'NOPROMO','Liability');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER before_reservation_insert
    BEFORE INSERT ON reservation
    FOR EACH ROW 
BEGIN
	SET NEW.insurance_amount = GetInsuranceAmount(NEW.insurance_type, NEW.start_date, NEW.end_date),
		NEW.total_amount_paid = NEW.rental_amount * (100 - GetDiscountPercentage(NEW.promo_code)) + NEW.deposit_amount + NEW.insurance_amount;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(40) NOT NULL,
  `first_name` varchar(40) NOT NULL,
  `date_of_birth` date NOT NULL,
  `license_no` varchar(45) NOT NULL,
  `address_line_1` varchar(45) NOT NULL,
  `address_line_2` varchar(45) DEFAULT NULL,
  `zipcode` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `contact_num_1` varchar(20) NOT NULL,
  `contact_num_2` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  KEY `zip_code_idx` (`zipcode`),
  CONSTRAINT `zipcode` FOREIGN KEY (`zipcode`) REFERENCES `zipcodes` (`zipcode`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (12,'Prabhu','Ashwin','1990-11-20','N1234567','10001 graduate ln','UTN','28262','avenka11@uncc.edu','9802675731',''),(13,'Admin','Admin','9999-12-09','NA','UNCC',NULL,'28262','admin@uncc.edu','9999999999',NULL),(14,'Kadam','Ashwini','1990-11-06','N647567','9679G','','28262','akadam3@uncc.edu','8897767566','');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usercredentials`
--

DROP TABLE IF EXISTS `usercredentials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usercredentials` (
  `user_name` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `user_id` int(11) NOT NULL,
  `type_of_user` enum('admin','reg_user') NOT NULL,
  PRIMARY KEY (`user_name`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`),
  CONSTRAINT `user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usercredentials`
--

LOCK TABLES `usercredentials` WRITE;
/*!40000 ALTER TABLE `usercredentials` DISABLE KEYS */;
INSERT INTO `usercredentials` VALUES ('admin','12345',13,'admin'),('akadam3','12345',14,'reg_user'),('avenka11','12346',12,'reg_user');
/*!40000 ALTER TABLE `usercredentials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicledetails`
--

DROP TABLE IF EXISTS `vehicledetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicledetails` (
  `vehicle_id` int(11) NOT NULL AUTO_INCREMENT,
  `vehicle_number` varchar(10) NOT NULL,
  `model` varchar(10) NOT NULL,
  `year` int(5) NOT NULL,
  `color` varchar(45) NOT NULL,
  `seat_capacity` int(11) NOT NULL,
  `is_available` enum('yes','no') NOT NULL,
  `cost_per_day` int(11) NOT NULL,
  `cost_per_mile` int(11) NOT NULL,
  `category` varchar(50) NOT NULL,
  `conditioned` enum('ac','non-ac') NOT NULL,
  `location_id` varchar(45) NOT NULL,
  PRIMARY KEY (`vehicle_id`),
  KEY `location_id_idx` (`location_id`),
  CONSTRAINT `location_id_vd` FOREIGN KEY (`location_id`) REFERENCES `pickuplocation` (`location_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicledetails`
--

LOCK TABLES `vehicledetails` WRITE;
/*!40000 ALTER TABLE `vehicledetails` DISABLE KEYS */;
INSERT INTO `vehicledetails` VALUES (12,'N1234','Tata nano',2009,'black',4,'yes',22,22,'Four-wheeler','ac','graduatelane'),(15,'m25000','Tata nano',2009,'black',4,'yes',22,22,'Four-wheeler','ac','graduatelane'),(16,'U76588','Accord',2009,'black',4,'yes',20,22,'Four-wheeler','ac','graduatelane'),(18,'B263546','Elantra',2009,'black',4,'yes',25,22,'Four-wheeler','ac','graduatelane'),(19,'NC122','Mustang',2010,'Black',6,'yes',15,12,'Four-wheeler','ac','utn'),(21,'NC228','Mustang',2010,'Yellow',2,'yes',15,20,'Four-wheeler','ac','ashford'),(22,'NC154','Honda City',2012,'Red',4,'yes',20,12,'Four-wheeler','ac','utd'),(23,'NC1256','GMC',2010,'White',6,'yes',22,12,'Four-wheeler','ac','utd'),(24,'VA1542','Merc C-55',2015,'Brown',2,'yes',35,30,'Four-wheeler','ac','utd'),(25,'NC1259','Ferrari',2016,'Pink',2,'yes',50,30,'Four-wheeler','ac','ashford'),(26,'NC15425','Ninza',2009,'Blue',1,'yes',20,20,'Two-wheeler','ac','ashford'),(27,'NC14589','BMW',2010,'Black',1,'yes',30,12,'Two-wheeler','ac','ashford'),(28,'NC1024','R-1',2009,'Red',1,'yes',12,10,'Two-wheeler','ac','utn');
/*!40000 ALTER TABLE `vehicledetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zipcodes`
--

DROP TABLE IF EXISTS `zipcodes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zipcodes` (
  `zipcode` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `state` varchar(45) NOT NULL,
  PRIMARY KEY (`zipcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zipcodes`
--

LOCK TABLES `zipcodes` WRITE;
/*!40000 ALTER TABLE `zipcodes` DISABLE KEYS */;
INSERT INTO `zipcodes` VALUES ('28202','Raleigh','NC'),('28262','Charlotte','NC');
/*!40000 ALTER TABLE `zipcodes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mvrs_db'
--

--
-- Dumping routines for database 'mvrs_db'
--
/*!50003 DROP FUNCTION IF EXISTS `GetDiscountPercentage` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetDiscountPercentage`(promo VARCHAR(15)) RETURNS int(11)
BEGIN
	DECLARE discount INT(11);
    
    SELECT discount_percentage INTO discount FROM discountdetails WHERE promo_code = promo;
    IF discount = NULL 
    THEN SET discount = 0;
    END IF;
RETURN discount;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetInsuranceAmount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetInsuranceAmount`(insurancetype VARCHAR(15), startdate DATE, enddate DATE) RETURNS float(8,2)
BEGIN
	DECLARE insuranceamount FLOAT(8, 2);
    
	SELECT (insurance_price * datediff(enddate, startdate)) INTO insuranceamount
    FROM insurance
    WHERE insurance_type = insurancetype;
RETURN insuranceamount;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddVehicle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddVehicle`(IN vehiclenumber VARCHAR(10), IN mdl VARCHAR(10), 
							   IN yr INT(5), IN clr VARCHAR(45), IN seatcapacity INT(11),
							   IN isavailable ENUM('yes', 'no'), IN costperday INT(11),
							   IN costpermile INT(11), IN ctgry VARCHAR(50),
							   IN cndtnd ENUM('ac', 'non-ac'), IN locationid VARCHAR(45))
BEGIN
	INSERT INTO vehicledetails (vehicle_number, model, year, color, seat_capacity, 
								is_available, cost_per_day, cost_per_mile, category, conditioned, location_id)
	VALUES (vehiclenumber, mdl, yr, clr, seatcapacity, isavailable, costperday, costpermile, ctgry, cndtnd, locationid);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BookVehicle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BookVehicle`(IN startdate DATE, IN enddate DATE, IN rentalamount INT(11), IN depositamount INT(11),
								IN totalamountpaid INT(11), IN vehicleid INT(11), IN userid INT(11), IN promocode VARCHAR(15), IN insurancetype VARCHAR(15))
BEGIN
	INSERT INTO reservation (start_date, end_date, rental_amount, deposit_amount, total_amount_paid, vehicle_id, user_id, promo_code, insurance_type)
    VALUES (startdate, enddate, rentalamount, depositamount, totalamountpaid, vehicleid, userid, promocode, insurancetype);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletePromoCode` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePromoCode`(IN promocode VARCHAR(15))
BEGIN
	DELETE FROM discountdetails WHERE promo_code = promocode;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeleteVehicle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteVehicle`(IN vehicleid INT(11))
BEGIN
	DELETE FROM vehicledetails WHERE vehicle_id = vehicleid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LoginUser` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoginUser`(IN usrname VARCHAR(45), IN passwd VARCHAR(45))
BEGIN
	SELECT type_of_user FROM usercredentials where user_name like usrname and password like passwd;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateVehicle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateVehicle`(IN mdl VARCHAR(10), 
								  IN yr INT(5), IN clr VARCHAR(45), IN seatcapacity INT(11),
								  IN isavailable ENUM('yes', 'no'), IN costperday INT(11),
								  IN costpermile INT(11), IN ctgry VARCHAR(50),
                                  IN cndtnd ENUM('ac', 'non-ac'), IN vehclid INT(11), IN locationid VARCHAR(45))
BEGIN
	UPDATE vehicledetails SET
		model = mdl,
		year = yr,
		color = clr,
		seat_capacity = seatcapacity,
		is_available = isavailable,
		cost_per_day = costperday,
		cost_per_mile = costpermile,
		category = ctgry,
		conditioned = cndtnd,
        location_id = locationid
    WHERE vehicle_id = vehclid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ViewAvailableVehicles` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ViewAvailableVehicles`(IN locationid VARCHAR(45), IN startdate DATE, IN enddate DATE)
BEGIN
	IF locationid = "NOLOCATION" THEN
			SELECT DISTINCT model, seat_capacity, 
					cost_per_day, cost_per_mile, 
					category, conditioned, 
					location_id, vehicle_id FROM vehicledetails
					WHERE vehicle_id NOT IN (select vehicle_id from reservation where start_date = startdate AND end_date = enddate);
	ELSE
			SELECT DISTINCT model, seat_capacity, cost_per_day, cost_per_mile, category, 
					conditioned, location_id, vehicle_id 
                    FROM vehicledetails
                    WHERE location_id = locationid AND
                    vehicle_id NOT IN (select vehicle_id from reservation WHERE start_date = startdate AND end_date = enddate);
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ViewBookingHistory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ViewBookingHistory`(IN userid INT(11))
BEGIN
	SELECT start_date, end_date, total_amount_paid, vehicle_id
	FROM reservation WHERE user_id = userid ORDER BY start_date DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-02 16:39:21
