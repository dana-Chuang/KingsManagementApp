CREATE PROCEDURE [dbo].[Usp_Users_ChangeAdminStatus]
@Id int,
@NewStatus int,
@UpdatedBy varchar(25)
AS
BEGIN
	UPDATE [dbo].[Users]
	SET [AdminStatus] = @NewStatus,
		[UpdatedBy] = @UpdatedBy,
		[UpdatedOn] = GETDATE()
	WHERE [Id] = @Id;
END
