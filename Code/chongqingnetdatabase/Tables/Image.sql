CREATE TABLE [dbo].[Image]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [AlbumId] INT NULL, 
    [UrlOriginal] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth102x102] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth235x350] NVARCHAR(500) NULL, 
    [UrlThumbnailWidth490x350] NVARCHAR(500) NULL, 
    [UrlThumbnailHeight200] NVARCHAR(500) NULL
)
