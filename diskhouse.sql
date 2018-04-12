-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 10 Apr 2018 la 08:02
-- Versiune server: 10.1.31-MariaDB
-- PHP Version: 7.2.3

/*SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";*/


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: "diskhouse"
--

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "albums"
--

CREATE TABLE "Albums" (
  "Id" nchar(10) NOT NULL,
  "Name" varchar(50) NOT NULL,
  "Year" date NOT NULL,
  "Genre" varchar(15) NOT NULL,
  "Artist.Id" nchar(10) NOT NULL
  PRIMARY KEY (Id)
) 

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "artists"
--

CREATE TABLE "artists" (
  "Id" nchar(10) NOT NULL,
  "Name" varchar(56) NOT NULL,
  "Description" text NOT NULL,
  "Members" varchar(100) NOT NULL
  PRIMARY KEY (Id)
) 

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "awards"
--

CREATE TABLE "awards" (
  "Id" nchar(10) NOT NULL ,
  "Name" varchar(50) NOT NULL,
  "Album.Id" nchar(10) NOT NULL,
  "Year" date NOT NULL
  PRIMARY KEY(Id)
)

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "songs"
--

CREATE TABLE "songs" (
  "Id" nchar(10) NOT NULL,
  "Album.Id" nchar(10) NOT NULL,
  "Name" varchar(50) NOT NULL,
  "Length" time(5) NOT NULL
  PRIMARY KEY(Id)
) 
-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "users"
--

CREATE TABLE "users" (
  "Id" nchar(10) NOT NULL,
  "Name" varchar(56) NOT NULL,
  "Password" varchar(25) NOT NULL,
  "Rights" nchar(1) NOT NULL
  PRIMARY KEY(Id)
) 
--
-- Restrictii pentru tabele "albums"
--
ALTER TABLE "albums"
  ADD CONSTRAINT "albums_ibfk_1" FOREIGN KEY ("Artist.Id") REFERENCES "artists" ("Id") ON UPDATE CASCADE;

--
-- Restrictii pentru tabele "artists"
--
ALTER TABLE "artists"
  ADD CONSTRAINT "artists_ibfk_1" FOREIGN KEY ("Id") REFERENCES "users" ("Id") ON UPDATE CASCADE;

--
-- Restrictii pentru tabele "awards"
--
ALTER TABLE "awards"
  ADD CONSTRAINT "awards_ibfk_1" FOREIGN KEY ("Album.Id") REFERENCES "albums" ("Id") ON UPDATE CASCADE;

--
-- Restrictii pentru tabele "songs"
--
ALTER TABLE "songs"
  ADD CONSTRAINT "songs_ibfk_1" FOREIGN KEY ("Album.Id") REFERENCES "albums" ("Id") ON UPDATE CASCADE;


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
