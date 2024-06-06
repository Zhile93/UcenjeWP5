use master;
go
drop database if exists Opcine;
go
create database Opcine;
go
use Opcine;

create table Nacelnici(
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
datumrodjenja datetime, 
);

delete from 