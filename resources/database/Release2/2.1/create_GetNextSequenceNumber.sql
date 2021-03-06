if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetNextSequenceNumber]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetNextSequenceNumber]
GO

CREATE PROCEDURE dbo.GetNextSequenceNumber(@vstrSequenceName AS VARCHAR(20))
AS
BEGIN
	DECLARE @intSequence AS INT

	SET NOCOUNT ON

	BEGIN TRANSACTION

	-- Must get an exclusive lock straight away to avoid deadlocks. Also, need to lock the whole table,
	-- not just the row, in case two processes try to INSERT the same sequence name simultaneously.

	SELECT @intSequence = NextNumber
	FROM dbo.[Sequence]
	WITH (TABLOCKX)
	WHERE [Name] = @vstrSequenceName

	IF @intSequence IS NULL
	BEGIN
		SET @intSequence = 1
		INSERT INTO dbo.[Sequence] ([Name], NextNumber)
		VALUES (@vstrSequenceName, @intSequence + 1)
	END
	ELSE
	BEGIN
		UPDATE dbo.[Sequence]
		SET NextNumber = (@intSequence + 1)
		WHERE [Name] = @vstrSequenceName
	END

	COMMIT TRANSACTION

	SELECT @intSequence
END
GO
