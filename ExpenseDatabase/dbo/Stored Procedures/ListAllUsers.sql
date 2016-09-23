/****** Script for SelectTopNRows command from SSMS  ******/

create proc ListAllUsers
as
begin
SELECT [id]
      ,[email]
      ,[password]
      ,[FirstName]
      ,[LastName]
      ,[OrgId]
  FROM [dbo].[ExpUsers] 
  end