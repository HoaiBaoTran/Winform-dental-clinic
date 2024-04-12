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

-- Tao function chay function truoc khi chay bang

CREATE TABLE Admin
(
  AdminID VARCHAR(10) PRIMARY KEY,
  name NVARCHAR(50) NOT NULL,
  address NVARCHAR(80) NOT NULL,
  phone_number NVARCHAR(15) NOT NULL,
  email NVARCHAR(30) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL
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
  email NVARCHAR(50) NOT NULL,
  phone_number NVARCHAR(15) NOT NULL,
  RecepID VARCHAR(10) PRIMARY KEY,
  salary INT NOT NULL,
  AdminID VARCHAR(10) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL,
  FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
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
  email NVARCHAR(50) NOT NULL,
  phone_number NVARCHAR(15) NOT NULL,
  name NVARCHAR(50) NOT NULL,
  title NVARCHAR(15) NOT NULL,
  rank NVARCHAR(20) NOT NULL,
  nation NVARCHAR(20) NOT NULL,
  salary INT NOT NULL,
  FacID VARCHAR(10) NOT NULL,
  gender BIT NOT NULL,
  birthday DATETIME NOT NULL,
  FOREIGN KEY (FacID) REFERENCES Faculty(FacID)
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


CREATE TABLE Account
(
  able BIT DEFAULT 1 NOT NULL,
  AccountID VARCHAR(10) PRIMARY KEY,
  username NVARCHAR(50) NOT NULL UNIQUE,
  password NVARCHAR(50) NOT NULL,
  role CHAR(1) NOT NULL CHECK (role in ('A','B','C')), -- A la Quan li, B Le tan, C la Nha si
  AdminID VARCHAR(10) NOT NULL,
  FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
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
  able BIT DEFAULT 1 NOT NULL,
  symptom NVARCHAR(150) NOT NULL,
  stateAp CHAR(1) CHECK (stateAp IN ('A', 'B', 'C')) NOT NULL,
  FOREIGN KEY (PatID) REFERENCES Patient(PatID),
  FOREIGN KEY (DenID) REFERENCES Dentist(DenID)
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
  name NVARCHAR(50) NOT NULL,
  price INT NOT NULL,
  CalUnit NVARCHAR(10) NOT NULL,
  quantity INT NOT NULL,
  note NVARCHAR(70)NOT NULL
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
		WHERE inserted.AdminID IN (SELECT AdminID FROM Admin)
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
-- Admin
create proc procAddAdmin
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@phone_number VARCHAR(15),
	@email VARCHAR(30),
	@gender bit,
	@birthday DATETIME 
as
begin
	declare @AdminID VARCHAR(10)
	set @AdminID = dbo.autoADid()
	insert into admin(AdminID, name, address, phone_number, email, gender, birthday) 
	values (@AdminID, @name, @address, @phone_number, @email, @gender, @birthday)
	
end
go
--select * from admin

exec procAddAdmin N'Nguyễn Văn Lâm', N'quận 7', '0901827394', 'nguyenval@gmail.com', 1, '2003-02-01'
go


--Account
create proc procAddAccount
	@username NVARCHAR(50),
	@password NVARCHAR(50),
	@role CHAR(1),
	@AdminID VARCHAR(10) 
as
begin
	if(@adminID not in (select AdminID from Admin)) 
		print(N'Chưa tồn tại mã Admin này')
	else
	begin 
		declare @AccID VARCHAR(10)
		set @AccID = dbo.autoAcid()
		insert into Account(AccountID, username, password,role,AdminID)
		values (@AccID,@username,@password,@role,@AdminID)
	end
end 
go

--select * from Account

exec procAddAccount 'adminDayNeds','123456789','A','AD00000001'
exec procAddAccount 'recep1','23456432','B','AD00000001'
exec procAddAccount 'recep2','645343','B','AD00000001'
exec procAddAccount 'nhasi1','12421424','C','AD00000001'
exec procAddAccount 'nhasi2','124241321','C','AD00000001'
GO

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
GO

--Receptionist
create proc procAddReceptionist
	@name NVARCHAR(50),
	@address NVARCHAR(80),
	@email NVARCHAR(50),
	@phone_number NVARCHAR(15),
	@salary INT,
	@AdminID VARCHAR(10) ,
	@gender BIT ,
	@birthday DATETIME 
as
begin
	if(@AdminID not in (select AdminID from Admin)) 
		print(N'Chưa tồn tại mã Admin này')
	else
	begin 
		declare @RecepID VARCHAR(10)
		set @RecepID = dbo.autoReid()
		insert into Receptionist(RecepID,name,address,email,phone_number,salary,adminId, gender, birthday) 
		values (@RecepID,@name,@address,@email,@phone_number,@salary,@adminID,@gender,@birthday)
	end
end 
go

--select * from Receptionist

exec procAddReceptionist N'Trần Văn Dũng', N'quận 2', 'tranvd@gmail.com', '0902837463',25000000,'AD00000001', 1, '2003-01-02'
exec procAddReceptionist N'Hoàng Thị Trâm', N'quận 3', 'hoantm@gmail.com', '09023522126',27000000,'AD00000001', 0, '2003-01-02'
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
exec procAddFaculty 'Phuc hinh'
exec procAddFaculty 'Rang tre em'
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
	@birthday DATETIME 
as
begin
	if(@FacID not in (select FacID from Faculty)) 
		print(N'Chưa tồn tại mã Faculty này')
	else
	begin 
		declare @DenID VARCHAR(10)
		set @DenID = dbo.autoDeid()
		insert into Dentist(DenID,name,address,email,phone_number,salary,FacID,title,rank,nation, gender, birthday) 
		values (@DenID,@name,@address,@email,@phone_number,@salary,@FacID,@title,@title,@nation,@gender,@birthday)
	end
end 
go

--select * from Dentist

exec procAddDentist N'Lâm Đình Kiêm', N'Tây Ninh', 'lamvak@gmail.com', '09023511284',9000000,'FA00000001','Thac si', 'A', 'Viet Nam', 1, '2003-01-02'
exec procAddDentist N'Hoa Hồ Quốc Đại', N'Kiên Giang', 'hoadai@gmail.com', '09092815226',8700000,'FA00000001','Tien si', 'B', 'Viet Nam', 1, '2003-01-02'
exec procAddDentist N'Bùi Xuân Huấn', N'Trá Vinh', 'buixhuan@gmail.com', '09062715226',8000000,'FA00000002','Thac si', 'C', 'Viet Nam', 1, '2003-01-02'
exec procAddDentist N'Linh Văn Sơn', N'Thanh Hoá', 'linhnui@gmail.com', '09028365226',8000000,'FA00000002','Tien si', 'C', 'Viet Nam', 1, '2003-01-02'
exec procAddDentist N'Phan Văn Toàn', N'Hải Phòng', 'phanvt@gmail.com', '09024635226',9300000,'FA00000003','Thac si', 'A', 'Viet Nam', 1, '2003-01-02'
exec procAddDentist N'Hoa Yến Anh', N'Tân Biên', 'anhvippro@gmail.com', '09022915226',9400000,'FA00000003','Tien si', 'A', 'Viet Nam', 0, '2003-01-02'
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

exec procAddCalendar_Dentist 'DE00000001', '2024-04-11', '2024-04-10 01:00:00', '2024-04-10 11:00:00'
exec procAddCalendar_Dentist 'DE00000002', '2024-04-11', '2024-04-10 02:00:00', '2024-04-10 12:00:00'
go

select * from Calendar_Dentist

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
	@symptom NVARCHAR(150),
	@stateAp CHAR(1)
as
begin
	if(@PatID not in (select patID from Patient)) 
		print(N'Chưa tồn tại mã Patient này')
	else if(@DenID not in (select DenID from Dentist)) 
		print(N'Chưa tồn tại mã Dentist này')
	else 
	begin
		declare @ApID VARCHAR(10)
		set @ApID = dbo.autoApid()
		set @ap_time = convert(datetime, @ap_time, 103)
		insert into Appointment(ApID,ap_time,PatID,DenID,symptom,stateAp)
		values (@ApID,@ap_time,@PatID,@DenID,@symptom,@stateAp)
	end
end 
go
--select * from Appointment

exec procAddAppointment '2024-03-05 12:00','PA00000001','DE00000001',N'đau răng cửa', 'B'
exec procAddAppointment '2024-03-06 12:00','PA00000001','DE00000001',N'đau răng cửa', 'B'
exec procAddAppointment '2024-03-05 11:00','PA00000002','DE00000002',N'mất răng hàm', 'A'
exec procAddAppointment '2024-03-05 10:00','PA00000003','DE00000003',N'ê buốc răng', 'C'
exec procAddAppointment '2024-03-06 13:00','PA00000004','DE00000004',N'đau ở chỗ răng khôn', 'A'
exec procAddAppointment '2024-03-06 15:00','PA00000005','DE00000005',N'lệch răng nghiêm trọng', 'B'
exec procAddAppointment '2024-03-06 16:00','PA00000006','DE00000006',N'lâu lâu bị nhói', 'C'
GO



--Service 

create proc procAddService
	@name NVARCHAR(50),
	@price INT,
	@CalUnit NVARCHAR(10),
	@quantity INT,
	@note NVARCHAR(70)
as
begin
	declare @SerID VARCHAR(10)
	set @SerID = dbo.autoSeid()
	insert into Service (serviceID,name, price,CalUnit,quantity,note) 
	values (@SerID,@name,@price,@CalUnit,@quantity,@note)
end 
go

--select * from service

exec procAddService N'Nhổ răng cửa', 50000,N'Cái',1,''
exec procAddService N'Nhổ răng cối nhỏ',60000,N'Cái',1,'4 phim'
exec procAddService N'Trám GIC', 100000,N'Xoang',1,''
exec procAddService N'Thay nền', 300000,N'Hàm',1,''
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
	@bilID VARCHAR(10)
as
begin
	if(@serviceID not in (select serviceID from Service)) 
		print(N'Chưa tồn tại mã Service này')
	else if(@bilID not in (select bilID from Bill)) 
		print(N'Chưa tồn tại mã Bill này')
	else
	begin
		insert into Bill_Service (serviceID, bilID)
		values (@serviceID,@bilID)
	end
end 
go

--select * from Bill_Service

exec procAddBill_Service 'SE00000001','BI00000001'
exec procAddBill_Service 'SE00000002','BI00000001'
exec procAddBill_Service 'SE00000001','BI00000002'
exec procAddBill_Service 'SE00000003','BI00000003'
exec procAddBill_Service 'SE00000004','BI00000003'
exec procAddBill_Service 'SE00000003','BI00000004'
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


/*
exec GetDentistByPatID 'PA00000001' 
GO
*/
