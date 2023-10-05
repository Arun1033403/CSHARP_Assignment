create Database SQL_1

-- Create Employees Clients
create table Clients (
    Client_ID INT PRIMARY KEY,
    Cname varchar(40) NOT NULL,
    Address varchar(30),
    Email varchar(30) UNIQUE,
    Phone varchar(10),
    Business varchar(20) NOT NULL
);


-- Departments table

create table Departments (
    Deptno int PRIMARY KEY,
    Dname varchar(15) NOT NULL,
    Loc varchar(20)
);


-- Employees table

create table Employees (
    Empno int PRIMARY KEY,
    Ename varchar(20) NOT NULL,
    Job varchar(15),
    Salary int check (Salary > 0),
    Deptno int,
    CONSTRAINT fk_deptno FOREIGN KEY (Deptno) references Departments(Deptno)
);

 

-- Create Projects table
create table Projects (
    Project_ID int PRIMARY KEY,
    Descr varchar(30) NOT NULL,
    Start_Date DATE,
    Planned_End_Date DATE,
    Actual_End_date DATE, check (Actual_End_date > Planned_End_Date),
    Budget int check (Budget > 0),
    Client_ID  int,
    CONSTRAINT fk_client_id FOREIGN KEY (Client_ID) references Clients(Client_ID)
);


-- Create EmpProjectTasks table
create table EmpProjectTasks (
    Project_ID int,
    Empno int,
    Start_Date DATE,
    End_Date DATE,
    Task varchar(25) NOT NULL,
    Status varchar(15) NOT NULL,
    PRIMARY KEY (Project_ID, Empno),
    CONSTRAINT fk_project_id FOREIGN KEY (Project_ID) references Projects(Project_ID),
    CONSTRAINT fk_empno FOREIGN KEY (Empno) references Employees(Empno)
);	

 
--Insert values into the clients table
insert into Clients values(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
    (1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
    (1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
    (1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional');

 

----------------------------------------------------------
--Insert values into the Departments table
	insert into Departments values (10, 'Design', 'Pune'),
    (20, 'Development', 'Pune'),
    (30, 'Testing', 'Mumbai'),
    (40, 'Document', 'Mumbai');
 

-------------------------------------------------------------
--Insert values into the Employees table
	insert into Employees values(7001, 'Sandeep', 'Analyst', 25000, 10),
    (7002, 'Rajesh', 'Designer', 30000, 10),
    (7003, 'Madhav', 'Developer', 40000, 20),
    (7004, 'Manoj', 'Developer', 40000, 20),
    (7005, 'Abhay', 'Designer', 35000, 10),
    (7006, 'Uma', 'Tester', 30000, 30),
    (7007, 'Gita', 'Tech. Writer', 30000, 40),
    (7008, 'Priya', 'Tester', 35000, 30),
    (7009, 'Nutan', 'Developer', 45000, 20),
    (7010, 'Smita', 'Analyst', 20000, 10),
    (7011, 'Anand', 'Project Mgr', 65000, 10);

 

--Insert values into the Projects table
	insert into Projects values(401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
    (402, 'Accounting', '2011-08-01', '2012-01-01', NULL, 500000, 1002),
    (403, 'Payroll', '2011-10-01', '2011-12-31', NULL, 75000, 1003),
    (404, 'Contact Mgmt', '2011-11-01', '2011-12-31', NULL, 50000, 1004);

 

--Insert values into the EmpProjectTasks bar
	insert into EmpProjectTasks values(401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
    (401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
    (401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
    (401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed'),
    (401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
    (401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
    (401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
    (401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
    (401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed'),
    (402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
    (402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed'),
    (402, 7004, '2011-10-01', NULL, 'Coding', 'In Progress');
    

	select * from Clients
	select * from Employees
	select * from Departments
	select * from EmpProjectTasks
	select * from Projects