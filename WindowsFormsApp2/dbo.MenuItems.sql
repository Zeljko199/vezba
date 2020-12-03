CREATE TABLE [dbo].[MenuItems] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (200)  NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Price]       DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

