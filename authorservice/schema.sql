CREATE DATABASE bookstorebackend;
USE bookstorebackend;
CREATE TABLE [dbo].[Author](
    [Name] [nvarchar](50) NULL,
    [Available] [bit] NOT NULL,
    [Popularity] [int] NULL,
    [Ratings] [int] NULL,
    [Age] [int] NULL,
CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED
(
    [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];
