CREATE PROCEDURE [dbo].[usp_Products_GetAllProduct]
	
AS
	SELECT ProductID,ProductName,ImageUrl,Rating,Brand,MRP,Price,Quantity from Products
RETURN 0
