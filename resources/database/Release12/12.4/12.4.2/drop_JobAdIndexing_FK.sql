IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobAdIndexing_JobAd]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobAdIndexing]'))
ALTER TABLE [dbo].[JobAdIndexing] DROP CONSTRAINT [FK_JobAdIndexing_JobAd]
GO

