IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ResumeJob') AND type in (N'U'))
DROP TABLE dbo.ResumeJob
GO

CREATE TABLE dbo.ResumeJob
(
	id UNIQUEIDENTIFIER NOT NULL,
	resumeId UNIQUEIDENTIFIER NOT NULL,
	title TEXT NULL,
	description TEXT NULL,
	company TEXT NULL,
	startDate DATETIME NULL,
	startDateParts TINYINT NULL,
	endDate DATETIME NULL,
	endDateParts TINYINT NULL,
	isCurrent BIT NOT NULL
)

ALTER TABLE dbo.ResumeJob
ADD CONSTRAINT PK_ResumeJob PRIMARY KEY NONCLUSTERED
(
	id
)
GO

CREATE CLUSTERED INDEX IX_ResumeJob_resumeId ON dbo.ResumeJob 
(
	resumeId
)
GO

ALTER TABLE dbo.ResumeJob
ADD CONSTRAINT FK_ResumeJob_Resume FOREIGN KEY (resumeId)
REFERENCES dbo.Resume (id)
GO

