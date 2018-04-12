CREATE TABLE [dbo].[songs] (
  [Id] [nchar](10) NOT NULL,
  [Album.Id] [nchar](10) NOT NULL,
  [Name] [varchar](50) NOT NULL,
  [Length] [time](5) NOT NULL,
  PRIMARY KEY CLUSTERED ([Id]),
  UNIQUE ([Album.Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[songs]
  ADD CONSTRAINT [songs_ibfk_1] FOREIGN KEY ([Album.Id]) REFERENCES [dbo].[Albums] ([Id]) ON UPDATE CASCADE
GO