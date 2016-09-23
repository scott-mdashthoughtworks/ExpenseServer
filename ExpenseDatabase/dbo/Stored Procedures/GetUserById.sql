/****** Script for SelectTopNRows command from SSMS  ******/

create proc GetUserById
 @id uniqueidentifier
as
begin
SELECT [id]
      ,[email]
      ,[password]
      ,[FirstName]
      ,[LastName]
      ,[OrgId]
  FROM [dbo].[ExpUsers] 
  where id = @id
  end