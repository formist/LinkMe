--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 7.0.813
--   Created On : Thursday, 12 July, 2007 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('CandidateIndustry') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE CandidateIndustry
GO

CREATE TABLE CandidateIndustry ( 
	candidateId uniqueidentifier NOT NULL,
	industryId uniqueidentifier NOT NULL
)
GO

ALTER TABLE CandidateIndustry ADD CONSTRAINT PK_CandidateIndustry 
	PRIMARY KEY CLUSTERED (candidateId, industryId)
GO

ALTER TABLE CandidateIndustry ADD CONSTRAINT FK_CandidateIndustry_Candidate 
	FOREIGN KEY (candidateId) REFERENCES Candidate (id)
GO

ALTER TABLE CandidateIndustry ADD CONSTRAINT FK_CandidateIndustry_Industry 
	FOREIGN KEY (industryId) REFERENCES Industry (id)
GO


