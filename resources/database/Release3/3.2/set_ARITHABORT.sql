DECLARE @dbname SYSNAME
SET @dbname = DB_NAME()
EXEC ('ALTER DATABASE ' + @dbname + ' SET ARITHABORT ON')
