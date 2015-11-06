create Database HomeworkOnP
go
use HomeworkOnP;

/*Login table*/
--create Table lLogin(
--id int identity(1,1) primary key(id),
--username varchar(20) not null,
--pass varchar(20) not null
--);

/*Assignement table*/
create Table Assignement(
aid int identity(1,1) primary key(aid),
subject varchar(20) not null,
title varchar(20) not null,
date varchar(20) not null,
deadline varchar(20) not null,
tid int not null
);

/*User table*/
create Table WebUser(
wid int identity(1,1) primary key(wid),
name varchar(20) not null,
phone int not null,
email varchar(20) not null,
password varchar(20) not null,
userType int not null
);

/*Child table*/
create Table Child(
id int  primary key (id) references WebUser(wid) on delete cascade on update cascade not null,
--cid int identity(1,1) primary key(cid),
grade varchar(20) not null
--uid int not null
);

/*Teacher table*/
create Table Teacher(
id int  primary key (id) references WebUser(wid) on delete cascade on update cascade not null,
--tid int identity(1,1) primary key(tid),
subject varchar(20) not null,
--uid int not null
);

/*Booking table*/
create Table Booking(
bid int identity(1,1) primary key(bid),
date varchar(20) not null,
time varchar(20) not null,
tid int not null,
cid int not null
);
