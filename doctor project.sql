USE clinicDB;

CREATE TABLE Doctors
(
    DoctorID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorName NVARCHAR(100),
    Specialization NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);
CREATE TABLE Patients
(
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    PatientName NVARCHAR(100),
    Age INT,
    Gender NVARCHAR(20),
    Phone NVARCHAR(20)
);
CREATE TABLE Appointments
(
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATETIME,
    Status NVARCHAR(50)
);
CREATE TABLE Prescriptions
(
    PrescriptionID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    Diagnosis NVARCHAR(500),
    Medicines NVARCHAR(MAX),
    Notes NVARCHAR(MAX),
    VisitDate DATETIME
);

INSERT INTO Patients
(PatientName, Age, Gender, Phone)
VALUES
('Ali',22,'Male','03001234567');

INSERT INTO Patients
(PatientName, Age, Gender, Phone)
VALUES
('Sara',25,'Female','03111234567');

INSERT INTO Patients
(PatientName, Age, Gender, Phone)
VALUES
('Ahmed',30,'Male','03221234567');

SELECT*FROM Patients;

INSERT INTO Doctors
(DoctorName, Specialization, Phone, Email)
VALUES
('Dr Ahmed','Cardiology','03001234567','ahmed@gmail.com');

SELECT * FROM Doctors;
SELECT * FROM Appointments;
SELECT * FROM Prescriptions;

CREATE PROCEDURE sp_GetPatients
AS
BEGIN
    SELECT * FROM Patients
END
GO


CREATE PROCEDURE sp_SearchPatient
    @PatientName NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Patients
    WHERE PatientName LIKE '%' + @PatientName + '%'
END
GO



CREATE PROCEDURE sp_AddAppointment
    @PatientID INT,
    @DoctorID INT,
    @AppointmentDate DATETIME,
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO Appointments
    (
        PatientID,
        DoctorID,
        AppointmentDate,
        Status
    )
    VALUES
    (
        @PatientID,
        @DoctorID,
        @AppointmentDate,
        @Status
    )
END
GO

CREATE TABLE AppointmentAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    AppointmentID INT,
    ActionPerformed NVARCHAR(50),
    ActionDate DATETIME
);

CREATE TRIGGER trg_AfterAppointmentInsert
ON Appointments
AFTER INSERT
AS
BEGIN
    INSERT INTO AppointmentAudit
    (
        AppointmentID,
        ActionPerformed,
        ActionDate
    )
    SELECT
        AppointmentID,
        'Appointment Created',
        GETDATE()
    FROM inserted;
END;

CREATE TABLE PrescriptionAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    PrescriptionID INT,
    ActionPerformed NVARCHAR(50),
    ActionDate DATETIME
);

CREATE TRIGGER trg_AfterPrescriptionInsert
ON Prescriptions
AFTER INSERT
AS
BEGIN
    INSERT INTO PrescriptionAudit
    (
        PrescriptionID,
        ActionPerformed,
        ActionDate
    )
    SELECT
        PrescriptionID,
        'Prescription Added',
        GETDATE()
    FROM inserted;
END;