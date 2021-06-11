CREATE TABLE Customer (
name nvarchar(30),
surname nvarchar(30), 
login nvarchar(30),
pin nvarchar(30),
accountBalance BIGINT,
accountsNumber BIGINT
)

CREATE TABLE Transfer (
source nvarchar(30),
destiny nvarchar(30),
money BIGINT
)

INSERT INTO Bank.dbo.Customer VALUES('B³a¿ej', 'Big', 'bis', '943', 0, 923081231);
Select * FROM Bank.dbo.Customer;
Select * FROM Bank.dbo.Transfer;

INSERT INTO Bank.dbo.Transfer VALUES(298289231, 420285231, 450);
