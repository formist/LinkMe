IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.UserActivation') AND type in (N'U'))
DROP TABLE dbo.UserActivation
GO

CREATE TABLE dbo.UserActivation
(
	id UNIQUEIDENTIFIER NOT NULL,
	userId UNIQUEIDENTIFIER NOT NULL,
	time DATETIME NOT NULL,
	activatedById UNIQUEIDENTIFIER NOT NULL
)

ALTER TABLE dbo.UserActivation
ADD CONSTRAINT PK_UserActivation PRIMARY KEY NONCLUSTERED
(
	id
)

CREATE CLUSTERED INDEX [IX_UserActivation_userId] ON [dbo].[UserActivation]
(
	userId,
	time
)
GO

INSERT
	dbo.UserActivation (id, userId, time, activatedById)
SELECT
	e.id, u.userId, e.time, e.actorId
FROM
	dbo.UserEvent AS e
LEFT OUTER JOIN
	dbo.UserEventActionedUser AS u ON u.eventid = e.id
WHERE
	e.type = 16