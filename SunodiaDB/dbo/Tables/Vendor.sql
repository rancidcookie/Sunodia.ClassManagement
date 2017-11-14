CREATE TABLE [dbo].[Vendor] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [VendorName] VARCHAR (50) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

