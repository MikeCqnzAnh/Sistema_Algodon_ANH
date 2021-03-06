Create table Clientes(
IdCliente int not null primary key identity(1,1),
Socio varchar(100),
Nombre varchar(100) not null,
IdTipoPersona int not null,
RfcFisica varchar(20),
CurpFisica varchar(20),
CalleFisica varchar(30),
NumeroFisica varchar(10),
IdEstadoFisica int, 
IdMunicipioFisica int,
ColoniaFisica varchar(50),
CelularFisica varchar(15),
TelefonoFisica varchar(15),
CorreoFisica varchar(50),
ApoderadoFisica varchar(50),
FolioActa varchar(30),
IdEstadoActa int,
FechaActa datetime,
NotarioActa varchar(30),
RegistroPublicoActa varchar(30),
NumeroActa varchar(30),
LibroActa varchar(30),
FolioMercantil varchar(30),
RfcApoderado varchar(20),
CurpApoderado varchar(20),
IneApoderado varchar(20),
CalleApoderado varchar(30),
IdEstadoApoderado int,
IdMunicipioApoderado int,
TelefonoApoderado varchar(15),
CelularApoderado varchar(15),
CorreoApoderado varchar(50),
IdEstadoMovilizacion int,
IdMunicipioMovilizacion int,
Certificado varchar(30),
Superficie float,
Predio varchar(30),
IdCuentaDe int,
IdUsuarioCreacion int, 
FechaCreacion datetime,
IdEstatus int not null
)