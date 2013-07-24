IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ResumeSearch]') AND name = N'PK_ResumeSearch')
ALTER TABLE [dbo].[ResumeSearch] DROP CONSTRAINT [PK_ResumeSearch]
GO

ALTER TABLE dbo.ResumeSearch
ADD CONSTRAINT PK_ResumeSearch
PRIMARY KEY NONCLUSTERED ([id])
GO
