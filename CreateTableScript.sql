CREATE TABLE [dbo].[Authors] (
    [AuthorId]   INT           IDENTITY (1, 1) NOT NULL,
    [AuthorName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AuthorId] ASC)
);

CREATE TABLE [dbo].[BookImages] (
    [ImageId]   INT            IDENTITY (1, 1) NOT NULL,
    [BookId]    INT            NULL,
    [ImagePath] NVARCHAR (250) NULL,
    [Date]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ImageId] ASC)
);

CREATE TABLE [dbo].[Books] (
    [BookId]      INT           IDENTITY (1, 1) NOT NULL,
    [CategoryId]  INT           NOT NULL,
    [AuthorId]    INT           NOT NULL,
    [PublisherId] INT           NOT NULL,
    [BookName]    NVARCHAR (50) NOT NULL,
    [Page]        INT           NOT NULL,
    [Price]       DECIMAL (18)  NOT NULL,
    [Description] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

CREATE TABLE [dbo].[Categories] (
    [CategoryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

CREATE TABLE [dbo].[CreditCards] (
    [CardId]           INT           IDENTITY (1, 1) NOT NULL,
    [UserId]           INT           NULL,
    [NameSurname]      NVARCHAR (50) NULL,
    [CreditCardNumber] NVARCHAR (50) NULL,
    [ExpirationDate]   NVARCHAR (50) NULL,
    [Cvc]              NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CardId] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Orders] (
    [OrderId]   INT      IDENTITY (1, 1) NOT NULL,
    [BookId]    INT      NULL,
    [UserId]    INT      NULL,
    [OrderDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

CREATE TABLE [dbo].[Payments] (
    [PaymentId]   INT      IDENTITY (1, 1) NOT NULL,
    [BookId]      INT      NULL,
    [UserId]      INT      NULL,
    [ProcessDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC)
);

CREATE TABLE [dbo].[Publishers] (
    [PublisherId]   INT           IDENTITY (1, 1) NOT NULL,
    [PublisherName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PublisherId] ASC)
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NULL,
    [OperationClaimId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50)   NULL,
    [LastName]     NVARCHAR (50)   NULL,
    [Email]        NVARCHAR (50)   NULL,
    [PasswordHash] VARBINARY (500) NULL,
    [PasswordSalt] VARBINARY (500) NULL,
    [Status]       BIT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
