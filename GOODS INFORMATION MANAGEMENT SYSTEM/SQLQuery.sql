create table account(
username varchar(20) primary key,
FULLNAME varchar(50),
password varchar(20),
Phone varchar(12) unique
)

insert into account values('admin','no','123','000000');

create table customer(
id int IDENTITY(1,1) primary key,
fullname varchar(30),
phonenumber varchar(12) unique,
password varchar(20)
)

create table category(
id int IDENTITY(1,1) primary key,
name varchar(30),
description varchar(250),
)

create table product(
id int IDENTITY(1,1) primary key,
name varchar(30),
description varchar(250),
price int,
categoryid int,
quantity int,
img varchar(200),
foreign key (categoryid) references category(id) 
)


create table bill_import(
id int IDENTITY(1,1) primary key,
datecreate date,
companyname varchar(50),
totalprice int,
)

create table product_billimport(
billid int,
productid int,
quantity int,
foreign key (billid) references bill_import(id),
foreign key (productid) references product(id),
primary key(billid,productid)
)

create table cart(
id int IDENTITY(1,1) primary key,
productid int, 
customerid int,
quantity int,
foreign key (productid) references product(id),
foreign key (customerid) references customer(id),
)



create table customerbill(
id int IDENTITY(1,1) primary key,
productid int, 
customerid int,
quantity int,
status varchar(10),
datecreate date default CURRENT_TIMESTAMP,
foreign key (productid) references product(id),
foreign key (customerid) references customer(id),
)



update customerbill set status='be trans.'  where id=1
select price,product_billimport.quantity from product, product_billimport  where billid= id and id=4