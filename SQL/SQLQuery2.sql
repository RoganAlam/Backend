Create database S1DBM02;

use S1DBM02;

Create table Docenten
(
	DocentenId int primary key identity(1,1),
	Voornaam varchar(50),
	Achternaam varchar(50),
	Leeftijd int,
)

Create table SLBer
(
	slbId int,
	Voornaam varchar(50),
	Achternaam varchar(50),
	leeftijd int,
	foreign key (slbId) references Studenten(Id),
)

Create table Studenten
(
	Id int primary key identity(1,1),
	Voornaam varchar(50),
	Achternaam varchar(50),
	leeftijd int,
	DocentenId int,
	foreign key (DocentenId) references Docenten(DocentenId),
)

Create table Vakken
(
	Vak varchar(50),
	foreign key (Cijfers) references Cijfers(Cijfers),
)

Create table Cijfers
(
	Cijfers decimal(2,1), 
	DocentenId int,
	StudentenId int,
	foreign key (DocentenId) references Docenten(DocentenId),
	foreign key (StudentenId) references Studenten(Id),
)


