/*
use master 
go
drop database watch_store 

*/
create database WATCH_STORE
go
use WATCH_STORE
go
create table agencies( /*chi nhánh*/
	ag_id char(3) primary key,
	ag_address nvarchar(100),
	ag_phone char(10)
)
go 
create table brands( /*thương hiệu*/
	br_id varchar(10) primary key, 
	br_country nvarchar(30)
)
go
 
create table products(
	pd_id char(8) primary key,
	pd_name nvarchar(80),
	pd_retail money, 
	pd_unit nvarchar(10), 
	br_id varchar(10) foreign key references brands(br_id)
)
GO
create table agency_product(
	ag_id char(3) foreign key references agencies(ag_id),
	pd_id char(8) foreign key references products(pd_id),
	pd_remain int,
	primary key (ag_id,pd_id)
)
go

create table suppliers( /*nhà cung cấp sản phẩm*/
	sp_id char(3) primary key,
	sp_name nvarchar(100),
	sp_tin varchar(13),
	sp_address nvarchar(100),
	sp_phone char(10),
)

go
create table provide(
	pr_id char(12) primary key,
	sp_id char(3) foreign key references suppliers(sp_id),
	ag_id char(3) foreign key references agencies(ag_id), /*chi nhánh*/
	pr_date datetime, /*ngày giao*/
	pr_deliveryCost money
)
go
create table provide_detail(
	pr_id char(12) foreign key references provide(pr_id),
	pd_id char(8) foreign key references products(pd_id),
	prd_quantity int,
	prd_purchase money,
	primary key (pr_id,pd_id)
)
go
create table watches(
	pd_id char(8) primary key,
	w_shape nvarchar(30),
	w_size nvarchar(30),
	w_energy nvarchar(30),
	w_color nvarchar(30),
	w_guarantee int,
	foreign key (pd_id) references products(pd_id),
)
go
create table company(
	cp_tin varchar(13) primary key,
	cp_name nvarchar(100),
	cp_address nvarchar(100),
	cp_phone char(10),
	cp_email varchar(30),
)
go
create table customers(
	ct_id char(7) primary key,
	ct_firstName nvarchar(30),
	ct_lastName nvarchar(30),
	ct_phone char(10),
	ct_email varchar(30),
	ct_gender bit,
	ct_address nvarchar(100),
	cp_tin varchar(13) foreign key references company(cp_tin),
)
go
create table staffs(
	st_id varchar(10) primary key,
	st_password varchar(20),
	st_firstName nvarchar(30),
	st_lastName nvarchar(30),
	st_phone char(10),
	st_email varchar(30),
	st_gender bit,
	st_workdays int,
	st_birthday date,
	st_salary money,
	st_role int,
	ag_id char(3) foreign key references agencies(ag_id)
)
go 

create table orders(
	od_id char(12) primary key,
	od_dateOrder datetime,
	od_dateDelivery datetime,
	od_status int,
	od_address nvarchar(100),
	od_payment nvarchar(30),
	st_id varchar(10) foreign key references staffs(st_id),
	ct_id char(7) foreign key references customers(ct_id),
	ag_id char(3) foreign key references agencies(ag_id),
)
go
create table order_detail(
	od_id char(12) foreign key references orders(od_id),
	pd_id char(8) foreign key references products(pd_id),
	od_quantity int,
	od_price money,
	primary key (od_id,pd_id)
)
go

insert into brands values
('Rhythm',N'Nhật Bản'),
('Seiko',N'Nhật Bản'),
('Casio',N'Nhật Bản'),
('7Gift',N'Việt Nam'), 
('Kashi ',N'Việt Nam')
go
insert into agencies values
('000',N'123 Nguyễn Hữu Cảnh, Q. Bình Thạnh, TP. Hồ Chí Minh','0903989027'),
('001',N'123 Nguyễn Hữu Thọ, Q. 7, TP. Hồ Chí Minh','0905555112'),
('002',N'1200 Lê Hồng Phong, P. Phước Long, TP. Nha Trang, T. Khánh Hòa','0908339338')
go
insert into company values
('1602129732',N'CÔNG TY TNHH MTV CORE VIỆT NAM',N'24P3, đường Trần Phú, Phường Mỹ Phước, Thành phố Long Xuyên, An Giang','0916426450','admin@core.vn'),
('0109333216',N'CÔNG TY TNHH TƯ VẤN ĐẦU TƯ VÀ CÔNG NGHỆ MIC VIỆT NAM',N'Số LP20, ngõ 219 Trung Kính, Phường Yên Hoà, Quận Cầu Giấy, Thành phố Hà Nội','0868353368','phamthanhtung@mic.vn'),
('0316471647',N'CÔNG TY TNHH KỸ THUẬT CÔNG NGHỆ T&P',N'151/53/17 Đường Liên Khu 4-5, Phường Bình Hưng Hòa B, Quận Bình Tân, Thành phố Hồ Chí Minh','0908772896','admin@tap.vn'),
('0316466580',N'CÔNG TY TNHH CÔNG NGHỆ IDA',N'84/1 Bà Triệu, Thị trấn Hóc Môn, Huyện Hóc Môn, Thành phố Hồ Chí Minh','0923498652','admin@ida.vn'),
('0316470795',N'CÔNG TY CỔ PHẦN CÔNG NGHỆ VÀ TRUYỀN THÔNG GO MEDIA VIỆT NAM',N'Tầng 5, Tòa nhà WMC số 102A-B-C đường Cống Quỳnh, Phường Phạm Ngũ Lão, Quận 1, Thành phố Hồ Chí Minh','0909820302','hotro@gomedia.vn')
 go
insert into customers values
('0000000',N'Huỳnh Thị Thúy',N'Kiều','0896804466','huynhkieu1606@gmail.com',0,N'Bình Định','1602129732'),
('0000001',N'Nguyễn Thị',N'Tiên','0813788390','nguyenthitien1202@gmail.com',0,N'TP. Hồ Chí Minh','1602129732'),
('0000002',N'La Hoàng',N'Long','0523769577','hoanglonghumus@gmail.com',1,N'TP. Nha Trang','0316471647'),
('0000003',N'Tennyson',N'Ben','0307906979','bentennyson@gmail.com',0,N'Bình Định','0316471647'),
('0000004',N'Lưu Huyền',N'Đức','896713483','huyenduc.thuchan@gmail.com',1,N'TP. Hồ Chí Minh','0316470795'),
('0000005',N'Tào Mạnh',N'Đức','0559224778','manhduc123@gmail.com',1,N'TP. Hồ Chí Minh','0316470795'),
('0000006',N'Ngô Nhật',N'Huy','0596447968','ngonhathuy@gmail.com',1,N'TP. Nha Trang','0316466580'),
('0000007',N'Nguyễn Trọng',N'Khánh','0898863448','trongkhanh456@gmail.com',1,N'Bình Định','0316466580'),
('0000008',N'Hà Tiểu',N'Mai','0896228105','hatieumai@gmail.com',0,N'Phú Yên','0109333216'),
('0000009',N'Văn Tiến',N'Luận','0898863448','vantienluan@gmail.com',1,N'Bình Định','0109333216')

go

insert into products values
('00000000',N'Đồng hồ treo tường CMH759NR06',4500000,N'cái','Rhythm'),
('00000001',N'Đồng hồ treo tường CMG544NR02',1800000,N'cái','Rhythm'),
('00000002',N'Đồng hồ treo tường CMG527NR03',2000000,N'cái','Rhythm'),
('00000003',N'Đồng hồ treo tường CMG778NR06',2800000,N'cái','Rhythm'),
('00000004',N'Đồng hồ treo tường 4MJ403WD23',4500000,N'cái','Rhythm'),
('00000005',N'Đồng hồ treo tường CMG292NR06',4850000,N'cái','Rhythm'),

('00000006',N'Đồng hồ treo tường QXM383B',3800000,N'cái','Seiko'),
('00000007',N'Đồng hồ treo tường QXM377B',2500000,N'cái','Seiko'),
('00000008',N'Đồng hồ treo tường QXA757B',4500000,N'cái','Seiko'),
('00000009',N'Đồng hồ treo tường QXA757Z',4000000,N'cái','Seiko'),
('00000010',N'Đồng hồ treo tường QXA752Z',3000000,N'cái','Seiko'),
('00000011',N'Đồng hồ treo tường QXA932B',2000000,N'cái','Seiko'),
('00000012',N'Đồng hồ treo tường QXA732W',3700000,N'cái','Seiko'),
('00000013',N'Đồng hồ treo tường QXA675Z',2800000,N'cái','Seiko'),
('00000014',N'Đồng hồ treo tường QXA521K',1200000,N'cái','Seiko'),
('00000015',N'Đồng hồ treo tường QXA577L',3600000,N'cái','Seiko'),

('00000016',N'Đồng hồ treo tường IC-02-7DF',2600000,N'cái','Casio'),
('00000017',N'Đồng hồ treo tường IC-01-7DF',2800000,N'cái','Casio'),
('00000018',N'Đồng hồ treo tường IC-02-9DF',3000000,N'cái','Casio'),
('00000019',N'Đồng hồ treo tường IC-02-5DF',3200000,N'cái','Casio'),

('00000020',N'Đồng hồ treo tường khung viền kiểu Hàn 522',350000,N'cái','7Gift'),
('00000021',N'Đồng hồ treo tường khung viền kiểu Hàn 517',300000,N'cái','7Gift'),
('00000022',N'Đồng hồ treo tường khung viền kiểu Hàn 10',350000,N'cái','7Gift'),
('00000023',N'Đồng hồ treo tường khung viền kiểu Hàn 04',350000,N'cái','7Gift'),
('00000024',N'Đồng hồ treo tường khung viền kiểu Hàn 08',350000,N'cái','7Gift'),

('00000025',N'Đồng hồ treo tường HM220',4200000,N'cái','Kashi'),
('00000026',N'Đồng hồ treo tường HM253',2500000,N'cái','Kashi'),
('00000027',N'Đồng hồ treo tường HM222',3200000,N'cái','Kashi'),
('00000028',N'Đồng hồ treo tường HM346',3800000,N'cái','Kashi'),
('00000029',N'Đồng hồ treo tường HM223',4000000,N'cái','Kashi')

go 

insert into watches values
('00000000',N'Hình tròn','r = 27.5',N'Quartz (chạy pin)',N'Nâu',36),
('00000001',N'Hình tròn','r = 31',N'Quartz (chạy pin)',N'Bạc',36),
('00000002',N'Hình tròn','r = 34',N'Quartz (chạy pin)',N'Trắng',36),
('00000003',N'Hình tròn','r = 30.2',N'Quartz (chạy pin)',N'Nâu',36),
('00000004',N'Hình oval','30.3 x 40.3 x 8.1',N'Quartz (chạy pin)',N'Nâu',36),
('00000005',N'Hình tròn','r = 59',N'Quartz (chạy pin)',N'Nâu',36),

('00000006',N'Hình oval','48 x 44 x 12',N'Quartz (chạy pin)',N'Nâu',36),
('00000007',N'Hình oval','44.3 x 40.5 x 9.7',N'Quartz (chạy pin)',N'Nâu',36),
('00000008',N'Hình tròn','r = 35',N'Quartz (chạy pin)',N'Nâu',36),
('00000009',N'Hình tròn','r = 35',N'Quartz (chạy pin)',N'Vàng',36),

('00000010',N'Hình tròn','r = 39.5',N'Quartz (chạy pin)',N'Nâu',12),
('00000011',N'Hình tròn','r = 21',N'Quartz (chạy pin)',N'Nâu',12),
('00000012',N'Hình tròn','r = 35',N'Quartz (chạy pin)',N'Trắng',12),
('00000013',N'Hình vuông','26.5 x 26.5',N'Quartz (chạy pin)',N'Nâu',12),
('00000014',N'Hình tròn','r = 29.5',N'Quartz (chạy pin)',N'Đen',12),
('00000015',N'Hình tròn','r = 28',N'Quartz (chạy pin)',N'Xanh dương',12),

('00000016',N'Hình tròn','r = 26',N'Quartz (chạy pin)',N'Nâu',12),
('00000017',N'Hình tròn','r = 26',N'Quartz (chạy pin)',N'Trắng',12),
('00000018',N'Hình tròn','r = 26',N'Quartz (chạy pin)',N'Vàng',12),
('00000019',N'Hình tròn','r = 26',N'Quartz (chạy pin)',N'Nâu',12),

('00000020',N'Hình tròn','r=26',N'Quartz (chạy pin)',N'Nhiều màu sắc',12),
('00000021',N'Hình tròn','r=26',N'Quartz (chạy pin)',N'Nhiều màu sắc',12),
('00000022',N'Hình tròn','r=26',N'Quartz (chạy pin)',N'Nhiều màu sắc',12),
('00000023',N'Hình tròn','r=26',N'Quartz (chạy pin)',N'Nhiều màu sắc',12),
('00000024',N'Hình tròn','r=26',N'Quartz (chạy pin)',N'Nhiều màu sắc',12),

('00000025',N'Hình đa giác đều','33.5 x 4.5 x 33.5 (D-R-C)',N'Quartz (chạy pin)',N'Nâu - Trắng',12),
('00000026',N'Hình đa giác đều','52 x 4 x 52 (D-R-C)',N'Quartz (chạy pin)',N'Nâu - Trắng',12),
('00000027',N'Hình vuông','34.3 x 4.5 x 34.3 (D-R-C)',N'Quartz (chạy pin)',N'Trắng',12),
('00000028',N'Hình chữ nhật','40 x 56.5 x 4.5 (D-R-C)',N'Quartz (chạy pin)',N'Nâu - Trắng',12),
('00000029',N'Hình tròn','30 x 4,7',N'Quartz (chạy pin)',N'Đen',12)
go 

insert into staffs values
('admin','admin',N'Đặng Quốc',N'Lai','0772470922','danglai.mail@gmail.com',1,10,'12/22/2000',100000,0,'000'), /*admin*/

('lhkhang','lhkhang',N'Lê Hoàng',N'Khang','0908465894','lhkhang@gmail.com',1,10,'6/16/2000',150000,1,'000'),
('thphuong','thphuong',N'Triệu Hà',N'Phương','0902568425','thphuong@gmail.com',0,4,'2/19/2000',100000,1,'000'),
('ngmy','ngmy',N'Ngô Hoàng',N'My','0908055364','ngmy@gmail.com',1,5,'7/17/2000',170000,1,'000'),

('ntdung','ntdung',N'Nguyễn Thành',N'Dũng','0906980736','ntdung@gmail.com',1,4,'5/13/1999',120000,1,'001'),
('dttram','dttram',N'Đặng Thùy',N'Trâm','0906343749','dttram@gmail.com',0,23,'9/13/1999',200000,1,'001'),
('hqhuy','hqhuy',N'Huỳnh Quang', N'Huy','0907100763','hqhuy@gmail.com',1,8,'3/13/1999',120000,1,'001'),

('dtminh','dtminh',N'Đặng Thành',N'Minh','0903951811','dtminh@gmail.com',1,10,'1/7/2000',120000,1,'002'),
('tbngoc','tbngoc',N'Trịnh Bảo',N'Ngọc','0905151706','tbngoc@gmail.com',0,12,'12/14/2000',170000,1,'002'),
('nqtrung','nqtrung',N'Nguyễn Quang',N'Trung','0903951811','dtminh@gmail.com',1,10,'8/7/2000',120000,1,'002')

go

insert into suppliers values 
('111',N'CÔNG TY CỔ PHẦN TRỰC TUYẾN ĐĂNG QUANG','0104938104',N'Tổ 13, Phường Thượng Thanh, Quận Long Biên, Thành phố Hà Nội','0436557330'),
('112',N'CÔNG TY TNHH ĐỒNG HỒ HẢI TRIỀU','0315667679',N'281/11 Khuông Việt, Phường Phú Trung, Quận Tân Phú, Thành phố Hồ Chí Minh','0436557332'),
('113',N'CÔNG TY CỔ PHẦN THẾ GIỚI DI ĐỘNG','0312358714',N'130 Trần Quang Khải, Phường Tân Định, Quận 1, Thành phố Hồ Chí Minh','0436557338')
go

insert into provide values
('000000000000','111','000','09/01/2020',0),
('000000000001','112','000','09/03/2020',0),
('000000000002','113','000','09/06/2020',100000),
('000000000003','113','001','09/06/2020',200000),
('000000000004','112','002','09/06/2020',300000),
('000000000005','111','002','09/06/2020',0)
 
go

insert into provide_detail values
('000000000000','00000000',10,4000000),
('000000000000','00000001',7,1000000),
('000000000000','00000002',8,1000000),
('000000000000','00000003',9,2000000),
('000000000000','00000004',6,3800000),

('000000000001','00000010',5,2500000),
('000000000001','00000011',2,1500000),
('000000000001','00000012',1,3000000),
('000000000001','00000013',3,2000000),
('000000000001','00000014',12,800000),
('000000000001','00000015',14,3000000),

('000000000002','00000015',18,3200000),
('000000000002','00000016',2,2000000),
('000000000002','00000017',3,2000000),
('000000000002','00000018',20,2200000), 

('000000000003','00000026',8,2000000), 
('000000000003','00000027',6,2500000), 
('000000000003','00000028',4,3000000), 
('000000000003','00000029',12,3200000), 

('000000000004','00000005',22,4000000), 
('000000000004','00000006',23,3200000), 
('000000000004','00000007',14,2000000), 
('000000000004','00000008',16,3500000), 
('000000000004','00000009',18,3200000), 

('000000000005','00000021',22,250000), 
('000000000005','00000022',13,300000), 
('000000000005','00000023',47,300000), 
('000000000005','00000024',23,300000), 
('000000000005','00000025',19,320000),
('000000000005','00000026',20,2000000)

/* thêm data cho bảng angency_product kiểm tra số lượng còn lại của mỗi cửa hàng với 
từng sản phẩm. Giả sử trường hợp đầu tiên là cửa hàng chỉ nhập và chưa bán bất kỳ mặt hàng nào.
Lưu ý ag_id =000, mặt hàng số 00000015 có 2 lần nhập vào 2 ngày khác nhau, nên số lượng có thay
đổi, kiểm tra bằng câu lệnh bên dưới comment này, dòng 11, 12
 
	select a.ag_id,b.pd_id,b.prd_quantity,a.pr_date
	from provide a inner join provide_detail b on a.pr_id = b.pr_id 

*/

insert into agency_product (ag_id,pd_id,pd_remain)
	select a.ag_id,b.pd_id,sum(b.prd_quantity) pd_remain
	from provide a inner join provide_detail b on a.pr_id = b.pr_id 
	group by a.ag_id,b.pd_id

go 

insert into orders values
('000000000000',GETDATE(),GETDATE(),0,N'606 Quốc lộ 13, TP. Hồ Chí Minh',N'Tiền mặt','admin','0000000','000')
go
insert into order_detail values
('000000000000','00000000',1,4500000),
('000000000000','00000001',1,1800000)

go
/* Thêm 1 đơn hàng -> số lượng trong bảng agency_product giảm đi nên cần viết hàm*/

create proc addOrders (
	@od_id char(12),
	@od_dateDelivery datetime,
	@od_status int,
	@od_address nvarchar(100),
	@od_payment nvarchar(30),
	@st_id varchar(10),
	@ct_id char(7),
	@ag_id char(3),
	@pd_id char(8) 
) as 
begin
-- Nếu đơn hàng chưa tồn tại thì tạo mới
	if not exists (select od_id from orders where od_id=@od_id)
		insert into orders values
		(@od_id,GETDATE(),@od_dateDelivery,@od_status,@od_address,@od_payment, @st_id, @ct_id, @ag_id)

	declare @od_price money = (select pd_retail from products where pd_id = @pd_id)

	declare @od_quantity int = (select od_quantity from order_detail where (od_id = @od_id) and (pd_id=@pd_id))

	-- Nếu chưa tồn tại trong bảng chi tiết đơn hàng
	if (@od_quantity is null) 
	begin
		set @od_quantity = 1
		insert into order_detail values (@od_id,@pd_id,@od_quantity,@od_price)
	end
	-- Trường hợp sản phẩm và đơn hàng đã tồn tại trong bảng chi tiết đơn hàng
	else 
		update order_detail
		set od_quantity = @od_quantity + 1
		where (od_id = @od_id and pd_id=@pd_id)

	update agency_product
	set pd_remain = pd_remain-1
	where ag_id=@ag_id and pd_id = @pd_id
end

go

create proc addProducts (
	@pr_id char(12),
	@sp_id char(3),
	@ag_id char(3), 
	@pr_deliveryCost money,
	@pd_id char(8),
	@prd_quantity int,
	@prd_purchase money
) as
begin
	declare @id char(12) = (select pr_id from provide where @pr_id = pr_id)
	if(@id is null)
		insert into provide values (@pr_id,@sp_id,@ag_id,GETDATE(),@pr_deliveryCost)
	insert into provide_detail values (@pr_id,@pd_id,@prd_quantity,@prd_purchase)

	declare @quantity int = (select pd_remain from agency_product where ag_id=@ag_id and pd_id=@pd_id)
	if(@quantity is null)
		insert into agency_product values (@ag_id,@pd_id,@quantity)
	else
		update agency_product set pd_remain = (@quantity+@prd_quantity) where (ag_id=@ag_id and pd_id=@pd_id)

end

/*
select * from agencies
select * from brands
select * from company
select * from customers
select * from order_detail
select * from agency_product
select * from staffs
select * from orders
select * from products
select * from provide
select * from provide_detail
select * from suppliers
select * from watches
*/
/* 
declare @tdate datetime = getdate()

exec addOrders @od_id = '000000000002',
	@od_dateDelivery = @tdate,
	@od_status = 2,
	@od_address = N'Địa chỉ test',
	@od_payment = N'Tiền mặt',
	@st_id = 'admin',
	@ct_id = '0000000',
	@ag_id = '000',
	@pd_id = '00000000'
*/

/* convert database table to class
CREATE PROCEDURE CREATEMODEL  
(  
     @TableName SYSNAME 
)  
AS  
BEGIN  
    DECLARE @Result VARCHAR(MAX)  
    SET @Result = 'public class ' + upper(left(@TableName,1)) + substring(@TableName,2,len(@TableName))+ '_DTO
{'  
SELECT @Result = @Result + '  
    public ' + ColumnType + NullableSign + ' ' + ColumnName + ' { get; set; }'  
FROM  
(  
    SELECT
		upper(left(col.NAME,1)) + substring(col.NAME,2,len(col.NAME)) ColumnName,  
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

exec CREATEMODEL 'watches'

select * from INFORMATION_SCHEMA.tables

*/

 