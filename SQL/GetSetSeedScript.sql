USE [GetSet]
GO

set identity_insert [UserProfile] on;
INSERT INTO "UserProfile" ("Id","FirstName", "LastName", "Email", "FirebaseUserId", IsAdmin, IsActive) 
VALUES 
(1, 'Wes', 'Mitchell', 'wmdrums@gmail.com', 'b3GhpC5vTFO7ddbMabxEk6p0Kv23', 1, 1),
(2, 'Benny', 'Greb', 'benny@greb.com', 'gtLwTp6UepMHp9LFl2CdH5xBnW93', 0, 1)
set identity_insert [UserProfile] off;

set identity_insert [Band] on;
INSERT INTO "Band" ("Id","Name", "UserProfileId")
VALUES 
(1, 'Megajoos', 1),
(2, 'Moving Parts', 2),
(3, 'Penicillin Baby', 1),
(4, 'Thunder Brother', 1),
(5, 'Bully', 1),
(6, 'Benny G Quartet', 2)
set identity_insert [Band] off;

set identity_insert [Playlist] on;
INSERT INTO "Playlist" ("Id", "Description", "UserProfileId", "BandId")
VALUES 
(1, 'Riot Fest', 1, 5),
(2, 'Namm Show Performance', 2, 6)
set identity_insert [Playlist] off;

set identity_insert [Track] on;
INSERT INTO "Track" ("Id", "Name", "Bpm", "Notes", "UserProfileId", "BandId", "RunTime")
VALUES 
(1, 'Trying', 120, 'Keep it solid', 1, 5, '00:03:20'),
(2, 'Feel the Same', 135, 'Do not speed up', 1, 5, '00:03:45'),
(3, 'Focused', 100, 'Start on floor tom', 1, 5, '00:04:25'),
(4, 'I Remember', 135, 'Smash the Drums', 1, 5, '00:01:50'),
(5, 'Where To Start', 155, 'No Shift in Tempo', 1, 5, '00:03:13')
set identity_insert [Track] off;

set identity_insert [PlaylistTrack] on;
INSERT INTO "PlaylistTrack" ("Id", "SequenceOrder", "PlaylistId", "TrackId")
VALUES 
(1, 1, 1, 1),
(2, 2, 1, 2),
(3, 3, 1, 3),
(4, 4, 1, 4),
(5, 5, 1, 5)
set identity_insert [PlaylistTrack] off;












