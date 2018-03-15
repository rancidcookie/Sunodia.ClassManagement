CREATE TABLE [dbo].[EventTransactionStudent] (
    [Id]                 INT IDENTITY (1, 1) NOT NULL,
    [EventTransactionId] INT NOT NULL,
    [StudentId]          INT NOT NULL,
    [RegistrationTypeId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventTransactionStudent_EventTransaction] FOREIGN KEY ([EventTransactionId]) REFERENCES [dbo].[EventTransaction] ([Id]),
    CONSTRAINT [FK_EventTransactionStudent_People] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[People] ([Id]),
    CONSTRAINT [FK_EventTransactionStudent_ToRegistrationType] FOREIGN KEY ([RegistrationTypeId]) REFERENCES [dbo].[RegistrationTypes] ([Id])
);

