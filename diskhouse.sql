-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 10 Apr 2018 la 08:02
-- Versiune server: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `diskhouse`
--

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul `albums`
--

CREATE TABLE `albums` (
  `Id` int(10) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Year` year(4) NOT NULL,
  `Genre` varchar(15) NOT NULL,
  `Artist.Id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul `artists`
--

CREATE TABLE `artists` (
  `Id` int(10) NOT NULL,
  `Name` varchar(56) NOT NULL,
  `Description` text NOT NULL,
  `Members` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul `awards`
--

CREATE TABLE `awards` (
  `Id` int(10) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Album.Id` int(10) NOT NULL,
  `Year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul `songs`
--

CREATE TABLE `songs` (
  `Id` int(10) NOT NULL,
  `Album.Id` int(10) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Length` time(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul `users`
--

CREATE TABLE `users` (
  `Id` int(10) NOT NULL,
  `Name` varchar(56) NOT NULL,
  `Password` varchar(25) NOT NULL,
  `Rights` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `albums`
--
ALTER TABLE `albums`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `artistId` (`Artist.Id`);

--
-- Indexes for table `artists`
--
ALTER TABLE `artists`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `awards`
--
ALTER TABLE `awards`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Album.Id` (`Album.Id`);

--
-- Indexes for table `songs`
--
ALTER TABLE `songs`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Album.Id` (`Album.Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `albums`
--
ALTER TABLE `albums`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;


-- AUTO_INCREMENT for table `artists`
--
ALTER TABLE `artists`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `songs`
--
ALTER TABLE `songs`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;

--
-- Restrictii pentru tabele sterse
--

--
-- Restrictii pentru tabele `albums`
--
ALTER TABLE `albums`
  ADD CONSTRAINT `albums_ibfk_1` FOREIGN KEY (`Artist.Id`) REFERENCES `artists` (`Id`) ON UPDATE CASCADE;

--
-- Restrictii pentru tabele `artists`
--
ALTER TABLE `artists`
  ADD CONSTRAINT `artists_ibfk_1` FOREIGN KEY (`Id`) REFERENCES `users` (`Id`) ON UPDATE CASCADE;

--
-- Restrictii pentru tabele `awards`
--
ALTER TABLE `awards`
  ADD CONSTRAINT `awards_ibfk_1` FOREIGN KEY (`Album.Id`) REFERENCES `albums` (`Id`) ON UPDATE CASCADE;

--
-- Restrictii pentru tabele `songs`
--
ALTER TABLE `songs`
  ADD CONSTRAINT `songs_ibfk_1` FOREIGN KEY (`Album.Id`) REFERENCES `albums` (`Id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
