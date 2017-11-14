CREATE TABLE [dbo].[Certificates] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [CertName]        VARCHAR (50)  NOT NULL,
    [CertDescription] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

