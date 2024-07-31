create table product(pid int primary key,pname varchar(20) unique not null,price int,stock int)
as
begin
declare @pid int
if(exists(select * from product))
begin 
select @pid=max(pid) from product
set @pid=@pid+1
end
else
begin
set @pid=1
end

insert into product values(@pid,@pname,@price,@stock)
end

exec InsertProduct 'mouse',100,20
select * from product
insert into product values(3,'keyboard',200,10),(4,'adaptor',300,25),(5,'joystick',350,50)

----*** 1.  GetAllProducts

create procedure GetAllProducts
as 
begin
select * from product
end

exec  GetAllProducts

---*** 2.  GetProductByName

create procedure  GetProductByName(@name varchar(20))
as 
begin
select * from product where pname=@name
end

exec GetProductByName 'adaptor'

---*** 3. GetAllProductsBy>input Price

create procedure GetAllProductsByPrice1(@price int)
as 
begin
select * from product where price>@price
end

exec GetAllProductsByPrice1 '100'

---*** 4. DeleteProductById

create procedure  DeleteProductById(@id int)
as
begin
delete product where pid=@id
end

exec  DeleteProductById '2'

--- *** 5. UpdateProduct(Update Price and Stock of the Product using Pid)

create procedure UpdateProduct(@id int)
as
begin
update product set price=1000,stock =100 where pid=@id
end

exec UpdateProduct 4

select * from product