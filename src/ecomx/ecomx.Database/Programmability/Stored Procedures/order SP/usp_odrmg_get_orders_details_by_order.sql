CREATE PROCEDURE [dbo].[usp_odrmg_get_orders_details_by_order]
	@OrderNumber nvarchar(100)
AS
    Begin
	   SELECT * from
	   orderDetailTable o
	   inner join orderTable od on o.OrderNumber =@OrderNumber and  od.OrderNumber =@OrderNumber
	   inner join ProductTable p on o.ProductId = p.ProductId
    End
RETURN 0
