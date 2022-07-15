create table TurnosEnc
(
IdTurnoenc int primary key identity(1,1),
Descripcion varchar(40),
IdPlanta int,
Horaentrada time,
Horasalida time
)