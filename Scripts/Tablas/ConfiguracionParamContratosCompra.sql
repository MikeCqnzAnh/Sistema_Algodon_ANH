Create table ConfiguracionParamContratosCompra
(
IdConfiguracion int primary key identity(1,1),
ParamDia1 int,
ParamMes1 varchar(15),
ParamTemp1 int,
ParamMes2 varchar(15),
ParamTemp2 int,
ParamMes3 varchar(15),
ParamPrompesomin decimal(18,2),
ParamPrompesomax decimal(18,2),
ParamPesomin decimal(18,2),
TemporadaAnual int,
FechaCreacion datetime,
FechaActualizacion datetime
)