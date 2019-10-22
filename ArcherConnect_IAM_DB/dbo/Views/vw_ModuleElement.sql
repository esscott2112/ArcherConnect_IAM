
CREATE view [dbo].[vw_ModuleElement] as
select me.ObjectId as ModuleElementObjectID,  e.name as elementName, m.Name as ModuleName
from [UI Module Element] me left join [UI Element] e on me.ElementId = e.Id
join [UI Module] m on me.ModuleId = m.Id