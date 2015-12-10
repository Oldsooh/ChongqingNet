CREATE TABLE [dbo].[Slide]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(500) NULL, 
    [Url] NVARCHAR(500) NULL, 
    [Image] NVARCHAR(500) NULL, 
    [InsertTime] DATETIME NULL
)
