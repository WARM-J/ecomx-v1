CREATE TABLE [dbo].[review_table]
(
	[ReviewId] INT NOT NULL PRIMARY KEY identity(1,1), 
    [ProductId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [Star] INT NOT NULL, 
    [ReviewTimeStamp] DATETIME NULL, 
    [UpdateTimeStamp] DATE NULL, 
    [ReviewMsg] NCHAR(1000) NULL
)
