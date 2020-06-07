CREATE PROCEDURE [dbo].[usp_Products_Delete_Product]
	@ProductID int

As
BEGIN
	DELETE FROM Products WHERE ProductID=@ProductID;
	END
RETURN 0
