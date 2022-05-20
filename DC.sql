create database Daidamonycenter;
Go

use DaidamonyCenter;


create table patient
(
First_Name nvarchar(50) COLLATE Arabic_CI_AI_KS_WS not null,
Last_Name nvarchar(50) COLLATE Arabic_CI_AI_KS_WS not null,
Age int not null,
PhoneNumber nvarchar(50) not null,
Home_Address  nvarchar(50) COLLATE Arabic_CI_AI_KS_WS,
Visit_Date date,
Occupation nvarchar(50) COLLATE Arabic_CI_AI_KS_WS,
ID nvarchar(50) not null,
 primary key(ID), 
)

create table operation
(
OpName nvarchar(50) not null,
Price int,
primary key(OpName),
)

create table Diagnosed_Patient
(
Patient_ID nvarchar(50) not null,
Visit_Date date,
Medical_History nvarchar(500),
Diagnosis nvarchar(50),
Tooth nvarchar(50) not null,
Operation nvarchar(50) not null,
Cost int,
Paid int,
Remaining int,



foreign key(Patient_ID) references patient(ID)
ON delete cascade ON update cascade,

primary key(Patient_ID,tooth,operation),
)



