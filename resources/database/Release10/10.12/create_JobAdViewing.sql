IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.JobAdViewing') AND type in (N'U'))
DROP TABLE dbo.JobAdViewing
GO

CREATE TABLE dbo.JobAdViewing
(
	id UNIQUEIDENTIFIER NOT NULL,
	time DATETIME NOT NULL,
	viewerId UNIQUEIDENTIFIER NULL,
	jobAdId UNIQUEIDENTIFIER NOT NULL
)

ALTER TABLE dbo.JobAdViewing
ADD CONSTRAINT PK_JobAdViewing PRIMARY KEY NONCLUSTERED
(
	id
)

CREATE CLUSTERED INDEX [IX_JobAdViewing_jobAdId] ON [dbo].[JobAdViewing]
(
	jobAdId
)
GO

ALTER TABLE dbo.JobAdViewing
ADD CONSTRAINT FK_JobAdViewing_JobAd FOREIGN KEY (jobAdId)
REFERENCES dbo.JobAd (id)
GO



