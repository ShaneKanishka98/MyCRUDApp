STEP 01 : Execute Query in DB End

CREATE DATABASE DatabaseFirstDB;

USE DatabaseFirstDB;

CREATE TABLE Customer
(CustomerId INT PRIMARY KEY IDENTITY(1,1),
CustomerName VARCHAR NOT NULL,
CustomerAmmount FLOAT);

STEP 02 : First Approach: Run the below command in Nuget package Console

{ Scaffold-DbContext "Server=LAPTOP-75O0631G;Database=DatabaseFirstDB;Integrated Security=true;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models }

STEP 03 : If you have updated the table attribute then you can run the below command after updating in DB end

{ Scaffold-DbContext "Server=LAPTOP-75O0631G;Database=DatabaseFirstDB;Integrated Security=true;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force }
