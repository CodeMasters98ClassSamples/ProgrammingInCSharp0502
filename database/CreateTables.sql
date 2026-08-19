/* =====================================================
   ProgrammingInCSharp0502 Database - Table Scripts
   SQL Server | IDENTITY(1,1)
   ===================================================== */

-- Drop in dependency order (child -> parent)
IF OBJECT_ID('dbo.StudentCourseHistory', 'U') IS NOT NULL DROP TABLE dbo.StudentCourseHistory;
IF OBJECT_ID('dbo.CourseHistory', 'U') IS NOT NULL DROP TABLE dbo.CourseHistory;
IF OBJECT_ID('dbo.Course', 'U') IS NOT NULL DROP TABLE dbo.Course;
IF OBJECT_ID('dbo.Category', 'U') IS NOT NULL DROP TABLE dbo.Category;
IF OBJECT_ID('dbo.Master', 'U') IS NOT NULL DROP TABLE dbo.Master;
IF OBJECT_ID('dbo.Address', 'U') IS NOT NULL DROP TABLE dbo.Address;
IF OBJECT_ID('dbo.Student', 'U') IS NOT NULL DROP TABLE dbo.Student;
GO

-- ===================== Address =====================
CREATE TABLE dbo.Address
(
    Id          INT           IDENTITY(1,1) NOT NULL,
    Title       NVARCHAR(100) NOT NULL,
    Detail      NVARCHAR(500) NOT NULL,
    PostalCode  VARCHAR(10)   NOT NULL,
    CreatedAt   DATETIME2     NOT NULL CONSTRAINT DF_Address_CreatedAt DEFAULT SYSUTCDATETIME(),
    IsDeleted   BIT           NOT NULL CONSTRAINT DF_Address_IsDeleted DEFAULT 0,
    DeletedAt   DATETIME2     NULL,

    CONSTRAINT PK_Address PRIMARY KEY (Id)
);
GO

-- ===================== Student =====================
CREATE TABLE dbo.Student
(
    Id           BIGINT        IDENTITY(1,1) NOT NULL,
    FirstName    NVARCHAR(100) NOT NULL,
    LastName     NVARCHAR(100) NOT NULL,
    Phone        VARCHAR(11)   NOT NULL,
    NationalCode CHAR(10)      NOT NULL,
    Code         VARCHAR(10)   NOT NULL,
    CreatedAt    DATETIME2     NOT NULL CONSTRAINT DF_Student_CreatedAt DEFAULT SYSUTCDATETIME(),
    IsDeleted    BIT           NOT NULL CONSTRAINT DF_Student_IsDeleted DEFAULT 0,
    DeletedAt    DATETIME2     NULL,

    CONSTRAINT PK_Student PRIMARY KEY (Id),
    CONSTRAINT UQ_Student_NationalCode UNIQUE (NationalCode),
    CONSTRAINT UQ_Student_Code UNIQUE (Code)
);
GO

-- ===================== Category =====================
CREATE TABLE dbo.Category
(
    Id          SMALLINT      IDENTITY(1,1) NOT NULL,
    Title       NVARCHAR(100) NOT NULL,
    StartAt     DATETIME2     NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedAt   DATETIME2     NOT NULL CONSTRAINT DF_Category_CreatedAt DEFAULT SYSUTCDATETIME(),
    IsDeleted   BIT           NOT NULL CONSTRAINT DF_Category_IsDeleted DEFAULT 0,
    DeletedAt   DATETIME2     NULL,

    CONSTRAINT PK_Category PRIMARY KEY (Id)
);
GO

-- ===================== Master =====================
CREATE TABLE dbo.Master
(
    Id           SMALLINT      IDENTITY(1,1) NOT NULL,
    FirstName    NVARCHAR(100) NOT NULL,
    LastName     NVARCHAR(100) NOT NULL,
    Phone        VARCHAR(11)   NOT NULL,
    NationalCode CHAR(10)      NOT NULL,
    AddressId    INT           NULL,
    LastDocument NVARCHAR(500) NULL,
    CardInfo     NVARCHAR(200) NULL,
    CreatedAt    DATETIME2     NOT NULL CONSTRAINT DF_Master_CreatedAt DEFAULT SYSUTCDATETIME(),
    IsDeleted    BIT           NOT NULL CONSTRAINT DF_Master_IsDeleted DEFAULT 0,
    DeletedAt    DATETIME2     NULL,

    CONSTRAINT PK_Master PRIMARY KEY (Id),
    CONSTRAINT UQ_Master_NationalCode UNIQUE (NationalCode),
    CONSTRAINT FK_Master_Address FOREIGN KEY (AddressId) REFERENCES dbo.Address (Id)
);
GO

-- ===================== Course =====================
CREATE TABLE dbo.Course
(
    Id          SMALLINT        IDENTITY(1,1) NOT NULL,
    Title       NVARCHAR(200)   NOT NULL,
    Description NVARCHAR(2000)  NULL,
    Price       DECIMAL(18, 2)  NOT NULL,
    Hour        INT             NOT NULL,
    OnSiteSize  INT             NOT NULL,
    RemoteSize  INT             NOT NULL,
    CategoryId  SMALLINT        NULL,
    CreatedAt   DATETIME2       NOT NULL CONSTRAINT DF_Course_CreatedAt DEFAULT SYSUTCDATETIME(),
    IsDeleted   BIT             NOT NULL CONSTRAINT DF_Course_IsDeleted DEFAULT 0,
    DeletedAt   DATETIME2       NULL,

    CONSTRAINT PK_Course PRIMARY KEY (Id),
    CONSTRAINT FK_Course_Category FOREIGN KEY (CategoryId) REFERENCES dbo.Category (Id)
);
GO

-- ===================== CourseHistory =====================
CREATE TABLE dbo.CourseHistory
(
    Id         INT           IDENTITY(1,1) NOT NULL,
    Title      NVARCHAR(200) NOT NULL,
    Code       VARCHAR(20)   NOT NULL,
    Price      DECIMAL(18,2) NOT NULL,
    StartAt    DATETIME2     NOT NULL,
    EndAt      DATETIME2     NOT NULL,
    [Type]     TINYINT       NOT NULL, -- CourseType enum: 1=ONSITE, 2=ONLINE, 3=HYBRID, 4=OFLINE
    CourseId   SMALLINT      NOT NULL,
    MasterId   SMALLINT      NOT NULL,
    CreatedAt  DATETIME2     NOT NULL CONSTRAINT DF_CourseHistory_CreatedAt DEFAULT SYSUTCDATETIME(),

    CONSTRAINT PK_CourseHistory PRIMARY KEY (Id),
    CONSTRAINT FK_CourseHistory_Course FOREIGN KEY (CourseId) REFERENCES dbo.Course (Id),
    CONSTRAINT FK_CourseHistory_Master FOREIGN KEY (MasterId) REFERENCES dbo.Master (Id)
);
GO

-- ===================== StudentCourseHistory =====================
CREATE TABLE dbo.StudentCourseHistory
(
    Id              BIGINT    IDENTITY(1,1) NOT NULL,
    StudentId       BIGINT    NOT NULL,
    CourseHistoryId INT       NOT NULL,
    PaymentType     TINYINT   NOT NULL, -- PaymentType enum: 1=CASHE, 2=ONLINE
    RegisterDate    DATETIME2 NOT NULL,
    CreatedAt       DATETIME2 NOT NULL CONSTRAINT DF_StudentCourseHistory_CreatedAt DEFAULT SYSUTCDATETIME(),

    CONSTRAINT PK_StudentCourseHistory PRIMARY KEY (Id),
    CONSTRAINT FK_StudentCourseHistory_Student FOREIGN KEY (StudentId) REFERENCES dbo.Student (Id),
    CONSTRAINT FK_StudentCourseHistory_CourseHistory FOREIGN KEY (CourseHistoryId) REFERENCES dbo.CourseHistory (Id)
);
GO
