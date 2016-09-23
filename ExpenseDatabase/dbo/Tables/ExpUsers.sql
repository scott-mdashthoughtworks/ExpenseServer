CREATE TABLE [dbo].[ExpUsers] (
    [id]        UNIQUEIDENTIFIER NOT NULL,
    [email]     NVARCHAR (500)   NULL,
    [password]  NVARCHAR (256)   NULL,
    [FirstName] NVARCHAR (150)   NULL,
    [LastName]  NVARCHAR (150)   NULL,
    [OrgId]     INT              NULL,
    CONSTRAINT [PK_ExpUsers] PRIMARY KEY CLUSTERED ([id] ASC)
);

