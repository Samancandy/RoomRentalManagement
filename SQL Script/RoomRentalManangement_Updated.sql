create database RoomRentalManagement
go
use RoomRentalManagement
go

create table tbUser(
	id int primary key identity,
	uname varchar(20) unique,
	passw varchar(20))

create table tbRoom(
	RoomNo varchar(10) primary key,
	RoomType varchar(20),
	Size varchar(10),
	Price float,
	Status varchar(10))
	   


create table tbCustomer(
	PersonID varchar(10) primary key,
	Name varchar(20),
	Gender varchar(8),
	DOB date,
	Phone varchar(10),
	Addr varchar(50))

create table tbRoomMember(
	ID int primary key identity,
	RoomNo varchar(10) references tbRoom(RoomNo),
	CustomerID varchar(10) references tbCustomer(PersonID),
	unique(CustomerID)
	)

create table tbWorker(
	WorkerID varchar(10) primary key,
	WorkerName varchar(20),
	Gender varchar(8),
	DOB date,
	Phone varchar(11),
	Addr varchar(5),
	Salary float)

create table tbRental(
	RentalID int primary key identity,
	PersonID varchar(10) references tbCustomer(PersonID),
	RoomNo varchar(10) references tbRoom(RoomNo) unique,
	RentedDate date,
	unique(PersonID, RoomNo))

create table tbPayment(
	PaymentID int primary key identity,
	PersonID varchar(10) references tbCustomer(PersonID),
	RoomNo varchar(10) references tbRoom(RoomNo),
	PaymentDate date)


	insert into tbUser values('','')

	insert into tbCustomer values('CS00002','Choko', 'Female', '12-09-2018', '0967077002', 'Takeo')
	insert into tbCustomer values('CS00001','Candy', 'Male', '12-09-2018', '0967077002', 'Takeo')
	insert into tbCustomer values('CS00003','Chehii', 'Female', '12-09-2018', '0967077002', 'Takeo')
	insert into tbRoom values ('RM00001','Medium','4x5', '50', 'Available')
	insert into tbRoom values ('RM00002','Medium','4x5', '50', 'Available')
	insert into tbRoom values ('RM00003','Medium','4x5', '50', 'Available')
	insert into tbWorker values('WD00001','MIK', 'Male', '12-09-2018', '0967077002', 'Takeo', '2500')
	insert into tbWorker values('WD00002','Mark', 'Male', '12-09-2018', '0967077002', 'Takeo', '5000')
	insert into tbWorker values('WD00003','Yon', 'Male', '12-09-2018', '0967077002', 'Takeo', '4500')

	--delete from tbWorker where WorkerID = 'WD00001'




	--select * from tbRental

	--select * from tbRoomMember


	--select PersonID, Name, Gender, DOB, Phone, Addr from tbCustomer cs inner join tbRoomMember rm on cs.PersonID = rm.CustomerID where RoomNo = 'RM00003'


