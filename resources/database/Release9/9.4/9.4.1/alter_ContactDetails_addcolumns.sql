ALTER TABLE dbo.ContactDetails
ADD secondaryEmails NVARCHAR(700) NULL
GO

ALTER TABLE dbo.JobAd
ADD hideContactDetails BIT NULL
GO

UPDATE dbo.JobAd
SET hideContactDetails = 0
GO

ALTER TABLE dbo.JobAd
ALTER COLUMN hideContactDetails BIT NOT NULL
GO

