CREATE PROCEDURE [dbo].[usp_odrmg_get_order_details]
	@UserId nvarchar(100)
AS
	Begin	
		Select od.OrderId,od.OrderNumber,od.ProductId,od.Quantity,
		od.UserId,o.FullName,o.PhoneNumber,o.OrderDate,o.Address,o.City,
		o.DeliveryInstruction,o.Total
		from orderDetailTable od
		inner join orderTable o on o.UserId = od.UserId
		where od.UserId = @UserId
	End
RETURN 0
