CREATE PROCEDURE [dbo].[usp_review_create_or_update_review]
	@ProductId INT,
	@CustomerId INT,
	@Star INT,
	@ReviewMsg VARCHAR(1000)
AS
	BEGIN
		DECLARE @reviewtime DATETIME;
		DECLARE @updatetime DATETIME;
		SET @reviewtime = GETDATE();
		SET @updatetime = GETDATE();
		IF(EXISTS(SELECT 1 FROM [review_table] WHERE [ProductId] = @ProductId AND [CustomerId]= @CustomerId))
			BEGIN
				UPDATE review_table 
				SET
				Star = @Star,
				ReviewMsg = @ReviewMsg,
				UpdateTimeStamp = @updatetime
				WHERE [ProductId] = @ProductId AND [CustomerId]= @CustomerId
			END
		ELSE
			BEGIN
				INSERT INTO review_table(ProductId,CustomerId,Star,ReviewMsg,ReviewTimeStamp,UpdateTimeStamp)
				VALUES (@ProductId,@CustomerId,@Star,@ReviewMsg,@reviewtime,@updatetime)
			END	
	END
GO
