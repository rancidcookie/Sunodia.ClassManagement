CREATE TABLE [dbo].[PaymentMethods] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [PaymentMethod] VARCHAR (100)   NOT NULL,
    [Percentage]    DECIMAL (10, 3) DEFAULT ((0)) NOT NULL,
    [PlusFee]       DECIMAL (10, 3) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

