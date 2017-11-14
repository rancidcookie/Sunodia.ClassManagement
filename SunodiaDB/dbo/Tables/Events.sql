﻿CREATE TABLE [dbo].[Events] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [CourseId]         INT           NULL,
    [CourseDate]       DATETIME      NULL,
    [MaterialCost]     MONEY         NULL,
    [CourseFormatId]   INT           NULL,
    [Description]      VARCHAR (100) NULL,
    [BookCost]         MONEY         NULL,
    [BookId]           INT           NULL,
    [RegistrationDate] DATETIME      NULL,
    [QuickBooksDate]   DATETIME      NULL,
    [Complete]         BIT           DEFAULT ((0)) NOT NULL,
    [RegistrationCost] MONEY         NULL,
    [EndDate]          DATE          NULL,
    [StartDate]        DATE          NULL,
    [Frequency]        VARCHAR (50)  NULL,
    [CourseType]       VARCHAR (50)  NULL,
    [NickName]         VARCHAR (50)  NULL,
    [Active]           BIT           DEFAULT ((1)) NOT NULL,
    [FacilitatorId]    INT           NULL,
    [FrequencyId]      INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Classes_ToBooks] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    CONSTRAINT [FK_Classes_ToCourseFormat] FOREIGN KEY ([CourseFormatId]) REFERENCES [dbo].[CourseFormats] ([Id]),
    CONSTRAINT [FK_Classes_ToCourses] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]),
    CONSTRAINT [FK_Events_ToFacilitator] FOREIGN KEY ([FacilitatorId]) REFERENCES [dbo].[People] ([Id]),
    CONSTRAINT [FK_Events_ToFrequency] FOREIGN KEY ([FrequencyId]) REFERENCES [dbo].[Frequency] ([Id])
);

