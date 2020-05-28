CREATE PROCEDURE [dbo].[teststoreprocedure]
	@param1 int
AS
	SELECT * from testtable 
	where Id = @param1
RETURN 0
