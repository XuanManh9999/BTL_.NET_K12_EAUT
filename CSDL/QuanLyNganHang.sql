﻿CREATE DATABASE QuanLyNganHang
USE QuanLyNganHang 

-- KHACHHANG
CREATE TABLE KHACHHANG (
	MaKH NVARCHAR(20) NOT NULL PRIMARY KEY,
	TenKH NVARCHAR(50),
	CMND NVARCHAR(20) NOT NULL UNIQUE,
	NgaySinh CHAR(25),
	GioiTinh NVARCHAR(5),
	DiaChi NVARCHAR(50),
	SDT VARCHAR(15)
)
-- begin

						-- Hiển thị khách hàng
						CREATE PROCEDURE dbo.HienThiKH
						AS
						BEGIN
							SELECT * FROM KHACHHANG
						END

				-- Thêm khách hàng
				CREATE PROCEDURE dbo.ThemKH
					@MaKH NVARCHAR(20),
					@TenKH NVARCHAR(50),
					@CMND NVARCHAR(20),
					@NgaySinh CHAR(25),
					@GioiTinh NVARCHAR(5),
					@DiaChi NVARCHAR(50),
					@SDT VARCHAR(15)
				AS
				BEGIN 
					INSERT INTO KhachHang VALUES (@MaKH, @TenKH, @CMND, @NgaySinh, @GioiTinh, @DiaChi, @SDT)
				END

				-- Sửa khách hàng
				CREATE PROCEDURE dbo.SuaKH
					@MaKH NVARCHAR(20),
					@TenKH NVARCHAR(50),
					@CMND NVARCHAR(20),
					@NgaySinh CHAR(25),
					@GioiTinh NVARCHAR(5),
					@DiaChi NVARCHAR(50),
					@SDT VARCHAR(15)
				AS
				BEGIN 
					UPDATE KhachHang SET TenKH = @TenKH, CMND = @CMND, NgaySinh = @NgaySinh, 
					GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaKH = @MaKH
				END


				-- Xoá khách hàng
				CREATE PROCEDURE dbo.XoaKH
					@MaKH NVARCHAR(20),
					@TenKH NVARCHAR(50),
					@CMND NVARCHAR(20),
					@NgaySinh CHAR(25),
					@GioiTinh NVARCHAR(5),
					@DiaChi NVARCHAR(50),
					@SDT VARCHAR(15)
				AS
				BEGIN 
					DELETE KHACHHANG WHERE MaKH = @MaKH
				END

							-- Tìm kiếm KHACHHANG theo MaKH
							CREATE PROCEDURE dbo.TimKiemKH_MaKH
								@MaKH NVARCHAR(20)
							AS
							BEGIN
								SELECT * FROM KHACHHANG WHERE MaKH = @MaKH
							END

							-- Tìm kiếm KHACHHANG theo TenKH
							CREATE PROCEDURE dbo.TimKiemKH_TenKH
								@TenKH NVARCHAR(50)
							AS
							BEGIN
								SELECT * FROM KHACHHANG WHERE TenKH = @TenKH
							END


							-- kiểm tra xem mã kh đã tồn tại hay chưa
							CREATE PROCEDURE dbo.Check_MaKH
								@MaKH NVARCHAR(20)
							AS
							BEGIN
								SELECT MaKH FROM KhachHang WHERE MaKH = @MaKH
							END


					-- Thêm thông tin tài khoản
					CREATE PROCEDURE dbo.ThemTTTK
						@SoTK NVARCHAR(20),
						@SoDu FLOAT,
						@NgayCap VARCHAR(20),
						@TenCN NVARCHAR(50),
						@LoaiTK NVARCHAR(20),
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						INSERT INTO ThongTinTaiKhoan VALUES (@SoTK, @SoDu, @NgayCap, @TenCN, @LoaiTK, @MaKH)
					END

					-- Xóa thông tin tài khoản
					CREATE PROCEDURE dbo.XoaTTTK
						@SoTK NVARCHAR(20)
					AS
					BEGIN
						DELETE ThongTinTaiKhoan WHERE SoTK = @SoTK
					END


					-- Xóa thông tin tài khoản khi dùng chức năng xóa KH ở form QLKH
					CREATE PROCEDURE dbo.XoaTTTK_QLKH
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						DELETE ThongTinTaiKhoan WHERE MaKH = @MaKH
					END


				-- Lấy soTk để check xem khách hàng đã có thông tin tài khoản hay chưa
					CREATE PROCEDURE dbo.LaySoTK
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						SELECT SoTK FROM THONGTINTAIKHOAN WHERE MaKH = @MaKH
					END


					-- Cộng tiền cho khách hàng nhận tiền
					CREATE PROCEDURE dbo.CongTien
						@SoTienGD FLOAT,
						@SoTKNhan NVARCHAR(20)
					AS
					BEGIN
						UPDATE THONGTINTAIKHOAN SET SoDu += @SoTienGD WHERE SoTK = @SoTKNhan
					END


					-- Trừ tiền cho khách hàng nhận tiền
					CREATE PROCEDURE dbo.TruTien
						@SoTienGD FLOAT,
						@SoTKGui NVARCHAR(20)
					AS
					BEGIN
						UPDATE THONGTINTAIKHOAN SET SoDu -= @SoTienGD WHERE SoTK = @SoTKGui
					END


					-- Lấy MaTK để kiểm tra mã tk đã tồn tại chưa
					CREATE PROCEDURE dbo.LayMaTK
						@MaTK NVARCHAR(20)
					AS 
					BEGIN
						SELECT MaTK FROM TaiKhoanDangNhap WHERE MaTK = @MaTK
					END

-- Lấy MaTK


					-- Thêm tài khoản đăng nhập
					CREATE PROCEDURE dbo.ThemTKDN
						@MaTK NVARCHAR(20),
						@TenTK NVARCHAR(50),
						@MK NVARCHAR(50),
						@Email VARCHAR(50),
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						INSERT INTO TaiKhoanDangNhap VALUES (@MaTK, @TenTK, @MK, @Email, @MaKH)
					END

					-- Xóa tài khoản đăng nhập
					CREATE PROCEDURE dbo.XoaTKDN
						@MaTK NVARCHAR(20)
					AS
					BEGIN
						DELETE TaiKhoanDangNhap WHERE MaTK = @MaTK
					END

					-- Xóa tài khoản đăng nhập khi dùng chức năng xóa KH ở form QLKH
					CREATE PROCEDURE dbo.XoaTKDN_QLKH
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						DELETE TaiKhoanDangNhap WHERE MaKH = @MaKH
					END

				-- Lấy MaTK để check xem khách hàng đã có tài đăng nhập hay chưa
				CREATE PROCEDURE dbo.LayMaTK_QLKH
					@MaKH NVARCHAR(20)
				AS
				BEGIN
					SELECT MaTK FROM TAIKHOANDANGNHAP WHERE MaKH = @MaKH
				END



				-- Lấy dữ liệu để kiểm tra thông tin khi khách hàng đăng nhập
				CREATE PROCEDURE dbo.dangNhapTK
					@TenTK NVARCHAR(50),
					@MK NVARCHAR(50)
				AS
				BEGIN
					SELECT * FROM TaiKhoanDangNhap WHERE TenTK = @TenTK and MK = @MK
				END


				-- Lấy lại mk cho khách hàng
				CREATE PROCEDURE dbo.quenMK
					@Email VARCHAR(50)
				AS
				BEGIN
					SELECT MK FROM TaiKhoanDangNhap where Email = @Email
				END

								-- Lấy dữ liệu MaGD
								CREATE PROCEDURE dbo.LayMaGD
								AS
								BEGIN
									SELECT MaGD FROM GIAODICH
								END

			-- Thêm dữ liệu vào bảng GiaoDich
			CREATE PROCEDURE dbo.ThemGD
				@MaGD NVARCHAR(20),
				@SoTienGD FLOAT,
				@NoiDungGD NVARCHAR(50),
				@ThoiGianGD NVARCHAR(20),
				@SoTKNhan NVARCHAR(20),
				@SoTKGui NVARCHAR(20)
			AS
			BEGIN
				INSERT INTO GIAODICH VALUES (@MaGD, @SoTienGD, @NoiDungGD, @ThoiGianGD, @SoTKNhan, @SoTKGui)
			END


			-- Check khách hàng đã giao dịch hay chưa
			CREATE PROCEDURE dbo.Check_GiaoDich
				@MaKH NVARCHAR(20)
			AS
			BEGIN
				SELECT MaGD FROM THONGTINTAIKHOAN AS TK, KHACHHANG AS K, GIAODICH AS G 
				WHERE G.SoTKNhan = TK.SoTK AND TK.MaKH = K.MaKH AND K.MaKH = @MaKH
			END

		-- Xóa giao dịch khi xóa khách hàng ở form QLKH
		CREATE PROCEDURE dbo.XoaGiaoDich_QLKH
			@MaKH NVARCHAR(20)
		AS
		BEGIN
			DELETE GIAODICH WHERE MaGD IN (SELECT MaGD FROM THONGTINTAIKHOAN AS TK,
			KHACHHANG AS K, GIAODICH AS G
			WHERE G.SoTKNhan = TK.SoTK AND TK.MaKH = K.MaKH AND K.MaKH = @MaKH)
		END

		-- Xem chi tiết giao dịch
		CREATE PROCEDURE dbo.XemCTGD
			@MaKH NVARCHAR(20)
		AS
		BEGIN
			select DISTINCT GIAODICH.MaGD, KHACHHANG.TenKH, GIAODICH.SoTienGD,GIAODICH.NoiDungGD, 
			GIAODICH.SoTKNhan, GIAODICH.ThoiGianGD from GIAODICH, THONGTINTAIKHOAN, KHACHHANG where 
			GIAODICH.SoTKGui = THONGTINTAIKHOAN.SoTK and THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH and 
			KHACHHANG.MaKH = @MaKH
		END

					-- Lấy thông tin người chuyển
					CREATE PROCEDURE dbo.TienNhan
						@SoTKNhan NVARCHAR(20)
					AS
					BEGIN
						SELECT GIAODICH.MaGD, KHACHHANG.TenKH, GIAODICH.SoTienGD, GIAODICH.NoiDungGD, 
						GIAODICH.SoTKGui, GIAODICH.ThoiGianGD FROM GIAODICH INNER JOIN THONGTINTAIKHOAN
						ON GIAODICH.SoTKGui = THONGTINTAIKHOAN.SoTK INNER JOIN KHACHHANG ON 
						THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH WHERE GIAODICH.SoTKNhan = @SoTKNhan
					END



						-- Lấy mã tiết kiệm
						CREATE PROCEDURE dbo.Get_MaTietKiem
						AS
						BEGIN
							select MaTK from TIETKIEM
						END

				-- Thêm thông tin bảng tiết kiệm
				CREATE PROCEDURE dbo.ThemTietKiem
					@MaTietKiem NVARCHAR(20),
					@SoTienGui FLOAT,
					@NoiDungTK NVARCHAR(50),
					@NgayGuiTK NVARCHAR(20),
					@MaTK NVARCHAR(20)
				AS
				BEGIN
					INSERT INTO TIETKIEM VALUES (@MaTietKiem, @SoTienGui, @NoiDungTK, @NgayGuiTK, @MaTK)
				END

					-- check xem khách hàng có gửi tiết kiệm hay k
					CREATE PROCEDURE dbo.Check_TietKiem
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						SELECT TK.MaTK FROM TIETKIEM AS T, TAIKHOANDANGNHAP AS TK, KHACHHANG AS K
						WHERE T.MaTK = TK.MaTK AND TK.MaKH = K.MaKH AND K.MaKH = @MaKH
					END

				-- Xóa tiết kiệm khi xóa khách hàng ở form QLKH
				CREATE PROCEDURE dbo.XoaTietKiem_QLKH
					@MaKH NVARCHAR(20)
				AS
				BEGIN
					DELETE TIETKIEM WHERE MaTK IN (SELECT TK.MaTK FROM TIETKIEM AS T, 
					TAIKHOANDANGNHAP AS TK, KHACHHANG AS K
					WHERE T.MaTK = TK.MaTK AND TK.MaKH = K.MaKH AND K.MaKH = @MaKH)
				END



						-- Thêm QLKH
						CREATE PROCEDURE dbo.ThemQLKH
							@MaKH NVARCHAR(20),
							@MaQL NVARCHAR(20)
						AS
						BEGIN
							INSERT INTO QUANLYKHACHHANG VALUES (@MaKH, @MaQL)
						END

						-- Xóa QLKH
						CREATE PROCEDURE dbo.XoaQLKH
							@MaKH NVARCHAR(20),
							@MaQL NVARCHAR(20)
						AS
						BEGIN
							DELETE QUANLYKHACHHANG WHERE MaKH = @MaKH;
						END


-- Báo cáo thống kê

					-- Lấy thông tin người nhận
					CREATE PROCEDURE dbo.Get_TTNN
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						SELECT T.SoTK, K.TenKH FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T 
						WHERE G.SoTKNhan = T.SoTK AND K.MaKH = T.MaKH
						AND G.MaGD IN (SELECT G.MaGD FROM KHACHHANG AS K, GIAODICH AS G, 
						THONGTINTAIKHOAN AS T WHERE K.MaKH = T.MaKH AND G.SoTKGui = T.SoTK AND K.MaKH = @MaKH)
					END


					-- Lấy thông tin thống kê giao dịch tiền ra
					CREATE PROCEDURE dbo.GetGD_TienRa
						@MaKH NVARCHAR(20)
					AS
					BEGIN
						SELECT K.MaKH, TenKH, MaGD, SoTienGD, NoiDungGD, ThoiGianGD, SoTKNhan FROM 
						KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T
						WHERE K.MaKH = T.MaKH AND G.SoTKGui = T.SoTK AND K.MaKH = @MaKH
					END


			-- Lấy thông tin người gửi
			CREATE PROCEDURE dbo.Get_TTNG
				@MaKH NVARCHAR(20)
			AS
			BEGIN
				SELECT T.SoTK, K.TenKH FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T 
				WHERE G.SoTKGui = T.SoTK AND K.MaKH = T.MaKH
				AND G.MaGD IN (SELECT G.MaGD FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T 
				WHERE K.MaKH = T.MaKH AND G.SoTKNhan = T.SoTK AND K.MaKH = @MaKH)
			END

		-- Lấy thông tin thống kê giao dịch tiền vào
		CREATE PROCEDURE dbo.GetGD_TienVao
			@MaKH NVARCHAR(20)
		AS
		BEGIN
			SELECT K.MaKH, TenKH, MaGD, SoTienGD, NoiDungGD, ThoiGianGD, SoTKGui FROM 
			KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T
			WHERE K.MaKH = T.MaKH AND G.SoTKNhan = T.SoTK AND K.MaKH = @MaKH
		END

					--Get MaTK
					CREATE PROCEDURE dbo.GetMaTK
					@TenTK nvarchar(50), @MK varchar(50)
					as
					begin
						select MaTK from TAIKHOANDANGNHAP where TenTK = @TenTK and MK = @MK
					end


					--Get MaKH
					CREATE PROCEDURE dbo.Get_MaKH
					@TenTK nvarchar(50), @MK varchar(50)
					as
					begin
						select MaKH from TAIKHOANDANGNHAP where TenTK = @TenTK and MK = @MK
					end


					-- Hiện Thị Thông Tin Khách  Hàng
					CREATE PROC HIENTHITHONGTINKHACHHANG
					@MaKH varchar(20)
					AS
						BEGIN 
							SELECT * FROM KHACHHANG where KHACHHANG.MaKH = @MaKH
						END


		CREATE PROC CAPNHATTHONGTIN
		@MaKH varchar(20), @TenKH nvarchar(100), @CMND varchar(20), @NgaySinh varchar(20), 
		@GioiTinh nvarchar(20), @DiaChi nvarchar(100), @SDT varchar(20)
		as
		BEGIN
			UPDATE KHACHHANG SET TenKH = @TenKH, CMND = @CMND, NgaySinh = @NgaySinh, 
			GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaKH = @MaKH
		END
					
					--GET STK
						CREATE PROC dbo.GetSoTK 
						@MaKH varchar(20)
						as
						begin
							select SoTK from THONGTINTAIKHOAN where MaKH = @MaKH
						end 
-- END
-----------------------------------------------Các bảng
-- THONGTINTAIKHOAN
CREATE TABLE THONGTINTAIKHOAN (
	SoTK NVARCHAR(20) NOT NULL PRIMARY KEY,
	SoDu FLOAT CHECK(SoDu >= 0),
	NgayCap VARCHAR(20),
	TenCN NVARCHAR(50),
	LoaiTK NVARCHAR(20),
	MaKH NVARCHAR(20) FOREIGN KEY REFERENCES KHACHHANG(MaKH)
)
-- TAIKHOANDANGNHAP
CREATE TABLE TAIKHOANDANGNHAP(
	MaTK NVARCHAR(20) NOT NULL PRIMARY KEY,
	TenTK NVARCHAR(50),
	MK NVARCHAR(50),
	Email VARCHAR(50),
	MaKH NVARCHAR(20) FOREIGN KEY REFERENCES KHACHHANG(MaKH)
)
--TIETKIEM
CREATE TABLE TIETKIEM (
	MaTietKiem NVARCHAR(20) NOT NULL PRIMARY KEY,
	SoTienGui FLOAT,
	NoiDungTK NVARCHAR(50),
	NgayGuiTK VARCHAR(20),
	MaTK NVARCHAR(20) FOREIGN KEY REFERENCES TAIKHOANDANGNHAP(MaTK)
)
--QUANLY
CREATE TABLE QUANLY
(
	MaQL NVARCHAR(20) NOT NULL PRIMARY KEY,
	TenQL NVARCHAR(25),
	CMND NVARCHAR(20) NOT NULL UNIQUE,
	NgaySinh VARCHAR(20),
	GioiTinh NVARCHAR(5),
	DiaChi NVARCHAR(50),
	SDT VARCHAR(15),
)

INSERT INTO QUANLY VALUES ('QL001', 'Nguyễn Văn A', '0203937223', '20/10/2003', N'Nam', N'Hà Nội', '09226382')

--QUANLYKHACHHANG
CREATE TABLE QUANLYKHACHHANG (
	MaKH NVARCHAR(20) FOREIGN KEY REFERENCES KHACHHANG(MaKH),
	MaQL NVARCHAR(20) FOREIGN KEY REFERENCES QUANLY(MaQL),
	PRIMARY KEY(MaKH, MaQL)
)
SELECT * FROM THONGTINTAIKHOAN
SELECT * FROM KHACHHANG
SELECT * FROM QUANLY
SELECT * FROM TAIKHOANDANGNHAP
SELECT * FROM TIETKIEM 
SELECT * FROM GIAODICH
SELECT * FROM QUANLYKHACHHANG

SELECT TenTK, MK FROM TAIKHOANDANGNHAP

INSERT INTO THONGTINTAIKHOAN VALUES('0928273', '100000', '02/08/2003', 'KH0003')

-- LẤY TÊN KH THUỘC QUẢN LÝ CỦA QL001
SELECT KHACHHANG.MaKH, TenKH FROM KHACHHANG, QUANLY, QUANLYKHACHHANG WHERE KHACHHANG.MaKH = QUANLYKHACHHANG.MaKH 
AND QUANLY.MaQL = QUANLYKHACHHANG.MaQL AND QUANLY.MaQL = 'QL001'

-- Thêm bảng khách hàng, thông tin tài khoản, tài khoản đăng nhập, quản lý khách hàng
-- Random: MaKH, SoTK: CMND, MaTK, MatKhau

-- Xóa kh, tkdn, tttk, qlkh, tk, gd
DELETE KHACHHANG WHERE MaKH = 'KH754'

DELETE TAIKHOANDANGNHAP WHERE MaKH = 'KH754'

DELETE THONGTINTAIKHOAN WHERE MaKH = 'KH754'

DELETE TIETKIEM WHERE MaTK IN (SELECT TK.MaTK FROM TIETKIEM AS T, TAIKHOANDANGNHAP AS TK, KHACHHANG AS K 
WHERE T.MaTK = TK.MaTK AND TK.MaKH = K.MaKH AND K.MaKH = 'KH6883')

DELETE GIAODICH WHERE MaGD IN (SELECT MaGD FROM THONGTINTAIKHOAN AS TK, KHACHHANG AS K, GIAODICH AS G 
WHERE G.SoTKNhan = TK.SoTK AND TK.MaKH = K.MaKH AND K.MaKH = 'KH6883')WHERE G.SoTKNhan = TK.SoTK AND TK.MaKH = K.MaKH AND K.MaKH = 'KH2867')
-- Random: MaKH, SoTK: CMND, MaTK, MatKhau
-- GIAODICH
CREATE TABLE GIAODICH (
	MaGD NVARCHAR(20) NOT NULL PRIMARY KEY,
	SoTienGD FLOAT,
	NoiDungGD NVARCHAR(50),
	ThoiGianGD VARCHAR(20),
	SoTKNhan NVARCHAR(20) FOREIGN KEY REFERENCES THONGTINTAIKHOAN(SoTK),
	SoTKGui NVARCHAR(20)
)
--------------------------------------------------Các Thủ Tục Stored Procedured----------------
