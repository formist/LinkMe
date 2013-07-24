IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[JobSearchCriteria]') AND name = N'PK_JobSearchCriteria')
ALTER TABLE [dbo].[JobSearchCriteria] DROP CONSTRAINT [PK_JobSearchCriteria]
GO

ALTER TABLE dbo.JobSearchCriteria
ADD CONSTRAINT PK_JobSearchCriteria PRIMARY KEY NONCLUSTERED 
(
	setId,
	[name]
)
GO
