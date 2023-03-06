create table incidenciaproduccionenc
(
idincidencia int primary key identity(1,1),
idturnoenc int,
idplanta int,
fechaincidencia datetime,
idresponsableturno int,
idresponsableprensa int,
estatus bit,
fechacreacion datetime,
fechaactualizacion datetime
)