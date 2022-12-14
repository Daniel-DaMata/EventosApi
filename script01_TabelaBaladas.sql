IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [baladas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Endereco] nvarchar(max) NULL,
    [Bebida] bit NOT NULL,
    [Entrada] real NOT NULL,
    CONSTRAINT [PK_baladas] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bebida', N'Endereco', N'Entrada', N'Nome') AND [object_id] = OBJECT_ID(N'[baladas]'))
    SET IDENTITY_INSERT [baladas] ON;
INSERT INTO [baladas] ([Id], [Bebida], [Endereco], [Entrada], [Nome])
VALUES (1, CAST(1 AS bit), N'Santana', CAST(0 AS real), N'Robinho'),
(2, CAST(1 AS bit), N'Avenida Nova', CAST(30 AS real), N'Red'),
(3, CAST(1 AS bit), N'Avenida Engenheiro', CAST(20 AS real), N'Lux'),
(4, CAST(1 AS bit), N'Avenida Nova', CAST(10 AS real), N'Barcelona'),
(5, CAST(1 AS bit), N'Avenida Cruzeiro', CAST(60 AS real), N'Dubai'),
(6, CAST(1 AS bit), N'Avenida Guilherme', CAST(25 AS real), N'Slim');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bebida', N'Endereco', N'Entrada', N'Nome') AND [object_id] = OBJECT_ID(N'[baladas]'))
    SET IDENTITY_INSERT [baladas] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221214184058_InitialCreate', N'7.0.1');
GO

COMMIT;
GO

