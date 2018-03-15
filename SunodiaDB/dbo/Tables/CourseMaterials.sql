CREATE TABLE [dbo].[CourseMaterials] (
    [Id]              INT          IDENTITY (1, 1) NOT NULL,
    [CourseId]        INT          NOT NULL,
    [MaterialName]    VARCHAR (50) DEFAULT ('') NOT NULL,
    [CostToStudent]   MONEY        DEFAULT ((0)) NOT NULL,
    [CostToOrg]       MONEY        DEFAULT ((0)) NOT NULL,
    [PurchaseOptions] VARCHAR (50) NULL,
    [VendorId]        INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CourseMaterials_ToCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]),
    CONSTRAINT [FK_CourseMaterials_ToVendor] FOREIGN KEY ([VendorId]) REFERENCES [dbo].[Vendor] ([Id])
);

