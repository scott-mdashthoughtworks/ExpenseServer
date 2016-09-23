create proc updateUser	
            @id  uniqueidentifier
           ,@email nvarchar(max)
           ,@password nvarchar(256)
           ,@FirstName nvarchar(150)
           ,@LastName nvarchar(150)
           ,@OrgId int 
as 
begin 
update  [dbo].[ExpUsers] 
  set  
    [email]         =	 @email, 		
    [password]		=	 @password ,
    [FirstName]		=	 @FirstName,
    [LastName]		=	 @LastName ,
    [OrgId] 		=	 @OrgId 
  where @id = id
 
end
