--EXEC [dbo].[usp_Products_GetAllProduct]
CREATE PROCEDURE [dbo].[usp_Products_GetAllProduct]
	--@SearchText Nvarchar(255),
	--@offset INT,
	--@limit INT
AS
SET NOCOUNT On;
declare @RowTotal INT=0
	SELECT ProductID,ProductName,ImageUrl,Rating,Brand,MRP,Price,Quantity,Description ,ROW_NUMBER()over(order by ProductID desc) as RowNum 
	--into #temp
	from Products
	--where ProductName like '%'+@SearchText+'%'
	--select @RowTotal = @@ROWCOUNT

	--select @RowTotal as RowTotal, * from #temp
	--order by (RowNum) offset(@offset) ROWS FETCH NEXT(@limit) ROWS ONLY
	
RETURN 0
