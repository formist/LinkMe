IF NOT EXISTS (SELECT * FROM dbo.AtsIntegrator WHERE id = 'E61335AB-A34E-4AAE-A8E0-9FD329EC9DCD')
BEGIN
	INSERT
		dbo.AtsIntegrator (id, name)
	VALUES
		('E61335AB-A34E-4AAE-A8E0-9FD329EC9DCD', 'JobG8')
END

IF NOT EXISTS (SELECT * FROM dbo.IntegratorUser WHERE id = '3BAE70FC-350B-4778-953A-05226170602B')
BEGIN
	INSERT
		dbo.IntegratorUser (id, username, password, integratorId, permissions)
	VALUES
		('3BAE70FC-350B-4778-953A-05226170602B', 'JobG8', 'X03MO1qnZdYdgyfeuILPmQ==', 'E61335AB-A34E-4AAE-A8E0-9FD329EC9DCD', 1)
END
	