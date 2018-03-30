IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [DifficultyLevel] (
        [DifficultyId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_DifficultyLevel] PRIMARY KEY ([DifficultyId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [ExerciseTemplates] (
        [ExerciseTemplateId] uniqueidentifier NOT NULL,
        [Description] nvarchar(max) NULL,
        [Name] nvarchar(20) NOT NULL,
        [Metrics_Capacity] int NOT NULL,
        CONSTRAINT [PK_ExerciseTemplates] PRIMARY KEY ([ExerciseTemplateId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [MetricTypes] (
        [MetricTypeId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_MetricTypes] PRIMARY KEY ([MetricTypeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [MuscleCategories] (
        [MuscleCategoryId] uniqueidentifier NOT NULL,
        [Name] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_MuscleCategories] PRIMARY KEY ([MuscleCategoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [Trainings] (
        [TrainingId] uniqueidentifier NOT NULL,
        [Comment] nvarchar(max) NULL,
        [CreationDate] datetime2 NOT NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [Name] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Trainings] PRIMARY KEY ([TrainingId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [MuscleGroups] (
        [MuscleGroupId] uniqueidentifier NOT NULL,
        [MuscleCategoryId] uniqueidentifier NOT NULL,
        [Name] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_MuscleGroups] PRIMARY KEY ([MuscleGroupId]),
        CONSTRAINT [FK_MuscleGroups_MuscleCategories_MuscleCategoryId] FOREIGN KEY ([MuscleCategoryId]) REFERENCES [MuscleCategories] ([MuscleCategoryId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [Exercises] (
        [ExerciseId] uniqueidentifier NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [Name] nvarchar(20) NOT NULL,
        [TrainingId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Exercises] PRIMARY KEY ([ExerciseId]),
        CONSTRAINT [FK_Exercises_Trainings_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Trainings] ([TrainingId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [TrainingMuscleCategories] (
        [MuscleCategoryId] uniqueidentifier NOT NULL,
        [TrainingId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_TrainingMuscleCategories] PRIMARY KEY ([MuscleCategoryId], [TrainingId]),
        CONSTRAINT [FK_TrainingMuscleCategories_MuscleCategories_MuscleCategoryId] FOREIGN KEY ([MuscleCategoryId]) REFERENCES [MuscleCategories] ([MuscleCategoryId]) ON DELETE CASCADE,
        CONSTRAINT [FK_TrainingMuscleCategories_Trainings_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Trainings] ([TrainingId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [ExerciseTemplateCoreMuscleGroups] (
        [ExerciseTemplateId] uniqueidentifier NOT NULL,
        [MuscleGroupId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_ExerciseTemplateCoreMuscleGroups] PRIMARY KEY ([ExerciseTemplateId], [MuscleGroupId]),
        CONSTRAINT [FK_ExerciseTemplateCoreMuscleGroups_ExerciseTemplates_ExerciseTemplateId] FOREIGN KEY ([ExerciseTemplateId]) REFERENCES [ExerciseTemplates] ([ExerciseTemplateId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ExerciseTemplateCoreMuscleGroups_MuscleGroups_MuscleGroupId] FOREIGN KEY ([MuscleGroupId]) REFERENCES [MuscleGroups] ([MuscleGroupId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [ExerciseTemplateSuppMuscleGroups] (
        [ExerciseTemplateId] uniqueidentifier NOT NULL,
        [MuscleGroupId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_ExerciseTemplateSuppMuscleGroups] PRIMARY KEY ([ExerciseTemplateId], [MuscleGroupId]),
        CONSTRAINT [FK_ExerciseTemplateSuppMuscleGroups_ExerciseTemplates_ExerciseTemplateId] FOREIGN KEY ([ExerciseTemplateId]) REFERENCES [ExerciseTemplates] ([ExerciseTemplateId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ExerciseTemplateSuppMuscleGroups_MuscleGroups_MuscleGroupId] FOREIGN KEY ([MuscleGroupId]) REFERENCES [MuscleGroups] ([MuscleGroupId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [ExerciseCoreMuscleGroup] (
        [ExcersiceId] uniqueidentifier NOT NULL,
        [MuscleGroupId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_ExerciseCoreMuscleGroup] PRIMARY KEY ([ExcersiceId], [MuscleGroupId]),
        CONSTRAINT [FK_ExerciseCoreMuscleGroup_Exercises_ExcersiceId] FOREIGN KEY ([ExcersiceId]) REFERENCES [Exercises] ([ExerciseId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ExerciseCoreMuscleGroup_MuscleGroups_MuscleGroupId] FOREIGN KEY ([MuscleGroupId]) REFERENCES [MuscleGroups] ([MuscleGroupId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [ExerciseSuppMuscleGroup] (
        [ExcersiceId] uniqueidentifier NOT NULL,
        [MuscleGroupId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_ExerciseSuppMuscleGroup] PRIMARY KEY ([ExcersiceId], [MuscleGroupId]),
        CONSTRAINT [FK_ExerciseSuppMuscleGroup_Exercises_ExcersiceId] FOREIGN KEY ([ExcersiceId]) REFERENCES [Exercises] ([ExerciseId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ExerciseSuppMuscleGroup_MuscleGroups_MuscleGroupId] FOREIGN KEY ([MuscleGroupId]) REFERENCES [MuscleGroups] ([MuscleGroupId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [Sets] (
        [SetId] uniqueidentifier NOT NULL,
        [DifficultyId] int NULL,
        [ExerciseId] uniqueidentifier NULL,
        [ExericeId] uniqueidentifier NOT NULL,
        [Metrics_Distance] float NOT NULL,
        [Metrics_Duration] float NOT NULL,
        [Metrics_Repetitions] int NOT NULL,
        [Metrics_Weight] float NOT NULL,
        CONSTRAINT [PK_Sets] PRIMARY KEY ([SetId]),
        CONSTRAINT [FK_Sets_DifficultyLevel_DifficultyId] FOREIGN KEY ([DifficultyId]) REFERENCES [DifficultyLevel] ([DifficultyId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Sets_Exercises_ExerciseId] FOREIGN KEY ([ExerciseId]) REFERENCES [Exercises] ([ExerciseId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [MetricValues] (
        [MetricValueId] int NOT NULL IDENTITY,
        [MetricId] int NOT NULL,
        [SetId] uniqueidentifier NULL,
        [Value] float NOT NULL,
        CONSTRAINT [PK_MetricValues] PRIMARY KEY ([MetricValueId]),
        CONSTRAINT [FK_MetricValues_Sets_SetId] FOREIGN KEY ([SetId]) REFERENCES [Sets] ([SetId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE TABLE [Metrics] (
        [MetricId] int NOT NULL IDENTITY,
        [ExerciseTemplateId] uniqueidentifier NOT NULL,
        [MetricTypeId] int NOT NULL,
        [MetricValueId] int NOT NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Metrics] PRIMARY KEY ([MetricId]),
        CONSTRAINT [FK_Metrics_ExerciseTemplates_ExerciseTemplateId] FOREIGN KEY ([ExerciseTemplateId]) REFERENCES [ExerciseTemplates] ([ExerciseTemplateId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Metrics_MetricTypes_MetricTypeId] FOREIGN KEY ([MetricTypeId]) REFERENCES [MetricTypes] ([MetricTypeId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Metrics_MetricValues_MetricValueId] FOREIGN KEY ([MetricValueId]) REFERENCES [MetricValues] ([MetricValueId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_ExerciseCoreMuscleGroup_MuscleGroupId] ON [ExerciseCoreMuscleGroup] ([MuscleGroupId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_Exercises_TrainingId] ON [Exercises] ([TrainingId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_ExerciseSuppMuscleGroup_MuscleGroupId] ON [ExerciseSuppMuscleGroup] ([MuscleGroupId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_ExerciseTemplateCoreMuscleGroups_MuscleGroupId] ON [ExerciseTemplateCoreMuscleGroups] ([MuscleGroupId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_ExerciseTemplateSuppMuscleGroups_MuscleGroupId] ON [ExerciseTemplateSuppMuscleGroups] ([MuscleGroupId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_Metrics_ExerciseTemplateId] ON [Metrics] ([ExerciseTemplateId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_Metrics_MetricTypeId] ON [Metrics] ([MetricTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE UNIQUE INDEX [IX_Metrics_MetricValueId] ON [Metrics] ([MetricValueId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_MetricValues_SetId] ON [MetricValues] ([SetId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_MuscleGroups_MuscleCategoryId] ON [MuscleGroups] ([MuscleCategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_Sets_DifficultyId] ON [Sets] ([DifficultyId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_Sets_ExerciseId] ON [Sets] ([ExerciseId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    CREATE INDEX [IX_TrainingMuscleCategories_TrainingId] ON [TrainingMuscleCategories] ([TrainingId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180324191002_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180324191002_Initial', N'2.0.2-rtm-10011');
END;

GO

