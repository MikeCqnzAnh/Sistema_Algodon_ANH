Create Table PerfilUsuario
(
IdPerfilUsuario integer primary key identity(1,1),
IdUsuario int,
IdNodo int,
IdPadre int,
IdTipo int,
IdEstatus bit
)