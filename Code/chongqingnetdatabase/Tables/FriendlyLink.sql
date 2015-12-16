CREATE TABLE [dbo].[FriendlyLink]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Name] NVARCHAR(200) NULL, 
    [Link] NVARCHAR(500) NULL, 
    [Logo] NVARCHAR(500) NULL, 
    [Sort] INT NULL
)
