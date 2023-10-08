create database Assignment_2

use Assignment_2

--EMP(empno, ename, job, mgr-id, hiredate, sal, comm., deptno) 

--DEPT(deptno, dname, loc) 

create table EMP(
empno int primary key,
ename varchar(40),
job varchar(40),
mgr_id int,
hiredate date,
sal int,
comm int)


create table DEPT(
deptno int primary key,
dname varchar(40),
loc varchar(40))

insert into EMP values(7369,'SMITH','CLERK',7902 ,'17-DEC-80 ', 800,null, 20),
         (7499,'ALLEN ','SALESMAN',7698 ,'20-FEB-81 ', 1600,300, 30),
         (7521,'WARD','SALESMAN',7698 ,'22-FEB-81 ',  1250 ,500, 30),
		 (7566,'JONES','MANAGER',7839 ,'02-APR-81 ',   2975 ,null, 20),
		 (7654,'MARTIN','SALESMAN',7698 ,'28-SEP-81 ',  1250 ,1400, 30),
		 (7698,'BLAKE','MANAGER',7839 ,'01-MAY-81  ',  2850,null, 30),
		 (7782,'CLARK','MANAGER',7839 ,'09-JUN-81 ',2450 ,null, 10),
		 (7788,'SCOTT',' ANALYST ',7566 ,' 19-APR-87',3000,null, 20),
		 (7839,'KING','PRESIDENT',null ,'17-NOV-81  ', 5000,null, 10),
		 (7844 ,'TURNER','SALESMAN',7698 ,'08-SEP-81 ', 1500,0, 30),
		 (7876,' ADAMS ','CLERK',7788 ,'23-MAY-87 ', 1100 ,null, 20),
		 (7900,'JAMES','CLERK',7698 ,' 03-DEC-81 ', 950 ,null, 30),
		 (7902 ,' FORD',' ANALYST ',7566 ,'03-DEC-81 ', 3000,null, 20),
		 (7934,'MILLER','CLERK',7782 ,'23-JAN-82 ',  1300,null, 10)


insert into DEPT values
(10,'accounting','new york'),
(20,'research','dallas'),
(30,'sales','chicago'),
(40,'operations','boston')

select * from EMP
select * from DEPT

select * from EMP
where ename like 'A%'

select * from EMP
where job != ' MANAGER '

-- List employee name, number and salary for those employees who earn in the range 1200 to 1400.

select ename,empno,sal from EMP
where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
update EMP
set sal = sal*1.1
where deptno = 20

--5. Find the number of CLERKS employed. Give it a descriptive heading. 

select count (*)  'Number of CLERKS Employed'
from EMP
where job = 'CLERKS'

--6. Find the average salary for each job type and the number of people employed in each job. 

select job, avg(sal) as "Avg Salary", count (*) as "Number of people employed"
from EMP
group by job

--7. List the employees with the lowest and highest salary.

select * from EMP
where sal = (select min(sal) from EMP)
select * from EMP
where sal = (select max(sal) from EMP)

--8. List full details of departments that don't have any employees. 

select * from DEPT
where deptno NOT IN (select distinct deptno from EMP)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.Sort the answer by ascending order of name

select ename, sal from EMP
where job = 'ANALYST' AND sal > 1200 AND deptno = 20
order by ename ASC

--10. For each department, list its name and number together with the total salary paid to employees in that department

select d.dname, d.deptno, SUM(e.sal) 
AS "Total Salary" 
from DEPT d
LEFT JOIN EMP e ON d.deptno = e.deptno
group by d.dname, d.deptno

--11. Find out salary of both MILLER and SMITH.

select ename, sal
from EMP
where ename in ( 'MILLER' , 'SMITH' ) 

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.  

select ename 
from EMP
where ename LIKE 'A%' OR ename LIKE 'M%'

--13. Compute yearly salary of SMITH. 

select ename, sal * 12 AS "Yearly Salary"
from EMP
where ename = 'SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.

select ename, sal from EMP
where sal NOT BETWEEN 1500 AND 2850

--15. Find all managers who have more than 2 employees reporting to them

 select e.ename AS "Manager Name" from EMP e
JOIN (select mgr_id, count(*) AS emp_count
      from EMP
      group by mgr_id
      having count(*) > 2) m ON e.empno = m.mgr_id