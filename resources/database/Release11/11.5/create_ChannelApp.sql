IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ChannelApp') AND type in (N'U'))
DROP TABLE dbo.ChannelApp
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.App') AND type in (N'U'))
DROP TABLE dbo.App
GO

CREATE TABLE [dbo].[App](
	[id] [uniqueidentifier] NOT NULL,
	[name] NVARCHAR(50) NOT NULL
)
GO

ALTER TABLE dbo.App
ADD CONSTRAINT PK_App PRIMARY KEY NONCLUSTERED
(
	id
)
GO

CREATE UNIQUE INDEX IX_App_name ON dbo.App
(
	name
)
GO

CREATE TABLE [dbo].[ChannelApp](
	[channelId] [uniqueidentifier] NOT NULL,
	[appId] [uniqueidentifier] NOT NULL
)
GO

ALTER TABLE dbo.ChannelApp
ADD CONSTRAINT PK_ChannelApp PRIMARY KEY NONCLUSTERED
(
	channelId,
	appId
)
GO

ALTER TABLE dbo.ChannelApp
ADD CONSTRAINT FK_ChannelApp_Channel FOREIGN KEY (channelId)
REFERENCES dbo.Channel (id)
GO

ALTER TABLE dbo.ChannelApp
ADD CONSTRAINT FK_ChannelApp_App FOREIGN KEY (appId)
REFERENCES dbo.App (id)
GO



