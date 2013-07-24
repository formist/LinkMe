IF NOT EXISTS (SELECT * FROM syscolumns WHERE id = OBJECT_ID('CreditAllocation') AND NAME = 'referenceId')
BEGIN

	ALTER TABLE dbo.CreditAllocation
	ADD referenceId UNIQUEIDENTIFIER NULL

END
	
GO
