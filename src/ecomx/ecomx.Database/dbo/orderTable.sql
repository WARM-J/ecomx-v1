CREATE TABLE [dbo].[orderTable]
(
	[OrderId] INT NOT NULL PRIMARY KEY identity(1,1),
	[OrderNumber] nvarchar(100)  Null,
	[FullName] nvarchar(100)  Null,
	[PhoneNumber] nvarchar(100)  Null,
	[OrderDate] datetime  Null,
	[Address] nvarchar(100) Null,
	[City] nvarchar(100)  Null,
	[DeliveryInstruction] nvarchar(500) null,
	[UserId] nvarchar(100) null,
	[Total] decimal null
)
