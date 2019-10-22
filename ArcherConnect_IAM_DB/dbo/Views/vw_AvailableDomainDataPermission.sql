
CREATE view [dbo].[vw_AvailableDomainDataPermission] as
select dd.*, sop.PermissionId, sp.Name as PermissionName, sop.id as SystemObjectPermissionId
from vw_DomainData dd join SystemObjectPermission sop on dd.ObjectId = sop.ObjectId
join SystemPermission sp on sp.id = sop.PermissionId