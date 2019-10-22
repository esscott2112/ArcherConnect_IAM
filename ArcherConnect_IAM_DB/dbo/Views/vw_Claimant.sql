  create view vw_Claimant as
  select c.id as ClaimantId, c.ObjectID, c.domainpersonid, dp.First_Name, dp.Last_Name, dp.ssn
  from Claimant c join DomainPerson dp on c.DomainPersonId = dp.id