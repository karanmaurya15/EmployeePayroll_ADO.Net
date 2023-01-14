--Add Table
CREATE TABLE Emppayroll(Id INT,
Name VARCHAR(40),
Salary bigint,
Start DATE,
Gender varchar(6),
PhoneNumber varchar(16),
Address VARCHAR(100),
);

CREATE PROCEDURE SPAddNewEmployee(
@Id int,
@Name VARCHAR(40),
@Salary bigint,
@Start DATE,
@Gender varchar(6),
@PhoneNumber varchar(16),
@Address VARCHAR(100)
)