USE [master]
GO
/****** Object:  Database [DeAn]    Script Date: 24/10/2018 9:16:15 PM ******/
CREATE DATABASE [DeAn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeAn', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DeAn.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DeAn_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DeAn_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DeAn] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeAn] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeAn] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DeAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeAn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeAn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeAn] SET  MULTI_USER 
GO
ALTER DATABASE [DeAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeAn] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DeAn]
GO
/****** Object:  Table [dbo].[DIENTHOAI]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIENTHOAI](
	[MaDT] [char](10) NOT NULL,
	[TenDT] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[NgaySanXuat] [nchar](10) NULL,
	[BaoHanh] [nchar](10) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [char](10) NOT NULL,
	[NgayBan] [nchar](10) NULL,
	[MaKH] [char](10) NULL,
	[TenKH] [nvarchar](30) NULL,
	[MaSP] [char](10) NULL,
	[TenSP] [nvarchar](30) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
	[GiamGia] [int] NULL,
	[TongTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](10) NULL,
	[SoTaiKhoan] [nchar](10) NULL,
	[NgayDangKy] [nchar](10) NULL,
	[LoaiKH] [nchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINHKIEN]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINHKIEN](
	[MaLK] [char](10) NOT NULL,
	[TenLK] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[NgaySanXuat] [nchar](10) NULL,
	[BaoHanh] [nchar](10) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [nchar](10) NULL,
	[GioiTinh] [nchar](3) NULL,
	[SDT] [nchar](10) NULL,
	[ChucVu] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYENTRUYCAP]    Script Date: 24/10/2018 9:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYENTRUYCAP](
	[MaNV] [char](10) NOT NULL,
	[Quyen] [nchar](7) NULL,
	[TaiKhoan] [char](10) NULL,
	[MatKhau] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'IP001     ', N'iPhone 6 32GB', 7490000, N'24/07/2016', N'12 tháng  ', 6)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'IP002     ', N'iPhone 8 Plus 64GB', 20990000, N'23/09/2017', N'12 tháng  ', 7)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'NK001     ', N'Nokia 6', 3590000, N'02/01/2017', N'9 tháng   ', 3)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'NK002     ', N'Nokia 5', 3090000, N'24/11/2016', N'9 tháng   ', 6)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'OP001     ', N'OPPO Find X', 20990000, N'14/02/2017', N'12 tháng  ', 3)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'OP002     ', N'OPPO F9 6GB', 8490000, N'14/02/2017', N'12 tháng  ', 6)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'SS001     ', N'Samsung Galaxy Note 9', 229900000, N'01/08/2017', N'12 tháng  ', 3)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'SS002     ', N'Samsung Galaxy J8', 6290000, N'24/10/2017', N'12 tháng  ', 9)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'XRM001    ', N'Xiaomi Redmi 5 Plus', 4790000, N'02/03/2017', N'6 tháng   ', 6)
INSERT [dbo].[DIENTHOAI] ([MaDT], [TenDT], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'XRM002    ', N'Xiaomi Redmi 5', 3490000, N'02/03/2017', N'6 tháng   ', 10)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'CH001     ', N'Chuột có dây Logitech M100r', 75000, N'12/03/2016', N'3 tháng   ', 5)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'CH002     ', N'Chuột có dây Genius DX-125', 75000, N'02/03/2016', N'3 tháng   ', 6)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'CS001     ', N'Cáp Micro 0.2m eSaver BST-0728', 24000, N'09/03/2017', NULL, 2)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'CS002     ', N'Cáp Micro 0.2m Xmobile MU003', 20000, N'25/03/2017', NULL, 4)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'PS001     ', N'Pin sạc eSaver 5.000 mAh Y322', 200000, N'24/02/2016', N'3 tháng   ', 5)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'PS002     ', N'Pin sạc eSaver 7500 mAh LJ JP133', 280000, N'09/02/2017', N'3 tháng   ', 6)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'SD001     ', N'Micro SD 8 GB class 4', 180000, N'16/09/2017', NULL, 5)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'SD002     ', N'Micro SC 16 GB class 10', 280000, N'16/09/2017', NULL, 6)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'TN001     ', N'Tai nghe chụp tai Kanen IP-350', 150000, N'24/07/2016', N'3 tháng   ', 5)
INSERT [dbo].[LINHKIEN] ([MaLK], [TenLK], [DonGia], [NgaySanXuat], [BaoHanh], [SoLuong]) VALUES (N'TN002     ', N'Tai nghe nhét trong Kanen IP-219', 97000, N'24/09/2017', N'3 tháng   ', 6)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [SDT], [ChucVu], [DiaChi]) VALUES (N'CH000     ', N'Huỳnh Thiện Tuấn', N'24/07/1998', N'Nam', N'0845620518', N'Chủ', N'TP.HCM')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV01      ', N'Nguyễn Hoàng Thiện', N'26/09/1999', N'Nam', N'0845214365', N'Nhân viên', N'Đại Lãnh')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [SDT], [ChucVu], [DiaChi]) VALUES (N'QL01      ', N'Trà Xuân Sơn', N'03/05/1998', N'Nam', N'0812536248', N'Quản lý', N'TP.HCM')
INSERT [dbo].[QUYENTRUYCAP] ([MaNV], [Quyen], [TaiKhoan], [MatKhau]) VALUES (N'CH000     ', N'admin  ', N'admin     ', N'admin     ')
INSERT [dbo].[QUYENTRUYCAP] ([MaNV], [Quyen], [TaiKhoan], [MatKhau]) VALUES (N'NV01      ', N'user   ', N'nhanvien  ', N'nhanvien  ')
INSERT [dbo].[QUYENTRUYCAP] ([MaNV], [Quyen], [TaiKhoan], [MatKhau]) VALUES (N'QL01      ', N'manager', N'quanly    ', N'quanly    ')
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_DT] FOREIGN KEY([MaSP])
REFERENCES [dbo].[DIENTHOAI] ([MaDT])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_DT]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_KH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_LK] FOREIGN KEY([MaSP])
REFERENCES [dbo].[LINHKIEN] ([MaLK])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_LK]
GO
ALTER TABLE [dbo].[QUYENTRUYCAP]  WITH CHECK ADD  CONSTRAINT [FK_QTC_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[QUYENTRUYCAP] CHECK CONSTRAINT [FK_QTC_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [DeAn] SET  READ_WRITE 
GO
