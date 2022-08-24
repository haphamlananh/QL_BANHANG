create database QuanLyBanHang
use QuanLyBanHang

create table DANGNHAP(
	ten_dang_nhap nvarchar(50),
	mat_khau nvarchar(50)
)
insert into DANGNHAP (ten_dang_nhap, mat_khau) VALUES ('nhom6-quanlybanhang', '123456')
insert into DANGNHAP (ten_dang_nhap, mat_khau) VALUES ('123', '123')


create table NHANVIEN (
	ma_nv primary key IDENTITY(1,1),
	ho_ten VARCHAR(50),
	gioi_tinh VARCHAR(50),
	ngay_sinh DATE,
	SDT VARCHAR(50),
	dia_chi VARCHAR(50),
);
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Alaric', 'Male', '4/24/2022', '193-438-1515', '67 Vidon Road');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Tyson', 'Male', '9/21/2021', '119-808-9403', '0 Hansons Place');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Kain', 'Male', '2/8/2022', '869-364-7801', '9 Miller Terrace');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Barbie', 'Genderfluid', '2/14/2022', '450-693-0171', '13 Mandrake Parkway');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Christine', 'Genderfluid', '11/29/2021', '585-383-4129', '1686 Spohn Road');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Abbie', 'Male', '3/24/2022', '287-612-9533', '664 Northview Alley');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Ozzie', 'Male', '7/2/2021', '155-113-2048', '60096 Crest Line Street');
insert into NHANVIEN (ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values ('Celia', 'Female', '3/5/2022', '804-598-4454', '8768 Judy Parkway');


create table HANGHOA (
	ma_hang_hoa INT primary key IDENTITY(1,1),
	ten_nhom_hang NVARCHAR(50), --Thêm thuộc tính
	ten_hang_hoa nVARCHAR(50),
	don_gia INT,
	so_luong_ton_kho int, /* Them thuoc tinh so luong ton kho*/
	don_vi_tinh NVARCHAR(50),
	VAT float,

);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Lương thực', 'Bread - Wheat Baguette', 627,100, N'đồng', 0.1);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Peach - Fresh', 633,40,  N'đồng', 0.04);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Kem', 'Island Oasis - Ice Cream Mix', 278, 50, N'đồng', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Rau', 'Lettuce - Arugula', 969, 60, N'đồng', 0.04);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Lương thực', 'Bag - Bread, White, Plain', 195, 60, N'đồng', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ hộp', 'Soup - Campbells Bean Medley', 813, 60, N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ ăn chế biến sẵn', 'Edible Flower - Mixed', 105, 47, N'đồng', 0.01);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ bếp', 'Steam Pan Full Lid', 698, 76 ,N'đồng', 0.1);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ dùng', 'French Kiss Vanilla', 926,43 , N'đồng', 0.014);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ bếp', 'Ocean Spray - Ruby Red', 143,44,  N'đồng', 0.07);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Glaze - Clear', 623,50,  N'đồng', 0.011);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Thịt', 'Mcguinness - Blue Curacao', 711,100,  N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Hoa quả', 'Cheese - Gouda', 696,200,  N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Gia vị', 'Cheese-Powder', 696,200,  N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Rau củ', 'Dragon Fruit', 696,200,  N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ ăn vặt', 'Oreo', 696,200,  N'đồng', 0.09);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Lương thực', 'Rice Paper', 422, 43, 'dong', 0.07);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Gia vị', 'Mushroom - Porcini, Dry', 261, 431, 'dong', 0.04);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Gia vị', 'Pastry - Trippleberry Muffin - Mini', 605, 2435, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Wine - Pinot Grigio Collavini', 809, 543, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ hộp', 'Pastry - Apple Muffins - Mini', 403,5433, 'dong', 0.06);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Curry Powder Madras', 732,90, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ ăn chế biến sẵn', 'Shortbread - Cookie Crumbs', 987,45, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Gia vị', 'Cheese - Brick With Pepper', 169, 99,'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia, so_luong_ton_kho,don_vi_tinh, VAT) values (N'Gia vị', 'Bagelers', 308, 20,'dong', 0.1);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Gia vị', 'Cilantro / Coriander - Fresh', 474,233, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia, so_luong_ton_kho,don_vi_tinh, VAT) values (N'Đồ uống', 'Wine - Trimbach Pinot Blanc', 737,98, 'dong', 0.1);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Baking Soda', 323,89, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia, so_luong_ton_kho,don_vi_tinh, VAT) values (N'Đồ uống', 'Spice - Greek 1 Step', 387,323, 'dong', 0.02);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Kem', 'Cream - 18%', 896, 340,'dong', 0.07);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia, so_luong_ton_kho,don_vi_tinh, VAT) values (N'Kem', 'Veal - Shank, Pieces', 780, 231,'dong', 0.07);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Beer - Sleemans Honey Brown', 633,232, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Puree - Mocha', 539, 222,'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia, so_luong_ton_kho,don_vi_tinh, VAT) values (N'Đồ uống', 'Lid Tray - 16in Dome', 42,888, 'dong', 0.1);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Đồ uống', 'Water - Spring Water, 355 Ml', 4799,88, 'dong', 0);
insert into HANGHOA (ten_nhom_hang, ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'Hoa quả', 'Dried Cherries', 889, 99,'dong', 0);



create table KHACHHANG (
	ma_kh INT primary key IDENTITY(1,1),
	ho_ten VARCHAR(50),
	cccd varchar(15),
	gioi_tinh VARCHAR(50),
	SDT VARCHAR(50),
	dia_chi VARCHAR(50)
);
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Cogilith Fatz', '3532532535', 'Male', '849-514-2342', '27 Pankratz Street');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Fivechat Riffpath', '7457985945', 'Male', '351-529-2645', '7 Clove Park');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Fatz', '509874325', 'Genderfluid', '516-675-2402', '0993 Caliangt Way');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Riffpath', '52938745', 'Male', '405-663-3562', '38042 Waywood Junction');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Lalerr Oyonder', '905838495', 'Male', '707-173-1770', '4 Norway Maple Alley');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Devshare Male', '148791432', 'Male', '433-831-8376', '0 Graceland Trail');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Gigaclub Oyonder', '2459853', 'Male', '277-874-0667', '2 Quincy Pass');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Dazzlesphere', '25989344', 'Male', '414-888-2364', '096 Derek Way');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Aibox', '109879537', 'Male', '708-549-1962', '205 Meadow Ridge Circle');
insert into KHACHHANG (ho_ten, cccd, gioi_tinh, SDT, dia_chi) values ('Feedfish', '0935894395', 'Male', '271-617-1441', '9422 Oak Valley Center');
Select * from KHACHHANG

create table QUAY (
	ma_quay INT primary key IDENTITY(1,1),
	ten_quay VARCHAR(50)
);
insert into QUAY (ten_quay) values ('Quay so 1');
insert into QUAY (ten_quay) values ('Quay so 2');
insert into QUAY (ten_quay) values ('Quay so 3');


create table HOADON (
	ma_hd int primary key IDENTITY(1,1),
	ma_nv INT,
	ma_quay INT,
	ma_kh INT,
	ngay_lap_hd DATE,
	FOREIGN KEY (ma_nv) REFERENCES NHANVIEN(ma_nv),
	FOREIGN KEY (ma_quay) REFERENCES QUAY(ma_quay),
	FOREIGN KEY (ma_kh) REFERENCES KHACHHANG(ma_kh)
);
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 3, null, '4/20/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (2, 3, 7, '7/2/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 2, 6, '10/9/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 2, 3, '12/10/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 1, '3/20/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 2, 3, '12/25/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (1, 1, null, '2/1/2022');
select *from HOADON
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (1, 2, 3, '7/9/2021');
/* chúng ta làm 7 hóa đơn thôi cho ngắn:v
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (4, 3, 8, '5/20/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 1, 5, '11/21/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (1, 2, 7, '11/13/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 6, '10/21/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 1, 2, '7/16/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (2, 2, null, '7/24/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 2, 10, '3/18/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 10, '4/14/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (2, 3, 3, '11/6/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 3, 6, '10/1/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (1, 1, 5, '10/11/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (3, 1, 3, '1/31/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 2, 6, '1/15/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (2, 2, 2, '3/12/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (1, 2, 6, '3/6/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (4, 2, 1, '4/1/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (8, 1, 8, '1/6/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (4, 2, 9, '11/29/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (2, 1, 10, '3/19/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (4, 2, 4, '5/20/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 3, 4, '1/8/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (8, 2, 2, '9/24/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 2, 9, '7/9/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 7, '8/17/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 3, 8, '5/6/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 3, '6/15/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (8, 1, 8, '10/21/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (8, 1, 5, '12/16/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 2, 3, '11/22/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (5, 3, 8, '6/19/2021');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (7, 3, 2, '3/22/2022');
insert into HOADON (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values (6, 1, 1, '7/10/2021');
*/


create table CHITIETHOADON (
	ma_hd INT,
	ma_hang_hoa INT,
	so_luong INT,
	primary key (ma_hd, ma_hang_hoa),
	foreign key (ma_hd) references HOADON(ma_hd),
	foreign key (ma_hang_hoa) references HANGHOA(ma_hang_hoa)
);
-- trigger TRỪ đi so luong tồn kho trong HANGHOA
create trigger trg_CapNhatSoLuongSauKhiBan on CHITIETHOADON AFTER INSERT AS
BEGIN
	UPDATE HANGHOA
	SET so_luong_ton_kho = so_luong_ton_kho - (
		select so_luong
		from inserted
		where ma_hang_hoa=HANGHOA.ma_hang_hoa
	)
	FROM HANGHOA
	JOIN inserted ON HANGHOA.ma_hang_hoa=inserted.ma_hang_hoa
END
-- select * from HANGHOA
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (1, 10, 5);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (1, 13, 6);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (1, 2, 9);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (2, 14, 6);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (2, 7, 1);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (3, 16, 2);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (3, 5, 8);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (3, 10, 1);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (4, 14, 9);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (4, 11, 8);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (4, 12, 9);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (5, 19, 4);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (6, 5, 7);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (6, 7, 9);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (6, 11, 1);

insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 9, 6);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 17, 7);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 11, 5);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 5, 8);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 10, 3);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 18, 8);
insert into CHITIETHOADON (ma_hd, ma_hang_hoa, so_luong) values (7, 20, 2);

-- NHẬP HÓA ĐƠN
--
DROP TABLE IF EXISTS NHAPHOADON;
create TABLE NHAPHOADON (
	id int primary key IDENTITY(1,1),
	ma_hang_hoa nvarchar(50),
	ten_hang_hoa nvarchar(50),
	so_luong float,
	don_gia float,
	thanh_tien float
)
create trigger trg_TinhThanhTienMoiSanPhamHD on NHAPHOADON AFTER INSERT AS
BEGIN
	UPDATE NHAPHOADON
	SET thanh_tien = NHAPHOADON.so_luong * NHAPHOADON.don_gia
	FROM NHAPHOADON
END
insert into NHAPHOADON(ma_hang_hoa, ten_hang_hoa, so_luong, don_gia) values (2, (select ten_hang_hoa from HANGHOA WHERE ma_hang_hoa=2), 3,  (select don_gia from HANGHOA WHERE ma_hang_hoa=2))
select * from NHAPHOADON
--

create table NHAPHANGHOA (
	id int primary key identity(1,1),
	ma_hang_hoa INT,
	ngay_nhap DATE,
	so_luong_nhap INT
	foreign key (ma_hang_hoa) REFERENCES HANGHOA(ma_hang_hoa)
);
-- trigger nhập hàng hóa -> số lượng tồn kho trong HANGHOA
create trigger trg_CapNhatSoLuongSauKhiNhap on NHAPHANGHOA AFTER INSERT AS
BEGIN
	UPDATE HANGHOA
	SET so_luong_ton_kho = so_luong_ton_kho + (
		select so_luong_nhap
		from inserted
		where ma_hang_hoa=HANGHOA.ma_hang_hoa
	)
	FROM HANGHOA
	JOIN inserted ON HANGHOA.ma_hang_hoa=inserted.ma_hang_hoa
END
--select * from HANGHOA
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (1, '3/4/2022', 86);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (2, '3/3/2022', 663);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (3, '4/24/2022', 39);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (4, '2/15/2022', 787);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (5, '12/22/2021', 90);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (6, '1/31/2022', 86);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (7, '5/3/2022', 683);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (8, '11/15/2021', 68);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (9, '10/23/2021', 922);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (10, '9/21/2021', 6);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (11, '10/1/2021', 22);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (12, '9/20/2021', 234);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (13, '6/1/2022', 78);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (14, '3/29/2022', 355);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (15, '9/9/2021', 31);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (16, '8/20/2021', 334);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (17, '10/26/2021', 9);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (18, '1/30/2022', 96);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (19, '10/4/2021', 617);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (20, '2/7/2022', 381);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (21, '5/19/2022', 43);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (22, '9/7/2021', 24);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (23, '12/13/2021', 71);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (25, '3/17/2022', 12);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (26, '2/15/2022', 55);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (27, '1/29/2022', 187);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (28, '6/3/2022', 89);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (29, '5/26/2022', 916);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (30, '1/6/2022', 613);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (31, '5/11/2022', 90);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (32, '4/15/2022', 1010);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (33, '4/19/2022', 446);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (34, '1/21/2022', 23);
insert into NHAPHANGHOA (ma_hang_hoa, ngay_nhap, so_luong_nhap) values (35, '4/16/2022', 827);


create table CHAMCONG (
	ma_cc int primary key identity(1,1),
	ma_nv INT,
	thang INT,
	tong_so_gio float,
	hs_luong float,
	tien_luong float,
	FOREIGN KEY (ma_nv) REFERENCES NHANVIEN(ma_nv)
);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (1, 12, 89, 2.34);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (2, 12, 57, 1.9);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (3, 3, 117, 2.5);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (4, 8, 117, 2.37);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (5, 1, 73, 1.93);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (6, 12, 45, 1.67);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (7, 6, 59, 2.46);
insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (8, 6, 59, 3);


--FORM
-- form đăng nhập Hoang
-- form thêm, sửa, xóa
--			/khách hàng,
--			/nhân viên, 
--			/hàng hóa,		 Hoang
--			/quầy
--			/hàng tồn kho (thêm, sửa, xóa sản phẩm)
-- form lập hóa đơn + bên dưới là các trường thêm, xóa các sản phẩm
--		/khi lập hóa đơn, nhân viên chọn nhập mã KH (nếu có), ko thì sẽ mặc định ma_kh của HOADON là null
--		/tổng tiền KH mua sẽ chính là số điểm cộng thêm vào trong bảng Loại KH, đồng thời truy vấn theo đó in ra LKH
--		/ đồng thời, số lương mặt hàng mà KH mua sẽ bị trừ vào trong so_luong_ton_kho
-- form chấm công, thanh toán lương

--REPORT
-- report với CHITIETHOADON
-- report bảng lương NV - tính tổng lương nhân viên (tạo view) 

--tạo view hóa đơn
CREATE view v_chi_tiet_hoa_don AS (
SELECT HOADON.ma_hd, HOADON.ngay_lap_hd, HOADON.ma_nv, HOADON.ma_quay,
HANGHOA.ten_hang_hoa ,CHITIETHOADON.so_luong,
HANGHOA.don_gia, CHITIETHOADON.so_luong*HANGHOA.don_gia as thanh_tien 
FROM HOADON,HANGHOA, CHITIETHOADON
Where HOADON.ma_hd= CHITIETHOADON.ma_hd and
CHITIETHOADON.ma_hang_hoa=HANGHOA.ma_hang_hoa);

select * from v_chi_tiet_hoa_don

create view v_tong_tien_hoa_don as (
	select ma_hd, SUM(thanh_tien) as tong_tien
	from v_chi_tiet_hoa_don
	group by ma_hd
);

SELECT * FROM v_tong_tien_hoa_don;

--tạo view lương
CREATE view v_tonghopluong AS (
SELECT NHANVIEN.ma_nv, NHANVIEN.ho_ten, NHANVIEN.SDT,
	   CHAMCONG.ma_cc, CHAMCONG.hs_luong, CHAMCONG.thang, CHAMCONG.tong_so_gio, hs_luong*tong_so_gio*23000 as tien_luong
FROM  NHANVIEN, CHAMCONG
Where NHANVIEN.ma_nv = CHAMCONG.ma_nv);  --Chỉnh lại

select *from v_tonghopluong

--drop view v_tonghopluong
-- select cccd from KHACHHANG WHERE ma_kh = ' 2 ' 