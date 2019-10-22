CREATE TABLE [dbo].[Case] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID]     UNIQUEIDENTIFIER CONSTRAINT [DF_Case_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]         NVARCHAR (255)   NULL,
    [CourtCaseRef] NVARCHAR (255)   NULL
);

