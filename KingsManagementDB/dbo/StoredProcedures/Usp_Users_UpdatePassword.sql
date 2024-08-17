CREATE PROCEDURE [dbo].[Usp_Users_UpdatePassword]
@Id int,
@NewPassword varchar(20),
@UpdatedBy varchar(25)
AS
BEGIN
	UPDATE [dbo].[Users]
	SET [Password] = @NewPassword,
		[UpdatedBy] = @UpdatedBy,
		[UpdatedOn] = GETDATE()
	WHERE [Id] = @Id;
END
