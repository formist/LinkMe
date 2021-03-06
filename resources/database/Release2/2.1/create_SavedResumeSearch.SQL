--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 6.1.792
--   Created On : Thursday, 14 September, 2006 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('linkme_owner.SavedResumeSearch') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE linkme_owner.SavedResumeSearch
GO

CREATE TABLE linkme_owner.SavedResumeSearch ( 
	id uniqueidentifier NOT NULL,
	name nvarchar(100) NOT NULL,
	criteriaSetId uniqueidentifier NOT NULL,
	alertId uniqueidentifier,
	ownerId varchar(50) NOT NULL
)
GO

ALTER TABLE linkme_owner.SavedResumeSearch
	ADD CONSTRAINT UQ_SavedResumeSearch_ownerId_name UNIQUE (ownerId, name)
GO

ALTER TABLE linkme_owner.SavedResumeSearch ADD CONSTRAINT PK_SavedResumeSearch 
	PRIMARY KEY (id)
GO

ALTER TABLE linkme_owner.SavedResumeSearch ADD CONSTRAINT FK_SavedResumeSearch_ResumeSearchCriteriaSet 
	FOREIGN KEY (criteriaSetId) REFERENCES linkme_owner.ResumeSearchCriteriaSet (id)
GO

ALTER TABLE linkme_owner.SavedResumeSearch ADD CONSTRAINT FK_SavedResumeSearch_employer_profile 
	FOREIGN KEY (ownerId) REFERENCES linkme_owner.employer_profile (id)
GO

ALTER TABLE linkme_owner.SavedResumeSearch ADD CONSTRAINT FK_SavedResumeSearch_SavedResumeSearchAlert 
	FOREIGN KEY (alertId) REFERENCES linkme_owner.SavedResumeSearchAlert (id)
GO






