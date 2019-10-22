CREATE TABLE [dbo].[SystemUserRole] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [RoleId] INT NULL,
    [UserId] INT NULL,
    CONSTRAINT [PK_SystemUserRole] PRIMARY KEY CLUSTERED ([Id] ASC)
);

