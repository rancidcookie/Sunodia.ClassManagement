
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/09/2017 18:44:50
-- Generated from EDMX file: D:\MyDocs\Git\Sunodia.ClassManagement\Sunodia.ClassManagement\Models\sunodiaData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SunodiaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClassAttendees_ToClasses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_ClassAttendees_ToClasses];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassAttendees_ToPayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_ClassAttendees_ToPayer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassAttendees_ToPaymentType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_ClassAttendees_ToPaymentType];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassAttendees_ToPeople]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassAttendees] DROP CONSTRAINT [FK_ClassAttendees_ToPeople];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassAttendees_ToRegistrationTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassAttendees] DROP CONSTRAINT [FK_ClassAttendees_ToRegistrationTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Classes_ToBooks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Classes_ToBooks];
GO
IF OBJECT_ID(N'[dbo].[FK_Classes_ToCourseFormat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Classes_ToCourseFormat];
GO
IF OBJECT_ID(N'[dbo].[FK_Classes_ToCourses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Classes_ToCourses];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseCerts_Certificates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseCerts] DROP CONSTRAINT [FK_CourseCerts_Certificates];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseCerts_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseCerts] DROP CONSTRAINT [FK_CourseCerts_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseFormats_ToQBAccounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseFormats] DROP CONSTRAINT [FK_CourseFormats_ToQBAccounts];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseMaterials_ToCourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseMaterials] DROP CONSTRAINT [FK_CourseMaterials_ToCourse];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseMaterials_ToVendor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseMaterials] DROP CONSTRAINT [FK_CourseMaterials_ToVendor];
GO
IF OBJECT_ID(N'[dbo].[FK_EventbriteEvents_ToEvents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventbriteEvents] DROP CONSTRAINT [FK_EventbriteEvents_ToEvents];
GO
IF OBJECT_ID(N'[dbo].[FK_EventCost2Student_ToEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventCost2Student] DROP CONSTRAINT [FK_EventCost2Student_ToEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_Events_ToFacilitator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Events_ToFacilitator];
GO
IF OBJECT_ID(N'[dbo].[FK_Events_ToFrequency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Events_ToFrequency];
GO
IF OBJECT_ID(N'[dbo].[FK_EventStudents_Events]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventStudents] DROP CONSTRAINT [FK_EventStudents_Events];
GO
IF OBJECT_ID(N'[dbo].[FK_EventStudents_People]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventStudents] DROP CONSTRAINT [FK_EventStudents_People];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransaction_ToEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransaction] DROP CONSTRAINT [FK_EventTransaction_ToEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransaction_ToPaymentMethod]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransaction] DROP CONSTRAINT [FK_EventTransaction_ToPaymentMethod];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransaction_ToTransactionCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransaction] DROP CONSTRAINT [FK_EventTransaction_ToTransactionCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransactionComment_EventTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransactionComment] DROP CONSTRAINT [FK_EventTransactionComment_EventTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransactionStudent_EventTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransactionStudent] DROP CONSTRAINT [FK_EventTransactionStudent_EventTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransactionStudent_People]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransactionStudent] DROP CONSTRAINT [FK_EventTransactionStudent_People];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransactionStudent_ToRegistrationType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventTransactionStudent] DROP CONSTRAINT [FK_EventTransactionStudent_ToRegistrationType];
GO
IF OBJECT_ID(N'[dbo].[FK_EventVenues_ToEvents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventVenues] DROP CONSTRAINT [FK_EventVenues_ToEvents];
GO
IF OBJECT_ID(N'[dbo].[FK_EventVenues_ToVenue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventVenues] DROP CONSTRAINT [FK_EventVenues_ToVenue];
GO
IF OBJECT_ID(N'[dbo].[FK_MiscTransactions_ToClasses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_MiscTransactions_ToClasses];
GO
IF OBJECT_ID(N'[dbo].[FK_MiscTransactions_ToPayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_MiscTransactions_ToPayer];
GO
IF OBJECT_ID(N'[dbo].[FK_MiscTransactions_ToPaymentType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_MiscTransactions_ToPaymentType];
GO
IF OBJECT_ID(N'[dbo].[FK_MiscTransactions_ToQBAccounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MiscTransactions] DROP CONSTRAINT [FK_MiscTransactions_ToQBAccounts];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonGroups_ToGroups]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonGroups] DROP CONSTRAINT [FK_PersonGroups_ToGroups];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonGroups_ToPeople]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonGroups] DROP CONSTRAINT [FK_PersonGroups_ToPeople];
GO
IF OBJECT_ID(N'[dbo].[FK_Venue_VenueType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venue] DROP CONSTRAINT [FK_Venue_VenueType];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Books]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID(N'[dbo].[BooksPerClass]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BooksPerClass];
GO
IF OBJECT_ID(N'[dbo].[Certificates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Certificates];
GO
IF OBJECT_ID(N'[dbo].[ClassAttendees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClassAttendees];
GO
IF OBJECT_ID(N'[dbo].[CourseCerts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseCerts];
GO
IF OBJECT_ID(N'[dbo].[CourseFormats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseFormats];
GO
IF OBJECT_ID(N'[dbo].[CourseMaterials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseMaterials];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[EventbriteEvents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventbriteEvents];
GO
IF OBJECT_ID(N'[dbo].[EventCost2Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventCost2Student];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[EventStudents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventStudents];
GO
IF OBJECT_ID(N'[dbo].[EventTransaction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventTransaction];
GO
IF OBJECT_ID(N'[dbo].[EventTransactionComment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventTransactionComment];
GO
IF OBJECT_ID(N'[dbo].[EventTransactionStudent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventTransactionStudent];
GO
IF OBJECT_ID(N'[dbo].[EventVenues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventVenues];
GO
IF OBJECT_ID(N'[dbo].[Frequency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Frequency];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[MiscTransactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MiscTransactions];
GO
IF OBJECT_ID(N'[dbo].[PaymentMethods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PaymentMethods];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[PersonGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonGroups];
GO
IF OBJECT_ID(N'[dbo].[QBAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QBAccounts];
GO
IF OBJECT_ID(N'[dbo].[RegistrationTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistrationTypes];
GO
IF OBJECT_ID(N'[dbo].[StudentCosts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentCosts];
GO
IF OBJECT_ID(N'[dbo].[Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table];
GO
IF OBJECT_ID(N'[dbo].[TransactionCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionCategory];
GO
IF OBJECT_ID(N'[dbo].[Vendor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendor];
GO
IF OBJECT_ID(N'[dbo].[Venue]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venue];
GO
IF OBJECT_ID(N'[dbo].[VenueType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VenueType];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwEventTransactions]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwEventTransactions];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwFullPeople]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwFullPeople];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwGroups]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwGroups];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwMiscTotals]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwMiscTotals];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwPaymentExpenses]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwPaymentExpenses];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwRegistrationTotals]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwRegistrationTotals];
GO
IF OBJECT_ID(N'[sunodiaModelStoreContainer].[vwStudentTotals]', 'U') IS NOT NULL
    DROP TABLE [sunodiaModelStoreContainer].[vwStudentTotals];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'QBAccounts'
CREATE TABLE [dbo].[QBAccounts] (
    [Id] int  NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [QBAccount1] varchar(10)  NULL,
    [IsCredit] bit  NOT NULL
);
GO

-- Creating table 'RegistrationTypes'
CREATE TABLE [dbo].[RegistrationTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(100)  NOT NULL
);
GO

-- Creating table 'vwRegistrationTotals'
CREATE TABLE [dbo].[vwRegistrationTotals] (
    [ClassId] int  NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [Total] decimal(19,4)  NULL
);
GO

-- Creating table 'vwStudentTotals'
CREATE TABLE [dbo].[vwStudentTotals] (
    [classid] int  NOT NULL,
    [StudentCount] int  NULL,
    [TotalPaid] decimal(19,4)  NULL
);
GO

-- Creating table 'vwMiscTotals'
CREATE TABLE [dbo].[vwMiscTotals] (
    [ClassId] int  NOT NULL,
    [Description] varchar(100)  NULL,
    [PaymentMethod] varchar(100)  NOT NULL,
    [TotalPaid] decimal(19,4)  NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(100)  NOT NULL,
    [Description] varchar(100)  NULL,
    [Cost] decimal(18,0)  NULL,
    [Vendor] varchar(50)  NULL
);
GO

-- Creating table 'BooksPerClasses'
CREATE TABLE [dbo].[BooksPerClasses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BookId] int  NOT NULL,
    [ClassId] int  NOT NULL,
    [Charge] decimal(18,0)  NULL
);
GO

-- Creating table 'Certificates'
CREATE TABLE [dbo].[Certificates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CertName] varchar(50)  NOT NULL,
    [CertDescription] varchar(100)  NULL
);
GO

-- Creating table 'ClassAttendees'
CREATE TABLE [dbo].[ClassAttendees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassId] int  NOT NULL,
    [PersonId] int  NOT NULL,
    [PayerId] int  NULL,
    [Paid] decimal(19,4)  NULL,
    [RegistrationTypeId] int  NULL,
    [Attending] bit  NOT NULL,
    [QBDate] datetime  NULL,
    [PaymentTypeId] int  NULL
);
GO

-- Creating table 'CourseCerts'
CREATE TABLE [dbo].[CourseCerts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CertId] int  NOT NULL,
    [CourseId] int  NOT NULL
);
GO

-- Creating table 'CourseFormats'
CREATE TABLE [dbo].[CourseFormats] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Format] varchar(50)  NOT NULL,
    [AccountId] int  NULL
);
GO

-- Creating table 'CourseMaterials'
CREATE TABLE [dbo].[CourseMaterials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseId] int  NOT NULL,
    [MaterialName] varchar(50)  NOT NULL,
    [CostToStudent] decimal(19,4)  NOT NULL,
    [CostToOrg] decimal(19,4)  NOT NULL,
    [PurchaseOptions] varchar(50)  NULL,
    [VendorId] int  NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseName] varchar(100)  NOT NULL,
    [CourseNumber] varchar(50)  NOT NULL,
    [Cert] varchar(50)  NULL,
    [DateAdded] datetime  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'EventbriteEvents'
CREATE TABLE [dbo].[EventbriteEvents] (
    [Id] int  NOT NULL,
    [EventbriteEventId] varchar(50)  NULL,
    [EventbriteEventURL] varchar(50)  NULL,
    [EventId] int  NOT NULL
);
GO

-- Creating table 'EventCost2Student'
CREATE TABLE [dbo].[EventCost2Student] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventId] int  NOT NULL,
    [CostDescription] varchar(100)  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [Required] bit  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseId] int  NULL,
    [CourseDate] datetime  NULL,
    [MaterialCost] decimal(19,4)  NULL,
    [CourseFormatId] int  NULL,
    [Description] varchar(100)  NULL,
    [BookCost] decimal(19,4)  NULL,
    [BookId] int  NULL,
    [RegistrationDate] datetime  NULL,
    [QuickBooksDate] datetime  NULL,
    [Complete] bit  NOT NULL,
    [RegistrationCost] decimal(19,4)  NULL,
    [EndDate] datetime  NULL,
    [StartDate] datetime  NULL,
    [Frequency] varchar(50)  NULL,
    [CourseType] varchar(50)  NULL,
    [NickName] varchar(50)  NULL,
    [Active] bit  NOT NULL,
    [FacilitatorId] int  NULL,
    [FrequencyId] int  NULL
);
GO

-- Creating table 'EventStudents'
CREATE TABLE [dbo].[EventStudents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentId] int  NOT NULL,
    [EventId] int  NOT NULL,
    [DateAdded] datetime  NOT NULL
);
GO

-- Creating table 'EventTransactions'
CREATE TABLE [dbo].[EventTransactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventId] int  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL,
    [FHICredit] bit  NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [DateAdded] datetime  NOT NULL,
    [TransactionCategoryId] int  NULL,
    [PaymentMethodId] int  NULL
);
GO

-- Creating table 'EventTransactionComments'
CREATE TABLE [dbo].[EventTransactionComments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventTransactionId] int  NOT NULL,
    [Comment] varchar(max)  NOT NULL
);
GO

-- Creating table 'EventTransactionStudents'
CREATE TABLE [dbo].[EventTransactionStudents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventTransactionId] int  NOT NULL,
    [StudentId] int  NOT NULL,
    [RegistrationTypeId] int  NULL
);
GO

-- Creating table 'EventVenues'
CREATE TABLE [dbo].[EventVenues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VenueId] int  NOT NULL,
    [EventId] int  NOT NULL
);
GO

-- Creating table 'Frequencies'
CREATE TABLE [dbo].[Frequencies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Frequency1] varchar(50)  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupName] varchar(50)  NOT NULL
);
GO

-- Creating table 'MiscTransactions'
CREATE TABLE [dbo].[MiscTransactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassId] int  NOT NULL,
    [PayerId] int  NULL,
    [Paid] decimal(19,4)  NULL,
    [QBDate] datetime  NULL,
    [PaymentTypeId] int  NULL,
    [QBAccount] int  NULL,
    [TransactionDate] datetime  NOT NULL
);
GO

-- Creating table 'PaymentMethods'
CREATE TABLE [dbo].[PaymentMethods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PaymentMethod1] varchar(100)  NOT NULL,
    [Percentage] decimal(10,3)  NOT NULL,
    [PlusFee] decimal(10,3)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] varchar(100)  NULL,
    [FirstName] varchar(100)  NULL,
    [Email] varchar(100)  NULL,
    [Phone] varchar(50)  NULL,
    [Street] varchar(50)  NULL,
    [Address2] varchar(50)  NULL,
    [City] varchar(50)  NULL,
    [State] varchar(50)  NULL,
    [Zip] varchar(50)  NULL,
    [Phone2] varchar(50)  NULL,
    [Comments] varchar(max)  NULL
);
GO

-- Creating table 'PersonGroups'
CREATE TABLE [dbo].[PersonGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupId] int  NOT NULL,
    [PersonId] int  NOT NULL
);
GO

-- Creating table 'StudentCosts'
CREATE TABLE [dbo].[StudentCosts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [DefaultAmount] decimal(19,4)  NULL
);
GO

-- Creating table 'Tables'
CREATE TABLE [dbo].[Tables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VendorName] varchar(50)  NOT NULL
);
GO

-- Creating table 'TransactionCategories'
CREATE TABLE [dbo].[TransactionCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Category] varchar(50)  NOT NULL
);
GO

-- Creating table 'Vendors'
CREATE TABLE [dbo].[Vendors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VendorName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Venues'
CREATE TABLE [dbo].[Venues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [Address1] varchar(255)  NULL,
    [Address2] varchar(255)  NULL,
    [City] varchar(100)  NULL,
    [State] varchar(3)  NULL,
    [Zip] varchar(10)  NULL,
    [VenueTypeId] int  NULL
);
GO

-- Creating table 'VenueTypes'
CREATE TABLE [dbo].[VenueTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(30)  NOT NULL
);
GO

-- Creating table 'vwEventTransactions'
CREATE TABLE [dbo].[vwEventTransactions] (
    [Id] int  NOT NULL,
    [EventId] int  NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL,
    [FHICredit] bit  NOT NULL,
    [DateAdded] datetime  NOT NULL,
    [PaymentMethodId] int  NULL,
    [StudentId] int  NULL,
    [RegistrationTypeId] int  NULL,
    [RegistrationType] varchar(100)  NULL,
    [PaymentMethod] varchar(100)  NULL,
    [CategoryId] int  NULL,
    [Category] varchar(50)  NULL,
    [fee] decimal(35,11)  NULL
);
GO

-- Creating table 'vwFullPeoples'
CREATE TABLE [dbo].[vwFullPeoples] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] varchar(100)  NULL,
    [FirstName] varchar(100)  NULL,
    [Email] varchar(100)  NULL,
    [Phone] varchar(50)  NULL,
    [Street] varchar(50)  NULL,
    [Address2] varchar(50)  NULL,
    [City] varchar(50)  NULL,
    [State] varchar(50)  NULL,
    [Zip] varchar(50)  NULL,
    [Phone2] varchar(50)  NULL,
    [Comments] varchar(max)  NULL,
    [Donor] varchar(50)  NULL,
    [Student] varchar(50)  NULL,
    [Client] varchar(50)  NULL,
    [MinistryPartner] varchar(50)  NULL,
    [MailChimp] varchar(50)  NULL
);
GO

-- Creating table 'vwGroups'
CREATE TABLE [dbo].[vwGroups] (
    [GroupName] varchar(50)  NULL,
    [FullName] varchar(201)  NOT NULL,
    [Id] int  NOT NULL,
    [LastName] varchar(100)  NULL,
    [FirstName] varchar(100)  NULL,
    [Email] varchar(100)  NULL,
    [Phone] varchar(50)  NULL,
    [Street] varchar(50)  NULL,
    [Address2] varchar(50)  NULL,
    [City] varchar(50)  NULL,
    [State] varchar(50)  NULL,
    [Zip] varchar(50)  NULL,
    [Phone2] varchar(50)  NULL,
    [Comments] varchar(max)  NULL
);
GO

-- Creating table 'vwPaymentExpenses'
CREATE TABLE [dbo].[vwPaymentExpenses] (
    [DateAdded] datetime  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL,
    [Description] varchar(100)  NOT NULL,
    [PaymentMethod] varchar(100)  NOT NULL,
    [Percentage] decimal(10,3)  NOT NULL,
    [PlusFee] decimal(10,3)  NOT NULL,
    [fee] decimal(35,11)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'QBAccounts'
ALTER TABLE [dbo].[QBAccounts]
ADD CONSTRAINT [PK_QBAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RegistrationTypes'
ALTER TABLE [dbo].[RegistrationTypes]
ADD CONSTRAINT [PK_RegistrationTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ClassId], [Description] in table 'vwRegistrationTotals'
ALTER TABLE [dbo].[vwRegistrationTotals]
ADD CONSTRAINT [PK_vwRegistrationTotals]
    PRIMARY KEY CLUSTERED ([ClassId], [Description] ASC);
GO

-- Creating primary key on [classid] in table 'vwStudentTotals'
ALTER TABLE [dbo].[vwStudentTotals]
ADD CONSTRAINT [PK_vwStudentTotals]
    PRIMARY KEY CLUSTERED ([classid] ASC);
GO

-- Creating primary key on [ClassId], [PaymentMethod] in table 'vwMiscTotals'
ALTER TABLE [dbo].[vwMiscTotals]
ADD CONSTRAINT [PK_vwMiscTotals]
    PRIMARY KEY CLUSTERED ([ClassId], [PaymentMethod] ASC);
GO

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BooksPerClasses'
ALTER TABLE [dbo].[BooksPerClasses]
ADD CONSTRAINT [PK_BooksPerClasses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Certificates'
ALTER TABLE [dbo].[Certificates]
ADD CONSTRAINT [PK_Certificates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClassAttendees'
ALTER TABLE [dbo].[ClassAttendees]
ADD CONSTRAINT [PK_ClassAttendees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseCerts'
ALTER TABLE [dbo].[CourseCerts]
ADD CONSTRAINT [PK_CourseCerts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseFormats'
ALTER TABLE [dbo].[CourseFormats]
ADD CONSTRAINT [PK_CourseFormats]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseMaterials'
ALTER TABLE [dbo].[CourseMaterials]
ADD CONSTRAINT [PK_CourseMaterials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventbriteEvents'
ALTER TABLE [dbo].[EventbriteEvents]
ADD CONSTRAINT [PK_EventbriteEvents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventCost2Student'
ALTER TABLE [dbo].[EventCost2Student]
ADD CONSTRAINT [PK_EventCost2Student]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventStudents'
ALTER TABLE [dbo].[EventStudents]
ADD CONSTRAINT [PK_EventStudents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventTransactions'
ALTER TABLE [dbo].[EventTransactions]
ADD CONSTRAINT [PK_EventTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventTransactionComments'
ALTER TABLE [dbo].[EventTransactionComments]
ADD CONSTRAINT [PK_EventTransactionComments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventTransactionStudents'
ALTER TABLE [dbo].[EventTransactionStudents]
ADD CONSTRAINT [PK_EventTransactionStudents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EventVenues'
ALTER TABLE [dbo].[EventVenues]
ADD CONSTRAINT [PK_EventVenues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Frequencies'
ALTER TABLE [dbo].[Frequencies]
ADD CONSTRAINT [PK_Frequencies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [PK_MiscTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PaymentMethods'
ALTER TABLE [dbo].[PaymentMethods]
ADD CONSTRAINT [PK_PaymentMethods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonGroups'
ALTER TABLE [dbo].[PersonGroups]
ADD CONSTRAINT [PK_PersonGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentCosts'
ALTER TABLE [dbo].[StudentCosts]
ADD CONSTRAINT [PK_StudentCosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [PK_Tables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TransactionCategories'
ALTER TABLE [dbo].[TransactionCategories]
ADD CONSTRAINT [PK_TransactionCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vendors'
ALTER TABLE [dbo].[Vendors]
ADD CONSTRAINT [PK_Vendors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Venues'
ALTER TABLE [dbo].[Venues]
ADD CONSTRAINT [PK_Venues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VenueTypes'
ALTER TABLE [dbo].[VenueTypes]
ADD CONSTRAINT [PK_VenueTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [EventId], [Description], [Amount], [FHICredit], [DateAdded] in table 'vwEventTransactions'
ALTER TABLE [dbo].[vwEventTransactions]
ADD CONSTRAINT [PK_vwEventTransactions]
    PRIMARY KEY CLUSTERED ([Id], [EventId], [Description], [Amount], [FHICredit], [DateAdded] ASC);
GO

-- Creating primary key on [Id] in table 'vwFullPeoples'
ALTER TABLE [dbo].[vwFullPeoples]
ADD CONSTRAINT [PK_vwFullPeoples]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [FullName], [Id] in table 'vwGroups'
ALTER TABLE [dbo].[vwGroups]
ADD CONSTRAINT [PK_vwGroups]
    PRIMARY KEY CLUSTERED ([FullName], [Id] ASC);
GO

-- Creating primary key on [DateAdded], [Amount], [Description], [PaymentMethod], [Percentage], [PlusFee] in table 'vwPaymentExpenses'
ALTER TABLE [dbo].[vwPaymentExpenses]
ADD CONSTRAINT [PK_vwPaymentExpenses]
    PRIMARY KEY CLUSTERED ([DateAdded], [Amount], [Description], [PaymentMethod], [Percentage], [PlusFee] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BookId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Classes_ToBooks]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Classes_ToBooks'
CREATE INDEX [IX_FK_Classes_ToBooks]
ON [dbo].[Events]
    ([BookId]);
GO

-- Creating foreign key on [CertId] in table 'CourseCerts'
ALTER TABLE [dbo].[CourseCerts]
ADD CONSTRAINT [FK_CourseCerts_Certificates]
    FOREIGN KEY ([CertId])
    REFERENCES [dbo].[Certificates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseCerts_Certificates'
CREATE INDEX [IX_FK_CourseCerts_Certificates]
ON [dbo].[CourseCerts]
    ([CertId]);
GO

-- Creating foreign key on [PersonId] in table 'ClassAttendees'
ALTER TABLE [dbo].[ClassAttendees]
ADD CONSTRAINT [FK_ClassAttendees_ToPeople]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassAttendees_ToPeople'
CREATE INDEX [IX_FK_ClassAttendees_ToPeople]
ON [dbo].[ClassAttendees]
    ([PersonId]);
GO

-- Creating foreign key on [RegistrationTypeId] in table 'ClassAttendees'
ALTER TABLE [dbo].[ClassAttendees]
ADD CONSTRAINT [FK_ClassAttendees_ToRegistrationTypes]
    FOREIGN KEY ([RegistrationTypeId])
    REFERENCES [dbo].[RegistrationTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassAttendees_ToRegistrationTypes'
CREATE INDEX [IX_FK_ClassAttendees_ToRegistrationTypes]
ON [dbo].[ClassAttendees]
    ([RegistrationTypeId]);
GO

-- Creating foreign key on [CourseId] in table 'CourseCerts'
ALTER TABLE [dbo].[CourseCerts]
ADD CONSTRAINT [FK_CourseCerts_Course]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseCerts_Course'
CREATE INDEX [IX_FK_CourseCerts_Course]
ON [dbo].[CourseCerts]
    ([CourseId]);
GO

-- Creating foreign key on [CourseFormatId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Classes_ToCourseFormat]
    FOREIGN KEY ([CourseFormatId])
    REFERENCES [dbo].[CourseFormats]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Classes_ToCourseFormat'
CREATE INDEX [IX_FK_Classes_ToCourseFormat]
ON [dbo].[Events]
    ([CourseFormatId]);
GO

-- Creating foreign key on [AccountId] in table 'CourseFormats'
ALTER TABLE [dbo].[CourseFormats]
ADD CONSTRAINT [FK_CourseFormats_ToQBAccounts]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[QBAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseFormats_ToQBAccounts'
CREATE INDEX [IX_FK_CourseFormats_ToQBAccounts]
ON [dbo].[CourseFormats]
    ([AccountId]);
GO

-- Creating foreign key on [CourseId] in table 'CourseMaterials'
ALTER TABLE [dbo].[CourseMaterials]
ADD CONSTRAINT [FK_CourseMaterials_ToCourse]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseMaterials_ToCourse'
CREATE INDEX [IX_FK_CourseMaterials_ToCourse]
ON [dbo].[CourseMaterials]
    ([CourseId]);
GO

-- Creating foreign key on [VendorId] in table 'CourseMaterials'
ALTER TABLE [dbo].[CourseMaterials]
ADD CONSTRAINT [FK_CourseMaterials_ToVendor]
    FOREIGN KEY ([VendorId])
    REFERENCES [dbo].[Vendors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseMaterials_ToVendor'
CREATE INDEX [IX_FK_CourseMaterials_ToVendor]
ON [dbo].[CourseMaterials]
    ([VendorId]);
GO

-- Creating foreign key on [CourseId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Classes_ToCourses]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Classes_ToCourses'
CREATE INDEX [IX_FK_Classes_ToCourses]
ON [dbo].[Events]
    ([CourseId]);
GO

-- Creating foreign key on [EventId] in table 'EventbriteEvents'
ALTER TABLE [dbo].[EventbriteEvents]
ADD CONSTRAINT [FK_EventbriteEvents_ToEvents]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventbriteEvents_ToEvents'
CREATE INDEX [IX_FK_EventbriteEvents_ToEvents]
ON [dbo].[EventbriteEvents]
    ([EventId]);
GO

-- Creating foreign key on [EventId] in table 'EventCost2Student'
ALTER TABLE [dbo].[EventCost2Student]
ADD CONSTRAINT [FK_EventCost2Student_ToEvent]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventCost2Student_ToEvent'
CREATE INDEX [IX_FK_EventCost2Student_ToEvent]
ON [dbo].[EventCost2Student]
    ([EventId]);
GO

-- Creating foreign key on [ClassId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_ClassAttendees_ToClasses]
    FOREIGN KEY ([ClassId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassAttendees_ToClasses'
CREATE INDEX [IX_FK_ClassAttendees_ToClasses]
ON [dbo].[MiscTransactions]
    ([ClassId]);
GO

-- Creating foreign key on [FacilitatorId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Events_ToFacilitator]
    FOREIGN KEY ([FacilitatorId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Events_ToFacilitator'
CREATE INDEX [IX_FK_Events_ToFacilitator]
ON [dbo].[Events]
    ([FacilitatorId]);
GO

-- Creating foreign key on [FrequencyId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Events_ToFrequency]
    FOREIGN KEY ([FrequencyId])
    REFERENCES [dbo].[Frequencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Events_ToFrequency'
CREATE INDEX [IX_FK_Events_ToFrequency]
ON [dbo].[Events]
    ([FrequencyId]);
GO

-- Creating foreign key on [EventId] in table 'EventStudents'
ALTER TABLE [dbo].[EventStudents]
ADD CONSTRAINT [FK_EventStudents_Events]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventStudents_Events'
CREATE INDEX [IX_FK_EventStudents_Events]
ON [dbo].[EventStudents]
    ([EventId]);
GO

-- Creating foreign key on [EventId] in table 'EventTransactions'
ALTER TABLE [dbo].[EventTransactions]
ADD CONSTRAINT [FK_EventTransaction_ToEvent]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransaction_ToEvent'
CREATE INDEX [IX_FK_EventTransaction_ToEvent]
ON [dbo].[EventTransactions]
    ([EventId]);
GO

-- Creating foreign key on [EventId] in table 'EventVenues'
ALTER TABLE [dbo].[EventVenues]
ADD CONSTRAINT [FK_EventVenues_ToEvents]
    FOREIGN KEY ([EventId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventVenues_ToEvents'
CREATE INDEX [IX_FK_EventVenues_ToEvents]
ON [dbo].[EventVenues]
    ([EventId]);
GO

-- Creating foreign key on [ClassId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_MiscTransactions_ToClasses]
    FOREIGN KEY ([ClassId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MiscTransactions_ToClasses'
CREATE INDEX [IX_FK_MiscTransactions_ToClasses]
ON [dbo].[MiscTransactions]
    ([ClassId]);
GO

-- Creating foreign key on [StudentId] in table 'EventStudents'
ALTER TABLE [dbo].[EventStudents]
ADD CONSTRAINT [FK_EventStudents_People]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventStudents_People'
CREATE INDEX [IX_FK_EventStudents_People]
ON [dbo].[EventStudents]
    ([StudentId]);
GO

-- Creating foreign key on [PaymentMethodId] in table 'EventTransactions'
ALTER TABLE [dbo].[EventTransactions]
ADD CONSTRAINT [FK_EventTransaction_ToPaymentMethod]
    FOREIGN KEY ([PaymentMethodId])
    REFERENCES [dbo].[PaymentMethods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransaction_ToPaymentMethod'
CREATE INDEX [IX_FK_EventTransaction_ToPaymentMethod]
ON [dbo].[EventTransactions]
    ([PaymentMethodId]);
GO

-- Creating foreign key on [TransactionCategoryId] in table 'EventTransactions'
ALTER TABLE [dbo].[EventTransactions]
ADD CONSTRAINT [FK_EventTransaction_ToTransactionCategory]
    FOREIGN KEY ([TransactionCategoryId])
    REFERENCES [dbo].[TransactionCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransaction_ToTransactionCategory'
CREATE INDEX [IX_FK_EventTransaction_ToTransactionCategory]
ON [dbo].[EventTransactions]
    ([TransactionCategoryId]);
GO

-- Creating foreign key on [EventTransactionId] in table 'EventTransactionComments'
ALTER TABLE [dbo].[EventTransactionComments]
ADD CONSTRAINT [FK_EventTransactionComment_EventTransaction]
    FOREIGN KEY ([EventTransactionId])
    REFERENCES [dbo].[EventTransactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransactionComment_EventTransaction'
CREATE INDEX [IX_FK_EventTransactionComment_EventTransaction]
ON [dbo].[EventTransactionComments]
    ([EventTransactionId]);
GO

-- Creating foreign key on [EventTransactionId] in table 'EventTransactionStudents'
ALTER TABLE [dbo].[EventTransactionStudents]
ADD CONSTRAINT [FK_EventTransactionStudent_EventTransaction]
    FOREIGN KEY ([EventTransactionId])
    REFERENCES [dbo].[EventTransactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransactionStudent_EventTransaction'
CREATE INDEX [IX_FK_EventTransactionStudent_EventTransaction]
ON [dbo].[EventTransactionStudents]
    ([EventTransactionId]);
GO

-- Creating foreign key on [StudentId] in table 'EventTransactionStudents'
ALTER TABLE [dbo].[EventTransactionStudents]
ADD CONSTRAINT [FK_EventTransactionStudent_People]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransactionStudent_People'
CREATE INDEX [IX_FK_EventTransactionStudent_People]
ON [dbo].[EventTransactionStudents]
    ([StudentId]);
GO

-- Creating foreign key on [RegistrationTypeId] in table 'EventTransactionStudents'
ALTER TABLE [dbo].[EventTransactionStudents]
ADD CONSTRAINT [FK_EventTransactionStudent_ToRegistrationType]
    FOREIGN KEY ([RegistrationTypeId])
    REFERENCES [dbo].[RegistrationTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransactionStudent_ToRegistrationType'
CREATE INDEX [IX_FK_EventTransactionStudent_ToRegistrationType]
ON [dbo].[EventTransactionStudents]
    ([RegistrationTypeId]);
GO

-- Creating foreign key on [VenueId] in table 'EventVenues'
ALTER TABLE [dbo].[EventVenues]
ADD CONSTRAINT [FK_EventVenues_ToVenue]
    FOREIGN KEY ([VenueId])
    REFERENCES [dbo].[Venues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventVenues_ToVenue'
CREATE INDEX [IX_FK_EventVenues_ToVenue]
ON [dbo].[EventVenues]
    ([VenueId]);
GO

-- Creating foreign key on [GroupId] in table 'PersonGroups'
ALTER TABLE [dbo].[PersonGroups]
ADD CONSTRAINT [FK_PersonGroups_ToGroups]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonGroups_ToGroups'
CREATE INDEX [IX_FK_PersonGroups_ToGroups]
ON [dbo].[PersonGroups]
    ([GroupId]);
GO

-- Creating foreign key on [PayerId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_ClassAttendees_ToPayer]
    FOREIGN KEY ([PayerId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassAttendees_ToPayer'
CREATE INDEX [IX_FK_ClassAttendees_ToPayer]
ON [dbo].[MiscTransactions]
    ([PayerId]);
GO

-- Creating foreign key on [PaymentTypeId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_ClassAttendees_ToPaymentType]
    FOREIGN KEY ([PaymentTypeId])
    REFERENCES [dbo].[PaymentMethods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassAttendees_ToPaymentType'
CREATE INDEX [IX_FK_ClassAttendees_ToPaymentType]
ON [dbo].[MiscTransactions]
    ([PaymentTypeId]);
GO

-- Creating foreign key on [PayerId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_MiscTransactions_ToPayer]
    FOREIGN KEY ([PayerId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MiscTransactions_ToPayer'
CREATE INDEX [IX_FK_MiscTransactions_ToPayer]
ON [dbo].[MiscTransactions]
    ([PayerId]);
GO

-- Creating foreign key on [PaymentTypeId] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_MiscTransactions_ToPaymentType]
    FOREIGN KEY ([PaymentTypeId])
    REFERENCES [dbo].[PaymentMethods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MiscTransactions_ToPaymentType'
CREATE INDEX [IX_FK_MiscTransactions_ToPaymentType]
ON [dbo].[MiscTransactions]
    ([PaymentTypeId]);
GO

-- Creating foreign key on [QBAccount] in table 'MiscTransactions'
ALTER TABLE [dbo].[MiscTransactions]
ADD CONSTRAINT [FK_MiscTransactions_ToQBAccounts]
    FOREIGN KEY ([QBAccount])
    REFERENCES [dbo].[QBAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MiscTransactions_ToQBAccounts'
CREATE INDEX [IX_FK_MiscTransactions_ToQBAccounts]
ON [dbo].[MiscTransactions]
    ([QBAccount]);
GO

-- Creating foreign key on [PersonId] in table 'PersonGroups'
ALTER TABLE [dbo].[PersonGroups]
ADD CONSTRAINT [FK_PersonGroups_ToPeople]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonGroups_ToPeople'
CREATE INDEX [IX_FK_PersonGroups_ToPeople]
ON [dbo].[PersonGroups]
    ([PersonId]);
GO

-- Creating foreign key on [VenueTypeId] in table 'Venues'
ALTER TABLE [dbo].[Venues]
ADD CONSTRAINT [FK_Venue_VenueType]
    FOREIGN KEY ([VenueTypeId])
    REFERENCES [dbo].[VenueTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Venue_VenueType'
CREATE INDEX [IX_FK_Venue_VenueType]
ON [dbo].[Venues]
    ([VenueTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------