CREATE PROCEDURE AssertUser(@id UNIQUEIDENTIFIER, @expectedFlags SMALLINT, @expectedSendPlainTextOnly BIT)
AS
BEGIN

	DECLARE @sId VARCHAR(100)
	SET @sId = CONVERT(VARCHAR(100), @id)

	IF NOT EXISTS (SELECT * FROM RegisteredUser WHERE id = @id)
		RAISERROR ('User %s not found', 10, 1, @sId)

	DECLARE @flags SMALLINT
	SELECT @flags = flags FROM RegisteredUser WHERE id = @id

	IF (@flags <> @expectedFlags)
		RAISERROR ('User %s has flags %i when it should have been %i', 10, 1, @sId, @flags, @expectedFlags)

	IF NOT EXISTS (SELECT * FROM EmailSettings WHERE userId = @id)
		RAISERROR ('EmailSettings for %s not found', 10, 1, @sId)

	DECLARE @sendPlainTextOnly BIT
	SELECT @sendPlainTextOnly = sendPlainTextOnly FROM EmailSettings WHERE userId = @id

	IF (@sendPlainTextOnly <> @expectedSendPlainTextOnly)
		RAISERROR ('User %s has plain text only flag wrong', 10, 1, @sId)

END

GO

DECLARE @id UNIQUEIDENTIFIER
DECLARE @flags SMALLINT

-- Nothing set.

SET @id = '{55815EDB-9FC3-4fd3-9B43-4B2D37820D61}'
SET @flags = 0
EXEC AssertUser @id, @flags, 0

-- Activated, Off, No EmailSettings

SET @id = '{F7266874-8699-4f42-99D3-2916710E5190}'
SET @flags = 32 + 1 -- Activated / EmailVerified
EXEC AssertUser @id, @flags, 0

-- Activated, On, No EmailSettings

SET @id = '{217301AC-8443-4087-948E-0925D7908F04}'
SET @flags = 32 /*+ 8*/ + 1 -- Activated / SendPlainTextEmail / EmailVerified
EXEC AssertUser @id, @flags, 1

-- Disabled, Off, No EmailSettings

SET @id = '{B162FF33-3AF2-4afe-8D2E-4C3C80C00D9A}'
SET @flags = 32 + 4 + 1 -- Activated / Disabled / EmailVerified
EXEC AssertUser @id, @flags, 0

-- Disabled, On, No EmailSettings

SET @id = '{0526A101-1537-449b-B10D-68DFD038B056}'
SET @flags = 32 /*+ 8*/ + 4 + 1 -- Activated / SendPlainTextEmail / Disabled / EmailVerified
EXEC AssertUser @id, @flags, 1

-- Activated, Off, EmailSettings

SET @id = '{053F5A30-45AB-4436-AA29-59EE06D26B77}'
SET @flags = 32 + 1 -- Activated / EmailVerified
EXEC AssertUser @id, @flags, 0

-- Activated, On, EmailSettings

SET @id = '{E578637A-1E5F-41f8-91FB-466E92296BBC}'
SET @flags = 32 /*+ 8*/ + 1 -- Activated / SendPlainTextEmail / EmailVerified
EXEC AssertUser @id, @flags, 1

-- Disabled, Off, EmailSettings

SET @id = '{3AE6E084-24C5-48ff-B4F7-00C925D6926E}'
SET @flags = 32 + 4 + 1 -- Activated / Disabled / EmailVerified
EXEC AssertUser @id, @flags, 0

-- Disabled, On, EmailSettings

SET @id = '{B2D6BB6C-966B-4a5d-A5F2-1BF71DD21A3E}'
SET @flags = 32 /*+ 8*/ + 4 + 1 -- Activated / SendPlainTextEmail / Disabled / EmailVerified
EXEC AssertUser @id, @flags, 1

GO

DROP PROCEDURE AssertUser
GO