CREATE TABLE [dbo].[EventTransaction] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [EventId]               INT           NOT NULL,
    [Amount]                MONEY         DEFAULT ((0)) NOT NULL,
    [FHICredit]             BIT           DEFAULT ((0)) NOT NULL,
    [Description]           VARCHAR (100) DEFAULT ('') NOT NULL,
    [DateAdded]             DATETIME      DEFAULT (getdate()) NOT NULL,
    [TransactionCategoryId] INT           NULL,
    [PaymentMethodId]       INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventTransaction_ToEvent] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    CONSTRAINT [FK_EventTransaction_ToPaymentMethod] FOREIGN KEY ([PaymentMethodId]) REFERENCES [dbo].[PaymentMethods] ([Id]),
    CONSTRAINT [FK_EventTransaction_ToTransactionCategory] FOREIGN KEY ([TransactionCategoryId]) REFERENCES [dbo].[TransactionCategory] ([Id])
);

