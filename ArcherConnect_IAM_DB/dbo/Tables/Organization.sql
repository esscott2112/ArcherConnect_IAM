CREATE TABLE [dbo].[Organization] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [OrganizationName] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([Id] ASC)
);

