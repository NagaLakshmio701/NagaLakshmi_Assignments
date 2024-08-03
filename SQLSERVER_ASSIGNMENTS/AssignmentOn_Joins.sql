-- Create Department table
CREATE TABLE Department (
    Dept_no CHAR(2) PRIMARY KEY,
    Dept_name VARCHAR(50),
    location VARCHAR(50)
);

-- Insert data into Department table
INSERT INTO Department (Dept_no, Dept_name, location)
VALUES
('d1', 'Research', 'Dallas'),
('d2', 'Accounting', 'Seattle'),
('d3', 'Marketing', 'Dallas');

-- Create Employee table
CREATE TABLE Employee (
    emp_no INT PRIMARY KEY,
    emp_fname VARCHAR(50),
    emp_lname VARCHAR(50),
    dept_no CHAR(2),
    FOREIGN KEY (dept_no) REFERENCES Department(Dept_no)
);

-- Insert data into Employee table
INSERT INTO Employee (emp_no, emp_fname, emp_lname, dept_no)
VALUES
(25348, 'Matthew', 'Smith', 'd3'),
(10102, 'Ann', 'Jones', 'd3'),
(18316, 'John', 'Barrimore', 'd1'),
(29346, 'James', 'James', 'd2'),
(9031, 'Laura', 'Wilson', 'd1'), 
(28559, 'Nina', 'Clark', 'd2'),  
(2581, 'Oliver', 'King', 'd3'),  
(12345, 'Alice', 'Johnson', 'd1'),
(23456, 'Bob', 'Brown', 'd2'),
(34567, 'Charlie', 'Davis', 'd3'),
(45678, 'Diana', 'Evans', 'd1'),
(56789, 'Edward', 'Franklin', 'd3');

-- Create Project table
CREATE TABLE Project (
    project_no CHAR(2) PRIMARY KEY,
    project_name VARCHAR(50),
    Budget DECIMAL(10, 2)
);

-- Insert data into Project table
INSERT INTO Project (project_no, project_name, Budget)
VALUES
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600);

-- Create Works_on table
CREATE TABLE Works_on (
    emp_no INT,
    project_no CHAR(2),
    Job VARCHAR(50),
    enter_date DATE,
    PRIMARY KEY (emp_no, project_no),
    FOREIGN KEY (emp_no) REFERENCES Employee(emp_no),
    FOREIGN KEY (project_no) REFERENCES Project(project_no)
);

-- Insert data into Works_on table
INSERT INTO Works_on (emp_no, project_no, Job, enter_date)
VALUES
(10102, 'p1', 'Analyst', '1997-10-01'),
(10102, 'p3', 'manager', '1999-01-01'),
(25348, 'p2', 'Clerk', '1998-02-15'),
(18316, 'p2', NULL, '1998-06-01'),
(29346, 'p2', NULL, '1997-12-15'),
(2581, 'p3', 'Analyst', '1998-10-15'),
(9031, 'p1', 'Manager', '1998-04-15'),
(28559, 'p1', NULL, '1998-08-01'),
(28559, 'p2', 'Clerk', '1992-02-01'),
(9031, 'p3', 'Clerk', '1997-11-15'),
(29346, 'p1', 'Clerk', '1998-01-04');


---***	1.A  Equijoin *** 

select p.*,w.* from Project p join Works_on w on p.project_no =w.project_no


---*** 1.B   Natural join  ***

select p.*,w.emp_no,w.job,w.enter_date  from Project p join Works_on w on p.project_no =w.project_no

--- *** 1.C Cartesian produc ***

select * from Project ,Works_on 

--- *** 2. Get the employee numbers and job titles of all employees working on project Gemini


select w.emp_no,w.job from Works_on w join Project p on w.project_no =p.project_no where project_name ='gemini'


----*** 3. Get the first and last names of all employees that work for departments Research or Acounting

select e.emp_fname,e.emp_lname from Employee e join Department d on e.dept_no =d.Dept_no where Dept_name in ('research','accounting')

--- *** 4. Get the enter dates of all clerks that belong to the department d1.
select * from Department

select w.enter_date from Works_on w join Employee e on e.emp_no =w.emp_no where job='clerk' and dept_no ='d1'

--- *** 5. Get the names of projects on which two or more clerks are working

select * from Works_on
select * from Project 

select p.project_name from Project p join Works_on w on p.project_no=w.project_no where job='clerk' group by p.project_name  having count(w.emp_no )>=2

--- *** 6. Get the first and last names of the employees that are manager and that work on project Mercury

select e.emp_fname,e.emp_lname from Employee e join Works_on w on e.emp_no=w.emp_no join  project p on w.project_no = p.project_no where job='manager' and project_name='mercury'

--- *** 7. Get the first and last names of all employee who entered the project at the same time as at least one other employee.

select e.emp_fname,e.emp_lname from Employee e join Works_on w on e.emp_no=w.emp_no where w.enter_date in (select enter_date from Works_on  group by enter_date having count(emp_no)>1 )

--- *** 8. Get the employee numbers of the employees living in the same location and belonging to the same department as one another.

select * from Employee
select * from Department

select e.emp_no from Employee e join Department d on e.dept_no =d.Dept_no join Employee e2 on e.emp_no=e2.emp_no   join Department d2 on d.Dept_no =d2.Dept_no   where e.dept_no=e2.dept_no and d.location =d2.location


--- *** 9.Get the employee numbers of all employees belonging to the Marketing department.Find two equivalent solutions using:


---   *** 9.A  the JOIN operator

select e.emp_no  from Employee e join Department d on e.dept_no =d.Dept_no where Dept_name='marketing'

--- *** 9.B  The correlated subquery.

select e.emp_no from Employee e   where e.dept_no =(select d.dept_no from Department d   where Dept_name ='marketing')





--- *** Modifying a Table’s Content***

--- *** 1. Insert the data of a new employee called Julia Long, whose employee number is 1111. Her department number is not known yet.

insert into Employee (emp_no ,emp_fname ,emp_lname) values(1111,'Julia','Long')


--- *** 2. Create a new table called emp_d1_d2 with all employees who work for department d1 or d2, and load the corresponding rows from the employee table.

create table emp_d1_d2 (emp_no int ,emp_fname varchar(20),emp_lname varchar(20),dept_no char(5))
insert into emp_d1_d2 (emp_no,emp_fname ,emp_lname ,dept_no ) select emp_no,emp_fname ,emp_lname ,dept_no from Employee where dept_no in ('d1','d2')
select * from emp_d1_d2

--- *** 3. Modify the job of all the employees in project p1 who are managers. They have to work as clerks from now on.
select * from Project 

select * from Employee
select * from Works_on

select * from Department

update  works_on set job='clerks' where project_no ='p1' and job='manager'

--- *** 4. The budgets of all projects are no longer determined. Assign all budgets the NULL value.

update Project set Budget=null 

---*** 5. Increase the budget of the project where the manager has the employee number 10102. The increase is 10%.

update project set Budget = Budget*0.10  where project_no=(select project_no from Works_on where emp_no=10102 and job='manager')

---*** 6. Change the enter date for the projects for those employees who work in project p1 and belong to the department Sales. The new date is 12.12.1998


UPDATE Works_on SET enter_date = '1998-12-12' WHERE project_no = 'p1' AND emp_no IN (SELECT emp_no FROM Employee WHERE dept_no = (SELECT Dept_no FROM Department WHERE Dept_name = 'Sales'))

---*** 7. Create a stored procedure to insert data into department and Employee table

create procedure InsertDataIntoDepartment1 ( @dept_no varchar(20), @dept_name varchar(20), @location varchar(20) )
as 
begin
 
insert into Department(dept_no,dept_name,location) values(@dept_no,@dept_name,@location)
select * from Department
end


exec  InsertDataIntoDepartment1 'd6' ,'accounting' ,'AP'


create procedure InsertDataIntoEmployee1(@emp_no int,@emp_fname varchar(20),@emp_lname varchar(20),@dept_no varchar(5))
as
begin 
insert into Employee values(@emp_no,@emp_fname,@emp_lname,@dept_no)
select * from Employee
end

exec InsertDataIntoEmployee1 12234,'lakshmi','singamsetty','d2'










