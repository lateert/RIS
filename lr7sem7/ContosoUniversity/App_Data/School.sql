IF DB_ID(N'School') IS NOT NULL
BEGIN
    ALTER DATABASE School SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE School;
END
GO

CREATE DATABASE School
ON (NAME = School, FILENAME = 'C:\Lab\RIS\lr6sem7\ContosoUniversity\App_Data\School.mdf')
LOG ON (NAME = School_log, FILENAME = 'C:\Lab\RIS\lr6sem7\ContosoUniversity\App_Data\School_log.ldf');
GO

USE School;
GO

CREATE TABLE dbo.Department (
    DepartmentID int IDENTITY(1,1) NOT NULL,
    Name nvarchar(50) NOT NULL,
    Budget money NOT NULL,
    StartDate datetime NOT NULL,
    Administrator int NULL,
    CONSTRAINT PK_Department PRIMARY KEY (DepartmentID)
);

CREATE TABLE dbo.Person (
    PersonID int IDENTITY(1,1) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    FirstName nvarchar(50) NOT NULL,
    HireDate datetime NULL,
    EnrollmentDate datetime NULL,
    CONSTRAINT PK_Person PRIMARY KEY (PersonID)
);

CREATE TABLE dbo.Course (
    CourseID int NOT NULL,
    Title nvarchar(100) NOT NULL,
    Credits int NOT NULL,
    DepartmentID int NOT NULL,
    CONSTRAINT PK_Course PRIMARY KEY (CourseID),
    CONSTRAINT FK_Course_Department FOREIGN KEY (DepartmentID) REFERENCES dbo.Department (DepartmentID)
);

CREATE TABLE dbo.OnlineCourse (
    CourseID int NOT NULL,
    URL nvarchar(100) NOT NULL,
    CONSTRAINT PK_OnlineCourse PRIMARY KEY (CourseID),
    CONSTRAINT FK_OnlineCourse_Course FOREIGN KEY (CourseID) REFERENCES dbo.Course (CourseID)
);

CREATE TABLE dbo.OnsiteCourse (
    CourseID int NOT NULL,
    Location nvarchar(50) NOT NULL,
    Days nvarchar(50) NOT NULL,
    Time smalldatetime NOT NULL,
    CONSTRAINT PK_OnsiteCourse PRIMARY KEY (CourseID),
    CONSTRAINT FK_OnsiteCourse_Course FOREIGN KEY (CourseID) REFERENCES dbo.Course (CourseID)
);

CREATE TABLE dbo.CourseInstructor (
    CourseID int NOT NULL,
    PersonID int NOT NULL,
    CONSTRAINT PK_CourseInstructor PRIMARY KEY (CourseID, PersonID),
    CONSTRAINT FK_CourseInstructor_Course FOREIGN KEY (CourseID) REFERENCES dbo.Course (CourseID),
    CONSTRAINT FK_CourseInstructor_Person FOREIGN KEY (PersonID) REFERENCES dbo.Person (PersonID)
);

CREATE TABLE dbo.OfficeAssignment (
    InstructorID int NOT NULL,
    Location nvarchar(50) NOT NULL,
    Timestamp rowversion NOT NULL,
    CONSTRAINT PK_OfficeAssignment PRIMARY KEY (InstructorID),
    CONSTRAINT FK_OfficeAssignment_Person FOREIGN KEY (InstructorID) REFERENCES dbo.Person (PersonID)
);

CREATE TABLE dbo.StudentGrade (
    EnrollmentID int IDENTITY(1,1) NOT NULL,
    CourseID int NOT NULL,
    StudentID int NOT NULL,
    Grade decimal(3, 2) NULL,
    CONSTRAINT PK_StudentGrade PRIMARY KEY (EnrollmentID),
    CONSTRAINT FK_StudentGrade_Course FOREIGN KEY (CourseID) REFERENCES dbo.Course (CourseID),
    CONSTRAINT FK_StudentGrade_Person FOREIGN KEY (StudentID) REFERENCES dbo.Person (PersonID)
);

ALTER TABLE dbo.Department
    ADD CONSTRAINT FK_Department_Person FOREIGN KEY (Administrator) REFERENCES dbo.Person (PersonID);
GO

SET IDENTITY_INSERT dbo.Department ON;
INSERT INTO dbo.Department (DepartmentID, Name, Budget, StartDate, Administrator) VALUES
    (1, N'Engineering', 350000.00, '2007-09-01', NULL),
    (2, N'English', 120000.00, '2007-09-01', NULL),
    (3, N'Economics', 200000.00, '2007-09-01', NULL);
SET IDENTITY_INSERT dbo.Department OFF;

SET IDENTITY_INSERT dbo.Person ON;
INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate) VALUES
    (1, N'Abercrombie', N'Kim', '1995-03-11', NULL),
    (2, N'Fakhouri', N'Fadi', '2002-07-06', NULL),
    (3, N'Harui', N'Roger', '1998-07-01', NULL),
    (4, N'Alexander', N'Carson', NULL, '2005-09-01'),
    (5, N'Alonso', N'Meredith', NULL, '2002-09-01'),
    (6, N'Anand', N'Arturo', NULL, '2003-09-01'),
    (7, N'Barzdukas', N'Gytis', NULL, '2005-09-01');
SET IDENTITY_INSERT dbo.Person OFF;

UPDATE dbo.Department SET Administrator = 1 WHERE DepartmentID = 1;
UPDATE dbo.Department SET Administrator = 2 WHERE DepartmentID = 2;
UPDATE dbo.Department SET Administrator = 3 WHERE DepartmentID = 3;

INSERT INTO dbo.Course (CourseID, Title, Credits, DepartmentID) VALUES
    (1050, N'Chemistry', 4, 1),
    (1061, N'Physics', 4, 1),
    (1045, N'Calculus', 4, 1),
    (2021, N'Composition', 3, 2),
    (2030, N'Poetry', 2, 2),
    (3141, N'Macroeconomics', 3, 3);

INSERT INTO dbo.OnlineCourse (CourseID, URL) VALUES
    (2021, N'http://www.contoso.com/composition'),
    (2030, N'http://www.contoso.com/poetry');

INSERT INTO dbo.OnsiteCourse (CourseID, Location, Days, Time) VALUES
    (1050, N'Building 7', N'Monday, Wednesday', '2000-01-01 15:30'),
    (1061, N'Building 5', N'Tuesday, Thursday', '2000-01-01 09:00'),
    (1045, N'Building 7', N'Monday, Wednesday, Friday', '2000-01-01 11:00'),
    (3141, N'Building 2', N'Monday, Wednesday', '2000-01-01 13:00');

INSERT INTO dbo.CourseInstructor (CourseID, PersonID) VALUES
    (1050, 1),
    (1061, 1),
    (1045, 2),
    (2021, 2),
    (2030, 3),
    (3141, 3);

INSERT INTO dbo.OfficeAssignment (InstructorID, Location) VALUES
    (1, N'Smith Hall 17'),
    (2, N'Gowan Hall 42'),
    (3, N'Thompson Hall 8');

INSERT INTO dbo.StudentGrade (CourseID, StudentID, Grade) VALUES
    (1050, 4, 3.50),
    (1061, 4, 4.00),
    (2021, 5, 3.00),
    (2030, 6, NULL),
    (3141, 7, 2.50),
    (1045, 5, 3.50);
GO
