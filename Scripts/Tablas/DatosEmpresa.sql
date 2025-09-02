CREATE TABLE DatosEmpresa
(
IdDatosEmpresa int primary key identity(1,1),
RazonSocial varchar(60),
RFCEmpresa varchar(13),
RepresentanteLegal varchar(50),
RFCRepresentante varchar(13),
Calle varchar(40),
NumExt varchar(10),
NumInt varchar(10),
EntreCalle1 varchar(40),
EntreCalle2 varchar(40),
Colonia varchar(40),
Referencia varchar(40),
Poblacion varchar(40),
CodigoPostal varchar(6),
Pais varchar(25),
Estado varchar(25),
Municipio varchar(25),
LugarExpedicion varchar(40)
)
