CREATE TABLE [dbo].[Venue] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NOT NULL,
    [Address1]    VARCHAR (255) NULL,
    [Address2]    VARCHAR (255) NULL,
    [City]        VARCHAR (100) NULL,
    [State]       VARCHAR (3)   NULL,
    [Zip]         VARCHAR (10)  NULL,
    [VenueTypeId] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Venue_VenueType] FOREIGN KEY ([VenueTypeId]) REFERENCES [dbo].[VenueType] ([Id])
);

