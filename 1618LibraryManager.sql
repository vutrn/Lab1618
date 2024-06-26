USE [master]
GO
/****** Object:  Database [1618LibraryManager]    Script Date: 09-04-2024 12:20:53 AM ******/
CREATE DATABASE [1618LibraryManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'1618LibraryManager', FILENAME = N'A:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\1618LibraryManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'1618LibraryManager_log', FILENAME = N'A:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\1618LibraryManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [1618LibraryManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [1618LibraryManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [1618LibraryManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [1618LibraryManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [1618LibraryManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [1618LibraryManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [1618LibraryManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [1618LibraryManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [1618LibraryManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [1618LibraryManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [1618LibraryManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [1618LibraryManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [1618LibraryManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [1618LibraryManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [1618LibraryManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [1618LibraryManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [1618LibraryManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [1618LibraryManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [1618LibraryManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [1618LibraryManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [1618LibraryManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [1618LibraryManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [1618LibraryManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [1618LibraryManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [1618LibraryManager] SET  MULTI_USER 
GO
ALTER DATABASE [1618LibraryManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [1618LibraryManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [1618LibraryManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [1618LibraryManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [1618LibraryManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [1618LibraryManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [1618LibraryManager] SET QUERY_STORE = ON
GO
ALTER DATABASE [1618LibraryManager] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [1618LibraryManager]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 09-04-2024 12:20:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[book_name] [nvarchar](max) NULL,
	[author_name] [nvarchar](max) NULL,
	[genre_name] [nvarchar](max) NULL,
	[isBorrowed] [bit] NULL,
	[publication_date] [date] NULL,
	[std_id] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 09-04-2024 12:20:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[std_id] [int] IDENTITY(1,1) NOT NULL,
	[std_name] [nvarchar](max) NOT NULL,
	[std_gmail] [nvarchar](max) NOT NULL,
	[std_phone_number] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[std_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (114, N'300 Bai Code Thieu Nhi', N'Vu Tran', N'Education', 1, CAST(N'2024-04-04' AS Date), 49)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (115, N'The Hobbit', N'Tolkien', N'Fantasy', 1, CAST(N'2024-04-04' AS Date), 57)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (117, N'Triet Hoc Mac-Lenin', N'NXB BGD', N'Education', 0, CAST(N'2024-04-05' AS Date), NULL)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (118, N'One Piece', N'Eiichiro Oda', N'Fantasy', 0, CAST(N'2024-04-05' AS Date), NULL)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (120, N'Cinderella', N'The Brothers Grimm', N'Fairy Tale', 0, CAST(N'2024-04-06' AS Date), NULL)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (121, N'Attack On Titan', N'Hajime Isayama', N'Dark Fantasy', 0, CAST(N'2024-04-06' AS Date), NULL)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (122, N'The Little Mermaid', N'Andersen', N'Fairy Tale', 1, CAST(N'2024-04-06' AS Date), 69)
INSERT [dbo].[Book] ([book_id], [book_name], [author_name], [genre_name], [isBorrowed], [publication_date], [std_id]) VALUES (123, N'Beauty and the Beast', N'Beaumont', N'Fairy Tale', 1, CAST(N'2024-04-06' AS Date), 68)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (37, N'Vu', N'a@.com', 12112)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (38, N'Vu', N'a@.com', 12112)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (39, N'Vu', N'@', 123)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (40, N'Vu', N'@', 123)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (41, N'Vu', N'@', 123)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (49, N'Vu', N'a@g.c', 123213)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (57, N'Tran Huy Vu', N'@', 75876)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (60, N'1', N'12', 12)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (61, N'Vutran', N'@a', 12345)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (63, N'123', N'123', 23)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (64, N'12', N'33', 123)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (65, N'1', N'12', 2)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (66, N'Tran Vu', N'vu@gmail.com', 123456)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (67, N'1', N'2', 12)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (68, N'Vu Tran', N'vu@gmail.com', 123455)
INSERT [dbo].[Student] ([std_id], [std_name], [std_gmail], [std_phone_number]) VALUES (69, N'Phong', N'phong@g.com', 123456)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_isBorrowed]  DEFAULT ((0)) FOR [isBorrowed]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Student] FOREIGN KEY([std_id])
REFERENCES [dbo].[Student] ([std_id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Student]
GO
USE [master]
GO
ALTER DATABASE [1618LibraryManager] SET  READ_WRITE 
GO
