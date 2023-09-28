create database school
use school
go

CREATE TABLE Teacher (
    teacher_id INT IDENTITY PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    surname VARCHAR(255) NOT NULL,
    gender VARCHAR(10),
    subject VARCHAR(255)
);

CREATE TABLE Pupil (
    pupil_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    gender VARCHAR(10),
    class VARCHAR(255)
);

CREATE TABLE Teacher_Pupil (
    teacher_id INT,
    pupil_id INT,
    PRIMARY KEY (teacher_id, pupil_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id),
    FOREIGN KEY (pupil_id) REFERENCES Pupil(pupil_id)
);

SELECT DISTINCT T.name, T.surname
FROM Teacher T
INNER JOIN Teacher_Pupil TP ON T.teacher_id = TP.teacher_id
INNER JOIN Pupil P ON TP.pupil_id = P.pupil_id
WHERE P.first_name = 'Giorgi';

