CREATE TABLE [dbo].[PersonGroups] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [GroupId]  INT NOT NULL,
    [PersonId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PersonGroups_ToGroups] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]),
    CONSTRAINT [FK_PersonGroups_ToPeople] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[People] ([Id]) ON DELETE CASCADE
);

