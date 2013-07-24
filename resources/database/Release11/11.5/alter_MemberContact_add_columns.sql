ALTER TABLE dbo.MemberContact
ADD channelId UNIQUEIDENTIFIER NULL
GO

ALTER TABLE dbo.MemberContact
ADD appId UNIQUEIDENTIFIER NULL
GO

-- Set all existing channel/app to the web.

DECLARE @channelId UNIQUEIDENTIFIER
DECLARE @appId UNIQUEIDENTIFIER

SELECT
	@channelId = id
FROM
	dbo.Channel
WHERE
	name = 'Web'

SELECT
	@appId = id
FROM
	dbo.App
WHERE
	name = 'Web'

UPDATE
	dbo.MemberContact
SET
	channelId = @channelId,
	appId = @appId
GO

ALTER TABLE dbo.MemberContact
ALTER COLUMN channelId UNIQUEIDENTIFIER NOT NULL
GO

ALTER TABLE dbo.MemberContact
ALTER COLUMN appId UNIQUEIDENTIFIER NOT NULL
GO
