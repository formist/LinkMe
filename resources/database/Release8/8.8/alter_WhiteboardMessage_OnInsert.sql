ALTER TRIGGER [dbo].[OnWhiteboardMessageInsert]
ON [dbo].[WhiteboardMessage]
FOR INSERT

AS

-- Need to set this for NHibernate.

SET NOCOUNT ON

-- Need to use a cursor because ids are not auto-generated, e.g. via an identity or a default.

DECLARE @id UNIQUEIDENTIFIER
DECLARE @whiteboardId UNIQUEIDENTIFIER
DECLARE @posterId UNIQUEIDENTIFIER
DECLARE @eventId UNIQUEIDENTIFIER
DECLARE @text VARCHAR(100)
DECLARE @ownerId UNIQUEIDENTIFIER

DECLARE insertedCursor CURSOR STATIC FORWARD_ONLY FOR
SELECT
	id, whiteboardId, [text]
FROM
	inserted

OPEN insertedCursor

FETCH NEXT FROM insertedCursor INTO @id, @whiteboardId, @text
WHILE @@FETCH_STATUS = 0
BEGIN
	SET @ownerId = (SELECT id FROM Networker WHERE whiteboardId = @whiteboardId)
	SET @posterId = (SELECT posterId FROM UserContentItem WHERE id = @id)

	IF @ownerId IS NOT NULL
	BEGIN
		SET @eventId = NEWID()
		INSERT
			dbo.NetworkerEvent ( id, [time], [type], actorId, actionedNetworkerId, contentId )
		SELECT
			@eventId, GETDATE(), 63, @ownerId, @posterId, @id

		INSERT
			dbo.NetworkerEventDelta ( eventId, [from], [to] )
		SELECT
			@eventId, NULL, left(@text, 100)
	END
	FETCH NEXT FROM insertedCursor INTO @id, @whiteboardId, @text
END

CLOSE insertedCursor
DEALLOCATE insertedCursor

SET NOCOUNT OFF