create table ConfiguracionParametros
(
IdConfiguracion int identity(1,1) primary key,
NombrePC varchar(30),
DireccionIP varchar(15),
NombrePuerto varchar(6),
InicialModulo int,
NoCaracterModulo int,
InicialTransporte int,
NoCaracterTransporte int,
InicialBoletasBruto int,
NoCaracterBoletasBruto int,
InicialBoletasTara int,
NoCaracterBoletasTara int,
InicialBoletasNeto int,
NoCaracterBoletasNeto int,
InicialPacas int,
NoCaracteresPacas int,
BaseDeDatos varchar
)