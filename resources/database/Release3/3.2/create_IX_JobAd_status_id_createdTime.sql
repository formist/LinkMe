CREATE NONCLUSTERED INDEX [IX_JobAd_status_id_createdTime] ON [dbo].[JobAd] 
(
	[status] ASC,
	[id] ASC,
	[createdTime] ASC
)