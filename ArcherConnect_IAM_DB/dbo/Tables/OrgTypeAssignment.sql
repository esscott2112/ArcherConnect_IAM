CREATE TABLE [dbo].[OrgTypeAssignment] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Organization]     INT            NULL,
    [OrganizationType] INT            NULL,
    [Name]             NVARCHAR (255) NULL,
    CONSTRAINT [PK_OrgTypeAssignment] PRIMARY KEY CLUSTERED ([Id] ASC)
);

