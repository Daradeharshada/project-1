use CRMDB;

DROP TABLE IF EXISTS custTable;


CREATE TABLE custTable
(
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Phone VARCHAR(15),
    City VARCHAR(50),
    CreatedDate DATETIME DEFAULT GETDATE()
);
INSERT INTO custTable
(FirstName, LastName, Email, Phone, City)
VALUES
('Priya', 'Verma', 'priya@gmail.com', '9123456780', 'Delhi'),

('Amit', 'Patel', 'amit@gmail.com', '9988776655', 'Ahmedabad'),

('Sneha', 'Rao', 'sneha@gmail.com', '9090909090', 'Bangalore');
select * from  custTable;
