CREATE PROCEDURE [dbo].[Usp_Users_GetPasswordById]
@Id int
AS
BEGIN
	SELECT Password
	FROM [dbo].[Users]
	WHERE Id = @Id;
END
