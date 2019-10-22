CREATE TABLE [dbo].[UI Element] (
    [Id]       INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID] UNIQUEIDENTIFIER CONSTRAINT [DF_UI Elements_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]     NVARCHAR (255)   NULL
);

