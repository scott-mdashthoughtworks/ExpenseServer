

create procedure  dbo.DeleteExpenseRecord
	 @id int
as 
begin
delete [dbo].[ExpenseRecord] where   id = @id
end
