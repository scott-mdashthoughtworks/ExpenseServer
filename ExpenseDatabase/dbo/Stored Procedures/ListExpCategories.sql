/****** Script for SelectTopNRows command from SSMS  ******/
create proc ListExpCategories
as
begin
SELECT [id]
      ,[Name]
      ,[SortOrder]
  FROM [dbo].[ExpCategories]
  order by sortorder, name
end