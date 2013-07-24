--  -------------------------------------------------- 
--  Generated by Enterprise Architect Version 7.0.813
--  Created On : Friday, 13 July, 2007 
--  DBMS       : SQL Server 2000 
--  -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Region') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Region
GO

CREATE TABLE Region ( 
	id int NOT NULL
)
GO

ALTER TABLE Region ADD CONSTRAINT PK_Region 
	PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE Region ADD CONSTRAINT FK_Region_GeographicalArea 
	FOREIGN KEY (id) REFERENCES GeographicalArea (id)
GO

