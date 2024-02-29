GRANT ALL PRIVILEGES ON * . * TO 'atip'@'%' ;
CREATE TABLE `tests` (
  id INT PRIMARY KEY AUTO_INCREMENT, 
  name VARCHAR(255),
  email VARCHAR(255)
);

INSERT INTO tests (name,email) VALUES ('test','email');
INSERT INTO tests (name,email) VALUES ('test1','email1');