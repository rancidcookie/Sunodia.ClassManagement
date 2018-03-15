CREATE TABLE [dbo].[People] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [LastName]  VARCHAR (100) NULL,
    [FirstName] VARCHAR (100) NULL,
    [Email]     VARCHAR (100) NULL,
    [Phone]     VARCHAR (50)  NULL,
    [Street]    VARCHAR (50)  NULL,
    [Address2]  VARCHAR (50)  NULL,
    [City]      VARCHAR (50)  NULL,
    [State]     VARCHAR (50)  NULL,
    [Zip]       VARCHAR (50)  NULL,
    [Phone2]    VARCHAR (50)  NULL,
    [Comments]  VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

