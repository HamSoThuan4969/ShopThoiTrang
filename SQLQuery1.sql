CREATE DATABASE ShopThoiTrang 
Go 
USE ShopThoiTrang
Go 
CREATE TABLE Unit 
(
  Id int identity (1, 1) primary key,
  DisplayName nvarchar(1000),


)
Go 
CREATE TABLE Suplier
(
  Id int identity (1, 1) primary key,
  DisplayName nvarchar(1000),
  Address nvarchar(max),
  Email nvarchar(200),
  Phone nvarchar(20),
  TyObject nvarchar(100),
  MoreInfor nvarchar(max),
  ContractDate Datetime
)
Go 
CREATE TABLE SetObject 
( 
  Id int identity(1, 1) primary key,
  DisplayName nvarchar(100),

)
Go 
CREATE TABLE Object
(
  Id nvarchar(128) primary key, -- có mục đích 128
  DisplayName nvarchar(max),
  IdSet int,
  IdUnit int not null,
  IdSuplier int not null,
  InputPrice int, 
  
  foreign key(IdUnit) references Unit(Id),
  foreign key(IdSuplier) references Suplier(Id),
  foreign key (IdSet) references SetObject(Id),



)
Go
CREATE TABLE UserRole
(
  Id int identity(1, 1) primary key,
  DisplayName nvarchar(max)
)
Go 
CREATE TABLE Users
(
  Id int identity(1,1) primary key,
  DisplayName nvarchar(max),
  UserName nvarchar(100),
  Password nvarchar(max),
  IdUserRole int not null

  foreign key (IdUserRole) references UserRole(Id)
)
Go 
--hóa đơn tổng
CREATE TABLE Input
(
  Id nvarchar(128) primary key,
  Quantity int not null,
  ToTal float default 0,
  Type nvarchar(100),
  BarCode nvarchar(max),
  DateInput Datetime 


)
Go
-- hóa đơn con
CREATE TABLE InputInfor          
(
  Id nvarchar(128) primary key,
  IdInput nvarchar(128) not null,
  IdObject nvarchar(128) not null,
  Quantity int,
  InputPrice int, 
  OutputPrice int

  foreign key(IdInput) references Input(Id),
  foreign key(IdObject) references Object(Id)

)
Go 
CREATE TABLE GroupCustomer
(
  Id nvarchar(128) primary key,
  DisplayName nvarchar(200),
  TypeGroup nvarchar(100)
)
Go
CREATE TABLE Customer
(
  Id nvarchar(128) primary key,
  DisplayName nvarchar(max),
  IdGroupCustomer nvarchar(128) not null,
  Address nvarchar(max),
  Phone nvarchar(20),
  Email nvarchar(20),
  DateContract Datetime,
  MoreInfor nvarchar(max),
  IdUserRole int not null

  foreign key(IdGroupCustomer) references GroupCustomer(Id),
  foreign key(IdUserRole) references UserRole(Id)

)
Go 
ALTER TABLE Customer
ALTER COLUMN Email nvarchar(50);
Go 
CREATE TABLE Sale (
    Id nvarchar(128) PRIMARY KEY,
    DisplayName NVARCHAR(255),
    typeSale NVARCHAR(50),  -- 'Customer', 'ComboSet', 'Bill', 'Event'
    StartDate DATE,
    EndDate DATE
)
Go
CREATE TABLE Sale_Detail (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdSale nvarchar(128) not null,  -- Liên kết với bảng Sale
    Discount INT,  -- Mức giảm giá
    ConditionValue INT NULL,  -- Điều kiện (VD: tổng hóa đơn tối thiểu)
    Description NVARCHAR(255),  -- Mô tả điều kiện sale
    FOREIGN KEY (IdSale) REFERENCES Sale(Id)
)
Go 
CREATE TABLE Output
(
  Id nvarchar(128) primary key,
  IdCustomer nvarchar(128), -- có thể họ chưa có tài khoản 
  IdSale_Output nvarchar(128),
  DateOuput Datetime,
  ToTal float default 0, 
  Type nvarchar(100),
  status nvarchar(50)

  foreign key(IdCustomer) references Customer(Id)

)
Go 
CREATE TABLE Sale_Output
(
  Id nvarchar(128) primary key,
  IdSale nvarchar(128) null, 
  IdOutput nvarchar(128) not null,
  DiscountValua float default 0,

  foreign key(IdSale) references Sale(Id),
  foreign key(IdOutput) references Output(Id)
)
ALTER TABLE Output -- do khi tạo bản sale_output trước thì không có 
ADD CONSTRAINT FK_Output_Sale_Output  -- cột để tham chiếu khóa ngoại tới output
FOREIGN KEY (IdSale_Output) REFERENCES Sale_Output(Id)
Go 
CREATE TABLE OutputInfor
(
  Id nvarchar(128) primary key,
  IdObject nvarchar(128) not null,
  IdInputInfor nvarchar(128) not null, -- dùng để truy xuất nếu hàng hóa bị lỗi
  IdCustomer nvarchar(128), -- có thể họ chưa có tài khoản và cần khhi sale
  IdSale_OutputInfor nvarchar(128) null,
  Quantity int,
  InputPrice float default 0,

  foreign key(IdObject) references Object(id),
  foreign key(IdInputInfor) references InputInfor(id),
  foreign key(IdCustomer) references Customer(id), 

  
)
Go 
CREATE TABLE Sale_OutputInfor
(
  Id nvarchar(128) primary key, 
  IdSale nvarchar(128) null,
  IdOutputInfor nvarchar(128) not null,
  DiscountValua float default 0

  foreign key(IdSale) references Sale(Id),
  foreign key(IdOutputInfor) references OutputInfor(Id) 
)
Go
ALTER TABLE OutputInfor -- do khi tạo bản sale_outputInfor trước thì không có 
ADD CONSTRAINT FK_OutputInfor_Sale_OutputInfor  -- cột để tham chiếu khóa ngoại tới outputInfor
FOREIGN KEY (IdSale_OutputInfor) REFERENCES Sale_OutputInfor(Id)

-- rồi tới người dùng đây : 
Go 
  

-- nhập data 
-- Thêm dữ liệu vào bảng Unit
INSERT INTO Unit (DisplayName) VALUES ('Piece');
INSERT INTO Unit (DisplayName) VALUES ('Box');
INSERT INTO Unit (DisplayName) VALUES ('Kilogram');

-- Thêm dữ liệu vào bảng Suplier
INSERT INTO Suplier (DisplayName, Address, Email, Phone, TyObject, MoreInfor, ContractDate) 
VALUES ('Suplier1', '123 Street', 'suplier1@example.com', '123456789', 'Type1', 'More information 1', '2025-01-01');
INSERT INTO Suplier (DisplayName, Address, Email, Phone, TyObject, MoreInfor, ContractDate) 
VALUES ('Suplier2', '456 Avenue', 'suplier2@example.com', '987654321', 'Type2', 'More information 2', '2025-02-01');

-- Thêm dữ liệu vào bảng SetObject
INSERT INTO SetObject (DisplayName) VALUES ('Set 1');
INSERT INTO SetObject (DisplayName) VALUES ('Set 2');

-- Thêm dữ liệu vào bảng Object
INSERT INTO Object (Id, DisplayName, IdSet, IdUnit, IdSuplier, InputPrice) 
VALUES ('OBJ1', 'Object 1', 1, 1, 1, 100);
INSERT INTO Object (Id, DisplayName, IdSet, IdUnit, IdSuplier, InputPrice) 
VALUES ('OBJ2', 'Object 2', 2, 2, 2, 200);

-- Thêm dữ liệu vào bảng UserRole
INSERT INTO UserRole (DisplayName) VALUES ('Admin');
INSERT INTO UserRole (DisplayName) VALUES ('User');

-- Thêm dữ liệu vào bảng Users
INSERT INTO Users (DisplayName, UserName, Password, IdUserRole) 
VALUES ('User 1', 'user1', 'password1', 1);
INSERT INTO Users (DisplayName, UserName, Password, IdUserRole) 
VALUES ('User 2', 'user2', 'password2', 2);

-- Thêm dữ liệu vào bảng Input
INSERT INTO Input (Id, Quantity, ToTal, Type, BarCode, DateInput) 
VALUES ('INP1', 10, 1000, 'Type1', '123456', '2025-03-01');
INSERT INTO Input (Id, Quantity, ToTal, Type, BarCode, DateInput) 
VALUES ('INP2', 20, 2000, 'Type2', '654321', '2025-03-02');

-- Thêm dữ liệu vào bảng InputInfor
INSERT INTO InputInfor (Id, IdInput, IdObject, Quantity, InputPrice, OutputPrice) 
VALUES ('INFI1', 'INP1', 'OBJ1', 5, 100, 150);
INSERT INTO InputInfor (Id, IdInput, IdObject, Quantity, InputPrice, OutputPrice) 
VALUES ('INFI2', 'INP2', 'OBJ2', 10, 200, 250);

-- Thêm dữ liệu vào bảng GroupCustomer
INSERT INTO GroupCustomer (Id, DisplayName, TypeGroup) 
VALUES ('GC1', 'Group 1', 'Type1');
INSERT INTO GroupCustomer (Id, DisplayName, TypeGroup) 
VALUES ('GC2', 'Group 2', 'Type2');

-- Thêm dữ liệu vào bảng Customer
INSERT INTO Customer (Id, DisplayName, IdGroupCustomer, Address, Phone, Email, DateContract, MoreInfor, IdUserRole) 
VALUES ('CUST1', 'Customer 1', 'GC1', '789 Boulevard', '321321321', 'customer1@example.com', '2025-04-01', 'More info 1', 1);
INSERT INTO Customer (Id, DisplayName, IdGroupCustomer, Address, Phone, Email, DateContract, MoreInfor, IdUserRole) 
VALUES ('CUST2', 'Customer 2', 'GC2', '101 Road', '789789789', 'customer2@example.com', '2025-04-02', 'More info 2', 2);


-- Thêm dữ liệu vào bảng Sale
INSERT INTO Sale (Id, DisplayName, typeSale, StartDate, EndDate) 
VALUES ('SALE1', 'Sale 1', 'Event', '2025-04-01', '2025-04-10');
INSERT INTO Sale (Id, DisplayName, typeSale, StartDate, EndDate) 
VALUES ('SALE2', 'Sale 2', 'ComboSet', '2025-04-05', '2025-04-15');

-- Thêm dữ liệu vào bảng Sale_Detail
INSERT INTO Sale_Detail (IdSale, Discount, ConditionValue, Description) 
VALUES ('SALE1', 10, NULL, '10% discount on all items');
INSERT INTO Sale_Detail (IdSale, Discount, ConditionValue, Description) 
VALUES ('SALE2', 20, 1000, '20% discount on orders over 1000');

-- Thêm dữ liệu vào bảng Output
INSERT INTO Output (Id, IdCustomer, IdSale_Output, DateOuput, ToTal, Type, status) 
VALUES ('OUT1', 'CUST1', 'SOUT1', '2025-04-01', 1500, 'Type1', 'Completed');
INSERT INTO Output (Id, IdCustomer, IdSale_Output, DateOuput, ToTal, Type, status) 
VALUES ('OUT2', 'CUST2', 'SOUT2', '2025-04-02', 2500, 'Type2', 'Pending');

-- Thêm dữ liệu vào bảng Sale_Output
INSERT INTO Sale_Output (Id, IdSale, IdOutput, DiscountValua) 
VALUES ('SOUT1', 'SALE1', 'OUT1', 150);
INSERT INTO Sale_Output (Id, IdSale, IdOutput, DiscountValua) 
VALUES ('SOUT2', 'SALE2', 'OUT2', 500);

-- Thêm dữ liệu vào bảng OutputInfor
INSERT INTO OutputInfor (Id, IdObject, IdInputInfor, IdCustomer, IdSale_OutputInfor, Quantity, InputPrice) 
VALUES ('OUTI1', 'OBJ1', 'INFI1', 'CUST1', 'SOUTI1', 5, 150);
INSERT INTO OutputInfor (Id, IdObject, IdInputInfor, IdCustomer, IdSale_OutputInfor, Quantity, InputPrice) 
VALUES ('OUTI2', 'OBJ2', 'INFI2', 'CUST2', 'SOUTI2', 10, 250);

-- Thêm dữ liệu vào bảng Sale_OutputInfor
INSERT INTO Sale_OutputInfor (Id, IdSale, IdOutputInfor, DiscountValua) 
VALUES ('SOUTI1', 'SALE1', 'OUTI1', 50);
INSERT INTO Sale_OutputInfor (Id, IdSale, IdOutputInfor, DiscountValua) 
VALUES ('SOUTI2', 'SALE2', 'OUTI2', 100);

-- Thêm dữ liệu vào bảng Employment
INSERT INTO Employment (Id) VALUES ('EMP1');
INSERT INTO Employment (Id) VALUES ('EMP2');

