IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.EmployerProfile') AND type in (N'U'))
DROP TABLE dbo.EmployerProfile
GO

CREATE TABLE dbo.EmployerProfile
(
	employerId UNIQUEIDENTIFIER NOT NULL,
	hideCreditReminder BIT NOT NULL,
	hideBulkCreditReminder BIT NOT NULL
)

ALTER TABLE dbo.EmployerProfile
ADD CONSTRAINT PK_EmployerProfile PRIMARY KEY NONCLUSTERED
(
	employerId
)

GO
