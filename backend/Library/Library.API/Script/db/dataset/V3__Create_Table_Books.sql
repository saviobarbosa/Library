CREATE TABLE books (
  id INT PRIMARY KEY IDENTITY(1,1),
  author VARCHAR(80),
  launch_date VARCHAR NOT NULL,
  price decimal NOT NULL,
  title VARCHAR(80)
)
