create table account(
username varchar(20) primary key,
FULLNAME varchar(50),
password varchar(20),
Phone varchar(12) unique
)

create table customer(
id int IDENTITY(1,1) primary key,
fullname varchar(30),
phonenumber varchar(12) unique,
password varchar(20)
)

select * from account