USE ExcursionsDB;

--DROP DATABASE ExcursionsDB;

SET IDENTITY_INSERT [dbo].[Guides] ON
INSERT INTO [dbo].[Guides]([GuideID], [FirstName], [LastName])
VALUES (1, 'Nathan', 'Malkivic')
SET IDENTITY_INSERT [dbo].[Guides] OFF

SET IDENTITY_INSERT [dbo].[Tours] ON
INSERT INTO [dbo].[Tours]([TourID], [TourName], [Price], [GuideID])
VALUES (1, 'Amsterdam center sightseeing', 9.00, 1)
SET IDENTITY_INSERT [dbo].[Tours] OFF


SET IDENTITY_INSERT [dbo].[Schedule] ON
INSERT INTO [dbo].[Schedule]([ScheduleEntryID], [TourName], [StartTime], [TourID])
VALUES (1, 'Amsterdam center sightseeing', CONVERT(DATETIME,'18-06-12 10:34:09 PM',5), 1);
SET IDENTITY_INSERT [dbo].[Schedule] OFF

SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers]([CustomerID], [FirstName], [LastName], [ScheduleEntryID])
VALUES (1, 'Sonia', 'Miler', 1),
	   (2, 'John', 'Dou', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF

SET IDENTITY_INSERT [dbo].[Places] ON
INSERT INTO [dbo].[Places]([PlaceID], [PlaceName])
VALUES (1, 'The Torensluis Bridge'),
	   (2, 'Heiniken Museum')
SET IDENTITY_INSERT [dbo].[Places] OFF

INSERT INTO [dbo].[PlaceTours]([Place_PlaceID], [Tour_TourID])
VALUES (1, 1),
	   (2, 1)
SET IDENTITY_INSERT [dbo].[Places] OFF