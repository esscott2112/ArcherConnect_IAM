

CREATE view [dbo].[vw_DomainData] as
select ObjectId, 'Case' as DataType, [Name] from [Case]
union
select ObjectId, 'Claimant' as DataType, First_Name +' '+Last_Name as 'Name' from vw_Claimant
union
select ObjectId, 'Bankruptcy' as DataType, [Name]  from Bankruptcy