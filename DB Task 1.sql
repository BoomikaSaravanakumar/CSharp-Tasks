--creating database cms
create database CMS;
use CMS;

--Creating Table User
create table Courier_User(UserID int constraint pk_user_id primary key,Cname varchar(255),
Email varchar(255) Unique,UPassword varchar(255),ContactNumber varchar(20), UAddress text);

----Inserting values in User Table
insert into Courier_User values(1,'Aalin','aalin@gmail.com','aalin_1','6547018930','12E-NK street,Chennai');
insert into Courier_User values(2,'Jeni','jeni@gmail.com','jeni_2','6542318923','10B-Gandhi street,Vellor');
insert into Courier_User values(3,'Jabil','jabil@gmail.com','Jabil_3','6754578217','122K-Kaveri street,Coimbatore');
insert into Courier_User values(4,'Khan','khan@gmail.com','Khan_4','9845372314','45A-MD street,Chennai');
insert into Courier_User values(5,'Sundar','sundar@gmail.com','Sundar_5','6389342510','352-Ganga street,karnataka');
insert into Courier_User values(6,'Mali','mali@gmail.com','Mali_6','9734267435','12E-East street,Pune');
insert into Courier_User values(7,'Aishu','aishu@gmail.com','Aishu_7','9342556783','133E-South street,Salem');
insert into Courier_User values(8,'Kavi','kavi@gmail.com','Kavi_8','6542167329','19N-Nehru street,Madurai');
insert into Courier_User values(9,'Naren','naren@gmail.com','Naren_9','9054372514','175D-Yamuna street,Namakkal');
insert into Courier_User values(10,'Prabu','prabu@gmail.com','Prabu_10','6594563780','15L-West street,Mumbai');

---Select command for User Table
select * from Courier_User;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='Courier_User' ;


--creating Courier Table
create table Courier(CourierID int constraint pk_courier_id primary key,SenderName varchar(255),SenderAddress text,
ReceiverName varchar(255),ReceiverAddress text,Cou_Weight decimal(5,2) ,Cou_Status varchar(50), 
TrackingNumber varchar(20) Unique,DeliveryDate Date);

--Inserting Values in Courier Table
insert into Courier values(001,'Linga','18/3 Kumuran street,Chennai','Aalin','12E-NK street,Chennai',2.5,'dispatched','TR001_Nk','2025-03-27');
insert into Courier values(002,'Saran','13-Cross street,Kallakurichi','Jeni','10B-Gandhi street,Vellor',4.5,'delivered','TR0675','2025-03-22');
insert into Courier values(003,'Karthi','18S-Kathiboard Street,Madurai','Jabil','122K-Kaveri street,Coimbatore',8.2,'Ready for Pickup','TR8950','2025-04-15');
insert into Courier values(004,'Kalai','34-Anna street,Krishnagiri','Khan','45A-MD street,Chennai',3.7,'Ready for Pickup','TR00784','2025-04-05');
insert into Courier values(005,'Hari','125-Devi street,Thanjur','Sundar','352-Ganga street,karnataka',5.5,'dispatched','TR893','2025-03-20');
insert into Courier values(006,'Kowsi','62A-Tnagar,Chennai','Mali','12E-East street,Pune',6.8,'Delayed','TR007-A','2025-03-31');
insert into Courier values(007,'Dharsh','155E-Kaveri street,Coimbatore','Aishu','133E-South street,Salem',2.9,'dispatched','TR090','2025-03-17');
insert into Courier values(008,'Mani','45E-Jai street,Chennai','Kavi','19N-Nehru street,Madurai',3.0,'Out for Delivery','TR066','2025-03-25');
insert into Courier values(009,'Dheepsh','9F-Kurinji street,Tirunelveli','Naren','175D-Yamuna street,Namakkal',2.0,'dispatched','TR0775','2025-03-19');
insert into Courier values(010,'Logi','18R-Ganga street,Trichy','Prabu','15L-West street,Mumbai',7.4,'Delayed','TR196','2025-03-29');

--Select command for Courier Table
select * from Courier;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='Courier' ;


--creating courierservices table
create table CourierServices(ServiceID int constraint pk_sid primary key,ServiceName varchar(100),Cost decimal(8,2));

--inserting values for CourierService table
insert into CourierServices values(101,'Fast',100.00);
insert into CourierServices values(102,'Normal',175.00);
insert into CourierServices values(103,'Fast',225.95);
insert into CourierServices values(104,'Slow',180.00);
insert into CourierServices values(105,'Fast',200.00);
insert into CourierServices values(106,'Normal',225.25);
insert into CourierServices values(107,'Fast',200.00);
insert into CourierServices values(108,'Slow',250.00);
insert into CourierServices values(109,'Normal',125.00);
insert into CourierServices values(110,'Slow',266.00);

--Select command for CourierService Table
select * from CourierServices;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='courierServices' ;

--creating table for employee
create table Employee(EmployeeID int constraint pk_Eid primary key, EName varchar(255),Eemail varchar(255) Unique,
ContactNumber varchar(20),ERole varchar(50),Salary decimal(10,2));

--inserting values for Employee Table
insert into Employee values(1001,'Rasiga','rasi@gmail.com','9087634256','Dispatcher',20000);
insert into Employee values(1002,'Kalki','kalki@gmail.com','9065437628','Customer Service Manager ',25000);
insert into Employee values(1003,'Yuva','yuva@gmail.com','6534728922','Branch Manager',70000);
insert into Employee values(1004,'Nithu','nithu@gmail.com','6756908734','Supervisor',50000);
insert into Employee values(1005,'Poorni','poorni@gmail.com','9764538873','Dispatcher',20000);
insert into Employee values(1006,'Ragavi','ragavi@gmail.com','9345761299','Delivery Agent',30000);
insert into Employee values(1007,'Bhuvi','bhuvi@gmail.com','6954201887','Route Planner',15000);


--Select command for Employee Table
select * from Employee;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='Employee' ;

--creating table for location
create table Location_Customer(ULocationID int constraint pk_loc primary key,LocationName varchar(100), Cus_Address text);

--Inserting values for Location Table
insert into Location_Customer values(21,'Chennai','12E-NK street,Chennai');
insert into Location_Customer values(22,'Vellore','10B-Gandhi street,Vellor');
insert into Location_Customer values(23,'Coimbatore','1122K-Kaveri street,Coimbatore');
insert into Location_Customer values(24,'Chennai','45A-MD street,Chennai');
insert into Location_Customer values(25,'Karnataka','352-Ganga street,karnataka');
insert into Location_Customer values(26,'Pune','12E-East street,Pune');
insert into Location_Customer values(27,'Salem','133E-South street,Salem');
insert into Location_Customer values(28,'Madurai','19N-Nehru street,Madurai');
insert into Location_Customer values(29,'Namakkal','175D-Yamuna street,Namakkal');
insert into Location_Customer values(30,'Mumbai','15L-West street,Mumbai');


--Select command for Location table
select * from Location_Customer;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='Location_Customer' ;


--creating a table for payment
create table Payment(PaymentID int constraint pk_pay_id primary key,CourierID int ,ULocationID int ,Amount decimal(10,2),
PaymentDate Date,constraint fk_cid Foreign Key (CourierID) References Courier(CourierID),
constraint fk_loc_id Foreign Key (ULocationID) References Location_Customer(ULocationID));


--Inserting values for payment table
insert into Payment values(3001,001,21,250.00,'2025-03-25');
insert into Payment values(3002,002,22,335.00,'2025-03-20');
insert into Payment values(3003,003,23,2450.00,'2025-04-12');
insert into Payment values(3004,004,24,452.00,'2025-04-01');
insert into Payment values(3005,005,25,666.00,'2025-03-18');
insert into Payment values(3006,006,26,719.00,'2025-03-28');
insert into Payment values(3007,007,27,945.00,'2025-03-27');
insert into Payment values(3008,008,28,1000.00,'2025-03-22');
insert into Payment values(3009,009,29,2500.00,'2025-03-15');
insert into Payment values(3010,010,30,4250.00,'2025-03-27');

---Select command for Payment Table
select * from Payment;
select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where table_name='Payment' ;

-----1.list all the customers-----
select cname,UserID from  Courier_User;
----2.list all the orders for a specific customer---------
select courierID from courier where Receivername='Naren';
-----3.list all the couriers-----
select courierID from Courier;
Select courierID from courier order by courierID ASC;
-----4.list all the packages for a specific order-------
select cou_weight,courierID from courier where courierid=3;
select cou_weight,courierID from courier where courierid=10;
-------5.list all the deliveries for a specific order---
select receivername,receiveraddress,courierid from courier where courierid=10;
------6.list all the undelivered packages----
select courierid,Receivername,cou_status from courier where cou_status!='delivered';
------7.list all the packages that are scheduled for delivery today----
select courierid from courier where DeliveryDate=getdate();
----8.list all the packages for a specific status----
select courierid,receivername,cou_status from courier where cou_status='dispatched';
---------9.calculate total no of packages for each courier----
select count(courierid) from courier where courierid between 1 and 10;
----------10.find the average delivery time for each courier--------
select count(deliverydate) from courier where courierId between 1 and 10
and deliverydate>=getdate();
-----11.list all the packages for a specific weight range---
select courierid,cou_weight from courier where  cou_weight between 2.00 and 5.50;
----12.retrieve employees whose names contains 'john'-----
select ename from employee where ename='john';
---13.retrieve all couriers with payments greater than $50-----
select courierid,paymentid,FORMAT (amount, 'C', 'en-us')from payment where amount>=$50;
