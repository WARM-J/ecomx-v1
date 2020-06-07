CREATE PROCEDURE [dbo].[usp_odrmg_add_to_cart_by_user]
    @UserId Nvarchar(100),
	@ProductId int,
	@Quantity int,
	@DataCreated datetime
AS
	Begin
		Insert Into cartTable (UserId,ProductId,Quantity,DataCreate)
		Values (@UserId,@ProductId,@Quantity,@DataCreated)
	End
Go
