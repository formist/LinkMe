IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.OfferRequest') AND type in (N'U'))
DROP TABLE dbo.OfferRequest
GO

CREATE TABLE dbo.OfferRequest
(
	id UNIQUEIDENTIFIER NOT NULL,
	categoryId UNIQUEIDENTIFIER NOT NULL,
	userId UNIQUEIDENTIFIER NOT NULL
)

ALTER TABLE dbo.OfferRequest
ADD CONSTRAINT PK_OfferRequest PRIMARY KEY NONCLUSTERED
(
	id
)

ALTER TABLE dbo.OfferRequest
ADD CONSTRAINT FK_OfferRequest_OfferCategory FOREIGN KEY (categoryId)
REFERENCES dbo.OfferCategory (id)

ALTER TABLE dbo.OfferRequest
ADD CONSTRAINT FK_OfferRequest_UserToUserRequest FOREIGN KEY(id)
REFERENCES dbo.UserToUserRequest (id)
