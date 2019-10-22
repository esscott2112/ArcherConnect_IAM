 CREATE view vw_EffectiveRolePermission as 
 select sr.Id as RoleId, sr.RoleName, srp.id as SystemRolePermissionId, srp.systemObjectPermissionID, amp.ElementName, amp.ModuleName, amp.PermissionName 
 from SystemRole sr join SystemRolePermission srp on sr.Id = srp.RoleId
join vw_AvailableModulePermission amp on srp.SystemObjectPermissionId = amp.[SystemObjectPermissionId]