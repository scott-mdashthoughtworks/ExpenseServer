create proc DeleteExpCategories 
 @id int
as 
begin 
DELETE FROM [dbo].[ExpCategories]
      WHERE  id = @id
end 
