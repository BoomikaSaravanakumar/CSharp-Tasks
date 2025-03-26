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
insert into Courier values(011,'Logi','18R-Ganga street,Trichy','kani','15L-West street,Mumbai',7.4,'Delayed','TR1934','2025-03-30');

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

----------------------------------------------Task 2-----------------------------

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


--------------------------------------------Task 3----------------------------------------------------

select *from employee;
select * from courier_user;
select * from courier;
select * from payment;
select * from location_customer;
select * from courierservices;
--------14.find total no of couriers handled by each employee---------
select * from employee;
select * from courier;
this doesnot exist 
--------------15.calculate total revenue generated by each location---
select distinct avg(p.amount)as Revenue,
l.LocationName from location_customer l join payment p
on l.Ulocationid = p.Ulocationid group by locationname;

------------16.find the total no of couriers delivered to each location---------
select distinct count(p.courierid)as total_count,
l.locationname from location_customer l join payment p
on l.Ulocationid=p.Ulocationid group by locationname ;

-------------17.find the courier with highest average delivery time------------
select datediff(day,deliverydate,getdate())as deliverytime,deliverydate from courier ;

------------18.find locations with total payment less than a certain amount-------
select distinct sum(p.amount)as Revenue,
l.LocationName from location_customer l join payment p
on l.Ulocationid = p.Ulocationid  where p.amount<1000 group by locationname;

------------19.calculate total payments per location------
select count(p.paymentid),l.locationname from payment p
join location_customer l  on p.Ulocationid=l.ulocationid 
group by l.locationname;

------------20.Retrieve couriers who have received payments totaling more than $1000
---in a specific location (LocationID = X):
select p.courierid,FORMAT (amount, 'C', 'en-us')as Amount from payment p
join location_customer l on p.ulocationid=l.ulocationid 
where amount>=$1000 and p.ulocationid=29;

select courierid,FORMAT (amount, 'C', 'en-us')as Amount from payment  
where Amount>$1000 and ulocationid=
(select ulocationid from location_customer where ulocationid=30);

-------------21.Retrieve couriers who have received payments totaling
----more than $1000 after a certain date (PaymentDate > 'YYYY-MM-DD'):  
select courierid,FORMAT (amount, 'C', 'en-us')as Amount,paymentdate from payment 
where Amount>$1000 and paymentdate>='2025-03-18';

select count(courierid)as count_id,FORMAT (amount, 'C', 'en-us')as Amount,
paymentdate from payment where Amount>$1000 and 
paymentdate>='2025-03-18' group by amount,paymentdate;

---------------22.Retrieve locations where the total amount received is more than $5000
-----before a certain date (PaymentDate > 'YYYY-MM-DD')  
select l.locationname ,FORMAT (p.amount, 'C', 'en-us')as Amount ,
sum(p.Amount)as Total from location_customer l
join payment p on l.ulocationid=p.ulocationid where p.amount>$5000 
group by l.locationname,p.amount;

select l.locationname ,FORMAT (p.amount, 'C', 'en-us')as Amount ,
sum(p.Amount)as Total from location_customer l
join payment p on l.ulocationid=p.ulocationid  group by l.locationname,p.amount;


----------------------------------Task 4-----------------------------

------------------23. Retrieve Payments with Courier Information-----------
select p.amount,p.paymentid,c.* from payment p right join 
courier c on p.courierid=c.courierid;

select c.*,p.amount from courier c left join payment p
on p.courierid=c.courierid;

------------24.Retrieve Payments with Location Information 
select p.amount,p.paymentid,l.* from payment p right join
location_customer l on p.ulocationid=l.ulocationid;

-----------25.Retrieve Payments with Courier and Location Information  --------
select p.amount,p.paymentid,l.*,c.* from location_customer l 
right join payment p on l.ulocationid=p.ulocationid
join courier c on p.courierid=c.courierid;

---------26. List all payments with courier details--------
select p.*,c.* from payment p full outer join  courier c
on p.courierid=c.courierid;

------------27.Total payments received for each courier  
select  distinct courierid , sum(amount)as total  from payment 
where courierid between 1 and 10 group by courierid;

select sum(amount)as total from payment 
where courierid between 1 and 10;

------------28.List payments made on a specific date -----
select datepart(day,paymentdate),paymentid from payment
where paymentdate='2025-03-27';

---------------29.Get Courier Information for Each Payment 
select c.* ,p.Amount,p.paymentid from courier c join payment p
on c.courierid=p.courierid;

-------------30.Get Payment Details with Location  
select p.*,l.locationname from payment p join location_customer l
on p.ulocationid=l.ulocationid;

---------------------31.Calculating Total Payments for Each Courier  
select distinct courierid ,sum(amount)as total from payment
where courierid between 1 and 10 group by courierid;

---------------32.. List Payments Within a Date Range 
select paymentid,paymentdate from payment where 
paymentdate between '2025-03-15' and '2025-03-28';

-------------33. Retrieve a list of all users and their corresponding courier records,
---------including cases where there are no matches on either side  
select u.userid ,u.cname,c.* from courier_user u join 
courier c on u.cname=c.receivername;

select u.userid ,u.cname,c.*,
case 
when u.userid is not null then u.userid
when c.courierid is not null then c.courierid
when u.cname is not null then c.receivername
else 'not found'
end as 'list'
from courier_user u ,courier c;

------------------34.Retrieve a list of all couriers and 
--their corresponding services, including cases where there are no matches on either side
select * from courier;
select * from courierservices;
cannot be retrived as there are no matching columns available

 -------------35.Retrieve a list of all employees and
 --their corresponding payments, including cases where 
 --there are no matches on either side
 select p.paymentid ,p.amount,e.employeeid,
 case 
 when p.paymentid is not null then p.paymentid
when e.employeeid is not null then e.employeeid
else 'not found'
end as 'list'
from payment p , employee e;

----------36.List all users and all courier services, showing all possible combinations. 
select u.cname, c.courierid from courier_user u
join courier c on u.cname=c.receivername;

----------37.List all employees and all locations, showing all possible combinations:
select * from employee;
select * from Location_Customer;
no matching columns

-------------38. Retrieve a list of couriers and their corresponding sender information (if available) 
select * from courier;
select courierid,sendername,senderaddress from courier ;

-----------------39.Retrieve a list of couriers and their corresponding receiver information (if available):  
select courierid,receivername,receiveraddress from courier ;

------------------------40.Retrieve a list of couriers along with the courier service details (if available):
select * from courier;
select * from courierservices;
no matching columns exist

--------------41. Retrieve a list of employees and the number of couriers assigned to each employee:
select * from employee;
select * from courier;
no matching columns

----------42.Retrieve a list of locations and the total payment amount received at each location:
select distinct l.locationname , sum(p.amount)as total  from location_customer l
join payment p on l.ulocationid=p.ulocationid group by l.locationname;

----------------43.Retrieve all couriers sent by the same sender (based on SenderName).  
select distinct s.sendername,c.courierid from courier c join courier s 
on c.sendername=s.sendername where c.sendername=s.sendername;

-------------44.List all employees who share the same role.  
select distinct e.employeeid , e.erole from employee e join employee s
on e.erole=s.erole where  e.employeeid!=s.employeeid order by Erole asc; 

------------45. Retrieve all payments made for couriers sent from the same location.
select distinct l.locationname, sum(p.amount)as Payment from location_customer l
join payment p 
on p.ulocationid=l.ulocationid group by l.locationname ;

------------46.Retrieve all couriers sent from the same location (based on SenderAddress).  
select *
from Courier
where SenderAddress =(
    select SenderAddress
    from Courier
    group by SenderAddress
    having count(*) > 1
);---------doubt-----

------------47. List employees and the number of couriers they have delivered:  
select * from courier;
select * from employee;
no matching columns

----------48. Find couriers that were paid an amount greater than the cost of their respective courier services  
select * from courier;
select * from courierservices;
select * from payment;
no matching columns


------------------------49.find cpuriers that have a  weight greater than the average weight of all courier
select courierid, cou_weight from courier where cou_weight>=
(select avg(cou_weight) from courier) ;
select avg(cou_weight) from courier;

-------------------50. Find the names of all employees who have a salary greater than the average salary:  
select ename,employeeid,salary from employee where
salary>=(select avg(salary) from employee);
select avg(salary) from employee;

---------------------51. Find the total cost of all courier services where the cost is less than the maximum cost  
select sum(amount) from payment where exists (select courierid,amount from payment where 
amount<(select max(amount) from payment)) ;

-------------------52. Find all couriers that have been paid for  
select courierid,paymentdate from payment where paymentdate<=getdate();
select * from courier;

----------------53. Find the locations where the maximum payment amount was made  
select distinct l.locationname from location_customer l join payment p
on l.ulocationid=p.ulocationid where p.amount=(select max(p.amount) from payment) group by l.locationname;----doubt

----------------54. Find all couriers whose weight is greater than the weight of all couriers sent by a specific sender (e.g., 'SenderName'): 
select cou_weight from courier where cou_weight>=(select sum(cou_weight) from courier  where sendername='Logi');
select cou_weight from courier where cou_weight>=(select sum(cou_weight) from courier  where sendername='Dheepsh');