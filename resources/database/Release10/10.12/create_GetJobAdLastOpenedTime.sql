if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetJobAdLastOpenedTime]') and xtype in (N'FN', N'IF', N'TF'))
DROP FUNCTION [dbo].[GetJobAdLastOpenedTime]
GO

CREATE FUNCTION dbo.GetJobAdLastOpenedTime (@jobAdId UNIQUEIDENTIFIER)
RETURNS DATETIME
AS
BEGIN

	DECLARE @time DATETIME

	-- The job ad must still be open.

	SELECT
		@time = MAX(s.time)
	FROM
		dbo.JobAdStatus AS s
	INNER JOIN
		dbo.JobAd AS a ON a.id = s.jobAdId
	WHERE
		a.id = @jobAdId
		AND a.status = 2
		AND s.previousStatus = 1
		AND s.newStatus = 2

	RETURN @time
END
GO
