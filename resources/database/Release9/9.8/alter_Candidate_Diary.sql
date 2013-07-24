IF NOT EXISTS (SELECT * FROM syscolumns WHERE id = OBJECT_ID('Candidate') AND NAME = 'diaryId')
BEGIN

	ALTER TABLE dbo.Candidate
	ADD diaryId UNIQUEIDENTIFIER NULL

END
	
ALTER TABLE dbo.Candidate
ADD CONSTRAINT FK_Candidate_CandidateDiary FOREIGN KEY (diaryId)
REFERENCES dbo.[CandidateDiary] (id)
GO
