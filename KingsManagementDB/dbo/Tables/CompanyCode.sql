﻿CREATE TABLE [dbo].[CompanyCode]
(   
	[Id] INT IDENTITY(1,1) NOT NULL,
	[CompanyCode] VARCHAR(5) NULL, 
    [Domain] VARCHAR(10) NULL,
    [Created] DATETIME NOT NULL, 
    [CreatedBy] CHAR(25) NOT NULL, 
    [Updated] DATETIME NULL, 
    [UpdatedBy] CHAR(25) NULL,
	PRIMARY KEY CLUSTERED([Id] ASC)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF)
    ON [PRIMARY],
)

