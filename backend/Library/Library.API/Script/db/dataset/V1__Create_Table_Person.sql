CREATE TABLE persons (
  id INT PRIMARY KEY IDENTITY(1,1),
  first_name varchar(80) NOT NULL,
  last_name varchar(80) NOT NULL,
  address varchar(100) NOT NULL,
  gender varchar(6) NOT NULL
) 