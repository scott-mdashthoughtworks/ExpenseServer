create procedure dbo.UpdateExpenseRecord
	 @id int,
	 @ownerId uniqueidentifier,
	 @expDate date,
	 @desc nvarchar(500),
	 @amt  money,
	 @posted date,
	 @PersonalCategoryId int,
	 @CategoryId int 
 as 
 begin
UPDATE [dbo].[ExpenseRecord]
   SET [OwnerId] =  @ownerId
      ,[ExpDate] = @expDate
      ,[Description] = @desc 
      ,[Amount] = @amt
      ,[Posted] = @posted
      ,[PersonalCategoryId] = @PersonalCategoryId
      ,[CategoriesId] = @CategoryId



 WHERE   id = @id
 end
