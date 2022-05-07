CREATE DATABASE TrungTamAnhVanDB
GO

USE TrungTamAnhVanDB

CREATE TABLE Category (
	id INT PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(20)
)

CREATE TABLE Level (
	id INT PRIMARY KEY IDENTITY(1,1),
	sign char(2),
	name NVARCHAR(20)
)

CREATE TABLE Course (
	id INT PRIMARY KEY IDENTITY(1,1),
	lessons INT,
	description NVARCHAR(100),
	term VARCHAR(50),
	level_id INT FOREIGN KEY REFERENCES Level(id),
	category_id INT FOREIGN KEY REFERENCES Category(id)
)

CREATE TABLE Teacher (
	id INT PRIMARY KEY IDENTITY(1,1),
	full_name NVARCHAR(20),
	gender NVARCHAR(3),
	date_birth DATE,
	phone NVARCHAR(15),
	address NVARCHAR(50),
	description NVARCHAR(50),
	salary MONEY
)

CREATE TABLE Teacher_account (
	id INT PRIMARY KEY IDENTITY(1,1),
	teacher_id INT FOREIGN KEY REFERENCES Teacher(id),
	login NVARCHAR(20),
	password NVARCHAR(20)
)

CREATE TABLE Admin (
	id INT PRIMARY KEY IDENTITY(1,1),
	full_name NVARCHAR(20)
)

CREATE TABLE Admin_account (
	id INT PRIMARY KEY IDENTITY(1,1),
	admin_id INT FOREIGN KEY REFERENCES Admin(id),
	login NVARCHAR(20),
	password NVARCHAR(20)
)

CREATE TABLE Class (
	id INT PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(20),
	start_day DATE,
	end_day	DATE,
	price MONEY,
	quantity INT,
    max_quantity INT,
    teacher_id INT FOREIGN KEY REFERENCES Teacher(id),
	course_id INT FOREIGN KEY REFERENCES Course(id),
)

CREATE TABLE Student (
	id INT PRIMARY KEY IDENTITY(1,1),
	full_name NVARCHAR(20),
	gender NVARCHAR(3),
	date_birth DATE,
	phone NVARCHAR(15),
	address NVARCHAR(50),
	class_id INT NULL FOREIGN KEY REFERENCES Class(id),
	level_id INT NOT NULL FOREIGN KEY REFERENCES Level(id)
)

CREATE TABLE Student_account (
	id INT PRIMARY KEY IDENTITY(1,1),
	student_id INT FOREIGN KEY REFERENCES Student(id),
	login NVARCHAR(20),
	password NVARCHAR(20)
)

CREATE TABLE Score (
	id INT PRIMARY KEY IDENTITY(1,1),
	listening_score NVARCHAR,
	reading_score NVARCHAR,
	speaking_score NVARCHAR,
	writing_score NVARCHAR,
	student_id INT FOREIGN KEY REFERENCES Student(id)
)

CREATE TABLE Event (
	id INT PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(50),
	description NVARCHAR(100),
	sending_time DATETIME,
	start_day DATE,
	class_id INT FOREIGN KEY REFERENCES Class(id),
	teacher_id INT FOREIGN KEY REFERENCES Teacher(id)
)

--CREATE TABLE Class_student (
--	id INT PRIMARY KEY IDENTITY(1,1),
--	class_id INT FOREIGN KEY REFERENCES Class(id),
--	student_id INT FOREIGN KEY REFERENCES Student(id)
--)


CREATE TABLE Weekday (
	id INT PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(10)
)

CREATE TABLE Class_weekday (
	class_id INT FOREIGN KEY REFERENCES Class(id),
	weekday_id INT FOREIGN KEY REFERENCES Weekday(id),
	start_hour INT,
	end_hour INT,
	CONSTRAINT PK_Class_weekday PRIMARY KEY (class_id, weekday_id)
)

INSERT INTO Admin VALUES('Lê Văn A')

INSERT INTO Admin_account VALUES(1, 'admin1', '1')

INSERT INTO Teacher VALUES(N'Trần Văn A', N'Nam', '1980-01-01', '0123450089', N'1 Quyết Thắng', 'ielts 8.0', 0)
INSERT INTO Teacher VALUES(N'Trần Thị B', N'Nữ', '1980-01-02', '0123450189', N'2 Quyết Thắng', 'ielts 8.0', 0)
INSERT INTO Teacher VALUES(N'Trần Văn C', N'Nam', '1980-01-03', '0123450289', N'3 Quyết Thắng', 'ielts 8.0', 0)
INSERT INTO Teacher VALUES(N'Trần Thị D', N'Nữ', '1980-01-04', '0123450389', N'4 Quyết Thắng', 'ielts 8.0', 0)
INSERT INTO Teacher VALUES(N'Trần Văn E', N'Nam', '1980-01-05', '0123450489', N'5 Quyết Thắng', 'ielts 8.0', 0)


INSERT INTO Teacher_account VALUES(1, 'teacher1', '1')
INSERT INTO Teacher_account VALUES(2, 'teacher2', '2')
INSERT INTO Teacher_account VALUES(3, 'teacher3', '3')
INSERT INTO Teacher_account VALUES(4, 'teacher4', '4')
INSERT INTO Teacher_account VALUES(5, 'teacher5', '5')

INSERT INTO Category VALUES('Children')
INSERT INTO Category VALUES('Youth')
INSERT INTO Category VALUES('Adult')

INSERT INTO Level VALUES('A1', 'Beginner')
INSERT INTO Level VALUES('A2', 'Elementary')
INSERT INTO Level VALUES('B1', 'Intermediate')
INSERT INTO Level VALUES('B2', 'Upper Intermediate')
INSERT INTO Level VALUES('C1', 'Advanced')
INSERT INTO Level VALUES('C2', 'Proficient')

INSERT INTO Course VALUES(15, N'Khoá học hè cho trẻ em mới bắt đầu', N'3 tháng', 1, 1)
INSERT INTO Course VALUES(15, N'Khoá học hè cho trẻ em sơ cấp', N'3 tháng', 2, 1)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên mới bắt đầu', N'3 tháng', 1, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên sơ cấp', N'3 tháng', 2, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên trung cấp', N'3 tháng', 3, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên trên trung cấp', N'3 tháng', 4, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên cao cấp', N'3 tháng', 5, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho thanh niên thành thạo', N'3 tháng', 6, 2)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn mới bắt đầu', N'3 tháng', 1, 3)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn sơ cấp', N'3 tháng', 2, 3)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn trung cấp', N'3 tháng', 3, 3)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn trên trung cấp', N'3 tháng', 4, 3)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn cao cấp', N'3 tháng', 5, 3)
INSERT INTO Course VALUES(15, N'Khoá học hè cho người lớn thành thạo', N'3 tháng', 6, 3)

INSERT INTO Class VALUES('A101', '2022-05-01', '2022-08-01', 1000000, 0, 20, 1, 1)
INSERT INTO Class VALUES('A102', '2022-05-01', '2022-08-01', 2000000, 0, 20, 2, 2)
INSERT INTO Class VALUES('A103', '2022-05-01', '2022-08-01', 3000000, 0, 20, 3, 3)
INSERT INTO Class VALUES('A104', '2022-05-01', '2022-08-01', 3000000, 0, 20, 4, 4)
INSERT INTO Class VALUES('A105', '2022-05-01', '2022-08-01', 3000000, 0, 20, 5, 9)
INSERT INTO Class VALUES('A106', '2022-05-01', '2022-08-01', 3000000, 0, 20, 1, 10)
INSERT INTO Class VALUES('B101', '2022-05-01', '2022-08-01', 3000000, 0, 20, 2, 5)
INSERT INTO Class VALUES('B102', '2022-05-01', '2022-08-01', 3000000, 0, 20, 3, 6)
INSERT INTO Class VALUES('B103', '2022-05-01', '2022-08-01', 3000000, 0, 20, 4, 11)
INSERT INTO Class VALUES('B104', '2022-05-01', '2022-08-01', 3000000, 0, 20, 5, 12)
INSERT INTO Class VALUES('C101', '2022-05-01', '2022-08-01', 3000000, 0, 20, 1, 7)
INSERT INTO Class VALUES('C102', '2022-05-01', '2022-08-01', 3000000, 0, 20, 2, 8)
INSERT INTO Class VALUES('C103', '2022-05-01', '2022-08-01', 3000000, 0, 20, 3, 13)
INSERT INTO Class VALUES('C104', '2022-05-01', '2022-08-01', 3000000, 0, 20, 4, 14)

INSERT INTO Weekday VALUES(N'Thứ hai')
INSERT INTO Weekday VALUES(N'Thứ ba')
INSERT INTO Weekday VALUES(N'Thứ tư')
INSERT INTO Weekday VALUES(N'Thứ năm')
INSERT INTO Weekday VALUES(N'Thứ sáu')
INSERT INTO Weekday VALUES(N'Thứ bảy')
INSERT INTO Weekday VALUES(N'Chủ nhật')

INSERT INTO Class_weekday VALUES(1, 1, 7, 10)
INSERT INTO Class_weekday VALUES(1, 3, 7, 10)
INSERT INTO Class_weekday VALUES(2, 2, 7, 10)
INSERT INTO Class_weekday VALUES(2, 4, 7, 10)
INSERT INTO Class_weekday VALUES(3, 3, 7, 10)
INSERT INTO Class_weekday VALUES(3, 5, 7, 10)
INSERT INTO Class_weekday VALUES(4, 4, 7, 10)
INSERT INTO Class_weekday VALUES(4, 6, 7, 10)
INSERT INTO Class_weekday VALUES(5, 5, 7, 10)
INSERT INTO Class_weekday VALUES(5, 7, 7, 10)
INSERT INTO Class_weekday VALUES(6, 1, 18, 21)
INSERT INTO Class_weekday VALUES(6, 3, 18, 21)
INSERT INTO Class_weekday VALUES(7, 2, 18, 21)
INSERT INTO Class_weekday VALUES(7, 4, 18, 21)
INSERT INTO Class_weekday VALUES(8, 3, 18, 21)
INSERT INTO Class_weekday VALUES(8, 5, 18, 21)
INSERT INTO Class_weekday VALUES(9, 4, 18, 21)
INSERT INTO Class_weekday VALUES(9, 6, 18, 21)
INSERT INTO Class_weekday VALUES(10, 5, 18, 21)
INSERT INTO Class_weekday VALUES(10, 7, 18, 21)
INSERT INTO Class_weekday VALUES(11, 1, 14, 17)
INSERT INTO Class_weekday VALUES(11, 3, 14, 17)
INSERT INTO Class_weekday VALUES(12, 2, 14, 17)
INSERT INTO Class_weekday VALUES(12, 4, 14, 17)
INSERT INTO Class_weekday VALUES(13, 3, 14, 17)
INSERT INTO Class_weekday VALUES(13, 5, 14, 17)
INSERT INTO Class_weekday VALUES(14, 4, 14, 17)
INSERT INTO Class_weekday VALUES(14, 6, 14, 17)

INSERT INTO Student VALUES(N'Nguyễn Văn A', 'Nam', '2002-01-01', '0123456701', N'0 Trường Chinh', NULL, 1)
INSERT INTO Student VALUES(N'Nguyễn Văn B', 'Nam', '2002-01-02', '0123456702', N'1 Trường Chinh', NULL, 2)
INSERT INTO Student VALUES(N'Nguyễn Văn C', 'Nam', '2002-01-03', '0123456703', N'2 Trường Chinh', NULL, 3)
INSERT INTO Student VALUES(N'Nguyễn Văn D', 'Nam', '2002-01-04', '0123456704', N'3 Trường Chinh', NULL, 4)
INSERT INTO Student VALUES(N'Nguyễn Văn E', 'Nam', '2002-01-05', '0123456705', N'4 Trường Chinh', NULL, 5)
INSERT INTO Student VALUES(N'Nguyễn Văn F', 'Nam', '2002-01-06', '0123456706', N'5 Trường Chinh', NULL, 6)
INSERT INTO Student VALUES(N'Nguyễn Văn G', 'Nam', '2002-01-07', '0123456707', N'6 Trường Chinh', NULL, 1)
INSERT INTO Student VALUES(N'Nguyễn Văn H', 'Nam', '2002-01-08', '0123456708', N'7 Trường Chinh', NULL, 2)
INSERT INTO Student VALUES(N'Nguyễn Văn I', 'Nam', '2002-01-09', '0123456709', N'8 Trường Chinh', NULL, 3)
INSERT INTO Student VALUES(N'Nguyễn Văn J', 'Nam', '2002-01-10', '0123456710', N'9 Trường Chinh', NULL, 4)
INSERT INTO Student VALUES(N'Nguyễn Văn K', 'Nam', '2002-01-11', '0123456711', N'10 Trường Chinh', NULL, 5)
INSERT INTO Student VALUES(N'Nguyễn Văn L', 'Nam', '2002-01-12', '0123456712', N'11 Trường Chinh', NULL, 6)
INSERT INTO Student VALUES(N'Nguyễn Văn M', 'Nam', '2002-01-13', '0123456713', N'12 Trường Chinh', NULL, 1)
INSERT INTO Student VALUES(N'Nguyễn Thị N', N'Nữ', '2002-01-14', '0123456714', N'13 Trường Chinh', NULL, 2)
INSERT INTO Student VALUES(N'Nguyễn Thị O', N'Nữ', '2002-01-15', '0123456715', N'14 Trường Chinh', NULL, 3)
INSERT INTO Student VALUES(N'Nguyễn Thị P', N'Nữ', '2002-01-16', '0123456716', N'15 Trường Chinh', NULL, 4)
INSERT INTO Student VALUES(N'Nguyễn Thị Q', N'Nữ', '2002-01-17', '0123456717', N'16 Trường Chinh', NULL, 5)
INSERT INTO Student VALUES(N'Nguyễn Thị R', N'Nữ', '2002-01-18', '0123456718', N'17 Trường Chinh', NULL, 6)
INSERT INTO Student VALUES(N'Nguyễn Thị S', N'Nữ', '2002-01-19', '0123456719', N'18 Trường Chinh', NULL, 1)
INSERT INTO Student VALUES(N'Nguyễn Thị T', N'Nữ', '2002-01-20', '0123456720', N'19 Trường Chinh', NULL, 2)
INSERT INTO Student VALUES(N'Nguyễn Thị U', N'Nữ', '2002-01-21', '0123456721', N'20 Trường Chinh', NULL, 3)
INSERT INTO Student VALUES(N'Nguyễn Thị V', N'Nữ', '2002-01-22', '0123456722', N'21 Trường Chinh', NULL, 4)
INSERT INTO Student VALUES(N'Nguyễn Thị W', N'Nữ', '2002-01-23', '0123456723', N'22 Trường Chinh', NULL, 5)
INSERT INTO Student VALUES(N'Nguyễn Thị X', N'Nữ', '2002-01-24', '0123456724', N'23 Trường Chinh', NULL, 6)
INSERT INTO Student VALUES(N'Nguyễn Thị Y', N'Nữ', '2002-01-25', '0123456725', N'24 Trường Chinh', NULL, 1)
INSERT INTO Student VALUES(N'Nguyễn Thị Z', N'Nữ', '2002-01-26', '0123456726', N'25 Trường Chinh', NULL, 2)

INSERT INTO Student_account VALUES(1, 'student1', '1')
INSERT INTO Student_account VALUES(2, 'student2', '2')
INSERT INTO Student_account VALUES(3, 'student3', '3')
INSERT INTO Student_account VALUES(4, 'student4', '4')
INSERT INTO Student_account VALUES(5, 'student5', '5')
INSERT INTO Student_account VALUES(6, 'student6', '6')
INSERT INTO Student_account VALUES(7, 'student7', '7')
INSERT INTO Student_account VALUES(8, 'student8', '8')
INSERT INTO Student_account VALUES(9, 'student9', '9')
INSERT INTO Student_account VALUES(10, 'student10', '10')
INSERT INTO Student_account VALUES(11, 'student11', '11')
INSERT INTO Student_account VALUES(12, 'student12', '12')
INSERT INTO Student_account VALUES(13, 'student13', '13')
INSERT INTO Student_account VALUES(14, 'student14', '14')
INSERT INTO Student_account VALUES(15, 'student15', '15')
INSERT INTO Student_account VALUES(16, 'student16', '16')
INSERT INTO Student_account VALUES(17, 'student17', '17')
INSERT INTO Student_account VALUES(18, 'student18', '18')
INSERT INTO Student_account VALUES(19, 'student19', '19')
INSERT INTO Student_account VALUES(20, 'student20', '20')
INSERT INTO Student_account VALUES(21, 'student21', '21')
INSERT INTO Student_account VALUES(22, 'student22', '22')
INSERT INTO Student_account VALUES(23, 'student23', '23')
INSERT INTO Student_account VALUES(24, 'student24', '24')
INSERT INTO Student_account VALUES(25, 'student25', '25')
INSERT INTO Student_account VALUES(26, 'student26', '26')
