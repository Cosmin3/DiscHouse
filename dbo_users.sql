﻿--
-- Script was generated by Devart dbForge Data Pump for SQL Server, Version 1.3.57.0
-- Product home page: http://www.devart.com/dbforge/sql/data-pump
-- Script date 12-Apr-18 3:25:08 PM
-- Server version: 14.00.1000
--

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT Diskhouse.dbo.users(Id, Name, Password, Rights) VALUES (N'1', N'LP', N'rock', N'2')
INSERT Diskhouse.dbo.users(Id, Name, Password, Rights) VALUES (N'2', N'admin', N'admin', N'1')
INSERT Diskhouse.dbo.users(Id, Name, Password, Rights) VALUES (N'3', N'guest', N'guest', N'3')
GO