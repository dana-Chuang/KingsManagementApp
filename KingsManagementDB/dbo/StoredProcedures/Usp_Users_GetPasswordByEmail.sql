CREATE PROCEDURE [dbo].[Usp_Users_GetPasswordByEmail]
@Email nvarchar(25)
AS
BEGIN
	SELECT Password
	FROM [dbo].[Users]
	WHERE Email = @Email;
END
