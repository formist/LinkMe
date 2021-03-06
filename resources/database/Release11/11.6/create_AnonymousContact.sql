IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.AnonymousContact') AND type in (N'U'))
DROP TABLE dbo.AnonymousContact
GO

CREATE TABLE [dbo].[AnonymousContact]
(
	[userId] [uniqueidentifier] NOT NULL,
	[contactDetailsId] [uniqueidentifier] NOT NULL
)
GO

ALTER TABLE dbo.AnonymousContact
ADD CONSTRAINT PK_AnonymousContact PRIMARY KEY CLUSTERED
(
	userId,
	contactDetailsId
)
GO

ALTER TABLE dbo.AnonymousContact
ADD CONSTRAINT FK_AnonymousContact_AnonymousUser FOREIGN KEY (userId)
REFERENCES dbo.AnonymousUser (id)
GO

ALTER TABLE dbo.AnonymousContact
ADD CONSTRAINT FK_AnonymousContact_ContactDetails FOREIGN KEY (contactDetailsId)
REFERENCES dbo.ContactDetails (id)
GO

