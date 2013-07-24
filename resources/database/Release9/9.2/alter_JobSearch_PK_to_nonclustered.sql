IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[JobSearch]') AND name = N'PK_JobSearch')
ALTER TABLE [dbo].[JobSearch] DROP CONSTRAINT [PK_JobSearch]
GO

ALTER TABLE dbo.JobSearch
ADD CONSTRAINT PK_JobSearch
PRIMARY KEY NONCLUSTERED ([id])
GO
