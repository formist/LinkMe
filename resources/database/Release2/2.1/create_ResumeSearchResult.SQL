--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 6.1.792
--   Created On : Thursday, 14 September, 2006 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('linkme_owner.ResumeSearchResult') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE linkme_owner.ResumeSearchResult
GO

CREATE TABLE linkme_owner.ResumeSearchResult ( 
	setId uniqueidentifier NOT NULL,
	rank smallint NOT NULL,
	resumeId varchar(100) NOT NULL
)
GO

ALTER TABLE linkme_owner.ResumeSearchResult ADD CONSTRAINT PK_ResumeSearchResult 
	PRIMARY KEY (setId, rank)
GO

ALTER TABLE linkme_owner.ResumeSearchResult ADD CONSTRAINT FK_ResumeSearchResult_ResumeSearchResultSet 
	FOREIGN KEY (setId) REFERENCES linkme_owner.ResumeSearchResultSet (id)
GO




