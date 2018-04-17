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
  "Id" int NOT NULL IDENTITY(1,1),
  "Name" varchar(150) NOT NULL,
  "Year" date NOT NULL,
  "Genre" varchar(50) NOT NULL,
  "Artist.Id" int NOT NULL 
  PRIMARY KEY (Id)
) 

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "artists"
--

CREATE TABLE "artists" (
  "Id" int NOT NULL IDENTITY(1,1),
  "Name" varchar(150) NOT NULL,
  "Description" text NOT NULL,
  "Members" varchar(200) NOT NULL,
  "userid" int not null
  PRIMARY KEY (Id)
) 

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "awards"
--

CREATE TABLE "awards" (
  "Id" int NOT NULL IDENTITY(1,1),
  "Name" varchar(150) NOT NULL,
  "Album.Id" int NOT NULL,
  "Year" date NOT NULL
  PRIMARY KEY(Id)
)

-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "songs"
--

CREATE TABLE "songs" (
  "Id" int NOT NULL IDENTITY(1,1),
  "Album.Id" INT NOT NULL,
  "Name" varchar(150) NOT NULL,
  "Length" time(5) NOT NULL
  PRIMARY KEY(Id)
) 
-- --------------------------------------------------------

--
-- Structura de tabel pentru tabelul "users"
--

CREATE TABLE "users" (
  "Id" int NOT NULL IDENTITY(1,1),
  "Name" varchar(150) NOT NULL,
  "Password" varchar(50) NOT NULL,
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
  ADD CONSTRAINT "artists_ibfk_1" FOREIGN KEY ("userid") REFERENCES "users" ("Id") ON UPDATE CASCADE;

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
