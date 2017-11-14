CREATE TABLE [dbo].[EventTransactionComment] (
    [Id]                 INT           IDENTITY (1, 1) NOT NULL,
    [EventTransactionId] INT           NOT NULL,
    [Comment]            VARCHAR (MAX) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventTransactionComment_EventTransaction] FOREIGN KEY ([EventTransactionId]) REFERENCES [dbo].[EventTransaction] ([Id])
);

