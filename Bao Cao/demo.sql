USE [demo]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USER]') AND type in (N'U'))
DROP TABLE [dbo].[USER]
GO
/****** Object:  Table [dbo].[TIENTRINH]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIENTRINH]') AND type in (N'U'))
DROP TABLE [dbo].[TIENTRINH]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nganh]') AND type in (N'U'))
DROP TABLE [dbo].[Nganh]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MONHOC]') AND type in (N'U'))
DROP TABLE [dbo].[MONHOC]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KHOA]') AND type in (N'U'))
DROP TABLE [dbo].[KHOA]
GO
/****** Object:  Table [dbo].[HE]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HE]') AND type in (N'U'))
DROP TABLE [dbo].[HE]
GO
/****** Object:  Table [dbo].[CHITIETMONHOC]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CHITIETMONHOC]') AND type in (N'U'))
DROP TABLE [dbo].[CHITIETMONHOC]
GO
/****** Object:  Table [dbo].[BOMON]    Script Date: 10/11/2020 23:03:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOMON]') AND type in (N'U'))
DROP TABLE [dbo].[BOMON]
GO
USE [master]
GO
/****** Object:  Database [demo]    Script Date: 10/11/2020 23:03:57 ******/
DROP DATABASE [demo]
GO
/****** Object:  Database [demo]    Script Date: 10/11/2020 23:03:57 ******/
CREATE DATABASE [demo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'demo', FILENAME = N'E:\Apps\mysql\MSSQL14.MSSQLSERVER\MSSQL\DATA\demo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'demo_log', FILENAME = N'E:\Apps\mysql\MSSQL14.MSSQLSERVER\MSSQL\DATA\demo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [demo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [demo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [demo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [demo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [demo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [demo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [demo] SET ARITHABORT OFF 
GO
ALTER DATABASE [demo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [demo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [demo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [demo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [demo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [demo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [demo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [demo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [demo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [demo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [demo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [demo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [demo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [demo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [demo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [demo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [demo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [demo] SET RECOVERY FULL 
GO
ALTER DATABASE [demo] SET  MULTI_USER 
GO
ALTER DATABASE [demo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [demo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [demo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [demo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [demo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'demo', N'ON'
GO
ALTER DATABASE [demo] SET QUERY_STORE = OFF
GO
USE [demo]
GO
/****** Object:  Table [dbo].[BOMON]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOMON](
	[MaBM] [nvarchar](50) NOT NULL,
	[TenBM] [nvarchar](max) NULL,
 CONSTRAINT [PK_BOMON] PRIMARY KEY CLUSTERED 
(
	[MaBM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETMONHOC]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETMONHOC](
	[MaMH] [nvarchar](50) NOT NULL,
	[MaHe] [nvarchar](50) NOT NULL,
	[MaNganh] [nvarchar](50) NOT NULL,
	[MaKhoa] [nvarchar](50) NOT NULL,
	[MaBM] [nvarchar](50) NOT NULL,
	[SotietLT] [int] NULL,
	[SotietTH] [int] NULL,
	[LoaiMH] [nvarchar](50) NULL,
	[SoTC] [int] NULL,
	[Mota] [nvarchar](max) NULL,
 CONSTRAINT [PK_CHITIETMONHOC] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaHe] ASC,
	[MaNganh] ASC,
	[MaKhoa] ASC,
	[MaBM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HE]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HE](
	[MaHe] [nvarchar](50) NOT NULL,
	[TenHe] [nvarchar](max) NULL,
 CONSTRAINT [PK_HE] PRIMARY KEY CLUSTERED 
(
	[MaHe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [nvarchar](50) NOT NULL,
	[TenKhoa] [nvarchar](max) NULL,
	[SoTC] [int] NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMH] [nvarchar](50) NOT NULL,
	[TenMH] [nvarchar](max) NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[MaNganh] [nvarchar](50) NOT NULL,
	[TenNganh] [nvarchar](max) NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIENTRINH]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENTRINH](
	[MaNganh] [nvarchar](50) NOT NULL,
	[MaMH] [nvarchar](50) NOT NULL,
	[MaKhoa] [nvarchar](50) NOT NULL,
	[HocKy] [nvarchar](max) NULL,
 CONSTRAINT [PK_TIENTRINH] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC,
	[MaMH] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 10/11/2020 23:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BOMON] ([MaBM], [TenBM]) VALUES (N'ANM', N'Mạng và An Ninh Mạng')
INSERT [dbo].[BOMON] ([MaBM], [TenBM]) VALUES (N'CNPM', N'Công Nghệ Phần Mềm')
INSERT [dbo].[BOMON] ([MaBM], [TenBM]) VALUES (N'HTTT', N'Hệ Thống Thông Tin')
INSERT [dbo].[BOMON] ([MaBM], [TenBM]) VALUES (N'THCS', N'Tin Học Cơ Sở')
GO
INSERT [dbo].[HE] ([MaHe], [TenHe]) VALUES (N'DH', N'Đại học')
INSERT [dbo].[HE] ([MaHe], [TenHe]) VALUES (N'Ths', N'Sau Đại học(Thạc Sĩ)')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SoTC]) VALUES (N'K18', N'Khóa 2018', 132)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SoTC]) VALUES (N'K18-', N'Trước khóa 2018', 152)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SoTC]) VALUES (N'K19+', N'Từ Khóa 2019', 150)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SoTC]) VALUES (N'KH', N'Khoa Học', 36)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SoTC]) VALUES (N'UD', N'Ứng Dụng', 36)
GO
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'52480105', N'Kỹ Thuật Dữ Liệu')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'52480201', N'Sư Phạm Kỹ Thuật Công Nghệ Thông Tin')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'7480201', N'Công Nghệ Thông Tin')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'8480101', N'Khoa Học Máy Tính')
GO
INSERT [dbo].[USER] ([UserName], [Password]) VALUES (N'admin     ', N'1234      ')
INSERT [dbo].[USER] ([UserName], [Password]) VALUES (N'Gv1       ', N'1234      ')
INSERT [dbo].[USER] ([UserName], [Password]) VALUES (N'Gv2       ', N'1234      ')
GO
USE [master]
GO
ALTER DATABASE [demo] SET  READ_WRITE 
GO
