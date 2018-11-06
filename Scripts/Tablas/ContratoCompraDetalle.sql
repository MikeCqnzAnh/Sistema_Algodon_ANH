create table ContratoCompraDetalle(
IdContratoAlgodonDetalle int not null primary key identity(1,1),
IdContratoAlgodon int,
IdLote int,
SuperficieContratada float
)