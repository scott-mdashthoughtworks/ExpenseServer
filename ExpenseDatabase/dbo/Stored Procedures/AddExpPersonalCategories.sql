/****** Script for SelectTopNRows command from SSMS  ******/
create proc AddExpPersonalCategories
  @OwnerId uniqueidentifier,
  @name nvarchar(20),
  @sortorder int
as
begin
insert into  [dbo].[ExpPersonalCategories]
([Name] ,[SortOrder], ownerid)
values
(@name, @sortorder, @ownerid) 
end