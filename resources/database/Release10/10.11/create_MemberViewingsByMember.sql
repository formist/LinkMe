IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[MemberViewingsByMember]'))
DROP VIEW [dbo].[MemberViewingsByMember]
GO

CREATE VIEW dbo.MemberViewingsByMember (memberId, views)
WITH SCHEMABINDING
AS
	SELECT memberId, COUNT_BIG(*)
	FROM dbo.MemberViewing
	GROUP BY memberId
GO

CREATE UNIQUE CLUSTERED INDEX IX_MemberViewingsByMember
ON dbo.MemberViewingsByMember (memberId)
GO
