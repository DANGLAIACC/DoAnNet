create database QL_DONG_HO 
go
use QL_DONG_HO
go
create table nhasx(
	ma_nsx char(8) primary key,
	ten_nsx nvarchar(80) not null,
	nuoc_sx nvarchar(20)
)
go
create table khachhang(
	ma_kh char(8) primary key,
	ten_kh nvarchar(80),
	dien_thoai char(10),
	email varchar(20),
	dia_chi nvarchar(80)
)
go
create table nhanvien(
	ma_nv char(8) primary key,
	ten_nv nvarchar(80),
	dien_thoai char(10),
	email varchar(20),
	dia_chi nvarchar(80),
	so_ngay_cong float,
	luong_cb money,
)
go
create table sanpham(
	ma_sp char(9) primary key,
	ten_sp nvarchar(80),
	img nvarchar(20),
	gia_nhap money,
	don_gia money,
	bao_hanh int,
	ma_nsx char(8) foreign key references nhasx(ma_nsx),
)
go
create table hoadon(
	so_hd char(10) primary key,
	ngay_lap_hd datetime,
	ngay_giao datetime,
	ma_nv char(8) foreign key references nhanvien(ma_nv)
)
go
create table cthoadon(
	so_hd char(10) foreign key references hoadon(so_hd),
	ma_sp char(9) foreign key references sanpham(ma_sp),
	so_luong int,
	gia_ban money,
	primary key (so_hd,ma_sp),
)
