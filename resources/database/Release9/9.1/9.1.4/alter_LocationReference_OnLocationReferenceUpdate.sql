IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[OnLocationReferenceUpdate]'))
DROP TRIGGER [dbo].[OnLocationReferenceUpdate]
GO
