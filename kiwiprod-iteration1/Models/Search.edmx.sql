
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/29/2020 13:19:36
-- Generated from EDMX file: E:\Kiwiprod\IE project\kiwiprod-iteration1\kiwiprod-iteration1\Models\Search.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [searchDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AgeSet'
CREATE TABLE [dbo].[AgeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [age] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EducationLevelSet'
CREATE TABLE [dbo].[EducationLevelSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [level] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SkillsSet'
CREATE TABLE [dbo].[SkillsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [skillName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LocationSet'
CREATE TABLE [dbo].[LocationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AgeSet'
ALTER TABLE [dbo].[AgeSet]
ADD CONSTRAINT [PK_AgeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EducationLevelSet'
ALTER TABLE [dbo].[EducationLevelSet]
ADD CONSTRAINT [PK_EducationLevelSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SkillsSet'
ALTER TABLE [dbo].[SkillsSet]
ADD CONSTRAINT [PK_SkillsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocationSet'
ALTER TABLE [dbo].[LocationSet]
ADD CONSTRAINT [PK_LocationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------