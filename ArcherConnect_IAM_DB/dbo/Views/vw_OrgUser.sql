  create view vw_OrgUser as 
  select op.*, su.Username, su.id as SystemUserId, su.RecoveryEmail from vw_OrgPerson op
  join SystemUser su on su.SystemPersonId = op.PersonID