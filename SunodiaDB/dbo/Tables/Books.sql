CREATE TABLE [dbo].[Books] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (100) NOT NULL,
    [Description] VARCHAR (100) NULL,
    [Cost]        DECIMAL (18)  NULL,
    [Vendor]      VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

