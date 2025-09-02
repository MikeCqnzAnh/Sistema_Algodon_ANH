Create table ResistenciaDetalle
(
IdModoDetalle int primary key identity(1,1),
IdModoEncabezado int,
Rango1 decimal(6,2),
Rango2 decimal(6,2),
Castigo decimal(6,2),
IdEstatus int
)