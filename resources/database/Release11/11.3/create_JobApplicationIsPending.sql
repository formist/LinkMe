BEGIN TRANSACTION
GO
ALTER TABLE dbo.JobApplication ADD
	isPending bit NOT NULL CONSTRAINT DF_JobApplication_isPending DEFAULT 0
GO
COMMIT