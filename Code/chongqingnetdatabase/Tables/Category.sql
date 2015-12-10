CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EntityType] NVARCHAR(500) NULL, 
    [Title] NVARCHAR(2000) NULL, 
    [Keywords] NVARCHAR(2000) NULL, 
    [Description] NCHAR(10) NULL, 
    [Name] NVARCHAR(500) NULL, 
    [OrderNumber] INT NULL, 
    [IsShow] BIT NULL, 
    [UpdatedTime] DATETIME NULL
)
