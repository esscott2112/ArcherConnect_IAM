/****** Script for SelectTopNRows command from SSMS  ******/
create view vw_OrgPerson as 
SELECT p.id as PersonID, p.FirstName, p.LastName, p.Email, ota.id as OrgTypeAssignmentID, op.Id as OrgPersonID,  o.OrganizationName, ot.Name as OrganizationType
  FROM [ArcherConnectIAM].[dbo].[OrgPerson] op
  join SystemPerson p on op.Person = p.id
  join OrgTypeAssignment ota on ota.Id = op.OrgTypeAssignment
  join Organization o on o.id = ota.Organization
  join OrgType ot on ot.id = ota.OrganizationType