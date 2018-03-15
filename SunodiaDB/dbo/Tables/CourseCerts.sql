CREATE TABLE [dbo].[CourseCerts] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [CertId]   INT NOT NULL,
    [CourseId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CourseCerts_Certificates] FOREIGN KEY ([CertId]) REFERENCES [dbo].[Certificates] ([Id]),
    CONSTRAINT [FK_CourseCerts_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id])
);

