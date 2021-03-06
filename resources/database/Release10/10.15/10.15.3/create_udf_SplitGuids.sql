IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SplitGuids]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[SplitGuids]
GO

CREATE FUNCTION [dbo].[SplitGuids] (@delimiter NVARCHAR(MAX), @input NVARCHAR(MAX))
RETURNS TABLE (value UNIQUEIDENTIFIER)
AS EXTERNAL NAME [LinkMe.Framework.SqlServer].[LinkMe.Framework.SqlServer.UserDefinedFunctions].SplitGuids
GO