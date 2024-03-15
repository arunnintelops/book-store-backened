CREATE DATABASE bookstorebackend;
USE bookstorebackend;
CREATE TABLE [dbo].[Publisher](
    [Name] [nvarchar](50) NULL,
    [Address] [nvarchar](255) NULL,
    [Phone] [nvarchar](20) NULL,
CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED
(
    [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];
