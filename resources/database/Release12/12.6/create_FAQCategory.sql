CREATE TABLE [dbo].[FAQCategory](
	[id] [uniqueidentifier] NOT NULL,
	[displayName] [nvarchar](50) NOT NULL,
	[displayOrder] [tinyint] NOT NULL,
 CONSTRAINT [PK_FAQCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)
