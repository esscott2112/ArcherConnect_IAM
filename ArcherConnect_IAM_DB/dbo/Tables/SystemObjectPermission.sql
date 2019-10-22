CREATE TABLE [dbo].[SystemObjectPermission] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID]     UNIQUEIDENTIFIER CONSTRAINT [DF_ObjectPermission_ObjectID] DEFAULT (newsequentialid()) NULL,
    [PermissionId] NVARCHAR (255)   NULL,
    [Description]  NVARCHAR (255)   NULL
);

