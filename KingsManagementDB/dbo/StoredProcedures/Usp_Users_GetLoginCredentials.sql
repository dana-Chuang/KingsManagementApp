CREATE PROCEDURE [dbo].[Usp_Users_GetLoginCredentials]
@Email nvarchar(25)
AS
BEGIN
	SELECT FirstName, EmployeeNo
	FROM [dbo].[Users]
	WHERE Email = @Email;
END
