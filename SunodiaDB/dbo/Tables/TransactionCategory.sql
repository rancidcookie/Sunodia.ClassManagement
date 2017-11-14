CREATE TABLE [dbo].[TransactionCategory] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Category] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

