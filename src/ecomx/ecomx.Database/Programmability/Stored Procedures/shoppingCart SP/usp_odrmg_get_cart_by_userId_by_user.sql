CREATE PROCEDURE [dbo].[usp_odrmg_get_cart_by_userId_by_user]
	@UserId NVarChar(100) 
	
AS
	    Begin
			Select c.CartId, c.ProductId,c.UserId,c.Quantity,c.DataCreate,p.Price,p.ProductName,p.Description
			From cartTable c
			inner join ProductTable p on c.ProductId=p.ProductId
			where c.UserId = @UserId and c.IsOrderPlaced = 0
		End
Go
