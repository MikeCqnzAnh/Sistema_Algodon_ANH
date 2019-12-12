Create Table PaqueteMatExt
(
IdPaquete int Primary key identity(1,1),
LotId int,
BaleId int,
IdOrdenTrabajo int,
BarkLevel1 float,
BarkLevel2 float,
PrepLevel1 float,
PrepLevel2 float,
OtherLevel1 float,
OtherLevel2 float,
PlasticLevel1 float,
PlasticLevel2 float
)