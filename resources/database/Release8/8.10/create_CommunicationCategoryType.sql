
IF NOT EXISTS(SELECT * FROM dbo.systypes WHERE name = 'CommunicationCategoryType')
	CREATE TYPE dbo.CommunicationCategoryType FROM TINYINT NOT NULL

