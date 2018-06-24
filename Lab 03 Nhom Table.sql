﻿/*----------------------------------------------------------
MASV: 1412274, 1412282, 1412414
HO TEN CAC THANH VIEN NHOM:
	1412274 - Nguyen Hoang Kim
	1412282 - Nguyen Hoang Lan
	1412414 - Vuong Thien Phu
LAB: 03 - NHOM
NGAY: 12/06/2018
----------------------------------------------------------*/
USE QLSVN
GO

--CAC CAU LENH TAO TABLE
CREATE TABLE SINHVIEN
(
	MASV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL, 
	MATKHAU VARBINARY(2048) NOT NULL
)
GO

CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(2048),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(2048) NOT NULL,
	PUBKEY VARCHAR(20)
)
GO

CREATE TABLE LOP
(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20)		
)
GO

CREATE TABLE HOCPHAN
(
	MAHP VARCHAR(20) PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
)
GO

CREATE TABLE BANGDIEM
(
	MASV VARCHAR(20),
	MAHP VARCHAR(20),
	DIEMTHI VARBINARY(2048),
	PRIMARY KEY(MASV, MAHP)
)
GO