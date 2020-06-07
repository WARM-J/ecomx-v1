CREATE PROCEDURE [dbo].[usp_odrmg_remove_product_by_cartId_by_user]
	@CartId Int
AS
	Begin
	Delete From cartTable Where CartId= @CartId;
	End
Go