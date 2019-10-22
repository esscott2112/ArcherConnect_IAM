 create view vw_SystemObjectPermission as
 SELECT TOP (1000) me.[Id] as ModuleElementId
      ,me.[ObjectID] as ModuleElementObjectId
      ,[ModuleId]
      ,[ElementId], sop.id SystemObjectPermissionID, p.id as PermissionId, p.Name as PermissionName
  FROM [ArcherConnectIAM].[dbo].[UI Module Element] me
  left join SystemObjectPermission sop on me.ObjectId = sop.ObjectId
  left join SystemPermission p on sop.PermissionID = p.id