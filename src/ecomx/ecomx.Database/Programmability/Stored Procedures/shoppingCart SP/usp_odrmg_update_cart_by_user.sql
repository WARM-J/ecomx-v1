CREATE PROCEDURE [dbo].[usp_odrmg_update_cart_by_user]
	@CartId Int,
	@UserId NVarChar(100),
	@Quantity Int
AS
	Begin
		Update cartTable
		Set Quantity = @Quantity
		where CartId = @CartId and UserId = @UserId
    End
Go