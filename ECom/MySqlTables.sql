DROP TABLE IF EXISTS roles;
CREATE TABLE roles(id int NOT NULL AUTO_INCREMENT, title varchar(100));
INSERT INTO roles values(1,'Electronics');
INSERT INTO roles values(2,'Fashion');
INSERT INTO roles values(3,'Decorations');

DROP TABLE IF EXISTS categories;
CREATE TABLE categories(id int NOT NULL AUTO_INCREMENT, title varchar(100));
INSERT INTO categories values(1,'Admin');
INSERT INTO categories values(2,'Customer');
INSERT INTO categories values(3,'Seller');

DROP TABLE IF EXISTS products;
CREATE TABLE products(id int NOT NULL AUTO_INCREMENT, name varchar(30),description varchar(30),unitprice double,quantity int,imageurl text,PRIMARY KEY(id));

DROP TABLE IF EXISTS carts;
CREATE TABLE carts(id int NOT NULL AUTO_INCREMENT, userid int, productid int, quantity int, unitprice double, PRIMARY KEY(id), FOREIGN KEY(productid) REFERENCES products(id));

DROP TABLE IF EXISTS users;
CREATE TABLE users(id int NOT NULL AUTO_INCREMENT, firstname varchar(50), lastname varchar(50), email varchar(100), password varchar(50), contactnumber varchar(20), roleid int FOREIGN KEY(roleid) REFERENCES roles(id));
INSERT INTO users(firstname,lastname,email,password,contactnumber,roleid) values("Jeremy","Gojer","gojerjeremy@gmail.com","Jeremy","7019294131",1);
INSERT INTO users(firstname,lastname,email,password,contactnumber,roleid) values("Saleel","Bagde","saleel.songs@gmail.com","saleel","2222222222",2);