IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[CommunityMemberData]') AND name = N'PK_CommunityMemberData')
ALTER TABLE [dbo].[CommunityMemberData] DROP CONSTRAINT [PK_CommunityMemberData]

ALTER TABLE [dbo].[CommunityMemberData] ADD CONSTRAINT [PK_CommunityMemberData] PRIMARY KEY NONCLUSTERED 
(
	id,
	memberId,
	name
)