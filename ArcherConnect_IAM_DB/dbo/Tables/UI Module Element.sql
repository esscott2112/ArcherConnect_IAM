CREATE TABLE [dbo].[UI Module Element] (
    [Id]        INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID]  UNIQUEIDENTIFIER CONSTRAINT [DF_UI Module Elements_ObjectID] DEFAULT (newsequentialid()) NULL,
    [ModuleId]  INT              NULL,
    [ElementId] INT              NULL
);

