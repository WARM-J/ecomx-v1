CREATE TABLE [dbo].[productTable]
(
	[ProductId] INT NOT NULL PRIMARY KEY Identity(1,1),
	[ProductName] varchar(100) Null,
	[CategoryId] int Null,
	[Price] decimal Null,
	[Description] nvarchar(500) Null
)
