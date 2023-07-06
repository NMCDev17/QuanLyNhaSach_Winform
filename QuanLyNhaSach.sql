create database QL_NhaSach
use QL_NhaSach;
go

create table NhanVien 
(
	MaNV char(10) not null primary key,
	TenNV nvarchar(50) not null,
	GioiTinh bit not null,
	NamSinh datetime not null,
	SDT char(10) null,
	QuenQuan nvarchar(50) null,
);

create table KhachHang
(
	MaKH char(10) not null primary key,
	TenKH nvarchar(50) not null,
	GioiTinh bit not null,
	SDT char(10) null,
	DiaChi nvarchar(50) not null,
);

create table NhaCungCap
(
	MaNCC char(10) not null primary key,
	TenNCC nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	SDT char(10) null,
	Email nvarchar(50) null,
);

create table Sach
(
	MaSach char(10) not null primary key,
	TenSach nvarchar(50) not null,
	TenTG nvarchar(50) null,
	TheLoai nvarchar(50) not null,
	GiaBan int not null,
	GiaMua int not null,
	MaNCC char(10) not null,
	constraint FK_SACH_NHACUNGCAP
	foreign key (MaNCC) references NhaCungCap(MaNCC),
);

create table HoaDon
(
	MaHD char(10) not null,
	MaSach char(10) not null,
	MaKH char(10) not null,
	ThanhTien int null,
	SoLuong int null,
	constraint FK_HD_SACH
	foreign key (MaSach) references Sach(MaSach),
	constraint FK_HD_KH
	foreign key (maKH) references KhachHang(MaKH)
);

create table KhoSach
(
	MaKho char(10) not null,
	MaSach char(10) not null,
	SoLuong int not null,
	NgayNhap datetime not null,
	constraint FK_KS_SACH
	foreign key (masach) references Sach(masach)
);

create table TaiKhoan
(
	TenTK nvarchar(50) not null primary key,
	MatKhau char(50) not null
);
