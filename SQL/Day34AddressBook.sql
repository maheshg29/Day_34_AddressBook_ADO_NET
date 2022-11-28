create database AddressBook_Day34

create table AddressBook_day34_table
(
FirstName varchar(255),
LastNames varchar(255), 
Address varchar(255), 
City varchar(255),
State varchar(255),
Zip int, 
PhoneNumber varchar(15),
Email varchar(100)
)

insert into AddressBook_day34_table(FirstName,LastNames,Address,City,State,Zip,PhoneNumber,Email)
values
('mahesh','g','9b nagar','nashik','maharashtra',424008,'9812345678','gagag@gmail.com');
select * from AddressBook_day34_table