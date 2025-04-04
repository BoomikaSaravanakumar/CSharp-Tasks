--------------------------------------------------------
create database EcommerceSite;
use EcommerceSite;

--------------creating tables--------------
create table customers(customer_id  int  constraint PK_Cus_id Primary Key,Cname varchar(30),
email varchar(100),cpassword varchar(20),CAddress varchar(35));

create table products (product_id int constraint PK_PID Primary Key, pname varchar(20),
price decimal(10,2),pro_description varchar(50), stockQuantity int);


create table cart (cart_id int constraint PK_Cart_id Primary key,customer_id  int,
product_id int,quantity int, constraint FK_CID foreign key (customer_id) references customers(customer_id), 
constraint FK_Pro_id foreign key (product_id) references products(product_id));

create table orders(order_id int constraint PK_OID primary key,customer_id int,
order_date date,total_price decimal(10,2),shipping_address varchar(50), constraint FK_Cust_id
foreign key(customer_id) references customers(customer_id));

create table order_items(order_item_id int constraint PK_id primary key,order_id int,
product_id int, quantity int ,itemAmount decimal(10,2), constraint FK_OID1 foreign key(order_id)
references orders(order_id),constraint FK_PID1 foreign key(product_id) references products(product_id));


-------------inserting values

insert into customers values(1,'John','john@example.com','John','123 Main St,city');
insert into customers values(2,'Jane','jane@example.com','Jane','456 Elm St,Town');
insert into customers values(3,'Robert','robert@example.com','Robert','789 Oak St,Village');
insert into customers values(4,'Sarah','sarah@example.com','Sarah','101 Pine St,Suburb');
insert into customers values(5,'David','david@example.com','David','234 Cedar St,District');
insert into customers values(6,'Laura','laura@example.com','Laura','567 Birch St,Country');
insert into customers values(7,'Michael','michael@example.com','Michael','890 Maple St,State');
insert into customers values(8,'Emma','emma@example.com','Emma','321 Redwood St, Country');
insert into customers values(9,'William','william@example.com','William','432 Spruce St, Province');
insert into customers values(10,'Olivia','olivia@example.com','Olivia','765 Fir St,Territory');


insert into products values(1,'Laptop',800.00,'High-performance laptop',10);
insert into products values(2,'SmartPhone',600.00,'Latest SmartPhone',15);
insert into products values(3,'Tablet',300.00,'Portable Tablet',20);
insert into products values(4,'HaedPhones',150.00,'Noise-cancelling',30);
insert into products values(5,'TV',900.00,'4k Smart Tv',5);
insert into products values(6,'CoffeeMaker',50.00,'Automatic Coffee Maker',25);
insert into products values(7,'Refrigerator',700.00,'Energy-Efficient',10);
insert into products values(8,'MicrowaveOven',80.00,'Countertop Microwave',15);
insert into products values(9,'Blender',70.00,'High-Speed Blender',20);
insert into products values(10,'Vaccum Cleaner',120.00,'Bagless Vacuum Cleaner',10);


insert into cart values(1,1,1,2);
insert into cart values(2,1,3,1);
insert into cart values(3,2,2,3);
insert into cart values(4,3,4,4);
insert into cart values(5,3,5,2);
insert into cart values(6,4,6,1);
insert into cart values(7,5,1,1);
insert into cart values(8,6,10,2);
insert into cart values(9,6,9,3);
insert into cart values(10,7,7,2);


insert into orders values(1,1,'2023-01-05',1200.00,'12E , chennai');
insert into orders values(2,2,'2023-02-10',900.00,'42E , coimbatore');
insert into orders values(3,3,'2023-03-15',300.00,'12R , mumbai');
insert into orders values(4,4,'2023-04-20',150.00,'55K , hyderabad');
insert into orders values(5,5,'2023-05-25',1800.00,'15H , pune');
insert into orders values(6,6,'2023-06-30',400.00,'14S , nepal');
insert into orders values(7,7,'2023-07-05',700.00,'17F ,vellore');
insert into orders values(8,8,'2023-08-10',160.00,'12E , trichy');
insert into orders values(9,9,'2023-09-15',140.00,'I23, salem');
insert into orders values(10,01,'2023-10-20',1400.00,'97B , namakkal');
insert into orders values(11,4,'2022-10-20',1400.00,'55V , Thanjur');


insert into order_items values(1,1,1,2,1600.00);
insert into order_items values(2,1,3,1,300.00);
insert into order_items values(3,2,2,3,1800.00);
insert into order_items values(4,3,5,2,1800.00);
insert into order_items values(5,4,4,4,600.00);
insert into order_items values(6,4,6,1,50.00);
insert into order_items values(7,5,1,1,800.00);
insert into order_items values(8,5,2,2,1200.00);
insert into order_items values(9,6,10,2,240.00);
insert into order_items values(10,6,9,3,210.00);


----------------------------Questions-------------------------------------

-----------1. Update refridgerator product price to 800---
update products set price=800 where pname='Refrigerator';
select * from products;

-----------2.remove all cart items for a specific customer----
delete from cart where customer_id=3;
select * from cart;

-----------3.retrieve product price below $100----------------
select format(price,'C','en-us'),* from products where price<$100;

--------------4.find product with stock quantity greater than 5----
select * from products;
select pname from products where stockQuantity >5;

------------6.find products which name end with r----
select * from products where pname like '%r';
select * from products;

-----------7.Retrieve cart items for the customer 5---------------
select * from cart where customer_id=5;

----------8.find customers who placed orders in 2023------------------------
select * from orders;
select * from customers;
select customer_id,order_date from orders where year(order_date)=2023;

------------9.determine the minimum stockquantity for each product category------------
select * from products;
select min(p1.stockQuantity)as Minimum from products p1 join products p2
on p1.product_id=p2.product_id where p1.product_id=p2.product_id;

------------10.calculate the total amount spend by each customer----
select * from customers;
select * from orders;
select sum(o.total_price)As AmountSpend,c.cname,c.customer_id from customers c
join orders o on c.customer_id=o.customer_id group by c.cname,c.customer_id;

----------------11.find the average order amount for each customer----
select avg(o.total_price)As AverageAmount,c.cname,c.customer_id from customers c
join orders o on c.customer_id=o.customer_id group by c.cname,c.customer_id;

------------12.count the number of orders placed by each customer-----------------
select c.cname,c.customer_id,count(o.order_id)As TotalCount from customers c
join orders o on c.customer_id=o.customer_id group by c.cname,c.customer_id;
select * from orders;

------------13.find the maximun order amount for each customer----------------
select c.cname,c.customer_id,max(o.total_price) from customers c
join orders o on c.customer_id=o.customer_id 
where c.customer_id=o.customer_id group by c.cname,c.customer_id;

-------------14.get customers who placed orders totaling over $1000-------------------
select format(Total_price,'C','en-us')as Price,c.* from orders o join 
customers c on o.customer_id=c.customer_id where total_price>$1000;

-----------------15.subquery to find products not in the cart-----------------
select * from cart;
select product_id ,pname from products where product_id not in 
(select product_id from cart); 

------------16.subquery to find customer who haven't placed order--------------------
select customer_id ,cname from customers where customer_id not in (select customer_id 
from orders);

------------17.subquery to calculate the percentage of total revenue for a product---------------s
elect p.product_id,p.pname,(o.total_price-p.price)/100.00 as Revenue into AvgRevenue1  from products p join
cart c on p.product_id=c.product_id join orders o on c.customer_id=o.customer_id ;
select sum(Revenue) from AvgRevenue1 ;


-----------18.subquery to find the products with low stock---------------------
select product_id, pname from products where stockquantity=(
select top 1 stockquantity from products order by stockquantity asc);

------------19.subquery to find customers who placed high value orders----------------------
select c.customer_id ,c.cname,o.total_price from customers c join orders o
on c.customer_id=o.customer_id where o.total_price=all(select max(total_price) from orders);
