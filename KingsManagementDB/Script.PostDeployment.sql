﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (SELECT 1 FROM [dbo].[Users])
BEGIN
    INSERT INTO [dbo].[Users] (CompanyCode, EmployeeNo, FirstName, LastName, Status, Email, IsAdmin, Password,CreatedOn, CreatedBy)
    VALUES ('0','TestUser1','DefaultFName','DefaultLName',0,'DefaultEmail',0,'Password',GETDATE(),'Admin');
END