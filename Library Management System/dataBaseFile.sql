USE [master]
GO
/****** Object:  Database [library_management_db]    Script Date: 10/20/2018 10:54:26 PM ******/
CREATE DATABASE [library_management_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'library_management_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.HASNAINDB123\MSSQL\DATA\library_management_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'library_management_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.HASNAINDB123\MSSQL\DATA\library_management_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [library_management_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library_management_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [library_management_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [library_management_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [library_management_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [library_management_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [library_management_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [library_management_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [library_management_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [library_management_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [library_management_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [library_management_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [library_management_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [library_management_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [library_management_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [library_management_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [library_management_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [library_management_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [library_management_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [library_management_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [library_management_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [library_management_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [library_management_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [library_management_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [library_management_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [library_management_db] SET  MULTI_USER 
GO
ALTER DATABASE [library_management_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [library_management_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [library_management_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [library_management_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [library_management_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [library_management_db] SET QUERY_STORE = OFF
GO
USE [library_management_db]
GO
/****** Object:  Table [dbo].[approved_tbl]    Script Date: 10/20/2018 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[approved_tbl](
	[approved_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[approved_date] [datetime] NOT NULL,
	[due_date] [datetime] NOT NULL,
 CONSTRAINT [PK_approved_tbl] PRIMARY KEY CLUSTERED 
(
	[approved_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category_tbl](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_type] [varchar](20) NOT NULL,
	[item_delay] [int] NOT NULL,
 CONSTRAINT [PK__category__D54EE9B41B9DA1B5] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_tbl](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [int] NOT NULL,
	[item_name] [nvarchar](50) NOT NULL,
	[item_added_date] [datetime] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_item_tbl] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loan_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loan_tbl](
	[loan_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[item_count] [int] NOT NULL,
	[loan_date] [datetime] NOT NULL,
	[category_id] [int] NOT NULL,
	[due_date] [datetime] NOT NULL,
 CONSTRAINT [PK_loan_tbl] PRIMARY KEY CLUSTERED 
(
	[loan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pending_message_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pending_message_tbl](
	[message_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[message] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_pending_message_tbl] PRIMARY KEY CLUSTERED 
(
	[message_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_registration_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_registration_tbl](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phone_no] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[type_combo_box] [int] NULL,
	[gender] [int] NULL,
	[user_register_date_time] [datetime] NULL,
 CONSTRAINT [PK_user_registration_tbl] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_type_tbl]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_type_tbl](
	[user_type_id] [int] IDENTITY(1,1) NOT NULL,
	[user_type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user_type_tbl] PRIMARY KEY CLUSTERED 
(
	[user_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[approved_tbl] ON 

INSERT [dbo].[approved_tbl] ([approved_id], [user_id], [item_id], [category_id], [approved_date], [due_date]) VALUES (1, 37, 1, 1, CAST(N'2018-10-19T11:11:40.000' AS DateTime), CAST(N'2018-11-16T11:11:40.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[approved_tbl] OFF
SET IDENTITY_INSERT [dbo].[category_tbl] ON 

INSERT [dbo].[category_tbl] ([category_id], [category_type], [item_delay]) VALUES (1, N'Book', 4)
INSERT [dbo].[category_tbl] ([category_id], [category_type], [item_delay]) VALUES (2, N'Movie', 1)
INSERT [dbo].[category_tbl] ([category_id], [category_type], [item_delay]) VALUES (3, N'Game', 1)
SET IDENTITY_INSERT [dbo].[category_tbl] OFF
SET IDENTITY_INSERT [dbo].[item_tbl] ON 

INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (1, 1, N'java', CAST(N'2018-10-16T11:18:26.877' AS DateTime), 3)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (2, 1, N'C# For Biggenners', CAST(N'2018-10-16T11:44:20.190' AS DateTime), 6)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (3, 1, N'English Grammer', CAST(N'2018-10-16T11:45:37.087' AS DateTime), 7)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (4, 2, N'interstellar', CAST(N'2018-10-16T11:46:41.387' AS DateTime), 12)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (5, 2, N'passengers', CAST(N'2018-10-16T11:47:19.123' AS DateTime), 5)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (6, 2, N'Martian', CAST(N'2018-10-16T11:47:29.000' AS DateTime), 4)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (7, 3, N'Assassins''s Creed ', CAST(N'2018-10-16T11:48:55.440' AS DateTime), 7)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (8, 3, N'Forza Horizon 4', CAST(N'2018-10-16T11:49:17.660' AS DateTime), 10)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (9, 3, N'GTA V', CAST(N'2018-10-16T11:49:58.007' AS DateTime), 1)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (10, 1, N'Sql', CAST(N'2018-10-16T21:37:50.000' AS DateTime), 3)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (11, 1, N'General Knowledge', CAST(N'2018-10-16T22:23:40.000' AS DateTime), 4)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (12, 3, N'Snow', CAST(N'2018-10-16T22:25:12.000' AS DateTime), 8)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (13, 1, N'Basic Electronics', CAST(N'2018-10-19T00:24:10.000' AS DateTime), 15)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (14, 1, N'Sql', CAST(N'2018-10-19T09:31:17.000' AS DateTime), 5)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (15, 1, N'Keyboard learning', CAST(N'2018-10-19T09:31:38.000' AS DateTime), 10)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (16, 3, N'Street fighter', CAST(N'2018-10-19T23:47:07.000' AS DateTime), 5)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (17, 2, N'Ben 10', CAST(N'2018-10-19T23:54:11.000' AS DateTime), 1)
INSERT [dbo].[item_tbl] ([item_id], [category_name], [item_name], [item_added_date], [quantity]) VALUES (18, 2, N'Dragon Ball z', CAST(N'2018-10-19T23:54:30.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[item_tbl] OFF
SET IDENTITY_INSERT [dbo].[loan_tbl] ON 

INSERT [dbo].[loan_tbl] ([loan_id], [user_id], [item_id], [item_count], [loan_date], [category_id], [due_date]) VALUES (1, 37, 1, 1, CAST(N'2018-10-19T11:08:26.000' AS DateTime), 1, CAST(N'2018-11-16T11:08:26.000' AS DateTime))
INSERT [dbo].[loan_tbl] ([loan_id], [user_id], [item_id], [item_count], [loan_date], [category_id], [due_date]) VALUES (2, 37, 4, 2, CAST(N'2018-10-19T11:08:33.000' AS DateTime), 2, CAST(N'2018-10-17T11:08:33.000' AS DateTime))
INSERT [dbo].[loan_tbl] ([loan_id], [user_id], [item_id], [item_count], [loan_date], [category_id], [due_date]) VALUES (3, 37, 7, 3, CAST(N'2018-10-19T11:08:44.000' AS DateTime), 3, CAST(N'2018-10-26T11:08:44.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[loan_tbl] OFF
SET IDENTITY_INSERT [dbo].[pending_message_tbl] ON 

INSERT [dbo].[pending_message_tbl] ([message_id], [user_id], [item_id], [message]) VALUES (1, 37, 4, N'Farzana Bring Back the book.')
SET IDENTITY_INSERT [dbo].[pending_message_tbl] OFF
SET IDENTITY_INSERT [dbo].[user_registration_tbl] ON 

INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (2, N'hasnain', N'hasnainkhankqs@gmail.com', N'03312189275', N'123456789', 1, 1, CAST(N'2018-10-15T12:42:57.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (3, N'wajid', N'wajidkhan@gmail.com', N'03453496875', N'123456789', 2, 1, CAST(N'2018-10-15T15:02:41.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (4, N'ahmed', N'ahmedkhan@gmail.com', N'03345896571', N'123456789', 3, 1, CAST(N'2018-10-15T15:03:10.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (5, N'tayyab', N'tayyab@gmail.com', N'02258965472', N'123456789', 4, 1, CAST(N'2018-10-15T15:03:38.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (6, N'asma', N'asma@gmail.com', N'02258965471', N'123456789', 4, 2, CAST(N'2018-10-15T15:04:07.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (8, N'shayan', N'shayan@gmail.com', N'03254789541', N'1234567', 1, 1, CAST(N'2018-10-16T19:00:03.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (9, N'ali', N'ali@gmail.com', N'03312589254', N'1234567', 4, 1, CAST(N'2018-10-16T19:01:45.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (10, N'fazal', N'fazal@gmail.com', N'03331258957', N'1234567', 1, 1, CAST(N'2018-10-16T19:28:11.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (11, N'arsalan', N'arsalan@gmail.com', N'03124569878', N'1234567', 3, 1, CAST(N'2018-10-16T19:33:59.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (12, N'bilal', N'bilal@gmail.com', N'03121589511', N'1234567', 1, 1, CAST(N'2018-10-16T19:41:24.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (13, N'khurram', N'khurram@gmail.com', N'03121458965', N'1234567', 1, 1, CAST(N'2018-10-16T19:56:57.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (14, N'hasan', N'hasan@gmail.com', N'03312189572', N'1234567', 1, 1, CAST(N'2018-10-16T20:10:55.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (15, N'anum', N'anum@gmail.com', N'03125895741', N'1234567', 1, 2, CAST(N'2018-10-16T20:35:03.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (16, N'sarim', N'sarim@gmail.com', N'03121456987', N'1234567', 1, 1, CAST(N'2018-10-16T20:36:04.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (17, N'faraz', N'faraz@gmail.com', N'03256987415', N'123456789', 1, 1, CAST(N'2018-10-16T20:38:55.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (18, N'sufyan', N'sufyan@gmail.com', N'03125896311', N'1234567', 1, 1, CAST(N'2018-10-16T20:40:47.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (19, N'faizan', N'faizan@gmail.com', N'03256895741', N'123456789', 1, 1, CAST(N'2018-10-16T20:45:06.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (20, N'saad', N'saad@gmail.com', N'03215698754', N'123456789', 1, 1, CAST(N'2018-10-16T20:47:07.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (21, N'sami', N'sami@gmail.com', N'03258957412', N'123456789', 1, 1, CAST(N'2018-10-16T22:16:02.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (22, N'shahid', N'shahid@gmail.com', N'03356987854', N'123456789', 3, 1, CAST(N'2018-10-16T22:23:14.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (23, N'farhat', N'farhat@gmail.com', N'03312589572', N'123456789', 2, 2, CAST(N'2018-10-16T22:37:43.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (24, N'ayesha', N'ayesha@gmail.com', N'03325689755', N'123456789', 4, 2, CAST(N'2018-10-16T22:39:07.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (25, N'raza', N'raza@gmail.com', N'03365895740', N'123456789', 4, 1, CAST(N'2018-10-16T22:43:00.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (27, N'jawad', N'jawad@gmail.com', N'03356958744', N'123456789', 4, 1, CAST(N'2018-10-17T11:03:30.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (28, N'john', N'johndoe@gmail.com', N'12345678901', N'1234567', 4, 1, CAST(N'2018-10-17T11:09:25.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (29, N'hasnain', N'admin@gmail.com', N'03312189275', N'admin123', 1, 1, CAST(N'2018-10-17T19:07:23.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (30, N'tahab', N'tahab@gmail.com', N'12345678944', N'12345678', 4, 1, CAST(N'2018-10-18T11:54:22.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (31, N'bushra', N'bushra@gmail.com', N'12345678977', N'123456789', 4, 1, CAST(N'2018-10-18T11:56:40.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (32, N'arhama', N'arhama@gmail.com', N'12345678988', N'1234567897', 4, 2, CAST(N'2018-10-18T12:04:59.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (33, N'aymen', N'aymen@gmail.com', N'12345678977', N'123456789', 4, 2, CAST(N'2018-10-18T12:18:14.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (34, N'faisal', N'faisal@gmail.com', N'12345678977', N'123456789', 4, 1, CAST(N'2018-10-18T12:20:59.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (35, N'daniyal', N'daniyal@gmail.com', N'12345678978', N'123456789', 4, 1, CAST(N'2018-10-18T12:31:56.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (37, N'farzana', N'farzana@gmail.com', N'12345678977', N'123456789', 4, 2, CAST(N'2018-10-19T11:08:01.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (38, N'secratary', N'secretary@gmail.com', N'12345678912', N'123456789', 3, 1, CAST(N'2018-10-19T23:45:12.000' AS DateTime))
INSERT [dbo].[user_registration_tbl] ([user_id], [name], [email], [phone_no], [password], [type_combo_box], [gender], [user_register_date_time]) VALUES (39, N'librarian', N'librarian@gmail.com', N'12345678912', N'123456789', 2, 1, CAST(N'2018-10-19T23:51:39.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[user_registration_tbl] OFF
SET IDENTITY_INSERT [dbo].[user_type_tbl] ON 

INSERT [dbo].[user_type_tbl] ([user_type_id], [user_type]) VALUES (1, N'Admin')
INSERT [dbo].[user_type_tbl] ([user_type_id], [user_type]) VALUES (2, N'Librarian')
INSERT [dbo].[user_type_tbl] ([user_type_id], [user_type]) VALUES (3, N'Secretary')
INSERT [dbo].[user_type_tbl] ([user_type_id], [user_type]) VALUES (4, N'Member')
SET IDENTITY_INSERT [dbo].[user_type_tbl] OFF
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 10/20/2018 10:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddUser]

@nameDB varchar(50),
@emailDB varchar(50),
@phone_noDB varchar(50),
@passwordDB varchar(50),
@type_combo_boxDB int,
@genderDB int,
@user_register_date_timeDB datetime
 as
 insert into user_registration_tbl (name,email,phone_no,password,type_combo_box,gender,user_register_date_time) 
 values
  (@nameDB,@emailDB,@phone_noDB,@passwordDB,@type_combo_boxDB,@genderDB,@user_register_date_timeDB)
GO
USE [master]
GO
ALTER DATABASE [library_management_db] SET  READ_WRITE 
GO
