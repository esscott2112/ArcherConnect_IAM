CREATE TABLE [dbo].[Medical_Record] (
    [Id]       INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID] UNIQUEIDENTIFIER CONSTRAINT [DF_Medical_Record_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]     NVARCHAR (255)   NULL
);

