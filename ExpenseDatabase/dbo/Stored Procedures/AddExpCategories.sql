/****** Script for SelectTopNRows command from SSMS  ******/
CREATE proc AddExpCategories
  @name nvarchar(20),
  @sortorder int
as
begin
insert into  [dbo].[ExpCategories]
([Name] ,[SortOrder])
values
(@name, @sortorder) 
end