CREATE TABLE [dbo].[FAQSubcategory](
	[id] [uniqueidentifier] NOT NULL,
	[faqCategoryId] [uniqueidentifier] NOT NULL,
	[displayName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_faqSubcategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)
)
GO

ALTER TABLE [dbo].[FAQSubcategory]  WITH CHECK ADD  CONSTRAINT [FK_faqSubcategory_faqSubcategory] FOREIGN KEY([faqCategoryId])
REFERENCES [dbo].[FAQCategory] ([id])
GO
ALTER TABLE [dbo].[FAQSubcategory] CHECK CONSTRAINT [FK_faqSubcategory_faqSubcategory]