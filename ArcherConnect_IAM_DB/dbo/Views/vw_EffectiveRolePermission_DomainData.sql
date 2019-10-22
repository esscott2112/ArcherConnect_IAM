



 CREATE view [dbo].[vw_EffectiveRolePermission_DomainData] as 
 select sr.Id as RoleId, sr.RoleName, srp.id as SystemRolePermissionId, srp.systemObjectPermissionID, amp.DataType, amp.PermissionName, sop.objectId, dd.name 
 from SystemRole sr join SystemRolePermission srp on sr.Id = srp.RoleId
join vw_availableDomainDataPermission amp on srp.SystemObjectPermissionId = amp.[SystemObjectPermissionId]
join SystemObjectPermission sop on sop.id = srp.systemObjectPermissionID
join vw_DomainData dd on sop.objectId = dd.objectId