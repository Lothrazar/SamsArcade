CREATE TABLE [dbo].[Game]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(MAX) NOT NULL, 
    [developer] NVARCHAR(MAX) NULL, 
    [publisher] NVARCHAR(MAX) NULL
)
