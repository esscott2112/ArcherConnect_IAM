CREATE TABLE [dbo].[Claim] (
    [Id]       INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID] UNIQUEIDENTIFIER CONSTRAINT [DF_Claim_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]     NVARCHAR (255)   NULL
);

