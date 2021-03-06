IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Vertical') AND type in (N'U'))
DROP TABLE dbo.Vertical
GO

CREATE TABLE dbo.Vertical
(
	id UNIQUEIDENTIFIER NOT NULL,
	name NVARCHAR(100) NOT NULL,
	url NVARCHAR(100) NULL,
	host NVARCHAR(100) NULL,
	countryId INT NULL
)

ALTER TABLE dbo.Vertical
ADD CONSTRAINT PK_Vertical PRIMARY KEY NONCLUSTERED
(
	id
)

ALTER TABLE dbo.Vertical
ADD CONSTRAINT UQ_Vertical_name UNIQUE NONCLUSTERED 
(
	name 
)

