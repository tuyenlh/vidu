USE [master]
GO
/****** Object:  Database [Duanmau]    Script Date: 19/10/2021 12:27:20 PM ******/
CREATE DATABASE [Duanmau]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Duanmau', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Duanmau.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Duanmau_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Duanmau_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Duanmau] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Duanmau].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Duanmau] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Duanmau] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Duanmau] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Duanmau] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Duanmau] SET ARITHABORT OFF 
GO
ALTER DATABASE [Duanmau] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Duanmau] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Duanmau] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Duanmau] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Duanmau] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Duanmau] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Duanmau] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Duanmau] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Duanmau] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Duanmau] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Duanmau] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Duanmau] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Duanmau] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Duanmau] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Duanmau] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Duanmau] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Duanmau] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Duanmau] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Duanmau] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Duanmau] SET  MULTI_USER 
GO
ALTER DATABASE [Duanmau] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Duanmau] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Duanmau] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Duanmau] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Duanmau]
GO
/****** Object:  User [asm_tuyen]    Script Date: 19/10/2021 12:27:20 PM ******/
CREATE USER [asm_tuyen] FOR LOGIN [asm_tuyen] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [asm_tuyen]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/10/2021 12:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hangs]    Script Date: 19/10/2021 12:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hangs](
	[MaHang] [nvarchar](20) NOT NULL,
	[ID_Hang] [int] NOT NULL,
	[TenHang] [nvarchar](20) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaNhap] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
	[AnhHang] [nvarchar](max) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[Ma_NhanVien] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Hangs] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHangs]    Script Date: 19/10/2021 12:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangs](
	[SDT] [nvarchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[Ma_NanVienMa_NhanVien] [nvarchar](20) NULL,
 CONSTRAINT [PK_KhachHangs] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanViens]    Script Date: 19/10/2021 12:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanViens](
	[Ma_NhanVien] [nvarchar](20) NOT NULL,
	[ID_NhanVien] [int] NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[VaiTro] [int] NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[Diachi] [nvarchar](500) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[TrangThaiMatKhau] [bit] NOT NULL,
 CONSTRAINT [PK_NhanViens] PRIMARY KEY CLUSTERED 
(
	[Ma_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Hangs_Ma_NhanVien]    Script Date: 19/10/2021 12:27:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Hangs_Ma_NhanVien] ON [dbo].[Hangs]
(
	[Ma_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_KhachHangs_Ma_NanVienMa_NhanVien]    Script Date: 19/10/2021 12:27:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_KhachHangs_Ma_NanVienMa_NhanVien] ON [dbo].[KhachHangs]
(
	[Ma_NanVienMa_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hangs]  WITH CHECK ADD  CONSTRAINT [FK_Hangs_NhanViens_Ma_NhanVien] FOREIGN KEY([Ma_NhanVien])
REFERENCES [dbo].[NhanViens] ([Ma_NhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hangs] CHECK CONSTRAINT [FK_Hangs_NhanViens_Ma_NhanVien]
GO
ALTER TABLE [dbo].[KhachHangs]  WITH CHECK ADD  CONSTRAINT [FK_KhachHangs_NhanViens_Ma_NanVienMa_NhanVien] FOREIGN KEY([Ma_NanVienMa_NhanVien])
REFERENCES [dbo].[NhanViens] ([Ma_NhanVien])
GO
ALTER TABLE [dbo].[KhachHangs] CHECK CONSTRAINT [FK_KhachHangs_NhanViens_Ma_NanVienMa_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [Duanmau] SET  READ_WRITE 
GO
