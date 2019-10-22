

CREATE view [dbo].[vw_AvailableModulePermission] as
select me.*, sop.PermissionId, sp.Name as PermissionName, sop.id as SystemObjectPermissionId
from vw_ModuleElement me join SystemObjectPermission sop on me.ModuleElementObjectID = sop.ObjectId
join SystemPermission sp on sp.id = sop.PermissionId