CREATE PROCEDURE [dbo].[usp_odrmg_update_is_placed_order_in__cart]
	--@CartId int,
	@IsOrderPlaced bit,
	@UserId NVarChar(100) = null
AS
	Begin
		Update cartTable
		Set IsOrderPlaced =@IsOrderPlaced
		where 
		--CartId = @CartId and 
		UserId =@UserId
	End
RETURN 0
