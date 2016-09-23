/****** Script for SelectTopNRows command from SSMS  ******/

CREATE proc GetUserByEmail
 @email nvarchar(max)
as
begin
SELECT [id]
      ,[email]
      ,[password]
      ,[FirstName]
      ,[LastName]
      ,[OrgId]
  FROM [dbo].[ExpUsers] where @email = email
  end