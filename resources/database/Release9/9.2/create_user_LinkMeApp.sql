IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'LinkMeApp')
BEGIN
	DECLARE @loginName SYSNAME
	SET @loginName = CAST(SERVERPROPERTY('MachineName') AS SYSNAME) + '\LinkMeApp'

	DECLARE @sql NVARCHAR(1000)
	SET @sql = 'CREATE USER LinkMeApp FOR LOGIN [' + @loginName + ']'
	EXEC sp_executesql @sql

	EXEC sp_addrolemember N'db_owner', N'LinkMeApp'
END
