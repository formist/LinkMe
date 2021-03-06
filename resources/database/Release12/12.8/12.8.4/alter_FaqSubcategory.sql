ALTER TABLE dbo.FAQSubcategory
ADD displayOrder TINYINT NULL
GO

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 10
WHERE
	faqCategoryId = '9D961194-16DF-463E-8B74-2C744F91DA6C' AND displayName = 'Job and employment scams'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 10
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Contacting candidates'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 20,
	displayName = 'Job board'
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Job Board'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 30
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Saved searches and email alerts'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 40
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Searching for candidates'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 50
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Folders and notes'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 60
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'Candidate Connect'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 70
WHERE
	faqCategoryId = '556AA450-EB4A-4664-A3DC-400C2232739D' AND displayName = 'About LinkMe'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 10
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Setting up your profile'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 20
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Accessing and editing your profile'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 30
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Security, spam and access'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 40
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Applying for jobs'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 50
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'My LinkMe profile'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 60
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Email alerts and newsletters'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 70
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'Miscellaneous'

UPDATE
	dbo.FAQSubcategory
SET
	displayOrder = 80
WHERE
	faqCategoryId = 'F0D71552-14BC-40B5-A237-A1A8BE2F2C98' AND displayName = 'About LinkMe'
GO

ALTER TABLE dbo.FAQSubcategory
ALTER COLUMN displayOrder TINYINT NOT NULL
GO

