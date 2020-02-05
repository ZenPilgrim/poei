
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/29/2020 15:16:32
-- Generated from EDMX file: C:\Users\hj\source\repos\CoursEF\TpEFWinForm\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ArticleProjetDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArticleLigneCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneCommandeSet] DROP CONSTRAINT [FK_ArticleLigneCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_LigneCommandeCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneCommandeSet] DROP CONSTRAINT [FK_LigneCommandeCommande];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArticleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArticleSet];
GO
IF OBJECT_ID(N'[dbo].[LigneCommandeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LigneCommandeSet];
GO
IF OBJECT_ID(N'[dbo].[CommandeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommandeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArticleSet'
CREATE TABLE [dbo].[ArticleSet] (
    [IdArticle] int IDENTITY(1,1) NOT NULL,
    [PrixUnitaire] real  NOT NULL,
    [QuantiteStock] int  NOT NULL,
    [NomArticle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LigneCommandeSet'
CREATE TABLE [dbo].[LigneCommandeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QuantiteCommandee] int  NOT NULL,
    [Article_IdArticle] int  NULL,
    [Commande_NumCommande] int  NULL
);
GO

-- Creating table 'CommandeSet'
CREATE TABLE [dbo].[CommandeSet] (
    [NumCommande] int IDENTITY(1,1) NOT NULL,
    [DateCommande] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdArticle] in table 'ArticleSet'
ALTER TABLE [dbo].[ArticleSet]
ADD CONSTRAINT [PK_ArticleSet]
    PRIMARY KEY CLUSTERED ([IdArticle] ASC);
GO

-- Creating primary key on [Id] in table 'LigneCommandeSet'
ALTER TABLE [dbo].[LigneCommandeSet]
ADD CONSTRAINT [PK_LigneCommandeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [NumCommande] in table 'CommandeSet'
ALTER TABLE [dbo].[CommandeSet]
ADD CONSTRAINT [PK_CommandeSet]
    PRIMARY KEY CLUSTERED ([NumCommande] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Article_IdArticle] in table 'LigneCommandeSet'
ALTER TABLE [dbo].[LigneCommandeSet]
ADD CONSTRAINT [FK_ArticleLigneCommande]
    FOREIGN KEY ([Article_IdArticle])
    REFERENCES [dbo].[ArticleSet]
        ([IdArticle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticleLigneCommande'
CREATE INDEX [IX_FK_ArticleLigneCommande]
ON [dbo].[LigneCommandeSet]
    ([Article_IdArticle]);
GO

-- Creating foreign key on [Commande_NumCommande] in table 'LigneCommandeSet'
ALTER TABLE [dbo].[LigneCommandeSet]
ADD CONSTRAINT [FK_LigneCommandeCommande]
    FOREIGN KEY ([Commande_NumCommande])
    REFERENCES [dbo].[CommandeSet]
        ([NumCommande])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LigneCommandeCommande'
CREATE INDEX [IX_FK_LigneCommandeCommande]
ON [dbo].[LigneCommandeSet]
    ([Commande_NumCommande]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------