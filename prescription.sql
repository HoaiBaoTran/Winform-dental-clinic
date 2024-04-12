
DROP TABLE IF EXISTS Prescription
CREATE TABLE Prescription
(
	PresID VARCHAR(10) PRIMARY KEY, 
	PatID VARCHAR(10) REFERENCES PATIENT(PatID),
	DenID VARCHAR(10) REFERENCES DENTIST(DenID),
	totalPrice INT NOT NULL
)
GO


DROP FUNCTION IF EXISTS autoPresid
DROP TABLE IF EXISTS Prescription_Detail
CREATE TABLE Prescription_Detail
(
	PresID VARCHAR(10) REFERENCES Prescription(PresID), 
	materialID VARCHAR(10) REFERENCES Material(materialID),
	quantity INT NOT NULL,
	calUnit NVARCHAR(10),
	note NTEXT
)
GO

create function autoPresid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(PresID) + 1 from Prescription 
	SELECT @ID = 'PR' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000001', 'DE00000001', 150000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000002', 'DE00000001', 250000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000003', 'DE00000002', 350000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000004', 'DE00000002', 400000)


INSERT INTO Prescription_Detail(PresID, materialID, quantity, calUnit, note) values
('PR00000001', 'MA00000052', 10, N'viên', N'3 lần 1 ngày'),
('PR00000001', 'MA00000055', 7, N'viên', N'2 lần 1 ngày'),
('PR00000002', 'MA00000053', 10, N'viên', N'3 lần 1 ngày'),
('PR00000002', 'MA00000055', 5, N'viên', N'1 lần 1 ngày'),
('PR00000002', 'MA00000056', 10, N'viên', N'2 lần 1 ngày'),
('PR00000003', 'MA00000060', 10, N'viên', N'2 lần 1 ngày'),
('PR00000003', 'MA00000063', 4, N'viên', N'1 lần 1 ngày'),
('PR00000003', 'MA00000059', 10, N'viên', N'5 lần 1 ngày'),
('PR00000004', 'MA00000063', 5, N'viên', N'1 lần 1 ngày')

