Create Table RevisionProdParametros
(
IdRevision int primary key identity(1,1),
IdProduccion int unique,
FlagRevisado bit
)