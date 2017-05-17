CREATE DATABASE ExcursionsDB
GO

USE ExcursionsDB
GO

CREATE TABLE [dbo].[Customers] (
    [CustomerID] [int] NOT NULL IDENTITY,
    [FirstName] [nvarchar](30) NOT NULL,
    [LastName] [nvarchar](30) NOT NULL,
    [ScheduleEntryID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([CustomerID])
)
GO 

CREATE TABLE [dbo].[Schedule] (
    [ScheduleEntryID] [int] NOT NULL IDENTITY,
    [TourName] [nvarchar](50),
    [StartTime] [datetime] NOT NULL,
    [TourID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Schedule] PRIMARY KEY ([ScheduleEntryID])
)
GO

CREATE TABLE [dbo].[Tours] (
    [TourID] [int] NOT NULL IDENTITY,
    [TourName] [nvarchar](50) NOT NULL,
    [Price] [money],
    [GuideID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Tours] PRIMARY KEY ([TourID])
)
GO

CREATE TABLE [dbo].[Guides] (
    [GuideID] [int] NOT NULL IDENTITY,
    [FirstName] [nvarchar](30) NOT NULL,
    [LastName] [nvarchar](30) NOT NULL,
    CONSTRAINT [PK_dbo.Guides] PRIMARY KEY ([GuideID])
)
GO

CREATE TABLE [dbo].[Places] (
    [PlaceID] [int] NOT NULL IDENTITY,
    [PlaceName] [nvarchar](50) NOT NULL,
    CONSTRAINT [PK_dbo.Places] PRIMARY KEY ([PlaceID])
)
GO

CREATE TABLE [dbo].[PlaceTours] (
    [Place_PlaceID] [int] NOT NULL,
    [Tour_TourID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.PlaceTours] PRIMARY KEY ([Place_PlaceID], [Tour_TourID])
)
GO

ALTER TABLE [dbo].[Customers] 
ADD CONSTRAINT [FK_dbo.Customers_dbo.Schedule_Schedule_ScheduleEntryID] 
FOREIGN KEY ([ScheduleEntryID]) REFERENCES [dbo].[Schedule] ([ScheduleEntryID]) 
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Schedule] 
ADD CONSTRAINT [FK_dbo.Schedule_dbo.Tours_TourID] 
FOREIGN KEY ([TourID]) REFERENCES [dbo].[Tours] ([TourID]) 
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Tours] 
ADD CONSTRAINT [FK_dbo.Tours_dbo.Guides_GuideID] 
FOREIGN KEY ([GuideID]) REFERENCES [dbo].[Guides] ([GuideID]) 
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PlaceTours] 
ADD CONSTRAINT [FK_dbo.PlaceTours_dbo.Places_Place_PlaceID] 
FOREIGN KEY ([Place_PlaceID]) REFERENCES [dbo].[Places] ([PlaceID]) 
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PlaceTours] 
ADD CONSTRAINT [FK_dbo.PlaceTours_dbo.Tours_Tour_TourID]
FOREIGN KEY ([Tour_TourID]) REFERENCES [dbo].[Tours] ([TourID]) 
ON DELETE CASCADE
GO


   
