CREATE PROCEDURE [dbo].[usp_review_get_all_review_by_user_id]
	@CustomerId INT
AS
	BEGIN
	SELECT ReviewId,ProductId,CustomerId,Star,ReviewMsg,ReviewTimeStamp,UpdateTimeStamp 
	FROM review_table
	WHERE CustomerId = @CustomerId
	END
GO