DECLARE @value DECIMAL
SET @value = 50000

EXEC dbo.CreateOfferingCriteria '7994CF68-C3D1-4C55-91A7-5D81BC7F0C36', 'C0134225-1185-4851-AF53-AFF69172A3D3', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '7367F4E1-314C-4628-8197-B55058022617', '1318D29E-D7AE-4D58-A2C0-A733816EE4E2', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '6130887F-C4B8-4428-BAE7-700AB31B9027', '66B1E6F8-892A-45C2-99F0-1B5DB8B1294C', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria 'F4FC51CA-0857-406D-8D5B-FAEDB92B9358', '7D4CB719-83F5-40A2-8420-DAF8500D7171', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '5DCE87C2-FD3A-4C60-89B9-1A1104624BA9', 'FAD9BDAD-799B-4731-A3FC-842F5A4599C9', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria 'CCCB0A1E-7891-4FEA-AAF7-1CC2DE7BCC00', '7DC9D0DD-BC9A-4C36-8ADA-3D34028DCC67', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL

EXEC dbo.CreateOfferingCriteria '5B047C55-C9CC-42DE-9E18-AA3F567A26B2', 'FFAD2715-CB01-4BA9-B3AB-F08F995CDFF6', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '3B23B738-8A04-4AA6-8C84-CD2E2B92413C', '55A990D3-2C6B-4FBF-B3E4-7696E1B55AB6', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, 'Keywords', 'Bachelor OR Degree OR Graduate'

SET @value = 80000

EXEC dbo.CreateOfferingCriteria '9F432786-F580-4DF1-9FC1-30C3738B7358', '85B3728D-60D3-4FE0-9059-6219D3A38EC5', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '7D5A2BE4-BA14-40A7-B5CC-F83C97FB1ABC', '22C57322-0B46-4AE0-BEC2-6673C9756A77', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria '1CCD028E-AE0C-40B8-A2CF-DE9ADE452CBE', 'D98A8B4B-2E40-4E4A-A7A9-81C9F6947DA4', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL
EXEC dbo.CreateOfferingCriteria 'B1AF0853-2D15-4FD1-A363-914C9EF63CD2', '28643C53-8110-4C63-8753-E05831053EAB', 'Country', 1, 'SalaryLowerBound', @value, 'ExcludeNoSalary', 1, 'UseUnrestrictedSalary', 1, NULL, NULL

UPDATE
	dbo.OfferCategory
SET
	name = name + ' (Fee for service)'
WHERE
	name IN
	(
		'Interview Skills & Coaching',
		'Career Transition Management',
		'Executive Career Transition Management',
		'Mature Age Job Search Assistance',
		'Migrants (already residing in Australia) Job Search Assistance',
		'Graduate Job Search Assistance'
	)