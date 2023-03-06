create table InformeCondicionesProd
(
idinforme int primary key identity(1,1),
idproduccionenc int,
descripcion varchar(100)
)
go
create table informeproduccionborra
(
idinforme int primary key identity(1,1),
idproduccionenc int,
baleid bigint unique
)
go
create table informeincendios
(
idinforme int primary key identity(1,1),
idproduccionenc int,
baleidsiniestrada bigint unique,
baleidant1 bigint,
baleidant2 bigint,
baleidpos1 bigint,
baleidpos2 bigint
)
go
create table informetiempomuerto
(
idinforme int primary key identity(1,1),
idproduccionenc int,
descripcion varchar(100)
)
go
create table informecorrecciones
(
idinforme int primary key identity(1,1),
idproduccionenc int,
descripcion varchar(100)
)
go
create table informeprogramacionmantenimiento
(
idinforme int primary key identity(1,1),
idproduccionenc int,
descripcion varchar(100)
)
go
create table informeobservaciones
(
idinforme int primary key identity(1,1),
idproduccionenc int,
descripcion varchar(100)
)