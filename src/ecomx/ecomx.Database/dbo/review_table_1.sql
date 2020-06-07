CREATE TABLE [dbo].[review_table]
(
	[ReviewId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ProductId] INT NOT NULL ,
	[CustomerId] INT NOT NULL,
	[Star] INT, 
    [ReviewTimeStamp] DATETIME NULL, 
    [UpdateTimeStamp] DATETIME NULL, 
    [ReviewMsg] VARCHAR(1000) NULL

)
