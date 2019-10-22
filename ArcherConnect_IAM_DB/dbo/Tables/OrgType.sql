CREATE TABLE [dbo].[OrgType] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NULL,
    CONSTRAINT [PK_OrgType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

