CREATE TABLE [dbo].[StudentCosts] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Description]   VARCHAR (100) NOT NULL,
    [DefaultAmount] MONEY         NULL,
    CONSTRAINT [PK_StudentCosts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

