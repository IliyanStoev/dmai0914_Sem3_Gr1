CREATE DATABASE HomeworkOnP
GO

USE [HomeworkOnP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person] (
    [pid]      INT           IDENTITY (1, 1) NOT NULL,
    [userName] VARCHAR (20)  NOT NULL,
    [name]     VARCHAR (30)  NOT NULL,
    [phone]    VARCHAR (20)  NOT NULL,
    [email]    VARCHAR (30)  NOT NULL,
    [password] VARCHAR (MAX) NOT NULL,
    [userType] INT           NOT NULL,
    [subject]  VARCHAR (30)  NULL,
    [grade]    VARCHAR (30)  NULL
);

USE [HomeworkOnP]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TutoringTime] (
    [tid]       INT          IDENTITY (1, 1) NOT NULL,
    [date]      DATETIME     NOT NULL,
    [childId]   INT          NULL,
    [teacherId] INT          NOT NULL,
    [time]      VARCHAR (20) NOT NULL
);

USE [HomeworkOnP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Assignment] (
    [aid]      INT           IDENTITY (1, 1) NOT NULL,
    [subject]  VARCHAR (30)  NOT NULL,
    [title]    VARCHAR (30)  NOT NULL,
    [exercise] VARCHAR (MAX) NOT NULL,
    [date]     DATE          NOT NULL,
    [deadLine] DATE          NOT NULL,
    [pid]      INT           NOT NULL
);

USE [HomeworkOnP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Homework] (
    [hid]          INT           IDENTITY (1, 1) NOT NULL,
    [childId]      INT           NOT NULL,
    [assignmentId] INT           NOT NULL,
    [date]         DATETIME      NOT NULL,
    [diskName]     VARCHAR (MAX) NOT NULL
);
