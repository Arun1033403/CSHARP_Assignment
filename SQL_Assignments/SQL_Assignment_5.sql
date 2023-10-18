CREATE DATABASE SQL_Assignment_5
use SQL_Assignment_5

Create procedure GeneratePayslip
    @EmployeeID int,
    @Salary decimal(10, 2)
as
begin
    declare @HRA decimal(10, 2)
    declare @DA decimal(10, 2)
    declare @PF decimal(10, 2)
    declare @IT decimal(10, 2)
    declare @Deductions decimal(10, 2)
    declare @GrossSalary decimal(10, 2)
    declare @NetSalary decimal(10, 2)

    set @HRA = 0.10 * @Salary
    set @DA = 0.20 * @Salary
    set @PF = 0.08 * @Salary
    set @IT = 0.05 * @Salary

    set @Deductions = @PF + @IT

    set @GrossSalary = @Salary + @HRA + @DA

    set @NetSalary = @GrossSalary - @Deductions

    select 'Employee ID: ' + CAST(@EmployeeID AS VARCHAR(10)) AS 'Payslip'
    select   'Basic Salary: ' + CAST(@Salary AS VARCHAR(10)) AS ' '
    select    'HRA: ' + CAST(@HRA AS VARCHAR(10)) AS ' '
    select    'DA: ' + CAST(@DA AS VARCHAR(10)) AS ' '
    select    'PF: ' + CAST(@PF AS VARCHAR(10)) AS ' '
    select   'IT: ' + CAST(@IT AS VARCHAR(10)) AS ' '
    select   'Deductions: ' + CAST(@Deductions AS VARCHAR(10)) AS ' '
    select   'Gross Salary: ' + CAST(@GrossSalary AS VARCHAR(10)) AS ' '
    select'Net Salary: ' + CAST(@NetSalary AS VARCHAR(10)) AS ' '
end
EXEC GeneratePayslip @EmployeeID = 1, @Salary = 1234000.00