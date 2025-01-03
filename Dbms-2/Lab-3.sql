CREATE TABLE Departments (
 DepartmentID INT PRIMARY KEY,
 DepartmentName VARCHAR(100) NOT NULL UNIQUE,
 ManagerID INT NOT NULL,
 Location VARCHAR(100) NOT NULL
);
CREATE TABLE Employee (
 EmployeeID INT PRIMARY KEY,
 FirstName VARCHAR(100) NOT NULL,
 LastName VARCHAR(100) NOT NULL,
 DoB DATETIME NOT NULL,
 Gender VARCHAR(50) NOT NULL,
 HireDate DATETIME NOT NULL,
 DepartmentID INT NOT NULL,
 Salary DECIMAL(10, 2) NOT NULL,
 FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
-- Create Projects Table
CREATE TABLE Projects (
 ProjectID INT PRIMARY KEY,
 ProjectName VARCHAR(100) NOT NULL,
 StartDate DATETIME NOT NULL,
 EndDate DATETIME NOT NULL,
 DepartmentID INT NOT NULL,
  FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
INSERT INTO Departments (DepartmentID, DepartmentName, ManagerID, Location)
VALUES
 (1, 'IT', 101, 'New York'),
 (2, 'HR', 102, 'San Francisco'),
 (3, 'Finance', 103, 'Los Angeles'),
 (4, 'Admin', 104, 'Chicago'),
 (5, 'Marketing', 105, 'Miami');
INSERT INTO Employee (EmployeeID, FirstName, LastName, DoB, Gender, HireDate, DepartmentID,
Salary)
VALUES
 (101, 'John', 'Doe', '1985-04-12', 'Male', '2010-06-15', 1, 75000.00),
 (102, 'Jane', 'Smith', '1990-08-24', 'Female', '2015-03-10', 2, 60000.00),
 (103, 'Robert', 'Brown', '1982-12-05', 'Male', '2008-09-25', 3, 82000.00),
 (104, 'Emily', 'Davis', '1988-11-11', 'Female', '2012-07-18', 4, 58000.00),
 (105, 'Michael', 'Wilson', '1992-02-02', 'Male', '2018-11-30', 5, 67000.00);
INSERT INTO Projects (ProjectID, ProjectName, StartDate, EndDate, DepartmentID)
VALUES
 (201, 'Project Alpha', '2022-01-01', '2022-12-31', 1),
 (202, 'Project Beta', '2023-03-15', '2024-03-14', 2),
 (203, 'Project Gamma', '2021-06-01', '2022-05-31', 3),
 (204, 'Project Delta', '2020-10-10', '2021-10-09', 4),
 (205, 'Project Epsilon', '2024-04-01', '2025-03-31', 5);

---------------------------------Part – A----------------------------------------------------
--1. Create Stored Procedure for Employee table As User enters either First Name or Last Name and based
--on this you must give EmployeeID, DOB, Gender & Hiredate.
	Create or Alter Procedure Pr_Employee_GetByName
	@FirstName varchar(30) = Null,
	@LastName varchar(30) = Null
	As
	Begin
		Select EmployeeID,DoB,Gender,HireDate
		From Employee 
		Where (FirstName = @FirstName)
		Or
		(LastName = @LastName)
	End

	exec Pr_Employee_GetByName 'Robert'
	
--2. Create a Procedure that will accept Department Name and based on that gives employees list who
--belongs to that department. 
	Create Or Alter Procedure Pr_Departement_Name
	@Dname varchar(100)
	As
	Begin
		Select * From Employee 
		Where EmployeeID = (Select ManagerID From Departments Where DepartmentName = @Dname)
	End
	exec Pr_Departement_Name Hr

--3. Create a Procedure that accepts Project Name & Department Name and based on that you must give
--all the project related details.
	Create OR Alter PROCEDURE Pr_Project_Name
	@PName varchar(100),
	@DName varchar(100)
	AS
	BEGIN
		SELECT * FROM PROJECTS WHERE ProjectName=@PName AND DepartmentID = (Select DepartmentID from Departments where DepartmentName=@DName)
	END
	Exec Pr_Project_Name 'Project Alpha ','It'
	
--4. Create a procedure that will accepts any integer and if salary is between provided integer, then those
--employee list comes in output.
	Create Or Alter Procedure Pr_Employee_Salary
	@MinSalary Decimal(10,2),
	@MaxSalary Decimal(10,2)
	As
	Begin 
		Select * From Employee 
		Where Salary Between @MinSalary And @MaxSalary
	End
	exec Pr_Employee_Salary 2000,59000
--5. Create a Procedure that will accepts a date and gives all the employees who all are hired on that date.
	Create Or Alter Procedure Pr_Employee_Hire
	@Date datetime
	As
	Begin
		Select * From Employee 
		Where HireDate = @Date
	End

	exec Pr_Employee_Hire '2010-06-15'

---------------------------------------Part – B--------------------------------------------
--6. Create a Procedure that accepts Gender’s first letter only and based on that employee details will be
--served.
	Create Or Alter Procedure Pr_Employee_Gender
	@Gender char(1)
	As
	Begin
		Select * From Employee Where SUBSTRING(Gender,1,1) = @Gender
	End

	Exec Pr_Employee_Gender m

--7. Create a Procedure that accepts First Name or Department Name as input and based on that employee
--data will come.
	Create Or Alter Procedure Pr_Employee_Name
	@FirstName varchar(30) = null,
	@Department varchar(30) = null
	As
	Begin
		Select * From Employee
		Where FirstName = @FirstName Or DepartmentID = 
			(Select DepartmentID From Departments Where DepartmentName = @Department)
	End
	Exec Pr_Employee_Name '','Admin'

--8. Create a procedure that will accepts location, if user enters a location any characters, then he/she will
--get all the departments with all data.
	Create Or Alter Procedure Pr_Departements_Location
	@Location varchar(100)
	As
	Begin
		Select *From Departments Where Location Like '%'+@Location+'%'
	End
	Exec Pr_Departements_Location 'New York'
--------------------------------------------Part – C------------------------------------
--9. Create a procedure that will accepts From Date & To Date and based on that he/she will retrieve Project
--related data.
	Create Or Alter Procedure Pr_Project_Date
	@Fromdate datetime,
	@Todate datetime
	As
	Begin
		Select* From Projects 
		Where StartDate =@Fromdate And EndDate = @Todate
	End
	Exec Pr_Project_Date '2022-01-01','2022-12-31'

--10. Create a procedure in which user will enter project name & location and based on that you must
--provide all data with Department Name, Manager Name with Project Name & Starting Ending Dates. 
	Create Or Alter Procedure Pr_Project_Departement
	@PName varchar(100),
	@Location varchar(100)
	AS
	BEGIN
		SELECT d.DepartmentName,e.FirstName,e.LastName,p.ProjectName,p.StartDate,p.EndDate FROM Projects as p join Departments as d on p.DepartmentID=d.DepartmentID join Employee as e on e.EmployeeID=d.ManagerID
		where p.ProjectName=@PName and d.Location=@Location
	END
	Exec Pr_Project_Departement 'Project Alpha','New York'