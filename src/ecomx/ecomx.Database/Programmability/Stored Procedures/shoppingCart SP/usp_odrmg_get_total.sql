CREATE PROCEDURE [dbo].[usp_odrmg_get_total]
@UserId nvarchar(100)
AS
	Begin		
			select sum(c.Quantity * p.Price) as price from 
				(select * from cartTable) c
				inner join 
				(select * from ProductTable) p
				on c.ProductId=p.ProductId
				where c.UserId =@UserId and c.IsOrderPlaced = 0
	End
RETURN 0
