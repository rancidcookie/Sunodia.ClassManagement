CREATE TABLE [dbo].[Courses] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [CourseName]   VARCHAR (100) NOT NULL,
    [CourseNumber] VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Cert]         VARCHAR (50)  NULL,
    [DateAdded]    DATE          DEFAULT (getdate()) NOT NULL,
    [Active]       BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

