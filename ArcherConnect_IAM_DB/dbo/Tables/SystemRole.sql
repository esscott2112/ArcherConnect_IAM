CREATE TABLE [dbo].[SystemRole] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [RoleName] NVARCHAR (255) NULL,
    CONSTRAINT [PK_SystemRole] PRIMARY KEY CLUSTERED ([Id] ASC)
);

