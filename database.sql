use master 

drop database QL_DONG_HO

create database QL_DONG_HO 
go
use QL_DONG_HO
go
create table nhasx(
	ma_nsx int identity(10,2) primary key,
	ten_nsx nvarchar(80) not null,
	nuoc_sx nvarchar(20)
)
go
create table sanpham(
/*ảnh sản phẩm = ma_sp.jpg*/
	ma_sp int identity(1000,2) primary key,
	ten_sp nvarchar(80), 
	gia_nhap money,
	don_gia money,
	hinh_dang_mat nvarchar(20),
	duong_kinh_mat varchar(20),
	chat_lieu nvarchar(20),
	nang_luong nvarchar(20),
	mau_sac nvarchar(20),
	bao_hanh int,
	ma_nsx int foreign key references nhasx(ma_nsx),
)
go
create table khachhang(
	ma_kh int identity(100000,2) primary key,
	ten_kh nvarchar(80),
	dien_thoai char(10),
	email varchar(20),
	dia_chi nvarchar(80)
)
go
create table nhanvien(
	ma_nv int identity(800000,2) primary key,
	ten_nv nvarchar(80),
	dien_thoai char(10),
	email varchar(20),
	dia_chi nvarchar(80),
	so_ngay_cong float,
	luong_cb money,
)
go
create table hoadon(
	so_hd int identity(10000000,1) primary key,
	ngay_lap_hd datetime,
	ngay_giao datetime,
	ma_nv int foreign key references nhanvien(ma_nv)
)
go
create table cthoadon(
	so_hd int foreign key references hoadon(so_hd),
	ma_sp int foreign key references sanpham(ma_sp),
	so_luong int,
	gia_ban money,
	primary key (so_hd,ma_sp),
)
go

insert into nhasx values
('Rhythm',N'Nhật Bản'),
('Seiko',N'Nhật Bản'),
('Casio',N'Nhật Bản'),
('7Gift Shop',N'Việt Nam'),
('Gimiko',N'Việt Nam'),
('Kashi ',N'Việt Nam')
 
insert into sanpham values
('CMH759NR06',3500000,4092000,N'Tròn','27.5',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,10),
('CMG544NR02',1034000,1034000,N'Tròn','31',N'Nhựa',N'Quartz (chạy pin)',N'Bạc (Siver)',36,10),
('CMG527NR03',1496000,1496000,N'Tròn','34',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',36,10),
('CMG778NR06',2376000,2376000,N'Tròn','30.2',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,10), 
('4MJ403WD23',5630081,5720000,N'Oval','30.3 x 40.3 x 8.1',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,10),
('CMG292NR06',4730000,4730000,N'Tròn','59',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,10),

('QXM383B',19640000,19640000,N'Oval','48 x 44 x 12',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXM377B',9460000,9460000,N'Oval','44.3 x 40.5 x 9.7',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXA757B',1530000,1530000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXA757Z',1530000,1530000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Vàng',36,12),
('QXA752Z',2800000,2800000,N'Tròn','39.5',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXA932B',1160884,1300000,N'Tròn','21',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXA732W',1349475,1600000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',36,12),
('QXA675Z',1920000,1920000,N'Vuông','26.5 X 26.5',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,12),
('QXA521K',1500000,1500000,N'Tròn','29.5',N'Nhựa',N'Quartz (chạy pin)',N'Đen',36,12),
('QXA577L',770000,770000,N'Tròn','28',N'Nhựa',N'Quartz (chạy pin)',N'Xanh dương',36,12), /*1030*/


('IC-02-7DF',1505753,1551000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',24,14), /*casio 1032*/
('IC-01-7DF',1143730,1481000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',24,14),
('IC-02-9DF',1451878,1551000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Vàng',24,14),
('IC-02-5DF',1069699,1551000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',24,14),

/*7 gift shop 1040*/
(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 7GS-522',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,16),
(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 7GS-517',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,16),
(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 10 7GS-520',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',12,16),
(N'TREO TƯỜNG KIỂU HÀN KHUNG VIỀN 04 (DH7GS-508)',200000,400000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,16),
(N'TREO TƯỜNG KHUNG VIỀN 20180326-08',200000,400000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng - Xanh lục',12,16), /*1050*/

select * from nhasx

select * from sanpham


select * from nhasx

select * from sanpham

/*

donghominhtuong.com.vn

var lstDD = document.querySelectorAll("dd");
var gia = document
  .querySelector("p.s-price.one")
  .innerText.replaceAll(".", "")
  .replace("Giá: ", "");
var loi = Math.trunc(Math.random() * 500000 * Math.trunc(Math.random() * 2));
var x = `('${lstDD[0].innerText}',${gia - loi},${gia},N'${
  lstDD[1].innerText
}','${lstDD[2].innerText}',N'${lstDD[3].innerText}',N'${lstDD[4].innerText}',N'${
  lstDD[5].innerText
}',${lstDD[6].innerText.replace(" tháng", "")},12),`;
console.log(x);
console.log(document.querySelector('.zoomWindowContainer>div').style.backgroundImage)

*/