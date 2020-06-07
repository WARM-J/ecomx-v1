CREATE PROCEDURE [dbo].[usp_review_get_star_by_product_id]
	@ProductId int
	
AS
	BEGIN
	SELECT t1.ProductId,One,Two,Three,Four,Five FROM
	(SELECT ProductId,COUNT(Star) AS Five FROM review_table 
	WHERE Star=5 and ProductId=@ProductId GROUP BY ProductId) t1
	LEFT JOIN
	(SELECT ProductId,COUNT(Star) AS Four FROM review_table
	WHERE Star=4 and ProductId=@ProductId GROUP BY ProductId) t2
	ON t1.ProductId = t2.ProductId
	LEFT JOIN
	(SELECT ProductId,COUNT(Star) AS Three FROM review_table 
	WHERE Star=3 and ProductId=@ProductId Group BY ProductId) t3
	ON t1.ProductId = t3.ProductId
	LEFT JOIN 
	(SELECT ProductId,COUNT(Star) AS Two FROM review_table 
	WHERE Star=2 and ProductId=@ProductId Group BY ProductId) t4
	ON t1.ProductId = t4.ProductId
	LEFT JOIN 
	(SELECT ProductId,COUNT(Star) AS One FROM review_table 
	WHERE Star=1 and ProductId=@ProductId Group BY ProductId) t5
	ON t1.ProductId = t5.ProductId
	END
go