CREATE TABLE [dbo].[ExpPersonalCategories] (
    [id]        INT              IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (20)    NOT NULL,
    [OwnerId]   UNIQUEIDENTIFIER NULL,
    [SortOrder] INT              CONSTRAINT [DF_ExpPersonalCategories_SortOrder] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_ExpPersonalCategories] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_ExpPersonalCategories_ExpUsers] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[ExpUsers] ([id]) ON DELETE CASCADE
);

