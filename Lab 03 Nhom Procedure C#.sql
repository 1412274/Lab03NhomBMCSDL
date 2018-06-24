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

-----------------------------Bảng SINHVIEN-----------------------------
--Thêm sinh viên
CREATE PROCEDURE SP_INS_SINHVIEN @MASV VARCHAR(20), 
								 @HOTEN NVARCHAR(100), 
								 @NGAYSINH DATETIME, 
								 @DIACHI NVARCHAR(200), 
								 @MALOP VARCHAR(20), 
								 @TENDN NVARCHAR(100), 
								 @MATKHAU VARCHAR(100)
AS
BEGIN
	INSERT INTO SINHVIEN VALUES(@MASV, @HOTEN, @NGAYSINH, @DIACHI, @MALOP, @TENDN, HASHBYTES('MD5', @MATKHAU))
END
GO

DROP PROCEDURE SP_INS_SINHVIEN
GO

SELECT * FROM SINHVIEN
GO

DELETE FROM SINHVIEN
GO

--Load danh sách sinh viên
CREATE PROCEDURE SP_DSSV @MALOP VARCHAR(20)
AS
BEGIN
	SELECT MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN, CONVERT(VARCHAR(2048), MATKHAU) AS MATKHAU 
	FROM SINHVIEN
	WHERE MALOP = @MALOP
END
GO

DROP PROCEDURE SP_DSSV
GO

--Cập nhật sinh viên
CREATE PROCEDURE SP_UPDATE_SV @MASV VARCHAR(20), 
							  @HOTEN NVARCHAR(100),
							  @NGAYSINH DATETIME,
							  @DIACHI NVARCHAR(200),
							  @TENDN NVARCHAR(100),
							  @MATKHAU VARCHAR(100)
AS
BEGIN
	DECLARE @MATKHAU_MAHOA VARBINARY(2048), @MATKHAU_TEMP VARBINARY(2048)
	IF (@HOTEN = '')
		SELECT @HOTEN = HOTEN FROM SINHVIEN WHERE MASV = @MASV
	IF (@NGAYSINH = '')
		SELECT @NGAYSINH = NGAYSINH FROM SINHVIEN WHERE MASV = @MASV
	IF (@DIACHI = '')
		SELECT @DIACHI = DIACHI FROM SINHVIEN WHERE MASV = @MASV
	IF (@TENDN = '')
		SELECT @TENDN = TENDN FROM SINHVIEN WHERE MASV = @MASV
	
	IF (@MATKHAU = '')
		SELECT @MATKHAU_MAHOA = MATKHAU FROM SINHVIEN WHERE MASV = @MASV
	ELSE
	BEGIN
		IF (@MATKHAU != '')
		BEGIN
			SELECT @MATKHAU_TEMP = MATKHAU FROM SINHVIEN WHERE MASV = @MASV
			IF (CONVERT(VARCHAR(2048), @MATKHAU_TEMP) = @MATKHAU)
				SELECT @MATKHAU_MAHOA = MATKHAU FROM SINHVIEN WHERE MASV = @MASV
			ELSE
				SET @MATKHAU_MAHOA = HASHBYTES('MD5', @MATKHAU)
		END
	END

	UPDATE SINHVIEN SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, TENDN = @TENDN, MATKHAU = @MATKHAU_MAHOA
	WHERE MASV = @MASV

END
GO

DROP PROCEDURE SP_UPDATE_SV
GO

--Xóa sinh viên
CREATE PROCEDURE SP_DELETE_SV @MASV VARCHAR(20)
AS
BEGIN
	DELETE FROM SINHVIEN WHERE MASV = @MASV
END
GO

DROP PROCEDURE SP_DELETE_SV
GO

--Lấy mã SV lớn nhất
CREATE PROCEDURE SP_MAX_MASV @MASV VARCHAR(20) OUT
AS
BEGIN
	SELECT @MASV = MAX(MASV)
	FROM SINHVIEN
END
GO

DROP PROCEDURE SP_MAX_MASV
GO
-----------------------------------------------------------------------

-----------------------------Bảng BANGDIEM-----------------------------
CREATE PROCEDURE SP_INS_BANGDIEM @MASV VARCHAR(20), 
								@MAHP VARCHAR(20), 
								@DIEMTHI FLOAT, 
								@PUBKEY VARCHAR(20), 
								@KQ INT OUT
AS
BEGIN
	INSERT INTO BANGDIEM VALUES(@MASV, @MAHP, EncryptByAsymKey(ASYMKEY_ID(@PUBKEY), CONVERT(VARCHAR, @DIEMTHI)))

	IF @@ERROR <> 0
		SET @KQ = 1
	ELSE
		SET @KQ = 0
END
GO

CREATE PROCEDURE SP_SEL_BANGDIEM @MASV VARCHAR(20), 
								@MK NVARCHAR(100),
								@PUBKEY VARCHAR(20)
AS
BEGIN
	SELECT MASV, MAHP, CONVERT(VARCHAR, DECRYPTBYASYMKEY(ASYMKEY_ID(@PUBKEY), BD.DIEMTHI, @MK)) as DIEMTHI
	FROM BANGDIEM BD
	WHERE MASV = @MASV
END
GO

CREATE PROCEDURE SP_SEL_HOCPHAN
AS
BEGIN
	SELECT * FROM HOCPHAN
END
GO
-----------------------------------------------------------------------

--Thêm dữ liệu vào CSDL
EXEC SP_INS_PUBLIC_NHANVIEN 'NV03', 'HO THI THANH TUYEN', 'httt@gmail.com', 3000000, 'HTTT', 'abcd123'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV04', 'TUAN NGUYEN HOAI DUC', 'tnhd@gmail.com', 10000000, 'TNHD', 'abcd123'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV05', 'PHAM MINH TU', 'pmt@gmail.com', 6000000, 'PMT', 'abcd123'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV06', 'LE THI NHAN', 'ltn@gmail.com', 6000000, 'LTN', 'abcd123'
SELECT * FROM NHANVIEN
GO

EXEC SP_INS_SINHVIEN 'SV01', 'NGUYEN HOANG KIM', '1/1/1990', '280 AN DUONG VUONG', '14CTT1', 'nhkim', '123456' 
EXEC SP_INS_SINHVIEN 'SV02', 'PHAN KHANH LAM', '1/1/1990', '450 AU CO', '14CTT1', 'pklam', '123456'
EXEC SP_INS_SINHVIEN 'SV03', 'NGUYEN HOANG LAN', '1/1/1990', '280 AN DUONG VUONG', '14CTT2', 'nhlan', 'pass123'
EXEC SP_INS_SINHVIEN 'SV04', 'VUONG THIEN PHU', '1/1/1990', '450 AU CO', '14CTT2', 'vtphu', 'pass123'
EXEC SP_INS_SINHVIEN 'SV05', 'DANG NHAT MINH', '1/1/1990', '280 AN DUONG VUONG', '14CTT3', 'dnminh', 'pass123'
EXEC SP_INS_SINHVIEN 'SV06', 'HUYNH CONG LOI', '1/1/1990', '450 AU CO', '14CTT3', 'hcloi', 'pass123'
SELECT * FROM SINHVIEN
GO

INSERT INTO HOCPHAN VALUES('HP01', N'Cơ sở dữ liệu', 4)
INSERT INTO HOCPHAN VALUES('HP02', N'Cơ sở dữ liệu nâng cao', 4)
INSERT INTO HOCPHAN VALUES('HP03', N'Bảo mật cơ sở dữ liệu', 4)
INSERT INTO HOCPHAN VALUES('HP04', N'Tương tác người - máy', 4)
INSERT INTO HOCPHAN VALUES('HP05', N'Phân tích thiết kế HTTT', 4)
INSERT INTO HOCPHAN VALUES('HP06', N'Hệ quản trị CSDL', 4)
INSERT INTO HOCPHAN VALUES('HP07', N'Phát triển ứng dụng HTTT hiện đại', 4)
SELECT * FROM HOCPHAN
GO

INSERT INTO LOP VALUES('14CTT1', N'Lớp hệ chính quy 1', 'NV01')
INSERT INTO LOP VALUES('14CTT2', N'Lớp hệ chính quy 2', 'NV02')
INSERT INTO LOP VALUES('14CTT3', N'Lớp hệ chính quy 3', 'NV03')
INSERT INTO LOP VALUES('14CNTN', N'Lớp cử nhân tài năng', 'NV04')
SELECT * FROM LOP
GO

