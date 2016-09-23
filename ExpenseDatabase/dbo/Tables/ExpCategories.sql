CREATE TABLE [dbo].[ExpCategories] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NULL,
    [SortOrder] INT           CONSTRAINT [DF_ExpCategories_SortOrder] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_ExpCategories] PRIMARY KEY CLUSTERED ([id] ASC)
);

