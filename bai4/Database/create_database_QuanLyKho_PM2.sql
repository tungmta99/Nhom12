create database QuanLyKho_PM2
go

use QuanLyKho_PM2
go

create table Unit
(
	ID int identity(1,1) primary key,
	Displayname nvarchar(500)
)
go

create table Supplier 
(
	ID int identity(1,1) primary key ,
	Displayname nvarchar(500),
	Adress nvarchar(500),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate Datetime 


)
go

create table Customer
(
	ID int identity(1,1) primary key ,
	Displayname nvarchar(500),
	Adress nvarchar(500),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate Datetime 

)
go

create table Supply
(
	ID nvarchar(10) primary key,
	DisplayName nvarchar(500),
	IdUnit int not null,
	IdSupplier int not null,
	QRcode nvarchar(max),
	Barcode nvarchar(max),
	Stock int default 0,

	constraint fk_Supply_Unit foreign key(IdUnit) references Unit(ID), 
	constraint fk_Supply_Supplier foreign key(IdSupplier) references Supplier(ID), 
)
go

create table UserRole
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(250),

)
go

create table Users
(
	ID int  identity(1,1) primary key,
	DisplayName nvarchar(100),
	UserName nvarchar(100),
	Password nvarchar(max),
	IdRole int not null,

	constraint fk_Users_UserRole foreign key(IdRole) references USerRole(ID), 
)
go

create table Input 
(
	Id nvarchar(10) primary key,
	DateInput DateTime,
	
)
go

create table InputInfo
(
	ID nvarchar(10) primary key,
	IdSupply nvarchar(10) not null,
	IdInput nvarchar(10) not null,
	Quantity int not null,
	InputPrice float not null,
	
	Status nvarchar(max),

	constraint fk_InputInfo_Supply foreign key(IdSupply) references Supply(ID), 
	constraint fk_InputInfo_Input foreign key(IdInput) references Input(ID), 

)
go

create table Outputs
(
	Id nvarchar (10) primary key,
	DateOutput datetime,
)
create table OutputInfo
(
	Id nvarchar(10) primary key,
	IdOutput nvarchar(10) not null,
	IdSupply nvarchar (10) not null,
	IdCustomer int not null,
	Quantity int  not null,
	OuputPrice float not null,

	Status nvarchar(max),

	constraint fk_OutputInfo_Suplly foreign key(IdSupply) references Supply(ID), 
	constraint fk_OutputInfo_Customer foreign key(IdCustomer) references Customer(ID),
	constraint fk_OutputInfo_Outputs foreign key(IdOutput) references Outputs(ID),
)
go


--Insert du~ liê?u

insert into UserRole values ('Admin')
insert into UserRole values (N'Nhân viên')

insert into Users values('Admin',N'admin',N'admin',1)

insert into Unit values (N'Cái')
insert into Unit values (N'Thùng')
insert into Unit values (N'Chai')
insert into Unit values (N'Bao')

insert into Supplier values(N'Trần Tuấn Sơn',N'Ðông Anh, Hà Nội','0912984223','trantuanson97@gmail.com',null,null)
insert into Supplier values(N'Nguyễn Hải Linh',N'Ðông Anh, Hà Nội','0912235457','nguyenhailinh2k@gmail.com',null,null)
insert into Supplier values(N'Nguyễn Đại Minh',N'Ðông Anh, Hà Nội','0912984367','nguyendaiminh2k7@gmail.com',null,null)

insert into Supply values ('D0001',N'Coca cola',3,1,null,null,0)
insert into Supply values ('D0002',N'Pessi',3,1,null,null,0)
insert into Supply values ('D0003',N'7UP',3,1,null,null,0)
insert into Supply values ('D0004',N'Sting',3,1,null,null,0)


insert into Customer values(N'Nguyễn Văn Cấp',N'Hà Nội',N'0912941241','nguyenvancap78@gmail.com',null,null)
insert into Customer values(N'Trần Thị Hằng',N'Hà Nội',N'0913534535','tranthihang98@gmail.com',null,null)
insert into Customer values(N'Trịnh Thanh Thủy',N'Hà Nội',N'0912923543','trinhthanhthuy96@gmail.com',null,null)

insert into Input values(N'I00001','09-09-2019')
insert into Input values(N'I00002','10-09-2019')
insert into Input values(N'I00003','10-14-2019')
insert into Input values(N'I00004','10-20-2019')

insert into InputInfo values(N'IF00001',N'D0001',N'I00001',30,9000,null)
insert into InputInfo values(N'IF00002',N'D0002',N'I00001',20,8000,null)
insert into InputInfo values(N'IF00003',N'D0003',N'I00001',25,7000,null)
insert into InputInfo values(N'IF00004',N'D0004',N'I00001',60,9200,null)
insert into InputInfo values(N'IF00005',N'D0001',N'I00002',30,9000,null)
insert into InputInfo values(N'IF00006',N'D0002',N'I00002',30,8000,null)

insert into Outputs values(N'O00001','11-01-2019')
insert into Outputs values(N'O00002','11-02-2019')

insert into OutputInfo values(N'OF00001',N'O00001','D0001',1,10,10000,null)
insert into OutputInfo values(N'OF00002',N'O00001','D0002',1,10,9000,null)
insert into OutputInfo values(N'OF00003',N'O00002','D0001',1,10,10000,null)

select * from Customer
select * from Input
select * from InputInfo
select * from OutputInfo
select * from Outputs
select * from Supplier
select * from Unit
select * from UserRole
select * from Users

select * from Supply
go

update Supplier set Displayname=N'Tran Tuan Son',Adress=N'Ha Dong',ContractDate='09-10-2018' where ID=1

--
select ID,Displayname as[Tên],Adress as[Địa chỉ],Phone as[SDT],Email,MoreInfo as[Khác],ContractDate as[Ngày hợp tác] from Supplier
go
-- ta?o Pro câ?p nhâ?p tô`n kho
create proc UpdateStock
@IdSupply nvarchar(10)
as
begin

declare @TongNhap int
declare @TongXuat int


select @TongNhap=sum(Quantity) from InputInfo where IdSupply=@IdSupply
select @TongXuat=sum(Quantity) from OutputInfo where IdSupply=@IdSupply

update Supply set Stock= @TongNhap-@TongXuat
where (
	ID=@IdSupply
		) 
if (@TongXuat is null)
	begin
		update Supply set Stock= @TongNhap
		
	where (
	ID=@IdSupply
		) 
		print @TongNhap-@TongXuat
	end
	
end
go



--Ta?o view XEMKHO
create view KhoView
as
select Supply.ID as[ID],Supply.DisplayName as[Vật tư],Stock as[Số lượng tồn],Unit.DisplayName as[Đơn vị] from Supply,Unit where IdUnit=Unit.ID
go

--Ta?o view XEMVATTU
create view SupplyView
as 
select Supply.ID as[ID],Supply.DisplayName as[Vật tư],Unit.DisplayName as[Đơn vị],Supplier.DisplayName as[Nhà cung cấp],QRcode,Barcode,Stock as[Lượng tồn] from Supply,Unit,Supplier where IdUnit=Unit.ID and IdSupplier=Supplier.Id
go

-- TA?o view XEMChiTietNhap
create view InputInfoView
as
select InputInfo.ID as[ID],IdInput ,Supply.DisplayName as [Vật tư],Quantity as [Số lượng],InputPrice as[Giá nhập], Status as[Trạng Thái],DateInput as[Ngày nhập] from Input,InputInfo,Supply 
	where Input.Id =InputInfo.IdInput and Supply.ID=IdSupply
go

-- TA?o view XEMChiTietXuat
create view OutputInfoView
as
select OutputInfo.ID as[ID],IdOutput ,Supply.DisplayName as [Vật tư],Quantity as [Số lượng],OuputPrice as[Giá xuất], Status as[Trạng Thái],DateOutput as[Ngày xuất],Customer.Displayname as[Khách hàng] from Outputs,OutputInfo,Supply,Customer
	where Outputs.Id =OutputInfo.IdOutput and Supply.ID=IdSupply and Customer.ID=IdCustomer
go

select * from OutputInfoView
select * from SupplyView

exec UpdateStock 'D0005'
go

select * from Supply

select sum(Quantity) from InputInfo where IdSupply='D0001'
go

select * from USers 

select sum(Quantity) from InputInfo
go

--Ta?o Proc AddSupplyByN 
create proc AddSupplyByN 
@ID nvarchar(10),
@DisplayName nvarchar(500),
@UnitName nvarchar(500),
@SupplierName nvarchar(500),
@QRcode nvarchar(max),
@Barcode nvarchar(max)
as begin 

	declare @IdUnit int 
	declare @IdSupplier int

	select @IdUnit=ID from Unit where Displayname=@UnitName
	select @IdSupplier=ID from Supplier where Displayname=@SupplierName

	insert into Supply (ID,DisplayName,IdUnit,IdSupplier,QRcode,Barcode) values (@ID,@DisplayName,@IdUnit,@IdSupplier,@QRcode,@Barcode)

end 
go

--Ta?o Proc UpdateSupplyByN
create proc UpdateSupplyByN 
@ID nvarchar(10),
@DisplayName nvarchar(500),
@UnitName nvarchar(500),
@SupplierName nvarchar(500),
@QRcode nvarchar(max),
@Barcode nvarchar(max),
@IdOld nvarchar(10)
as begin 

	declare @IdUnit int 
	declare @IdSupplier int

	select @IdUnit=ID from Unit where Displayname=@UnitName
	select @IdSupplier=ID from Supplier where Displayname=@SupplierName

	update Supply set ID=@ID,DisplayName=@DisplayName,IdUnit=@IdUnit,IdSupplier=@IdSupplier,QRcode=@QRcode,Barcode=@Barcode where Id=@IdOld

end 
go



exec UpdateSupplyByN 'M0001',N'Sữa cô gái Hà Lan',N'Hộp',N'Ngô Quy`nh Anh','','','M0001'
go

--Ta?o Proc AddInputInfoByN 
create proc AddInputInfoByN 
@ID nvarchar(10),
@SupplyName nvarchar(500),
@IdInput nvarchar(10),
@Quantity int,
@InputPrice float,
@Status nvarchar(max)
as begin 

	declare @IdSupply nvarchar(10)

	select @IdSupply=ID from Supply where Displayname=@SupplyName

	insert into InputInfo values (@ID,@IdSupply,@IdInput,@Quantity,@InputPrice,@Status)
	exec UpdateStock @IdSupply
end 
go

--Ta?o Proc UpdateInputInfoByN 
create proc UpdateInputInfoByN 
@ID nvarchar(10),
@SupplyName nvarchar(500),
@IdInput nvarchar(10),
@Quantity int,
@InputPrice float,
@Status nvarchar(max),
@Idold nvarchar(10)
as begin 

	declare @IdSupply nvarchar(10)

	select @IdSupply=ID from Supply where Displayname=@SupplyName

	update InputInfo set ID=@ID,IdSupply=@IdSupply,IdInput=@IdInput,Quantity=@Quantity,InputPrice=@InputPrice,Status=@Status where Id=@Idold
	exec UpdateStock @IdSupply
end 
go
select * from OutputInfoView where IdOutput=N'O00001'
exec UpdateInputInfoByN 'IF00009',N'Sữa tiệt trùng','I00003',80,24000,'','IF00009'
go

--Ta?o Proc AddOutputInfoByN 
create proc AddOutputInfoByN 
@ID nvarchar(10),
@IdOutput nvarchar(10),
@SupplyName nvarchar(500),
@CustomerName nvarchar(500),
@Quantity int,
@OutputPrice float,
@Status nvarchar(max)

as begin 

	declare @IdSupply nvarchar(10)
	declare @IdCustomer int

	select @IdSupply=ID from Supply where Displayname=@SupplyName
	select @IdCustomer=ID from Customer where Displayname=@CustomerName

	insert into OutputInfo values (@ID,@IdOutput,@IdSupply,@IdCustomer,@Quantity,@OutputPrice,@Status)
	exec UpdateStock @IdSupply
end 
go
exec AddOutputInfoByN 'OF00009','O00002',N'Sữa tiệt trùng',N'Trần Thị Hằng',30,28000,''
select ID From Customer where Displayname=N'Trần Thị Hằng'
select * from OutputInfo
select * from Supply
go

--Ta?o Proc UpdateOutputInfoByN 
create proc UpdateOutputInfoByN
@ID nvarchar(10),
@IdOutput nvarchar(10),
@SupplyName nvarchar(500),
@CustomerName nvarchar(500),
@Quantity int,
@OutputPrice float,
@Status nvarchar(max),
@Idold nvarchar(10)
as begin 

	declare @IdSupply nvarchar(10)
	declare @IdCustomer int

	select @IdSupply=ID from Supply where Displayname=@SupplyName
	select @IdCustomer=ID from Customer where Displayname=@CustomerName

	update OutputInfo set ID=@ID,IdSupply=@IdSupply,IdOutput=@IdOutput,Quantity=@Quantity,OuputPrice=@OutputPrice,Status=@Status,IdCustomer=@IdCustomer where Id=@Idold
	exec UpdateStock @IdSupply
end 
go

-- exec UpdateOutputInfoByN 'OF00009','O00002',N'Sữa tươi tiệt trùng',N'Trần Thị Hằng',20,28000,'','OF00009'
go

--Tạo PROC  AddUserByN 
create proc AddUserByN
@DisplayName nvarchar(100),
@UserName nvarchar(100),
@Password nvarchar(max),
@RoleName nvarchar(250)
as begin
	
declare @IdRole int

select @IdRole=Id from UserRole where DisplayName =@RoleName

insert into Users values (@DisplayName,@UserName,@Password,@IdRole)
end
go

--Tạo PROC  UpdateUserByN 
create proc UpdateUserByN
@DisplayName nvarchar(100),
@UserName nvarchar(100),
@Password nvarchar(max),
@RoleName nvarchar(250),
@ID int 
as begin
	
declare @IdRole int

select @IdRole=Id from UserRole where DisplayName =@RoleName

update Users set DisplayName=@DisplayName,UserName=@UserName,Password=@Password,IdRole=@IdRole where ID=@ID

end
go

exec  UpdateUserByN N'BrownEyes',N'LinhPhamMy',N'linh1234',N'Nhân viên',2
go

select * from OutputInfoView
select * from Supply
select ID from Supplier where Displayname=N'Trần Tuấn Sơn'

select * from KhoView where [Số lượng tồn] >0

select * from KhoView
select sum(Quantity) from InputInfo

select InputInfo.ID as[ID], Supply.DisplayName as [Vật tư],Quantity as [Số lượng],InputPrice as[Giá nhập], Status as[Trạng thái] from Input,InputInfo,Supply 
	where Input.Id =InputInfo.IdInput and Supply.ID=IdSupply and IdInput =N'I00001'

	select DateInput from Input where ID=N'I00001'

