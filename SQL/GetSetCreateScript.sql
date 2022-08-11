USE [master]

IF db_id('GetSet') IS NULL
  CREATE DATABASE [GetSet]
GO

USE [GetSet]
GO

DROP TABLE IF EXISTS [PlaylistTrack];
DROP TABLE IF EXISTS [Playlist];
DROP TABLE IF EXISTS [Track];
DROP TABLE IF EXISTS [Band];
DROP TABLE IF EXISTS [UserProfile];
GO

CREATE TABLE [UserProfile] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [FirstName] nvarchar(255) NOT NULL,
  [LastName] nvarchar(255) NOT NULL,
  [Email] nvarchar(255) NOT NULL,
  [FirebaseUserId] nvarchar(255) NOT NULL,
  [IsAdmin] bit NOT NULL,
  [IsActive] bit NOT NULL DEFAULT ('true')
)
GO

CREATE TABLE [Track] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Name] nvarchar(255) NOT NULL,
  [Bpm] int NOT NULL,
  [Notes] nvarchar(255) NOT NULL,
  [UserProfileId] int NOT NULL,
  [BandId] int NOT NULL,
  [RunTime] Time NOT NULL
)
GO

CREATE TABLE [Playlist] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [UserProfileId] int NOT NULL,
  [Description] nvarchar(255) NOT NULL,
  [BandId] int NOT NULL
)
GO

CREATE TABLE [Band] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Name] nvarchar(255) NOT NULL,
  [UserProfileId] int NOT NULL,
  [PlaylistId] int NULL
)
GO

CREATE TABLE [PlaylistTrack] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [SequenceOrder] int NOT NULL,
  [PlaylistId] int NOT NULL,
  [TrackId] int NOT NULL
)
GO

ALTER TABLE [Band] ADD FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])
GO

ALTER TABLE [PlaylistTrack] ADD FOREIGN KEY ([PlaylistId]) REFERENCES [Playlist] ([Id])
GO

ALTER TABLE [Playlist] ADD FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])
GO

ALTER TABLE [PlaylistTrack] ADD FOREIGN KEY ([TrackId]) REFERENCES [Track] ([Id])
GO

ALTER TABLE [Playlist] ADD FOREIGN KEY ([BandId]) REFERENCES [Band] ([Id])
GO

ALTER TABLE [Track] ADD FOREIGN KEY ([BandId]) REFERENCES [Band] ([Id])
GO

ALTER TABLE [Track] ADD FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])
GO









