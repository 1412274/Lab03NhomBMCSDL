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

--CAU LENH TAO STORED PROCEDURE
--i) Stored dùng để thêm mới dữ liệu (Insert) vào table NHANVIEN, trong đó
--• Thuộc tính MATKHAU được mã hóa (HASH) sử dụng SHA1
--• Thuộc tính LUONG sẽ được mã hóa từ tham số LUONGCB sử dụng thuật toán RSA
--512, với khóa bí mật là tham số MK được truyền vào.
--• Thuộc tính PUBKEY sẽ lưu trữ tên khóa công khai được tạo ra ứng với nhân viên
--này, giá trị này sẽ = với mã nhân viên.
CREATE PROCEDURE SP_INS_PUBLIC_NHANVIEN @MANV VARCHAR(20),
										@HOTEN NVARCHAR(100),
										@EMAIL VARCHAR(20),
										@LUONGCB INT,
										@TENDN NVARCHAR(100),
										@MK VARCHAR(100)
AS
BEGIN
	--Phần tạo key
	DECLARE @STR NVARCHAR(3000), @AsymID INT
	SET @STR = 'CREATE ASYMMETRIC KEY ' + @MANV + ' WITH ALGORITHM = RSA_512 ENCRYPTION BY PASSWORD = ''' + @MK + ''''
	EXEC (@STR)
	SET @AsymID = ASYMKEY_ID(@MANV)

	INSERT INTO NHANVIEN VALUES(@MANV, @HOTEN, @EMAIL, ENCRYPTBYASYMKEY(@AsymID, CONVERT(VARCHAR, @LUONGCB)), @TENDN, HASHBYTES('SHA1', @MK), @MANV)
END
GO

select * from NHANVIEN

DROP ASYMMETRIC KEY NV01
DROP ASYMMETRIC KEY NV02
GO

DROP PROCEDURE SP_INS_PUBLIC_NHANVIEN
GO

EXEC SP_INS_PUBLIC_NHANVIEN 'NV01', 'NGUYEN VAN A', 'nva@gmail.com', 3000000, 'NVA', '123456'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV02', 'NGUYEN VAN B', 'nvb@gmail.com', 2000000, 'NVB', '1234567'
GO

SELECT * FROM NHANVIEN
GO

DELETE FROM NHANVIEN WHERE MANV = 'NV01'
DELETE FROM NHANVIEN WHERE MANV = 'NV02'
GO

--ii) Stored dùng để truy vấn dữ liệu nhân viên (NHANVIEN)
CREATE PROCEDURE SP_SEL_PUBLIC_NHANVIEN @TENDN NVARCHAR(100), --TENDN ở đây xét vào là MANV chứ không phải cột TENDN
										@MK NVARCHAR(100) --Để NVARCHAR mới có thể bỏ vào hàm DECRYPTBYASYMKEY
AS
BEGIN
	DECLARE @AsymID INT, @LUONG VARBINARY(2048)
	SET @LUONG = (SELECT LUONG FROM NHANVIEN WHERE MANV = @TENDN)
	SET @AsymID = ASYMKEY_ID(@TENDN)

	SELECT MANV, HOTEN, EMAIL, CONVERT(VARCHAR, DECRYPTBYASYMKEY(@AsymID, @LUONG, @MK)) as LUONGCB
	FROM NHANVIEN
	WHERE MANV = @TENDN
END
GO

DROP PROCEDURE SP_SEL_PUBLIC_NHANVIEN
GO

EXEC SP_SEL_PUBLIC_NHANVIEN 'NV01', '123456'
EXEC SP_SEL_PUBLIC_NHANVIEN 'NV02', '1234567'
GO