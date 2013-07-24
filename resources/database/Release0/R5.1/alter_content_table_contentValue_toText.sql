IF EXISTS (
	SELECT 1
	FROM information_schema.tables
	WHERE table_name = 'Content'
	AND table_schema = 'linkme_owner'
	AND table_type = 'BASE TABLE'
)
BEGIN
	
	ALTER TABLE linkme_owner.Content
		ALTER COLUMN contentValue TEXT NULL
	
END
GO