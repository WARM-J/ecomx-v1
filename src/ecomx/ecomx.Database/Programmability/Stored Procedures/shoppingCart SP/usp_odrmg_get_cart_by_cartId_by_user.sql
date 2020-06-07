CREATE PROCEDURE [dbo].[usp_odrmg_get_cart_by_cartId_by_user]
	@CartId int
AS
	Begin
		Select UserId,ProductId,Quantity,DataCreate,CartId From cartTable
		where CartId = @CartId
	End
Go