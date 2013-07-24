IF EXISTS (
	SELECT 1
	FROM information_schema.tables
	WHERE table_name = 'endorsement'
	AND table_schema = 'linkme_owner'
	AND table_type = 'BASE TABLE'
)
BEGIN
	
	ALTER TABLE Endorsement
	DROP COLUMN endorsementDate
	
END
GO