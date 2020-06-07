CREATE PROCEDURE [dbo].[usp_Products_GetProduct_By_ProductID]
	@ProductID INT
AS
BEGIN
	SELECT ProductID ,
	ProductName ,
	ImageUrl,
	Rating ,
	Brand ,
	MRP ,
	Price,
	Quantity From Products
	WHERE ProductID=@ProductID
	END
RETURN 0
