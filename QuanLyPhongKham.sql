		/*
use master
go
drop database QuanLyPhongKham
*/
/*
create database QuanLyPhongKham
go
use QuanLyPhongKham
go
*/

CREATE TABLE Account
(
  able BIT DEFAULT 1 NOT NULL,
  AccountID VARCHAR(10) PRIMARY KEY,
  username NVARCHAR(50) NOT NULL UNIQUE,
  password NVARCHAR(50) NOT NULL,
  role CHAR(1) NOT NULL CHECK (role in ('A','B','C')), -- A la Quan li, B Le tan, C la Nha si
);
GO

--function tu tao id 

create function autoAcid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(AccountID) + 1 from Account 
	SELECT @ID = 'AC' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


CREATE TABLE Admin
(
  AdminID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(50) NOT NULL,
  address NVARCHAR(80) NOT NULL,
  phone_number NVARCHAR(15) NOT NULL,
  email NVARCHAR(30) NOT NULL UNIQUE,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL,
  AccountID VARCHAR(10) NOT NULL,
  FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
)
GO

--function tu tao id 
create function autoADid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(AdminID) + 1 from admin 
	SELECT @ID = 'AD' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO

CREATE TABLE Material
(
  able BIT DEFAULT 1 NOT NULL,
  materialID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(50) NOT NULL,
  AdminID VARCHAR(10) NOT NULL,
  CalUnit NVARCHAR(70) NOT NULL,
  quantity INT NOT NULL,
  FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
);
GO

--function tu tao id 

create function autoMAid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(materialID) + 1 from Material 
	SELECT @ID = 'MA' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO



CREATE TABLE ConsumableMaterial
(
  able BIT DEFAULT 1 NOT NULL,
  expiration_date DATETIME NOT NULL,
  typeConMaterial NVARCHAR(40) NOT NULL,
  materialID VARCHAR(10) PRIMARY KEY ,
  FOREIGN KEY (materialID) REFERENCES Material(materialID)
)
GO

CREATE TABLE Medicine
(
	able BIT DEFAULT 1 NOT NULL,
	price INT NOT NULL,
	materialID VARCHAR(10) PRIMARY KEY ,
	FOREIGN KEY (materialID) REFERENCES ConsumableMaterial(materialID)
)

CREATE TABLE FixedMaterial
(
  able BIT DEFAULT 1 NOT NULL,
  materialID VARCHAR(10) PRIMARY KEY ,
  FOREIGN KEY (materialID) REFERENCES Material(materialID)
)
GO

CREATE TABLE Receptionist
(
  able BIT DEFAULT 1 NOT NULL,
  name NVARCHAR(50) NOT NULL,
  address NVARCHAR(80) NOT NULL,
  email NVARCHAR(50) NOT NULL UNIQUE,
  phone_number NVARCHAR(15) NOT NULL,
  RecepID VARCHAR(10) PRIMARY KEY,
  salary INT NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL,
  AccountID VARCHAR(10) NOT NULL,
  FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
)
GO

CREATE TABLE Calendar_Receptionist
(
	able BIT DEFAULT 1 NOT NULL,
	RecepID VARCHAR(10),
	dayWorks DATETIME NOT NULL,
	timeStart DATETIME NOT NULL,
	timeEnd DATETIME NOT NULL,
	FOREIGN KEY (RecepID) REFERENCES Receptionist(RecepID)
)
go


--function tu tao id 

create function autoReid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(RecepID) + 1 from Receptionist 
	SELECT @ID = 'RE' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO

CREATE TABLE Faculty
(
  able BIT DEFAULT 1 NOT NULL,
  FacID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(50) NOT NULL
);
GO
--function tu tao id 

create function autoFaid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(FacID) + 1 from Faculty 
	SELECT @ID = 'FA' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


CREATE TABLE Dentist
(
  able BIT DEFAULT 1 NOT NULL,
  DenID VARCHAR(10) PRIMARY KEY,
  address NVARCHAR(80) NOT NULL,
  email NVARCHAR(50) NOT NULL UNIQUE,
  phone_number NVARCHAR(15) NOT NULL,
  name NVARCHAR(50) NOT NULL,
  title NVARCHAR(15) NOT NULL,
  rank NVARCHAR(20) NOT NULL,
  nation NVARCHAR(20) NOT NULL,
  salary INT NOT NULL,
  FacID VARCHAR(10) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL,
  AccountID VARCHAR(10) NOT NULL,
  FOREIGN KEY (FacID) REFERENCES Faculty(FacID),
  FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

CREATE TABLE Calendar_Dentist
(
	able BIT DEFAULT 1 NOT NULL,
	DenID VARCHAR(10) ,
	dayWorks DATETIME NOT NULL,
	timeStart DATETIME NOT NULL,
	timeEnd DATETIME NOT NULL,
	FOREIGN KEY (DenID) REFERENCES Dentist(DenID)
)
go
--function tu tao id 

create function autoDeid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(DenID) + 1 from Dentist 
	SELECT @ID = 'DE' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


CREATE TABLE Patient
(
  able BIT DEFAULT 1 NOT NULL,
  name NVARCHAR(50) NOT NULL,
  email NVARCHAR(50) NOT NULL,
  PatID VARCHAR(10) PRIMARY KEY,
  number NVARCHAR(15) NOT NULL,
  address NVARCHAR(80) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL
)
GO

--function tu tao id 

create function autoPaid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(PatID) + 1 from Patient 
	SELECT @ID = 'PA' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO





CREATE TABLE Assisstant
(
  able BIT DEFAULT 1 NOT NULL,
  AssiID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(50) NOT NULL,
  phone_number NVARCHAR(15) NOT NULL,
  email NVARCHAR(50) NOT NULL,
  salary INT NOT NULL,
  address NVARCHAR(80) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL
)
GO

CREATE TABLE Calendar_Assisstant
(
	able BIT DEFAULT 1 NOT NULL,
	AssiID VARCHAR(10) ,
	dayWorks DATETIME NOT NULL,
	timeStart DATETIME NOT NULL,
	timeEnd DATETIME NOT NULL,
	FOREIGN KEY (AssiID) REFERENCES Assisstant(AssiID)
)
go

--function tu tao id 

create function autoAsid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(AssiID) + 1 from Assisstant 
	SELECT @ID = 'AS' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


CREATE TABLE Appointment
(
  ApID VARCHAR(10) PRIMARY KEY,
  ap_time DATETIME NOT NULL,
  PatID VARCHAR(10) NOT NULL,
  DenID VARCHAR(10) NOT NULL,
  AssiID VARCHAR(10) NOT NULL,
  able BIT DEFAULT 1 NOT NULL,
  symptom NVARCHAR(150) NOT NULL,
  stateAp CHAR(1) CHECK (stateAp IN ('A', 'B', 'C')) NOT NULL,
  note NVARCHAR(170) NOT NULL,
  FOREIGN KEY (PatID) REFERENCES Patient(PatID),
  FOREIGN KEY (DenID) REFERENCES Dentist(DenID),
  FOREIGN KEY (AssiID) REFERENCES Assisstant(AssiID)
);
GO

--function tu tao id 

create function autoApid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(ApID) + 1 from Appointment 
	SELECT @ID = 'AP' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO



CREATE TABLE Bill
(
  able BIT DEFAULT 1 NOT NULL,
  bilID VARCHAR(10) PRIMARY KEY,
  total_price INT NOT NULL,
  payment_time DATETIME NOT NULL,
  PatID VARCHAR(10) NOT NULL,
  FOREIGN KEY (PatID) REFERENCES Patient(PatID)
);
GO


--function tu tao id 

create function autoBiid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(bilID) + 1 from Bill 
	SELECT @ID = 'BI' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO


CREATE TABLE Service
(
  able BIT DEFAULT 1 NOT NULL,
  serviceID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(100) NOT NULL,
  price INT NOT NULL,
  CalUnit NVARCHAR(10) NOT NULL,
  quantity INT NOT NULL,
  note NVARCHAR(70)NOT NULL,								
  kindService NVARCHAR(60) NOT NULL
)
GO

--function tu tao id 

create function autoSeid()
returns VARCHAR(10)
as 
begin
	declare @ID VARCHAR(10)
	declare @QUAN INT 
	SELECT @QUAN = COUNT(serviceID) + 1 from Service 
	SELECT @ID = 'SE' + RIGHT(REPLICATE(0,8), 8 - LEN(CAST (@QUAN AS VARCHAR(8)))) +  CAST(@QUAN AS VARCHAR(8))
	RETURN @ID
END
GO

CREATE TABLE Bill_Service
(
  BilId VARCHAR(10) NOT NULL,
  ServiceID VARCHAR(10) NOT NULL,
  quantity int NOT NULL,
  PRIMARY KEY (BilId, ServiceID),
  FOREIGN KEY (BilId) REFERENCES Bill(BilId),
  FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID)
);
GO


CREATE TABLE Faculty_Recep
(
  RecepID VARCHAR(10) NOT NULL,
  FacID VARCHAR(10) NOT NULL,
  PRIMARY KEY (RecepID, FacID),
  FOREIGN KEY (RecepID) REFERENCES Receptionist(RecepID),
  FOREIGN KEY (FacID) REFERENCES Faculty(FacID)
);
GO

CREATE TABLE Assiss_Recep
(
  RecepID VARCHAR(10) NOT NULL,
  AssiID VARCHAR(10) NOT NULL,
  PRIMARY KEY (RecepID, AssiID),
  FOREIGN KEY (RecepID) REFERENCES Receptionist(RecepID),
  FOREIGN KEY (AssiID) REFERENCES Assisstant(AssiID)
);

CREATE TABLE Bill_Recep
(
  RecepID VARCHAR(10) NOT NULL,
  bilID VARCHAR(10) NOT NULL,
  PRIMARY KEY (RecepID, bilID),
  FOREIGN KEY (RecepID) REFERENCES Receptionist(RecepID),
  FOREIGN KEY (bilID) REFERENCES Bill(bilID)
);
GO

CREATE TABLE Patient_Recep
(
  PatID VARCHAR(10) NOT NULL,
  RecepID VARCHAR(10) NOT NULL,
  PRIMARY KEY (PatID, RecepID),
  FOREIGN KEY (PatID) REFERENCES Patient(PatID),
  FOREIGN KEY (RecepID) REFERENCES Receptionist(RecepID)
);
GO


CREATE TABLE Prescription
(
	PresID VARCHAR(10) PRIMARY KEY, 
	PatID VARCHAR(10) REFERENCES PATIENT(PatID),
	DenID VARCHAR(10) REFERENCES DENTIST(DenID),
	totalPrice INT NOT NULL
)
GO

CREATE TABLE Bill_Prescription
(
	BilID VARCHAR(10) REFERENCES Bill(bilId),
	PresID VARCHAR(10) REFERENCES Prescription(PresID)
)
GO


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

-- TAO TRIGGER
CREATE TRIGGER ADD_DENTIST
ON Dentist
AFTER INSERT
AS
BEGIN
	IF EXISTS (SELECT SALARY FROM INSERTED WHERE INSERTED.SALARY  < 0)
	BEGIN
		RAISERROR('Luong khong the la so am', 16, 1)
		ROLLBACK TRANSACTION;
	END
END
GO


CREATE TRIGGER ADD_Bill
ON Bill
AFTER INSERT
AS
BEGIN
	IF EXISTS (SELECT total_price FROM INSERTED WHERE INSERTED.total_price < 0)
	BEGIN
		RAISERROR('Tong gia khong the la so am', 16, 1)
		ROLLBACK TRANSACTION;
	END
END
GO

CREATE TRIGGER ADD_Bill_Service
ON Bill_Service
AFTER INSERT
AS
BEGIN
	(select b.bilid,'Total' = SUM(s.price ) into T
	from Bill_Service bs
	join bill b
	on b.bilid = bs.bilid
	join service s
	on s.serviceid = bs.serviceid
	group by b.bilid)

	UPDATE Bill 
	SET total_price = 
	case 
		when bill.bilid in (select bilid from T) then (select total  from T where Bill.bilid = T.bilid)
		else '0'
	end
	drop table T
END
GO

CREATE TRIGGER ADD_Service
ON Service
AFTER INSERT
AS
BEGIN
	IF EXISTS (SELECT price FROM INSERTED WHERE INSERTED.price < 0)
	BEGIN
		RAISERROR('Tong gia khong the la so am', 16, 1)
		ROLLBACK TRANSACTION;
	END
END
GO

CREATE TRIGGER ADD_Receptionist
ON Receptionist
AFTER INSERT
AS
BEGIN
	IF  NOT EXISTS(
		SELECT * FROM inserted
		WHERE inserted.AccountID IN (SELECT AccountID FROM Account)
	)
	BEGIN
		RAISERROR('Khoa ngoai chua ton tai', 16, 1)
		ROLLBACK TRANSACTION;
		RETURN
	END
	IF EXISTS (SELECT SALARY FROM INSERTED WHERE INSERTED.SALARY < 0)
	BEGIN
		RAISERROR('Luong khong the la so am', 16, 1)
		ROLLBACK TRANSACTION;
	END
END
GO

CREATE TRIGGER ADD_Assisstant
ON Assisstant
AFTER INSERT
AS
BEGIN
	IF EXISTS (SELECT SALARY FROM INSERTED WHERE INSERTED.SALARY  < 0)
	BEGIN
		RAISERROR('Luong khong the la so am', 16, 1)
		ROLLBACK TRANSACTION;
		RETURN
	END
END
GO


--STORE PROCEDURE
--Them du lieu
--Account
create proc procAddAccount
	@username NVARCHAR(50),
	@password NVARCHAR(50),
	@role CHAR(1)
as
begin
	begin 
		declare @AccID VARCHAR(10)
		set @AccID = dbo.autoAcid()
		insert into Account(AccountID, username, password,role)
		values (@AccID,@username,@password,@role)
	end
end 
go

--select * from Account

exec procAddAccount 'admin','123456','A'
exec procAddAccount 'recep1','23456432','B'
exec procAddAccount 'recep2','645343','B'
exec procAddAccount 'dentist1','12421424','C'
exec procAddAccount 'dentist2','124241321','C'
exec procAddAccount 'dentist3','124241321','C'
exec procAddAccount 'dentist4','124241321','C'
exec procAddAccount 'dentist5','124241321','C'
exec procAddAccount 'dentist6','124241321','C'
GO


-- Admin
create proc procAddAdmin
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@phone_number VARCHAR(15),
	@email VARCHAR(30),
	@gender bit,
	@birthday DATETIME,
	@AccountID VARCHAR(10)	
as
begin
	if(@AccountID not in (select AccountID from Account)) 
		print(N'Chưa tồn tại mã Account này')
	else
	begin
	declare @AdminID VARCHAR(10)
	set @AdminID = dbo.autoADid()
	insert into admin(AdminID, name, address, phone_number, email, gender, birthday,accountID) 
	values (@AdminID, @name, @address, @phone_number, @email, @gender, @birthday,@AccountID)
	end
end
go
--select * from admin

exec procAddAdmin N'Nguyễn Văn Lâm', N'quận 7', '0901827394', 'nguyenval@gmail.com', 1, '2003-02-01','AC00000001'
go

--Material

create proc procAddMaterial
	@name NVARCHAR(50),
	@adminID VARCHAR(10),
	@calUnit NVARCHAR(70),
	@quantity INT
as
begin
	if(@adminID not in (select AdminID from Admin)) 
		print(N'Chưa tồn tại mã Admin này')
	else
	begin 
		declare @MatID VARCHAR(10)
		set @MatID = dbo.autoMAid()
		insert into Material(materialID, name, adminID, CalUnit, quantity)
		values (@MatID,@name,@adminID,@calUnit,@quantity)
	end
end 
go 	
--select * from material
--Vật liệu cố định 
exec procAddMaterial N'Mũi cạo vôi', 'AD00000001', N'Cái', 10
exec procAddMaterial N'Kềm 150', 'AD00000001', N'Cái', 10
exec procAddMaterial N'Kềm 151', 'AD00000001', N'Cái', 10
exec procAddMaterial N'Kềm 50', 'AD00000001', N'Cái', 10
exec procAddMaterial N'Kềm 51', 'AD00000001', N'Cái', 10
exec procAddMaterial N'Nạy 1', 'AD00000001', N'Cái', 12
exec procAddMaterial N'Nạy 2', 'AD00000001', N'Cái', 12
exec procAddMaterial N'Nạy 3', 'AD00000001', N'Cái', 12
exec procAddMaterial N'Gương nha khoa', 'AD00000001', N'Cái', 6
exec procAddMaterial N'Thám trâm', 'AD00000001', N'Cái', 9
exec procAddMaterial N'Nạo ngà', 'AD00000001', N'Cái', 21
exec procAddMaterial N'Kẹp', 'AD00000001', N'Cái', 8
exec procAddMaterial N'Bay trám', 'AD00000001', N'Cái', 8
exec procAddMaterial N'Cây đo túi nú', 'AD00000001', N'Cái', 8
exec procAddMaterial N'Đèn quang trùng hợp', 'AD00000001', N'Cái', 8
exec procAddMaterial N'Ống chích sắt', 'AD00000001', N'Cái', 8

--Vật liệu tiêu hao
	--Không phải thuốc
		--Chữa răng
exec procAddMaterial N'Composite đặc màu A2', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite đặc màu A3', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite đặc màu A3.5', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite đặc màu A4', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite đặc màu ngà', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite đặc màu men tự nhiên', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu A2', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu A3', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu A3.5', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu A4', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu ngà', 'AD00000001', N'liều', 2
exec procAddMaterial N'Composite lỏng màu men tự nhiên', 'AD00000001', N'liều', 2
exec procAddMaterial N'Bonding', 'AD00000001', N'chai', 5
exec procAddMaterial N'Cọ bond', 'AD00000001', N'hộp', 5
exec procAddMaterial N'Bông gòn 1kg', 'AD00000001', N'cuộn', 50
exec procAddMaterial N'Mũi khoan kim cương', 'AD00000001', N'mũi', 5
		
		--Nội nha 
exec procAddMaterial N'Sealer trám bít', 'AD00000001', N'mũi', 5
exec procAddMaterial N'Cone giấy', 'AD00000001', N'hộp', 15
exec procAddMaterial N'Cone chính', 'AD00000001', N'hộp', 15
exec procAddMaterial N'NaOCL', 'AD00000001', N'hộp', 15
exec procAddMaterial N'Nacl', 'AD00000001', N'hộp', 15
exec procAddMaterial N'EDTA', 'AD00000001', N'hộp', 15
exec procAddMaterial N'Trâm tay', 'AD00000001', N'cây', 5
exec procAddMaterial N'Trâm máy', 'AD00000001', N'cây', 5
		
		--Nha chu
exec procAddMaterial N'Spongel', 'AD00000001', N'hộp', 5
exec procAddMaterial N'Mũi đánh bóng', 'AD00000001', N'cây', 40
exec procAddMaterial N'Chỗi đánh bóng', 'AD00000001', N'cây', 45
exec procAddMaterial N'Sò đánh bóng', 'AD00000001', N'hộp', 5

		--Nhổ răng
exec procAddMaterial N'Chỉ khâu', 'AD00000001', N'hộp', 45
exec procAddMaterial N'Thuốc tê', 'AD00000001', N'hộp', 65

		--Răng trẻ em
exec procAddMaterial N'Formolcoresol', 'AD00000001', N'hộp', 15
exec procAddMaterial N'ZnO', 'AD00000001', N'hộp', 6
exec procAddMaterial N'MTA', 'AD00000001', N'hộp', 5
exec procAddMaterial N'GIC', 'AD00000001', N'hộp', 5
exec procAddMaterial N'Trám tạm', 'AD00000001', N'hộp', 10


--Là thuốc
exec procAddMaterial N'Amoxicillin 500mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Amoxicillin 625mg', 'AD00000001', 'viên', 200
exec procAddMaterial N'Amoxicillin 875mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Amoxicillin 1000mg', 'AD00000001', 'viên', 200
exec procAddMaterial N'Metronidazole 200mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Metronidazole 500mg', 'AD00000001', 'viên', 200
exec procAddMaterial N'Cephalexin 500mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Paracetamol 500mg', 'AD00000001', 'viên', 200
exec procAddMaterial N'Aspirin 100mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Ibuprofen 400mg', 'AD00000001', 'viên', 200
exec procAddMaterial N'Naproxen 500mg', 'AD00000001', 'viên', 500
exec procAddMaterial N'Dexamethason 0.5mg', 'AD00000001', 'viên', 500


GO



--ConsumableMaterial
create proc procAddConsumableMaterial
	@materialID VARCHAR(10),
	@expiration_date DATETIME,
	@typeConMaterial NVARCHAR(40)
as
begin
	if(@materialID not in (select materialID from Material)) 
		print(N'Chưa tồn tại mã Material này')
	else
	begin 
		insert into ConsumableMaterial(materialID, expiration_date, typeConMaterial)
		values (@materialID,@expiration_date,@typeConMaterial)
	end
end
go



--select * from ConsumableMaterial
--Không là thuốc
exec procAddConsumableMaterial 'MA00000017', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000018', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000019', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000020', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000021', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000022', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000023', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000024', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000025', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000026', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000027', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000028', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000029', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000030', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000031', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000032', '2025-05-05 12:00', N'Chữa răng'
exec procAddConsumableMaterial 'MA00000033', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000034', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000035', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000036', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000037', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000038', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000039', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000040', '2025-05-05 12:00', N'Nội nha'
exec procAddConsumableMaterial 'MA00000041', '2025-05-05 12:00', N'Nha chu'
exec procAddConsumableMaterial 'MA00000042', '2025-05-05 12:00', N'Nha chu'
exec procAddConsumableMaterial 'MA00000043', '2025-05-05 12:00', N'Nha chu'
exec procAddConsumableMaterial 'MA00000044', '2025-05-05 12:00', N'Nha chu'
exec procAddConsumableMaterial 'MA00000045', '2025-05-05 12:00', N'Nhổ răng'
exec procAddConsumableMaterial 'MA00000046', '2025-05-05 12:00', N'Nhổ răng'
exec procAddConsumableMaterial 'MA00000047', '2025-05-05 12:00', N'Răng trẻ em'
exec procAddConsumableMaterial 'MA00000048', '2025-05-05 12:00', N'Răng trẻ em'
exec procAddConsumableMaterial 'MA00000049', '2025-05-05 12:00', N'Răng trẻ em'
exec procAddConsumableMaterial 'MA00000050', '2025-05-05 12:00', N'Răng trẻ em'
exec procAddConsumableMaterial 'MA00000051', '2025-05-05 12:00', N'Răng trẻ em'


--Thuốc
exec procAddConsumableMaterial 'MA00000052', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000053', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000054', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000055', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000056', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000057', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000058', '2025-05-05 12:00', N'Kháng sinh'
exec procAddConsumableMaterial 'MA00000059', '2025-05-05 12:00', N'Giảm đau'
exec procAddConsumableMaterial 'MA00000060', '2025-05-05 12:00', N'Giảm đau'
exec procAddConsumableMaterial 'MA00000061', '2025-05-05 12:00', N'Kháng viêm'
exec procAddConsumableMaterial 'MA00000062', '2025-05-05 12:00', N'Kháng viêm'
exec procAddConsumableMaterial 'MA00000063', '2025-05-05 12:00', N'Kháng viêm'
GO

create proc procAddMedicine
	@materialID VARCHAR(10),
	@price INT
as
begin
	if(@materialID not in (select materialID from ConsumableMaterial)) 
		print(N'Chưa tồn tại mã ConsumableMaterial này')
	else
	begin 
		insert into Medicine(materialID, price)
		values (@materialID,@price)
	end
end
go

exec procAddMedicine 'MA00000052', 1000
exec procAddMedicine 'MA00000053', 13000
exec procAddMedicine 'MA00000054', 6000
exec procAddMedicine 'MA00000055', 20000
exec procAddMedicine 'MA00000056', 2000
exec procAddMedicine 'MA00000057', 3000
exec procAddMedicine 'MA00000058', 1000
exec procAddMedicine 'MA00000059', 2000
exec procAddMedicine 'MA00000060', 6000
exec procAddMedicine 'MA00000061', 4000
exec procAddMedicine 'MA00000062', 5000
exec procAddMedicine 'MA00000063', 80000
go

--FixedMaterial
create proc procAddFixedMaterial
	@materialID VARCHAR(10)
as
begin
	if(@materialID not in (select materialID from Material)) 
		print(N'Chưa tồn tại mã Material này')
	else
	begin 
		insert into FixedMaterial(materialID)
		values (@materialID)
	end
end 
go
	
--select * from FixedMaterial

exec procAddFixedMaterial 'MA00000001'
exec procAddFixedMaterial 'MA00000002'
exec procAddFixedMaterial 'MA00000003'
exec procAddFixedMaterial 'MA00000004'
exec procAddFixedMaterial 'MA00000005'
exec procAddFixedMaterial 'MA00000006'
exec procAddFixedMaterial 'MA00000007'
exec procAddFixedMaterial 'MA00000008'
exec procAddFixedMaterial 'MA00000009'
exec procAddFixedMaterial 'MA00000010'
exec procAddFixedMaterial 'MA00000011'
exec procAddFixedMaterial 'MA00000012'
exec procAddFixedMaterial 'MA00000013'
exec procAddFixedMaterial 'MA00000014'
exec procAddFixedMaterial 'MA00000015'
exec procAddFixedMaterial 'MA00000016'
GO

--Receptionist
create proc procAddReceptionist
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@email NVARCHAR(50),
	@phone_number NVARCHAR(15),
	@salary INT,
	@gender BIT ,
	@birthday DATETIME,
	@AccountID VARCHAR(10)
as
begin
	if(@AccountID not in (select AccountID from Account)) 
		print(N'Chưa tồn tại mã Account này')
	else
	begin 
		declare @RecepID VARCHAR(10)
		set @RecepID = dbo.autoReid()
		insert into Receptionist(RecepID,name,address,email,phone_number,salary, gender, birthday, AccountID) 
		values (@RecepID,@name,@address,@email,@phone_number,@salary,@gender,@birthday,@AccountID)
	end
end 
go

--select * from Receptionist

exec procAddReceptionist N'Trần Văn Dũng', N'quận 2', 'tranvd@gmail.com', '0902837463',25000000, 1, '2003-01-02','AC00000002'
exec procAddReceptionist N'Hoàng Thị Trâm', N'quận 3', 'hoantm@gmail.com', '09023522126',27000000, 0, '2003-01-02','AC00000003'
GO

create proc procAddCalendar_Receptionist
	@RecepID VARCHAR(10),
	@dayWorks DATETIME,
	@timeStart DATETIME,
	@timeEnd DATETIME
as
begin
	if(@RecepID not in (select RecepID from Receptionist)) 
		print(N'Chưa tồn tại mã Receptionist này')
	else
	BEGIN
		insert into Calendar_Receptionist(RecepID,dayWorks,timeStart,timeEnd) 
		values (@RecepID, @dayWorks,@timeStart,@timeEnd)
	END
end
go

exec procAddCalendar_Receptionist 'RE00000001', '2024-04-10', '2024-04-10 01:00:00', '2024-04-10 11:00:00'
exec procAddCalendar_Receptionist 'RE00000002', '2024-04-10', '2024-04-10 01:00:00', '2024-04-10 11:00:00'
go


--Assisstant
create proc procAddAssisstant
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@email NVARCHAR(50),
	@phone_number NVARCHAR(15),
	@salary INT,
	@gender BIT,
	@birthday DATETIME 
as
begin
	declare @AssID VARCHAR(10)
	set @AssID = dbo.autoAsid()
	insert into Assisstant(AssiID,name,address,email,phone_number,salary, gender, birthday) 
	values (@AssID,@name,@address,@email,@phone_number,@salary,@gender,@birthday)
end 
go

--select * from Assisstant

exec procAddAssisstant N'Nguyễn Đình Toàn', N'quận 2', 'nguyendt@gmail.com','0902463245',10000000, 1, '2003-01-02'
exec procAddAssisstant N'Liêm Văn Chính', N'quận 3', 'lienvac@gmail.com', '09023515226',7000000, 1, '2003-01-02'
exec procAddAssisstant N'Nguyễn Hoài Thu', N'Gò Vấp', 'hoaithu12@gmail.com', '0902463628',20000000, 0, '2003-01-02'
exec procAddAssisstant N'Ngô Văn Trọng', N'Bến Tre', 'Ngovac@gmail.com', '09023515226',8000000, 1, '2003-01-02'
exec procAddAssisstant N'Bùi Tiến Dũng', N'Bình Định', 'btd@gmail.com', '0902463245',12000000, 1, '2003-01-02'
exec procAddAssisstant N'Watson Holmes', 'London', 'holmes221b@gmail.com', '09023515226',900000, 1, '2003-01-02'
GO

create proc procAddCalendar_Assisstant
	@AssID VARCHAR(10),
	@dayWorks DATETIME,
	@timeStart DATETIME,
	@timeEnd DATETIME
as
begin
	if(@AssID not in (select AssiID from Assisstant)) 
		print(N'Chưa tồn tại mã Assisstant này')
	else
	BEGIN
		insert into Calendar_Assisstant(AssiID,dayWorks,timeStart,timeEnd) 
		values (@AssID, @dayWorks,@timeStart,@timeEnd)
	END
end
go

exec procAddCalendar_Assisstant 'AS00000001', '2024-04-11', '2024-04-10 01:00:00', '2024-04-10 11:00:00'
exec procAddCalendar_Assisstant 'AS00000002', '2024-04-11', '2024-04-10 02:00:00', '2024-04-10 12:00:00'
go

--Faculty
create proc procAddFaculty	
	@name NVARCHAR(50)
as
begin
	declare @facID VARCHAR(10)
	set @facID = dbo.autoFaid()
	insert into Faculty (FacID,name)
	values (@facID,@name)
end 
go
--select * from Faculty

exec procAddFaculty 'Nha chu'
exec procAddFaculty N'Phục Hình'
exec procAddFaculty N'Răng trẻ em'
exec procAddFaculty N'Nhổ răng va tiểu phẩu'
exec procAddFaculty N'Chữa răng và nội nha'
exec procAddFaculty N'Tổng quát'
GO


--Dentist
create proc procAddDentist
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@email NVARCHAR(50),
	@phone_number NVARCHAR(15),
	@salary INT,
	@FacID VARCHAR(10),
	@title NVARCHAR(15),
	@rank NVARCHAR(20),
	@nation NVARCHAR(20),
	@gender BIT,
	@birthday DATETIME ,
	@AccountID VARCHAR(10)
as
begin
	if(@FacID not in (select FacID from Faculty)) 
		print(N'Chưa tồn tại mã Faculty này')
	else if(@AccountID not in (select AccountID from Account)) 
		print(N'Chưa tồn tại mã Account này')
	else
	begin 
		declare @DenID VARCHAR(10)
		set @DenID = dbo.autoDeid()
		insert into Dentist(DenID,name,address,email,phone_number,salary,FacID,title,rank,nation, gender, birthday,AccountID) 
		values (@DenID,@name,@address,@email,@phone_number,@salary,@FacID,@title,@rank,@nation,@gender,@birthday,@AccountID)
	end
end 
go

--select * from Dentist

exec procAddDentist N'Lâm Đình Kiêm', N'Tây Ninh', 'lamvak@gmail.com', '09023511284',9000000,'FA00000001','Thac si', 'A', 'Viet Nam', 1, '2003-01-02','AC00000004'
exec procAddDentist N'Hoa Hồ Quốc Đại', N'Kiên Giang', 'hoadai@gmail.com', '09092815226',8700000,'FA00000001','Tien si', 'B', 'Viet Nam', 1, '2003-01-02','AC00000005'
exec procAddDentist N'Bùi Xuân Huấn', N'Trá Vinh', 'buixhuan@gmail.com', '09062715226',8000000,'FA00000002','Thac si', 'C', 'Viet Nam', 1, '2003-01-02','AC00000006'
exec procAddDentist N'Linh Văn Sơn', N'Thanh Hoá', 'linhnui@gmail.com', '09028365226',8000000,'FA00000002','Tien si', 'C', 'Viet Nam', 1, '2003-01-02','AC00000007'
exec procAddDentist N'Tạ Triết', N'An Giang', 'tatriet16@gmail.com', '09024635226',9300000,'FA00000003','Thac si', 'A', 'Viet Nam', 1, '2003-01-02','AC00000008'
exec procAddDentist N'Hoa Yến Anh', N'Tân Biên', 'anhvippro@gmail.com', '09022915226',9400000,'FA00000003','Tien si', 'A', 'Viet Nam', 0, '2003-01-02','AC00000009'
GO

create proc procAddCalendar_Dentist
	@DenID VARCHAR(10),
	@dayWorks DATETIME,
	@timeStart DATETIME,
	@timeEnd DATETIME
as
begin
	if(@DenID not in (select DenID from Dentist)) 
		print(N'Chưa tồn tại mã Dentist này')
	else
	BEGIN
		insert into Calendar_Dentist(DenID,dayWorks,timeStart,timeEnd) 
		values (@DenID, @dayWorks,@timeStart,@timeEnd)
	END
end
go

exec procAddCalendar_Dentist 'DE00000001', '2024-04-11', '01:00:00', '2024-04-10 11:00:00'
exec procAddCalendar_Dentist 'DE00000002', '2024-04-11', '2024-04-10 02:00:00', '2024-04-10 12:00:00'
go

--select * from Calendar_Dentist

--Patient
create proc procAddPatient
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@email NVARCHAR(50),
	@number NVARCHAR(15),
	@gender BIT,
	@birthday DATETIME 
as
begin
	declare @PaID VARCHAR(10)
	set @PaID = dbo.autoPaid()
	insert into Patient(PatID,name,address,email,number, gender, birthday) 
	values (@PaID,@name,@address,@email,@number,@gender,@birthday)
end 
go

--select * from Patient

exec procAddPatient N'Bùi Thị Xuân', N'Đồng Nai', 'buitx@gmail.com', '09023512373', 0, '2003-01-02'
exec procAddPatient N'Trịnh Thị Hồng Phúc', N'Tây Ninh', 'hongphuccute@gmail.com', '0902383723', 0, '2003-01-02'
exec procAddPatient N'Đặng Văn Trọng', N'Tây Ninh', 'tronghaihai@gmail.com', '09023726373', 1, '2003-01-02'
exec procAddPatient N'Nguyễn Hoàng Anh Tuấn', N'Quảng Ninh', 'anhtuan22@gmail.com', '09023162573', 1, '2003-01-02'
exec procAddPatient N'Tạ Văn Lâm', N'Hà Giang', 'taval@gmail.com', '09023094573', 1, '2003-01-02'
exec procAddPatient N'Trần Văn Hiếu', N'An Giang', 'tranvh@gmail.com', '09023384273', 1, '2003-01-02'
GO

--Appointment
create proc procAddAppointment
	@ap_time DATETIME,
	@PatID VARCHAR(10),
	@DenID VARCHAR(10),
	@AssiID VARCHAR(10),
	@symptom NVARCHAR(150),
	@stateAp CHAR(1),
	@note NVARCHAR(170)
as
begin
	if(@PatID not in (select patID from Patient)) 
		print(N'Chưa tồn tại mã Patient này')
	else if(@DenID not in (select DenID from Dentist)) 
		print(N'Chưa tồn tại mã Dentist này')
	else if(@AssiID not in (select AssiID from Assisstant)) 
		print(N'Chưa tồn tại mã Assisstant này')
	else 
	begin
		declare @ApID VARCHAR(10)
		set @ApID = dbo.autoApid()
		set @ap_time = convert(datetime, @ap_time, 103)
		insert into Appointment(ApID,ap_time,PatID,DenID,AssiID,symptom,stateAp,note)
		values (@ApID,@ap_time,@PatID,@DenID,@AssiID,@symptom,@stateAp,@note)
	end
end 
go
--select * from Appointment

exec procAddAppointment '2024-03-05 12:00','PA00000001','DE00000001','AS00000001',N'đau răng cửa', 'B', N'bệnh nhân đang gấp'
exec procAddAppointment '2024-03-06 12:00','PA00000001','DE00000001','AS00000001',N'đau răng cửa', 'B', N'bệnh nhân khám lại'
exec procAddAppointment '2024-03-05 11:00','PA00000002','DE00000002','AS00000001',N'mất răng hàm', 'A', ''
exec procAddAppointment '2024-03-05 10:00','PA00000003','DE00000003','AS00000001',N'ê buốc răng', 'C' , ''
exec procAddAppointment '2024-03-06 13:00','PA00000004','DE00000004','AS00000001',N'đau ở chỗ răng khôn', 'A', ''
exec procAddAppointment '2024-03-06 15:00','PA00000005','DE00000005','AS00000001',N'lệch răng nghiêm trọng', 'B', ''
exec procAddAppointment '2024-03-06 16:00','PA00000006','DE00000006','AS00000001',N'lâu lâu bị nhói', 'C', ''
GO



--Service 

create proc procAddService
	@name NVARCHAR(100),
	@price INT,
	@CalUnit NVARCHAR(10),
	@quantity INT,
	@note NVARCHAR(70),
	@kindService NVARCHAR(60)
	
as
begin
	declare @SerID VARCHAR(10)
	set @SerID = dbo.autoSeid()
	insert into Service (serviceID,name, price,CalUnit,quantity,note,kindService) 
	values (@SerID,@name,@price,@CalUnit,@quantity,@note,@kindService)
end 
go

--select * from service

--1.Khám hồ sơ 
exec procAddService N'Khám bệnh',5000,N'Lượt',1,'',N'Khám-hồ sơ'
--2.Nhổ răng
exec procAddService N'Nhổ răng cửa, răng nanh', 50000,N'Cái',1,'', N'Nhổ răng'
exec procAddService N'Nhổ răng cối nhỏ',60000,N'Cái',1,'',N'Nhổ răng'
exec procAddService N'Nhổ răng cối lớn trên',70000,N'Cái',1,'',N'Nhổ răng'
exec procAddService N'Nhổ răng cối lớn dưới',90000,N'Cái',1,'',N'Nhổ răng'
exec procAddService N'Nhổ răng cối lung lay',50000,N'Cái',1,'',N'Nhổ răng'
exec procAddService N'Nhổ chân răng vĩnh viễn',60000,N'Cái',1,'',N'Nhổ răng'
exec procAddService N'Khâu ổ răng',50000,N'Cái',1,'',N'Nhổ răng'
--Tiểu phẫu thuật
exec procAddService N'Rằng khôn mọc lệch nhổ tiểu phẩu',300000,N'Cái',1,'',N'Tiểu phẩu thuật'
exec procAddService N'Phẫu thuật điều chỉnh xương ổ răng',200000,N'Cái',1,'',N'Tiểu phẩu thuật'
exec procAddService N'Phẩu thuật cắt chóp',300000,N'Cái',1,'',N'Tiểu phẩu thuật'
--3.Nha chu
exec procAddService N'Cạo vôi răng',50000,N'2 hàm',1,'','Nha chu'
exec procAddService N'Điều trị viêm nha chu không phẫu thuật',100000,N'Vùng hàm',1,N'Nạo túi nha chu','Nha chu'
exec procAddService N'Phẫu thuật lật vạt làm sạch',100000,N'Lần',1,'','Nha chu'
exec procAddService N'Cắt thắng',100000,N'Lần',1,'','Nha chu'
exec procAddService N'Phẫu thuật nướu',500000,N'Răng',1,'','Nha chu'
--4.Chữa răng-Nội nha
exec procAddService N'Tái tạo thân răng', 150000, N'Xoang', 1, '', N'Chữa răng-Nội nha'
exec procAddService N'Trám composite xoang I, III', 100000, 'Xoang', 1, '', N'Chữa răng-Nội nha'
exec procAddService N'Trám composite xoang II, IV, V', 120000, 'Xoang', 1, '', N'Chữa răng-Nội nha'
exec procAddService N'Trám GIC', 100000, N'Xoang', 1, '', N'Chữa răng-Nội nha'
exec procAddService N'Trám đắp mặt, hở kẽ', 200000, N'Cái', 1, '', N'Chữa răng-Nội nha'
exec procAddService N'Trám phòng ngừa', 80000, N'Cái', 1, '', N'Chữa răng-Nội nha'
--Chữa tủy
exec procAddService N'Răng cửa, răng nanh', 250000,N'Cái',1,'', N'chữa tủy'
exec procAddService N'Răng cối nhỏ',300000,N'Cái',1,'',N'chữa tủy'
exec procAddService N'Răng cối lớn',60000,N'Cái',1,'',N'chữa tủy'
exec procAddService N'Chữa tủy lại(đóng thêm)',60000,N'Ống tủy',1,'',N'chữa tủy'
--Phục hình tháo lắp
exec procAddService N'Phục hình tháo lắp 1 răng', 100000, N'Răng', 1, N'', N'Phục hình tháo lắp'
exec procAddService N'Phục hình tháo lắp 1 hàm toàn hàm', 1500000, N'Hàm', 1, N'', N'Phục hình tháo lắp'
exec procAddService N'Phục hình tháo lắp 2 hàm toàn hàm', 3000000, N'Hàm', 1, N'', N'Phục hình tháo lắp'
--Sữa chữa hàm
exec procAddService N'Vá hàm', 100000, N'Hàm', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Thay nền', 300000, N'Hàm', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Đệm hàm nhựa nấu', 250000, N'Hàm', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Thêm, thay móc', 50000, N'Cái', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Thêm, thay răng', 50000, N'Cái', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Chữa đau', 50000, N'Lần', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Móc dẻo', 200000, N'Cái', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Hàm dẻo', 700000, N'Cái', 1, N'', N'Sửa chữa hàm'
exec procAddService N'Hàm khung bộ ', 750000, N'Cái', 1, N'Răng tính riêng', N'Sửa chữa hàm'
--Điều trị tiền phục hình
exec procAddService N'Đệm hàm nhựa tự cứng (Hàm cũ)', 100000, N'Hàm', 1, N'', N'Điều trị tiền phục hình'
exec procAddService N'Điều chỉnh khớp cắn (Hàm cũ)', 100000, N'Hàm', 1, N'', N'Điều trị tiền phục hình'

--6.Phục hình cố định
exec procAddService N'Tái tạo cùi răng (có chốt)', 150000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Mão, cầu răng kim loại toàn diện', 350000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Mão, cầu răng kim loại-sứ', 500000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Sứ titan', 700000, N'', 1, N'', N'Phục hình cố định'
exec procAddService N'Hàm khung Ti (chưa bao gồm răng)', 1500000, N'', 1, N'', N'Phục hình cố định'
exec procAddService N'Sứ zirconia', 2500000, N'', 1, N'', N'Phục hình cố định'
exec procAddService N'Sứ cercon', 3500000, N'', 1, N'', N'Phục hình cố định'
exec procAddService N'Điều chỉnh, gắn lại, tháo PHCĐ', 100000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Hàm tạm', 50000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Mão tạm', 15000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Cầu răng tạm', 15000, N'Răng', 1, N'', N'Phục hình cố định'
exec procAddService N'Cùi giá đúc', 100000, N'Cái', 1, N'', N'Phục hình cố định'

--7.Điều trị răng sữa
exec procAddService N'Nhổ răng sữa(tê bôi)',20000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Nhổ răng sữa(tê chích)',50000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Trám răng sữa bằng GIC',50000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Trám răng sữa bằng composite',80000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Trám dự phòng hố rãnh mặt nhai',80000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Đặt gel Fluor phòng ngừa',50000, N'Hàm',1,'',N'Điều trị răng sữa'
exec procAddService N'Lấy tủy chân răng sữa',200000, N'Răng',1,'2 phim',N'Điều trị răng sữa'
exec procAddService N'Mão nhựa răng cửa (Strip crown)',200000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Mão kim loại làm sẵn',250000, N'Răng',1,'',N'Điều trị răng sữa'
exec procAddService N'Bộ giữ khoảng tháo lắp',250000, N'Hàm',1,'',N'Điều trị răng sữa'
exec procAddService N'Giữ khoảng cố định 1 bên',400000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Bộ giữ khoảng cố định 2 bên',800000, N'Bộ',1,'',N'Điều trị răng sữa'
exec procAddService N'Mặt phẳng nghiêng',500000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Tấm chặn môi',500000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Khí cụ đẩy môi (lip bumper)',1000000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Khí cụ tháo lắp điều trị cắn chéo l răng',1000000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Khí cụ Quad Helix',1000000, N'Cái',1,'',N'Điều trị răng sữa'
exec procAddService N'Tiểu phẫu',250000, N'Lần',1,'', N'Điều trị răng sữa'

--8.Chỉnh hình răng mặt
--Khí cụ tháo lắp
exec procAddService N'Khí cụ tháo lắp 1 hàm',1500000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ tháo lắp 2 hàm',3000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Làm lại khí cụ tháo lắp 1 hàm',300000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Làm lại khí cụ tháo lắp 2 hàm',600000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ duy trì kết quả 1 hàm',300000, N'Hàm',1,'Khí cụ tháo lắp',N'Chỉnh hình răng mặt'
--Khí cụ cố định
exec procAddService N'Khí cụ cố định 1 hàm',10000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ cố định 2 hàm',20000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ cố định 2 hàm trên 2 năm',26000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ cố định 2 hàm sử dụng mắc cài thế hệ mới',28000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'
exec procAddService N'Khí cụ cố định 2 hàm sử dụng mắc cài sứ',15000000, N'Hàm',1,'',N'Chỉnh hình răng mặt'

--9.Nha công cộng
exec procAddService N'Máng Fluor không thuốc', 100000, N'Máng', 1, N'2 hàm', N'Nha công cộng'

--10.Điều trị loạn năng hệ thống nhai
exec procAddService N'1 máng nhai', 500000, N'Máng', 1, N'', N'Điều trị loạn năng hệ thống nhai'
exec procAddService N'Mài chỉnh khớp cắn đơn giản', 150000, N'Lần', 1, N'', N'Điều trị loạn năng hệ thống nhai'
exec procAddService N'Mài chỉnh khớp cắn phức tạp', 300000, N'Lần', 1, N'', N'Điều trị loạn năng hệ thống nhai'
--11.X-quang răng
exec procAddService N'Phim quanh chóp', 30000, N'Phim', 1, N'', N'X-quang răng'
exec procAddService N'Phim toàn cảnh', 100000, N'Phim', 1, N'', N'X-quang răng'


--Phục hình đơn lẻ
--{
--Răng sứ dán
exec procAddService N'Răng sứ dán kim loại', 1500000,N'Hàm',1,'',N'Răng sứ dán'
exec procAddService N'Răng sứ dán Titan', 3000000,N'Hàm',1,'',N'Răng sứ dán'
exec procAddService N'Răng sứ dán Zirco', 6000000,N'Hàm',1,'',N'Răng sứ dán'
exec procAddService N'Răng sứ dán Bio HPP', 8000000,N'Hàm',1,'',N'Răng sứ dán'
--Giá răng sứ bắt vít trên Multi Unit gồm 2 khoản sau cộng lại:***
exec procAddService N'Trụ phục hình Multi Unit', 1500000,N'Hàm',1,'',N'Răng sứ dán'
--exec procAddService N'Răng sứ(Kim loại, Titan, Zirco, Bio HPP)', 1500000,N'Hàm',1,'',N'Răng sứ dán'
--}

--Phục Hình bắt vít 
--{
--Hàm phủ tháo lắp
exec procAddService N'Hàm phủ tháo lắp 2 Implant', 70000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 3 Implant thanh bar', 75000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 4 Implant thanh bar', 80000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 5 Implant thanh bar', 90000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 6 Implant thanh bar', 100000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 3 Implant nút bấm', 75000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 4 Implant nút bấm', 80000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 5 Implant nút bấm', 90000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'
exec procAddService N'Hàm phủ tháo lắp 6 Implant nút bấm', 100000000,N'Hàm',1,N'Răng composite nền nhựa cường lực',N'Hàm phủ tháo lắp'

--Hàm cố định 
exec procAddService N'Hàm cố định bắ vítt 4 Implant Sườn Titan răng nhựa', 70000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 4 Implant Sườn Titan răng sứa', 150000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 4 Implant Sườn Zirco răng nhựa', 110000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 4 Implant Sườn Zirco răng sứa', 190000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 4 Implant Sườn Bio HPP răng nhựa', 110000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 4 Implant Sườn Bio HPP răng sứa', 190000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'

exec procAddService N'Hàm cố định bắt vít 5 Implant', 14000000,N'Phục hình',1,'',N'Hàm cố định bắt vít'

exec procAddService N'Hàm cố định bắT vít 6 Implant Sườn Titan răng nhựa', 90000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 6 Implant Sườn Titan răng sứa', 170000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 6 Implant Sườn Zirco răng nhựa', 130000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 6 Implant Sườn Zirco răng sứa', 210000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 6 Implant Sườn Bio HPP răng nhựa', 130000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
exec procAddService N'Hàm cố định bắt vít 6 Implant Sườn Bio HPP răng sứa', 210000000,N'Hàm',1,'HYBRID',N'Hàm cố định bắt vít'
--}
--Phục hình tạm tức thì toàn hàm
exec procAddService N'Răng tạm toàn hàm', 20000000,N'Hàm',1,'',N'Phục hình tạm tức thì toàn hàm'
exec procAddService N'Cylinder', 4000000,N'Hàm',1,'',N'Phục hình tạm tức thì toàn hàm'

--Cấy ghép 1 trụ Implant
exec procAddService N'OSSTEM(KOREA)', 15000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'RITTER', 20000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'SIC(SWISS/GERMANY)', 20000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'NOBEL BIOCARE (USA/SWEDEN)', 24000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'NOBEL ACTIVE/PARALLEL (USA/SWEDEN)', 29000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'STRAUMANN SLActive (SWISS)', 32000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'NOBEL TiUltra-ACTIVE/PARALLEL-(USA/SWEDEN)', 32000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'STRAUMANN BLX (SWISS)', 35000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'
exec procAddService N'Implant Zygoma NOBEL (USA)', 50000000,N'1 trụ Implant',1,'',N'Cấy ghép 1 trụ Implant'

-- Màng, xương tổng hợp
exec procAddService N'Xương khử khoáng', 5000000, N'Đơn vị', 1, N'', N'Màng, xương tổng hợp'
exec procAddService N'Màng Collagen 15x20mm', 4000000, N'Đơn vị', 1, N'', N'Màng, xương tổng hợp'
exec procAddService N'Màng Collagen 20x30mm', 5000000, N'Đơn vị', 1, N'', N'Màng, xương tổng hợp'
exec procAddService N'Màng Collagen 30x40mm', 7000000, N'Đơn vị', 1, N'', N'Màng, xương tổng hợp'
exec procAddService N'Màng Titan, PTFE', 6000000, N'Đơn vị', 1, N'', N'Màng, xương tổng hợp'
exec procAddService N'Vít (Tack) neo xương, màng', 600000, N'Con', 1, N'', N'Màng, xương tổng hợp'

-- Màng, xương tự thân
exec procAddService N'Ghép xương tự thân', 6000000, N'Đơn vị *', 1, N'', N'Màng, xương tự thân'
exec procAddService N'Mô liên kết', 5000000, N'Đơn vị *', 1, N'', N'Màng, xương tự thân'
exec procAddService N'Màng PRP (tự thân)', 5000000, N'Đơn vị', 1, N'', N'Màng, xương tự thân'
exec procAddService N'Ghép xương mào chậu', 20000000, N'', 1, N'', N'Màng, xương tự thân'

-- Nâng xoang
exec procAddService N'Nâng xoang kín', 4000000, N'Đơn vị', 1, N'Không bao gồm xương và màng', N'Nâng xoang'
exec procAddService N'Nâng xoang hở', 6000000, N'Đơn vị', 1, N'Không bao gồm xương và màng', N'Nâng xoang'

-- Chụp CT CONE BEAM
exec procAddService N'Chụp CT Cone Beam 1 hàm', 550000, N'Đơn vị *', 1, N'', N'Chụp CT CONE BEAM'
exec procAddService N'Chụp CT Cone Beam 2 hàm', 900000, N'Đơn vị *', 1, N'', N'Chụp CT CONE BEAM'

--Máng Hướng Dẫn / in Sọ Mặt
exec procAddService N'Máng hướng dẫn', 3300000, N'Răng', 1, N'', N'Máng Hướng Dẫn / in Sọ Mặt'
exec procAddService N'In sọ mặt', 700000, N'Đơn vị', 1, N'', N'Máng Hướng Dẫn / in Sọ Mặt'


GO

--Bill 

create proc procAddBill
	@total_price INT,
	@payment_time DATETIME,
	@PatID VARCHAR(10)
as
begin
	if(@PatID not in (select PatID from Patient)) 
		print(N'Chưa tồn tại mã Patient này')
	else
	begin
		declare @BillID VARCHAR(10)
		set @BillID = dbo.autoBiid()
		insert into Bill(bilID,total_price,payment_time,PatID)
		values (@BillID,@total_price,@payment_time,@PatID)
	end
end 
go

--select * from bill
exec procAddBill 0, '2024-03-05 13:00','PA00000001'
exec procAddBill 0, '2024-03-05 12:00','PA00000002'
exec procAddBill 0, '2024-03-05 11:00','PA00000003'
exec procAddBill 0, '2024-03-06 14:00','PA00000004'
exec procAddBill 0, '2024-03-06 16:00','PA00000005'
exec procAddBill 0, '2024-03-06 17:00','PA00000006'
GO


--Bill_Service
create proc procAddBill_Service
	@serviceID VARCHAR(10),
	@bilID VARCHAR(10),
	@quantity INT
as
begin
	if(@serviceID not in (select serviceID from Service)) 
		print(N'Chưa tồn tại mã Service này')
	else if(@bilID not in (select bilID from Bill)) 
		print(N'Chưa tồn tại mã Bill này')
	else
	begin
		insert into Bill_Service (serviceID, bilID, quantity)
		values (@serviceID,@bilID, @quantity)
	end
end 
go

--select * from Bill_Service

exec procAddBill_Service 'SE00000001','BI00000001', 1
exec procAddBill_Service 'SE00000002','BI00000001', 1
exec procAddBill_Service 'SE00000001','BI00000002', 1
exec procAddBill_Service 'SE00000003','BI00000003', 1
exec procAddBill_Service 'SE00000004','BI00000003', 1
exec procAddBill_Service 'SE00000003','BI00000004', 1
GO

--Bill_Recep
create proc procAddBill_Recep
	@billID VARCHAR(10),
	@RecepID VARCHAR(10)
as
begin
	if(@RecepID not in (select RecepID from Receptionist)) 
		print(N'Chưa tồn tại mã Receptionist này')
	else if(@billID not in (select bilID from Bill)) 
		print(N'Chưa tồn tại mã Service này')
	else
	begin
		insert into Bill_Recep (RecepID, bilID)
		values (@RecepID,@billID)
	end
end 
go

--select * from Bill_Recep


exec procAddBill_Recep 'BI00000001','RE00000001'
exec procAddBill_Recep 'BI00000002','RE00000001'
exec procAddBill_Recep 'BI00000003','RE00000001'
exec procAddBill_Recep 'BI00000004','RE00000002'
exec procAddBill_Recep 'BI00000005','RE00000002'
exec procAddBill_Recep 'BI00000006','RE00000002'
GO

--Patient_Recep
create proc procAddPatient_Recep
	@PatID VARCHAR(10),
	@RecepID VARCHAR(10)
as
begin
	if(@RecepID not in (select RecepID from Receptionist)) 
		print(N'Chưa tồn tại mã Receptionist này')
	else if(@PatID not in (select PatID from Patient)) 
		print(N'Chưa tồn tại mã Patient này')
	else
	begin
		insert into Patient_Recep (RecepID, PatID)
		values (@RecepID,@PatID)
	end
end 
go
--select * from Patient_Recep


exec procAddPatient_Recep  'PA00000001','RE00000001'
exec procAddPatient_Recep  'PA00000002','RE00000001'
exec procAddPatient_Recep  'PA00000003','RE00000001'
exec procAddPatient_Recep  'PA00000004','RE00000002'
exec procAddPatient_Recep  'PA00000005','RE00000002'
exec procAddPatient_Recep  'PA00000006','RE00000002'
GO

--Faculty_Recep
create proc procAddFaculty_Recep
	@FacID VARCHAR(10),
	@RecepID VARCHAR(10)
as
begin
	if(@RecepID not in (select RecepID from Receptionist)) 
		print(N'Chưa tồn tại mã Receptionist này')
	else if(@FacID not in (select FacID from Faculty)) 
		print(N'Chưa tồn tại mã Faculty này')
	else
	begin
		insert into Faculty_Recep (FacID, RecepID)
		values (@FacID,@RecepID)
	end
end 
go
--select * from Faculty_Recep 


exec procAddFaculty_Recep 'FA00000001','RE00000001'
exec procAddFaculty_Recep 'FA00000002','RE00000001'
exec procAddFaculty_Recep 'FA00000003','RE00000001'
GO

--Assiss_Recep
create proc procAddAssiss_Recep
	@AssiID VARCHAR(10),
	@RecepID VARCHAR(10)
as
begin
	if(@RecepID not in (select RecepID from Receptionist)) 
		print(N'Chưa tồn tại mã Receptionist này')
	else if(@AssiID not in (select AssiID from Assisstant)) 
		print(N'Chưa tồn tại mã Assisstant này')
	else
	begin
		insert into Assiss_Recep (AssiID, RecepID)
		values (@AssiID,@RecepID)
	end
end 
go

--select * from Assiss_Recep


exec procAddAssiss_Recep 'AS00000001','RE00000001'
exec procAddAssiss_Recep 'AS00000002','RE00000001'
exec procAddAssiss_Recep 'AS00000003','RE00000001'
exec procAddAssiss_Recep 'AS00000004','RE00000002'
exec procAddAssiss_Recep 'AS00000005','RE00000002'
exec procAddAssiss_Recep 'AS00000006','RE00000002'
GO

INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000001', 'DE00000001', 150000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000002', 'DE00000001', 250000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000003', 'DE00000002', 350000)
INSERT INTO Prescription(PresID, PatID, DenID, totalPrice) values (dbo.autoPresid(), 'PA00000004', 'DE00000002', 400000)
GO

INSERT INTO Bill_Prescription(BilID, PresID) values 
('BI00000001', 'PR00000001'),
('BI00000002', 'PR00000002'),
('BI00000003', 'PR00000003'),
('BI00000004', 'PR00000004')
GO

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
GO

--chuc nang truy van

--Luong lon nhat nho nhat
--Nha_si
create proc MaxSalaryOfDentist
as
begin
	select *
	from dentist
	where salary = (select max(salary) from dentist)
end
go

/*
exec MaxSalaryOfDentist 
GO
*/

create proc MinSalaryOfDentist
as
begin
	select *
	from dentist
	where salary = (select min(salary) from dentist)
end
go

/*
exec MinSalaryOfDentist 
GO
*/

--Le_Tan
create proc MaxSalaryOfRecep
as
begin
	select *
	from Receptionist
	where salary = (select max(salary) from Receptionist)
end
go

/*
exec MaxSalaryOfRecep 
GO
*/

create proc MinSalaryOfRecep
as
begin
	select *
	from Receptionist
	where salary = (select min(salary) from Receptionist)
end
go

/*
exec MinSalaryOfRecep 
GO
*/

--Phu_Ta
create proc MaxSalaryOfAss
as
begin
	select *
	from Assisstant
	where salary = (select max(salary) from Assisstant)
end
go

/*
exec MaxSalaryOfAss
GO
*/

create proc MinSalaryOfAss
as
begin
	select *
	from Assisstant
	where salary = (select min(salary) from Assisstant)
end
go

/*
exec MinSalaryOfAss 
GO
*/

--Hoa_don
create proc MaxPriceOfBill
as
begin
	select *
	from Bill
	where total_price  = (select max(total_price ) from Bill)
end
go

/*
exec MaxPriceOfBill
GO
*/

create proc MinPriceOfBill
as
begin
	select *
	from Bill
	where total_price  = (select min(total_price) from Bill)
end
go

/*
exec MinPriceOfBill
GO
*/

--function lay id nha si dang cham soc cho benh nhan
create function GetDentistByPat (@PatID NVARCHAR(10))
returns VARCHAR(10) as
begin
	declare @denID VARCHAR(10)
	set @denID = 
	(select DenID
	from Appointment
	where ApID=(select TOP 1 ApID 
	from Appointment
	where PatID = @PatID and able = 1
	order by ApID desc ) and able = 1)
	return @denID
end
go

--Cac benh nhan duoc quan li boi nha si (nhap id bac si)
create proc PatientListByDentistID @denID NVARCHAR(10)
as
begin
	select *
	from Patient
	where patID in 
	(select patID
	from Appointment
	where denId = @denID and able = 1)
	and dbo.GetDentistByPat(PatID) = @denID
end
go

/*
exec PatientListByDentistID 'DE00000001'
GO
*/

--Tim nha si bang id cua benh nhan
create proc GetDentistByPatID @PatID NVARCHAR(10)
as 
begin
	select *
	from Dentist
	where DenID = dbo.GetDentistByPat(@PatID)
end
GO

/*
exec GetDentistByPatID 'PA00000001' 
GO
*/

CREATE FUNCTION CalculateDailyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT CONVERT(date, payment_time) AS payment_date, SUM(total_price) AS daily_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY CONVERT(date, payment_time)
)
GO


CREATE FUNCTION CalculateMonthlyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT DATEFROMPARTS(YEAR(payment_time), MONTH(payment_time), 1) AS payment_month, SUM(total_price) AS monthly_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY YEAR(payment_time), MONTH(payment_time)
)
GO

CREATE FUNCTION CalculateYearlyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT YEAR(payment_time) AS payment_year, SUM(total_price) AS yearly_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY YEAR(payment_time)
)
GO

CREATE FUNCTION CalculateQuarterlyRevenue (@dateFrom DATETIME, @dateTo DATETIME)
RETURNS @QuarterlyRevenue TABLE (
    payment_year INT,
    payment_quarter INT,
    quarterly_revenue DECIMAL(18, 2)
)
AS
BEGIN
    INSERT INTO @QuarterlyRevenue (payment_year, payment_quarter, quarterly_revenue)
    SELECT
        DATEPART(year, payment_time) AS payment_year,
        DATEPART(quarter, payment_time) AS payment_quarter,
        SUM(total_price) AS quarterly_revenue
    FROM
        Bill
    WHERE
        payment_time BETWEEN @dateFrom AND @dateTo
    GROUP BY
        DATEPART(year, payment_time),
        DATEPART(quarter, payment_time)
    ORDER BY
        payment_year, payment_quarter;

    RETURN;
END;