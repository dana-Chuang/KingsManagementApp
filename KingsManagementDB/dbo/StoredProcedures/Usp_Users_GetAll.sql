CREATE PROCEDURE [dbo].[Usp_Users_GetAll]
AS
BEGIN
	SELECT Id,
		CompanyCode,
		EmployeeNo,
		FirstName,
		LastName,
		Status,
		Password,
		CreatedOn,
		CreatedBy,
		UpdatedOn,
		UpdatedBy
	FROM [dbo].[Users];
END
