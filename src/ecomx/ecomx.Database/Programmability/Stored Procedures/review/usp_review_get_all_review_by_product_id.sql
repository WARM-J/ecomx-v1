CREATE PROCEDURE [dbo].[usp_review_get_all_review_by_product_id]
	@ProductId INT	
AS
	BEGIN
	SELECT ReviewId,ProductId,CustomerId,Star,ReviewMsg,ReviewTimeStamp,UpdateTimeStamp 
	FROM review_table
	WHERE ProductId = @ProductId
	END
GO