create table EmbarqueEncabezado
(
	idembarqueencabezado int primary key identity(1,1),
	idcomprador int,
	nombrechofer varchar(80),
	nolicencia varchar(15),
	telefono varchar(17),
	folio varchar(15),
	placatractocamion varchar(15),
	placacaja varchar(15),
	destino varchar(80),
	observaciones varchar(150),
	totalpacas int,
	totalkilos decimal(18,4),
	idestatus int,
	fechacreacion datetime,
	fechaactualizacion datetime
)