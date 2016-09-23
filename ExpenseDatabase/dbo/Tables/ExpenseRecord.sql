CREATE TABLE [dbo].[ExpenseRecord] (
    [id]                 INT              IDENTITY (1, 1) NOT NULL,
    [OwnerId]            UNIQUEIDENTIFIER NOT NULL,
    [ExpDate]            DATE             NOT NULL,
    [Description]        NVARCHAR (500)   NOT NULL,
    [Amount]             MONEY            NOT NULL,
    [Posted]             DATE             NULL,
    [PersonalCategoryId] INT              NULL,
    [CategoriesId]       INT              NULL,
    CONSTRAINT [PK_ExpenseRecord] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_ExpenseRecord_ExpCategories] FOREIGN KEY ([CategoriesId]) REFERENCES [dbo].[ExpCategories] ([id]),
    CONSTRAINT [FK_ExpenseRecord_ExpPersonalCategories] FOREIGN KEY ([PersonalCategoryId]) REFERENCES [dbo].[ExpPersonalCategories] ([id]),
    CONSTRAINT [FK_ExpenseRecord_ExpUsers] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[ExpUsers] ([id])
);

