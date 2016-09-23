create procedure listExpensesForUserAndDateRange
@ownerid uniqueidentifier,
@date1 date,
@date2 date
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
    and expdate >= @date1 
	and expdate <= @date2
end

