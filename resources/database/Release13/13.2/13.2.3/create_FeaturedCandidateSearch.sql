IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.FeaturedCandidateSearch') AND type in (N'U'))
DROP TABLE dbo.FeaturedCandidateSearch
GO

CREATE TABLE dbo.FeaturedCandidateSearch
(
	id UNIQUEIDENTIFIER NOT NULL,
	url NVARCHAR(1024) NOT NULL,
	title NVARCHAR(1024) NOT NULL
)

ALTER TABLE dbo.FeaturedCandidateSearch
ADD CONSTRAINT PK_FeaturedCandidateSearch PRIMARY KEY NONCLUSTERED
(
	id
)
GO

DELETE
	dbo.FeaturedCandidateSearch

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{54AC3914-EADC-4705-9F28-D7402F0163AF}', '~/search/candidates?Keywords=Engineer', 'Engineer')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{38304C04-2304-4AD5-9AB2-4126BE243BFB}', '~/search/candidates?Keywords=Sales+executive', 'Sales executive')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{D1FAC94E-DEC6-45DB-85B7-46F96C2CE37E}', '~/search/candidates?Keywords=Software+engineer', 'Software engineer')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{8ACB23EA-1C4F-4FFE-A48E-38CABBCE9E5A}', '~/search/candidates?Keywords=Project+manager', 'Project manager')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{FDDCBEFB-D96E-4B1D-8A1F-8CC5EC7DB4C3}', '~/search/candidates?Keywords=General+manager', 'General manager')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{1625AB19-A6AD-43BE-9B1B-4F5C4183CFC8}', '~/search/candidates?Keywords=Receptionist', 'Receptionist')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{65D5B34C-9478-47DD-BCA7-7F50AB996772}', '~/search/candidates?Keywords=Personal+assistant', 'Personal assistant')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{84F07DCD-9265-4A97-B4DE-59B0B455478D}', '~/search/candidates?Keywords=Accountant', 'Accountant')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{0A9D2D0E-D7E4-4C9C-9DAC-A9D94DD66341}', '~/search/candidates?Keywords=Nurse', 'Nurse')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{FFEF04FE-FD78-4B9A-BE22-CFA4506B629A}', '~/search/candidates?Keywords=Mechanic', 'Mechanic')

INSERT
	dbo.FeaturedCandidateSearch (id, url, title)
VALUES
	('{E6C796F7-0C70-4896-9DBC-B2F6E2202467}', '~/search/candidates?Keywords=Forklift+driver', 'Forklift driver')
