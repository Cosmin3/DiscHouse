CREATE TABLE [dbo].[Albums] (
  [Id] [nchar](10) NOT NULL,
  [Name] [varchar](50) NOT NULL,
  [Year] [date] NOT NULL,
  [Genre] [varchar](15) NOT NULL,
  [Artist.Id] [nchar](10) NOT NULL,
  PRIMARY KEY CLUSTERED ([Id]),
  UNIQUE ([Artist.Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Albums]
  ADD CONSTRAINT [albums_ibfk_1] FOREIGN KEY ([Artist.Id]) REFERENCES [dbo].[artists] ([Id]) ON UPDATE CASCADE
GO