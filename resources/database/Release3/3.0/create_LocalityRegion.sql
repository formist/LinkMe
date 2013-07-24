--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 7.0.813
--   Created On : Thursday, 12 July, 2007 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('LocalityRegion') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LocalityRegion
GO

CREATE TABLE LocalityRegion ( 
	localityId int NOT NULL,
	regionId int NOT NULL
)
GO

ALTER TABLE LocalityRegion ADD CONSTRAINT PK_LocalityRegion 
	PRIMARY KEY CLUSTERED (localityId, regionId)
GO

ALTER TABLE LocalityRegion ADD CONSTRAINT FK_LocalityRegion_Locality 
	FOREIGN KEY (localityId) REFERENCES Locality (id)
GO

ALTER TABLE LocalityRegion ADD CONSTRAINT FK_LocalityRegion_Region 
	FOREIGN KEY (regionId) REFERENCES Region (id)
GO


