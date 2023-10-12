create database NORMAL_FORM

use NORMAL_FORM

create table FirstNormalForm(
clientno varchar(30),
cname varchar(30),
propertyno varchar(30),
pname varchar(30),
rent_start varchar(30),
rent_finish varchar(30),
rent int,
owner_no varchar(30),
oname varchar(30)
)


insert into FirstNormalForm values
('CR76' , 'John Kay', 'PG4' , '6 lawrence st, Glascow' ,'01-07-2000' , '31-10-2001' , 350 ,'C040' , 'Tina Murphy' ),
('CR76' , 'John Kay', 'PG16' , '5 Novar Dr. Glascow' ,'01-09-2002' , '01-09-2002' , 450 ,'C093' , 'Tony Shaw' ),
('CR56' , 'Aine Stewars', 'PG4' , '6 lawrence st, Glascow' ,'01-09-1999' , '10-06-2000' , 350 ,'C040' , 'Tina Murphy' ),
('CR56' , 'Aine Stewars', 'PG36' , '2 Manor Rd Glascow' ,'10-10-2000' , '01-12-2001' , 370 ,'C093' , 'Tony Shaw' ),
('CR56' , 'Aine Stewars', 'PG16' , '5 Novar Dr. Glascow' ,'01-11-2002' , '01-08-2003' , 450 ,'C093' , 'Tony Shaw' )

select * from FirstNormalForm

create table client(
clientno varchar(30) primary key,
cname varchar(30)) 

insert into client values
('CR76' , 'John Kay') ,
('CR56' , 'Aine Stewars')

select * from client

create table Properties (
propertyno varchar(30) primary key,
pname varchar(30))

create table Owners (
owner_no varchar(30) primary key,
oname varchar(30))

create table Rents (
clientno varchar(30) foreign key REFERENCES client(clientno),
propertyno varchar(30) foreign key REFERENCES Properties(propertyno),
rent_start varchar(30),
rent_finish varchar(30),
rent int,
owner_no varchar(30) foreign key REFERENCES Owners(owner_no))

select * from Rents

insert into Properties values
('PG4' , '6 lawrence st, Glascow' ),
('PG16' , '5 Novar Dr. Glascow' ),
('PG36' ,'2 Manor Rd Glascow' )

select * from Properties

insert into Owners values
('C040' , 'Tina Murphy'),
('C093' , 'Tony Shaw' )

select * from Owners

insert into Rents values
('CR76' , 'PG4'  ,'01-07-2000' , '31-10-2001' , 350 ,'C040' ),
('CR76' , 'PG16' ,'01-09-2002' , '01-09-2002' , 450 ,'C093'  ),
('CR56' , 'PG4'  ,'01-09-1999' , '10-06-2000' , 350 ,'C040'  ),
('CR56' , 'PG36' ,'10-10-2000' , '01-12-2001' , 370 ,'C093' ),
('CR56' , 'PG16' ,'01-11-2002' , '01-08-2003' , 450 ,'C093'  )

select * from Rents 
