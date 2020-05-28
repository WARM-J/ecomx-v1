CREATE PROCEDURE [dbo].[user_delete_user_by_id]
	@Id INT
AS
	BEGIN
		DELETE FROM testtable WHERE Id = @Id;
	END
GO
