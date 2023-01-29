DROP TABLE IF EXISTS products;
CREATE TABLE products(id int NOT NULL AUTO_INCREMENT, name varchar(30),description varchar(30),unitprice double,quantity int,imageurl text,PRIMARY KEY(id));

DROP TABLE IF EXISTS shoppingCart;
CREATE TABLE shoppingCart(id int NOT NULL AUTO_INCREMENT, userid int, productid int, PRIMARY KEY(id));
