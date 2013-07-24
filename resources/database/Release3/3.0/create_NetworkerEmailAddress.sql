--  -------------------------------------------------- 
--  Generated by Enterprise Architect Version 7.0.817
--  Created On : Monday, 22 October, 2007 
--  DBMS       : SQL Server 2000 
--  -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('NetworkerEmailAddress') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE NetworkerEmailAddress
GO

CREATE TABLE NetworkerEmailAddress ( 
	id uniqueidentifier NOT NULL,
	emailAddress EmailAddress NOT NULL,
	isVerified bit NOT NULL,
	networkerId uniqueidentifier NOT NULL
)
GO

ALTER TABLE NetworkerEmailAddress
	ADD CONSTRAINT UQ_NetworkerEmailAddress_emailAddress UNIQUE (emailAddress)
GO

ALTER TABLE NetworkerEmailAddress ADD CONSTRAINT PK_NetworkerEmailAddress 
	PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE NetworkerEmailAddress ADD CONSTRAINT FK_NetworkerEmailAddress_Networker 
	FOREIGN KEY (networkerId) REFERENCES Networker (id)
GO




