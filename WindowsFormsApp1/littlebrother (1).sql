-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 09, 2021 at 10:19 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `littlebrother`
--

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `fName` varchar(20) NOT NULL,
  `sName` varchar(20) NOT NULL,
  `tName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`id`, `fName`, `sName`, `tName`) VALUES
(1, 'Вася', 'Пупкин', 'Иванович'),
(2, 'Иван', 'Иванов', 'Иванович');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `room` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`id`, `room`) VALUES
(1, 'Цех 1'),
(2, '[ВНЕ РАБОЧЕЙ ЗОНЫ]'),
(3, 'Сортировка');

-- --------------------------------------------------------

--
-- Table structure for table `st`
--

CREATE TABLE `st` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `member_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `st`
--

INSERT INTO `st` (`id`, `member_id`, `room_id`, `date`, `time_in`, `time_out`) VALUES
(1, 1, 2, '2021-03-09', '21:20:40', '21:36:03'),
(2, 1, 1, '2021-03-09', '21:36:03', '21:43:18'),
(3, 1, 2, '2021-03-09', '21:43:18', '21:48:42'),
(4, 1, 1, '2021-03-09', '21:48:42', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `statistic`
--

CREATE TABLE `statistic` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `member_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `dateTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `statistic`
--

INSERT INTO `statistic` (`id`, `member_id`, `room_id`, `dateTime`) VALUES
(1, 1, 2, '2021-03-08 16:06:20'),
(2, 3, 1, '2021-03-08 16:07:20'),
(3, 2, 2, '2021-03-08 16:32:34'),
(4, 1, 1, '2021-03-08 23:56:34'),
(5, 1, 1, '2021-03-09 00:13:35'),
(6, 1, 2, '2021-03-09 00:21:52'),
(7, 2, 1, '2021-03-09 00:24:30');

-- --------------------------------------------------------

--
-- Table structure for table `userpasswords`
--

CREATE TABLE `userpasswords` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `userpasswords`
--

INSERT INTO `userpasswords` (`id`, `password`) VALUES
(1, 'Testpassword123'),
(2, 'Testpassword2');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `login` varchar(60) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `login`, `password`) VALUES
(1, 'test', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `st`
--
ALTER TABLE `st`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `statistic`
--
ALTER TABLE `statistic`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `userpasswords`
--
ALTER TABLE `userpasswords`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `rooms`
--
ALTER TABLE `rooms`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `st`
--
ALTER TABLE `st`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `statistic`
--
ALTER TABLE `statistic`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `userpasswords`
--
ALTER TABLE `userpasswords`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
