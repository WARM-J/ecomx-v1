CREATE TABLE [dbo].[orderDetailTable]
(
	[OrderDetailId] INT NOT NULL PRIMARY KEY Identity(1,1),
	[OrderId] int null,
	[OrderNumber] Nvarchar(100) null,
	[ProductId] int null,
	[Quantity] int null,
	[UserId] nvarchar(100) null
)
