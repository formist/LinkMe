set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[RegisterEmailLinkClick](@emailId VARCHAR(50), @communityId VARCHAR(50), @variationId VARCHAR(50), @file VARCHAR(50))
AS
BEGIN
	SET NOCOUNT ON

	BEGIN TRANSACTION

	declare @id uniqueidentifier
	set @id = (SELECT id FROM dbo.EmailStats WHERE emailId = @emailId AND communityId = @communityId AND variationId = @variationId)
 
	IF @id is not null
		BEGIN
			INSERT INTO dbo.EmailLinkStats (id, emailStatsId, [file], time)
			VALUES (newid(), @id, @file, getdate())

			IF (@@ERROR <> 0)
				BEGIN
					ROLLBACK TRANSACTION
					RETURN
				END
		END
	ELSE
		BEGIN
			declare @message varchar(200)
			set @message = 'The email with emailId "' + @emailId + '", communityId "' + @communityId +
				'" and variationId "' + @variationId + '" does not exist.'
			RAISERROR(@message, 14, 1)

			ROLLBACK TRANSACTION
			RETURN
		END
	COMMIT TRANSACTION
END
