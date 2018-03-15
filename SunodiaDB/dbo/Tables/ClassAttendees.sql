CREATE TABLE [dbo].[ClassAttendees] (
    [Id]                 INT      IDENTITY (1, 1) NOT NULL,
    [ClassId]            INT      NOT NULL,
    [PersonId]           INT      NOT NULL,
    [PayerId]            INT      NULL,
    [Paid]               MONEY    NULL,
    [RegistrationTypeId] INT      NULL,
    [Attending]          BIT      DEFAULT ((0)) NOT NULL,
    [QBDate]             DATETIME NULL,
    [PaymentTypeId]      INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClassAttendees_ToPeople] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[People] ([Id]),
    CONSTRAINT [FK_ClassAttendees_ToRegistrationTypes] FOREIGN KEY ([RegistrationTypeId]) REFERENCES [dbo].[RegistrationTypes] ([Id])
);

