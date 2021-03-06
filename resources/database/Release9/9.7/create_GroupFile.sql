IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.GroupFile') AND type in (N'U'))
DROP TABLE dbo.GroupFile
GO

CREATE TABLE dbo.GroupFile
(
	id UNIQUEIDENTIFIER NOT NULL,
	groupId UNIQUEIDENTIFIER NOT NULL,
	savedByContributorId UNIQUEIDENTIFIER NOT NULL,
	fileReferenceId UNIQUEIDENTIFIER NOT NULL,
)

ALTER TABLE dbo.GroupFile
ADD CONSTRAINT PK_GroupFile PRIMARY KEY NONCLUSTERED
(
	id
)

CREATE CLUSTERED INDEX IX_GroupFile_groupId ON dbo.GroupFile
(
	groupId
)
GO

ALTER TABLE dbo.GroupFile
ADD CONSTRAINT FK_GroupFile_Group FOREIGN KEY (groupId)
REFERENCES dbo.[Group] (id)
GO


