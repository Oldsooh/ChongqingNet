﻿CREATE TABLE [dbo].[NovelCategory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(500) NULL, 
    [Sort] INT NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [IsActive] BIT NULL
)
