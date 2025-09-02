Create Table IntegracionCompra
(
IdIntegracionCompra int primary key identity(1,1),
IdContrato int,
IdCompra int,
IdProductor int,
ImporteFacturas decimal,
TotalToneladasFacturas decimal,
TotalPacasFacturas decimal,
FechaCreacion datetime,
FechaActualizacion datetime
)