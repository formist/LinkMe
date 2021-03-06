-- Disable Alternative Careers

UPDATE
	dbo.Offering
SET
	enabled = 0
WHERE
	id IN
	(
		'FD007234-A6E5-4C27-BF2C-55252EC35DC2',
		'AC839BC2-2BBD-4710-9A52-933021020971',
		'99FF1CB4-59C3-4CB1-B8D2-A188C2B41693'
	)

-- Disable Further Education

UPDATE
	dbo.Offering
SET
	enabled = 0
WHERE
	id IN
	(
		'4444912F-8E38-41FB-A461-EA8524F4D462',
		'8F25EF13-D27A-4213-B832-1372DF92F8F0',
		'293F4C53-71A8-4B30-9D5D-171D514ECC20',
		'B542A8D1-A672-4109-977A-9936CDA40D04',
		'ECEAF673-B45C-4467-874D-C5FC30DC5786',
		'9F858256-E438-46DD-963E-C6B01F1CC695',
		'FDAF091E-EB30-4A87-A857-319E8EE8233B',
		'4D617CC8-0AFF-497E-B868-97A89C0C8FDB',
		'7D7BF861-C2B3-4D50-AC76-D849D87717DD',
		'C6F36E34-4C42-4B2C-BF56-B982B7F70075',
		'DEAD0DD2-7F1D-4FD8-B518-2C436C5B24FC',
		'AC839BC2-2BBD-4710-9A52-933021020971',
		'99FF1CB4-59C3-4CB1-B8D2-A188C2B41693',
		'FD007234-A6E5-4C27-BF2C-55252EC35DC2'
	)

-- Add criteria

EXEC dbo.CreateOfferingCriteria '8504E270-3667-45da-B25D-1ED643244ABE', '03C889FB-CB1E-48C7-9269-62B33AAE6037', 'Keywords', 'Bachelor AND (Finance OR Accounting OR Banking)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL