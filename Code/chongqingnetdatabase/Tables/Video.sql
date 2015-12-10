CREATE TABLE [dbo].[Video]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(1000) NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [Thumbnail] NVARCHAR(500) NULL, 
    [Url] NVARCHAR(500) NULL, 
    [UrlM] NVARCHAR(500) NULL, 
    [InsertTime] DATETIME NULL, 
    [ViewTime] INT NULL, 
    [IsDelete] BIT NULL
)
