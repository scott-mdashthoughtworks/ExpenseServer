/****** Script for SelectTopNRows command from SSMS  ******/
create proc ListExpPersonalCategories
  @OwnerId uniqueidentifier
as
begin
SELECT [id]
      ,[Name]
      ,[SortOrder]
  FROM [dbo].[ExpPersonalCategories]
  where ownerid = @ownerid
  order by sortorder, name
end