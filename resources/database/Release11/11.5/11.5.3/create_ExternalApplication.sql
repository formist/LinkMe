IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ExternalApplication') AND type in (N'U'))
DROP TABLE dbo.ExternalApplication
GO

CREATE TABLE dbo.ExternalApplication
(
	id UNIQUEIDENTIFIER NOT NULL,
	createdTime DATETIME NOT NULL,
	positionId UNIQUEIDENTIFIER NOT NULL,
	applicantId UNIQUEIDENTIFIER NULL,
	isDeleted BIT NOT NULL
)

ALTER TABLE dbo.ExternalApplication
ADD CONSTRAINT PK_ExternalApplication PRIMARY KEY NONCLUSTERED
(
	id
)

CREATE NONCLUSTERED INDEX IX_ExternalApplication_applicantId ON dbo.ExternalApplication
(
	applicantId
)
GO
