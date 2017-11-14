CREATE TABLE [dbo].[EventVenues] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [VenueId] INT NOT NULL,
    [EventId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventVenues_ToEvents] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id]),
    CONSTRAINT [FK_EventVenues_ToVenue] FOREIGN KEY ([VenueId]) REFERENCES [dbo].[Venue] ([Id])
);

