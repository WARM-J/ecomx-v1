CREATE PROCEDURE [dbo].[user_get_user_by_id]
	@Id INT
AS
	BEGIN
		SELECT Id,Name,Age,Address FROM testtable
		WHERE Id = @Id
	END
GO
