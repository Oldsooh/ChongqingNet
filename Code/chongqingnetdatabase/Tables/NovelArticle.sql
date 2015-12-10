CREATE TABLE [dbo].[NovelArticle]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [NovelId] INT NULL, 
    [Title] NVARCHAR(1000) NULL, 
    [ContentStyle] NTEXT NULL, 
    [InsertTime] DATETIME NULL
)
