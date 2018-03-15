CREATE TABLE [dbo].[QBAccounts] (
    [Id]          INT           NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    [QBAccount]   VARCHAR (10)  NULL,
    [IsCredit]    BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

