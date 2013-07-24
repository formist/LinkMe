IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[TinyUrlMapping]') AND name = N'IX_TinyUrlMapping_createdTime')
DROP INDEX [IX_TinyUrlMapping_createdTime] ON [dbo].[TinyUrlMapping]
GO

CREATE CLUSTERED INDEX [IX_TinyUrlMapping_createdTime] ON [dbo].[TinyUrlMapping]
(
	[createdTime]
)
GO

