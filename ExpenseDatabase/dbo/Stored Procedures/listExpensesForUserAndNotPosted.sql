create procedure listExpensesForUserAndNotPosted
@ownerid uniqueidentifier 
as
begin 
SELECT [id]
      ,[OwnerId]
      ,[ExpDate]
      ,[Description]
      ,[Amount]
      ,[Posted]
      ,[PersonalCategoryId]
      ,[CategoriesId]
  FROM [dbo].[ExpenseRecord]
  where ownerid = @ownerid 
    and posted is null 
end

