CREATE TABLE [dbo].[MiscTransactions] (
    [Id]              INT      IDENTITY (1, 1) NOT NULL,
    [ClassId]         INT      NOT NULL,
    [PayerId]         INT      NULL,
    [Paid]            MONEY    NULL,
    [QBDate]          DATETIME NULL,
    [PaymentTypeId]   INT      NULL,
    [QBAccount]       INT      NULL,
    [TransactionDate] DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClassAttendees_ToClasses] FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Events] ([Id]),
    CONSTRAINT [FK_ClassAttendees_ToPayer] FOREIGN KEY ([PayerId]) REFERENCES [dbo].[People] ([Id]),
    CONSTRAINT [FK_ClassAttendees_ToPaymentType] FOREIGN KEY ([PaymentTypeId]) REFERENCES [dbo].[PaymentMethods] ([Id]),
    CONSTRAINT [FK_MiscTransactions_ToClasses] FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Events] ([Id]),
    CONSTRAINT [FK_MiscTransactions_ToPayer] FOREIGN KEY ([PayerId]) REFERENCES [dbo].[People] ([Id]),
    CONSTRAINT [FK_MiscTransactions_ToPaymentType] FOREIGN KEY ([PaymentTypeId]) REFERENCES [dbo].[PaymentMethods] ([Id]),
    CONSTRAINT [FK_MiscTransactions_ToQBAccounts] FOREIGN KEY ([QBAccount]) REFERENCES [dbo].[QBAccounts] ([Id])
);

