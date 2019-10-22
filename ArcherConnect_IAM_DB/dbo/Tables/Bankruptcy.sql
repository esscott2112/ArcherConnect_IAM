CREATE TABLE [dbo].[Bankruptcy] (
    [Id]             INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID]       UNIQUEIDENTIFIER CONSTRAINT [DF_Bankruptcy_ObjectID] DEFAULT (newsequentialid()) NULL,
    [DomainPersonId] INT              NULL
);

