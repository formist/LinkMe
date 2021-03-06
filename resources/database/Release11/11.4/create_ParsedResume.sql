IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ParsedResume') AND type in (N'U'))
DROP TABLE dbo.ParsedResume
GO

CREATE TABLE dbo.ParsedResume
(
	id UNIQUEIDENTIFIER NOT NULL,
	firstName NVARCHAR(30) NULL,
	lastName NVARCHAR(30) NULL,
	street NVARCHAR(100) NULL,
	location NVARCHAR(1000) NULL,
	phoneNumber NVARCHAR(20) NULL,
	emailAddress NVARCHAR(320) NULL,
	dateOfBirth DATETIME NULL,
	dateOfBirthParts TINYINT NULL,
	resumeId UNIQUEIDENTIFIER NULL
)

ALTER TABLE dbo.ParsedResume
ADD CONSTRAINT PK_ParsedResume PRIMARY KEY NONCLUSTERED
(
	id
)

ALTER TABLE dbo.ParsedResume
ADD CONSTRAINT FK_ParsedResume_Resume FOREIGN KEY (resumeId)
REFERENCES dbo.Resume (id)
GO

