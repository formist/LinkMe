ALTER VIEW [dbo].[vw_SearchMe_DesiredJobTitle]
AS
    SELECT r.id, 
           doc,
           HashBytes('SHA1', doc) AS sha1sum,
           CASE WHEN doc IS NULL THEN 1 ELSE 0 END AS docIsNull
    FROM (SELECT id, desiredJobTitle AS doc FROM dbo.Candidate) c
	JOIN dbo.Resume r on r.CandidateId = c.id