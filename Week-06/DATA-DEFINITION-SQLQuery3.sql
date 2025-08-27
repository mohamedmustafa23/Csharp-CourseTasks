--1.Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).

CREATE TABLE Employees(
	ID INT,
	Name VARCHAR(50),
	Salary DECIMAL(8,2)
	);
GO

--2.Add a new column named "Department" to the "Employees" table with data type varchar(50).

ALTER TABLE Employees
ADD Department VARCHAR(50);

--3.Remove the "Salary" column from the "Employees" table.

ALTER TABLE Employees
DROP COLUMN Salary;

--4.Rename the "Department" column in the "Employees" table to "DeptName".

ALTER TABLE Employees
ADD DeptName VARCHAR(50);
GO

UPDATE Employees 
SET Department = DeptName;
GO

ALTER TABLE Employees
DROP COLUMN Department;
Go

--5.Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).

CREATE TABLE Projects(
	ProjectID INT,
	ProjectName VARCHAR(50)
	);
GO

--6.Add a primary key constraint to the "Employees" table for the "ID" column.

ALTER TABLE Employees
ALTER COLUMN ID INT NOT NULL;
GO

ALTER TABLE Employees
ADD CONSTRAINT PK_EMPLOYEE_ID PRIMARY KEY (ID);
GO

--7.Add a unique constraint to the "Name" column in the "Employees" table.

ALTER TABLE Employees
ADD CONSTRAINT UQ_Employees_Name UNIQUE (Name);
GO

--8.Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).

CREATE TABLE Customers(
	CustomerID INT,
	FirstName VARCHAR(20),
	LastaName VARCHAR(20),
	Email VARCHAR(50),
	Status VARCHAR(20)
	)
GO

--9.Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.

ALTER TABLE Customers
ADD CONSTRAINT UQ_Customer_FullName UNIQUE (FirstName, LastaName)
GO

--10.Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).

CREATE TABLE Orders(
	OrderID INT,
	CustomerID INT,
	OrderDate DATETIME,
	TotalAmount DECIMAL(10,2)
	);
GO

--11.Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.

ALTER TABLE Orders
ADD CONSTRAINT CHEK_TOTALAMOUNT CHECK (TotalAmount > 0);
GO

--12.Create a schema named "Sales" and move the "Orders" table into this schema.

CREATE SCHEMA Sales;
GO

ALTER SCHEMA Sales TRANSFER dbo.Orders;
go

--13.Rename the "Orders" table to "SalesOrders."

EXEC sp_rename 'Sales.SalesOrders' , 'SalesOrders';
GO