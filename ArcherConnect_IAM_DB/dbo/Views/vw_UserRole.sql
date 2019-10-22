
CREATE view  vw_UserRole as
select sur.id as systemuserRoleID, su.Username, su.id as UserId, sr.RoleName, sr.Id as RoleId
from systemUserRole sur join
 SystemUser su on sur.UserId = su.id
 join SystemRole sr on sur.RoleId = sr.Id