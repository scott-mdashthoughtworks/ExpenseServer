
CREATE PROCEDURE ListUserDetails 
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier  
AS
BEGIN
	 select id, email, password, FirstName, LastName, OrgId 
	    from [dbo].[ExpUsers]
		where id = @id

	 select   id, Name, OwnerId, SortOrder   from       [dbo].[ExpPersonalCategories] 
		where ownerid = @id
		order by sortorder 

     select id, OwnerId, ExpDate, Description, Amount, Posted, PersonalCategoryId, CategoriesId 
		from [dbo].[ExpenseRecord]
		where ownerid = @id 
		order by expdate 
END
