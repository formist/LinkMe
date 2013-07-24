IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StrJoin]') AND type = N'AF')
DROP AGGREGATE [dbo].[StrJoin]

CREATE AGGREGATE [dbo].[StrJoin](@input nvarchar(4000)) RETURNS nvarchar(max)
EXTERNAL NAME [LinkMe.SqlServer].[LinkMe.SqlServer.StrJoin]