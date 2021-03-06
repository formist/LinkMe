IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ContentDetail') AND type in (N'U'))
DROP TABLE dbo.ContentDetail
GO

CREATE TABLE dbo.ContentDetail
(
	id UNIQUEIDENTIFIER NOT NULL,
	itemId UNIQUEIDENTIFIER NOT NULL,
	name NVARCHAR(255) NOT NULL,
	type NVARCHAR(255) NOT NULL,
	value SQL_VARIANT NULL,
	stringValue TEXT NULL
)

ALTER TABLE dbo.ContentDetail
ADD CONSTRAINT PK_ContentDetail PRIMARY KEY NONCLUSTERED
(
	id
)

ALTER TABLE dbo.ContentDetail
ADD CONSTRAINT FK_ContentDetail_ContentItem FOREIGN KEY (itemId)
REFERENCES dbo.ContentItem (id)

