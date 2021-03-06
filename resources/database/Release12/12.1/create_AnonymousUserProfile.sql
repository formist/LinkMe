IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.AnonymousUserProfile') AND type in (N'U'))
DROP TABLE dbo.AnonymousUserProfile
GO

CREATE TABLE dbo.AnonymousUserProfile
(
	userId UNIQUEIDENTIFIER NOT NULL,
	userType INT NOT NULL
)

ALTER TABLE dbo.AnonymousUserProfile
ADD CONSTRAINT PK_AnonymousUserProfile PRIMARY KEY NONCLUSTERED
(
	userId
)

GO
