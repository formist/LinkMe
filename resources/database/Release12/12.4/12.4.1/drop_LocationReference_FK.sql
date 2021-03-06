IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Group_LocationReference]') AND parent_object_id = OBJECT_ID(N'[dbo].[Group]'))
ALTER TABLE [dbo].[Group] DROP CONSTRAINT [FK_Group_LocationReference]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobAdLocation_LocationReference]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobAdLocation]'))
ALTER TABLE [dbo].[JobAdLocation] DROP CONSTRAINT [FK_JobAdLocation_LocationReference]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RelocationLocation_GeographicalArea]') AND parent_object_id = OBJECT_ID(N'[dbo].[RelocationLocation]'))
ALTER TABLE [dbo].[RelocationLocation] DROP CONSTRAINT [FK_RelocationLocation_GeographicalArea]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OfferingLocation_LocationReference]') AND parent_object_id = OBJECT_ID(N'[dbo].[OfferingLocation]'))
ALTER TABLE [dbo].[OfferingLocation] DROP CONSTRAINT [FK_OfferingLocation_LocationReference]
GO