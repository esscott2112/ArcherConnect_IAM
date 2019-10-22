CREATE TABLE [dbo].[Lien] (
    [Id]       INT              IDENTITY (1, 1) NOT NULL,
    [ObjectID] UNIQUEIDENTIFIER CONSTRAINT [DF_Lien_ObjectID] DEFAULT (newsequentialid()) NULL,
    [Name]     NVARCHAR (255)   NULL
);

