CREATE PROCEDURE [dbo].[usp_odrmg_get_all_order_details]
AS
	SELECT OrderId,OrderNumber,FullName,
		   PhoneNumber,OrderDate,
		   Address,City,DeliveryInstruction,
		   UserId,Total
    from orderTable
RETURN 0
