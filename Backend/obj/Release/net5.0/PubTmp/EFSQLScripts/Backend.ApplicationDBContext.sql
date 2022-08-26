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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [Locations] (
        [LocationId] nvarchar(450) NOT NULL,
        [Longitude] float NOT NULL,
        [Latitude] float NOT NULL,
        CONSTRAINT [PK_Locations] PRIMARY KEY ([LocationId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE TABLE [Events] (
        [EventId] nvarchar(450) NOT NULL,
        [EventName] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [Rate] real NOT NULL,
        [StartDatetime] datetime2 NOT NULL,
        [EndDatetime] datetime2 NOT NULL,
        [UserID] nvarchar(450) NOT NULL,
        [LocationID] nvarchar(450) NOT NULL,
        [isFinished] bit NOT NULL,
        [ImagePath] nvarchar(max) NOT NULL,
        [IsCancelled] bit NOT NULL,
        CONSTRAINT [PK_Events] PRIMARY KEY ([EventId]),
        CONSTRAINT [FK_Events_AspNetUsers_UserID] FOREIGN KEY ([UserID]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Events_Locations_LocationID] FOREIGN KEY ([LocationID]) REFERENCES [Locations] ([LocationId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    EXEC(N'INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
    VALUES (N''b74ddd14-6340-4840-95c2-db12554843e5'', 0, N''455c3107-32d5-45f9-8758-8fa1a352a657'', N''volkovskiy4@gmail.com'', CAST(0 AS bit), CAST(0 AS bit), NULL, N''VOLKOVSKIY4@GMAIL.COM'', NULL, N''AJtQn7aPYwUBreGFV/umrnoWXMChjsvuhUqHRjG19r/ozEfFAYiBolSKk7fU9Rsvnw=='', NULL, CAST(0 AS bit), N''df8847a5-8842-48cd-8922-f14cb3195600'', CAST(0 AS bit), N''Test1'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'LocationId', N'Latitude', N'Longitude') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] ON;
    EXEC(N'INSERT INTO [Locations] ([LocationId], [Latitude], [Longitude])
    VALUES (N''1'', 48.733755000000002E0, 37.586129999999997E0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'LocationId', N'Latitude', N'Longitude') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventId', N'Description', N'EndDatetime', N'EventName', N'ImagePath', N'IsCancelled', N'LocationID', N'Rate', N'StartDatetime', N'UserID', N'isFinished') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] ON;
    EXEC(N'INSERT INTO [Events] ([EventId], [Description], [EndDatetime], [EventName], [ImagePath], [IsCancelled], [LocationID], [Rate], [StartDatetime], [UserID], [isFinished])
    VALUES (N''1'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5995876+03:00'', N''Mafia game'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5979134+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit)),
    (N''2'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5997230+03:00'', N''Mafia game1'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5997218+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit)),
    (N''3'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5997236+03:00'', N''Mafia game2'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5997234+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit)),
    (N''4'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5997242+03:00'', N''Mafia game3'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5997240+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit)),
    (N''5'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5997247+03:00'', N''Mafia game4'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5997245+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit)),
    (N''6'', N''Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn'', ''2022-05-15T20:36:19.5997252+03:00'', N''Mafia game5'', N''/test'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-15T15:36:19.5997250+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(0 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventId', N'Description', N'EndDatetime', N'EventName', N'ImagePath', N'IsCancelled', N'LocationID', N'Rate', N'StartDatetime', N'UserID', N'isFinished') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_Events_LocationID] ON [Events] ([LocationID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    CREATE INDEX [IX_Events_UserID] ON [Events] ([UserID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515123620_Init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220515123620_Init', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''17309440-39b4-4459-8808-cf89988f553f'', [NormalizedUserName] = N''TEST1'', [PasswordHash] = N''AOmmW8gd07mkltsyQRnpYgXOJmxhKvRQd+LagAan5FD7RuOl0e2N8vdvkEY5oyPjJA=='', [SecurityStamp] = N''6afd5c1f-b7ec-4adf-820c-db6195df9583''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7433551+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7417201+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7434891+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7434879+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7434898+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7434896+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7434903+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7434901+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7434908+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7434906+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T20:40:20.7434914+03:00'', [StartDatetime] = ''2022-05-15T15:40:20.7434912+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515124021_ChangedSeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220515124021_ChangedSeedData', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''c887196f-4b23-40d0-a57c-df72a74f9c4c'', [PasswordHash] = N''AD3xRmrq0i7UHdONRSZEQSgqAhWyRlvj6QiJ91cFCELvd5z0vqkJGJgvwV9OcgpIrg=='', [SecurityStamp] = N''a1d90eb2-c1c9-43f4-b045-e83c66f4b22a''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1241526+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1218340+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1243620+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1243605+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1243638+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1243631+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1243656+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1243648+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1243674+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1243666+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-15T21:29:56.1243691+03:00'', [StartDatetime] = ''2022-05-15T16:29:56.1243683+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220515132956_ChangedModels')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220515132956_ChangedModels', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''c772fa5e-0c4e-4df0-97e3-6ecc37fa67d3'', [PasswordHash] = N''ALE5j4rE7vkPjVGq/MlzNUHWyNg3Gm5Cvl8cOgVKYtBCDYIs/gS3sNOLc2hI3ML1Rg=='', [SecurityStamp] = N''bba993b4-7e8d-406c-ae1a-a3e02e31b8b4''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1453684+03:00'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1436732+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1455172+03:00'', [EventName] = N''Mafia game2'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1455160+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1455179+03:00'', [EventName] = N''Mafia game3'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1455177+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1455184+03:00'', [EventName] = N''Mafia game4'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1455181+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1455189+03:00'', [EventName] = N''Mafia game5'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1455186+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Events] SET [Description] = N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', [EndDatetime] = ''2022-05-19T01:27:58.1455194+03:00'', [EventName] = N''Mafia game6'', [ImagePath] = N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', [StartDatetime] = ''2022-05-18T20:27:58.1455192+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    EXEC(N'UPDATE [Locations] SET [Latitude] = 49.839683999999998E0, [Longitude] = 24.029716000000001E0
    WHERE [LocationId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220518172758_SeedingModification')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220518172758_SeedingModification', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    CREATE TABLE [EventParticipantsDBs] (
        [EventParticipantsId] nvarchar(450) NOT NULL,
        [EventId] nvarchar(450) NULL,
        [UserId] nvarchar(450) NULL,
        CONSTRAINT [PK_EventParticipantsDBs] PRIMARY KEY ([EventParticipantsId]),
        CONSTRAINT [FK_EventParticipantsDBs_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_EventParticipantsDBs_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([EventId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''0328d5dc-1ead-400f-b2c4-7f1089cda22b'', [PasswordHash] = N''AFo3k/cio1ZY8aQIXA0QrijtttOAeRs76ImnCZj+fQvhmHMRYoBLg6xYlelX2TLM/A=='', [SecurityStamp] = N''db955a0d-974c-4a42-be20-2377707ebb4f''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    EXEC(N'INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
    VALUES (N''c74ddf14-6340-4840-95c2-db12554843e5'', 0, N''7f931dae-ce9a-4afd-a2ad-219edf8f7e6e'', N''volkovskiy4@gmail.com'', CAST(0 AS bit), CAST(0 AS bit), NULL, N''VOLKOVSKIY4@GMAIL.COM'', N''TEST2'', N''AJcGxTvxo2ZV+fCaAZWn4rPCwrhMUqyylnO30Vgn9aoOiFqeSJmV9sEJTbju1WEZ7w=='', NULL, CAST(0 AS bit), N''28f9cb86-6a76-4d17-b12f-c640875e501f'', CAST(0 AS bit), N''Test2'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0139134+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0114281+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0140727+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0140715+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0140734+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0140731+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0140739+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0140737+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0140744+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0140742+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:45:12.0140750+03:00'', [StartDatetime] = ''2022-05-21T20:45:12.0140747+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] ON;
    EXEC(N'INSERT INTO [EventParticipantsDBs] ([EventParticipantsId], [EventId], [UserId])
    VALUES (N''7'', N''1'', N''c74ddf14-6340-4840-95c2-db12554843e5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] ON;
    EXEC(N'INSERT INTO [EventParticipantsDBs] ([EventParticipantsId], [EventId], [UserId])
    VALUES (N''8'', N''2'', N''c74ddf14-6340-4840-95c2-db12554843e5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] ON;
    EXEC(N'INSERT INTO [EventParticipantsDBs] ([EventParticipantsId], [EventId], [UserId])
    VALUES (N''9'', N''3'', N''c74ddf14-6340-4840-95c2-db12554843e5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipantsDBs]'))
        SET IDENTITY_INSERT [EventParticipantsDBs] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    CREATE INDEX [IX_EventParticipantsDBs_EventId] ON [EventParticipantsDBs] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    CREATE INDEX [IX_EventParticipantsDBs_UserId] ON [EventParticipantsDBs] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174512_AddParticipants')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220521174512_AddParticipants', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipantsDBs] DROP CONSTRAINT [FK_EventParticipantsDBs_AspNetUsers_UserId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipantsDBs] DROP CONSTRAINT [FK_EventParticipantsDBs_Events_EventId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipantsDBs] DROP CONSTRAINT [PK_EventParticipantsDBs];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC sp_rename N'[EventParticipantsDBs]', N'EventParticipants';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC sp_rename N'[EventParticipants].[IX_EventParticipantsDBs_UserId]', N'IX_EventParticipants_UserId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC sp_rename N'[EventParticipants].[IX_EventParticipantsDBs_EventId]', N'IX_EventParticipants_EventId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipants] ADD CONSTRAINT [PK_EventParticipants] PRIMARY KEY ([EventParticipantsId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''d7b3016c-3510-4047-a41f-0abb7034c7d7'', [PasswordHash] = N''AFXT6Ij2e1rP2IsCNIMHsUDM/89BSXs9LvS1SMBObqadTUBWj0IQdmlDMaHRXDVFlg=='', [SecurityStamp] = N''2dd36c36-728e-419d-bf41-85d3022ce01f''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''8bca1298-5451-417f-9ef4-4becb981dcf9'', [PasswordHash] = N''AKwJAW/nREbK0HlLgYUajBgPifFXatv1yXqmRnrAAY2knvchjW9n5bs4ZV3ck8DDzA=='', [SecurityStamp] = N''b7c8ec0e-4ccb-409a-8b4c-3e343f2d1c08''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6878946+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6863298+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6880418+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6880406+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6880425+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6880423+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6880430+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6880428+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6880436+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6880434+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-22T01:47:06.6880441+03:00'', [StartDatetime] = ''2022-05-21T20:47:06.6880439+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipants] ADD CONSTRAINT [FK_EventParticipants_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    ALTER TABLE [EventParticipants] ADD CONSTRAINT [FK_EventParticipants_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([EventId]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521174707_ChangedName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220521174707_ChangedName', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'DELETE FROM [EventParticipants]
    WHERE [EventParticipantsId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'DELETE FROM [EventParticipants]
    WHERE [EventParticipantsId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''856f1009-c761-4b16-b4ca-e9724e9df542'', [PasswordHash] = N''ANIdTMX+sRcXTAioa1GqZHQHIlwjPSa/X3jCgSCQFuv4h3wCaixuVVo3q0ueCkj8LQ=='', [SecurityStamp] = N''bb9e6980-56da-4d54-a963-0a775262dbbd''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''f5e1f105-a742-4a08-afe3-212cb1564fab'', [PasswordHash] = N''AB3/p8UQrYSn6F0S3q5mr3+zWGTLI0atOAc2rOqaCXeUJw0pmV9ukX2RatjJokP9QQ=='', [SecurityStamp] = N''73f6653d-4a59-4de2-9da0-5acc3afacd28''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [EventParticipants] SET [EventId] = N''1''
    WHERE [EventParticipantsId] = N''9'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipants]'))
        SET IDENTITY_INSERT [EventParticipants] ON;
    EXEC(N'INSERT INTO [EventParticipants] ([EventParticipantsId], [EventId], [UserId])
    VALUES (N''10'', N''2'', N''c74ddf14-6340-4840-95c2-db12554843e5''),
    (N''11'', N''3'', N''c74ddf14-6340-4840-95c2-db12554843e5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipants]'))
        SET IDENTITY_INSERT [EventParticipants] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4308011+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4291332+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4309494+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4309481+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4309501+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4309498+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4309506+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4309504+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4309511+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4309509+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-30T22:04:03.4309517+03:00'', [StartDatetime] = ''2022-05-30T17:04:03.4309514+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventId', N'Description', N'EndDatetime', N'EventName', N'ImagePath', N'IsCancelled', N'LocationID', N'Rate', N'StartDatetime', N'UserID', N'isFinished') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] ON;
    EXEC(N'INSERT INTO [Events] ([EventId], [Description], [EndDatetime], [EventName], [ImagePath], [IsCancelled], [LocationID], [Rate], [StartDatetime], [UserID], [isFinished])
    VALUES (N''7'', N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', ''2022-05-30T22:04:03.4309521+03:00'', N''Mafia game7'', N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-30T17:04:03.4309519+03:00'', N''b74ddd14-6340-4840-95c2-db12554843e5'', CAST(1 AS bit)),
    (N''8'', N''When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the ''''90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!'', ''2022-05-30T22:04:03.4309526+03:00'', N''Mafia game8'', N''http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D'', CAST(0 AS bit), N''1'', CAST(4.5 AS real), ''2022-05-30T17:04:03.4309524+03:00'', N''c74ddf14-6340-4840-95c2-db12554843e5'', CAST(1 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventId', N'Description', N'EndDatetime', N'EventName', N'ImagePath', N'IsCancelled', N'LocationID', N'Rate', N'StartDatetime', N'UserID', N'isFinished') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipants]'))
        SET IDENTITY_INSERT [EventParticipants] ON;
    EXEC(N'INSERT INTO [EventParticipants] ([EventParticipantsId], [EventId], [UserId])
    VALUES (N''12'', N''8'', N''b74ddd14-6340-4840-95c2-db12554843e5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EventParticipantsId', N'EventId', N'UserId') AND [object_id] = OBJECT_ID(N'[EventParticipants]'))
        SET IDENTITY_INSERT [EventParticipants] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220530140404_SeedModify')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220530140404_SeedModify', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    ALTER TABLE [Locations] ADD [Adress] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''911a7ead-3cc9-4c97-be02-22416611faae'', [PasswordHash] = N''ABW+lyFyW6wuYgS43O2gO0w3uTIkfo8fA7A4EG0bi0OLStP5W22dTsH6jTQjuYKYNw=='', [SecurityStamp] = N''b751762c-6f4c-4824-b0f6-08a882f5d17f''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''d1431996-5b14-4189-804b-717d8e7a9179'', [PasswordHash] = N''AHa6M9quqzaeSme1BDt6piYH5aDLahs71ZQMzMhLrJMQYgiUDO/1CXyffxMFKJBxRQ=='', [SecurityStamp] = N''df6cec85-4829-4f5f-9372-17182b7a49c5''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1984882+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1967228+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986435+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986423+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986494+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986491+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986501+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986498+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986506+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986504+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986513+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986510+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986518+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986516+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T20:29:53.1986523+03:00'', [StartDatetime] = ''2022-05-31T15:29:53.1986521+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    EXEC(N'UPDATE [Locations] SET [Adress] = N''Vinnytsia Oblast'', [Latitude] = 49.068764999999999E0, [Longitude] = 28.802313999999999E0
    WHERE [LocationId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531122953_ModifiedLocationModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220531122953_ModifiedLocationModel', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''06a4fcf6-527d-408a-9885-0e6f2ec90a9e'', [PasswordHash] = N''ADKsVUNcU7M5jIenruTMQwWhZsD9Y120UarEkW3IxPbGtVMi9k8qd2oo37EiLxUmmQ=='', [SecurityStamp] = N''73ab224b-b4cb-4879-bfda-9be93cc0104d''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''ce35643e-5d95-4690-8118-aa0fa3174fb5'', [PasswordHash] = N''AFXtorC5N+gPZ+10/8xU9Zzh+IIgZ7EcRyAmmIsqCZjEMzMyl8SjB9JWKLREXn77Ew=='', [SecurityStamp] = N''79e2325f-c0c4-42d7-833c-8b79d5d7c1f2''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9287918+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9271653+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9289404+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9289392+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9289411+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9289408+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9289416+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9289414+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9289421+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9289419+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T01:26:29.9289426+03:00'', [StartDatetime] = ''2022-05-31T23:26:29.9289424+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T19:26:29.9289431+03:00'', [StartDatetime] = ''2022-05-31T18:26:29.9289429+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-05-31T19:26:29.9289436+03:00'', [StartDatetime] = ''2022-05-31T18:26:29.9289434+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220531172630_ModifiedFinishedEvents')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220531172630_ModifiedFinishedEvents', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''addd10ff-2453-447f-8e86-505904da8178'', [PasswordHash] = N''AFqHLAx41fDinVJcJAGjuxqV48vkxRXZDjUHw+pVzL4iWyScfLZgHy6gJPqVjaIfNg=='', [SecurityStamp] = N''c06976e4-267b-486f-8e1f-6f877e4848fd''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''9ad96251-664a-41a1-aed4-d5213b14e2a8'', [PasswordHash] = N''AE1C7OwTUMym7sQJlts9T30ztoYe10tBVeT4tzOhxOwOOU0gWldhS1a5Db3j/CJl+w=='', [SecurityStamp] = N''1eb3b12a-d05c-4fa5-8757-ebb18f132cae''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [EventParticipants] SET [EventId] = N''7''
    WHERE [EventParticipantsId] = N''11'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [EventParticipants] SET [UserId] = N''c74ddf14-6340-4840-95c2-db12554843e5''
    WHERE [EventParticipantsId] = N''12'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4435885+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4419511+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4437451+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4437440+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4437459+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4437456+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4437464+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4437462+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4437469+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4437467+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T20:57:20.4437474+03:00'', [StartDatetime] = ''2022-06-01T18:57:20.4437472+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T14:57:20.4437479+03:00'', [StartDatetime] = ''2022-06-01T13:57:20.4437477+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-01T14:57:20.4437484+03:00'', [StartDatetime] = ''2022-06-01T13:57:20.4437482+03:00'', [UserID] = N''b74ddd14-6340-4840-95c2-db12554843e5''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220601125721_ModifiedSeed')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220601125721_ModifiedSeed', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''d75f153b-6356-4699-afe2-5f0ca5f57764'', [PasswordHash] = N''ALO8VlYdAdZsi1iWIiAd1PFgiEGDp5LaEknc7R9srLHtJHPjR4VoGm9VbTyzqrUk8w=='', [SecurityStamp] = N''429195d1-e8e3-41e9-a24c-bf01ea1cc601''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''35a7744c-e006-4512-a955-fe67c2e6497d'', [PasswordHash] = N''AD3/eksA1plVMTVmPmQE195qicNJ6+85ShBxS79LCc+eyXPuRTMOG9CijZ3LEptWCQ=='', [SecurityStamp] = N''32e6c726-56a7-4dbe-84cf-429e3f7c14f3''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-02T22:54:39.8416773+03:00'', [StartDatetime] = ''2022-06-02T22:54:09.8400216+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-05T05:54:09.8418261+03:00'', [StartDatetime] = ''2022-06-04T04:54:09.8418243+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-05T05:54:09.8418268+03:00'', [StartDatetime] = ''2022-06-04T04:54:09.8418265+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-05T05:54:09.8418273+03:00'', [StartDatetime] = ''2022-06-04T04:54:09.8418271+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-05T05:54:09.8418279+03:00'', [StartDatetime] = ''2022-06-04T04:54:09.8418277+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-05T05:54:09.8418284+03:00'', [StartDatetime] = ''2022-06-04T04:54:09.8418282+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-02T21:54:09.8418289+03:00'', [StartDatetime] = ''2022-06-02T20:54:09.8418287+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-02T21:54:09.8418294+03:00'', [StartDatetime] = ''2022-06-02T20:54:09.8418292+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220602195410_ChangedOneEventDate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220602195410_ChangedOneEventDate', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    ALTER TABLE [Events] ADD [IsCreatedFromOriginal] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''0d578b12-b857-4482-aae6-4feddb227957'', [PasswordHash] = N''AB0435qHuzrkSvNKxSqC2rxLx0gLqQflkmW3hxZXr5QZiUXyLRVU+N37tnz/H5LCfw=='', [SecurityStamp] = N''036a5e22-147a-4476-aba7-27b252efa9cd''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''12207cf2-74f0-472f-8ddf-9894f4543c82'', [PasswordHash] = N''AHuWVbToMw0CaDaTy+djzh9LPsxoyUAX1lGEZcJ2ZG5+f3eF17PfOI8W79VBBYr2Sw=='', [SecurityStamp] = N''0e7635e9-7b8b-40b8-9565-2c25cb9bccd7''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-03T22:51:34.4136180+03:00'', [StartDatetime] = ''2022-06-03T22:51:04.4112422+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-06T05:51:04.4138161+03:00'', [StartDatetime] = ''2022-06-05T04:51:04.4138136+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-06T05:51:04.4138171+03:00'', [StartDatetime] = ''2022-06-05T04:51:04.4138168+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-06T05:51:04.4138178+03:00'', [StartDatetime] = ''2022-06-05T04:51:04.4138175+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-06T05:51:04.4138187+03:00'', [StartDatetime] = ''2022-06-05T04:51:04.4138184+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-06T05:51:04.4138194+03:00'', [StartDatetime] = ''2022-06-05T04:51:04.4138191+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-03T21:51:04.4138200+03:00'', [StartDatetime] = ''2022-06-03T20:51:04.4138197+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-03T21:51:04.4138207+03:00'', [StartDatetime] = ''2022-06-03T20:51:04.4138204+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220603195105_ModifiedEventDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220603195105_ModifiedEventDB', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    CREATE TABLE [Friend] (
        [FriendId] nvarchar(450) NOT NULL,
        [UserFriendId] nvarchar(max) NULL,
        CONSTRAINT [PK_Friend] PRIMARY KEY ([FriendId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    CREATE TABLE [FriendDBUser] (
        [FriendsFriendId] nvarchar(450) NOT NULL,
        [UsersId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_FriendDBUser] PRIMARY KEY ([FriendsFriendId], [UsersId]),
        CONSTRAINT [FK_FriendDBUser_AspNetUsers_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_FriendDBUser_Friend_FriendsFriendId] FOREIGN KEY ([FriendsFriendId]) REFERENCES [Friend] ([FriendId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''492b6437-c83f-4a98-8085-9c40ff6efcc6'', [PasswordHash] = N''ABWcANjeF8njgxZ48/3kL0/e2rGMhDcpc9DPUGaGuNoQFQPIQZGV3IcSmODfHL+HFg=='', [SecurityStamp] = N''94f366f2-69f6-4cc7-ab15-513c670a323e''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''c1b543f0-22c9-454c-8139-e0d219b6b72b'', [PasswordHash] = N''APjk1z2iS1iSxksqES8MyhXKZEmRMmCkRUo+s/stKVNF/P2gk7QfgfqXQmoqHXi3Hw=='', [SecurityStamp] = N''5e803da7-baba-4dc2-b6c3-a68a4e7a3176''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T02:02:44.6250882+03:00'', [StartDatetime] = ''2022-06-08T02:02:14.6233264+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:02:14.6252450+03:00'', [StartDatetime] = ''2022-06-09T08:02:14.6252431+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:02:14.6252458+03:00'', [StartDatetime] = ''2022-06-09T08:02:14.6252455+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:02:14.6252463+03:00'', [StartDatetime] = ''2022-06-09T08:02:14.6252461+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:02:14.6252470+03:00'', [StartDatetime] = ''2022-06-09T08:02:14.6252467+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:02:14.6252475+03:00'', [StartDatetime] = ''2022-06-09T08:02:14.6252473+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T01:02:14.6252480+03:00'', [StartDatetime] = ''2022-06-08T00:02:14.6252478+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T01:02:14.6252485+03:00'', [StartDatetime] = ''2022-06-08T00:02:14.6252483+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    CREATE INDEX [IX_FriendDBUser_UsersId] ON [FriendDBUser] ([UsersId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607230215_Friends')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220607230215_Friends', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    DROP TABLE [FriendDBUser];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    DROP TABLE [Friend];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE TABLE [Comments] (
        [CommentId] nvarchar(450) NOT NULL,
        [Comment] nvarchar(max) NULL,
        [AuthorId] nvarchar(450) NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([CommentId]),
        CONSTRAINT [FK_Comments_AspNetUsers_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE TABLE [FriendInvitations] (
        [FriendInvitationId] nvarchar(450) NOT NULL,
        [AuthorId] nvarchar(450) NULL,
        [UserReceiverId] nvarchar(max) NULL,
        [IsConfirmed] bit NOT NULL,
        [IsRejected] bit NOT NULL,
        CONSTRAINT [PK_FriendInvitations] PRIMARY KEY ([FriendInvitationId]),
        CONSTRAINT [FK_FriendInvitations_AspNetUsers_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE TABLE [Friends] (
        [FriendId] nvarchar(450) NOT NULL,
        [UserId] nvarchar(450) NULL,
        [UserFriendId] nvarchar(max) NULL,
        CONSTRAINT [PK_Friends] PRIMARY KEY ([FriendId]),
        CONSTRAINT [FK_Friends_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE TABLE [Reviews] (
        [ReviewId] nvarchar(450) NOT NULL,
        [Rate] int NOT NULL,
        [AuthorId] nvarchar(450) NULL,
        [EventId] nvarchar(450) NULL,
        CONSTRAINT [PK_Reviews] PRIMARY KEY ([ReviewId]),
        CONSTRAINT [FK_Reviews_AspNetUsers_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Reviews_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([EventId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''e9004be9-0454-4e05-8f95-8396477e9ee9'', [PasswordHash] = N''AK84aH2cce/x0qnSTmKAV82b/KqucG0LAYbwAYnaw2KQTPEYjdwIa49qHwr0GtGutw=='', [SecurityStamp] = N''763a2c77-ee2c-47aa-81d7-cd89a77bf532''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''680b1a3d-d74a-41bc-9683-3482c7bf2928'', [PasswordHash] = N''AJfigdPdyLlajFlVcq1tlex3L+UFEsvf8nlY24MvW7IyyT18GISCB14eH+g6Kgo6kg=='', [SecurityStamp] = N''d1905867-0ed6-4524-bcc8-bdbf0cd765cb''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T02:40:35.7728235+03:00'', [StartDatetime] = ''2022-06-08T02:40:05.7701175+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:40:05.7730375+03:00'', [StartDatetime] = ''2022-06-09T08:40:05.7730349+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:40:05.7730385+03:00'', [StartDatetime] = ''2022-06-09T08:40:05.7730381+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:40:05.7730393+03:00'', [StartDatetime] = ''2022-06-09T08:40:05.7730390+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:40:05.7730401+03:00'', [StartDatetime] = ''2022-06-09T08:40:05.7730398+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-10T09:40:05.7730410+03:00'', [StartDatetime] = ''2022-06-09T08:40:05.7730405+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T01:40:05.7730421+03:00'', [StartDatetime] = ''2022-06-08T00:40:05.7730417+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-08T01:40:05.7730429+03:00'', [StartDatetime] = ''2022-06-08T00:40:05.7730426+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE INDEX [IX_Comments_AuthorId] ON [Comments] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE INDEX [IX_FriendInvitations_AuthorId] ON [FriendInvitations] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE INDEX [IX_Friends_UserId] ON [Friends] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE INDEX [IX_Reviews_AuthorId] ON [Reviews] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    CREATE INDEX [IX_Reviews_EventId] ON [Reviews] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220607234006_AddEntities')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220607234006_AddEntities', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    ALTER TABLE [Events] ADD [OriginalEventId] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''2be1f221-c00b-404f-a509-543fb7171c71'', [PasswordHash] = N''AJNvOHgYa7UV+wu/BCOB34bvFKRlN7vzviQpybdjdzFj2gkQ4dKoYIfVyLjw309Jhw=='', [SecurityStamp] = N''80f1aebe-d0f8-40a5-91b4-ac24027a29fc''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''3eb48e42-481b-412b-9730-3c15464ecc44'', [PasswordHash] = N''AGyt0Vx9oqW+W5L04ZK+KUuZ23iRpQE7MnmiPDZVdPhOWFnd1L7Mx8peFHo2qszOeQ=='', [SecurityStamp] = N''bd9e06a6-24db-445e-9b8f-966281a4ca22''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-12T15:51:39.9635884+03:00'', [StartDatetime] = ''2022-06-12T15:51:09.9620322+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-14T22:51:09.9637340+03:00'', [StartDatetime] = ''2022-06-13T21:51:09.9637319+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-14T22:51:09.9637347+03:00'', [StartDatetime] = ''2022-06-13T21:51:09.9637344+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-14T22:51:09.9637352+03:00'', [StartDatetime] = ''2022-06-13T21:51:09.9637350+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-14T22:51:09.9637357+03:00'', [StartDatetime] = ''2022-06-13T21:51:09.9637355+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-14T22:51:09.9637362+03:00'', [StartDatetime] = ''2022-06-13T21:51:09.9637360+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-12T14:51:09.9637367+03:00'', [StartDatetime] = ''2022-06-12T13:51:09.9637365+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-12T14:51:09.9637371+03:00'', [StartDatetime] = ''2022-06-12T13:51:09.9637369+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220612125110_ModifiedEventDBOriginalEvent')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220612125110_ModifiedEventDBOriginalEvent', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    ALTER TABLE [Comments] ADD [EventId] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''8909b3bc-37c5-4493-b1a8-657118a299f7'', [PasswordHash] = N''AP3oxsVrKFvFI5VpNq8oIXHGcAcI66+prqU9Rujus5waq5Txp7RpkNeqTIj7tcIa5Q=='', [SecurityStamp] = N''a5f3c6b5-f0da-4cd5-8504-30aecd26c760''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''fd8b9401-ee9f-4f63-8324-921118956a82'', [PasswordHash] = N''AAAlUBztYMormKkby77oPJ2xbnIpkCdwMTvCjvbXGOv/ivdig1koOsddWNiYZg+aNQ=='', [SecurityStamp] = N''e59cdf09-42a0-4cc0-bfe2-3a1351758898''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T19:25:43.9545723+03:00'', [StartDatetime] = ''2022-06-13T19:25:13.9529870+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:25:13.9547223+03:00'', [StartDatetime] = ''2022-06-15T01:25:13.9547205+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:25:13.9547230+03:00'', [StartDatetime] = ''2022-06-15T01:25:13.9547228+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:25:13.9547236+03:00'', [StartDatetime] = ''2022-06-15T01:25:13.9547233+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:25:13.9547241+03:00'', [StartDatetime] = ''2022-06-15T01:25:13.9547239+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:25:13.9547247+03:00'', [StartDatetime] = ''2022-06-15T01:25:13.9547244+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T18:25:13.9547255+03:00'', [StartDatetime] = ''2022-06-13T17:25:13.9547252+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T18:25:13.9547263+03:00'', [StartDatetime] = ''2022-06-13T17:25:13.9547259+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    ALTER TABLE [Comments] ADD CONSTRAINT [FK_Comments_Events_CommentId] FOREIGN KEY ([CommentId]) REFERENCES [Events] ([EventId]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613162514_AddComments')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220613162514_AddComments', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    ALTER TABLE [Comments] ADD [DateAdded] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''69618bc4-33e8-4a9a-af3c-46d0ed941975'', [PasswordHash] = N''ABXXkiYDcYtPkRLCyMzh1i+Aku9b0RPLAWZnt7JVPqwWCqEJI2D3xHuD1DxtA7Qhmw=='', [SecurityStamp] = N''2df55535-968c-49be-b7b5-55e96e6ccd92''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''ef1dfda6-5897-4a58-a32b-8d6eb4562467'', [PasswordHash] = N''ACJEJeTvcAMuEQvm6XyZ13cy3pjVA8Lwerjh+E97uvf4IRaui1VgwKziDgOnH2f59g=='', [SecurityStamp] = N''fb05e59b-7140-4e91-adef-569516899f48''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T19:31:56.6990339+03:00'', [StartDatetime] = ''2022-06-13T19:31:26.6973634+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:31:26.6991784+03:00'', [StartDatetime] = ''2022-06-15T01:31:26.6991764+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:31:26.6991791+03:00'', [StartDatetime] = ''2022-06-15T01:31:26.6991789+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:31:26.6991796+03:00'', [StartDatetime] = ''2022-06-15T01:31:26.6991794+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:31:26.6991801+03:00'', [StartDatetime] = ''2022-06-15T01:31:26.6991799+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T02:31:26.6991806+03:00'', [StartDatetime] = ''2022-06-15T01:31:26.6991804+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T18:31:26.6991811+03:00'', [StartDatetime] = ''2022-06-13T17:31:26.6991809+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T18:31:26.6991816+03:00'', [StartDatetime] = ''2022-06-13T17:31:26.6991814+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613163127_M')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220613163127_M', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''c13c1ef5-191c-4c30-b807-27707f2e6bad'', [PasswordHash] = N''AKzPdVBodILqVzNlASHwKRbpVn3uKAfhKaP6S/QPDTiEhzeoqDL+1JhIb1SZknA7+Q=='', [SecurityStamp] = N''38a26594-db01-452c-933a-bc2a5b0b0528''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''cecd2ac0-a518-48ca-a58a-4123c566770f'', [PasswordHash] = N''ALmHnCVNC/TPiVKk4ipZ7wzEqAJ+TR8j+xcjOxH2pDvEcRUgB/tWkBZIRraZ0w38NQ=='', [SecurityStamp] = N''86730508-9e0f-4d54-946d-19d1def6cdb9''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T21:31:14.4048285+03:00'', [StartDatetime] = ''2022-06-13T21:30:44.4026926+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:30:44.4049851+03:00'', [StartDatetime] = ''2022-06-15T03:30:44.4049832+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:30:44.4049858+03:00'', [StartDatetime] = ''2022-06-15T03:30:44.4049856+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:30:44.4049864+03:00'', [StartDatetime] = ''2022-06-15T03:30:44.4049861+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:30:44.4049869+03:00'', [StartDatetime] = ''2022-06-15T03:30:44.4049867+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:30:44.4049874+03:00'', [StartDatetime] = ''2022-06-15T03:30:44.4049872+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T20:30:44.4049879+03:00'', [StartDatetime] = ''2022-06-13T19:30:44.4049877+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T20:30:44.4049885+03:00'', [StartDatetime] = ''2022-06-13T19:30:44.4049882+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183045_Modify')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220613183045_Modify', N'5.0.13');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    ALTER TABLE [Comments] DROP CONSTRAINT [FK_Comments_Events_CommentId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Comments]') AND [c].[name] = N'EventId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Comments] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Comments] ALTER COLUMN [EventId] nvarchar(450) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''6d6087f9-fdf0-486c-bd6c-4429f3a8b341'', [PasswordHash] = N''AFXF9nkGWFoSKzoJDkWvEKDhJXzCEcTN5/AblDPtxQfZRE6wNGUjfEkM3TLH600H0g=='', [SecurityStamp] = N''373e99b6-3017-4df3-9b74-696ab786d1c7''
    WHERE [Id] = N''b74ddd14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''5da4e820-ef2e-4a7b-a251-5ef7fb0ddf45'', [PasswordHash] = N''AAtPrMILMdS5pnar4y17AcMY4GoULBNeRkEOiMs3/Z83tBLuQ9JO2/SRepjjolJx3Q=='', [SecurityStamp] = N''9425a10a-e005-4eb4-8729-ba579a86aa0c''
    WHERE [Id] = N''c74ddf14-6340-4840-95c2-db12554843e5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T21:32:53.0207104+03:00'', [StartDatetime] = ''2022-06-13T21:32:23.0185658+03:00''
    WHERE [EventId] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:32:23.0208843+03:00'', [StartDatetime] = ''2022-06-15T03:32:23.0208820+03:00''
    WHERE [EventId] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:32:23.0208851+03:00'', [StartDatetime] = ''2022-06-15T03:32:23.0208848+03:00''
    WHERE [EventId] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:32:23.0208857+03:00'', [StartDatetime] = ''2022-06-15T03:32:23.0208855+03:00''
    WHERE [EventId] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:32:23.0208863+03:00'', [StartDatetime] = ''2022-06-15T03:32:23.0208860+03:00''
    WHERE [EventId] = N''5'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-16T04:32:23.0208868+03:00'', [StartDatetime] = ''2022-06-15T03:32:23.0208865+03:00''
    WHERE [EventId] = N''6'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T20:32:23.0208873+03:00'', [StartDatetime] = ''2022-06-13T19:32:23.0208870+03:00''
    WHERE [EventId] = N''7'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    EXEC(N'UPDATE [Events] SET [EndDatetime] = ''2022-06-13T20:32:23.0208878+03:00'', [StartDatetime] = ''2022-06-13T19:32:23.0208876+03:00''
    WHERE [EventId] = N''8'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    CREATE INDEX [IX_Comments_EventId] ON [Comments] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    ALTER TABLE [Comments] ADD CONSTRAINT [FK_Comments_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([EventId]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220613183223_ModifyComments')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220613183223_ModifyComments', N'5.0.13');
END;
GO

COMMIT;
GO

