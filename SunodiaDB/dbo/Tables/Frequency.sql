CREATE TABLE [dbo].[Frequency] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Frequency] VARCHAR (50) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

