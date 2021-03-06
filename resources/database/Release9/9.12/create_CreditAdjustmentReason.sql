IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.CreditAdjustmentReason') AND type in (N'U'))
DROP TABLE dbo.CreditAdjustmentReason
GO

CREATE TABLE dbo.CreditAdjustmentReason
(
	id UNIQUEIDENTIFIER NOT NULL,
	description NVARCHAR(100) NOT NULL
)

ALTER TABLE dbo.CreditAdjustmentReason
ADD CONSTRAINT PK_CreditAdjustmentReason PRIMARY KEY NONCLUSTERED
(
	id
)

INSERT
	CreditAdjustmentReason (id, description)
SELECT
	id, description
FROM
	ProductGrantReason

GO

