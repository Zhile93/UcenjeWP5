use master;
go
drop database if exists ZavrsniradFondovi;
go
create database ZavrsniradFondovi collate Croatian_CI_AS;
go
use ZavrsniradFondovi;


create table Fond (
sifra int not null primary key identity(1,1),
naziv varchar (100) not null,
iznos_sredstava decimal (20,2),
broj_projekata int,
u_provedbi_do datetime
);


create table Javni_poziv (
sifra int not null primary key identity(1,1),
naziv varchar (100) not null,
iznos_sredstava decimal (20,2),
stopa_sufinanciranja int,
traje_do datetime,
fond int references fond(sifra)
);