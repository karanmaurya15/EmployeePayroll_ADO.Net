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

--RectriveData
CREATE PROCEDURE SPRetrieveAllDetails
AS BEGIN 
SELECT * FROM Employee_payroll
END

--Update
CREATE PROCEDURE SPUpdateDataInDB(
@SurName VARCHAR(30),
@TypeOfAddressBook VARCHAR(30),
@Mobile bigint
)
AS BEGIN
UPDATE Address_Book_Table SET Type = @TypeOfAddressBook, PhoneNumber = @Mobile WHERE LastName = @SurName
END