create Database Code_Base_Test_02

use Code_Base_Test_02

Create table Code_Employeese(empno int primary key,
empname varchar(35) not null,
empsal numeric(10,2) check (empsal >=0),
emptype char(1) check (emptype in ('F','P')))


CREATE PROCEDURE Add_Employeeese

    @empname varchar(35),
    @empsal decimal(10,2),
    @emptype char(1)
AS
BEGIN
   declare @empno int;
    set @empno = (select isnull(max(empno), 0) + 1 from Code_Employeese);
    INSERT INTO Code_Employeese(empno, empname, empsal, emptype)
    VALUES (@empno, @empname, @empsal, @emptype)
END;

EXEC Add_Employeeese 'Arun',8000.00,'F'
EXEC Add_employeeese 'Kumar',5001.00,'P'

select * from Code_Employeese


-- solution 2

use Assignment_2


declare @empnum numeric(4)
declare @salary int


declare employee_cursors cursor for
select empno, sal
from emp
where deptno = 10;

open employee_cursors;

 
fetch next from employee_cursors INTO @empnum, @salary;

 
while @@FETCH_STATUS = 0
begin
    -- Updating the salary with a 15% increase
    UPDATE emp
    set sal = sal * 1.15
    where empno = @empnum;

   
    fetch next from employee_cursors into @empnum, @salary
end

 

close employee_cursors
deallocate employee_cursors


select * from Emp where deptno = 10