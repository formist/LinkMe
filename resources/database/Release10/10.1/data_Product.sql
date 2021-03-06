CREATE PROCEDURE [dbo].[CreateProduct]
(
	@id UNIQUEIDENTIFIER,
	@name NVARCHAR(100),
	@price DECIMAL
)

AS
BEGIN

IF EXISTS (SELECT * FROM dbo.Product WHERE id = @id)
BEGIN
	DELETE
		dbo.ProductCreditAdjustment
	WHERE
		productId = @id

	DELETE
		dbo.Product
	WHERE
		id = @id
END

INSERT
	dbo.Product (id, name, enabled, userTypes, price, currency)
VALUES
	(@id, @name, 1, 2, @price, 36)
END
GO

CREATE PROCEDURE [dbo].[CreateCreditAdjustment]
(
	@productId UNIQUEIDENTIFIER,
	@quantity INT,
	@creditId UNIQUEIDENTIFIER
)

AS
BEGIN

INSERT
	dbo.ProductCreditAdjustment (productId, creditId, quantity, duration)
VALUES
	(@productId, @creditId, @quantity, 315360000000000)

END
GO

-- Contact credits

DECLARE @contactCreditId UNIQUEIDENTIFIER
SELECT
	@contactCreditId = id
FROM
	dbo.Credit
WHERE
	name = 'ContactCredit'

EXEC [dbo].[CreateProduct] '{4B209ABC-95D2-4ad8-9C99-A2C9A4D0B915}', '3 Candidate Contacts', 150
EXEC [dbo].[CreateCreditAdjustment] '{4B209ABC-95D2-4ad8-9C99-A2C9A4D0B915}', 3, @contactCreditId

EXEC [dbo].[CreateProduct] '{BB4BF45B-C0BE-4398-80B6-BE3555444AE5}', '10 Candidate Contacts', 400
EXEC [dbo].[CreateCreditAdjustment] '{BB4BF45B-C0BE-4398-80B6-BE3555444AE5}', 10, @contactCreditId

EXEC [dbo].[CreateProduct] '{C882B78C-93B4-42e3-B86A-F0C5CAB91B10}', '40 Candidate Contacts', 1200
EXEC [dbo].[CreateCreditAdjustment] '{C882B78C-93B4-42e3-B86A-F0C5CAB91B10}', 40, @contactCreditId

EXEC [dbo].[CreateProduct] '{AF2C1176-98F8-4138-AE5B-BD39E518206B}', '100 Candidate Contacts', 2000
EXEC [dbo].[CreateCreditAdjustment] '{AF2C1176-98F8-4138-AE5B-BD39E518206B}', 100, @contactCreditId

EXEC [dbo].[CreateProduct] '{88B5F4EA-97E2-4e6b-A03A-112826D2D5F0}', 'Unlimited Candidate Contacts', 0
EXEC [dbo].[CreateCreditAdjustment] '{88B5F4EA-97E2-4e6b-A03A-112826D2D5F0}', NULL, @contactCreditId

-- Job ad credits

DECLARE @jobAdCreditId UNIQUEIDENTIFIER
SELECT
	@jobAdCreditId = id
FROM
	dbo.Credit
WHERE
	name = 'JobAdCredit'

-- Applicant credits

DECLARE @applicantCreditId UNIQUEIDENTIFIER
SELECT
	@applicantCreditId = id
FROM
	dbo.Credit
WHERE
	name = 'ApplicantCredit'

EXEC [dbo].[CreateProduct] '{EDE89FC5-9B0B-45ba-A68F-8AD2EC22F7F1}', 'Unlimited Job Ads', 0
EXEC [dbo].[CreateCreditAdjustment] '{EDE89FC5-9B0B-45ba-A68F-8AD2EC22F7F1}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{EDE89FC5-9B0B-45ba-A68F-8AD2EC22F7F1}', NULL, @applicantCreditId

EXEC [dbo].[CreateProduct] '{94170E5D-EFE1-49ff-984D-1BB450244BEB}', '10 Applicant Pack', 150
EXEC [dbo].[CreateCreditAdjustment] '{94170E5D-EFE1-49ff-984D-1BB450244BEB}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{94170E5D-EFE1-49ff-984D-1BB450244BEB}', 10, @applicantCreditId

EXEC [dbo].[CreateProduct] '{3E3410DF-A95A-4995-BC42-CA2A858D1EE8}', '20 Applicant Pack', 250
EXEC [dbo].[CreateCreditAdjustment] '{3E3410DF-A95A-4995-BC42-CA2A858D1EE8}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{3E3410DF-A95A-4995-BC42-CA2A858D1EE8}', 20, @applicantCreditId

EXEC [dbo].[CreateProduct] '{8D96FBC8-8F47-4597-B559-EBB7B7D9C5DE}', '100 Applicant Pack', 1000
EXEC [dbo].[CreateCreditAdjustment] '{8D96FBC8-8F47-4597-B559-EBB7B7D9C5DE}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{8D96FBC8-8F47-4597-B559-EBB7B7D9C5DE}', 100, @applicantCreditId

EXEC [dbo].[CreateProduct] '{05FE52A9-D7A7-4a96-9FCF-EFB4414CB6B0}', '300 Applicant Pack', 2250
EXEC [dbo].[CreateCreditAdjustment] '{05FE52A9-D7A7-4a96-9FCF-EFB4414CB6B0}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{05FE52A9-D7A7-4a96-9FCF-EFB4414CB6B0}', 300, @applicantCreditId

-- Bundles

EXEC [dbo].[CreateProduct] '{A46812F1-CAD2-47c1-B8C3-5F7EF150DFBF}', '10 Applicants + 3 Contacts', 250
EXEC [dbo].[CreateCreditAdjustment] '{A46812F1-CAD2-47c1-B8C3-5F7EF150DFBF}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{A46812F1-CAD2-47c1-B8C3-5F7EF150DFBF}', 10, @applicantCreditId
EXEC [dbo].[CreateCreditAdjustment] '{A46812F1-CAD2-47c1-B8C3-5F7EF150DFBF}', 3, @contactCreditId

EXEC [dbo].[CreateProduct] '{BB5BC37D-052C-4946-BA0A-382AA7FEF1F2}', '20 Applicants + 10 Contacts', 500
EXEC [dbo].[CreateCreditAdjustment] '{BB5BC37D-052C-4946-BA0A-382AA7FEF1F2}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{BB5BC37D-052C-4946-BA0A-382AA7FEF1F2}', 20, @applicantCreditId
EXEC [dbo].[CreateCreditAdjustment] '{BB5BC37D-052C-4946-BA0A-382AA7FEF1F2}', 10, @contactCreditId

EXEC [dbo].[CreateProduct] '{C9C3DA74-9DFD-42c9-99D6-6A3C8ABF04E1}', '100 Applicants + 40 Contacts', 1760
EXEC [dbo].[CreateCreditAdjustment] '{C9C3DA74-9DFD-42c9-99D6-6A3C8ABF04E1}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{C9C3DA74-9DFD-42c9-99D6-6A3C8ABF04E1}', 100, @applicantCreditId
EXEC [dbo].[CreateCreditAdjustment] '{C9C3DA74-9DFD-42c9-99D6-6A3C8ABF04E1}', 40, @contactCreditId

EXEC [dbo].[CreateProduct] '{5C6B8B88-8057-44a9-8011-D6E0BF38CBAE}', '300 Applicants + 100 Contacts', 3400
EXEC [dbo].[CreateCreditAdjustment] '{5C6B8B88-8057-44a9-8011-D6E0BF38CBAE}', NULL, @jobAdCreditId
EXEC [dbo].[CreateCreditAdjustment] '{5C6B8B88-8057-44a9-8011-D6E0BF38CBAE}', 300, @applicantCreditId
EXEC [dbo].[CreateCreditAdjustment] '{5C6B8B88-8057-44a9-8011-D6E0BF38CBAE}', 100, @contactCreditId

DROP PROCEDURE [dbo].[CreateProduct]
DROP PROCEDURE [dbo].[CreateCreditAdjustment]
GO

