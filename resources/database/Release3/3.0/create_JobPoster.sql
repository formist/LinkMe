--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 7.0.813
--   Created On : Thursday, 12 July, 2007 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('JobPoster') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE JobPoster
GO

CREATE TABLE JobPoster ( 
	id uniqueidentifier NOT NULL,
	flags JobPosterFlags NOT NULL
)
GO

ALTER TABLE JobPoster ADD CONSTRAINT PK_JobPoster 
	PRIMARY KEY CLUSTERED (id)
GO



