create procedure dbo.AddExpenseRecord
	 @ownerId uniqueidentifier,
	 @expDate date,
	 @desc nvarchar(500),
	 @amt  money,
	 @posted date,
	 @PersonalCategoryId int,
	 @CategoryId int 
 as 
 begin
INSERT INTO [dbo].[ExpenseRecord]
           ([OwnerId]
           ,[ExpDate]
           ,[Description]
           ,[Amount]
           ,[Posted]
           ,[PersonalCategoryId]
           ,[CategoriesId])
     VALUES
           (@ownerId 
           ,@expDate
           , @desc
           ,@amt
           ,@posted 
           ,@PersonalCategoryId
           , @CategoryId)
end


