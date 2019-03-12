create table BitacoraSistema
(
IdBitacora int identity(1,1) primary key,
Computadora varchar(30),
DireccionIP varchar(15),
IdUsuario int,
Modulo varchar(50),
Opcion varchar(20),
Operacion varchar(100),
Observaciones varchar(max)
)