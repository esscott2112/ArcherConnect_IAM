CREATE TABLE [dbo].[UI Module] (
    [Id]       INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID] UNIQUEIDENTIFIER CONSTRAINT [DF_UI Modules_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]     NVARCHAR (255)   NULL
);

