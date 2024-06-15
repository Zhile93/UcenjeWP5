create database ZavrsniradFondovi;
use ZavrsniradFondovi;

create table Fond (
sifra int,
naziv varchar (100),
iznos_sredstava decimal (20,2),
broj_projekata int,
u_provedbi_do datetime
);


create table Javni_poziv (
sifra int, 
naziv varchar (100),
iznos_sredstava decimal (20,2),
stopa_sufinanciranja int,
traje_do datetime,
fond int primary key
);


create table Projekt (
sifra int,
javni_poziv int primary key,
iznos_sredstava decimal (20,2),
stopa_sufinanciranja int,
u_provedbi bit,
korekcije decimal (18,2),
manager varchar (50),
provedbeno_tijelo varchar (100)
);