CREATE TABLE [dbo].[CourseFormats] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Format]    VARCHAR (50) NOT NULL,
    [AccountId] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CourseFormats_ToQBAccounts] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[QBAccounts] ([Id])
);

