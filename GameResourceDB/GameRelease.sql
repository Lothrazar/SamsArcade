CREATE TABLE [dbo].[GameRelease]
(
	[id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [year] INT NULL, 
    [file] NVARCHAR(MAX) NULL, 
    [file_ext] NVARCHAR(10) NULL, 
    [region] NVARCHAR(10) NULL, 
    [system] NVARCHAR(50) NULL, 
    [is_first] BIT NOT NULL DEFAULT 0, 
    [game_id] UNIQUEIDENTIFIER NOT NULL, 
    [language] NVARCHAR(50) NULL
)
