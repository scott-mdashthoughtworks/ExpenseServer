
create proc summarizeExp 
@id uniqueidentifier
as 
begin 
select  month(a.expdate) as 'Month',sum(a.[Amount]) as 'TotalAmt', count(a.amount) as "no. of trans",  b.name  from [dbo].[ExpenseRecord] a
join [dbo].[ExpCategories] b  on a.[CategoriesId] = b.id 
 group by month(expdate), b.name, a.ownerid having a.ownerid =   @id
end
