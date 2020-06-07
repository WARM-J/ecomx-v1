CREATE PROCEDURE [dbo].[usp_review_get_avg_rating_of_product]
	@ProductId int 
AS
	Begin
	SELECT AVG(Star) from review_table
	where ProductId = @ProductId
	End

GO
