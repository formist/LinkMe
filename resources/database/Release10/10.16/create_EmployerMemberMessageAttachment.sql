IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.EmployerMemberMessageAttachment') AND type in (N'U'))
DROP TABLE dbo.EmployerMemberMessageAttachment
GO

CREATE TABLE dbo.EmployerMemberMessageAttachment
(
	messageId UNIQUEIDENTIFIER NOT NULL,
	attachmentId UNIQUEIDENTIFIER NOT NULL
)

ALTER TABLE dbo.EmployerMemberMessageAttachment
ADD CONSTRAINT PK_EmployerMemberMessageAttachment PRIMARY KEY CLUSTERED
(
	messageId,
	attachmentId
)

ALTER TABLE dbo.EmployerMemberMessageAttachment
ADD CONSTRAINT FK_EmployerMemberMessageAttachment_Message FOREIGN KEY (messageId)
REFERENCES dbo.EmployerMemberMessage (id)
GO

ALTER TABLE dbo.EmployerMemberMessageAttachment
ADD CONSTRAINT FK_EmployerMemberMessageAttachment_Attachment FOREIGN KEY (attachmentId)
REFERENCES dbo.EmployerMemberAttachment (id)
GO
