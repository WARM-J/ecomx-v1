CREATE PROCEDURE [dbo].[usp_odrmg_create_order_by_user]
	@OrderNumber nvarchar(100) = null,@FullName nvarchar(100) = null,
	@PhoneNumber nvarchar(100) = null,@OrderDate DateTime = null,
	@UserId nvarchar(100) = null,@Address nvarchar(100) = null,
	@City nvarchar(100) = null,@DeliveryInstruction nvarchar(100) = null,
	@Total nvarchar(100) = null
AS
	
	Begin
	if not exists (select OrderNumber from orderTable where UserId =@UserId)
		Begin		
			Insert Into orderTable
				(FullName,UserId,PhoneNumber,
				OrderDate,Address,City,DeliveryInstruction,Total,OrderNumber)
			Select FullName=@FullName,
				UserId=@UserId,
				PhoneNumber=@PhoneNumber,
				OrderDate=@OrderDate,
				Address=@Address,
				City=@City,
				DeliveryInstruction=@DeliveryInstruction,
				Total=@Total,
				OrderNumber =@OrderNumber
			from cartTable c
			where c.UserId = @UserId and c.IsOrderPlaced = 0 
		End
	else
		Begin		
			Update orderTable 
			Set Total=isnull(Total,0)+ @Total
			where UserId=@UserId
		End
	End
RETURN 0
