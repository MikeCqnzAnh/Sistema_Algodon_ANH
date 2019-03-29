Create Procedure Sp_InsertaBitacora
@Fecha datetime,
@Computadora varchar(30),
@DireccionIP varchar(15),
@IdUsuario int,
@Usuario varchar(15),
@Modulo varchar(50),
@Opcion varchar(20),
@Operacion varchar(100),
@Observaciones varchar(max)
as
insert into BitacoraSistema
(
fecha,
computadora,
direccionip,
idusuario,
usuario,
modulo,
opcion,
operacion,
observaciones
)
values
(
@Fecha ,
@Computadora ,
@DireccionIP ,
@IdUsuario ,
@Usuario ,
@Modulo ,
@Opcion ,
@Operacion ,
@Observaciones 
)