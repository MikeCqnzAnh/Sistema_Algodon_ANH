alter procedure sp_creatablas
as
if OBJECT_ID('usuarios','U') is not null
	drop table usuarios;
create table usuarios
(
IdUsuario int primary key identity(1,1),
Nombre varchar(40),
Usuario varchar(15),
Clave varchar(10),
Tipo int,
ClaveAutorizacion int
)


if OBJECT_ID('TipoUsuario','U') is not null
	drop table TipoUsuario;
create table TipoUsuario
(
IdTipo int primary key identity(1,1),
Descripcion varchar(15)
)
