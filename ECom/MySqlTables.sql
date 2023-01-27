DROP TABLE IF EXISTS products;
CREATE TABLE products(id int NOT NULL AUTO_INCREMENT, name varchar(30),description varchar(30),unitprice double,quantity int,imageurl text,PRIMARY KEY(id));
