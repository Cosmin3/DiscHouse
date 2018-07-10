CREATE TABLE [dbo].[users] (
  [Id] [nchar](10) NOT NULL,
  [Name] [varchar](56) NOT NULL,
  [Password] [varchar](25) NOT NULL,
  [Rights] [nchar](1) NOT NULL,
  PRIMARY KEY CLUSTERED ([Id])
)
ON [PRIMARY]
GO