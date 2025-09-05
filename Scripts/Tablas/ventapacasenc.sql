create table ventapacasenc
(
idventa int primary key identity(1,1),
idplanta int,
idcomprador int,
idcontrato int,
tara decimal(6,2),
checktara bit,
totalpacas int,
subtotal money,
castigomic money,
castigoresistencia money,
castigouhml money,
castigoui money,
deduccion money,
totalprecio money,
fechacreacion datetime,
fechaactualizacion datetime,
idestatus int
)