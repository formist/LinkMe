IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.FeaturedEmployer') AND type in (N'U'))
DROP TABLE dbo.FeaturedEmployer
GO

CREATE TABLE dbo.FeaturedEmployer
(
	id UNIQUEIDENTIFIER NOT NULL,
	name NVARCHAR(100) NOT NULL,
	logoUrl NVARCHAR(256) NOT NULL,
	logoOrder INT NOT NULL,
	enabled BIT NOT NULL
)

ALTER TABLE dbo.FeaturedEmployer
ADD CONSTRAINT PK_FeaturedEmployer PRIMARY KEY NONCLUSTERED
(
	id
)

CREATE UNIQUE CLUSTERED INDEX [IX_FeaturedEmployer_name] ON [dbo].[FeaturedEmployer]
(
	name
)
GO
