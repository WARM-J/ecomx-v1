CREATE PROCEDURE [dbo].[usp_odrmg_get_order_by_userId]
	@UserId nvarchar(100)
AS
		Begin
		Select c.ProductId,c.UserId,c.Quantity,c.DataCreate,p.Price,p.ProductName,p.Description
		From cartTable c
		inner join ProductTable p on c.ProductId=p.ProductId
		where c.UserId = @UserId
	End
RETURN 0
