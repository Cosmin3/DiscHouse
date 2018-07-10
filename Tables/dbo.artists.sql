CREATE TABLE [dbo].[artists] (
  [Id] [nchar](10) NOT NULL,
  [Name] [varchar](56) NOT NULL,
  [Description] [text] NOT NULL,
  [Members] [varchar](100) NOT NULL,
  PRIMARY KEY CLUSTERED ([Id])
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[artists]
  ADD CONSTRAINT [artists_ibfk_1] FOREIGN KEY ([Id]) REFERENCES [dbo].[users] ([Id]) ON UPDATE CASCADE
GO