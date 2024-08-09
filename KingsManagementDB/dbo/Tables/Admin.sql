﻿CREATE TABLE [dbo].[Admin]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [CompanyCodeId] INT NULL, 
    [EmployeeNo] VARCHAR(10) NOT NULL, 
    [FirstName] VARCHAR(25) NULL, 
    [LastName] VARCHAR(25) NULL, 
    [Status] INT NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] CHAR(25) NOT NULL, 
    [Updated] DATETIME NULL, 
    [UpdatedBy] CHAR(25) NULL,
    PRIMARY KEY CLUSTERED
    (
      [Id] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF)
    ON [PRIMARY]
)
