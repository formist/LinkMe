-- Create the spammer table.

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Spammer') AND type in (N'U'))
DROP TABLE dbo.Spammer
GO

CREATE TABLE dbo.Spammer
(
	id UNIQUEIDENTIFIER NOT NULL,
	userId UNIQUEIDENTIFIER NULL,
	firstName NVARCHAR(200) NULL,
	lastName NVARCHAR(200) NULL
)
GO

ALTER TABLE dbo.Spammer
ADD CONSTRAINT PK_Spammer PRIMARY KEY NONCLUSTERED
(
	id
)
GO

INSERT dbo.Spammer (id, userId, firstName, lastName)
VALUES (NEWID(), NULL, 'Mariam', 'Ture')
GO

INSERT dbo.Spammer (id, userId, firstName, lastName)
VALUES (NEWID(), NULL, 'Lilian', 'Dikko')
GO

INSERT dbo.Spammer (id, userId, firstName, lastName)
VALUES (NEWID(), NULL, 'Boris', 'Kone')
GO

INSERT dbo.Spammer (id, userId, firstName, lastName)
VALUES (NEWID(), NULL, 'Achi', 'Chantal')
GO

