CREATE TABLE [dbo].[BooksPerClass] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [BookId]  INT          NOT NULL,
    [ClassId] INT          NOT NULL,
    [Charge]  DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

