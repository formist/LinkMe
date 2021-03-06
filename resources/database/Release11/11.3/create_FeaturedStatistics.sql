IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.FeaturedStatistics') AND type in (N'U'))
DROP TABLE dbo.FeaturedStatistics
GO

CREATE TABLE dbo.FeaturedStatistics
(
	id UNIQUEIDENTIFIER NOT NULL,
	createdJobAds INT NOT NULL,
	members INT NOT NULL,
	memberSearches INT NOT NULL,
	memberAccesses INT NOT NULL
)

ALTER TABLE dbo.FeaturedStatistics
ADD CONSTRAINT PK_FeaturedStatistics PRIMARY KEY NONCLUSTERED
(
	id
)
GO

INSERT
	dbo.FeaturedStatistics (id, createdJobAds, members, memberSearches, memberAccesses)
VALUES
	('{BF834506-2403-4daa-9D17-C18F4D4A46BC}', 0, 0, 0, 0)