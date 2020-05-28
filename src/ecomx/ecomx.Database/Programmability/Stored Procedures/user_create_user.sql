CREATE PROCEDURE [dbo].[user_create_user]
	@Name VARCHAR(100),
	@Age INT,
	@Address VARCHAR(100)
AS
	BEGIN
		INSERT INTO testtable (Name,Age,Address) VALUES (@Name,@Age,@Address)
	END
GO
