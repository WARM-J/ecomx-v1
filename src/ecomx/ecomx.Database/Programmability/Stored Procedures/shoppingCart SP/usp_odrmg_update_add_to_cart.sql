CREATE PROCEDURE [dbo].[usp_odrmg_update_add_to_cart]
	@CartId int,
	@IsOrderPlaced bit
AS
	Begin
		Update cartTable
		Set IsOrderPlaced =@IsOrderPlaced
		where CartId = @CartId
	End
RETURN 0
