IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CampaignSearch]') AND type in (N'U'))
DROP TABLE [dbo].[CampaignSearch]
GO

CREATE TABLE [dbo].[CampaignSearch](
	[id] [uniqueidentifier] NOT NULL,
	[criteriaSetId] [uniqueidentifier] NOT NULL,
	[ownerId] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_CampaignSearch] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)
GO

ALTER TABLE [dbo].[CampaignSearch]  WITH CHECK ADD  CONSTRAINT [FK_CampaignSearch_CampaignCriteriaSet] FOREIGN KEY([criteriaSetId])
REFERENCES [dbo].[CampaignCriteriaSet] ([id])
GO

