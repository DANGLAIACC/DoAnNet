﻿/*
use master 

drop database QL_DONG_HO

*/
create database QL_DONG_HO 
go
use QL_DONG_HO
go
create table nhasx(
	Ma_nsx int identity(10,2) primary key,
	Ten_nsx nvarchar(80) not null,
	Nuoc_sx nvarchar(20)
)
go
create table sanpham(
/*ảnh sản phẩm = ma_sp.jpg*/
	Ma_sp int identity(1000,2) primary key,
	Ten_sp nvarchar(80), 
	Gia_nhap money,
	Don_gia money,
	Hinh_dang_mat nvarchar(28),
	Kich_thuoc varchar(28),
	Chat_lieu nvarchar(28),
	Nang_luong nvarchar(28),
	Mau_sac nvarchar(28),
	Bao_hanh int,
	So_luong int,
	Ma_nsx int foreign key references nhasx(ma_nsx),
)
go
create table khachhang(
	Ma_kh int identity(100000,2) primary key,
	Ten_kh nvarchar(80),
	Dien_thoai char(10),
	Email varchar(48),
	Dia_chi nvarchar(80)
)
go
create table nhanvien(
	Ma_nv int identity(800000,2) primary key,
	Ten_nv nvarchar(80),
	Dien_thoai char(10),
	Email varchar(48),
	Dia_chi nvarchar(80),
	So_ngay_cong float,
	Luong_cb money,
)
go
create table hoadon(
	Ma_hd int identity(10000000,1) primary key,
	Ngay_lap_hd date,
	Ngay_giao date,
	Ma_nv int foreign key references nhanvien(ma_nv),
	Ma_kh int foreign key references khachhang(ma_kh)
)
go
create table cthoadon(
	Ma_hd int foreign key references hoadon(ma_hd),
	Ma_sp int foreign key references sanpham(ma_sp),
	So_luong int,
	Gia_ban money,
	primary key (ma_hd,ma_sp),
)
go

insert into nhasx values
('Rhythm',N'Nhật Bản'),
('Seiko',N'Nhật Bản'),
('Casio',N'Nhật Bản'),
('7Gift Shop',N'Việt Nam'), 
('Kashi ',N'Việt Nam')
 

insert into sanpham values
('CMH759NR06',3500000,4092000,N'Tròn','27.5',N'Gỗ',N'Quartz (chạy pin)'
,N'Nâu',36,10,10),
('CMG544NR02',1034000,1034000,N'Tròn','31',N'Nhựa',N'Quartz (chạy pin)',N'Bạc (Siver)',36,8,10),
('CMG527NR03',1000000,1496000,N'Tròn','34',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',36,7,10),
('CMG778NR06',1800000,2376000,N'Tròn','30.2',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,12,10), 
('4MJ403WD23',4630081,5720000,N'Oval','30.3 x 40.3 x 8.1',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,20,10),
('CMG292NR06',3850000,4730000,N'Tròn','59',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,7,10),


('QXM383B',17640000,19640000,N'Oval','48 x 44 x 12',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,0,12),
('QXM377B',7500000,9460000,N'Oval','44.3 x 40.5 x 9.7',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,10,12),
('QXA757B',1320000,1530000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,20,12),
('QXA757Z',1320000,1530000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Vàng',36,15,12),
('QXA752Z',2200000,2800000,N'Tròn','39.5',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,25,12),
('QXA932B',1000000,1300000,N'Tròn','21',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',36,8,12),
('QXA732W',1200000,1600000,N'Tròn','35',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',36,12,12),
('QXA675Z',1600000,1920000,N'Vuông','26.5 X 26.5',N'Gỗ',N'Quartz (chạy pin)',N'Nâu',36,8,12),
('QXA521K',1200000,1500000,N'Tròn','29.5',N'Nhựa',N'Quartz (chạy pin)',N'Đen',36,7,12),
('QXA577L',570000,770000,N'Tròn','28',N'Nhựa',N'Quartz (chạy pin)',N'Xanh dương',36,22,12), /*1030*/



('IC-02-7DF',1200000,1550000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',24,0,14), /*casio 1032*/
('IC-01-7DF',1000000,1480000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',24,12,14),
('IC-02-9DF',1400000,1550000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Vàng',24,21,14),
('IC-02-5DF',1000000,1550000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nâu',24,10,14),

/*7 gift shop 1040*/


(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 7GS-522',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,7,16),
(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 7GS-517',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,8,16),
(N'TREO TƯỜNG KHUNG VIỀN KIỂU HÀN 10 7GS-520',200000,375000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng',12,9,16),
(N'TREO TƯỜNG KIỂU HÀN KHUNG VIỀN 04 (DH7GS-508)',200000,400000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Nhiều màu sắc',12,10,16),
(N'TREO TƯỜNG KHUNG VIỀN 20180326-08',200000,400000,N'Tròn','26',N'Nhựa',N'Quartz (chạy pin)',N'Trắng - Xanh lục',12,15,16), /*1048*/



/*Kashi 1050*/
(N'treo tường HM220',350000,480000,N'Đa giác đều','33.5 x 4.5 x 33.5 (D-R-C)',N'Vỏ gỗ tự nhiên',N'Quartz (chạy pin)',N'Nâu - Trắng',24,0,18), /*1050*/
(N'treo tường HM253',400000,600000,N'Đa giác đều','52 x 4 x 52 (D-R-C)',N'Vỏ gỗ, Nhựa chuyên dụng PVC',N'Quartz (chạy pin)',N'Nâu - Trắng',24,10,18),
(N'treo tường HM222',280000,420000,N'Hình vuông','34.3 x 4.5 x 34.3 (D-R-C)',N'Vỏ gỗ tự nhiên',N'Quartz (chạy pin)',N'Trắng',24,4,18),
(N'treo tường HM346',350000,480000,N'Hình chữ nhật','40 x 56.5 x 4.5 (D-R-C)',N'Vỏ gỗ tự nhiên',N'Quartz (chạy pin)',N'Nâu - Trắng',24,2,18),
(N'treo tường HM223',150000,280000,N'Tròn','30 x 4,7',N'Nhựa',N'Quartz (chạy pin)',N'Nâu - Trắng',24,8,18)

go

insert into khachhang values
(N'Huỳnh Thị Thúy Kiều','0959128136','thuykieu123@gmail.com',N'Bình Định'),
(N'La Hoàng Long','0947947364','hoanglonghcmus@gmail.com',N'Bình Định'),
(N'Phan Ngọc Sơn','0983247833','phanngocson012@gmail.com',N'Bình Định'),
(N'Bùi Cẩm Ly','0983520712','bcly202930@gmail.com',N'TP. Hồ Chí Minh'),
(N'Tăng Quốc Phiên','0969795424','tqphien000@gmail.com',N'Phú Yên'),
(N'Bùi Hoài Phong','0922129278','hoaiphong999@gmail.com',N'Quảng Ngãi'),
(N'Văn Tiến Luận','0982338147','tienluan56@gmail.com',N'Quảng Ngãi'),
(N'Đặng Văn Biểu','0976298228','dvbieu@gmail.com',N'Khánh Hòa'),
(N'Hồ Bích Ngân','0913601094','hobichngan44@gmail.com',N'Bình Định')

go

insert into nhanvien values
(N'Nguyễn Vĩnh Hải','0985265837','tphausdjf@gmail.com',N'606 Cách mạng tháng Tám, Q.3, TP. Hồ Chí Minh',10,200000),
(N'Nguyễn Nhật Minh','0950987763','nhatminhabcigdo@gmail.com',N'608 Ngô Gia Tự, P.5, Q.10, TP. Hồ Chí Minh',15,200000),
(N'Bùi Tân Thành','0963535717','tanthanh347854@gmail.com',N'88/32/11 Lương Định Của, Q.2, TP. Hồ Chí Minh',10.5,100000),
(N'Huỳnh Nhật Hùng','0987811754','nhathung0211@gmail.com',N'22 Điện Biên Phủ, Q.3, TP. Hồ Chí Minh',15,200000),
(N'Phan Tuấn Tú','0952732418','tuabcgidido@gmail.com',N'1000/12/4 Nguyễn Hữu Cảnh, Q. Bình Thạnh, TP. Hồ Chí Minh',15,200000)

go

insert into hoadon values
('08/31/2020','08/31/2020',800000,100000),
('3/2/2020','3/2/2020',800002,100002),
('3/29/2020','3/29/2020',800004,100004),
('6/2/2020','6/2/2020',800006,100006),
('7/6/2020','7/6/2020',800008,100008),
('7/20/2020','7/20/2020',800002,100010),
('5/26/2020','5/26/2020',800004,100012),
('4/30/2020','4/30/2020',800006,100014),
('6/20/2020','6/20/2020',800008,100002),
('8/19/2020','8/19/2020',800000,100004),
('8/28/2020','8/28/2020',800002,100006),
('7/16/2020','7/16/2020',800004,100008),
('5/15/2020','5/15/2020',800006,100012),
('4/28/2020','4/28/2020',800008,100014)

go

insert into cthoadon values
(10000000,1054,1,420000),
(10000001,1058,1,280000),
(10000002,1044,1,375000),
(10000002,1002,1,1034000),
(10000003,1000,1,4092000),
(10000004,1004,1,1496000),
(10000005,1006,1,1496000),
(10000006,1008,1,1496000),
(10000007,1010,1,1496000),
(10000008,1012,1,1496000),
(10000009,1014,1,9460000),
(10000010,1016,1,1530000),
(10000011,1018,1,1530000),
(10000012,1020,1,2800000),
(10000013,1052,1,600000)

/* convert database table to class
CREATE PROCEDURE CREATEMODEL  
(  
     @TableName SYSNAME ,  
     @CLASSNAME VARCHAR(500)   
)  
AS  
BEGIN  
    DECLARE @Result VARCHAR(MAX)  
    SET @Result = @CLASSNAME + @TableName + '  
{'  
SELECT @Result = @Result + '  
    public ' + ColumnType + NullableSign + ' ' + ColumnName + ' { get; set; }'  
FROM  
(  
    SELECT   
        REPLACE(col.NAME, ' ', '_') ColumnName,  
        column_id ColumnId,  
        CASE typ.NAME   
            WHEN 'bigint' THEN 'long'  
            WHEN 'binary' THEN 'byte[]'  
            WHEN 'bit' THEN 'bool'  
            WHEN 'char' THEN 'string'  
            WHEN 'date' THEN 'DateTime'  
            WHEN 'datetime' THEN 'DateTime'  
            WHEN 'datetime2' then 'DateTime'  
            WHEN 'datetimeoffset' THEN 'DateTimeOffset'  
            WHEN 'decimal' THEN 'decimal'  
            WHEN 'float' THEN 'float'  
            WHEN 'image' THEN 'byte[]'  
            WHEN 'int' THEN 'int'  
            WHEN 'money' THEN 'decimal'  
            WHEN 'nchar' THEN 'char'  
            WHEN 'ntext' THEN 'string'  
            WHEN 'numeric' THEN 'decimal'  
            WHEN 'nvarchar' THEN 'string'  
            WHEN 'real' THEN 'double'  
            WHEN 'smalldatetime' THEN 'DateTime'  
            WHEN 'smallint' THEN 'short'  
            WHEN 'smallmoney' THEN 'decimal'  
            WHEN 'text' THEN 'string'  
            WHEN 'time' THEN 'TimeSpan'  
            WHEN 'timestamp' THEN 'DateTime'  
            WHEN 'tinyint' THEN 'byte'  
            WHEN 'uniqueidentifier' THEN 'Guid'  
            WHEN 'varbinary' THEN 'byte[]'  
            WHEN 'varchar' THEN 'string'  
            ELSE 'UNKNOWN_' + typ.NAME  
        END ColumnType,  
        CASE   
            WHEN col.is_nullable = 1 and typ.NAME in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier')   
            THEN '?'   
            ELSE ''   
        END NullableSign  
    FROM SYS.COLUMNS col join sys.types typ on col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id  
    where object_id = object_id(@TableName)  
) t  
ORDER BY ColumnId  
SET @Result = @Result  + '  
}'  
print @Result  
END

exec CREATEMODEL 'cthoadon', 'public class '

select * from INFORMATION_SCHEMA.tables

*/
