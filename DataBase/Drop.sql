USE ExcursionsDB
GO

ALTER TABLE [dbo].[Customers]
DROP CONSTRAINT [FK_dbo.Customers_dbo.Schedule_Schedule_ScheduleEntryID]
GO

ALTER TABLE [dbo].[PlaceTours]
DROP CONSTRAINT [FK_dbo.PlaceTours_dbo.Places_Place_PlaceID]
GO

ALTER TABLE [dbo].[PlaceTours]
DROP CONSTRAINT [FK_dbo.PlaceTours_dbo.Tours_Tour_TourID]
GO

ALTER TABLE [dbo].[Schedule]
DROP CONSTRAINT [FK_dbo.Schedule_dbo.Tours_TourID]
GO

ALTER TABLE [dbo].[Tours]
DROP CONSTRAINT [FK_dbo.Tours_dbo.Guides_GuideID]
GO


DROP TABLE [dbo].[Customers]
GO

DROP TABLE [dbo].[Schedule]
GO

DROP TABLE [dbo].[Tours]
GO

DROP TABLE [dbo].[Guides]
GO

DROP TABLE [dbo].[Places]
GO

DROP TABLE [dbo].[PlaceTours]
GO

DROP TABLE [dbo].[Users]
GO

