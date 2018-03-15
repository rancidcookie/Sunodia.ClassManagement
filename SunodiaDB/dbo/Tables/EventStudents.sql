CREATE TABLE [dbo].[EventStudents] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [StudentId] INT      NOT NULL,
    [EventId]   INT      NOT NULL,
    [DateAdded] DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventStudents_Events] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    CONSTRAINT [FK_EventStudents_People] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[People] ([Id])
);

