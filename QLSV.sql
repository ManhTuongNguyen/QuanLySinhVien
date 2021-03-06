USE [master]
GO

Create database QuanLySinhVien
On (
	name = QuanLySinhVien_Dat,
	filename = 'D:\CSDL\QuanLySinhVien.mdf',
	size = 8mb,
	filegrowth = 10%
)
Log on (
	name = QuanLySinhVien_Log,
	filename = 'D:\CSDL\QuanLySinhVien.ldf',
	size = 8mb,
	filegrowth = 10%
)
go

USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](60) NULL,
	[DisplayName] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[Type] [nvarchar](15) NULL,
 CONSTRAINT [PK__Account__536C85E5E757AF2B] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuongTrinhHoc]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhHoc](
	[MaCT] [nvarchar](30) NOT NULL,
	[TenCT] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [nvarchar](30) NOT NULL,
	[MaMH] [nvarchar](30) NOT NULL,
	[DiemThiLan1] [nvarchar](10) NOT NULL,
	[DiemThiLan2] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](30) NOT NULL,
	[TenKhoa] [nvarchar](200) NULL,
	[NamThanhLap] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [nvarchar](30) NOT NULL,
	[NamBatDau] [nvarchar](30) NULL,
	[NamKetThuc] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LienHe]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LienHe](
	[MaSV] [nvarchar](30) NOT NULL,
	[SDTSinhVien] [nvarchar](11) NULL,
	[EmailSinhVien] [nvarchar](100) NULL,
	[HoTenNguoiThan] [nvarchar](200) NULL,
	[SDTNguoiThan] [nvarchar](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](30) NOT NULL,
	[TenLop] [nvarchar](60) NULL,
	[MaKhoa] [nvarchar](30) NOT NULL,
	[MaKhoaHoc] [nvarchar](30) NOT NULL,
	[MaCT] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nvarchar](30) NOT NULL,
	[MaKhoa] [nvarchar](30) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
	[SoTinChi] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](30) NOT NULL,
	[HoTen] [nvarchar](200) NULL,
	[NgaySinh] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](15) NULL,
	[QueQuan] [nvarchar](130) NULL,
	[DanToc] [nvarchar](50) NULL,
	[MaLop] [nvarchar](30) NOT NULL,
	[TinhTrang] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [Password], [DisplayName], [Email], [Type]) VALUES (N'fùáBo', N'uXlpa', N'fE12SKrI/Uk=', N'zxzDPhdMz/fBy+C6OJUP8S2PqpzhjErJ', N'wazPàPGd9MdT9')
INSERT [dbo].[Account] ([Username], [Password], [DisplayName], [Email], [Type]) VALUES (N'pV02', N'ếệủ', N'FZeXwL24WgZnCVvsOrJ+kNS8zXja+ZSG', N'dZlyBkIZknsE1wvHUUkRCgztz66IHFkQ', N'ùPáT XPêà')
INSERT [dbo].[Account] ([Username], [Password], [DisplayName], [Email], [Type]) VALUES (N'UV02', N'ếệủ', N'FZeXwL24WgYo0oCznK0Ban9bOH7A65Rh', N'293n21b2lrcwi9EM8xB09w==', N'RPàắ XPêà')
GO
INSERT [dbo].[ChuongTrinhHoc] ([MaCT], [TenCT]) VALUES (N'Lbk0h', N'TkUXy8knPatoanCJh2Bw9Q==')
INSERT [dbo].[ChuongTrinhHoc] ([MaCT], [TenCT]) VALUES (N'Lbk0Y', N'vXoW4QSLJU8jpkwaNnckig==')
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV02', N'uk0a', N'à', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV02', N'uk0X', N'6Ea', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV02', N'uk0z', N'fE5', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0c', N'uk0J', N'G0', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0c', N'uk0R', N'e', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0c', N'uk0S', N'X', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0c', N'uk0X', N'e', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0c', N'uk0z', N'8', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0e', N'uk0J', N'f', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0e', N'uk0R', N'5', N'6')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0e', N'uk0S', N'à', N'a')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0e', N'uk0z', N'X', N'')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0n', N'uk0R', N'GEG', N'X')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0n', N'uk0S', N'GEà', N'X')
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [DiemThiLan1], [DiemThiLan2]) VALUES (N'UV0n', N'uk0z', N'GEX', N'')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00e', N'F0Tc9p6xphIgJW9sz4ne+ANHQt/EJeHQLN0Z1VJEynyRAYcUWmov9buX/zCZwlTjj9QEY9DBd8A9GAZp8tOg+8TL1IS0JU4lX/XCDU+CCPd0jm7Tx4Dxh38dYIQ2tZ9qkrlbLZWJLoo0O+j5A96BNTvkv4YRdSHyMkJRzrIAZcg=', N'7/ủ/DdưF')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00ể', N'Ggdpb6W+xiwCLgJ1sbWwQhye/mSH3Iv56XsHwrcx5f5YA27ylFpsudJMALBUYkqz/0ut8MHgtQCcpO4YUDaDmf8cA4xasaQimibt0h81JyW9u+hAYyHTbfouYiVw9DWiTr5WyIYFG70d+e6mY9SVUyoqRi6zgbZfbfhdFRn8IS4=', N'úG/Y/ưưo7')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00f', N'nfyRXQgeHfPZO2VKa6D6+zikXp5/LJmRDYE0rycbA+7p6c6lD8nRTIsPJRjQEJVv3CaVIxBShZDUXK8r/P09sYn3RXCQZRQdgsYDWYLN1kAlURGvzT/RAY9VNbA95Zk2L2/c7fgdmb7GLZVQyMmsX1RWZIXlQM3FzwmL62YMlKk=', N'úG/U/ưưFZ')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00K', N'lyhFayNgpQZfgAKyxWsOR2GxlPvHiMnCJoTcwUYz/COHP77XZiefYJYPuA74DPlvUAu+gjjcN03LcUt2w78F4rQIKyyOCxz5sMzGnLbG4gddswBBoMEhyP1FLanrd++yAHvZzOYNlXUG6JhtfQusmc46dAi/8CPafuv9a3+/Q8M=', N'úG/Rj/100X')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00n', N'RVFmD53E3roRYknwAOWNv+dRXyQGyBOv29z/r6c1hP9FiH2L6NweDaIGhsdGbnD9EJDphl0dSNJFrtdT93laAVcAoMHlVvtPaa2j/abHXecf29AEEBHcrFhRFWCTdtHQkaSkgSKRNMbY+6g+wgNFAtllB2gBH7PttfdRyS+srtc=', N'úG/7ó/pF7X')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00ò', N'eHoiVkCl9OAIL/AGe/3k2f6IB2sXRjMgXhZpcgcb4ZpBQjwzIMPuwinD+hwEO4f67d9mVyJB7hx8uc+vItItRGwaRzjApCiobZ5wTERX8BOYUW1Ta3rUvq8qW7e9EdQrGaFCYGz4JM2zFh+jMR09ul3lqhhUBJU3y3QB0nTiTqs=', N'úG/7ó/10 á')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00S', N'qwd+QOay+7ype4JccKn5PtsTJxiT2VwfI8UELs+irlkhO7iogu2Eo/oX+k6UMNhE5ZxMslW0xdQbYsPsHZFHmYIEj4B1sRT0vvCLXtGH1GTkZfG4Re6UA2fpjsB4XojVuaOwM6OvGUlvL+xkoeei3Sn4KQ/y5i1LbFosOD+VxgY=', N'7/ủ/DdPF')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT00x', N'fweYZ/UYF+3u77iiRGRyoeLcOBFRyomCpJKlNzB3CaHmGJgwhWLr3raKTDMutK4obJI0Dzc4+iH8hbbIwrA/HcYxzTiD0MjFovnI34mlA0JfbNCT2fuhKtIY3maBxsQdMmlFZmbKyi9djP5dclU17X/VybYAjwaUp9uZ9IVuU0o=', N'7/ủ/DdưK')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT0f0', N'nrCpCjVOWABh4FiTwyXtNhXMQFlfFvxgo7OGJ06LKwlCgJ4DQfu7grNh036LOZd6t6B3sPxYdVedG9W7/pftaj/9nzpk3Acw61QVGzi6MkIG0VGFiweOdvePKqR5PstGqqrNL6M/7MOQi0F3Mxm8wFo5KiLSe/cHP0CbiyE7VHI=', N'7/ủ/DdPF')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [NamThanhLap]) VALUES (N'IT0ff', N'kBsaEO978zfgZqogGb8ADFTYgXZqIfgvS72gC0CZMOs6/5mcKsXdry42b1LGEiKnrfG9I/+LpzqsqNV+l/JjEP3S2EL3bSP9oB9Be84BuFteOerelt19wGe5EjBiQAjr2Ez2ihaDkhQS/Rs9Sv7d+HMWGGIK/YboZ1ycxml4gjQ=', N'7/ủ/DdPF')
GO
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dc0', N'S0nc', N'602a')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dc2', N'S0nK', N'60n0')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcc', N'S0Sn', N'60nU')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dce', N'S0nể', N'60nB')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcề', N'S0nC', N'60n.')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcj', N'S0S0', N'60nF')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcn', N'S0nò', N'60nW')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcò', N'S0SS', N'60nm')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'dcz', N'S0SZ', N'60nb')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NamBatDau], [NamKetThuc]) VALUES (N'djk', N'S0nắ', N'602L')
GO
INSERT [dbo].[LienHe] ([MaSV], [SDTSinhVien], [EmailSinhVien], [HoTenNguoiThan], [SDTNguoiThan]) VALUES (N'UV02', N'0XlSPCSềib', N'xCRJkOMEfz1thBUi72Lvo24oPqHhHd4D', N'TM3kF8/ZXFE7eXOeTuViE0JnZ2HPh9tu', N'0fểKòneExx')
INSERT [dbo].[LienHe] ([MaSV], [SDTSinhVien], [EmailSinhVien], [HoTenNguoiThan], [SDTNguoiThan]) VALUES (N'UV0n', N'0e1 .Cửbu4', N'lZRLNRXGN8NthBUi72Lvo24oPqHhHd4D', N'nkV53sXf/Jhl4+59lkPdEpRzi+u7p4Mk', N'0SxEenòKểK')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'àE-4', N'73OsdgbjKyV1sTVoENug/A==', N'IT00K', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'àE-ề', N'73OsdgbjKyWeR8d8hIuSNg==', N'IT00K', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'ọũwB-5', N'kQs5lZA9pHT5XJ3a6e3gKPHalkcseRSUNfJFAKL2bOo=', N'IT00f', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'ọũwB-B', N'kQs5lZA9pHT5XJ3a6e3gKPHalkcseRSUBbEyh7kWSl8=', N'IT00f', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'ọũwB-D', N'kQs5lZA9pHT5XJ3a6e3gKPHalkcseRSUd9XW8I6LmRY=', N'IT00f', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'ọũwB-r', N'kQs5lZA9pHT5XJ3a6e3gKPHalkcseRSUkchxy672et0=', N'IT00f', N'dce', N'Lbk0h')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'sEwB-5', N'+qNk/HJ5oqqoySMY/2oQGPHalkcseRSUNfJFAKL2bOo=', N'IT00ể', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'sEwB-B', N'+qNk/HJ5oqqoySMY/2oQGPHalkcseRSUBbEyh7kWSl8=', N'IT00ể', N'dce', N'Lbk0Y')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaKhoaHoc], [MaCT]) VALUES (N'sEwB-D', N'+qNk/HJ5oqqoySMY/2oQGPHalkcseRSUd9XW8I6LmRY=', N'IT00ể', N'dce', N'Lbk0Y')
GO
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0a', N'IT00x', N'LjựqXạaoừEừdẫủoáháậừ', N'x')
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0J', N'IT00ể', N'úủR búâlyâIứảjoứậêỏừệôvfzâMN', N'ề')
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0R', N'IT00f', N'ọô9fXFBâPEừdầ5oứềư', N'ề')
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0S', N'IT00e', N'L6R Tởâw7ệồúệWíMMDủW', N'ề')
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0X', N'IT00ò', N'ũ28ừXIụó7XoểũOọ2tLKờzề6vz8', N'ề')
INSERT [dbo].[MonHoc] ([MaMH], [MaKhoa], [TenMH], [SoTinChi]) VALUES (N'uk0z', N'IT0ff', N'Ls8eXử537of.', N'ừ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV02', N'FZeXwL24WgZ6AzytlPpHutgkGAdyUJOg', N'êX/Us/z96u', N'm5HxCyshLP8=', N'búứMĐịếD', N'jILlC0IxZPY=', N'àE-4', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0c', N'FZeXwL24WgbVbbjd1rZU22KwWiTFzlXl', N'j/ũ/B000', N'Z4wgB+eBIwE=', N'qWúMGìếD', N'jILlC0IxZPY=', N'ọũwB-B', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0e', N'FZeXwL24WgYBe5FXVvc53wwX6fymY3IK', N'j/ũ/B000', N'Z4wgB+eBIwE=', N'qảEMplơếề', N'jILlC0IxZPY=', N'ọũwB-B', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0ề', N'FZeXwL24WgZ0Wmfa1o9TBSJ2f6WZAiUH', N'W/ếU/t000', N'Z4wgB+eBIwE=', N'YD EMGìếD', N'jILlC0IxZPY=', N'ọũwB-B', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0j', N'FZeXwL24WgYBe5FXVvc53wwX6fymY3IK', N'J/P/B001', N'Z4wgB+eBIwE=', N'qlếềMB9ế', N'jILlC0IxZPY=', N'ọũwB-B', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0n', N'4Edhg7xXRGXDWKRl9BxbAw==', N'êX/Us/K000', N'Z4wgB+eBIwE=', N'bềDừM8ế', N'3/Potg9dz98=', N'àE-4', N'Đ2vd UaK')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0ò', N'Dgh+iJ8pIT7Y328iCxzmCw==', N'j/ũ/iIj8', N'Z4wgB+eBIwE=', N'YDúếDMqũú', N'TELJkqs5AqE=', N'ọũwB-B', N'Nừn eưọ')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [DanToc], [MaLop], [TinhTrang]) VALUES (N'UV0z', N'9UBjPOjqttg0OkPxTbNidWKwWiTFzlXl', N'à/ếề/sj9S', N'Z4wgB+eBIwE=', N'YDúếDMqũú', N'jILlC0IxZPY=', N'ọũwB-B', N'Nừn eưọ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LienHe__2725081BA9C09DD7]    Script Date: 6/22/2022 1:52:58 PM ******/
ALTER TABLE [dbo].[LienHe] ADD UNIQUE NONCLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[LienHe]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaCT])
REFERENCES [dbo].[ChuongTrinhHoc] ([MaCT])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllDiem]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetAllDiem]
as
begin
	Select SinhVien.HoTen, Lop.TenLop, MonHoc.TenMH,
		case when DiemThiLan2 = ''
			then DiemThiLan1
			else DiemThiLan2
		end
		as Diem
	from KetQua inner join SinhVien on KetQua.MaSV = SinhVien.MaSV inner join MonHoc on KetQua.MaMH = MonHoc.MaMH
			inner join Lop on SinhVien.MaLop = Lop.MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDiemByStudentCode]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetDiemByStudentCode]
@maSV nvarchar(30)
as
begin
	Select MonHoc.TenMH, DiemThiLan1, DiemThiLan2
	from KetQua inner join SinhVien on KetQua.MaSV = SinhVien.MaSV 
				inner join MonHoc on KetQua.MaMH = MonHoc.MaMH

	where SinhVien.MaSV = @maSV
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInfoStudentByStudentCode]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetInfoStudentByStudentCode]
@maSV nvarchar(30)
as
begin
	select SinhVien.MaSV, HoTen, NgaySinh, GioiTinh, QueQuan, DanToc,
		Lop.TenLop, SDTSinhVien, EmailSinhVien, HoTenNguoiThan, SDTNguoiThan
	from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop
			left join LienHe on SinhVien.MaSV = LienHe.MaSV
	where SinhVien.MaSV = @maSV
end
GO
/****** Object:  Trigger [dbo].[UTG_InsertAccount]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[UTG_InsertAccount]
on [dbo].[Account] for insert
as
begin
	declare @username nvarchar(150)
	select @username = Username from inserted
	declare @name nvarchar(200)
	select @name = HoTen from dbo.SinhVien where MaSV = @username
	if (@name is not null)
	begin
		update dbo.Account set DisplayName = @name where Username = @username
	end
end
GO
ALTER TABLE [dbo].[Account] ENABLE TRIGGER [UTG_InsertAccount]
GO
/****** Object:  Trigger [dbo].[UTG_RemoveLopHoc]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[UTG_RemoveLopHoc]
on [dbo].[Lop]
instead of delete
as
begin
	declare @maLop nvarchar(30)
	select @maLop = MaLop from deleted
	delete from SinhVien where MaLop = @maLop
	delete from Lop where MaLop = @maLop
end
GO
ALTER TABLE [dbo].[Lop] ENABLE TRIGGER [UTG_RemoveLopHoc]
GO
/****** Object:  Trigger [dbo].[UTG_RemoveMonHoc]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[UTG_RemoveMonHoc]
on [dbo].[MonHoc]
instead of delete
as
begin
	declare @maMonHoc nvarchar(30)
	select @maMonHoc = MaMH from deleted
	delete from KetQua where MaMH = @maMonHoc
	delete from MonHoc where MaMH = @maMonHoc
end
GO
ALTER TABLE [dbo].[MonHoc] ENABLE TRIGGER [UTG_RemoveMonHoc]
GO
/****** Object:  Trigger [dbo].[UTG_RemoveSinhVien]    Script Date: 6/22/2022 1:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[UTG_RemoveSinhVien]
on [dbo].[SinhVien]
instead of delete
as
begin
	declare @maSinhVien nvarchar(30)
	Select @maSinhVien = MaSV from deleted
	delete from LienHe where MaSV = @maSinhVien
	delete from KetQua where MaSV = @maSinhVien
	delete from SinhVien where MaSV = @maSinhVien
end
GO
ALTER TABLE [dbo].[SinhVien] ENABLE TRIGGER [UTG_RemoveSinhVien]
GO
