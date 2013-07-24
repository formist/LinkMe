IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[ResumeFilter]'))
DROP VIEW [dbo].[ResumeFilter]
GO

CREATE VIEW [dbo].[ResumeFilter]
    ([id],
     candidateId,
     lastEditedTime,
     flags,
     employerAccess,
     desiredJobTypes,
	 desiredSalaryLower,
     desiredSalaryUpper,
     localityId,
     countrySubdivisionId,
     relocationPreference,
     namedLocationId)
WITH SCHEMABINDING
AS
SELECT r.id,
       r.candidateId,
       r.lastEditedTime,
       ru.flags,
       m.employerAccess,
       c.desiredJobTypes,
       c.desiredSalaryLower,
	   c.desiredSalaryUpper,
       lr.localityId,
       lr.countrySubdivisionId,
       c.relocationPreference,
       lr.namedLocationId		
  FROM dbo.Resume r
  JOIN dbo.Member m              ON m.[id] = r.candidateId
  JOIN dbo.Candidate c           ON c.[id] = r.candidateId
  JOIN dbo.Address a             ON a.[id] = m.addressId
  JOIN dbo.LocationReference lr  ON lr.[id] = a.locationReferenceId
  JOIN dbo.RegisteredUser ru     ON ru.[id] = r.candidateId
WHERE r.lensXmlIsNull = 0
GO

CREATE UNIQUE CLUSTERED INDEX UQ_ResumeFilter
ON dbo.ResumeFilter ([id])
GO
