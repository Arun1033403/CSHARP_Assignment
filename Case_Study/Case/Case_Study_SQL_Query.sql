create database StudentandCourseDetails

create table student (
id int primary key,
name varchar(50), 
dob date,
courseid int, foreign key (courseid) references course(id))

create table course(
id int primary key,
name varchar(50))

select* from student
select* from course