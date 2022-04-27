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

CREATE TABLE Student (
	id INT PRIMARY KEY IDENTITY(1,1),
	date_birth DATE,
	address NVARCHAR(50),
	full_name NVARCHAR(20),
	gender NVARCHAR(3),
	phone NVARCHAR(15),
)

CREATE TABLE Student_account (
	id INT PRIMARY KEY IDENTITY(1,1),
	student_id INT FOREIGN KEY REFERENCES Student(id),
	login NVARCHAR(20),
	password NVARCHAR(20)
)

CREATE TABLE Teacher (
	id INT PRIMARY KEY IDENTITY(1,1),
	description NVARCHAR(50),
	address NVARCHAR(50),
	full_name NVARCHAR(20),
	email NVARCHAR(20),
	phone NVARCHAR(15),
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
	teacher_id INT FOREIGN KEY REFERENCES Teacher(id),
	course_id INT FOREIGN KEY REFERENCES Course(id)
)

CREATE TABLE Class_student (
	id INT PRIMARY KEY IDENTITY(1,1),
	class_id INT FOREIGN KEY REFERENCES Class(id),
	student_id INT FOREIGN KEY REFERENCES Student(id)
)


CREATE TABLE Weekday (
	id INT PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(10)
)

CREATE TABLE Class_weekday (
	class_id INT FOREIGN KEY REFERENCES Class(id),
	weekday_id INT FOREIGN KEY REFERENCES Weekday(id),
	hours NVARCHAR(10),
	CONSTRAINT PK_Class_weekday PRIMARY KEY (class_id, weekday_id)
)