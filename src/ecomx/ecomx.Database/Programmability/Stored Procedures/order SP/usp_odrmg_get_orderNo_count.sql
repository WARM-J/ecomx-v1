CREATE PROCEDURE [dbo].[usp_odrmg_get_orderNo_count]
As
	Begin
	    SELECT Count(*) +1
		from orderTable
	End
RETURN 0
