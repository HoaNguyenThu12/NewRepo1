create database shopquanao
go
use shopquanao
go
create table khachhang
(
	makh char(5) primary key,
	hoten nvarchar(30),
	diachi nvarchar(100),
	sdt int
)
go 
create table taikhoan
(
	matk varchar(30) primary key,
	tentaikhoan nvarchar(30),
	matkhau varchar(84),
	email varchar(50)
)
go
create table loaisanpham
(
	maloaisp int identity primary key,
	tenloaisp nvarchar(50)
)
go 
create table sanpham
(
	masp varchar(20) primary key,
	tensp nvarchar(50),
	dvt nvarchar(10),
	giaban int,
	soluongton int,
	maloaisp int foreign key references loaisanpham(maloaisp),
)
go
create table hoadon 
(
	sohd int identity primary key,
	ngayban datetime,
	giaban int,
	makh char(5) foreign key references khachhang(makh),
	nguoiban varchar(30) foreign key references taikhoan(matk)
)
go 
create table cthoadon
(
	sohd int foreign key references hoadon(sohd),
	masp varchar(20) foreign key references sanpham(masp),
	soluongban int,
	giaban int,
	primary key (sohd,masp)
)
go

INSERT INTO taikhoan(matk, tentaikhoan, matkhau, email)VALUES ( N'50361' , N'Quản Lý' , N'50361', N'quanly@gmail.com')
INSERT INTO taikhoan(matk, tentaikhoan, matkhau, email)VALUES ( N'50362' , N'Nhân Viên' , N'50362', N'nhanvien@gmail.com')
INSERT INTO taikhoan(matk, tentaikhoan, matkhau, email)VALUES ( N'50363' , N'Nhân Viên 1' , N'50363', N'nhanvien1@gmail.com')

INSERT INTO loaisanpham(tenloaisp)VALUES ( N'Áo')
INSERT INTO loaisanpham(tenloaisp)VALUES ( N'Quần')
INSERT INTO loaisanpham(tenloaisp)VALUES ( N'Áo Khoác')
INSERT INTO loaisanpham(tenloaisp)VALUES ( N'Nón')
INSERT INTO loaisanpham(tenloaisp)VALUES ( N'Giày/Dép')

