CREATE PROCEDURE [dbo].[usp_Products_Update_Product]
	@ProductID int,
	@ProductName nvarchar(max),
	@ImageUrl nvarchar(255),
	@Rating nvarchar(255),
	@Brand nvarchar(max),
	@MRP int,
	@Price int,
	@Quantity int
AS
	BEGIN
	UPDATE Products
	SET 
	ProductName=@ProductName,
	ImageUrl=@ImageUrl,
	Rating=@Rating,
	Brand=@Brand,
	MRP=@MRP,
	Price=@Price,
	Quantity=@Quantity

	WHERE ProductID=@ProductID;
	END
RETURN 0
