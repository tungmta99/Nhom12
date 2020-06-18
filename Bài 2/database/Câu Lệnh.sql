USE QuanLyHocSinhGiaoVienTHPT

CREATE PROC del_GV
	@ID_GV NCHAR(20)
AS
BEGIN
	UPDATE dbo.DayHoc SET ID_GV = NULL WHERE ID_GV = @ID_GV
	DELETE  FROM dbo.GiaoVien WHERE ID_GV = @ID_GV
END;


CREATE PROC TKB @malop NCHAR(20)
AS
SELECT dh.Thu AS N'Thứ',dh.Tiet AS N'Tiết',dh.MonHoc AS N'Môn học',gv.HoTen AS N'Họ tên giáo viên'
FROM dbo.DayHoc dh,dbo.GiaoVien gv 
WHERE dh.ID_GV = gv.ID_GV AND @malop = dh.MaLopHoc
GROUP BY dh.Thu,dh.Tiet,dh.MonHoc,gv.HoTen
ORDER BY dh.Thu ASC

EXEC TKB @malop = 'L7A'