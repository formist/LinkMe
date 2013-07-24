--   -------------------------------------------------- 
--   Generated by Enterprise Architect Version 7.0.813
--   Created On : Thursday, 12 July, 2007 
--   DBMS       : SQL Server 2000 
--   -------------------------------------------------- 

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('CandidateAccessPurchase') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE CandidateAccessPurchase
GO

CREATE TABLE CandidateAccessPurchase ( 
	id uniqueidentifier NOT NULL,
	purchaseTime datetime NOT NULL,
	searcherId uniqueidentifier NOT NULL,
	candidateId uniqueidentifier NOT NULL
)
GO

ALTER TABLE CandidateAccessPurchase ADD CONSTRAINT PK_CandidateAccessPurchase 
	PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE CandidateAccessPurchase ADD CONSTRAINT FK_CandidateAccessPurchase_Candidate 
	FOREIGN KEY (candidateId) REFERENCES Candidate (id)
GO

ALTER TABLE CandidateAccessPurchase ADD CONSTRAINT FK_CandidateAccessPurchase_CandidateSearcher 
	FOREIGN KEY (searcherId) REFERENCES CandidateSearcher (id)
GO





