-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 30, 2021 at 04:56 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fmsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
CREATE TABLE IF NOT EXISTS `driver` (
  `nic` varchar(12) NOT NULL,
  `fname` varchar(25) NOT NULL,
  `lname` varchar(25) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `contact_no` char(10) NOT NULL,
  `address` varchar(150) NOT NULL,
  PRIMARY KEY (`nic`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `driver`
--

INSERT INTO `driver` (`nic`, `fname`, `lname`, `full_name`, `email`, `contact_no`, `address`) VALUES
('1', 'lasith', 'eranda', 'lasith eranda', 'lasith@fmail.com', '0770543255', 'skndkjnsd');

-- --------------------------------------------------------

--
-- Table structure for table `fine_receipt`
--

DROP TABLE IF EXISTS `fine_receipt`;
CREATE TABLE IF NOT EXISTS `fine_receipt` (
  `Ref_No` bigint(20) NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Amount` mediumint(9) NOT NULL,
  `State` tinyint(4) NOT NULL,
  `driver_nic` varchar(12) NOT NULL,
  `officer_id` smallint(5) NOT NULL,
  PRIMARY KEY (`Ref_No`),
  KEY `driver_nic` (`driver_nic`),
  KEY `officer_id` (`officer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fine_receipt`
--

INSERT INTO `fine_receipt` (`Ref_No`, `Date`, `Amount`, `State`, `driver_nic`, `officer_id`) VALUES
(2, '2021-07-30', 200, 3, '1', 2);

-- --------------------------------------------------------

--
-- Table structure for table `license`
--

DROP TABLE IF EXISTS `license`;
CREATE TABLE IF NOT EXISTS `license` (
  `id` char(8) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE IF NOT EXISTS `payment` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `amount` mediumint(9) NOT NULL,
  `driver_nic` varchar(12) NOT NULL,
  `fince_receipt_Ref` bigint(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `driver_nic` (`driver_nic`),
  KEY `fince_receipt_Ref` (`fince_receipt_Ref`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`id`, `date`, `amount`, `driver_nic`, `fince_receipt_Ref`) VALUES
(1, '2021-07-30', 1200, '1', 2);

-- --------------------------------------------------------

--
-- Table structure for table `police_station`
--

DROP TABLE IF EXISTS `police_station`;
CREATE TABLE IF NOT EXISTS `police_station` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `address` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `rule`
--

DROP TABLE IF EXISTS `rule`;
CREATE TABLE IF NOT EXISTS `rule` (
  `rule_id` int(11) NOT NULL,
  `rule_name` varchar(100) NOT NULL,
  `penalty_amount` mediumint(9) NOT NULL,
  `description` varchar(200) NOT NULL,
  PRIMARY KEY (`rule_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `rules_broken`
--

DROP TABLE IF EXISTS `rules_broken`;
CREATE TABLE IF NOT EXISTS `rules_broken` (
  `fine_receipt_id` bigint(20) NOT NULL,
  `rule_id` int(11) NOT NULL,
  PRIMARY KEY (`fine_receipt_id`,`rule_id`),
  KEY `rule_id` (`rule_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `traffic_police_officer`
--

DROP TABLE IF EXISTS `traffic_police_officer`;
CREATE TABLE IF NOT EXISTS `traffic_police_officer` (
  `police_id` smallint(5) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nic` varchar(12) NOT NULL,
  `contact_no` char(10) NOT NULL,
  `post` varchar(50) NOT NULL,
  `address` varchar(150) NOT NULL,
  PRIMARY KEY (`police_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `traffic_police_officer`
--

INSERT INTO `traffic_police_officer` (`police_id`, `fname`, `lname`, `full_name`, `email`, `nic`, `contact_no`, `post`, `address`) VALUES
(2, 'fname', 'lname', 'full name', 'email', '0770325244', '0770325244', 'sfnjksdnbj', 'kjnvsdjkvn');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `user_name`, `password`) VALUES
(1, 'lasith', '13926153831969718150168391712481961204215');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `fine_receipt`
--
ALTER TABLE `fine_receipt`
  ADD CONSTRAINT `fine_receipt_ibfk_1` FOREIGN KEY (`driver_nic`) REFERENCES `driver` (`nic`),
  ADD CONSTRAINT `fine_receipt_ibfk_2` FOREIGN KEY (`officer_id`) REFERENCES `traffic_police_officer` (`police_id`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`driver_nic`) REFERENCES `driver` (`nic`),
  ADD CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`fince_receipt_Ref`) REFERENCES `fine_receipt` (`Ref_No`);

--
-- Constraints for table `rules_broken`
--
ALTER TABLE `rules_broken`
  ADD CONSTRAINT `rules_broken_ibfk_2` FOREIGN KEY (`rule_id`) REFERENCES `rule` (`rule_id`),
  ADD CONSTRAINT `rules_broken_ibfk_3` FOREIGN KEY (`fine_receipt_id`) REFERENCES `fine_receipt` (`Ref_No`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
