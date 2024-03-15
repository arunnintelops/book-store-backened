CREATE DATABASE bookstorebackend;
USE bookstorebackend;
CREATE TABLE [dbo].[Book](
    [Title] [nvarchar](50) NULL,
    [PageCount] [int] NULL,
    [Language] [nvarchar](20) NULL,
    [Description] [nvarchar](255) NULL,
    [PublishDate] [nvarchar](255) NULL,
    [ISBN] [nvarchar](100) NOT NULL UNIQUE,
CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED
(
    [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];
