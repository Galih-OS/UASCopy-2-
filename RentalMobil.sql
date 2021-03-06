GO
ALTER DATABASE [RentalMobil] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentalMobil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentalMobil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentalMobil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentalMobil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentalMobil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentalMobil] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentalMobil] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentalMobil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentalMobil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentalMobil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentalMobil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentalMobil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentalMobil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentalMobil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentalMobil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentalMobil] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentalMobil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentalMobil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentalMobil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentalMobil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentalMobil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentalMobil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentalMobil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentalMobil] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentalMobil] SET  MULTI_USER 
GO
ALTER DATABASE [RentalMobil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentalMobil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentalMobil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentalMobil] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RentalMobil] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RentalMobil]
GO
/****** Object:  User [uas]    Script Date: 30/12/2015 01.25.50 ******/
CREATE USER [uas] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[KARYAWAN]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KARYAWAN](
	[ID_KARYAWAN] [int] NOT NULL,
	[NAMA_KARYAWAN] [varchar](50) NULL,
	[ALAMAT_KARYAWAN] [varchar](50) NULL,
	[JK_KARYAWAN] [char](1) NULL,
	[NO_TELP_KARYAWAN] [char](13) NULL,
	[PASS] [varchar](6) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOBIL]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOBIL](
	[ID_MOBIL] [int] NOT NULL,
	[NO_PLAT] [char](20) NULL,
	[JENIS] [varchar](50) NULL,
	[MERK] [varchar](50) NULL,
	[THN_BUAT] [datetime] NULL,
	[WARNA] [varchar](50) NULL,
	[HARGA] [char](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PELANGGAN]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PELANGGAN](
	[ID_PELANGGAN] [int] NOT NULL,
	[NAMA_PELANGGAN] [varchar](50) NULL,
	[ALAMAT_PELANGGAN] [varchar](50) NULL,
	[JK_PELANGGAN] [char](1) NULL,
	[NO_TELP_PELANGGAN] [char](13) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEWA]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEWA](
	[ID_SEWA] [int] NOT NULL,
	[ID_PELANGGAN] [int] NULL,
	[ID_KARYAWAN] [int] NULL,
	[TGL_PINJAM] [datetime] NULL,
	[TGL_KEMBALI] [datetime] NULL,
	[TOT_BAYAR] [int] NULL,
	[DENDA] [int] NULL,
	[KEMBALIAN] [int] NULL,
	[ID_MOBIL] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[tampilKaryawan]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tampilKaryawan]()
returns table
as return
(
	select * from karyawan
)
GO
/****** Object:  UserDefinedFunction [dbo].[tampilMobil]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[tampilMobil]()
returns table
as return
(
	select * from MOBIL
)
GO
/****** Object:  UserDefinedFunction [dbo].[tampilPelanggan]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tampilPelanggan]()
returns table
as return
(
	select * from PELANGGAN
)
GO
/****** Object:  UserDefinedFunction [dbo].[tampilSewa]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[tampilSewa]()
returns table
as return
(
	select * from SEWA
)
GO
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (100, N'komar', N'jl. margorejo 10/29, sby', N'L', N'089677853639 ', N'komar')
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (101, N'nestia', N'jl. sepanjang', N'P', N'0313767647   ', N'nestia')
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (102, N'toraja', N'jl. cempaka', N'P', N'0313789890   ', N'toraja')
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (103, N'farid', N'jl. Kondang', N'P', N'0313789000   ', N'farid')
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (104, N'ivo', N'jl. mariam', N'P', N'0319090909   ', N'ivo')
INSERT [dbo].[KARYAWAN] ([ID_KARYAWAN], [NAMA_KARYAWAN], [ALAMAT_KARYAWAN], [JK_KARYAWAN], [NO_TELP_KARYAWAN], [PASS]) VALUES (105, N'pandu', N'jl. jendral', N'L', N'089788987675 ', N'pandu')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (100, N'L 5807 JP           ', N'avansa', N'honda', CAST(N'2015-12-28 00:00:00.000' AS DateTime), N'Putih', N'350000              ')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (101, N'L 5888 JL           ', N'brio', N'honda', CAST(N'2015-12-30 00:00:00.000' AS DateTime), N'Silver', N'350000              ')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (102, N'L 5870 JL           ', N'juke', N'nisan', CAST(N'2015-12-28 00:00:00.000' AS DateTime), N'putih', N'300000              ')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (103, N'W 5670 JL           ', N'panther', N'isuzu', CAST(N'2015-11-11 00:00:00.000' AS DateTime), N'hijau', N'250000              ')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (104, N'AG 4870 JL          ', N'inova', N'toyota', CAST(N'2014-10-18 00:00:00.000' AS DateTime), N'silver', N'270000              ')
INSERT [dbo].[MOBIL] ([ID_MOBIL], [NO_PLAT], [JENIS], [MERK], [THN_BUAT], [WARNA], [HARGA]) VALUES (105, N'S 5470 JL           ', N'kijang', N'toyota', CAST(N'2013-10-08 00:00:00.000' AS DateTime), N'hitam', N'200000              ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (100, N'a', N'jl. cempaka', N'P', N'0313789890   ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (101, N'b', N'jl. Kondang', N'P', N'0313789000   ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (102, N'c', N'jl. mariam', N'P', N'0319090909   ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (103, N'd', N'jl. jendral', N'P', N'089788987675 ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (104, N'e', N'jl. cendrawasih', N'L', N'0313909090   ')
INSERT [dbo].[PELANGGAN] ([ID_PELANGGAN], [NAMA_PELANGGAN], [ALAMAT_PELANGGAN], [JK_PELANGGAN], [NO_TELP_PELANGGAN]) VALUES (105, N'f', N'jl. kapolda', N'L', N'0313761111   ')
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (100, 100, 100, CAST(N'2015-12-28 23:05:51.993' AS DateTime), CAST(N'2015-12-28 23:06:09.023' AS DateTime), 0, 0, 0, 100)
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (101, 101, 101, CAST(N'2015-12-28 22:48:53.807' AS DateTime), CAST(N'2015-12-28 23:06:16.837' AS DateTime), 0, 0, 0, 101)
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (102, 102, 102, CAST(N'2015-12-28 22:48:37.230' AS DateTime), CAST(N'2015-12-28 23:06:22.020' AS DateTime), 0, 0, 0, 102)
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (103, 103, 103, CAST(N'2015-12-28 22:49:01.943' AS DateTime), CAST(N'2015-12-28 23:06:26.233' AS DateTime), 0, 0, 0, 103)
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (104, 103, 103, CAST(N'2015-12-27 22:49:01.000' AS DateTime), CAST(N'2015-12-28 23:06:26.000' AS DateTime), 300000, 100000, 50000, 103)
INSERT [dbo].[SEWA] ([ID_SEWA], [ID_PELANGGAN], [ID_KARYAWAN], [TGL_PINJAM], [TGL_KEMBALI], [TOT_BAYAR], [DENDA], [KEMBALIAN], [ID_MOBIL]) VALUES (105, 103, 103, CAST(N'2015-12-23 22:49:01.000' AS DateTime), CAST(N'2015-12-26 23:06:26.000' AS DateTime), 400000, 300000, 150000, 103)
/****** Object:  Index [PK_KARYAWAN]    Script Date: 30/12/2015 01.25.50 ******/
ALTER TABLE [dbo].[KARYAWAN] ADD  CONSTRAINT [PK_KARYAWAN] PRIMARY KEY NONCLUSTERED 
(
	[ID_KARYAWAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_MOBIL]    Script Date: 30/12/2015 01.25.50 ******/
ALTER TABLE [dbo].[MOBIL] ADD  CONSTRAINT [PK_MOBIL] PRIMARY KEY NONCLUSTERED 
(
	[ID_MOBIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_PELANGGAN]    Script Date: 30/12/2015 01.25.50 ******/
ALTER TABLE [dbo].[PELANGGAN] ADD  CONSTRAINT [PK_PELANGGAN] PRIMARY KEY NONCLUSTERED 
(
	[ID_PELANGGAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_SEWA]    Script Date: 30/12/2015 01.25.50 ******/
ALTER TABLE [dbo].[SEWA] ADD  CONSTRAINT [PK_SEWA] PRIMARY KEY NONCLUSTERED 
(
	[ID_SEWA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MELAKUKAN_FK]    Script Date: 30/12/2015 01.25.50 ******/
CREATE NONCLUSTERED INDEX [MELAKUKAN_FK] ON [dbo].[SEWA]
(
	[ID_PELANGGAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MENGELOLA_FK]    Script Date: 30/12/2015 01.25.50 ******/
CREATE NONCLUSTERED INDEX [MENGELOLA_FK] ON [dbo].[SEWA]
(
	[ID_KARYAWAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SEWA]  WITH CHECK ADD FOREIGN KEY([ID_MOBIL])
REFERENCES [dbo].[MOBIL] ([ID_MOBIL])
GO
ALTER TABLE [dbo].[SEWA]  WITH CHECK ADD  CONSTRAINT [FK_SEWA_MELAKUKAN_PELANGGA] FOREIGN KEY([ID_PELANGGAN])
REFERENCES [dbo].[PELANGGAN] ([ID_PELANGGAN])
GO
ALTER TABLE [dbo].[SEWA] CHECK CONSTRAINT [FK_SEWA_MELAKUKAN_PELANGGA]
GO
ALTER TABLE [dbo].[SEWA]  WITH CHECK ADD  CONSTRAINT [FK_SEWA_MENGELOLA_KARYAWAN] FOREIGN KEY([ID_KARYAWAN])
REFERENCES [dbo].[KARYAWAN] ([ID_KARYAWAN])
GO
ALTER TABLE [dbo].[SEWA] CHECK CONSTRAINT [FK_SEWA_MENGELOLA_KARYAWAN]
GO
/****** Object:  StoredProcedure [dbo].[simpanKaryawan]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[simpanKaryawan]
@id_karyawan int,
@nama_karyawan varchar(50),
@alamat_karyawan varchar(50),
@jk_karyawan char(1),
@no_telp_karyawan char(13),
@pass varchar(6)
AS
insert into KARYAWAN values(@id_karyawan, @nama_karyawan, @alamat_karyawan, @jk_karyawan, @no_telp_karyawan, @pass)
GO
/****** Object:  StoredProcedure [dbo].[simpanMobil]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[simpanMobil]
@id_mobil int,
@id_sewa int,
@no_plat char(20),
@jenis varchar(50),
@merk varchar(50),
@tahun datetime,
@warna varchar(50),
@harga char(20)
AS
insert into mobil values (@id_mobil, @id_sewa, @no_plat, @jenis, @merk, @tahun, @warna, @harga)
GO
/****** Object:  StoredProcedure [dbo].[simpanPelanggan]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[simpanPelanggan]
@id_pelanggan int,
@nama_pelanggan varchar(50),
@alamat_pelanggan varchar(50),
@jk_pelanggan char(1),
@no_telp_pelanggan char(13)
AS
insert into PELANGGAN values(@id_pelanggan, @nama_pelanggan, @alamat_pelanggan, @jk_pelanggan, @no_telp_pelanggan)
GO
/****** Object:  StoredProcedure [dbo].[simpanSewa]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[simpanSewa]
@id_sewa int,
@id_pelanggan int,
@id_karyawan int,
@tgl_pinjam datetime,
@tgl_kembali datetime,
@tot_bayar int,
@denda int,
@kembalian int,
@id_mobil int
AS
insert into SEWA (ID_SEWA, ID_PELANGGAN, ID_KARYAWAN, TGL_PINJAM, TGL_KEMBALI,TOT_BAYAR,DENDA,KEMBALIAN, ID_MOBIL)values (@id_sewa, @id_pelanggan, @id_karyawan, @tgl_pinjam, @tgl_kembali, @tot_bayar, @denda,@kembalian, @id_mobil)
GO
/****** Object:  StoredProcedure [dbo].[updatedenda]    Script Date: 30/12/2015 01.25.50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatedenda]
@id_sewa int,
@denda int
AS
UPDATE SEWA set denda=@denda where id_sewa=@id_sewa
GO
USE [master]
GO
ALTER DATABASE [RentalMobil] SET  READ_WRITE 
GO
