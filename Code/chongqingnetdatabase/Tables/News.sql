CREATE TABLE [dbo].[News]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CategoryId] NVARCHAR(500) NULL, 
    [Title] NVARCHAR(500) NULL, 
    [Keywords] NVARCHAR(500) NULL, 
    [Description] NVARCHAR(2000) NULL, 
    [Cover] NVARCHAR(500) NULL, 
    [PictureGroup] NVARCHAR(500) NULL, 
    [ContentStyle] NTEXT NULL, 
    [ContentText] NTEXT NULL, 
    [PostType] NVARCHAR(500) NULL, 
    [Author] NVARCHAR(500) NULL, 
    [ComeFrom] NVARCHAR(500) NULL, 
    [InsertTime] DATETIME NULL, 
    [UpdateTime] DATETIME NULL, 
    [ViewCount] INT NULL, 
    [IsRecommend] BIT NULL, 
    [IsTop] BIT NULL, 
    [IsSlide] BIT NULL, 
    [IsActive] BIT NULL
)
