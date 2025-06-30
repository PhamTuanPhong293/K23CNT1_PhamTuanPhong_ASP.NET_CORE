Create Database PhamTuanPhong_2310900081
USE PhamTuanPhong_2310900081;
GO

-- ====================================
-- Tạo bảng PtpEmployee
-- ====================================
CREATE TABLE PtpEmployee (
    PtpEmpId INT IDENTITY(1,1) PRIMARY KEY,
    PtpEmpName NVARCHAR(100) NOT NULL,
    PtpEmpLevel NVARCHAR(50),
    PtpEmpStartDate DATE,
    PtpEmpStatus BIT -- Boolean: 1 = true, 0 = false
);
GO

-- ====================================
-- Thêm dữ liệu mẫu
-- ====================================
INSERT INTO PtpEmployee (PtpEmpName, PtpEmpLevel, PtpEmpStartDate, PtpEmpStatus)
VALUES 
(N'Pham Tuan Phong', N'Student', '2023-03-01', 1), -- Sinh viên thực hiện bài thi
(N'Nguyễn Văn B', N'Senior Developer', '2020-05-10', 0),
(N'Lê Thị C', N'Junior Developer', '2022-01-15', 1);
GO

-- ====================================
-- Kiểm tra dữ liệu
-- ====================================
SELECT * FROM PtpEmployee;
GO