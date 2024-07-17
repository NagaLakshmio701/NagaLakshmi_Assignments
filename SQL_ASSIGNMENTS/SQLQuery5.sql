create database sql_assignment_one
use sql_assignment_one

--*** 1 ***
create table Customers
(
  CustomerID char(5) not null,
  CompanyName varchar(40) not null,
  contactName char(30) null,
  Address varchar(60) null,
  City char(15) null,
  Phone char(24) null,
  Fax char(24) null
)
go

create table Orders
( 
   OrderId integer not null,
   customerId char(5) not null,
   Orderdate datetime null,
   Shippeddate datetime null,
   Freight money null,
   Shipname varchar(40) null,
   Shipaddres varchar(60) null,
   Quantity integer null
)

--*** 2 ***

alter table Orders add shipregion int

--*** 3 ***

alter table Orders alter column shipregion char(8) 

-- *** 4 ***


alter table Orders drop column shipregion


--*** 5 ***

insert into Orders values( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)

select * from Orders


--*** 6 ***


ALTER TABLE Orders
ADD CONSTRAINT DF_Orderdate DEFAULT GETDATE() FOR Orderdate;




--*** 7 ***

sp_rename 'Customers.City','Town'