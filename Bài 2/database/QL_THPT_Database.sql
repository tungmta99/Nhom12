USE master

CREATE DATABASE QuanLyHocSinhGiaoVienTHPT

USE QuanLyHocSinhGiaoVienTHPT
GO

 CREATE TABLE TaiKhoan(
	ID_TaiKhoan INT,
	TenTaiKhoan NCHAR(50),
	MatKhau NCHAR(50),
	PRIMARY KEY(ID_TaiKhoan)
 )
 GO


CREATE TABLE GiaoVien(
	ID_GV NCHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(10),
	NgaySinh DATE,
	QueQuan NVARCHAR(50),
	TrinhDo NVARCHAR(50),	
	SDT INT
	PRIMARY KEY(ID_GV),	
)
GO

CREATE TABLE LopHoc(
	MaLopHoc NCHAR(20) NOT NULL,
	TenLopHoc NVARCHAR(50) NOT NULL,
	NamHoc NVARCHAR(10),
	PRIMARY KEY(MaLopHoc),	
)
GO

CREATE TABLE DayHoc(
	MonHoc NVARCHAR(20),
	ID_GV NCHAR(10),
	MaLopHoc NCHAR(20),
	Thu NVARCHAR(10),
	Tiet NCHAR(10),
	FOREIGN KEY(ID_GV) REFERENCES GiaoVien(ID_GV),
	FOREIGN KEY(MaLopHoc) REFERENCES LopHoc(MaLopHoc)
)
GO

CREATE TABLE HocSinh(
	ID_HS NCHAR(10),
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(10),
	NgaySinh DATE,
	QueQuan NVARCHAR(50),
	MaLopHoc NCHAR(20),
	PRIMARY KEY(ID_HS),
	FOREIGN KEY(MaLopHoc) REFERENCES LopHoc(MaLopHoc),
)
GO


INSERT dbo.GiaoVien(ID_GV, HoTen, GioiTinh, NgaySinh, QueQuan, TrinhDo, SDT)
VALUES ('001', N'Ngyễn Thị Hạnh', N'Nữ', '1977-5-15', N'Vĩnh Phúc', N'Thạc sỹ', 0386597421)
INSERT dbo.GiaoVien(ID_GV, HoTen, GioiTinh, NgaySinh, QueQuan, TrinhDo, SDT)
VALUES ('002', N'Lê Quốc Tuấn', N'Nam', '1972-6-2', N'Hà Nam', N'Tiến sỹ', 0932475110)
INSERT dbo.GiaoVien(ID_GV, HoTen, GioiTinh, NgaySinh, QueQuan, TrinhDo, SDT)
VALUES ('003', N'Trần Thi Thu Huyền', N'Nữ', '1975-12-2', N'Hưng Yên', N'Thạc sỹ', 0326558744)
INSERT dbo.GiaoVien(ID_GV, HoTen, GioiTinh, NgaySinh, QueQuan, TrinhDo, SDT)
VALUES ('004', N'Ngô Quang Chiến', N'Nam', '1970-4-12', N'Hà Nội', N'Giáo sư', 0936358524)
INSERT dbo.GiaoVien(ID_GV, HoTen, GioiTinh, NgaySinh, QueQuan, TrinhDo, SDT)
VALUES ('005', N'Nguyễn Minh Công', N'Nam', '1972-6-2', N'Lao Cai', N'Giáo viên' , 0364211017)

INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)
VALUES ('20032', N'Nguyễn Thái Sơn', N'Nam', '2007-10-20', N'Hà Nội', 'L7A')
INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)
VALUES ('20029', N'Lê Như Quỳnh', N'Nữ', '2007-12-14', N'Hà Nội', 'L7A')
INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)
VALUES ('20023', N'Cao Văn Quyết', N'Nam', '2007-5-15', N'Hà Nội', 'L7A')
INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)
VALUES ('20012', N'Vũ Thu Hường', N'Nữ', '2007-1-20', N'Hà Nội', 'L7A')
INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)
VALUES ('20002', N'Trần Hải Anh', N'Nam', '2007-1-31', N'Hà Nội', 'L7A')

INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet)
VALUES (N'Toán', '002', 'L7A', N'Thứ 3', N'1-3')
INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet)
VALUES (N'Lý', '004', 'L7A', N'Thứ 4', N'10-12')
INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet)
VALUES (N'Hóa', '001', 'L7A', N'Thứ 2', N'4-5')
INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet)
VALUES (N'Tiếng Anh', '003', 'L7A', N'Thứ 3', N'4-6')
INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet)
VALUES (N'Sinh', '005', 'L7A', N'Thứ 5', N'4-6')

INSERT dbo.LopHoc(MaLopHoc, TenLopHoc, NamHoc)
VALUES ('L7A', N'Lớp 7A', N'2019-2020')

INSERT dbo.TaiKhoan(ID_TaiKhoan, TenTaiKhoan, MatKhau)
VALUES ('1', 'admin', '123')


