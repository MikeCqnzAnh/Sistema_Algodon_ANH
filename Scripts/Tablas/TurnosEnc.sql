drop table TurnosEnc
go
create table TurnosEnc
(   
IdTurnoenc int primary key identity(1,1),
Descripcion varchar(40),
idplanta int,
idResponsableturno int,
responsableturno varchar(40),
idResponsableprensa int,
responsableprensa varchar(40),
Horaentrada time,
Horasalida time
)