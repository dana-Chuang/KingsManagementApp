CREATE PROCEDURE [dbo].[Usp_Users_AddAdmin]
@Id int,
@UpdatedBy varchar(25)
AS
BEGIN
	UPDATE [dbo].[Users]
	SET [IsAdmin] = 1,
		[UpdatedBy] = @UpdatedBy,
		[UpdatedOn] = GETDATE()
	WHERE [Id] = @Id;
END