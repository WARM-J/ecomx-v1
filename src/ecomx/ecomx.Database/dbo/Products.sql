CREATE TABLE [dbo].[Products]
(
	[ProductID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [ProductName] NVARCHAR(MAX) NULL, 
    [ImageUrl] NVARCHAR(255) NULL, 
    [Rating] NVARCHAR(255) NULL, 
    [Brand] NVARCHAR(MAX) NULL, 
    [MRP] INT NULL, 
    [Price] INT NULL, 
    [Quantity] INT NULL 
)
