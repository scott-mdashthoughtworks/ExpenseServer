create proc DeleteExpPersonalCategories 
 @id int
as 
begin 
DELETE FROM [dbo].[ExpPersonalCategories]
      WHERE  id = @id
end 
