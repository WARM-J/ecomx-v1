CREATE PROCEDURE [dbo].[user_update_user_by_id]
	@Id INT,
	@Name VARCHAR(100),
	@Age INT,
	@Address VARCHAR(100)
AS
	BEGIN 
		UPDATE testtable
		SET Name = @Name, Age = @Age, Address = @Address
		WHERE Id = @Id;
	END
GO
