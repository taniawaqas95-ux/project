
USE doctor;
GO

CREATE TABLE Doctors
(
    DoctorID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorName VARCHAR(100) NOT NULL,
    Gender VARCHAR(20),
    Specialization VARCHAR(100),
    Phone VARCHAR(20),
    Experience INT
);
