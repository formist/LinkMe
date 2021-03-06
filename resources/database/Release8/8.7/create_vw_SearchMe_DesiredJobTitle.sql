SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vw_SearchMe_DesiredJobTitle'))
    DROP VIEW dbo.vw_SearchMe_DesiredJobTitle
GO

CREATE VIEW dbo.vw_SearchMe_DesiredJobTitle
AS
    SELECT r.id, doc,
           HashBytes('SHA1', doc) AS sha1sum,
           NULL AS lastEditedTime,
           CASE WHEN doc IS NULL THEN 1 ELSE 0 END AS docIsNull
      FROM (SELECT id, desiredJobTitle AS doc FROM dbo.Candidate) c
      JOIN Resume r on r.CandidateId = c.id