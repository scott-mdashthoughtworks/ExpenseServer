create proc addUser	
            @id  uniqueidentifier
           ,@email nvarchar(max)
           ,@password nvarchar(256)
           ,@FirstName nvarchar(150)
           ,@LastName nvarchar(150)
           ,@OrgId int 
as 
begin 
INSERT INTO [dbo].[ExpUsers]
           ([id]
           ,[email]
           ,[password]
           ,[FirstName]
           ,[LastName]
           ,[OrgId])
     VALUES
           ( 
		   @id    		  ,
		   @email 		  ,
		   @password 	  ,
		   @FirstName	  ,
		   @LastName 	  ,
		   @OrgId 
		   )

exec [dbo].[AddExpPersonalCategories] @id, 'Default', 1  
end
