CREATE PROCEDURE [dbo].[usp_odrmg_create_order_details]
	@OrderId int = null,
	@OrderNumber nvarchar(100) = null,
	--@ProductId int = null , @Quantity int= null,
	@UserId nvarchar(100) null
AS
	Begin
		Insert Into orderDetailTable 
			(UserId,OrderId,OrderNumber,ProductId,Quantity)
		Select @UserId,o.OrderId,o.OrderNumber,c.ProductId,c.Quantity
		from orderTable o ,cartTable c
		where  o.UserId=@UserId and c.UserId=@UserId and c.IsOrderPlaced = 0 
	End
RETURN 0
