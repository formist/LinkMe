CREATE TABLE [dbo].[ResourceViewing](
	[id] [uniqueidentifier] NOT NULL,
	[userId] [uniqueidentifier] NOT NULL,
	[resourceId] [uniqueidentifier] NOT NULL,
	[resourceType] [tinyint] NOT NULL,
	[time] [datetime] NOT NULL,
 CONSTRAINT [PK_ResourceViewing] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)
