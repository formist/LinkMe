DECLARE @id UNIQUEIDENTIFIER
SET @id = '{19A26DB8-80FD-4b2f-A670-5202FB86799C}'

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Community') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
BEGIN

	-- Insert community details.

	DECLARE @name NVARCHAR(100)
	DECLARE @emailDomain NVARCHAR(100)
	DECLARE @url NVARCHAR(100)
	DECLARE @host NVARCHAR(100)
	DECLARE @flags TINYINT
	
	SET @name = 'AHRI HRcareers Network'
	SET @emailDomain = null
	SET @url = 'ahri'
	SET @host = 'ahricareers.linkme.com.au'
	SET @flags = 1

	IF NOT EXISTS (SELECT * FROM dbo.Community WHERE id = @id)
		INSERT
			dbo.Community ( id, name, emailDomain, url, host, flags )
		VALUES
			( @id, @name, @emailDomain, @url, @host, @flags )
	ELSE
		UPDATE
			dbo.Community
		SET
			name = @name, emailDomain = @emailDomain, url = @url, host = @host, flags = @flags
		WHERE
			id = @id

END