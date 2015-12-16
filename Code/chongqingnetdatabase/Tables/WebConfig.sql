CREATE TABLE [dbo].[WebConfig]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [WebName] NVARCHAR(500) NULL, 
    [Title] NVARCHAR(500) NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [DomainName] NVARCHAR(500) NULL, 
    [DomainMobile] NVARCHAR(500) NULL, 
    [DomainImage] NVARCHAR(500) NULL, 
    [Notice] NVARCHAR(500) NULL, 
    [ICP] NVARCHAR(500) NULL, 
    [Tel] NVARCHAR(500) NULL, 
    [Phone] NVARCHAR(100) NULL, 
    [QQ] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Weibo] NVARCHAR(100) NULL, 
    [Address] NVARCHAR(500) NULL, 
    [StatisticalCode] NVARCHAR(2000) NULL, 
    [Tags] NVARCHAR(2000) NULL
)
