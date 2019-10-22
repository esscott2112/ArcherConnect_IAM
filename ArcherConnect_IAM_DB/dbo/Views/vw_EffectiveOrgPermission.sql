

 CREATE view [dbo].[vw_EffectiveOrgPermission] as 
select ota.OrgTypeAssignmentId, op.id as OrgPermissionId, amp.SystemObjectPermissionId, ota.OrganizationName, ota.OrganizationType, amp.ElementName, amp.ModuleName, amp.PermissionName
from OrgPermission op 
join vw_OrgTypeAssignment ota on op.OrgTypeAssignmentId = ota.OrgTypeAssignmentId
join vw_AvailableModulePermission amp on op.SystemObjectPermissionId = amp.[SystemObjectPermissionId]