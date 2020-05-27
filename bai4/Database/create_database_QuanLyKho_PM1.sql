create database QuanLyKho_PM1
go

use QuanLyKho_PM1
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
	InputPrice float default 0,
	OuputPrice float default 0,
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
	IdInputInfo nvarchar(10) not null,
	IdCustomer int not null,
	Quantity int  not null,
	Status nvarchar(max),

	constraint fk_OutputInfo_Suplly foreign key(IdSupply) references Supply(ID), 
	constraint fk_OutputInfo_InputInfo foreign key(IdInputInfo) references InputInfo(ID),
	constraint fk_OutputInfo_Customer foreign key(IdCustomer) references Customer(ID),
	constraint fk_OutputInfo_Outputs foreign key(IdOutput) references Outputs(ID),
)
go


--Insert dữ liệu

insert into UserRole values ('Admin')
insert into UserRole values (N'Nhân viên')

insert into Users values('Admin',N'admin',N'admin',1)

insert into Unit values (N'Cái')
insert into Unit values (N'Thùng')
insert into Unit values (N'Chai')
insert into Unit values (N'Bao')

insert into Supplier values(N'Trần Tuấn Sơn',N'Đông Anh, Hà Nội','0912984223','trantuanson97@gmail.com',null,null)
insert into Supplier values(N'Nguyễn Hải Linh',N'Đông Anh, Hà Nội','0912235457','nguyenhailinh2k@gmail.com',null,null)
insert into Supplier values(N'Nguyễn Đại Minh',N'Đông Anh, Hà Nội','0912984367','nguyendaiminh2k7@gmail.com',null,null)

insert into Supply values ('D0001','Coca cola',3,1,null,null,0)
insert into Supply values ('D0002','Pessi',3,1,null,null,0)
insert into Supply values ('D0003','7UP',3,1,null,null,0)
insert into Supply values ('D0004','Sting',3,1,null,null,0)


insert into Customer values(N'Nguyễn Văn Cấp',N'Hà Nội',N'0912941241','nguyenvancap78@gmail.com',null,null)
insert into Customer values(N'Trần Thị Hằng',N'Hà Nội',N'0913534535','tranthihang98@gmail.com',null,null)
insert into Customer values(N'Trịnh Thanh Thủy',N'Hà Nội',N'0912923543','trinhthanhthuy96@gmail.com',null,null)

insert into Input values(N'I00001','09-09-2019')
insert into Input values(N'I00002','10-09-2019')
insert into Input values(N'I00003','10-14-2019')
insert into Input values(N'I00004','10-20-2019')

insert into InputInfo values(N'IF00001',N'D0001',N'I00001',30,9000,10000,null)
insert into InputInfo values(N'IF00002',N'D0002',N'I00001',20,8000,9000,null)
insert into InputInfo values(N'IF00003',N'D0003',N'I00001',25,7000,8000,null)
insert into InputInfo values(N'IF00004',N'D0004',N'I00001',60,9200,10000,null)
insert into InputInfo values(N'IF00005',N'D0001',N'I00002',30,9000,10000,null)
insert into InputInfo values(N'IF00006',N'D0002',N'I00002',30,8000,9000,null)

insert into Outputs values(N'O00001','11-01-2019')
insert into Outputs values(N'O00002','11-02-2019')

insert into OutputInfo values(N'OF00001',N'O00001','D0001','IF00001',1,10,null)
insert into OutputInfo values(N'OF00002',N'O00001','D0002','IF00002',1,10,null)
insert into OutputInfo values(N'OF00003',N'O00002','D0001','IF00001',1,10,null)

select * from Customer
select * from Input
select * from InputInfo
select * from OutputInfo
select * from Outputs
select * from Supplier
select * from Unit
select * from Users

select * from Supply
go

-- tạo Pro cập nhập tồn kho
alter proc UpdateStock
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



--Tạo view XEMKHO
create view KhoView
as
select Supply.ID as[ID],Supply.DisplayName as[Vật tư],Stock as[Số lượng tồn],Unit.DisplayName as[Đơn vị] from Supply,Unit where IdUnit=Unit.ID
go

select * from KhoView where [ID] like N'%{0}%' or [Vật tư] like N'%Co%' or [Số lượng tồn] =25 or [Đơn vị] like N'%{3}%'

create view SupplyView
as 
select Supply.ID as[ID],Supply.DisplayName as[Vật tư],Unit.DisplayName as[Đơn vị],Supplier.DisplayName as[Nhà cung cấp] from Supply,Unit,Supplier where IdUnit=Unit.ID and IdSupplier=Supplier.Id
go

--Tạo biew XEMVATTU


exec UpdateStock 'D0003'
go

select * from Supply

select sum(Quantity) from InputInfo where IdSupply='D0001'
go

select sum(Quantity) from InputInfo

create proc AddSupplyByN 
@ID nvarchar(10),
@DisplayName nvarchar(500),
@UnitName nvarchar(500),
@SupplyName nvarchar(500)
as begin 
	declare @IdUnit int 
	declare @IdSupply int

	select @Tong_tien=sum(DonGia) from ChiTietMuaMoiThietBi,MuaMoiThietBi
	where ChiTietMuaMoiThietBi.MaMMTB=MuaMoiThietBi.MaMMTB
	insert into 
end 
go


