CREATE TABLE [dbo].[SystemUser] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Username]       NVARCHAR (255) NULL,
    [Password]       NVARCHAR (255) NULL,
    [SystemPersonId] INT            NULL,
    [RecoveryEmail]  NVARCHAR (255) NULL,
    CONSTRAINT [PK_SystemUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);

