CREATE TABLE [dbo].[Claimant] (
    [Id]             INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID]       UNIQUEIDENTIFIER CONSTRAINT [DF_Claimant_ObjectID] DEFAULT (newsequentialid()) NULL,
    [DomainPersonId] INT              NULL
);

