select * from Slaptable



create table Slaptable(slapid int primary key identity(1,1),
Slap_name varchar (100),
Pay_Group_Code varchar(30),
Slap_Low_value varchar(30),
Slap_High_value varchar(30),
Slap_Percentage float,
Slap_Value varchar(30))


create table SlapDefinition(Slid int primary key identity(1,1),
Short_Name varchar (30),
Pay_Group_Code varchar(30),
Description_s varchar(30),
Status_s varchar(30)

select * from SlapDefinition