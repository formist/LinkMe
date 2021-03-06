IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRelocationPreferenceDisplayText]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRelocationPreferenceDisplayText]
GO

CREATE FUNCTION [dbo].[GetRelocationPreferenceDisplayText](@preference AS TINYINT)
RETURNS NVARCHAR(100)
AS
BEGIN

	-- Converts the CandidateStatus enum into a string using the same logic as the CandidateStatusDisplay class.

	DECLARE @displayText NVARCHAR(100)

	SELECT
		@displayText = CASE @preference
		WHEN 1 THEN 'Yes'
		WHEN 2 THEN 'Would consider'
		ELSE 'No'
		END

	RETURN @displayText
END
