CREATE TABLE [dbo].[Novel]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CategoryId] NVARCHAR(500) NULL, 
    [Title] NVARCHAR(500) NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(2000) NULL, 
    [Name] NVARCHAR(500) NULL, 
    [Author] NVARCHAR(500) NULL, 
    [ArticleCount] INT NULL, 
    [InsertTime] DATETIME NULL, 
    [ViewTime] INT NULL, 
    [IsDelete] BIT NULL
)
