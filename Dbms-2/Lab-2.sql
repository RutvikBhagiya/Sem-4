-- Create Department Table
CREATE TABLE Department (
 DepartmentID INT PRIMARY KEY,
 DepartmentName VARCHAR(100) NOT NULL UNIQUE
);
-- Create Designation Table
CREATE TABLE Designation (
 DesignationID INT PRIMARY KEY,
 DesignationName VARCHAR(100) NOT NULL UNIQUE
);
-- Create Person Table
CREATE TABLE Person (
 PersonID INT PRIMARY KEY IDENTITY(101,1),
 FirstName VARCHAR(100) NOT NULL,
 LastName VARCHAR(100) NOT NULL,
 Salary DECIMAL(8, 2) NOT NULL,
 JoiningDate DATETIME NOT NULL,
 DepartmentID INT NULL,
 DesignationID INT NULL,
 FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
 FOREIGN KEY (DesignationID) REFERENCES Designation(DesignationID)
);


--Part – A
--1. Department, Designation & Person Table’s INSERT, UPDATE & DELETE Procedures.
	--Department
		Create Or Alter Procedure Pr_Department_Insert
		@DID int,
		@DName varchar(30)
		As 
		Begin
			Insert Into Department values(@DID,@DName)
		End
		Exec Pr_Department_Insert 1,'Admin';
		Exec Pr_Department_Insert 2,'IT';
		Exec Pr_Department_Insert 3,'HR';
		Exec Pr_Department_Insert 4,'Acoount';
		select * from Department
		
	--Designation
		Create Or Alter Procedure Pr_Designation_Insert
		@DeID int,
		@DeName varchar(30)
		As 
		Begin 
			Insert Into Designation values(@DeID,@DeName)
		End
		Exec Pr_Designation_Insert 11,'Jobber'
		Exec Pr_Designation_Insert 12,'Welder'
		Exec Pr_Designation_Insert 13,'Clerk'
		Exec Pr_Designation_Insert 14,'Manager'
		Exec Pr_Designation_Insert 15,'CEO'

		select * from Designation
		
	--Person
		Create Or Alter Procedure Pr_Person_Insert
		@FirstName varchar(30),
		@LastName varchar(30),
		@Salary Decimal(8,2),
		@JoiningDate Datetime,
		@DepartmentID int,
		@DesignationID int
		As 
		Begin 
			Insert Into Person values(@FirstName,@LastName,@Salary,@JoiningDate,@DepartmentID,@DesignationID)
		End
		Exec Pr_Person_Insert 'Rahul','Anshu',56000,'1990-01-01',1,12
		Exec Pr_Person_Insert 'Hardik','Hinsu',18000,'1990-09-25',2,11
		Exec Pr_Person_Insert 'Bhavin','Kamani',25000,'1991-05-14',NULL,11
		Exec Pr_Person_Insert 'Bhoomi','Patel',39000,'2014-02-20',1,13
		Exec Pr_Person_Insert 'Rohit','Rajgor',17000,'1990-07-23',2,15
		Exec Pr_Person_Insert 'Priya','Mehta',25000,'1990-10-18',2,NULL
		Exec Pr_Person_Insert 'Neha','Trivedi',18000,'2014-02-20',3,15
		select * from person
	
	
	--Department
		Create Or Alter Procedure Pr_Department_Update
		@DID int,
		@DName varchar(30)
		As 
		Begin 
			Update Department Set DepartmentName=@DName Where DepartmentID=@DID 
		End
		Exec Pr_Department_Update 3,'CE'

	--Designation
		Create Or Alter Procedure Pr_Designation_Update
		@DeID int,
		@DeName varchar(30)
		As 
		Begin 
			Update Designation Set DesignationName=@DeName Where DesignationID=@DeID 
		End
		Exec Pr_Designation_Update 13,'Vidhayak'

	--Person
		Create Or Alter Procedure Pr_Person_Update
		@PesonID int,
		@FirstName varchar(30),
		@LastName varchar(30),
		@Salary Decimal(8,2),
		@JoiningDate Datetime,
		@DepartmentID int,
		@DesignationID int
		As 
		Begin 
			Update Person 
			Set 
				FirstName=@FirstName,
				LastName = @LastName,
				Salary = @Salary,
				JoiningDate = @JoiningDate,
				DepartmentID = @DepartmentID,
				DesignationID = @DesignationID
			Where 
				PersonID=@PesonID
		End
		Exec Pr_Person_Update 101,'Rahul','Anshu',10300,'1990-01-01',1,12


	--Department
		Create Or Alter Procedure Pr_Department_Delete
		@DID int
		As 
		Begin 
			Delete From Department Where DepartmentID=@DID 
		End
		Exec Pr_Department_Delete 1

	--Designation
		Create Or Alter Procedure Pr_Designation_Delete
		@DeID int
		As 
		Begin 
			Delete From Designation Where DesignationID=@DeID 
		End
		Exec Pr_Designation_Delete 11

	--Person
		Create Or Alter Procedure Pr_Person_Delete
		@PersonID int
		As 
		Begin 
			Delete From Person Where PersonID=@PersonID 
		End
	
--2. Department, Designation & Person Table’s SELECTBYPRIMARYKEY

	--Department
		Create Or Alter Procedure Pr_Department_SelectBy
		@DID int
		As 
		Begin
			Select * From Department Where DepartmentID=@DID
		End
		Exec Pr_Department_SelectBy 1

	--Designation
		Create Or Alter Procedure Pr_Designation_SelectBy
		@DeID int
		As 
		Begin
			Select * From Designation Where DesignationID=@DeID
		End
		Exec Pr_Designation_SelectBy 11

	--Person
		Create Or Alter Procedure Pr_Person_SelectBy
		@PersonID int
		As 
		Begin
			Select * From Person Where PersonID=@PersonID
		End
		Exec Pr_Person_SelectBy 101
--3. Department, Designation & Person Table’s (If foreign key is available then do write join and take
--columns on select list)
	Create Or Alter Procedure Pr_Department_SelectAll
	as
	Begin
		Select Department.DepartmentID,DepartmentName,FirstName 
		From Department 
		Join Person
		On Department.DepartmentID = Person.DepartmentID
		join Designation
		On Designation.DesignationID = Person.DesignationID
		
	End
	Exec Pr_Department_SelectAll
	
--4. Create a Procedure that shows details of the first 3 persons
	Create Or Alter Proc Pr_Top_3
	As
	Begin
		Select Top 3 * From Person
	End
	Exec Pr_Top_3

------------------------Part-B-------------------------------
--5. Create a Procedure that takes the department name as input and returns a table with all workers 
--working in that department.
	Create Or Alter Procedure Pr_Dept_Work
	@DeptName varchar(30)
	As
	Begin
		Select PersonID,FirstName,Department.DepartmentID
		From Person
		Inner Join Department
		On Person.DepartmentID = Department.DepartmentID
		Where DepartmentName = @DeptName
	End
	Exec Pr_Dept_Work 'Admin'
--6. Create Procedure that takes department name & designation name as input and returns a table with 
--worker’s first name, salary, joining date & department name.
	Create Or Alter Procedure Pr_Dept_Desi
	@DeptName varchar(30),
	@DesiName varchar(30)
	As
	Begin
		Select FirstName,Salary,JoiningDate,DepartmentName
		From Person
		Inner Join Department
		On Person.DepartmentID = Department.DepartmentID
		Inner Join Designation
		On Person.DesignationID = Designation.DesignationID
		Where DepartmentName = @DeptName And DesignationName = @DesiName
	End
	Exec Pr_Dept_Desi 'Admin','Welder'

--7. Create a Procedure that takes the first name as an input parameter and display all the details of the 
--worker with their department & designation name.
	Create Or Alter Procedure Pr_Selectby_Firstname
	@FName Varchar(30)
	As
	Begin
		Select PersonID,FirstName,LastName,Salary,JoiningDate,DepartmentName,DesignationName 
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		join Designation
		On Person.DesignationID = Designation.DesignationID
		Where Person.FirstName = @FName
	End
	Exec Pr_Selectby_Firstname 'Rahul'

--8. Create Procedure which displays department wise maximum, minimum & total salaries.
	Create Or  Alter Procedure Pr_Dept_MaxMinTotal
	As
	Begin
		Select DepartmentName, 
			MAX(Salary) As Max_Salary,
			MIN(Salary) As Min_Salary,
			SUM(Salary) As Total_Salary
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		Group By DepartmentName
	End
	Exec Pr_Dept_MaxMinTotal

--9. Create Procedure which displays designation wise average & total salaries
	Create Or Alter Procedure Pr_Desi_AvgTotal
	As
	Begin
		Select DesignationName,
			AVG(Person.Salary) As Average_Salary,
			SUM(Person.Salary) As Total_Salary
		From Person
		Join Designation
		On Person.DesignationID = Designation.DesignationID
		Group By DesignationName
	End
	Exec Pr_Desi_AvgTotal

---------------------------------------Part-C---------------------------------------
--10. Create Procedure that Accepts Department Name and Returns Person Count.

	Create Or Alter Procedure Pr_Person_Count
		@DepartmentName Varchar(100)
	As
	Begin
		Select COUNT(PersonID) As Person_Count
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		Where Department.DepartmentName = @DepartmentName
	End
	Exec Pr_Person_Count 'IT'

--11. Create a procedure that takes a salary value as input and returns all workers with a salary greater than 
--input salary value along with their department and designation details. 

	Create Or Alter Procedure Pr_Salary_AllDetail
		@Salary Int
	As
	Begin
		Select 
			Person.PersonID,
			Person.FirstName,
			Person.LastName,
			Person.Salary,
			Person.JoiningDate,
			Department.DepartmentName, 
			Designation.DesignationName 
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		join Designation
		On Person.DesignationID = Designation.DesignationID
		Where Person.Salary > @Salary
	End
	Exec Pr_Salary_AllDetail 50000

--12. Create a procedure to find the department(s) with the highest total salary among all departments.

--13. Create a procedure that takes a designation name as input and returns a list of all workers under that 
--designation who joined within the last 10 years, along with their department.

	Create Or Alter Procedure Pr_Worker_10Year
		@DesignationName Varchar(100)
	As
	Begin
		Select
			Person.PersonID,
			Person.FirstName,
			Person.LastName,
			Person.Salary,
			Person.JoiningDate,
			Department.DepartmentName, 
			Designation.DesignationName 
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		join Designation
		On Person.DesignationID = Designation.DesignationID
		Where Designation.DesignationName = @DesignationName
				And  DATEDIFF(Year,Person.JoiningDate , GEtDAte()) > 10
	End 
	Exec Pr_Worker_10Year 'Jobber'

--14. Create a procedure to list the number of workers in each department who do not have a designation 
--assigned. 

	Create Or Alter Procedure Pr_NoOFWorker_DesNull
	As
	Begin
		Select COUNT(Person.PersonID) As WithoutDesignationCount ,Department.DepartmentName
		From Person
		Join Department 
		On Person.DepartmentID = Department.DepartmentID
		Where Person.DesignationID IS Null
		group By Department.DepartmentName

	End
	Exec Pr_NoOFWorker_DesNull

--15. Create a procedure to retrieve the details of workers in departments where the average salary is above 
--12000

	Create Or Alter Procedure Pr_SalaryAbove_12000
	As
	Begin
		Select
			AVG(Person.Salary),
			Person.PersonID,
			Person.FirstName,
			Person.LastName,
			Person.Salary,
			Person.JoiningDate,
			Department.DepartmentName
		From Person
		Join Department
		On Person.DepartmentID = Department.DepartmentID
		Where Person.DesignationID In 
			(
				SELECT Person.DepartmentID FROM Person
				GROUP BY Person.DepartmentID
				HAVING AVG(Person.Salary) > 12000
			)
	End
	Exec Pr_Selectby_Firstname 'Rahul'
