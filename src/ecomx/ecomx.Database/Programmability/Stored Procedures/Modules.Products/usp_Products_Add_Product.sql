CREATE PROCEDURE [dbo].[usp_Products_Add_Product]
	--Add the parameters for the stored procedure here

	@ProductID  int =NULL,
	@ProductName nvarchar(max),
	@ImageUrl nvarchar(255),
	@Rating nvarchar(255),
	@Brand nvarchar(max),
	@MRP int,
	@Price int,
	@Quantity int
	
AS
BEGIN
	INSERT INTO dbo.Products(ProductName,ImageUrl,Rating,Brand,MRP,Price,Quantity)VALUES(@ProductName,@ImageUrl,@Rating,@Brand,@MRP,@Price,@Quantity)
	END
	 
	 
RETURN 0
