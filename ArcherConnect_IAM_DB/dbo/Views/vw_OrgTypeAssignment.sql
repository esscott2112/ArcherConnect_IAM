
  CREATE view [dbo].[vw_OrgTypeAssignment] as 
  select o.OrganizationName, ot.Name as OrganizationType, ota.id as OrgTypeAssignmentId  from OrgTypeAssignment ota 
  join OrgType ot on ot.Id = ota.OrganizationType 
  join Organization o on o.Id = ota.Organization