CREATE TABLE [dbo].[EventCost2Student] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [EventId]         INT           NOT NULL,
    [CostDescription] VARCHAR (100) DEFAULT ('') NOT NULL,
    [Cost]            MONEY         DEFAULT ((0)) NOT NULL,
    [Required]        BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventCost2Student_ToEvent] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id])
);

