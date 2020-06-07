CREATE PROCEDURE [dbo].[usp_review_get_top_review_by_product_id]
	@top int = 5,
	@ProductId int
AS
    BEGIN
	    SELECT TOP (@top) 
           [ReviewId]
          ,[ProductId]
          ,[CustomerId]
          ,[Star]
          ,[ReviewTimeStamp]
          ,[UpdateTimeStamp]
          ,[ReviewMsg]
        FROM [ecomx].[dbo].[review_table] 
        WHERE [ProductId] = @ProductId
        ORDER BY Star DESC
  END
GO
