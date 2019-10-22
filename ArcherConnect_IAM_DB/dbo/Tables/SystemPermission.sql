CREATE TABLE [dbo].[SystemPermission] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [IsRead]   BIT            NULL,
    [IsWrite]  BIT            NULL,
    [IsDelete] BIT            NULL,
    [IsUpdate] BIT            NULL,
    [Name]     NVARCHAR (255) NULL
);

