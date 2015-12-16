CREATE TABLE [dbo].[Album]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [CategoryId] NVARCHAR(500) NULL, 
    [Title] NVARCHAR(500) NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [IsDelete] BIT NULL, 
    [IsShow] BIT NULL, 
    [IsTop] BIT NULL, 
    [InsertTime] DATETIME NULL, 
    [ViewTime] INT NULL, 
    [ImagesCount] INT NULL, 
    [UrlOriginal] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth102x102] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth235x350] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth490x350] NVARCHAR(500) NULL, 
    [UrlThumbnailHeight200] NVARCHAR(500) NULL, 
    [UpdatedTime] DATETIME NULL
)
