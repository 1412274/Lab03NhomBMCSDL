﻿/*----------------------------------------------------------
MASV:1412053-1412430-1412544
HO TEN CAC THANH VIEN NHOM:
	1412053	Nguyễn Huyền Quý Châu
	1412430 Nguyễn Vũ Quang
	1412544	Phạm Đức Tiên
LAB: 03 - NHOM
NGAY:31-05-2017
----------------------------------------------------------*/
use QLSVNhom
/*CAC CAU LENH TAO TABLE*/
create table SINHVIEN (
	MASV NVARCHAR(20) PRIMARY KEY,
	HOTEN nVARCHAR(100) not null,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL	
)

CREATE TABLE NHANVIEN(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
	PUBKEY VARCHAR(20) /*Ten khoa cong khai*/
)

CREATE TABLE LOP(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20)
)

CREATE TABLE HOCPHAN (
	MAHP VARCHAR(20) PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
)

CREATE TABLE BANGDIEM (
	MASV VARCHAR(20),
	MAHP VARCHAR(20),
	DIEMTHI VARBINARY(MAX),
	PRIMARY KEY(MASV,MAHP)
)