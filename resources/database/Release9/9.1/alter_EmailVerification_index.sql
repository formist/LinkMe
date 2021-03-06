-- Turn the primary key into a non-clustered index.

IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[EmailVerification]') AND name = N'PK_EmailVerification')
ALTER TABLE [dbo].[EmailVerification] DROP CONSTRAINT [PK_EmailVerification]
GO

ALTER TABLE [dbo].[EmailVerification]
ADD CONSTRAINT [PK_EmailVerification] PRIMARY KEY NONCLUSTERED
(
	[id]
)
GO

-- Add an index for userId and emailAddress

IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[EmailVerification]') AND name = N'IX_EmailVerification_userId_emailAddress')
DROP INDEX [IX_EmailVerification_userId_emailAddress] ON [dbo].[EmailVerification]
GO

CREATE CLUSTERED INDEX [IX_EmailVerification_userId_emailAddress] ON [dbo].[EmailVerification]
(
	[userId],
	[emailAddress]
)
GO

-- Add an index for verificationCode

IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[EmailVerification]') AND name = N'IX_EmailVerification_verificationCode')
DROP INDEX [IX_EmailVerification_verificationCode] ON [dbo].[EmailVerification]
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_EmailVerification_verificationCode] ON [dbo].[EmailVerification]
(
	[verificationCode]
)
GO
