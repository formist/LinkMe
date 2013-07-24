IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[UserEvent]') AND name = N'IX_UserEvent_time')
DROP INDEX [IX_UserEvent_time] ON [dbo].[UserEvent] WITH ( ONLINE = OFF )
GO

CREATE INDEX IX_UserEvent_time ON dbo.UserEvent ([time])
GO
