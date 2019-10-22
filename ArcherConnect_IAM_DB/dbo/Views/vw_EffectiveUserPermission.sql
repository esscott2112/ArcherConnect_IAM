
CREATE view [dbo].[vw_EffectiveUserPermission] as
select ur.userid as SystemUserId, ur.Username, erp.ElementName, erp.ModuleName, erp.PermissionName
, 'RoleBase' as PermissionType
from vw_EffectiveRolePermission erp join vw_UserRole ur
on erp.RoleId = ur.RoleId
union 
  select u.SystemUserId as SystemUserId
  ,u.username, eop.ElementName, eop.ModuleName, eop.PermissionName
  ,'OrgBased' as PermissionType 
from vw_EffectiveOrgPermission eop join vw_OrgUser u
on eop.OrgTypeAssignmentId = u.OrgTypeAssignmentId