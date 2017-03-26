create database QLThuVien
go 

use QLThuVien
go

create table KhoaHoc
(
	MaKH varchar(10) not null primary key,
	TenKH nvarchar(30)not null
)
go

create table HocSinh
(
	MaHS int not null primary key,
	HoTenHS nvarchar(50)not null,
	GioiTinh bit not null,
	NgaySinh date not null,
	DiaChi nvarchar(100)not null,
	DienThoai varchar(11),
	GhiChu nvarchar(100)
)
go

create table TacGia
(
	MaTG int not null primary key,
	HoTenTG nvarchar(50)not null	
)
go

create table TheLoaiSach
(
	MaTL varchar(20)not null primary key,
	TenTL nvarchar(50)not null
)
go

create table HocSinhKhoaHoc
(
	MaHS int not null references HocSinh(MaHS),
	MaKH varchar(10) not null references KhoaHoc(MaKH),
	NamBD int not null,
	NamKT int not null,
	primary key(MaHS,MaKH)
)
go

create table Sach
(
	MaSach varchar(10)not null primary key,
	MaTL varchar(20)not null references TheLoaiSach(MaTL),
	TenSach nvarchar(50)not null,
	SoLuong int not null,
	GiaSach int not null,
	NgayXuatBan date not null
)
go

create table Assigned_Book
(
	MaKH varchar(10)not null references KhoaHoc(MaKH),
	MaSach varchar(10) not null references Sach(MaSach),
	primary key(MaKH,MaSach)
)
go

create table SachTacGia
(
	MaTG int not null references TacGia(MaTG),
	MaSach varchar(10) not null references Sach(MaSach),
	primary key(MaTG,MaSach)
)
go

create table ChiTietMuonSach
(
	MaMuonSach int not null primary key,
	MaSach varchar(10) not null references Sach(MaSach),
	MaHS int not null references HocSinh(MaHS),
	NgayMuon date not null,
	NgayTra date not null
)
go

set dateformat dmy

insert into KhoaHoc(MaKH,TenKH) values('K10',N'Niên khoá 2010'),
										('K11',N'Niên khoá 2011')
go

insert into HocSinh(MaHS,HoTenHS,GioiTinh,NgaySinh,DiaChi,DienThoai,GhiChu)
values('10001',N'Nguyễn Đăng Khoa',1,'11/03/1996',N'Bình Thuận','0987654123',N''),
	  ('11002',N'Nguyễn Quang Huy',1,'18/12/1996',N'Bình Định','01689418416',N'')

go
	  
insert into TacGia(MaTG,HoTenTG)
values(1,N'Nguyễn Khoa'),
	  (2,N'Quách Tĩnh'),
	  (3,N'Hoàng Dung')		

go
	  
insert into TheLoaiSach(MaTL,TenTL) values('KH',N'Khoa học'),('XH',N'Xã hội'),('CN',N'Công nghệ')

go

insert into HocSinhKhoaHoc(MaHS,MaKH,NamBD,NamKT)
values('10001','K10',2010,2015),
	  ('11002','K11',2011,2016)	

go
	  
insert into Sach(MaSach,MaTL,TenSach,SoLuong,GiaSach,NgayXuatBan)values
				('KH001','KH',N'Em yêu khoa học',10,65000,'10/03/2012'),
				('XH001','XH',N'Hãy hành động',6,86000,'02/06/2010'),
				('CN001','CN',N'Kĩ thuật ô tô',2,189000,'18/12/2015')

go
				
insert into Assigned_Book(MaKH,MaSach)values('K10','XH001'),('K11','CN001'),('K10','CN001')		

go

insert into SachTacGia(MaTG,MaSach)values(1,'XH001'),(2,'CN001'),(3,'KH001')	

go

insert into ChiTietMuonSach(MaMuonSach,MaSach,MaHS,NgayMuon,NgayTra)values
						   (101,'KH001','10001','08/03/2017','18/03/2017')
						   
go
drop table NhanVien
create table NhanVien
(
	MaNV int primary key not null,
	HoTen nvarchar(50)not null,
	TaiKhoan varchar(30)not null,
	MatKhau varbinary(128)not null,
	LoaiTK int not null
)
insert into NhanVien(MaNV,HoTen,TaiKhoan,MatKhau,LoaiTK)values(1,N'Nguyễn Quang Huy','admin',cast('admin' as varbinary(128)),1),
															  (2,N'Nguyễn Đăng Khoa','khoa',cast('khoa' as varbinary(128)),2)
															  
create proc SP_KiemTraDangNhap
@TaiKhoan varchar(20),
@MatKhau varchar(20)
as
if exists (select 1 from NhanVien where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1)
	select 1 as mathongbao,N'Đăng nhập thành công' as ndthongbao,MaNV,HoTen from nhanvien 
	where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1
	else
	select 0 as mathongbao,N'Đăng nhập không thành công' as ndthongbao

GO