USE ResortDB 
GO

-- Nhân viên --
IF (OBJECT_ID(N'uspThemNhanVien', 'p') IS NOT NULL)
	DROP PROC uspThemNhanVien
GO
CREATE PROC uspThemNhanVien
				@IDNhanVien int out
				,@Pass nchar(30)
				,@Ho nvarchar(30)
				,@Ten nvarchar(10)
				,@GioiTinh bit
				,@NgaySinh smalldatetime
				,@DiaChi nvarchar(100)
				,@CMND int
				,@SDT nchar(12)
				,@BangCap nvarchar(30)
				,@ChucVu nvarchar(15)
				,@HinhAnh image
				,@TrangThai bit
AS
BEGIN
	IF EXISTS(SELECT * FROM NhanVien WHERE CMND = @CMND)
		UPDATE NhanVien SET Pass = @Pass, DiaChi = @DiaChi, SDT = @SDT, BangCap = @BangCap, ChucVu = @ChucVu, TrangThai = 1
			WHERE CMND = @CMND
	ELSE IF EXISTS (SELECT * FROM NhanVien WHERE IDNhanVien = @IDNhanVien)
		RAISERROR (N'Nhân viên đã tồn tại!', 16, 1);
	ELSE
		BEGIN
			INSERT INTO NhanVien(Pass, Ho, Ten, GioiTinh, NgaySinh, DiaChi, CMND, SDT, BangCap, ChucVu, HinhAnh, TrangThai)
				VALUES(@Pass, @Ho, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @CMND, @SDT, @BangCap, @ChucVu, @HinhAnh, @TrangThai)
			SET @IDNhanVien = (SELECT SCOPE_IDENTITY())
		END
END
GO

IF (OBJECT_ID(N'uspSuaNhanVien', 'p') IS NOT NULL)
	DROP PROC uspSuaNhanVien
GO
CREATE PROC uspSuaNhanVien
				@IDNhanVien int out
				,@Pass nchar(30)
				,@Ho nvarchar(30)
				,@Ten nvarchar(10)
				,@GioiTinh bit
				,@NgaySinh smalldatetime
				,@DiaChi nvarchar(100)
				,@CMND int
				,@SDT nchar(12)
				,@BangCap nvarchar(30)
				,@ChucVu nvarchar(15)
				,@HinhAnh image
				,@TrangThai bit
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM NhanVien WHERE IDNhanVien = @IDNhanVien)
		RAISERROR (N'Không tìm thấy nhân viên cần cập nhật!', 16, 1);
	ELSE
		UPDATE NhanVien SET Pass = @Pass, Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi,
			CMND = @CMND, SDT = @SDT, BangCap = @BangCap, ChucVu = @ChucVu, HinhAnh = @HinhAnh, TrangThai = 1
			WHERE IDNhanVien = @IDNhanVien
END
GO

IF (OBJECT_ID(N'uspXoaNhanVien', 'p') IS NOT NULL)
	DROP PROC uspXoaNhanVien
GO
CREATE PROC uspXoaNhanVien
				@IDNhanVien int out
				,@Pass nchar(30)
				,@Ho nvarchar(30)
				,@Ten nvarchar(10)
				,@GioiTinh bit
				,@NgaySinh smalldatetime
				,@DiaChi nvarchar(100)
				,@CMND int
				,@SDT nchar(12)
				,@BangCap nvarchar(30)
				,@ChucVu nvarchar(15)
				,@TrangThai bit
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM NhanVien WHERE IDNhanVien = @IDNhanVien)
		RAISERROR (N'Không tìm thấy nhân viên cần xóa!', 16, 1);
	ELSE
		UPDATE NhanVien SET TrangThai = 0
			WHERE IDNhanVien = @IDNhanVien
END
GO

-- Chi tiết đặt phòng --

-- Thêm ChiTietDatPhong--
IF (OBJECT_ID(N'uspThemChiTietDatPhong', 'p') IS NOT NULL)
	DROP PROC uspThemChiTietDatPhong
GO
CREATE PROC uspThemChiTietDatPhong
				@IDDatPhong int
				,@IDPhong int
				,@NgayNhan smalldatetime
				,@NgayTra smalldatetime
				,@ThanhTien money
				,@GiamGia real
AS
	IF EXISTS(SELECT * FROM ChiTietDatPhong WHERE IDDatPhong = @IDDatPhong AND IDPhong = @IDPhong)
		RAISERROR (N'Chi tiết đặt phòng đã tồn tại!', 16, 1)
	ELSE
		INSERT INTO ChiTietDatPhong VALUES(@IDDatPhong, @IDPhong, @NgayNhan, @NgayTra, @ThanhTien, @GiamGia)
GO

--Sửa ChiTietDatPhong--
IF (OBJECT_ID(N'uspSuaChiTietDatPhong', 'p') IS NOT NULL)
	DROP PROC uspSuaChiTietDatPhong
GO
CREATE PROC uspSuaChiTietDatPhong
				@IDDatPhong int
				,@IDPhong int
				,@NgayNhan smalldatetime
				,@NgayTra smalldatetime
				,@ThanhTien money
				,@GiamGia real
AS
	IF NOT EXISTS(SELECT * FROM ChiTietDatPhong WHERE IDDatPhong = @IDDatPhong AND IDPhong = IDPhong)
		RAISERROR (N'Không tìm thấy chi tiết đặt phòng cần cập nhật!', 16, 1)
	ELSE
		UPDATE ChiTietDatPhong SET NgayNhan = @NgayNhan, NgayTra = @NgayTra, ThanhTien = @ThanhTien, GiamGia = @GiamGia
GO

-- Xóa ChiTietDatPhong--
IF (OBJECT_ID(N'uspXoaChiTietDatPhong', 'p') IS NOT NULL)
	DROP PROC uspXoaChiTietDatPhong
GO
CREATE PROC uspXoaChiTietDatPhong
				@IDDatPhong int
AS
	IF NOT EXISTS(SELECT * FROM ChiTietDatPhong WHERE IDDatPhong = @IDDatPhong)
		RAISERROR (N'Không tìm thấy chi tiết đặt phòng cần xóa!', 16, 1)
	ELSE
		DELETE FROM ChiTietDatPhong WHERE IDDatPhong = @IDDatPhong
GO

--Hình ảnh--

--Thêm HinhAnh
IF (OBJECT_ID(N'uspThemHinhAnh', 'p') IS NOT NULL)
	DROP PROC uspThemHinhAnh
GO
CREATE PROC uspThemHinhAnh
				@IDHinhAnh int out
				,@Ten nvarchar(50)
				,@HinhAnh image
				,@IDLoaiPhong int
AS
BEGIN
	IF EXISTS (SELECT * FROM HinhAnh WHERE IDHinhAnh = @IDHinhAnh)
		RAISERROR (N'IDHinhAnh đã tồn tại!', 16, 1);
	ELSE
		BEGIN
			INSERT INTO HinhAnh(Ten, HinhAnh, IDLoaiPhong)
				VALUES(@Ten, @HinhAnh, @IDLoaiPhong)
			SET @IDHinhAnh = (SELECT SCOPE_IDENTITY())
		END
END
GO

IF (OBJECT_ID(N'uspSuaHinhAnh', 'p') IS NOT NULL)
	DROP PROC uspSuaHinhAnh
GO
CREATE PROC uspSuaHinhAnh
				@IDHinhAnh int out
				,@Ten nvarchar(50)
				,@HinhAnh image
				,@IDLoaiPhong int
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM HinhAnh WHERE IDHinhAnh = @IDHinhAnh)
		RAISERROR (N'Không tìm thấy hình ảnh cần cập nhật!', 16, 1);
	ELSE
		UPDATE HinhAnh SET Ten = @Ten, HinhAnh = @HinhAnh, IDLoaiPhong = @IDLoaiPhong
			WHERE IDHinhAnh = @IDHinhAnh
END
GO

IF (OBJECT_ID(N'uspXoaHinhAnh', 'p') IS NOT NULL)
	DROP PROC uspXoaHinhAnh
GO
CREATE PROC uspXoaHinhAnh
				@IDHinhAnh int
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM HinhAnh WHERE IDHinhAnh = @IDHinhAnh)
		RAISERROR (N'Không tìm thấy hình ảnh cần xóa!', 16, 1);
	ELSE
		DELETE HinhAnh WHERE IDHinhAnh = @IDHinhAnh
END
GO