CREATE TABLE [dbo].[awards] (
  [Id] [nchar](10) NOT NULL,
  [Name] [varchar](50) NOT NULL,
  [Album.Id] [nchar](10) NOT NULL,
  [Year] [date] NOT NULL,
  PRIMARY KEY CLUSTERED ([Id]),
  UNIQUE ([Album.Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[awards]
  ADD CONSTRAINT [awards_ibfk_1] FOREIGN KEY ([Album.Id]) REFERENCES [dbo].[Albums] ([Id]) ON UPDATE CASCADE
GO