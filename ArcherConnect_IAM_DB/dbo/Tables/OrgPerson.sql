CREATE TABLE [dbo].[OrgPerson] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [OrgTypeAssignment] INT NULL,
    [Person]            INT NULL,
    CONSTRAINT [PK_OrgPerson] PRIMARY KEY CLUSTERED ([Id] ASC)
);

