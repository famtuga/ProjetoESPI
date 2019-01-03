CREATE TABLE [dbo].[usershorario] (
    [id]       INT        NOT NULL IDENTITY,
    [name]     NCHAR (50) NULL,
    [password] NCHAR (10) NULL, 
    CONSTRAINT [PK_usershorario] PRIMARY KEY ([id])
);

