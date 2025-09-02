Create table FacturasDetalle
(
IdFacturaDetalle int identity(1,1),
IdFacturaEncabezado int,
ClaveProdServ int,
NoIdentificacion varchar(100),
Cantidad decimal,
ClaveUnidad varchar(3),
Unidad varchar(15),
Descripcion varchar(1000),
ValorUnitario decimal,
SubTotal decimal,
Importe decimal,
FechaCreacion datetime,
FechaActualizacion datetime
)