CREATE TABLE [dbo].[cartTable]
(
	[CartId] INT NOT NULL PRIMARY KEY identity(1,1),
	[UserId] nvarchar(100) NULL,
	[ProductId] int Null,
	[Quantity] int Null,
	[DataCreate] datetime Null,
	[IsOrderPlaced] bit Null,
	[Email] nvarchar(100) Null
)
