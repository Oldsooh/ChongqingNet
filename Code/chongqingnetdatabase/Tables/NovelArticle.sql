﻿CREATE TABLE [dbo].[NovelArticle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [NovelId] INT NULL, 
    [Title] NVARCHAR(1000) NULL, 
    [ContentStyle] NTEXT NULL, 
    [InsertTime] DATETIME NULL
)
